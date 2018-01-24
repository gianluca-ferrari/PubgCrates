Public Class RaritySelector
    Public rowIndex As Integer
    Private rarityCell As DataGridViewCell
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rarityCell = Main.dgv_Items.Item(Main.cRarity.Index, rowIndex)
        colorpicker.Color = rarityCell.Style.BackColor
        btn_color.BackColor = rarityCell.Style.BackColor
        colorpicker.CustomColors = {3947580, 7437889, 11358841, 3620808, 16777215, 16777215, 16777215, 16777215, 8421504, 12488449, 11620010, 16777215, 16777215, 16777215, 16777215, 16777215}
        txt_Rarity.Text = rarityCell.Value
        btn_color.Select()
    End Sub

    Private Sub btn_color_Click(sender As Object, e As EventArgs) Handles btn_color.Click
        colorpicker.ShowDialog()
        btn_color.BackColor = colorpicker.Color
        txt_Rarity.Select()
        txt_Rarity.SelectAll()
    End Sub

    Private Sub txt_Rarity_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Rarity.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            Me.Close()
        End If
    End Sub

    Private Sub RaritySelector_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        rarityCell.Style.BackColor = colorpicker.Color
        rarityCell.Style.ForeColor = Main.ChooseForeColor(colorpicker.Color)
        Dim result As Double
        If Double.TryParse(txt_Rarity.Text.Replace(".", ","), result) Then
            rarityCell.Value = result
        End If
    End Sub
End Class