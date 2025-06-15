<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CPU_Frame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CPU_Frame))
        butt_save_core = New Button()
        butt_close = New Button()
        Cmb_Manufacturer = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Cmb_model = New ComboBox()
        lbl_info = New Label()
        lbl_info2 = New Label()
        butt_core = New Button()
        SuspendLayout()
        ' 
        ' butt_save_core
        ' 
        butt_save_core.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        butt_save_core.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        butt_save_core.ForeColor = Color.FromArgb(CByte(55), CByte(74), CByte(103))
        butt_save_core.Location = New Point(12, 479)
        butt_save_core.Name = "butt_save_core"
        butt_save_core.Size = New Size(175, 46)
        butt_save_core.TabIndex = 0
        butt_save_core.Text = "Сохранить выбор"
        butt_save_core.UseVisualStyleBackColor = True
        ' 
        ' butt_close
        ' 
        butt_close.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        butt_close.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        butt_close.ForeColor = Color.FromArgb(CByte(55), CByte(74), CByte(103))
        butt_close.Location = New Point(847, 491)
        butt_close.Name = "butt_close"
        butt_close.Size = New Size(105, 34)
        butt_close.TabIndex = 1
        butt_close.Text = "Закрыть"
        butt_close.UseVisualStyleBackColor = True
        ' 
        ' Cmb_Manufacturer
        ' 
        Cmb_Manufacturer.DropDownStyle = ComboBoxStyle.DropDownList
        Cmb_Manufacturer.FormattingEnabled = True
        Cmb_Manufacturer.Location = New Point(193, 38)
        Cmb_Manufacturer.Name = "Cmb_Manufacturer"
        Cmb_Manufacturer.Size = New Size(274, 28)
        Cmb_Manufacturer.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label1.ForeColor = Color.FromArgb(CByte(55), CByte(74), CByte(103))
        Label1.Location = New Point(20, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(167, 25)
        Label1.TabIndex = 3
        Label1.Text = "Производитель - "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label2.ForeColor = Color.FromArgb(CByte(55), CByte(74), CByte(103))
        Label2.Location = New Point(88, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 25)
        Label2.TabIndex = 5
        Label2.Text = "Модель - "
        ' 
        ' Cmb_model
        ' 
        Cmb_model.DropDownStyle = ComboBoxStyle.DropDownList
        Cmb_model.FormattingEnabled = True
        Cmb_model.Location = New Point(193, 102)
        Cmb_model.Name = "Cmb_model"
        Cmb_model.Size = New Size(274, 28)
        Cmb_model.TabIndex = 4
        ' 
        ' lbl_info
        ' 
        lbl_info.AutoSize = True
        lbl_info.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        lbl_info.ForeColor = Color.FromArgb(CByte(55), CByte(74), CByte(103))
        lbl_info.Location = New Point(20, 165)
        lbl_info.Name = "lbl_info"
        lbl_info.Size = New Size(135, 25)
        lbl_info.TabIndex = 6
        lbl_info.Text = "Информация:"
        ' 
        ' lbl_info2
        ' 
        lbl_info2.AutoSize = True
        lbl_info2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        lbl_info2.ForeColor = Color.FromArgb(CByte(55), CByte(74), CByte(103))
        lbl_info2.Location = New Point(407, 189)
        lbl_info2.Name = "lbl_info2"
        lbl_info2.Size = New Size(0, 25)
        lbl_info2.TabIndex = 7
        ' 
        ' butt_core
        ' 
        butt_core.AccessibleDescription = ""
        butt_core.AccessibleName = ""
        butt_core.AutoSize = True
        butt_core.BackgroundImage = My.Resources.Resources.core
        butt_core.BackgroundImageLayout = ImageLayout.Zoom
        butt_core.Cursor = Cursors.Hand
        butt_core.FlatStyle = FlatStyle.Flat
        butt_core.ForeColor = Color.FromArgb(CByte(149), CByte(163), CByte(179))
        butt_core.Location = New Point(773, 21)
        butt_core.Name = "butt_core"
        butt_core.Size = New Size(136, 130)
        butt_core.TabIndex = 8
        butt_core.UseVisualStyleBackColor = False
        ' 
        ' CPU_Frame
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(149), CByte(163), CByte(179))
        ClientSize = New Size(964, 537)
        Controls.Add(butt_core)
        Controls.Add(lbl_info2)
        Controls.Add(lbl_info)
        Controls.Add(Label2)
        Controls.Add(Cmb_model)
        Controls.Add(Label1)
        Controls.Add(Cmb_Manufacturer)
        Controls.Add(butt_close)
        Controls.Add(butt_save_core)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximumSize = New Size(982, 584)
        MinimumSize = New Size(982, 584)
        Name = "CPU_Frame"
        Text = "CPU"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents butt_save_core As Button
    Friend WithEvents butt_close As Button
    Friend WithEvents Cmb_Manufacturer As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Cmb_model As ComboBox
    Friend WithEvents lbl_info As Label
    Friend WithEvents lbl_info2 As Label
    Friend WithEvents butt_core As Button
End Class
