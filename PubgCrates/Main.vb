Option Strict Off
Imports Newtonsoft.Json

Public Class Main
    Structure CrateItem
        Public name As String
        Public Collected As Boolean
        Public Price As Double
        Public rarity As Double
        Public rarityColor As Color
    End Structure
    Class Crate
        Public name As String
        Public items As List(Of CrateItem)
    End Class

    Dim Crates As Crate()
    Dim json As String
    Dim SelectedCrate As Crate
    Dim taxes As New Hashtable()
    Const QUERYDELAY As Integer = 3000
    Const FILEPATH As String = "crates.json"
    Const ICONS_DIR As String = "icons\"
    Const URL_JSON As String = "http://steamcommunity.com/market/priceoverview/?currency=3&appid=578080&market_hash_name="
    Const URL_ITEM As String = "https://steamcommunity.com/market/listings/578080/"

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load crates
        json = IO.File.ReadAllText(FILEPATH)
        System.IO.Directory.CreateDirectory("icons")
        Crates = JsonConvert.DeserializeObject(Of Crate())(json)
        For Each crate In Crates
            cmb_Crate.Items.Add(crate.name)
        Next
        lbl_TimeStamp.Text = IO.File.GetLastWriteTime(FILEPATH).ToString("hh:mm dd/MM/yyyy")

        'calculate steam taxes -> key:SellPriceInCent, value:TaxesInCent
        Dim i As Short
        For i = 1 To 200
            Dim temp As Integer = Math.Truncate(Math.Max(0.05 * i, 1))
            temp += Math.Truncate(Math.Max(0.1 * i, 1))
            taxes.Add(temp + i, temp)
        Next

    End Sub


    Private Sub cmb_Crate_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_Crate.SelectionChangeCommitted
        btn_Download.Enabled = False
        SaveData()
        SelectedCrate = Crates(cmb_Crate.SelectedIndex)
        LoadData()

        btn_Download.Enabled = True
        chk_Edit.Visible = True

        UpdateCrateStats()
    End Sub

    Public Function fetchPriceByName(name As String) As Double
        name = name.Replace(" ", "%20")
        Dim webClient As New System.Net.WebClient
        Dim resultJson As String = webClient.DownloadString(URL_JSON & name)
        webClient.Dispose()

        Dim result As Linq.JObject = Linq.JObject.Parse(resultJson)
        Dim strPrice As String = result.Value(Of String)("lowest_price")
        strPrice = strPrice.Substring(0, strPrice.Length - 1).Replace(".", ",").Replace("-", "0")
        Return Double.Parse(strPrice)
    End Function

    Private Sub fetchItemPrice(rowIndex As Integer, Optional wait As Boolean = True)
        With dgv_Items.Item(cPrice.Index, rowIndex)
            Dim oldValue = .Value
            .Value = "Loading..."
            dgv_Items.Refresh()
            'If wait Then Threading.Thread.Sleep(QUERYDELAY)
            Try
                .Tag = fetchPriceByName(dgv_Items.Item(cItem.Index, rowIndex).Value)
                .Value = .Tag & " (" & (.Tag - calculateTaxes(.Tag)) & ")"
                dgv_Items.Item(cPrice.Index, rowIndex).ErrorText = ""

            Catch ex As Exception
                If wait AndAlso ex.Message.Contains("Too Many Request") Then
                    Wait409.oldValue = oldValue
                    Wait409.rowIndex = rowIndex
                    Wait409.ShowDialog(Me)
                Else
                    dgv_Items.Item(cPrice.Index, rowIndex).ErrorText = ex.Message
                    .Value = oldValue
                End If
            End Try
            dgv_Items.Refresh()
        End With
        lbl_TimeStamp.Text = "Remember to Save!"
        lbl_TimeStamp.ForeColor = Color.Red
    End Sub

    Private Function IconPath(itemName As String) As String
        Return ICONS_DIR & SelectedCrate.name & " - " & itemName & ".png"
    End Function

    Private Sub fetchItemIcon(rowIndex As Integer)
        Dim itemName As String = dgv_Items(cItem.Index, rowIndex).Value
        If IO.File.Exists(IconPath(itemName)) Then Exit Sub
        Dim iconUrl As String = ""
        Dim web As New HtmlAgilityPack.HtmlWeb()
        Try
            Dim dom As HtmlAgilityPack.HtmlDocument = web.Load(URL_ITEM & itemName.Replace(" ", "%20"))
            Dim iconUrlNode As HtmlAgilityPack.HtmlNode = dom.GetElementbyId("mypurchase_0_image")
            If iconUrlNode Is Nothing Then
                dgv_Items.Item(cIcon.Index, rowIndex).ErrorText = "IconUrlNode not found"
                Exit Sub
            End If
            iconUrl = dom.GetElementbyId("mypurchase_0_image").GetAttributeValue("src", "")
            If iconUrl = "" Then
                dgv_Items.Item(cIcon.Index, rowIndex).ErrorText = "IconUrl not found"
                Exit Sub
            End If
            Dim webclient As New Net.WebClient
            webclient.DownloadFile(iconUrl, IconPath(itemName))
            Dim icon As Bitmap = New Bitmap(IconPath(itemName))
            dgv_Items.Item(cIcon.Index, rowIndex).Value = icon

            dgv_Items.Item(cIcon.Index, rowIndex).ErrorText = ""
        Catch ex As Exception
            dgv_Items.Item(cIcon.Index, rowIndex).ErrorText = ex.Message
        End Try
    End Sub

    Public Function calculateTaxes(sellPrice As Double) As Double
        Dim cent As Integer = CInt(sellPrice * 100)
        Dim temp As Double
        If cent > 230 Then
            temp = Math.Ceiling(cent / 1.15)
            temp = temp / 100
            Return sellPrice - temp
        End If
        calculateTaxes = taxes.Item(cent)
        calculateTaxes = taxes(cent)
        Return taxes.Item(cent) / 100
    End Function

    Private Sub UpdateCrateStats()
        'crate value
        Dim CrateValue As Double = 0
        Dim CrateRarity As Double = 0
        Dim TotalPrice As Double = 0
        Dim remainingPrice As Double = 0
        For Each row As DataGridViewRow In dgv_Items.Rows
            CrateValue += (row.Cells(cPrice.Index).Tag - calculateTaxes(row.Cells(cPrice.Index).Tag)) * row.Cells(cRarity.Index).Value
            CrateRarity += row.Cells(cRarity.Index).Value
            TotalPrice += row.Cells(cPrice.Index).Tag
            If row.Cells(cCollected.Index).Value = False Then remainingPrice += row.Cells(cPrice.Index).Tag
        Next
        CrateValue = CrateValue / CrateRarity
        txt_CrateValue.Text = CrateValue
        cRarity.HeaderText = "Rarity (SumOfWeights:" & CrateRarity & ")"

        'sell at
        Dim taxCents As Double = Math.Truncate(Math.Max(0.05 * CrateValue, 0.01) * 100)
        taxCents += Math.Truncate(Math.Max(0.1 * CrateValue, 0.01) * 100)
        txt_SellAt.Text = Math.Round(CrateValue + taxCents / 100, 2)

        'collection
        txt_CollectionTotalPrice.Text = TotalPrice
        txt_CollectionRemainingPrice.Text = remainingPrice


    End Sub

    Public Function ChooseForeColor(backcolor As Color) As Color
        If backcolor.GetBrightness > 0.5 Then
            Return Color.Black
        Else
            Return Color.White
        End If
    End Function

    Private Sub LoadData(Optional clearDGV As Boolean = True)
        If SelectedCrate.items Is Nothing Then Exit Sub
        If clearDGV Then dgv_Items.Rows.Clear()
        Dim index As Integer
        For Each item In SelectedCrate.items
            index = dgv_Items.Rows.Add({item.Collected, Nothing, item.name, 0, item.rarity})
            dgv_Items.Item(cRarity.Index, index).Style.BackColor = item.rarityColor
            dgv_Items.Item(cRarity.Index, index).Style.ForeColor = ChooseForeColor(item.rarityColor)
            dgv_Items.Item(cPrice.Index, index).Tag = item.Price
            dgv_Items.Item(cPrice.Index, index).Value = item.Price & " (" & (item.Price - calculateTaxes(item.Price)) & ")"
            If IO.File.Exists(IconPath(item.name)) Then
                dgv_Items.Item(cIcon.Index, index).Value = New Bitmap(IconPath(item.name))
            End If
        Next
    End Sub
    Private Sub SaveData()
        If SelectedCrate Is Nothing Then Exit Sub
        Dim bufItems As New List(Of CrateItem)
        For Each row As DataGridViewRow In dgv_Items.Rows
            bufItems.Add(New CrateItem With {
                .name = row.Cells(cItem.Index).Value,
                .Collected = row.Cells(cCollected.Index).Value,
                .Price = row.Cells(cPrice.Index).Tag,
                .rarity = row.Cells(cRarity.Index).Value,
                .rarityColor = row.Cells(cRarity.Index).Style.BackColor})
        Next
        SelectedCrate.items = bufItems
    End Sub

    Private Sub SaveOnFile() Handles btn_Save.Click
        SaveData()
        Dim json As String = JsonConvert.SerializeObject(Crates)
        IO.File.WriteAllText(FILEPATH, json)
        lbl_TimeStamp.Text = IO.File.GetLastWriteTime(FILEPATH).ToString("hh:mm dd/MM/yyyy")
        lbl_TimeStamp.ForeColor = Color.Black
        UpdateCrateStats()
    End Sub


    Private Sub btn_Download_Click(sender As Object, e As EventArgs) Handles btn_Download.Click
        prog_Load.Maximum = dgv_Items.Rows.Count
        prog_Load.Value = 0
        prog_Load.Visible = True
        Me.Enabled = False
        Dim firstIndex As Integer = 0
        If dgv_Items.SelectedCells.Count > 0 Then
            firstIndex = dgv_Items.SelectedCells(0).RowIndex
        End If
        For Each row As DataGridViewRow In dgv_Items.Rows
            If row.Index < firstIndex Then Continue For
            row.Selected = True
            dgv_Items.FirstDisplayedScrollingRowIndex = Math.Max(row.Index - 5, 0)
            dgv_Items.Refresh()
            prog_Load.Value += 1
            fetchItemIcon(row.Index)
            fetchItemPrice(row.Index, True)
            If Wait409.Cancel Then
                Exit For
            End If
        Next
        Me.Enabled = True
        prog_Load.Visible = False
        dgv_Items.SelectedRows(0).Selected = False
        UpdateCrateStats()
    End Sub

    Private Sub dgv_Items_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Items.CellDoubleClick
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub
        Select Case e.ColumnIndex
            Case cRarity.Index
                If Not chk_Edit.Checked Then Exit Sub
                RaritySelector.rowIndex = e.RowIndex
                RaritySelector.ShowDialog(Me)
            Case cItem.Index
                'go to link
                Dim item As String = dgv_Items.Item(cItem.Index, e.RowIndex).Value
                If item Is Nothing Then Exit Sub
                Process.Start(URL_ITEM & item.Replace(" ", "%20"))
            Case cPrice.Index
                'fetch single price
                fetchItemPrice(e.RowIndex, False)
            Case cIcon.Index
                fetchItemIcon(e.RowIndex)
                'fetch item icon
        End Select
    End Sub

    Private Sub chk_Edit_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Edit.CheckedChanged
        Dim editing As Boolean = chk_Edit.Checked
        cItem.ReadOnly = Not editing
        dgv_Items.AllowUserToAddRows = editing
        dgv_Items.AllowUserToDeleteRows = editing
        dgv_Items.RowHeadersVisible = editing
        cCollected.Visible = Not editing
        cPrice.Visible = Not editing
        cmb_Crate.Enabled = Not editing
        btn_Save.Enabled = Not editing
        btn_Download.Enabled = Not editing
    End Sub

    Private Sub dgv_Items_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_Items.MouseWheel
        If Control.ModifierKeys = Keys.Control Then
            Dim clicks As Integer = e.Delta / SystemInformation.MouseWheelScrollDelta
            dgv_Items.RowTemplate.Height += clicks
            SaveData()
            LoadData()
        End If
    End Sub
End Class
