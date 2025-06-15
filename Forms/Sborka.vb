Imports System.Diagnostics.Metrics
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window

Public Class Sborka
    Private _computer As Computer
    Public Property computer As Computer ' Public свойство для доступа к объекту
        Get
            Return _computer
        End Get
        Set(value As Computer)
            _computer = value
        End Set
    End Property
    Private Sub butt_motherboard_Click(sender As Object, e As EventArgs) Handles butt_motherboard.Click
        Dim result As DialogResult = Motherboard_Frame.ShowDialog()
        If result = DialogResult.OK Then
            Dim Motherboard_OUT As Motherboard = Motherboard_Frame.ResultObject
            computer.Motherboard = Motherboard_OUT
            Motherboard_Frame.Dispose()
            result = Nothing
            Dim treeNode As TreeNode = Tree.Nodes(0)
            Dim treeNode_Son As TreeNode = treeNode.Nodes(0)
            If treeNode_Son.Nodes.Count = 0 Then
                treeNode_Son.Nodes.Add(computer.Motherboard.Manufacturer + " " + computer.Motherboard.Soket + " " + computer.Motherboard.Form_factor)
            Else
                treeNode_Son.Nodes.Clear()
                treeNode_Son.Nodes.Add(computer.Motherboard.Manufacturer + " " + computer.Motherboard.Soket + " " + computer.Motherboard.Form_factor)
            End If
            treeNode_Son.ExpandAll()
        ElseIf result = DialogResult.Cancel Then
            MessageBox.Show("Вы не сохранили выбор!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Motherboard_Frame.Dispose()
            result = Nothing
        End If
    End Sub
    Private Sub Butt_Frame_Click(sender As Object, e As EventArgs) Handles Butt_Frame.Click
        Dim result As DialogResult = FRAME_FRAME.ShowDialog()
        If result = DialogResult.OK Then
            Dim Frame_OUT As Frame = FRAME_FRAME.ResultObject
            computer.Frame = Frame_OUT
            FRAME_FRAME.Dispose()
            result = Nothing
            Dim treeNode As TreeNode = Tree.Nodes(0)
            Dim treeNode_Son As TreeNode = treeNode.Nodes(7)
            If treeNode_Son.Nodes.Count = 0 Then
                treeNode_Son.Nodes.Add(computer.Frame.Manufacturer + " " + computer.Frame.Form_factor + " " + computer.Frame.Color)
            Else
                treeNode_Son.Nodes.Clear()
                treeNode_Son.Nodes.Add(computer.Frame.Manufacturer + " " + computer.Frame.Form_factor + " " + computer.Frame.Color)
            End If
            treeNode_Son.ExpandAll()
            If computer.Motherboard IsNot Nothing Then
                If computer.Motherboard.Form_factor <> computer.Frame.Form_factor Then
                    Dim treeNode_Son_X As TreeNode = treeNode.Nodes(7)
                    treeNode_Son_X.Nodes.Clear()
                    computer.Frame = Nothing
                    MessageBox.Show("Форм фактор на материнской плате не совпадает с корпусом! Он будет сброшен, выберете новый!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        ElseIf result = DialogResult.Cancel Then
            MessageBox.Show("Вы не сохранили выбор!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CPU_Frame.Dispose()
            result = Nothing
        End If
    End Sub

    Private Sub butt_core_Click(sender As Object, e As EventArgs) Handles butt_core.Click
        Dim result As DialogResult = CPU_Frame.ShowDialog()
        If result = DialogResult.OK Then
            butt_disk.Enabled = True
            butt_GPU.Enabled = True
            butt_motherboard.Enabled = True
            butt_save.Enabled = True
            butt_summ.Enabled = True
            Butt_RAM.Enabled = True
            Butt_powerplant.Enabled = True
            butt_disk.Enabled = True
            Butt_cooling.Enabled = True
            Butt_Frame.Enabled = True
            Dim CPU_OUT As CPU = CPU_Frame.ResultObject
            computer.CPU = CPU_OUT
            CPU_Frame.Dispose()
            result = Nothing
            Dim treeNode As TreeNode = Tree.Nodes(0)
            Dim treeNode_Son As TreeNode = treeNode.Nodes(1)
            If treeNode_Son.Nodes.Count = 0 Then
                treeNode_Son.Nodes.Add(computer.CPU.Manufacturer + " " + computer.CPU.Model)
            Else
                treeNode_Son.Nodes.Clear()
                treeNode_Son.Nodes.Add(computer.CPU.Manufacturer + " " + computer.CPU.Model)
            End If
            treeNode_Son.ExpandAll()
            If computer.Motherboard IsNot Nothing Then
                If computer.CPU.Soket <> computer.Motherboard.Soket Then
                    Dim treeNode_Son_X As TreeNode = treeNode.Nodes(0)
                    treeNode_Son_X.Nodes.Clear()
                    computer.Motherboard = Nothing
                    MessageBox.Show("Сокет на процессоре не совпадает с материнской платой! Она будет сброшена, выберете новую!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        ElseIf result = DialogResult.Cancel Then
            MessageBox.Show("Вы не сохранили выбор!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CPU_Frame.Dispose()
            result = Nothing
        End If
    End Sub

    Private Sub Butt_powerplant_Click(sender As Object, e As EventArgs) Handles Butt_powerplant.Click
        Dim result As DialogResult = Powerplant_Frame.ShowDialog()
        If result = DialogResult.OK Then
            Dim Powerplant_OUT As Powerplant = Powerplant_Frame.ResultObject
            computer.Powerplant = Powerplant_OUT
            Powerplant_Frame.Dispose()
            result = Nothing
            Dim treeNode As TreeNode = Tree.Nodes(0)
            Dim treeNode_Son As TreeNode = treeNode.Nodes(5)
            If treeNode_Son.Nodes.Count = 0 Then
                treeNode_Son.Nodes.Add(computer.Powerplant.Manufacturer + " " + computer.Powerplant.Sertif)
            Else
                treeNode_Son.Nodes.Clear()
                treeNode_Son.Nodes.Add(computer.Powerplant.Manufacturer + " " + computer.Powerplant.Sertif)
            End If
            treeNode_Son.ExpandAll()
        ElseIf result = DialogResult.Cancel Then
            MessageBox.Show("Вы не сохранили выбор!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Powerplant_Frame.Dispose()
            result = Nothing
        End If
    End Sub

    Private Sub Butt_cooling_Click(sender As Object, e As EventArgs) Handles Butt_cooling.Click
        Dim result As DialogResult = Cooling_Frame.ShowDialog()
        If result = DialogResult.OK Then
            Dim Cooling_OUT As Cooling = Cooling_Frame.ResultObject
            computer.Cooling = Cooling_OUT
            Cooling_Frame.Dispose()
            result = Nothing
            Dim treeNode As TreeNode = Tree.Nodes(0)
            Dim treeNode_Son As TreeNode = treeNode.Nodes(6)
            If treeNode_Son.Nodes.Count = 0 Then
                treeNode_Son.Nodes.Add(computer.Cooling.Manufacturer + " " + computer.Cooling.Type)
            Else
                treeNode_Son.Nodes.Clear()
                treeNode_Son.Nodes.Add(computer.Cooling.Manufacturer + " " + computer.Cooling.Type)
            End If
            treeNode_Son.ExpandAll()
            If computer.CPU Is Nothing Then
                If Array.Find(computer.Cooling.Soket.Remove(" ").Trim.Split(","), Function(s) s = computer.CPU.Soket) IsNot Nothing Then
                    Dim treeNode_Son_X As TreeNode = treeNode.Nodes(0)
                    treeNode_Son_X.Nodes.Clear()
                    computer.Cooling = Nothing
                    MessageBox.Show("Сокет на процессоре не совпадает с охлаждением! Она будет сброшена, выберете новую!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        ElseIf result = DialogResult.Cancel Then
            MessageBox.Show("Вы не сохранили выбор!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cooling_Frame.Dispose()
            result = Nothing
        End If
    End Sub

    Private Sub Butt_RAM_Click(sender As Object, e As EventArgs) Handles Butt_RAM.Click
        Dim result As DialogResult = RAM_Frame.ShowDialog()
        If result = DialogResult.OK Then
            Dim RAM_OUT As RAM = RAM_Frame.ResultObject
            computer.Ram = RAM_OUT
            RAM_Frame.Dispose()
            result = Nothing
            Dim treeNode As TreeNode = Tree.Nodes(0)
            Dim treeNode_Son As TreeNode = treeNode.Nodes(3)
            If treeNode_Son.Nodes.Count = 0 Then
                treeNode_Son.Nodes.Add(computer.Ram.Manufacturer + " " + computer.Ram.Type_RAM + " " + computer.Ram.Sum_RAM.ToString)
            Else
                treeNode_Son.Nodes.Clear()
                treeNode_Son.Nodes.Add(computer.Ram.Manufacturer + " " + computer.Ram.Type_RAM + " " + computer.Ram.Sum_RAM.ToString)
            End If
            treeNode_Son.ExpandAll()

            If computer.Motherboard IsNot Nothing Then
                Dim treeNode_Son_X As TreeNode = treeNode.Nodes(0)
                treeNode_Son_X.Nodes.Clear()
                computer.Ram = Nothing
                MessageBox.Show("Тип на оперативной памяти не совпадает с материнской платой! Она будет сброшена, выберете новую!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        ElseIf result = DialogResult.Cancel Then
            MessageBox.Show("Вы не сохранили выбор!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RAM_Frame.Dispose()
            result = Nothing
        End If
    End Sub

    Private Sub butt_disk_Click(sender As Object, e As EventArgs) Handles butt_disk.Click
        Dim result As DialogResult = Disk_Frame.ShowDialog()
        If result = DialogResult.OK Then
            Dim disk_OUT As Disk = Disk_Frame.ResultObject
            computer.Disk = disk_OUT
            Disk_Frame.Dispose()
            result = Nothing
            Dim treeNode As TreeNode = Tree.Nodes(0)
            Dim treeNode_Son As TreeNode = treeNode.Nodes(4)
            If treeNode_Son.Nodes.Count < 1 Then
                treeNode_Son.Nodes.Add(disk_OUT.Manufacturer + " " + disk_OUT.V_of_disk.ToString)
            Else
                treeNode_Son.Nodes.Clear()
                treeNode_Son.Nodes.Add(disk_OUT.Manufacturer + " " + disk_OUT.V_of_disk.ToString)
            End If
            treeNode_Son.ExpandAll()
        ElseIf result = DialogResult.Cancel Then
            MessageBox.Show("Вы не сохранили выбор!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Disk_Frame.Dispose()
            result = Nothing
        End If
    End Sub

    Private Sub butt_GPU_Click(sender As Object, e As EventArgs) Handles butt_GPU.Click
        Dim result As DialogResult = GPU_Frame.ShowDialog()
        If result = DialogResult.OK Then
            Dim GPU_OUT As GPU = GPU_Frame.ResultObject
            computer.GPU = GPU_OUT
            GPU_Frame.Dispose()
            result = Nothing
            Dim treeNode As TreeNode = Tree.Nodes(0)
            Dim treeNode_Son As TreeNode = treeNode.Nodes(2)
            If treeNode_Son.Nodes.Count = 0 Then
                treeNode_Son.Nodes.Add(computer.GPU.Manufacturer + " " + computer.GPU.V_GPU.ToString + " " + computer.GPU.Model)
            Else
                treeNode_Son.Nodes.Clear()
                treeNode_Son.Nodes.Add(computer.GPU.Manufacturer + " " + computer.GPU.V_GPU.ToString + " " + computer.GPU.Model)
            End If
            treeNode_Son.ExpandAll()
        ElseIf result = DialogResult.Cancel Then
            MessageBox.Show("Вы не сохранили выбор!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GPU_Frame.Dispose()
            result = Nothing
        End If
    End Sub


    Dim cost As Integer
    Private Sub butt_summ_Click(sender As Object, e As EventArgs) Handles butt_summ.Click

        If computer.Cooling IsNot Nothing Then
            cost += computer.Cooling.Cost
        End If
        If computer.CPU IsNot Nothing Then
            cost += computer.CPU.Cost
        End If
        If computer.Disk IsNot Nothing Then
            cost += computer.Disk.Cost
        End If

        If computer.Frame IsNot Nothing Then
            cost += computer.Frame.Cost
        End If

        If computer.GPU IsNot Nothing Then
            cost += computer.GPU.Cost
        End If

        If computer.Motherboard IsNot Nothing Then
            cost += computer.Motherboard.Cost
        End If

        If computer.Powerplant IsNot Nothing Then
            cost += computer.Powerplant.Cost
        End If

        If computer.Ram IsNot Nothing Then
            cost += computer.Ram.Cost
        End If

        txt_summ.Text = cost.ToString + "руб"
    End Sub

    Private Sub butt_save_Click(sender As Object, e As EventArgs) Handles butt_save.Click
        Dim filePath As String = "file.txt"
        Dim textToSave As String = $"Computer:" 
        if computer.Cooling IsNot Nothing Then
            textToSave = textToSave + $"
Cooling:
    Id - {computer.Cooling.Id}  
    Manufacturer - {computer.Cooling.Manufacturer}  
    Weight - {computer.Cooling.Weight}  
    Type - {computer.Cooling.Type}  
    Soket - {computer.Cooling.Soket}  
    For_what - {computer.Cooling.For_what}  
    TDP - {computer.Cooling.TDP}  
    Length - {computer.Cooling.Length}   
    Cost - {computer.Cooling.Cost}"
        End If
        If computer.CPU IsNot Nothing Then
            textToSave = textToSave + $"
CPU:
Id - {computer.CPU.Id}
Manufacturer - {computer.CPU.Manufacturer}
Model - {computer.CPU.Model}
Soket - {computer.CPU.Soket}
Sistem_cooling_in - {computer.CPU.Sistem_cooling_in}
Cores - {computer.CPU.Cores}
Process_cores - {computer.CPU.Process_cores}
Max_kol_potok - {computer.CPU.Max_kol_potok}
KESH - {computer.CPU.KESH}
Baze_speed - {computer.CPU.Baze_speed}
Max_speed - {computer.CPU.Max_speed}
Type_RAM - {computer.CPU.Type_RAM}
Max_speed_RAM - {computer.CPU.Max_speed_RAM}
Max_RAM - {computer.CPU.Max_RAM}
TDP - {computer.CPU.TDP}
In_GPU - {computer.CPU.In_GPU}
Control_PCI - {computer.CPU.Control_PCI}
Kol_lines - {computer.CPU.Kol_lines}
Cost - {computer.CPU.Cost}"
        End If
        If computer.Disk IsNot Nothing Then
            textToSave = textToSave + $"
Disk:
Id - {computer.Disk.Id}
Manufacturer - {computer.Disk.Manufacturer}
Weight - {computer.Disk.Weight}
Type - {computer.Disk.Type}
V_of_disk - {computer.Disk.V_of_disk}
Interface - {computer.Disk.Interface_q}
Max_speed_read - {computer.Disk.Max_speed_read}
Max_speed_write - {computer.Disk.Max_speed_write}
Max_V_write - {computer.Disk.Max_V_write}
Length - {computer.Disk.Length}
Cost - {computer.Disk.Cost}"
        End If

        If computer.Frame IsNot Nothing Then
            textToSave = textToSave + $"
Frame:
Id - {computer.Frame.Id}
Manufacturer - {computer.Frame.Manufacturer}
Hight - {computer.Frame.Hight}
Width - {computer.Frame.Width}
Length - {computer.Frame.Length}
Weight - {computer.Frame.Weight}
Color - {computer.Frame.Color}
Material - {computer.Frame.Material}
Form_factor - {computer.Frame.Form_factor}
Max_lenght_of_GPU - {computer.Frame.Max_lenght_of_GPU}
Water_cooling - {computer.Frame.Water_cooling}
Cost - {computer.Frame.Cost}"
        End If

        If computer.GPU IsNot Nothing Then
            textToSave = textToSave + $"
GPU:
Id - {computer.GPU.Id}
Manufacturer - {computer.GPU.Manufacturer}
Weight - {computer.GPU.Weight}
Color - {computer.GPU.Color}
Model - {computer.GPU.Model}
Graphic_unit - {computer.GPU.Graphic_unit}
Frequency - {computer.GPU.Frequency}
Turbofrequency - {computer.GPU.Turbofrequency}
DLSS - {computer.GPU.DLSS}
V_GPU - {computer.GPU.V_GPU}
Type_of_memory - {computer.GPU.Type_of_memory}
Type_of_ports - {computer.GPU.Type_of_ports}
Kol_ports - {computer.GPU.Kol_ports}
Interface - {computer.GPU.Interface_q}
Dop_power - {computer.GPU.Dop_power}
Type_of_cooling - {computer.GPU.Type_of_cooling}
LED - {computer.GPU.LED}
Cost - {computer.GPU.Cost}"
        End If

        If computer.Motherboard IsNot Nothing Then
            textToSave = textToSave + $"
Motherboard:
Id - {computer.Motherboard.Id}
Manufacturer - {computer.Motherboard.Manufacturer}
Weight - {computer.Motherboard.Weight}
Color - {computer.Motherboard.Color}
Length - {computer.Motherboard.Length}
Width - {computer.Motherboard.Width}
Soket - {computer.Motherboard.Soket}
Type_RAM - {computer.Motherboard.Type_RAM}
Max_V_RAM - {computer.Motherboard.Max_V_RAM}
Max_speed_RAM - {computer.Motherboard.Max_speed_RAM}
Kol_slots_RAM - {computer.Motherboard.Kol_slots_RAM}
PCI_version - {computer.Motherboard.PCI_version}
Kol_M2 - {computer.Motherboard.Kol_M2}
USB - {computer.Motherboard.USB}
Video_port - {computer.Motherboard.Video_port}
Form_factor - {computer.Motherboard.Form_factor}
Esernet_adapter - {computer.Motherboard.Esernet_adapter}
Esernet_speed - {computer.Motherboard.Esernet_speed}
Cost - {computer.Motherboard.Cost}"
        End If

        If computer.Powerplant IsNot Nothing Then
            textToSave = textToSave + $"Powerplant:
Id - {computer.Powerplant.Id}
Manufacturer - {computer.Powerplant.Manufacturer}
Weight - {computer.Powerplant.Weight}
Color - {computer.Powerplant.Color}
Сapacity - {computer.Powerplant.Сapacity}
Form_factor - {computer.Powerplant.Form_factor}
Power_CPU - {computer.Powerplant.Power_CPU}
Power_GPU - {computer.Powerplant.Power_GPU}
15_pin_SATA - {computer.Powerplant.l_15_pin_SATA}
4_pin_Molex - {computer.Powerplant.l_4_pin_Molex}
Cooling_system - {computer.Powerplant.Cooling_system}
Sertif - {computer.Powerplant.Sertif}
Cost - {computer.Powerplant.Cost}"
        End If

        If computer.Ram IsNot Nothing Then
            textToSave = textToSave + $"
Ram:
Id - {computer.Ram.Id}
Manufacturer - {computer.Ram.Manufacturer}
Color - {computer.Ram.Color}
Type_RAM - {computer.Ram.Type_RAM}
Sum_RAM - {computer.Ram.Sum_RAM}
One_RAM - {computer.Ram.One_RAM}
Kol_RAM - {computer.Ram.Kol_RAM}
Speed_RAM - {computer.Ram.Speed_RAM}
Cooler_RAM - {computer.Ram.Cooler_RAM}
Cost - {computer.Ram.Cost}"
        End If
        textToSave = textToSave + "
Итог: " + cost.ToString + "руб."


        FileOpen(1, filePath, OpenMode.Output)
        Print(1, textToSave)  ' Запись строки
        MessageBox.Show($"Сборка сохранена.
Путь:{filePath}", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        FileClose(1)          ' Закрытие файла


    End Sub
    Private Sub Sborka_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub Sborka_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        butt_disk.Enabled = False
        butt_GPU.Enabled = False
        butt_motherboard.Enabled = False
        butt_save.Enabled = False
        butt_summ.Enabled = False
        Butt_RAM.Enabled = False
        Butt_powerplant.Enabled = False
        Butt_Frame.Enabled = False
        butt_disk.Enabled = False
        Butt_cooling.Enabled = False
        Me.computer = New Computer
        Tree.ExpandAll()
    End Sub
    Private Sub butt_close_Click(sender As Object, e As EventArgs) Handles butt_close.Click
        Me.Close()
    End Sub

    Private Sub Tree_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles Tree.AfterSelect
        If Tree.SelectedNode.Tag Is Nothing Then
            Dim Parent As TreeNode = Tree.SelectedNode.Parent
            Select Case Tree.SelectedNode.Parent.Tag
                Case 1
                    computer.Motherboard = Nothing
                    Parent.Nodes.Clear()
                Case 2
                    computer.CPU = Nothing
                    Parent.Nodes.Clear()
                Case 3
                    computer.GPU = Nothing
                    Parent.Nodes.Clear()
                Case 4
                    computer.Ram = Nothing
                    Parent.Nodes.Clear()
                Case 5
                    computer.Disk = Nothing
                    Parent.Nodes.Clear()
                Case 6
                    computer.Powerplant = Nothing
                    Parent.Nodes.Clear()
                Case 7
                    computer.Cooling = Nothing
                    Parent.Nodes.Clear()
                Case 8
                    computer.Frame = Nothing
                    Parent.Nodes.Clear()
            End Select
        End If

    End Sub

End Class