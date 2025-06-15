<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Form))
        Butt_start = New Button()
        butt_exit = New Button()
        butt_avtor = New Button()
        SuspendLayout()
        ' 
        ' Butt_start
        ' 
        Butt_start.BackColor = Color.FromArgb(CByte(251), CByte(252), CByte(243))
        Butt_start.Cursor = Cursors.Hand
        Butt_start.Font = New Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Butt_start.Location = New Point(12, 12)
        Butt_start.Name = "Butt_start"
        Butt_start.Size = New Size(304, 83)
        Butt_start.TabIndex = 0
        Butt_start.Text = "Начать компановку компьютера"
        Butt_start.UseVisualStyleBackColor = False
        ' 
        ' butt_exit
        ' 
        butt_exit.BackColor = Color.FromArgb(CByte(251), CByte(252), CByte(243))
        butt_exit.Cursor = Cursors.Hand
        butt_exit.Font = New Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        butt_exit.Location = New Point(47, 166)
        butt_exit.Name = "butt_exit"
        butt_exit.Size = New Size(223, 46)
        butt_exit.TabIndex = 1
        butt_exit.Text = "Выход"
        butt_exit.UseVisualStyleBackColor = False
        ' 
        ' butt_avtor
        ' 
        butt_avtor.BackColor = Color.FromArgb(CByte(251), CByte(252), CByte(243))
        butt_avtor.Cursor = Cursors.Hand
        butt_avtor.Font = New Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        butt_avtor.Location = New Point(47, 114)
        butt_avtor.Name = "butt_avtor"
        butt_avtor.Size = New Size(223, 46)
        butt_avtor.TabIndex = 2
        butt_avtor.Text = "Автор"
        butt_avtor.UseVisualStyleBackColor = False
        ' 
        ' Main_Form
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(149), CByte(163), CByte(179))
        ClientSize = New Size(325, 227)
        Controls.Add(butt_avtor)
        Controls.Add(butt_exit)
        Controls.Add(Butt_start)
        Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        ForeColor = Color.FromArgb(CByte(55), CByte(74), CByte(103))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximumSize = New Size(343, 274)
        MinimumSize = New Size(343, 274)
        Name = "Main_Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Главная"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Butt_start As Button
    Friend WithEvents butt_exit As Button
    Friend WithEvents butt_avtor As Button

End Class
