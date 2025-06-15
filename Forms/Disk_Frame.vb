Public Class Disk_Frame
    Private _resultObject As Disk
    Dim count1, count2, all(0 To 1) As Integer
    Dim manu(), V_graf() As String
    Dim intriger As Integer = 0
    Public Property ResultObject() As Disk ' Public свойство для доступа к объекту
        Get
            Return _resultObject
        End Get
        Set(value As Disk)
            _resultObject = value
        End Set
    End Property
    Public Sub Obnov()
        Dim whereClauses As New List(Of String)()
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

            If Cmb_V_disk.Text() <> "Все" Then
                whereClauses.Add($"V_of_disk = {Cmb_V_disk.SelectedItem}")
            End If

            ' Собираем итоговый SQL
            command_7 = "SELECT * FROM DISK"
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

    Private Sub Cmb_V_disk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_V_disk.SelectedIndexChanged
        Obnov()
    End Sub

    Private Sub Cmb_Manuf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Manuf.SelectedIndexChanged
        Obnov()
    End Sub

    Private Sub butt_save_Click(sender As Object, e As EventArgs) Handles butt_save.Click
        CO.open()
        Dim Manufacturer As String, Weight As Double, Type As String, V_of_disk As Integer, Interface_q As String, Max_speed_read As Integer, Max_speed_write As Integer, Max_V_write As Integer, Length As Double, Cost As Decimal
        Dim choose_DISK As Disk
        Dim id As Integer = Nud_id.Value
        Dim command_8 = $"SELECT * FROM DISK WHERE Id = '7_{id}'"
        Dim COMMAND8 As New System.Data.OleDb.OleDbCommand(command_8, CO)
        Dim DATA8 As System.Data.OleDb.OleDbDataReader = COMMAND8.ExecuteReader(CommandBehavior.CloseConnection)
        Try
            DATA8.Read()
            Manufacturer = DATA8.GetValue(2)
            Weight = DATA8.GetValue(3)
            Type = DATA8.GetValue(4)
            V_of_disk = DATA8.GetValue(5)
            Interface_q = DATA8.GetValue(6)
            Max_speed_read = DATA8.GetValue(7)
            Max_speed_write = DATA8.GetValue(8)
            Max_V_write = Integer.Parse(DATA8.GetValue(9).ToString().Replace(" TBW", "").Trim())
            Length = DATA8.GetValue(10)
            Cost = DATA8.GetValue(11)
            choose_DISK = New Disk(id, Manufacturer, Weight, Type, V_of_disk, Interface_q, Max_speed_read, Max_speed_write, Max_V_write, Length, Cost)
            Me.ResultObject = choose_DISK
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

    Private Sub Disk_Frame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CO.Open
        Cmb_Manuf.Items.Clear()
        Cmb_V_disk.Items.Clear()
        Dim command_1 As String = "SELECT COUNT(*) 
FROM (SELECT DISTINCT Manufacturer FROM DISK)
UNION ALL
    Select COUNT(*)
FROM (SELECT DISTINCT V_of_disk FROM DISK);"
        Dim COMMAND As New System.Data.OleDb.OleDbCommand(command_1, CO)
        Dim DATA1 As System.Data.OleDb.OleDbDataReader = COMMAND.ExecuteReader(CommandBehavior.CloseConnection)
        For i = 0 To 1
            DATA1.Read()
            all(i) = DATA1.GetValue(0)
        Next
        count1 = all(0)
        count2 = all(1)
        ReDim manu(0 To count1 - 1), V_graf(0 To count2 - 1)
        Dim command_2 As String = "SELECT DISTINCT Manufacturer FROM DISK"
        Dim COMMAND2 As New System.Data.OleDb.OleDbCommand(command_2, CO)
        Dim DATA2 As System.Data.OleDb.OleDbDataReader = COMMAND2.ExecuteReader(CommandBehavior.CloseConnection)
        For i = 0 To count1 - 1
            DATA2.Read()
            manu(i) = DATA2.GetValue(0)
        Next
        Cmb_Manuf.Items.AddRange(manu)
        Cmb_Manuf.Items.Add("Все")
        Cmb_Manuf.SelectedItem = "Все"
        Dim command_3 As String = "SELECT DISTINCT V_of_disk FROM DISK"
        Dim COMMAND3 As New System.Data.OleDb.OleDbCommand(command_3, CO)
        Dim DATA3 As System.Data.OleDb.OleDbDataReader = COMMAND3.ExecuteReader(CommandBehavior.CloseConnection)
        For i = 0 To count2 - 1
            DATA3.Read()
            V_graf(i) = DATA3.GetValue(0)
        Next
        Cmb_V_disk.Items.AddRange(V_graf)
        Cmb_V_disk.Items.Add("Все")
        Cmb_V_disk.SelectedItem = "Все"
        CO.Close
    End Sub
End Class