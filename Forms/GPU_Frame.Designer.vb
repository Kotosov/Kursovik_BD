<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GPU_Frame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GPU_Frame))
        Label6 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Cmb_V_graf = New ComboBox()
        Cmb_Manuf = New ComboBox()
        Label7 = New Label()
        butt_close = New Button()
        butt_save = New Button()
        Label1 = New Label()
        Nud_id = New NumericUpDown()
        butt_GPU = New Button()
        DataGV = New DataGridView()
        CType(Nud_id, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label6.Location = New Point(10, 15)
        Label6.Name = "Label6"
        Label6.Size = New Size(106, 28)
        Label6.TabIndex = 38
        Label6.Text = "Фильтры:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label3.Location = New Point(11, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(304, 23)
        Label3.TabIndex = 37
        Label3.Text = "Количество графической памяти - "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label2.Location = New Point(11, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 23)
        Label2.TabIndex = 36
        Label2.Text = "Производитель - "
        ' 
        ' Cmb_V_graf
        ' 
        Cmb_V_graf.FormattingEnabled = True
        Cmb_V_graf.Location = New Point(321, 103)
        Cmb_V_graf.Name = "Cmb_V_graf"
        Cmb_V_graf.Size = New Size(189, 28)
        Cmb_V_graf.TabIndex = 35
        Cmb_V_graf.Text = "Все"
        ' 
        ' Cmb_Manuf
        ' 
        Cmb_Manuf.FormattingEnabled = True
        Cmb_Manuf.Location = New Point(176, 60)
        Cmb_Manuf.Name = "Cmb_Manuf"
        Cmb_Manuf.Size = New Size(189, 28)
        Cmb_Manuf.TabIndex = 34
        Cmb_Manuf.Text = "Все"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label7.Location = New Point(17, 191)
        Label7.Name = "Label7"
        Label7.Size = New Size(225, 28)
        Label7.TabIndex = 33
        Label7.Text = "Доступные на выбор:"
        ' 
        ' butt_close
        ' 
        butt_close.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        butt_close.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        butt_close.Location = New Point(669, 194)
        butt_close.Name = "butt_close"
        butt_close.Size = New Size(119, 33)
        butt_close.TabIndex = 32
        butt_close.Text = "Закрыть"
        butt_close.UseVisualStyleBackColor = True
        ' 
        ' butt_save
        ' 
        butt_save.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        butt_save.Location = New Point(457, 180)
        butt_save.Name = "butt_save"
        butt_save.Size = New Size(185, 47)
        butt_save.TabIndex = 31
        butt_save.Text = "Сохранить выбор"
        butt_save.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label1.Location = New Point(11, 149)
        Label1.Name = "Label1"
        Label1.Size = New Size(262, 23)
        Label1.TabIndex = 30
        Label1.Text = "Код выбранной видеокарты- "
        ' 
        ' Nud_id
        ' 
        Nud_id.Location = New Point(279, 149)
        Nud_id.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Nud_id.Name = "Nud_id"
        Nud_id.Size = New Size(88, 27)
        Nud_id.TabIndex = 29
        Nud_id.TextAlign = HorizontalAlignment.Center
        Nud_id.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' butt_GPU
        ' 
        butt_GPU.AccessibleDescription = ""
        butt_GPU.AccessibleName = ""
        butt_GPU.AutoSize = True
        butt_GPU.BackgroundImage = My.Resources.Resources.GPU
        butt_GPU.BackgroundImageLayout = ImageLayout.Zoom
        butt_GPU.Cursor = Cursors.Hand
        butt_GPU.Enabled = False
        butt_GPU.FlatStyle = FlatStyle.Flat
        butt_GPU.ForeColor = Color.FromArgb(CByte(149), CByte(163), CByte(179))
        butt_GPU.Location = New Point(587, 16)
        butt_GPU.Name = "butt_GPU"
        butt_GPU.Size = New Size(201, 115)
        butt_GPU.TabIndex = 39
        butt_GPU.UseVisualStyleBackColor = False
        ' 
        ' DataGV
        ' 
        DataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGV.Dock = DockStyle.Bottom
        DataGV.Location = New Point(0, 246)
        DataGV.Name = "DataGV"
        DataGV.RowHeadersWidth = 51
        DataGV.Size = New Size(800, 260)
        DataGV.TabIndex = 40
        ' 
        ' GPU_Frame
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(149), CByte(163), CByte(179))
        ClientSize = New Size(800, 506)
        Controls.Add(DataGV)
        Controls.Add(butt_GPU)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Cmb_V_graf)
        Controls.Add(Cmb_Manuf)
        Controls.Add(Label7)
        Controls.Add(butt_close)
        Controls.Add(butt_save)
        Controls.Add(Label1)
        Controls.Add(Nud_id)
        ForeColor = Color.FromArgb(CByte(55), CByte(74), CByte(103))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "GPU_Frame"
        Text = "GPU_Frame"
        CType(Nud_id, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Cmb_V_graf As ComboBox
    Friend WithEvents Cmb_Manuf As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents butt_close As Button
    Friend WithEvents butt_save As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Nud_id As NumericUpDown
    Friend WithEvents butt_GPU As Button
    Friend WithEvents DataGV As DataGridView
End Class
