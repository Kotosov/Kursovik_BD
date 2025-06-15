<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRAME_FRAME
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRAME_FRAME))
        Butt_Frame = New Button()
        DataGV = New DataGridView()
        Label7 = New Label()
        butt_close = New Button()
        butt_save = New Button()
        Label1 = New Label()
        Nud_id = New NumericUpDown()
        Label6 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Cmb_water = New ComboBox()
        Cmb_Color = New ComboBox()
        CType(DataGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(Nud_id, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Butt_Frame
        ' 
        Butt_Frame.AccessibleDescription = ""
        Butt_Frame.AccessibleName = ""
        Butt_Frame.AutoSize = True
        Butt_Frame.BackgroundImage = My.Resources.Resources.корпус
        Butt_Frame.BackgroundImageLayout = ImageLayout.Zoom
        Butt_Frame.Cursor = Cursors.Hand
        Butt_Frame.FlatStyle = FlatStyle.Flat
        Butt_Frame.ForeColor = Color.FromArgb(CByte(149), CByte(163), CByte(179))
        Butt_Frame.Location = New Point(620, 29)
        Butt_Frame.Name = "Butt_Frame"
        Butt_Frame.Size = New Size(141, 124)
        Butt_Frame.TabIndex = 1
        Butt_Frame.UseVisualStyleBackColor = False
        ' 
        ' DataGV
        ' 
        DataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGV.Dock = DockStyle.Bottom
        DataGV.Location = New Point(0, 243)
        DataGV.Name = "DataGV"
        DataGV.RowHeadersWidth = 51
        DataGV.Size = New Size(800, 256)
        DataGV.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label7.Location = New Point(15, 194)
        Label7.Name = "Label7"
        Label7.Size = New Size(225, 28)
        Label7.TabIndex = 22
        Label7.Text = "Доступные на выбор:"
        ' 
        ' butt_close
        ' 
        butt_close.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        butt_close.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        butt_close.Location = New Point(669, 197)
        butt_close.Name = "butt_close"
        butt_close.Size = New Size(119, 33)
        butt_close.TabIndex = 21
        butt_close.Text = "Закрыть"
        butt_close.UseVisualStyleBackColor = True
        ' 
        ' butt_save
        ' 
        butt_save.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        butt_save.Location = New Point(455, 183)
        butt_save.Name = "butt_save"
        butt_save.Size = New Size(185, 47)
        butt_save.TabIndex = 20
        butt_save.Text = "Сохранить выбор"
        butt_save.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label1.Location = New Point(9, 152)
        Label1.Name = "Label1"
        Label1.Size = New Size(237, 23)
        Label1.TabIndex = 19
        Label1.Text = "Код выбранного корпуса - "
        ' 
        ' Nud_id
        ' 
        Nud_id.Location = New Point(252, 152)
        Nud_id.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Nud_id.Name = "Nud_id"
        Nud_id.Size = New Size(88, 27)
        Nud_id.TabIndex = 18
        Nud_id.TextAlign = HorizontalAlignment.Center
        Nud_id.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label6.Location = New Point(8, 18)
        Label6.Name = "Label6"
        Label6.Size = New Size(106, 28)
        Label6.TabIndex = 27
        Label6.Text = "Фильтры:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label3.Location = New Point(9, 107)
        Label3.Name = "Label3"
        Label3.Size = New Size(205, 23)
        Label3.TabIndex = 26
        Label3.Text = "Водяное охлаждение - "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label2.Location = New Point(9, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 23)
        Label2.TabIndex = 25
        Label2.Text = "Цвет - "
        ' 
        ' Cmb_water
        ' 
        Cmb_water.FormattingEnabled = True
        Cmb_water.Location = New Point(220, 106)
        Cmb_water.Name = "Cmb_water"
        Cmb_water.Size = New Size(189, 28)
        Cmb_water.TabIndex = 24
        Cmb_water.Text = "Все"
        ' 
        ' Cmb_Color
        ' 
        Cmb_Color.FormattingEnabled = True
        Cmb_Color.Location = New Point(83, 63)
        Cmb_Color.Name = "Cmb_Color"
        Cmb_Color.Size = New Size(189, 28)
        Cmb_Color.TabIndex = 23
        Cmb_Color.Text = "Все"
        ' 
        ' FRAME_FRAME
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(149), CByte(163), CByte(179))
        ClientSize = New Size(800, 499)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Cmb_water)
        Controls.Add(Cmb_Color)
        Controls.Add(Label7)
        Controls.Add(butt_close)
        Controls.Add(butt_save)
        Controls.Add(Label1)
        Controls.Add(Nud_id)
        Controls.Add(DataGV)
        Controls.Add(Butt_Frame)
        ForeColor = Color.FromArgb(CByte(55), CByte(74), CByte(103))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FRAME_FRAME"
        Text = "FRAME_FRAME"
        CType(DataGV, ComponentModel.ISupportInitialize).EndInit()
        CType(Nud_id, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Butt_Frame As Button
    Friend WithEvents DataGV As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents butt_close As Button
    Friend WithEvents butt_save As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Nud_id As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Cmb_water As ComboBox
    Friend WithEvents Cmb_Color As ComboBox
End Class
