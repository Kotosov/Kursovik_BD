Imports System.ComponentModel.Design
Imports Windows.Win32.System

Public Class Motherboard_Frame
    Private _resultObject As Motherboard
    Dim count1, count2, count3, count4, all(0 To 3), kol_m2(), max_speed() As Integer
    Dim manu(), type_ram() As String
    Dim intriger As Integer = 0
    Public Property ResultObject() As Motherboard ' Public свойство для доступа к объекту
        Get
            Return _resultObject
        End Get
        Set(value As Motherboard)
            _resultObject = value
        End Set
    End Property
    Dim CO = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Kurs.accdb;Persist Security Info=False;")
    Private Sub butt_save_Click(sender As Object, e As EventArgs) Handles butt_save.Click
        CO.open()
        Dim Manufacturer As String, Weight As Double, Color As String, Length As Double, Width As Double, Soket As String, Type_RAM As String, Max_V_RAM As Integer, Max_speed_RAM As Integer, Kol_slots_RAM As Integer, PCI_version As String, Kol_M2 As Integer, USB As Integer, Video_port As String, Form_factor As String, Esernet_adapter As String, Esernet_speed As String, Cost As Decimal
        Dim choose_Motherboard As Motherboard
        Dim id As Integer = Nud_id.Value
        Dim command_8 = $"SELECT * FROM MATHERBOARD WHERE Id = '2_{id}'"
        Dim COMMAND8 As New System.Data.OleDb.OleDbCommand(command_8, CO)
        Dim DATA8 As System.Data.OleDb.OleDbDataReader = COMMAND8.ExecuteReader(CommandBehavior.CloseConnection)

        Try
            DATA8.Read()
            Manufacturer = DATA8.GetValue(2)
            Weight = DATA8.GetValue(3)
            Color = DATA8.GetValue(4)
            Length = DATA8.GetValue(5)
            Width = DATA8.GetValue(6)
            Soket = DATA8.GetValue(7)
            If Soket <> Sborka.computer.CPU.Soket Then
                Throw New Exception("Сокет материнской платы не соответствует выбранному процессору! Поменяйте выбор из предложенных.")
            End If
            Type_RAM = DATA8.GetValue(8)
            Max_V_RAM = DATA8.GetValue(9)
            Max_speed_RAM = DATA8.GetValue(10)
            Kol_slots_RAM = DATA8.GetValue(11)
            PCI_version = DATA8.GetValue(12).ToString + ".0"
            Kol_M2 = DATA8.GetValue(13)
            USB = DATA8.GetValue(14)
            Video_port = DATA8.GetValue(15)
            Form_factor = DATA8.GetValue(16)
            Esernet_adapter = DATA8.GetValue(17)
            Esernet_speed = DATA8.GetValue(18)
            Cost = DATA8.GetValue(19)
            choose_Motherboard = New Motherboard(id, Manufacturer, Weight, Color, Length, Width, Soket,
                                                 Type_RAM, Max_V_RAM, Max_speed_RAM, Kol_slots_RAM, PCI_version,
                                                 Kol_M2, USB, Video_port, Form_factor, Esernet_adapter, Esernet_speed, Cost)
            Me.ResultObject = choose_Motherboard
            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            CO.close()
        End Try
    End Sub

    Private Sub butt_close_Click(sender As Object, e As EventArgs) Handles butt_close.Click
        If (CO.State = ConnectionState.Open) Then
            CO.Close()
        End If
        Me.DialogResult = DialogResult.Cancel
    End Sub
    Public Sub Obnov()
        Dim whereClauses As New List(Of String)()
        Dim command_7 As String
        Dim soket As String = Sborka.computer.CPU.Soket
        If intriger < 4 Then
            intriger += 1
            Return
        Else
            CO.Open()
            ' Формируем условия WHERE
            If Cmb_manuf.Text() <> "Все" Then
                whereClauses.Add($"Manufacturer = '{Cmb_manuf.SelectedItem}'")
            End If

            If Cmb_Type_RAM.Text() <> "Все" Then
                whereClauses.Add($"Type_RAM = '{Cmb_Type_RAM.SelectedItem}'")
            End If

            If Cmb_Max_speed_RAM.Text() <> "Все" Then
                whereClauses.Add($"Max_speed_RAM <= {Cmb_Max_speed_RAM.SelectedItem}")
            End If

            If Cmb_kol_m2.Text <> "Все" Then
                whereClauses.Add($"Kol_M2 = {Cmb_kol_m2.SelectedItem}")

            End If

            ' Собираем итоговый SQL
            command_7 = "SELECT * FROM MATHERBOARD" & " WHERE " & $"Soket = '{soket}'"
            If whereClauses.Count > 0 Then
                command_7 = command_7 & " AND " & String.Join(" AND ", whereClauses)
            End If
            Dim COMMAND7 As New System.Data.OleDb.OleDbCommand(command_7, CO)
            Dim DATA7 As System.Data.OleDb.OleDbDataReader = COMMAND7.ExecuteReader(CommandBehavior.CloseConnection)
            Dim dataTable As New DataTable()
            dataTable.Load(DATA7)
            DataGV.DataSource = dataTable
            CO.Close
        End If
    End Sub
    Private Sub Motherboard_Frame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CO.Open
        Cmb_manuf.Items.Clear()
        Cmb_Type_RAM.Items.Clear()
        Cmb_kol_m2.Items.Clear()
        Cmb_Max_speed_RAM.Items.Clear()
        Dim command_1 As String = "SELECT COUNT(*) 
FROM (SELECT DISTINCT Manufacturer FROM MATHERBOARD)
UNION ALL
    Select COUNT(*)
FROM (SELECT DISTINCT Max_speed_RAM FROM MATHERBOARD)
UNION ALL
    Select COUNT(*)
FROM (SELECT DISTINCT Kol_M2 FROM MATHERBOARD) 
UNION ALL
    Select COUNT(*) FROM (Select DISTINCT Type_RAM FROM MATHERBOARD);"
        Dim COMMAND As New System.Data.OleDb.OleDbCommand(command_1, CO)
        Dim DATA1 As System.Data.OleDb.OleDbDataReader = COMMAND.ExecuteReader(CommandBehavior.CloseConnection)

        For i = 0 To 3
            DATA1.Read()
            all(i) = DATA1.GetValue(0)
        Next
        count1 = all(0)
        count4 = all(1)
        count3 = all(2)
        count2 = all(3)
        ReDim manu(0 To count1 - 1), type_ram(0 To count2 - 1), kol_m2(0 To count3 - 1), max_speed(0 To count4 - 1)
        Dim command_2 As String = "Select DISTINCT Manufacturer FROM MATHERBOARD"
        Dim COMMAND2 As New System.Data.OleDb.OleDbCommand(command_2, CO)
        Dim DATA2 As System.Data.OleDb.OleDbDataReader = COMMAND2.ExecuteReader(CommandBehavior.CloseConnection)
        For i = 0 To count1 - 1
            DATA2.Read()
            manu(i) = DATA2.GetValue(0)
        Next
        Cmb_manuf.Items.AddRange(manu)
        Cmb_manuf.Items.Add("Все")
        Cmb_manuf.SelectedItem = "Все"
        Dim command_3 As String = "Select DISTINCT Type_RAM FROM MATHERBOARD"
        Dim COMMAND3 As New System.Data.OleDb.OleDbCommand(command_3, CO)
        Dim DATA3 As System.Data.OleDb.OleDbDataReader = COMMAND3.ExecuteReader(CommandBehavior.CloseConnection)
        For i = 0 To count2 - 1
            DATA3.Read()
            type_ram(i) = DATA3.GetValue(0)
        Next
        Cmb_Type_RAM.Items.AddRange(type_ram)
        Cmb_Type_RAM.Items.Add("Все")
        Cmb_Type_RAM.SelectedItem = "Все"
        Dim command_4 As String = "Select DISTINCT Kol_M2 FROM MATHERBOARD"
        Dim COMMAND4 As New System.Data.OleDb.OleDbCommand(command_4, CO)
        Dim DATA4 As System.Data.OleDb.OleDbDataReader = COMMAND4.ExecuteReader(CommandBehavior.CloseConnection)
        For i = 0 To count3 - 1
            DATA4.Read()
            kol_m2(i) = DATA4.GetValue(0)
        Next
        Cmb_kol_m2.Items.AddRange(String.Join(", ", kol_m2).Split(New String() {", "}, StringSplitOptions.None))
        Cmb_kol_m2.Items.Add("Все")
        Cmb_kol_m2.SelectedItem = "Все"
        Dim command_5 As String = "Select DISTINCT Max_speed_RAM FROM MATHERBOARD"
        Dim COMMAND5 As New System.Data.OleDb.OleDbCommand(command_5, CO)
        Dim DATA5 As System.Data.OleDb.OleDbDataReader = COMMAND5.ExecuteReader(CommandBehavior.CloseConnection)
        For i = 0 To count4 - 1
            DATA5.Read()
            max_speed(i) = DATA5.GetValue(0)
        Next
        Cmb_Max_speed_RAM.Items.AddRange(String.Join(", ", max_speed).Split(New String() {", "}, StringSplitOptions.None))
        Cmb_Max_speed_RAM.Items.Add("Все")
        Cmb_Max_speed_RAM.SelectedItem = "Все"

        CO.Close
    End Sub

    Private Sub Cmb_manuf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_manuf.SelectedIndexChanged
        Obnov()
    End Sub

    Private Sub Cmb_Type_RAM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Type_RAM.SelectedIndexChanged
        Obnov()
    End Sub

    Private Sub Cmb_Max_speed_RAM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Max_speed_RAM.SelectedIndexChanged
        Obnov()
    End Sub

    Private Sub Cmb_kol_m2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_kol_m2.SelectedIndexChanged
        Obnov()
    End Sub




End Class