Public Class GPU_Frame
    Private _resultObject As GPU
    Dim count1, count2, all(0 To 1) As Integer
    Dim manu(), V_graf() As String
    Dim intriger As Integer = 0
    Public Property ResultObject() As GPU ' Public свойство для доступа к объекту
        Get
            Return _resultObject
        End Get
        Set(value As GPU)
            _resultObject = value
        End Set
    End Property
    Public Sub Obnov()
        Dim whereClauses As New List(Of String)()
        Dim interfaceClauses As New List(Of String)()
        Dim command_7 As String
        If intriger < 2 Then
            intriger += 1
            Return
        Else
            CO.Open()
            ' Формируем условия WHERE
            If Cmb_Manuf.Text() <> "Все" Then
                whereClauses.Add($"Manufacturer = '{Cmb_Manuf.SelectedItem}'")
            End If

            If Cmb_V_graf.Text() <> "Все" Then
                whereClauses.Add($"V_GPU = {Cmb_V_graf.SelectedItem}")
            End If
            If Sborka.computer.CPU IsNot Nothing Then

                Dim Interface_i() As String = Sborka.computer.CPU.Control_PCI.Split(",", StringSplitOptions.None)
                For Each i As String In Interface_i
                    interfaceClauses.Add($"Interface = '{i}'")
                Next
            End If

            If interfaceClauses.Count > 1 Then
                Dim interfaceCondition As String = "(" & String.Join(" OR ", interfaceClauses) & ")"
                whereClauses.Add(interfaceCondition)
            End If

            ' Собираем итоговый SQL
            command_7 = "SELECT * FROM GPU"
            If whereClauses.Count > 0 Then
                command_7 = command_7 & " WHERE " & String.Join(" AND ", whereClauses)
            End If
            Dim COMMAND7 As New System.Data.OleDb.OleDbCommand(command_7, CO)
            Dim DATA7 As System.Data.OleDb.OleDbDataReader = COMMAND7.ExecuteReader(CommandBehavior.CloseConnection)
            Dim dataTable As New DataTable()
            dataTable.Load(DATA7)
            DataGV.DataSource = dataTable
            CO.Close
        End If
    End Sub
    Dim CO = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Kurs.accdb;Persist Security Info=False;")

    Private Sub GPU_Frame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CO.Open
        Cmb_Manuf.Items.Clear()
        Cmb_V_graf.Items.Clear()
        Dim command_1 As String = "SELECT COUNT(*) 
FROM (SELECT DISTINCT Manufacturer FROM GPU)
UNION ALL
    Select COUNT(*)
FROM (SELECT DISTINCT V_GPU FROM GPU);"
        Dim COMMAND As New System.Data.OleDb.OleDbCommand(command_1, CO)
        Dim DATA1 As System.Data.OleDb.OleDbDataReader = COMMAND.ExecuteReader(CommandBehavior.CloseConnection)
        For i = 0 To 1
            DATA1.Read()
            all(i) = DATA1.GetValue(0)
        Next
        count1 = all(0)
        count2 = all(1)
        ReDim manu(0 To count1 - 1), V_graf(0 To count2 - 1)
        Dim command_2 As String = "SELECT DISTINCT Manufacturer FROM GPU"
        Dim COMMAND2 As New System.Data.OleDb.OleDbCommand(command_2, CO)
        Dim DATA2 As System.Data.OleDb.OleDbDataReader = COMMAND2.ExecuteReader(CommandBehavior.CloseConnection)
        For i = 0 To count1 - 1
            DATA2.Read()
            manu(i) = DATA2.GetValue(0)
        Next
        Cmb_Manuf.Items.AddRange(manu)
        Cmb_Manuf.Items.Add("Все")
        Cmb_Manuf.SelectedItem = "Все"
        Dim command_3 As String = "SELECT DISTINCT V_GPU FROM GPU"
        Dim COMMAND3 As New System.Data.OleDb.OleDbCommand(command_3, CO)
        Dim DATA3 As System.Data.OleDb.OleDbDataReader = COMMAND3.ExecuteReader(CommandBehavior.CloseConnection)
        For i = 0 To count2 - 1
            DATA3.Read()
            V_graf(i) = DATA3.GetValue(0)
        Next
        Cmb_V_graf.Items.AddRange(V_graf)
        Cmb_V_graf.Items.Add("Все")
        Cmb_V_graf.SelectedItem = "Все"
        CO.Close
    End Sub
    Private Sub Cmb_Manuf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Manuf.SelectedIndexChanged
        Obnov()
    End Sub

    Private Sub Cmb_V_graf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_V_graf.SelectedIndexChanged
        Obnov()
    End Sub

    Private Sub butt_save_Click(sender As Object, e As EventArgs) Handles butt_save.Click
        CO.open()
        Dim Manufacturer As String, Weight As Double, Color As String, Model As String, Graphic_unit As String, Frequency As Integer, Turbofrequency As Integer, DLSS As Boolean, V_GPU As Integer, Type_of_memory As String, Type_of_ports As String, Kol_ports As Integer, Interface_q As String, Dop_power As String, Type_of_cooling As String, LED As Boolean, Cost As Decimal
        Dim choose_GPU As GPU
        Dim id As Integer = Nud_id.Value
        Dim command_8 = $"SELECT * FROM GPU WHERE Id = '6_{id}'"
        Dim COMMAND8 As New System.Data.OleDb.OleDbCommand(command_8, CO)
        Dim DATA8 As System.Data.OleDb.OleDbDataReader = COMMAND8.ExecuteReader(CommandBehavior.CloseConnection)
        Try
            DATA8.Read()
            Manufacturer = DATA8.GetValue(2)
            Weight = DATA8.GetValue(3)
            Color = DATA8.GetValue(4)
            Model = DATA8.GetValue(5)
            Graphic_unit = DATA8.GetValue(6)
            Frequency = DATA8.GetValue(7)
            Turbofrequency = DATA8.GetValue(8)
            DLSS = If(DATA8.GetValue(9) = "Да", True, False)
            V_GPU = DATA8.GetValue(10)
            Type_of_memory = DATA8.GetValue(11)
            Type_of_ports = DATA8.GetValue(12)
            Kol_ports = DATA8.GetValue(13)
            Interface_q = DATA8.GetValue(14)
            Dop_power = DATA8.GetValue(15)
            Type_of_cooling = DATA8.GetValue(16)
            LED = If(DATA8.GetValue(17) = "Да", True, False)
            Cost = DATA8.GetValue(18)
            choose_GPU = New GPU(id, Manufacturer, Weight, Color, Model, Graphic_unit,
            Frequency, Turbofrequency, DLSS, V_GPU, Type_of_memory,
            Type_of_ports, Kol_ports, Interface_q, Dop_power, Type_of_cooling, LED, Cost)
            Me.ResultObject = choose_GPU
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


End Class