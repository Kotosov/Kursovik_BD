Public Class Cooling_Frame
    Private _resultObject As Cooling
    Dim count1, count2, all(0 To 1) As Integer
    Dim manu(), type_cooling() As String

    Dim intriger As Integer = 0
    Public Property ResultObject() As Cooling ' Public свойство для доступа к объекту
        Get
            Return _resultObject
        End Get
        Set(value As Cooling)
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
            If Cmb_manuf.Text() <> "Все" Then
                whereClauses.Add($"Manufacture = '{Cmb_manuf.SelectedItem}'")
            End If

            If Cmb_type.Text() <> "Все" Then
                whereClauses.Add($"Type = '{Cmb_type.SelectedItem}'")
            End If
            If Sborka.computer.CPU IsNot Nothing Then
                Dim s As String = Sborka.computer.CPU.Soket.ToString().Replace(" ", "")
                whereClauses.Add($"Soket LIKE '%{s}%'")
                whereClauses.Add($"TDP >= {Sborka.computer.CPU.TDP}")
            End If
            ' Собираем итоговый SQL
            command_7 = "SELECT * FROM COOLING"
            If whereClauses.Count > 0 Then
                command_7 = command_7 & " WHERE " & String.Join(" AND ", whereClauses)
            End If
            Dim COMMAND7 As New System.Data.OleDb.OleDbCommand(command_7, CO)
            Dim DATA7 As System.Data.OleDb.OleDbDataReader = COMMAND7.ExecuteReader(CommandBehavior.CloseConnection)
            Dim dataTable As New DataTable()
            dataTable.Load(DATA7)
            DataGV_1.DataSource = dataTable
            CO.Close
        End If
    End Sub
    Dim CO = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Kurs.accdb;Persist Security Info=False;")

    Private Sub Cmb_manuf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_manuf.SelectedIndexChanged
        Obnov()
    End Sub

    Private Sub Cmb_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_type.SelectedIndexChanged
        Obnov()
    End Sub

    Private Sub butt_save_Click(sender As Object, e As EventArgs) Handles butt_save.Click
        CO.open()
        Dim Manufacturer As String, Weight As String, Type As String,
                   Soket As String, For_what As String, TDP As Integer,
                   Length As Single, Width As Single, Cost As Single
        Dim choose_Cooling As Cooling
        Dim id As Integer = Nud_id.Value
        Dim command_8 = $"SELECT * FROM COOLING WHERE Id = '8_{id}'"
        Dim COMMAND8 As New System.Data.OleDb.OleDbCommand(command_8, CO)
        Dim DATA8 As System.Data.OleDb.OleDbDataReader = COMMAND8.ExecuteReader(CommandBehavior.CloseConnection)
        Try
            DATA8.Read()
            Manufacturer = DATA8.GetValue(2)
            Weight = DATA8.GetValue(3)
            Type = DATA8.GetValue(4)
            Soket = DATA8.GetValue(5)
            For_what = DATA8.GetValue(6)
            Length = Single.Parse(DATA8.GetValue(7).Replace(" мм", "").Trim())
            Width = Single.Parse(DATA8.GetValue(8).Replace(" мм", "").Trim())
            Cost = DATA8.GetValue(9)
            TDP = DATA8.GetValue(10)
            choose_Cooling = New Cooling(id, Manufacturer, Weight, Type,
                   Soket, For_what, TDP, Length, Width, Cost)
            Me.ResultObject = choose_Cooling
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

    Private Sub Cooling_Frame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CO.Open
        Cmb_manuf.Items.Clear()
        Cmb_type.Items.Clear()
        Dim command_1 As String = "SELECT COUNT(*) 
FROM (SELECT DISTINCT Manufacture FROM COOLING)
UNION ALL
    Select COUNT(*)
FROM (SELECT DISTINCT Type FROM COOLING);"
        Dim COMMAND As New System.Data.OleDb.OleDbCommand(command_1, CO)
        Dim DATA1 As System.Data.OleDb.OleDbDataReader = COMMAND.ExecuteReader(CommandBehavior.CloseConnection)
        For i = 0 To 1
            DATA1.Read()
            all(i) = DATA1.GetValue(0)
        Next
        count1 = all(0)
        count2 = all(1)
        ReDim manu(0 To count1 - 1), type_cooling(0 To count2 - 1)
        Dim command_2 As String = "SELECT DISTINCT Manufacture FROM COOLING"
        Dim COMMAND2 As New System.Data.OleDb.OleDbCommand(command_2, CO)
        Dim DATA2 As System.Data.OleDb.OleDbDataReader = COMMAND2.ExecuteReader(CommandBehavior.CloseConnection)
        For i = 0 To count1 - 1
            DATA2.Read()
            manu(i) = DATA2.GetValue(0)
        Next
        Cmb_manuf.Items.AddRange(manu)
        Cmb_manuf.Items.Add("Все")
        Cmb_manuf.SelectedItem = "Все"
        Dim command_3 As String = "SELECT DISTINCT Type FROM COOLING"
        Dim COMMAND3 As New System.Data.OleDb.OleDbCommand(command_3, CO)
        Dim DATA3 As System.Data.OleDb.OleDbDataReader = COMMAND3.ExecuteReader(CommandBehavior.CloseConnection)
        For i = 0 To count2 - 1
            DATA3.Read()
            type_cooling(i) = DATA3.GetValue(0)
        Next
        Cmb_type.Items.AddRange(type_cooling)
        Cmb_type.Items.Add("Все")
        Cmb_type.SelectedItem = "Все"
        CO.Close
    End Sub
End Class