<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RaritySelector
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
        Me.txt_Rarity = New System.Windows.Forms.TextBox()
        Me.colorpicker = New System.Windows.Forms.ColorDialog()
        Me.btn_color = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'txt_Rarity
        '
        Me.txt_Rarity.Location = New System.Drawing.Point(44, 14)
        Me.txt_Rarity.Name = "txt_Rarity"
        Me.txt_Rarity.Size = New System.Drawing.Size(100, 20)
        Me.txt_Rarity.TabIndex = 0
        '
        'btn_color
        '
        Me.btn_color.Location = New System.Drawing.Point(12, 12)
        Me.btn_color.Name = "btn_color"
        Me.btn_color.Size = New System.Drawing.Size(26, 23)
        Me.btn_color.TabIndex = 1
        Me.btn_color.UseVisualStyleBackColor = true
        '
        'RaritySelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(153, 48)
        Me.Controls.Add(Me.btn_color)
        Me.Controls.Add(Me.txt_Rarity)
        Me.Name = "RaritySelector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Rarity"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents txt_Rarity As TextBox
    Friend WithEvents colorpicker As ColorDialog
    Friend WithEvents btn_color As Button
End Class
