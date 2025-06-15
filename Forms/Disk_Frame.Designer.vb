<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Disk_Frame
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Disk_Frame))
        Label6 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Cmb_V_disk = New ComboBox()
        Cmb_Manuf = New ComboBox()
        Label7 = New Label()
        butt_close = New Button()
        butt_save = New Button()
        Label1 = New Label()
        Nud_id = New NumericUpDown()
        butt_disk = New Button()
        DataGV = New DataGridView()
        CType(Nud_id, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label6.Location = New Point(10, 14)
        Label6.Name = "Label6"
        Label6.Size = New Size(106, 28)
        Label6.TabIndex = 48
        Label6.Text = "Фильтры:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label3.Location = New Point(11, 103)
        Label3.Name = "Label3"
        Label3.Size = New Size(190, 23)
        Label3.TabIndex = 47
        Label3.Text = "Количество памяти - "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label2.Location = New Point(11, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 23)
        Label2.TabIndex = 46
        Label2.Text = "Производитель - "
        ' 
        ' Cmb_V_disk
        ' 
        Cmb_V_disk.FormattingEnabled = True
        Cmb_V_disk.Location = New Point(207, 103)
        Cmb_V_disk.Name = "Cmb_V_disk"
        Cmb_V_disk.Size = New Size(189, 28)
        Cmb_V_disk.TabIndex = 45
        Cmb_V_disk.Text = "Все"
        ' 
        ' Cmb_Manuf
        ' 
        Cmb_Manuf.FormattingEnabled = True
        Cmb_Manuf.Location = New Point(176, 59)
        Cmb_Manuf.Name = "Cmb_Manuf"
        Cmb_Manuf.Size = New Size(189, 28)
        Cmb_Manuf.TabIndex = 44
        Cmb_Manuf.Text = "Все"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label7.Location = New Point(17, 190)
        Label7.Name = "Label7"
        Label7.Size = New Size(225, 28)
        Label7.TabIndex = 43
        Label7.Text = "Доступные на выбор:"
        ' 
        ' butt_close
        ' 
        butt_close.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        butt_close.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        butt_close.Location = New Point(669, 193)
        butt_close.Name = "butt_close"
        butt_close.Size = New Size(119, 33)
        butt_close.TabIndex = 42
        butt_close.Text = "Закрыть"
        butt_close.UseVisualStyleBackColor = True
        ' 
        ' butt_save
        ' 
        butt_save.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        butt_save.Location = New Point(457, 179)
        butt_save.Name = "butt_save"
        butt_save.Size = New Size(185, 47)
        butt_save.TabIndex = 41
        butt_save.Text = "Сохранить выбор"
        butt_save.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label1.Location = New Point(11, 148)
        Label1.Name = "Label1"
        Label1.Size = New Size(219, 23)
        Label1.TabIndex = 40
        Label1.Text = "Код выбранного диска - "
        ' 
        ' Nud_id
        ' 
        Nud_id.Location = New Point(254, 148)
        Nud_id.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Nud_id.Name = "Nud_id"
        Nud_id.Size = New Size(88, 27)
        Nud_id.TabIndex = 39
        Nud_id.TextAlign = HorizontalAlignment.Center
        Nud_id.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' butt_disk
        ' 
        butt_disk.AccessibleDescription = ""
        butt_disk.AccessibleName = ""
        butt_disk.AutoSize = True
        butt_disk.BackgroundImage = My.Resources.Resources.dick
        butt_disk.BackgroundImageLayout = ImageLayout.Zoom
        butt_disk.Cursor = Cursors.Hand
        butt_disk.Enabled = False
        butt_disk.FlatStyle = FlatStyle.Flat
        butt_disk.ForeColor = Color.FromArgb(CByte(149), CByte(163), CByte(179))
        butt_disk.Location = New Point(592, 18)
        butt_disk.Name = "butt_disk"
        butt_disk.Size = New Size(173, 108)
        butt_disk.TabIndex = 49
        butt_disk.UseVisualStyleBackColor = False
        ' 
        ' DataGV
        ' 
        DataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGV.Dock = DockStyle.Bottom
        DataGV.Location = New Point(0, 232)
        DataGV.Name = "DataGV"
        DataGV.RowHeadersWidth = 51
        DataGV.Size = New Size(800, 314)
        DataGV.TabIndex = 50
        ' 
        ' Disk_Frame
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(149), CByte(163), CByte(179))
        ClientSize = New Size(800, 546)
        Controls.Add(DataGV)
        Controls.Add(butt_disk)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Cmb_V_disk)
        Controls.Add(Cmb_Manuf)
        Controls.Add(Label7)
        Controls.Add(butt_close)
        Controls.Add(butt_save)
        Controls.Add(Label1)
        Controls.Add(Nud_id)
        ForeColor = Color.FromArgb(CByte(55), CByte(74), CByte(103))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Disk_Frame"
        Text = "Disk_Frame"
        CType(Nud_id, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Cmb_V_disk As ComboBox
    Friend WithEvents Cmb_Manuf As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents butt_close As Button
    Friend WithEvents butt_save As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Nud_id As NumericUpDown
    Friend WithEvents butt_disk As Button
    Friend WithEvents DataGV As DataGridView
End Class
