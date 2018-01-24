Public Class Wait409
    Public oldValue As String
    Public rowIndex As Integer
    Public Cancel As Boolean
    Private retries As Integer
    Private start As Date
    Private Const MAX_RETRIES As Integer = 10

    Private Sub Wait409_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cancel = False
        retries = 0
        btn_Cancel.Enabled = True
        start = DateAndTime.Now
        RequestTimer.Start()
        RefreshTimer.Start()
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        RefreshTimer.Stop
        cancel = True
        btn_Cancel.Enabled = False
        txt_Timer.Text = "Canceling...."
    End Sub

    Private Sub RequestTimer_Tick(sender As Object, e As EventArgs) Handles RequestTimer.Tick
        With Main.dgv_Items.Item(Main.cPrice.Index, rowIndex)
            If cancel Then
                Main.dgv_Items.Item(Main.cPrice.Index, rowIndex).ErrorText = "Canceled"
                .Value = oldValue
                Me.Close()
            End If
            retries += 1
            If retries > MAX_RETRIES Then
                Main.dgv_Items.Item(Main.cPrice.Index, rowIndex).ErrorText = "Reached Max Retries"
                .Value = oldValue
                Me.Close()
            End If
            Try
                .Tag = Main.fetchPriceByName(Main.dgv_Items.Item(Main.cPrice.Index, rowIndex).Value)
                .Value = .Tag & " (" & (.Tag - Main.calculateTaxes(.Tag)) & ")"
                Main.dgv_Items.Item(Main.cPrice.Index, rowIndex).ErrorText = ""
                Me.Close()
            Catch ex As Exception
                If Not ex.Message.Contains("Too Many Request") Then
                    Main.dgv_Items.Item(Main.cPrice.Index, rowIndex).ErrorText = ex.Message
                    .Value = oldValue
                    Me.Close()
                End If
            End Try
        End With
    End Sub

    Private Sub RefreshTimer_Tick(sender As Object, e As EventArgs) Handles RefreshTimer.Tick
        txt_Timer.Text = "Retries: " & retries & ", Waited: " & DateAndTime.Now.Subtract(start).Seconds & "s"
    End Sub

    Private Sub Form_Closing() Handles MyBase.Closing
        RequestTimer.Stop()
        RefreshTimer.Stop()
    End Sub
End Class