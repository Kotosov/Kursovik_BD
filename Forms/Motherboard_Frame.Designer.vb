<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Motherboard_Frame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Motherboard_Frame))
        butt_motherboard = New Button()
        DataGV = New DataGridView()
        Nud_id = New NumericUpDown()
        Cmb_manuf = New ComboBox()
        Cmb_Type_RAM = New ComboBox()
        Cmb_Max_speed_RAM = New ComboBox()
        Cmb_kol_m2 = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        butt_save = New Button()
        Label6 = New Label()
        butt_close = New Button()
        Label7 = New Label()
        CType(DataGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(Nud_id, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' butt_motherboard
        ' 
        butt_motherboard.AccessibleDescription = ""
        butt_motherboard.AccessibleName = ""
        butt_motherboard.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        butt_motherboard.AutoSize = True
        butt_motherboard.BackgroundImage = My.Resources.Resources.mother
        butt_motherboard.BackgroundImageLayout = ImageLayout.Stretch
        butt_motherboard.Cursor = Cursors.Hand
        butt_motherboard.FlatStyle = FlatStyle.Flat
        butt_motherboard.ForeColor = Color.FromArgb(CByte(149), CByte(163), CByte(179))
        butt_motherboard.Location = New Point(796, 12)
        butt_motherboard.Name = "butt_motherboard"
        butt_motherboard.Size = New Size(119, 136)
        butt_motherboard.TabIndex = 2
        butt_motherboard.UseVisualStyleBackColor = False
        ' 
        ' DataGV
        ' 
        DataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGV.Dock = DockStyle.Bottom
        DataGV.Location = New Point(0, 351)
        DataGV.Name = "DataGV"
        DataGV.RowHeadersWidth = 51
        DataGV.Size = New Size(927, 272)
        DataGV.TabIndex = 3
        ' 
        ' Nud_id
        ' 
        Nud_id.Location = New Point(350, 243)
        Nud_id.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Nud_id.Name = "Nud_id"
        Nud_id.Size = New Size(88, 27)
        Nud_id.TabIndex = 4
        Nud_id.TextAlign = HorizontalAlignment.Center
        Nud_id.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Cmb_manuf
        ' 
        Cmb_manuf.FormattingEnabled = True
        Cmb_manuf.Location = New Point(177, 57)
        Cmb_manuf.Name = "Cmb_manuf"
        Cmb_manuf.Size = New Size(189, 28)
        Cmb_manuf.TabIndex = 5
        Cmb_manuf.Text = "Все"
        ' 
        ' Cmb_Type_RAM
        ' 
        Cmb_Type_RAM.FormattingEnabled = True
        Cmb_Type_RAM.Location = New Point(265, 100)
        Cmb_Type_RAM.Name = "Cmb_Type_RAM"
        Cmb_Type_RAM.Size = New Size(189, 28)
        Cmb_Type_RAM.TabIndex = 6
        Cmb_Type_RAM.Text = "Все"
        ' 
        ' Cmb_Max_speed_RAM
        ' 
        Cmb_Max_speed_RAM.FormattingEnabled = True
        Cmb_Max_speed_RAM.Location = New Point(428, 144)
        Cmb_Max_speed_RAM.Name = "Cmb_Max_speed_RAM"
        Cmb_Max_speed_RAM.Size = New Size(189, 28)
        Cmb_Max_speed_RAM.TabIndex = 7
        Cmb_Max_speed_RAM.Text = "Все"
        ' 
        ' Cmb_kol_m2
        ' 
        Cmb_kol_m2.FormattingEnabled = True
        Cmb_kol_m2.Location = New Point(233, 190)
        Cmb_kol_m2.Name = "Cmb_kol_m2"
        Cmb_kol_m2.Size = New Size(189, 28)
        Cmb_kol_m2.TabIndex = 8
        Cmb_kol_m2.Text = "Все"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label1.Location = New Point(14, 243)
        Label1.Name = "Label1"
        Label1.Size = New Size(330, 23)
        Label1.TabIndex = 9
        Label1.Text = "Код выбранной материнской платы - "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label2.Location = New Point(12, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 23)
        Label2.TabIndex = 10
        Label2.Text = "Производитель - "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label3.Location = New Point(12, 101)
        Label3.Name = "Label3"
        Label3.Size = New Size(247, 23)
        Label3.TabIndex = 11
        Label3.Text = "Тип оперативоной памяти - "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label4.Location = New Point(12, 145)
        Label4.Name = "Label4"
        Label4.Size = New Size(412, 23)
        Label4.TabIndex = 12
        Label4.Text = "Максимальная скорость оперативной памяти - "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label5.Location = New Point(12, 191)
        Label5.Name = "Label5"
        Label5.Size = New Size(216, 23)
        Label5.TabIndex = 13
        Label5.Text = "Количество слотов M2 - "
        ' 
        ' butt_save
        ' 
        butt_save.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        butt_save.Location = New Point(649, 231)
        butt_save.Name = "butt_save"
        butt_save.Size = New Size(185, 47)
        butt_save.TabIndex = 14
        butt_save.Text = "Сохранить выбор"
        butt_save.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label6.Location = New Point(11, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(106, 28)
        Label6.TabIndex = 15
        Label6.Text = "Фильтры:"
        ' 
        ' butt_close
        ' 
        butt_close.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        butt_close.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        butt_close.Location = New Point(796, 312)
        butt_close.Name = "butt_close"
        butt_close.Size = New Size(119, 33)
        butt_close.TabIndex = 16
        butt_close.Text = "Закрыть"
        butt_close.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label7.Location = New Point(11, 308)
        Label7.Name = "Label7"
        Label7.Size = New Size(225, 28)
        Label7.TabIndex = 17
        Label7.Text = "Доступные на выбор:"
        ' 
        ' Motherboard_Frame
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(149), CByte(163), CByte(179))
        ClientSize = New Size(927, 623)
        Controls.Add(Label7)
        Controls.Add(butt_close)
        Controls.Add(Label6)
        Controls.Add(butt_save)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Cmb_kol_m2)
        Controls.Add(Cmb_Max_speed_RAM)
        Controls.Add(Cmb_Type_RAM)
        Controls.Add(Cmb_manuf)
        Controls.Add(Nud_id)
        Controls.Add(DataGV)
        Controls.Add(butt_motherboard)
        ForeColor = Color.FromArgb(CByte(55), CByte(74), CByte(103))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(945, 670)
        Name = "Motherboard_Frame"
        Text = "Motherboard_Frame"
        CType(DataGV, ComponentModel.ISupportInitialize).EndInit()
        CType(Nud_id, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents butt_motherboard As Button
    Friend WithEvents DataGV As DataGridView
    Friend WithEvents Nud_id As NumericUpDown
    Friend WithEvents Cmb_manuf As ComboBox
    Friend WithEvents Cmb_Type_RAM As ComboBox
    Friend WithEvents Cmb_Max_speed_RAM As ComboBox
    Friend WithEvents Cmb_kol_m2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents butt_save As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents butt_close As Button
    Friend WithEvents Label7 As Label
End Class
