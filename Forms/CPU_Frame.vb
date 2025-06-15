Imports System.Reflection

Public Class CPU_Frame
    Dim Id, Soket, Sistem_cooling_in, Cores, Process_cores, Max_kol_potok, KESH, Baze_speed, Max_speed, Type_RAM, Max_speed_RAM, Max_RAM, TDP, In_GPU, Control_PCI, Kol_lines, Cost As String

    Private _resultObject As CPU
    Dim CO = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Kurs.accdb;Persist Security Info=False;")
    Public Property ResultObject() As CPU ' Public свойство для доступа к объекту
        Get
            Return _resultObject
        End Get
        Set(value As CPU)
            _resultObject = value
        End Set
    End Property
    Private Sub butt_save_core_Click(sender As Object, e As EventArgs) Handles butt_save_core.Click
            Dim choose_CPU As CPU
        Try
            Dim Id_2 As Integer = Int32.Parse(Id.Substring(2))
            Dim core_2 As Integer = Int32.Parse(Cores)
            Dim Process_cores_2 As Integer = Int32.Parse(Process_cores)
            Dim Max_kol_potok_2 As Integer = Int32.Parse(Max_kol_potok)
            Dim Max_speed_RAM_2 As Integer = Int32.Parse(Max_speed_RAM)
            Dim Max_RAM_2 As Integer = Int32.Parse(Max_RAM)
            Dim TDP_2 As Integer = Int32.Parse(TDP)
            Dim Cost_2 As Decimal = Decimal.Parse(Cost)
            Dim KESH_2 As Double = Double.Parse(KESH)
            Dim Baze_speed_2 As Double = Double.Parse(Baze_speed)
            Dim Max_speed_2 As Double = Double.Parse(Max_speed)
            Dim result As Boolean = If(Sistem_cooling_in = "Нет", False, True)
            choose_CPU = New CPU(Id_2, Cmb_Manufacturer.Text, Cmb_model.Text, Soket,
                                 result, core_2, Process_cores_2, Max_kol_potok_2,
                                 KESH_2, Baze_speed_2, Max_speed_2, Type_RAM, Max_speed_RAM_2,
                                 Max_RAM_2, TDP_2, In_GPU, Control_PCI, Kol_lines, Cost_2)
            _resultObject = New CPU()
            ResultObject = choose_CPU
            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex, "Ошибка! ")
        End Try
    End Sub
    Private Sub butt_close_Click(sender As Object, e As EventArgs) Handles butt_close.Click
        If (CO.State = ConnectionState.Open) Then
            CO.Close()
        End If
        Me.DialogResult = DialogResult.Cancel
    End Sub
    Private Sub CPU_Frame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CO.Open
        Cmb_model.Items.Clear()
        Cmb_Manufacturer.Items.Clear()
        Dim count1 As Integer
        Dim manu() As String
        Dim command_1 As String = "SELECT COUNT(*) FROM (SELECT DISTINCT Manufacturer FROM CPU)"
        Dim COMMAND As New System.Data.OleDb.OleDbCommand(command_1, CO)
        Dim DATA1 As System.Data.OleDb.OleDbDataReader = COMMAND.ExecuteReader(CommandBehavior.CloseConnection)
        DATA1.Read()
        count1 = DATA1.GetValue(0)
        ReDim manu(0 To count1 - 1)
        Dim command_2 As String = "SELECT DISTINCT Manufacturer FROM CPU"
        Dim COMMAND2 As New System.Data.OleDb.OleDbCommand(command_2, CO)
        Dim DATA2 As System.Data.OleDb.OleDbDataReader = COMMAND2.ExecuteReader(CommandBehavior.CloseConnection)
        For i = 0 To count1 - 1
            DATA2.Read()
            manu(i) = DATA2.GetValue(0)
        Next
        Cmb_Manufacturer.Items.AddRange(manu)
        CO.Close
    End Sub
    Private Sub Cmb_Manufacturer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Manufacturer.SelectedIndexChanged
        CO.Open
        Cmb_model.Items.Clear()
        Dim count1 As Integer
        Dim ai As String = Cmb_Manufacturer.Items.Item(Cmb_Manufacturer.SelectedIndex)
        Dim manu() As String
        Dim command_1 As String = $"SELECT COUNT(*) FROM (SELECT DISTINCT Model FROM CPU WHERE Manufacturer = '{ai}')"
        Dim COMMAND As New System.Data.OleDb.OleDbCommand(command_1, CO)
        Dim DATA1 As System.Data.OleDb.OleDbDataReader = COMMAND.ExecuteReader(CommandBehavior.CloseConnection)
        DATA1.Read()
        count1 = DATA1.GetValue(0)
        ReDim manu(0 To count1 - 1)
        Dim command_2 As String = $"SELECT DISTINCT Model FROM CPU WHERE Manufacturer = '{ai}'"
        Dim COMMAND2 As New System.Data.OleDb.OleDbCommand(command_2, CO)
        Dim DATA2 As System.Data.OleDb.OleDbDataReader = COMMAND2.ExecuteReader(CommandBehavior.CloseConnection)
        For i = 0 To count1 - 1
            DATA2.Read()
            manu(i) = DATA2.GetValue(0)
        Next
        Cmb_model.Items.AddRange(manu)
        CO.Close
    End Sub
    Private Sub Cmb_model_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_model.SelectedIndexChanged
        CO.Open
        Dim ai As String = Cmb_model.Items.Item(Cmb_model.SelectedIndex)

        Dim command_1 As String = $"SELECT Soket,Sistem_cooling_in,Cores,Process_cores,Max_kol_potok,KESH,Baze_speed,Max_speed,Type_RAM,Max_speed_RAM,Max_RAM,TDP,In_GPU,Control_PCI,Kol_lines,Cost,Id FROM CPU WHERE Model = '{ai}'"
        Dim COMMAND As New System.Data.OleDb.OleDbCommand(command_1, CO)
        Dim DATA1 As System.Data.OleDb.OleDbDataReader = COMMAND.ExecuteReader(CommandBehavior.CloseConnection)
        DATA1.Read()
        Soket = DATA1.GetValue(0)
        Sistem_cooling_in = DATA1.GetValue(1)
        Cores = DATA1.GetValue(2)
        Process_cores = DATA1.GetValue(3)
        Max_kol_potok = DATA1.GetValue(4)
        KESH = DATA1.GetValue(5)
        Baze_speed = DATA1.GetValue(6)
        Max_speed = DATA1.GetValue(7)
        Type_RAM = DATA1.GetValue(8)
        Max_speed_RAM = DATA1.GetValue(9)
        Max_RAM = DATA1.GetValue(10)
        TDP = DATA1.GetValue(11)
        In_GPU = DATA1.GetValue(12)
        Control_PCI = DATA1.GetValue(13)
        Kol_lines = DATA1.GetValue(14)
        Cost = DATA1.GetValue(15)
        Id = DATA1.GetValue(16)
        lbl_info.Text = "Информация:" + vbCrLf + "Сокет - " + Soket + vbCrLf + "Система охалждения в комплекте: " + Sistem_cooling_in + vbCrLf + "Общее количество ядер: " + Cores + vbCrLf + "Количество производительных ядер: " + Process_cores + vbCrLf + "Максимальное число потоков: " + Max_kol_potok + vbCrLf + "Объем кэша: " + KESH + vbCrLf + "Базовая частота процессора: " + Baze_speed + vbCrLf + "Максимальная частота в турбо: " + Max_speed
        lbl_info2.Text = "Тип памяти: " + Type_RAM + vbCrLf + "Частота оперативной памяти: " + Max_speed_RAM + vbCrLf + "Максимально поддерживаемый объем памяти: " + Max_RAM + vbCrLf + "Тепловыделение: " + TDP + vbCrLf + "Интегрированное графическое ядро: " + In_GPU + vbCrLf + "Встроенный контроллер PCI Express: " + Control_PCI + vbCrLf + "Число линий PCI Express: " + Kol_lines + vbCrLf + "Цена: " + Cost
        CO.Close
    End Sub
End Class