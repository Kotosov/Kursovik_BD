<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RAM_Frame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RAM_Frame))
        Label6 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Cmb_Kol_RAM = New ComboBox()
        Cmb_One_RAM = New ComboBox()
        Label7 = New Label()
        butt_close = New Button()
        butt_save = New Button()
        Label1 = New Label()
        Nud_id = New NumericUpDown()
        Butt_RAM = New Button()
        DataGV = New DataGridView()
        CType(Nud_id, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label6.Location = New Point(10, 13)
        Label6.Name = "Label6"
        Label6.Size = New Size(106, 28)
        Label6.TabIndex = 58
        Label6.Text = "Фильтры:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label3.Location = New Point(11, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(201, 23)
        Label3.TabIndex = 57
        Label3.Text = "Количество модулей - "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label2.Location = New Point(11, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(434, 23)
        Label2.TabIndex = 56
        Label2.Text = "Количество оперативной памяти одного модуля - "
        ' 
        ' Cmb_Kol_RAM
        ' 
        Cmb_Kol_RAM.FormattingEnabled = True
        Cmb_Kol_RAM.Location = New Point(218, 101)
        Cmb_Kol_RAM.Name = "Cmb_Kol_RAM"
        Cmb_Kol_RAM.Size = New Size(189, 28)
        Cmb_Kol_RAM.TabIndex = 55
        Cmb_Kol_RAM.Text = "Все"
        ' 
        ' Cmb_One_RAM
        ' 
        Cmb_One_RAM.FormattingEnabled = True
        Cmb_One_RAM.Location = New Point(451, 58)
        Cmb_One_RAM.Name = "Cmb_One_RAM"
        Cmb_One_RAM.Size = New Size(189, 28)
        Cmb_One_RAM.TabIndex = 54
        Cmb_One_RAM.Text = "Все"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label7.Location = New Point(17, 189)
        Label7.Name = "Label7"
        Label7.Size = New Size(225, 28)
        Label7.TabIndex = 53
        Label7.Text = "Доступные на выбор:"
        ' 
        ' butt_close
        ' 
        butt_close.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        butt_close.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        butt_close.Location = New Point(744, 192)
        butt_close.Name = "butt_close"
        butt_close.Size = New Size(119, 33)
        butt_close.TabIndex = 52
        butt_close.Text = "Закрыть"
        butt_close.UseVisualStyleBackColor = True
        ' 
        ' butt_save
        ' 
        butt_save.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        butt_save.Location = New Point(553, 178)
        butt_save.Name = "butt_save"
        butt_save.Size = New Size(185, 47)
        butt_save.TabIndex = 51
        butt_save.Text = "Сохранить выбор"
        butt_save.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label1.Location = New Point(10, 147)
        Label1.Name = "Label1"
        Label1.Size = New Size(339, 23)
        Label1.TabIndex = 50
        Label1.Text = "Код выбранной оперативной памяти - "
        ' 
        ' Nud_id
        ' 
        Nud_id.Location = New Point(355, 147)
        Nud_id.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Nud_id.Name = "Nud_id"
        Nud_id.Size = New Size(88, 27)
        Nud_id.TabIndex = 49
        Nud_id.TextAlign = HorizontalAlignment.Center
        Nud_id.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Butt_RAM
        ' 
        Butt_RAM.AccessibleDescription = ""
        Butt_RAM.AccessibleName = ""
        Butt_RAM.AutoSize = True
        Butt_RAM.BackgroundImage = My.Resources.Resources.RAM
        Butt_RAM.BackgroundImageLayout = ImageLayout.Zoom
        Butt_RAM.Cursor = Cursors.Hand
        Butt_RAM.Enabled = False
        Butt_RAM.FlatStyle = FlatStyle.Flat
        Butt_RAM.ForeColor = Color.FromArgb(CByte(149), CByte(163), CByte(179))
        Butt_RAM.Location = New Point(653, 15)
        Butt_RAM.Name = "Butt_RAM"
        Butt_RAM.Size = New Size(210, 67)
        Butt_RAM.TabIndex = 59
        Butt_RAM.UseVisualStyleBackColor = False
        ' 
        ' DataGV
        ' 
        DataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGV.Dock = DockStyle.Bottom
        DataGV.Location = New Point(0, 231)
        DataGV.Name = "DataGV"
        DataGV.RowHeadersWidth = 51
        DataGV.Size = New Size(875, 219)
        DataGV.TabIndex = 60
        ' 
        ' RAM_Frame
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(149), CByte(163), CByte(179))
        ClientSize = New Size(875, 450)
        Controls.Add(DataGV)
        Controls.Add(Butt_RAM)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Cmb_Kol_RAM)
        Controls.Add(Cmb_One_RAM)
        Controls.Add(Label7)
        Controls.Add(butt_close)
        Controls.Add(butt_save)
        Controls.Add(Label1)
        Controls.Add(Nud_id)
        ForeColor = Color.FromArgb(CByte(55), CByte(74), CByte(103))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "RAM_Frame"
        Text = "RAM_Frame"
        CType(Nud_id, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Cmb_Kol_RAM As ComboBox
    Friend WithEvents Cmb_One_RAM As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents butt_close As Button
    Friend WithEvents butt_save As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Nud_id As NumericUpDown
    Friend WithEvents Butt_RAM As Button
    Friend WithEvents DataGV As DataGridView
End Class
