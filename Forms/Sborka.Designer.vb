<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sborka
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
        components = New ComponentModel.Container()
        Dim TreeNode1 As TreeNode = New TreeNode("Материнская плата")
        Dim TreeNode2 As TreeNode = New TreeNode("Процессор")
        Dim TreeNode3 As TreeNode = New TreeNode("Видеокарта")
        Dim TreeNode4 As TreeNode = New TreeNode("Оперативная память")
        Dim TreeNode5 As TreeNode = New TreeNode("Диски")
        Dim TreeNode6 As TreeNode = New TreeNode("Блок питания")
        Dim TreeNode7 As TreeNode = New TreeNode("Охлаждение")
        Dim TreeNode8 As TreeNode = New TreeNode("Корпус")
        Dim TreeNode9 As TreeNode = New TreeNode("Итоговая Сборка", New TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sborka))
        Butt_Frame = New Button()
        Tt_Frame = New ToolTip(components)
        butt_motherboard = New Button()
        butt_disk = New Button()
        butt_core = New Button()
        butt_GPU = New Button()
        Butt_powerplant = New Button()
        Butt_RAM = New Button()
        Butt_cooling = New Button()
        Tree = New TreeView()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        butt_save = New Button()
        butt_close = New Button()
        butt_summ = New Button()
        txt_summ = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
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
        Butt_Frame.Enabled = False
        Butt_Frame.FlatStyle = FlatStyle.Flat
        Butt_Frame.ForeColor = Color.FromArgb(CByte(149), CByte(163), CByte(179))
        Butt_Frame.Location = New Point(351, 12)
        Butt_Frame.Name = "Butt_Frame"
        Butt_Frame.Size = New Size(141, 124)
        Butt_Frame.TabIndex = 0
        Tt_Frame.SetToolTip(Butt_Frame, "Выбать корпус")
        Butt_Frame.UseVisualStyleBackColor = False
        ' 
        ' Tt_Frame
        ' 
        Tt_Frame.AutomaticDelay = 50
        Tt_Frame.AutoPopDelay = 2500
        Tt_Frame.BackColor = Color.FromArgb(CByte(251), CByte(252), CByte(243))
        Tt_Frame.ForeColor = Color.FromArgb(CByte(55), CByte(74), CByte(103))
        Tt_Frame.InitialDelay = 500
        Tt_Frame.ReshowDelay = 100
        Tt_Frame.ToolTipIcon = ToolTipIcon.Info
        Tt_Frame.ToolTipTitle = "Информация"
        ' 
        ' butt_motherboard
        ' 
        butt_motherboard.AccessibleDescription = ""
        butt_motherboard.AccessibleName = ""
        butt_motherboard.AutoSize = True
        butt_motherboard.BackgroundImage = My.Resources.Resources.mother
        butt_motherboard.BackgroundImageLayout = ImageLayout.Stretch
        butt_motherboard.Cursor = Cursors.Hand
        butt_motherboard.Enabled = False
        butt_motherboard.FlatStyle = FlatStyle.Flat
        butt_motherboard.ForeColor = Color.FromArgb(CByte(149), CByte(163), CByte(179))
        butt_motherboard.Location = New Point(169, 160)
        butt_motherboard.Name = "butt_motherboard"
        butt_motherboard.Size = New Size(110, 119)
        butt_motherboard.TabIndex = 1
        Tt_Frame.SetToolTip(butt_motherboard, "Выбать материнскую плату")
        butt_motherboard.UseVisualStyleBackColor = False
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
        butt_disk.Location = New Point(315, 333)
        butt_disk.Name = "butt_disk"
        butt_disk.Size = New Size(93, 61)
        butt_disk.TabIndex = 2
        Tt_Frame.SetToolTip(butt_disk, "Выбать диск")
        butt_disk.UseVisualStyleBackColor = False
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
        butt_core.Location = New Point(188, 12)
        butt_core.Name = "butt_core"
        butt_core.Size = New Size(91, 89)
        butt_core.TabIndex = 3
        Tt_Frame.SetToolTip(butt_core, "Выбрать процессор")
        butt_core.UseVisualStyleBackColor = False
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
        butt_GPU.Location = New Point(366, 186)
        butt_GPU.Name = "butt_GPU"
        butt_GPU.Size = New Size(126, 77)
        butt_GPU.TabIndex = 4
        Tt_Frame.SetToolTip(butt_GPU, "Выбрать видеокрту")
        butt_GPU.UseVisualStyleBackColor = False
        ' 
        ' Butt_powerplant
        ' 
        Butt_powerplant.AccessibleDescription = ""
        Butt_powerplant.AccessibleName = ""
        Butt_powerplant.AutoSize = True
        Butt_powerplant.BackgroundImage = My.Resources.Resources.bp
        Butt_powerplant.BackgroundImageLayout = ImageLayout.Zoom
        Butt_powerplant.Cursor = Cursors.Hand
        Butt_powerplant.Enabled = False
        Butt_powerplant.FlatStyle = FlatStyle.Flat
        Butt_powerplant.ForeColor = Color.FromArgb(CByte(149), CByte(163), CByte(179))
        Butt_powerplant.Location = New Point(12, 19)
        Butt_powerplant.Name = "Butt_powerplant"
        Butt_powerplant.Size = New Size(140, 110)
        Butt_powerplant.TabIndex = 5
        Tt_Frame.SetToolTip(Butt_powerplant, "Выбать блок питания")
        Butt_powerplant.UseVisualStyleBackColor = False
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
        Butt_RAM.Location = New Point(45, 340)
        Butt_RAM.Name = "Butt_RAM"
        Butt_RAM.Size = New Size(147, 54)
        Butt_RAM.TabIndex = 6
        Tt_Frame.SetToolTip(Butt_RAM, "Выбать оперативную память")
        Butt_RAM.UseVisualStyleBackColor = False
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
        Butt_cooling.Location = New Point(12, 172)
        Butt_cooling.Name = "Butt_cooling"
        Butt_cooling.Size = New Size(104, 91)
        Butt_cooling.TabIndex = 7
        Tt_Frame.SetToolTip(Butt_cooling, "Выбать охлаждение")
        Butt_cooling.UseVisualStyleBackColor = False
        ' 
        ' Tree
        ' 
        Tree.BackColor = Color.FromArgb(CByte(55), CByte(74), CByte(103))
        Tree.BorderStyle = BorderStyle.FixedSingle
        Tree.Dock = DockStyle.Right
        Tree.Font = New Font("Microsoft JhengHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Tree.ForeColor = Color.FromArgb(CByte(251), CByte(252), CByte(243))
        Tree.Location = New Point(739, 0)
        Tree.Name = "Tree"
        TreeNode1.Name = "Mother_Tree"
        TreeNode1.Tag = "1"
        TreeNode1.Text = "Материнская плата"
        TreeNode2.Name = "Core_Tree"
        TreeNode2.Tag = "2"
        TreeNode2.Text = "Процессор"
        TreeNode3.Name = "GPU_Tree"
        TreeNode3.Tag = "3"
        TreeNode3.Text = "Видеокарта"
        TreeNode4.Name = "RAM_Tree"
        TreeNode4.Tag = "4"
        TreeNode4.Text = "Оперативная память"
        TreeNode5.Name = "Disk_Tree"
        TreeNode5.Tag = "5"
        TreeNode5.Text = "Диски"
        TreeNode6.Name = "Powerplant_Tree"
        TreeNode6.Tag = "6"
        TreeNode6.Text = "Блок питания"
        TreeNode7.Name = "Cooling_Tree"
        TreeNode7.Tag = "7"
        TreeNode7.Text = "Охлаждение"
        TreeNode8.Name = "Frame_Tree"
        TreeNode8.Tag = "8"
        TreeNode8.Text = "Корпус"
        TreeNode9.Checked = True
        TreeNode9.Name = "Узел0"
        TreeNode9.NodeFont = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        TreeNode9.Text = "Итоговая Сборка"
        Tree.Nodes.AddRange(New TreeNode() {TreeNode9})
        Tree.PathSeparator = "*"
        Tree.Size = New Size(343, 500)
        Tree.TabIndex = 15
        Tt_Frame.SetToolTip(Tree, "Итоговая сборка")
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.rope1
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(269, 89)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(128, 107)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.rope1
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(81, 260)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(111, 107)
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = My.Resources.Resources.rope2
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(169, 75)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(128, 107)
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = My.Resources.Resources.rope3
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(81, 186)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(128, 91)
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImage = My.Resources.Resources.rope3
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Location = New Point(258, 172)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(128, 107)
        PictureBox5.TabIndex = 12
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackgroundImage = My.Resources.Resources.rope4
        PictureBox6.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox6.Location = New Point(242, 260)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(128, 107)
        PictureBox6.TabIndex = 13
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackgroundImage = My.Resources.Resources.rope4
        PictureBox7.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox7.Location = New Point(64, 89)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(128, 107)
        PictureBox7.TabIndex = 14
        PictureBox7.TabStop = False
        ' 
        ' butt_save
        ' 
        butt_save.Anchor = AnchorStyles.Bottom
        butt_save.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold)
        butt_save.Location = New Point(12, 434)
        butt_save.Name = "butt_save"
        butt_save.Size = New Size(231, 54)
        butt_save.TabIndex = 16
        butt_save.Text = "Сохранить сборку"
        butt_save.UseVisualStyleBackColor = True
        ' 
        ' butt_close
        ' 
        butt_close.Anchor = AnchorStyles.Bottom
        butt_close.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold)
        butt_close.Location = New Point(954, 454)
        butt_close.Name = "butt_close"
        butt_close.Size = New Size(116, 34)
        butt_close.TabIndex = 17
        butt_close.Text = "Закрыть"
        butt_close.UseVisualStyleBackColor = True
        ' 
        ' butt_summ
        ' 
        butt_summ.Anchor = AnchorStyles.Bottom
        butt_summ.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold)
        butt_summ.Location = New Point(258, 434)
        butt_summ.Name = "butt_summ"
        butt_summ.Size = New Size(234, 54)
        butt_summ.TabIndex = 18
        butt_summ.Text = "Подсчитать стоимость"
        butt_summ.UseVisualStyleBackColor = True
        ' 
        ' txt_summ
        ' 
        txt_summ.Anchor = AnchorStyles.Bottom
        txt_summ.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold)
        txt_summ.Location = New Point(523, 447)
        txt_summ.Name = "txt_summ"
        txt_summ.Size = New Size(201, 28)
        txt_summ.TabIndex = 19
        txt_summ.TextAlign = HorizontalAlignment.Center
        ' 
        ' Sborka
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(149), CByte(163), CByte(179))
        ClientSize = New Size(1082, 500)
        Controls.Add(txt_summ)
        Controls.Add(butt_summ)
        Controls.Add(butt_close)
        Controls.Add(butt_save)
        Controls.Add(Tree)
        Controls.Add(butt_motherboard)
        Controls.Add(Butt_cooling)
        Controls.Add(Butt_RAM)
        Controls.Add(Butt_powerplant)
        Controls.Add(butt_GPU)
        Controls.Add(butt_core)
        Controls.Add(butt_disk)
        Controls.Add(Butt_Frame)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox7)
        Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        ForeColor = Color.FromArgb(CByte(55), CByte(74), CByte(103))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximumSize = New Size(1100, 5000)
        MinimumSize = New Size(1100, 547)
        Name = "Sborka"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Сборка"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Butt_Frame As Button
    Friend WithEvents Tt_Frame As ToolTip
    Friend WithEvents butt_motherboard As Button
    Friend WithEvents butt_disk As Button
    Friend WithEvents butt_core As Button
    Friend WithEvents butt_GPU As Button
    Friend WithEvents Butt_powerplant As Button
    Friend WithEvents Butt_RAM As Button
    Friend WithEvents Butt_cooling As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Tree As TreeView
    Friend WithEvents butt_save As Button
    Friend WithEvents butt_close As Button
    Friend WithEvents butt_summ As Button
    Friend WithEvents txt_summ As TextBox
End Class
