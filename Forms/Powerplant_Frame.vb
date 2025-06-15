Public Class Powerplant_Frame
    Private _resultObject As Powerplant
    Dim count1, count2, all(0 To 1) As Integer
    Dim manu(), type_cooling() As String

    Dim intriger As Integer = 0
    Public Property ResultObject() As Powerplant ' Public свойство для доступа к объекту
        Get
            Return _resultObject
        End Get
        Set(value As Powerplant)
            _resultObject = value
        End Set
    End Property
    Public Function sertificate(sert As String)
        Select Case sert
            Case "80+ Bronze"
                Return 0.81
            Case "80+ Gold"
                Return 0.88
            Case "80+ Platinum"
                Return 0.9
            Case "80+ Titanium"
                Return 0.94
            Case "80+ White"
                Return 0.85
            Case "Нет"
                Return 0.8
            Case Else
                Return 0.8
        End Select
    End Function
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
                whereClauses.Add($"Manufacturer = '{Cmb_manuf.SelectedItem}'")
            End If

            If Cmb_type.Text() <> "Все" Then
                whereClauses.Add($"Sertif = '{Cmb_type.SelectedItem}'")
            End If
            If Sborka.computer.CPU IsNot Nothing And Sborka.computer.GPU IsNot Nothing Then
                whereClauses.Add($"Сapacity >= {Fix((Sborka.computer.CPU.TDP + 400) / sertificate(Cmb_type.Text))}")
            ElseIf Sborka.computer.CPU IsNot Nothing And Sborka.computer.GPU Is Nothing Then
                whereClauses.Add($"Сapacity >= {Fix((Sborka.computer.CPU.TDP + 100) / sertificate(Cmb_type.Text))}")
            End If
            ' Собираем итоговый SQL
            command_7 = "SELECT * FROM POWER_BLOK"
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
        Dim Manufacturer As String, Weight As Double, Color_1 As String, Сapacity As Integer, Form_factor As String, Power_CPU As String, Power_GPU As String, l_15_pin_SATA As String, l_4_pin_Molex As String, Cooling_system As String, Sertif As String, Cost As Decimal
        Dim choose_Powerplant As Powerplant
        Dim id As Integer = Nud_id.Value
        Dim command_8 = $"SELECT * FROM POWER_BLOK WHERE Id = '4_{id}'"
        Dim COMMAND8 As New System.Data.OleDb.OleDbCommand(command_8, CO)
        Dim DATA8 As System.Data.OleDb.OleDbDataReader = COMMAND8.ExecuteReader(CommandBehavior.CloseConnection)
        Try
            DATA8.Read()
            Manufacturer = DATA8.GetValue(2)
            Weight = DATA8.GetValue(3)
            Color_1 = DATA8.GetValue(4)
            Сapacity = DATA8.GetValue(5)
            Form_factor = DATA8.GetValue(6)
            Power_CPU = DATA8.GetValue(7)
            Power_GPU = DATA8.GetValue(8)
            l_15_pin_SATA = DATA8.GetValue(9)
            l_4_pin_Molex = DATA8.GetValue(10)
            Cooling_system = DATA8.GetValue(11)
            Sertif = DATA8.GetValue(12)
            Cost = DATA8.GetValue(13)
            choose_Powerplant = New Powerplant(id, Manufacturer, Weight, Color_1, Сapacity, Form_factor,
                                               Power_CPU, Power_GPU, l_15_pin_SATA, l_4_pin_Molex, Cooling_system, Sertif, Cost)
            Me.ResultObject = choose_Powerplant
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

    Private Sub Powerplant_Frame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CO.Open
        Cmb_manuf.Items.Clear()
        Cmb_type.Items.Clear()
        Dim command_1 As String = "SELECT COUNT(*) 
FROM (SELECT DISTINCT Manufacturer FROM POWER_BLOK)
UNION ALL
    Select COUNT(*)
FROM (SELECT DISTINCT Sertif FROM POWER_BLOK);"
        Dim COMMAND As New System.Data.OleDb.OleDbCommand(command_1, CO)
        Dim DATA1 As System.Data.OleDb.OleDbDataReader = COMMAND.ExecuteReader(CommandBehavior.CloseConnection)
        For i = 0 To 1
            DATA1.Read()
            all(i) = DATA1.GetValue(0)
        Next
        count1 = all(0)
        count2 = all(1)
        ReDim manu(0 To count1 - 1), type_cooling(0 To count2 - 1)
        Dim command_2 As String = "SELECT DISTINCT Manufacturer FROM POWER_BLOK"
        Dim COMMAND2 As New System.Data.OleDb.OleDbCommand(command_2, CO)
        Dim DATA2 As System.Data.OleDb.OleDbDataReader = COMMAND2.ExecuteReader(CommandBehavior.CloseConnection)
        For i = 0 To count1 - 1
            DATA2.Read()
            manu(i) = DATA2.GetValue(0)
        Next
        Cmb_manuf.Items.AddRange(manu)
        Cmb_manuf.Items.Add("Все")
        Cmb_manuf.SelectedItem = "Все"
        Dim command_3 As String = "SELECT DISTINCT Sertif FROM POWER_BLOK"
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