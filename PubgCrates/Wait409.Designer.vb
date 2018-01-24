<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Wait409
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.Message = New System.Windows.Forms.TextBox()
        Me.txt_Timer = New System.Windows.Forms.TextBox()
        Me.RequestTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RefreshTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(92, 83)
        Me.btn_Cancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(80, 27)
        Me.btn_Cancel.TabIndex = 0
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = true
        '
        'Message
        '
        Me.Message.Location = New System.Drawing.Point(8, 14)
        Me.Message.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Message.Multiline = true
        Me.Message.Name = "Message"
        Me.Message.ReadOnly = true
        Me.Message.Size = New System.Drawing.Size(255, 59)
        Me.Message.TabIndex = 1
        Me.Message.Text = "Too Many Requesto to Steam Servers. Max 20 request per minute. Wait here to resum"& _ 
    "e download automatically, or Cancel if you want to download data manually later "& _ 
    "(double click on a cell)"
        '
        'txt_Timer
        '
        Me.txt_Timer.Location = New System.Drawing.Point(19, 115)
        Me.txt_Timer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_Timer.Multiline = true
        Me.txt_Timer.Name = "txt_Timer"
        Me.txt_Timer.ReadOnly = true
        Me.txt_Timer.Size = New System.Drawing.Size(228, 27)
        Me.txt_Timer.TabIndex = 2
        '
        'RequestTimer
        '
        Me.RequestTimer.Interval = 5000
        '
        'RefreshTimer
        '
        '
        'Wait409
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 149)
        Me.Controls.Add(Me.Message)
        Me.Controls.Add(Me.txt_Timer)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Wait409"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents btn_Cancel As Button
    Friend WithEvents Message As TextBox
    Friend WithEvents txt_Timer As TextBox
    Friend WithEvents RequestTimer As Timer
    Friend WithEvents RefreshTimer As Timer
End Class
