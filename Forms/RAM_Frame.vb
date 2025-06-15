Public Class RAM_Frame
    Private _resultObject As RAM
    Dim count1, count2, all(0 To 1) As Integer
    Dim manu(), V_graf() As String
    Dim intriger As Integer = 0
    Public Property ResultObject() As RAM ' Public свойство для доступа к объекту
        Get
            Return _resultObject
        End Get
        Set(value As RAM)
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
            If Cmb_One_RAM.Text() <> "Все" Then
                whereClauses.Add($"One_RAM = {Cmb_One_RAM.SelectedItem}")
            End If

            If Cmb_Kol_RAM.Text() <> "Все" Then
                whereClauses.Add($"Kol_RAM = {Cmb_Kol_RAM.SelectedItem}")
            End If
            If Sborka.computer.Motherboard IsNot Nothing Then
                whereClauses.Add($"Speed_RAM <= {Sborka.computer.Motherboard.Max_speed_RAM}")
                whereClauses.Add($"Type_RAM = '{Sborka.computer.Motherboard.Type_RAM}'")
            End If
            ' Собираем итоговый SQL
            command_7 = "SELECT * FROM RAM"
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

    Private Sub Cmb_One_RAM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_One_RAM.SelectedIndexChanged
        Obnov()
    End Sub

    Private Sub Cmb_Kol_RAM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Kol_RAM.SelectedIndexChanged
        Obnov()
    End Sub

    Private Sub butt_save_Click(sender As Object, e As EventArgs) Handles butt_save.Click
        CO.open()
        Dim Manufacturer As String, Color As String, Type_RAM As String, Sum_RAM As Integer, One_RAM As Integer, Kol_RAM As Integer, Speed_RAM As Integer, Cooler_RAM As Boolean, Cost As Decimal
        Dim choose_RAM As RAM
        Dim id As Integer = Nud_id.Value
        Dim command_8 = $"SELECT * FROM RAM WHERE Id = '3_{id}'"
        Dim COMMAND8 As New System.Data.OleDb.OleDbCommand(command_8, CO)
        Dim DATA8 As System.Data.OleDb.OleDbDataReader = COMMAND8.ExecuteReader(CommandBehavior.CloseConnection)
        Try
            DATA8.Read()
            Manufacturer = DATA8.GetValue(2)
            Color = DATA8.GetValue(3)
            Type_RAM = DATA8.GetValue(4)
            Sum_RAM = DATA8.GetValue(5)
            One_RAM = DATA8.GetValue(6)
            Kol_RAM = DATA8.GetValue(7)
            Speed_RAM = DATA8.GetValue(8)
            Cooler_RAM = If(DATA8.GetValue(9) = "Да", True, False)
            Cost = DATA8.GetValue(10)
            choose_RAM = New RAM(id, Manufacturer, Color, Type_RAM, Sum_RAM, One_RAM, Kol_RAM, Speed_RAM, Cooler_RAM, Cost)
            Me.ResultObject = choose_RAM
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

    Private Sub RAM_Frame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CO.Open
        Cmb_One_RAM.Items.Clear()
        Cmb_Kol_RAM.Items.Clear()
        Dim command_1 As String = "SELECT COUNT(*) 
FROM (SELECT DISTINCT One_RAM FROM RAM)
UNION ALL
    Select COUNT(*)
FROM (SELECT DISTINCT Kol_RAM FROM RAM);"
        Dim COMMAND As New System.Data.OleDb.OleDbCommand(command_1, CO)
        Dim DATA1 As System.Data.OleDb.OleDbDataReader = COMMAND.ExecuteReader(CommandBehavior.CloseConnection)
        For i = 0 To 1
            DATA1.Read()
            all(i) = DATA1.GetValue(0)
        Next
        count1 = all(0)
        count2 = all(1)
        ReDim manu(0 To count1 - 1), V_graf(0 To count2 - 1)
        Dim command_2 As String = "SELECT DISTINCT One_RAM FROM RAM"
        Dim COMMAND2 As New System.Data.OleDb.OleDbCommand(command_2, CO)
        Dim DATA2 As System.Data.OleDb.OleDbDataReader = COMMAND2.ExecuteReader(CommandBehavior.CloseConnection)
        For i = 0 To count1 - 1
            DATA2.Read()
            manu(i) = DATA2.GetValue(0)
        Next
        Cmb_One_RAM.Items.AddRange(manu)
        Cmb_One_RAM.Items.Add("Все")
        Cmb_One_RAM.SelectedItem = "Все"
        Dim command_3 As String = "SELECT DISTINCT Kol_RAM FROM RAM"
        Dim COMMAND3 As New System.Data.OleDb.OleDbCommand(command_3, CO)
        Dim DATA3 As System.Data.OleDb.OleDbDataReader = COMMAND3.ExecuteReader(CommandBehavior.CloseConnection)
        For i = 0 To count2 - 1
            DATA3.Read()
            V_graf(i) = DATA3.GetValue(0)
        Next
        Cmb_Kol_RAM.Items.AddRange(V_graf)
        Cmb_Kol_RAM.Items.Add("Все")
        Cmb_Kol_RAM.SelectedItem = "Все"
        CO.Close
    End Sub
End Class