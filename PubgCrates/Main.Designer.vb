<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.dgv_Items = New System.Windows.Forms.DataGridView()
        Me.cCollected = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cIcon = New System.Windows.Forms.DataGridViewImageColumn()
        Me.cItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cRarity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_Crate = New System.Windows.Forms.ComboBox()
        Me.lbl_cmbCrate = New System.Windows.Forms.Label()
        Me.Pnl_Stats = New System.Windows.Forms.Panel()
        Me.chk_Edit = New System.Windows.Forms.CheckBox()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.prog_Load = New System.Windows.Forms.ProgressBar()
        Me.lbl_TimeStamp = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_CollectionRemainingPrice = New System.Windows.Forms.TextBox()
        Me.txt_CollectionTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Download = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_SellAt = New System.Windows.Forms.TextBox()
        Me.txt_CrateValue = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.dgv_Items,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Pnl_Stats.SuspendLayout
        Me.SuspendLayout
        '
        'dgv_Items
        '
        Me.dgv_Items.AllowUserToAddRows = false
        Me.dgv_Items.AllowUserToDeleteRows = false
        Me.dgv_Items.AllowUserToResizeColumns = false
        Me.dgv_Items.AllowUserToResizeRows = false
        Me.dgv_Items.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgv_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Items.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cCollected, Me.cIcon, Me.cItem, Me.cPrice, Me.cRarity})
        Me.dgv_Items.Location = New System.Drawing.Point(218, 12)
        Me.dgv_Items.MultiSelect = false
        Me.dgv_Items.Name = "dgv_Items"
        Me.dgv_Items.RowHeadersVisible = false
        Me.dgv_Items.Size = New System.Drawing.Size(650, 578)
        Me.dgv_Items.TabIndex = 2
        '
        'cCollected
        '
        Me.cCollected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cCollected.HeaderText = "Collected"
        Me.cCollected.Name = "cCollected"
        Me.cCollected.Width = 57
        '
        'cIcon
        '
        Me.cIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cIcon.HeaderText = ""
        Me.cIcon.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.cIcon.Name = "cIcon"
        Me.cIcon.ReadOnly = true
        Me.cIcon.Width = 5
        '
        'cItem
        '
        Me.cItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cItem.FillWeight = 60!
        Me.cItem.HeaderText = "Item"
        Me.cItem.Name = "cItem"
        Me.cItem.ReadOnly = true
        Me.cItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'cPrice
        '
        Me.cPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cPrice.FillWeight = 20!
        Me.cPrice.HeaderText = "Price"
        Me.cPrice.Name = "cPrice"
        Me.cPrice.ReadOnly = true
        Me.cPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'cRarity
        '
        Me.cRarity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cRarity.FillWeight = 20!
        Me.cRarity.HeaderText = "Rarity"
        Me.cRarity.Name = "cRarity"
        Me.cRarity.ReadOnly = true
        Me.cRarity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'cmb_Crate
        '
        Me.cmb_Crate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Crate.FormattingEnabled = true
        Me.cmb_Crate.Location = New System.Drawing.Point(12, 28)
        Me.cmb_Crate.Name = "cmb_Crate"
        Me.cmb_Crate.Size = New System.Drawing.Size(191, 21)
        Me.cmb_Crate.TabIndex = 0
        '
        'lbl_cmbCrate
        '
        Me.lbl_cmbCrate.AutoSize = true
        Me.lbl_cmbCrate.Location = New System.Drawing.Point(12, 12)
        Me.lbl_cmbCrate.Name = "lbl_cmbCrate"
        Me.lbl_cmbCrate.Size = New System.Drawing.Size(74, 13)
        Me.lbl_cmbCrate.TabIndex = 1
        Me.lbl_cmbCrate.Text = "Choose Crate:"
        '
        'Pnl_Stats
        '
        Me.Pnl_Stats.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Pnl_Stats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_Stats.Controls.Add(Me.chk_Edit)
        Me.Pnl_Stats.Controls.Add(Me.btn_Save)
        Me.Pnl_Stats.Controls.Add(Me.prog_Load)
        Me.Pnl_Stats.Controls.Add(Me.lbl_TimeStamp)
        Me.Pnl_Stats.Controls.Add(Me.Label5)
        Me.Pnl_Stats.Controls.Add(Me.Label3)
        Me.Pnl_Stats.Controls.Add(Me.Label4)
        Me.Pnl_Stats.Controls.Add(Me.txt_CollectionRemainingPrice)
        Me.Pnl_Stats.Controls.Add(Me.txt_CollectionTotalPrice)
        Me.Pnl_Stats.Controls.Add(Me.Label2)
        Me.Pnl_Stats.Controls.Add(Me.btn_Download)
        Me.Pnl_Stats.Controls.Add(Me.Label1)
        Me.Pnl_Stats.Controls.Add(Me.txt_SellAt)
        Me.Pnl_Stats.Controls.Add(Me.txt_CrateValue)
        Me.Pnl_Stats.Location = New System.Drawing.Point(12, 55)
        Me.Pnl_Stats.Name = "Pnl_Stats"
        Me.Pnl_Stats.Size = New System.Drawing.Size(191, 536)
        Me.Pnl_Stats.TabIndex = 3
        '
        'chk_Edit
        '
        Me.chk_Edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.chk_Edit.AutoSize = true
        Me.chk_Edit.Location = New System.Drawing.Point(17, 461)
        Me.chk_Edit.Name = "chk_Edit"
        Me.chk_Edit.Size = New System.Drawing.Size(93, 17)
        Me.chk_Edit.TabIndex = 4
        Me.chk_Edit.Text = "Enable editing"
        Me.chk_Edit.UseVisualStyleBackColor = true
        Me.chk_Edit.Visible = false
        '
        'btn_Save
        '
        Me.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_Save.Location = New System.Drawing.Point(17, 484)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(158, 23)
        Me.btn_Save.TabIndex = 11
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = true
        '
        'prog_Load
        '
        Me.prog_Load.Location = New System.Drawing.Point(17, 17)
        Me.prog_Load.Name = "prog_Load"
        Me.prog_Load.Size = New System.Drawing.Size(158, 23)
        Me.prog_Load.TabIndex = 4
        Me.prog_Load.Visible = false
        '
        'lbl_TimeStamp
        '
        Me.lbl_TimeStamp.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_TimeStamp.Location = New System.Drawing.Point(-1, 513)
        Me.lbl_TimeStamp.Name = "lbl_TimeStamp"
        Me.lbl_TimeStamp.Size = New System.Drawing.Size(191, 13)
        Me.lbl_TimeStamp.TabIndex = 10
        Me.lbl_TimeStamp.Text = "DataTimeStamp"
        Me.lbl_TimeStamp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(70, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Collection"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(17, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Remaining"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(14, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Total Price"
        '
        'txt_CollectionRemainingPrice
        '
        Me.txt_CollectionRemainingPrice.Location = New System.Drawing.Point(82, 193)
        Me.txt_CollectionRemainingPrice.Name = "txt_CollectionRemainingPrice"
        Me.txt_CollectionRemainingPrice.ReadOnly = true
        Me.txt_CollectionRemainingPrice.Size = New System.Drawing.Size(95, 20)
        Me.txt_CollectionRemainingPrice.TabIndex = 6
        '
        'txt_CollectionTotalPrice
        '
        Me.txt_CollectionTotalPrice.Location = New System.Drawing.Point(82, 167)
        Me.txt_CollectionTotalPrice.Name = "txt_CollectionTotalPrice"
        Me.txt_CollectionTotalPrice.ReadOnly = true
        Me.txt_CollectionTotalPrice.Size = New System.Drawing.Size(95, 20)
        Me.txt_CollectionTotalPrice.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(37, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sell At"
        '
        'btn_Download
        '
        Me.btn_Download.Enabled = false
        Me.btn_Download.Location = New System.Drawing.Point(17, 17)
        Me.btn_Download.Name = "btn_Download"
        Me.btn_Download.Size = New System.Drawing.Size(158, 23)
        Me.btn_Download.TabIndex = 3
        Me.btn_Download.Text = "Download Data"
        Me.btn_Download.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(14, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Crate Value"
        '
        'txt_SellAt
        '
        Me.txt_SellAt.Location = New System.Drawing.Point(82, 87)
        Me.txt_SellAt.Name = "txt_SellAt"
        Me.txt_SellAt.ReadOnly = true
        Me.txt_SellAt.Size = New System.Drawing.Size(95, 20)
        Me.txt_SellAt.TabIndex = 1
        '
        'txt_CrateValue
        '
        Me.txt_CrateValue.Location = New System.Drawing.Point(82, 61)
        Me.txt_CrateValue.Name = "txt_CrateValue"
        Me.txt_CrateValue.ReadOnly = true
        Me.txt_CrateValue.Size = New System.Drawing.Size(95, 20)
        Me.txt_CrateValue.TabIndex = 0
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 612)
        Me.Controls.Add(Me.Pnl_Stats)
        Me.Controls.Add(Me.lbl_cmbCrate)
        Me.Controls.Add(Me.cmb_Crate)
        Me.Controls.Add(Me.dgv_Items)
        Me.MinimumSize = New System.Drawing.Size(745, 547)
        Me.Name = "Main"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "PubgCrates"
        CType(Me.dgv_Items,System.ComponentModel.ISupportInitialize).EndInit
        Me.Pnl_Stats.ResumeLayout(false)
        Me.Pnl_Stats.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents dgv_Items As DataGridView
    Friend WithEvents cmb_Crate As ComboBox
    Friend WithEvents lbl_cmbCrate As Label
    Friend WithEvents Pnl_Stats As Panel
    Friend WithEvents btn_Download As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_SellAt As TextBox
    Friend WithEvents txt_CrateValue As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_TimeStamp As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_CollectionRemainingPrice As TextBox
    Friend WithEvents txt_CollectionTotalPrice As TextBox
    Friend WithEvents prog_Load As ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_Save As Button
    Friend WithEvents chk_Edit As CheckBox
    Friend WithEvents cCollected As DataGridViewCheckBoxColumn
    Friend WithEvents cIcon As DataGridViewImageColumn
    Friend WithEvents cItem As DataGridViewTextBoxColumn
    Friend WithEvents cPrice As DataGridViewTextBoxColumn
    Friend WithEvents cRarity As DataGridViewTextBoxColumn
End Class
