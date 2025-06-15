<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cooling_Frame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cooling_Frame))
        DataGV_1 = New DataGridView()
        Label6 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Cmb_manuf = New ComboBox()
        Cmb_type = New ComboBox()
        Label7 = New Label()
        butt_close = New Button()
        butt_save = New Button()
        Label1 = New Label()
        Nud_id = New NumericUpDown()
        Butt_cooling = New Button()
        CType(DataGV_1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Nud_id, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGV_1
        ' 
        DataGV_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGV_1.Dock = DockStyle.Bottom
        DataGV_1.Location = New Point(0, 231)
        DataGV_1.Name = "DataGV_1"
        DataGV_1.RowHeadersWidth = 51
        DataGV_1.Size = New Size(848, 219)
        DataGV_1.TabIndex = 72
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label6.Location = New Point(11, 7)
        Label6.Name = "Label6"
        Label6.Size = New Size(106, 28)
        Label6.TabIndex = 70
        Label6.Text = "Фильтры:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label3.Location = New Point(11, 46)
        Label3.Name = "Label3"
        Label3.Size = New Size(159, 23)
        Label3.TabIndex = 69
        Label3.Text = "Производитель - "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label2.Location = New Point(11, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(165, 23)
        Label2.TabIndex = 68
        Label2.Text = "Тип охлаждения - "
        ' 
        ' Cmb_manuf
        ' 
        Cmb_manuf.FormattingEnabled = True
        Cmb_manuf.Location = New Point(176, 45)
        Cmb_manuf.Name = "Cmb_manuf"
        Cmb_manuf.Size = New Size(189, 28)
        Cmb_manuf.TabIndex = 67
        Cmb_manuf.Text = "Все"
        ' 
        ' Cmb_type
        ' 
        Cmb_type.FormattingEnabled = True
        Cmb_type.Location = New Point(176, 98)
        Cmb_type.Name = "Cmb_type"
        Cmb_type.Size = New Size(189, 28)
        Cmb_type.TabIndex = 66
        Cmb_type.Text = "Все"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label7.Location = New Point(18, 183)
        Label7.Name = "Label7"
        Label7.Size = New Size(225, 28)
        Label7.TabIndex = 65
        Label7.Text = "Доступные на выбор:"
        ' 
        ' butt_close
        ' 
        butt_close.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        butt_close.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        butt_close.Location = New Point(717, 192)
        butt_close.Name = "butt_close"
        butt_close.Size = New Size(119, 33)
        butt_close.TabIndex = 64
        butt_close.Text = "Закрыть"
        butt_close.UseVisualStyleBackColor = True
        ' 
        ' butt_save
        ' 
        butt_save.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        butt_save.Location = New Point(522, 172)
        butt_save.Name = "butt_save"
        butt_save.Size = New Size(185, 47)
        butt_save.TabIndex = 63
        butt_save.Text = "Сохранить выбор"
        butt_save.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label1.Location = New Point(11, 141)
        Label1.Name = "Label1"
        Label1.Size = New Size(339, 23)
        Label1.TabIndex = 62
        Label1.Text = "Код выбранной оперативной памяти - "
        ' 
        ' Nud_id
        ' 
        Nud_id.Location = New Point(356, 141)
        Nud_id.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Nud_id.Name = "Nud_id"
        Nud_id.Size = New Size(88, 27)
        Nud_id.TabIndex = 61
        Nud_id.TextAlign = HorizontalAlignment.Center
        Nud_id.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Butt_cooling
        ' 
        Butt_cooling.AccessibleDescription = ""
        Butt_cooling.AccessibleName = ""
        Butt_cooling.AutoSize = True
        Butt_cooling.BackgroundImage = My.Resources.Resources.cooling
        Butt_cooling.BackgroundImageLayout = ImageLayout.Zoom
        Butt_cooling.Cursor = Cursors.Hand
        Butt_cooling.Enabled = False
        Butt_cooling.FlatStyle = FlatStyle.Flat
        Butt_cooling.ForeColor = Color.FromArgb(CByte(149), CByte(163), CByte(179))
        Butt_cooling.Location = New Point(694, 12)
        Butt_cooling.Name = "Butt_cooling"
        Butt_cooling.Size = New Size(132, 119)
        Butt_cooling.TabIndex = 73
        Butt_cooling.UseVisualStyleBackColor = False
        ' 
        ' Cooling_Frame
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(149), CByte(163), CByte(179))
        ClientSize = New Size(848, 450)
        Controls.Add(Butt_cooling)
        Controls.Add(DataGV_1)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Cmb_manuf)
        Controls.Add(Cmb_type)
        Controls.Add(Label7)
        Controls.Add(butt_close)
        Controls.Add(butt_save)
        Controls.Add(Label1)
        Controls.Add(Nud_id)
        ForeColor = Color.FromArgb(CByte(55), CByte(74), CByte(103))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Cooling_Frame"
        Text = "Cooling_Frame"
        CType(DataGV_1, ComponentModel.ISupportInitialize).EndInit()
        CType(Nud_id, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGV_1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Cmb_manuf As ComboBox
    Friend WithEvents Cmb_type As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents butt_close As Button
    Friend WithEvents butt_save As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Nud_id As NumericUpDown
    Friend WithEvents Butt_cooling As Button
End Class
