Imports System.Diagnostics.Metrics
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports FxResources.System

Public Class FRAME_FRAME
    Private _resultObject As Frame
    Dim count1, count2, all(0 To 1) As Integer
    Dim Color_in(), Water() As String
    Dim intriger As Integer = 0
    Public Property ResultObject() As Frame ' Public свойство для доступа к объекту
        Get
            Return _resultObject
        End Get
        Set(value As Frame)
            _resultObject = value
        End Set
    End Property
    Dim CO = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\Kurs.accdb;Persist Security Info=False;")

    Public Sub Obnov()
        Dim whereClauses As New List(Of String)()
        Dim command_7 As String

        If intriger < 2 Then
            intriger += 1
            Return
        Else
            CO.Open()
            ' Формируем условия WHERE
            If Cmb_Color.Text() <> "Все" Then
                whereClauses.Add($"Color = '{Cmb_Color.SelectedItem}'")
            End If

            If Cmb_water.Text() <> "Все" Then
                whereClauses.Add($"Water_cooling = '{Cmb_water.SelectedItem}'")
            End If
            If Sborka.computer.Motherboard IsNot Nothing Then
                Dim form As String = Sborka.computer.Motherboard.Form_factor
                whereClauses.Add($"Form_factor = '{Form}'")
            End If
            ' Собираем итоговый SQL
            command_7 = "SELECT * FROM FRAME"
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
    Private Sub Cmb_water_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_water.SelectedIndexChanged
        Obnov()
    End Sub
    Private Sub Cmb_Color_in_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Color.SelectedIndexChanged
        Obnov()
    End Sub

    Private Sub butt_save_Click(sender As Object, e As EventArgs) Handles butt_save.Click
        CO.open()
        Dim Manufacturer As String, Hight As Double, Width As Double, Length As Double, Weight As Double, Color_in As String, Material As String, Form_factor As String, Max_lenght_of_GPU As Integer, Water_cooling As Boolean, Cost As Decimal
        Dim choose_Frame As Frame
        Dim id As Integer = Nud_id.Value
        Dim command_8 = $"SELECT * FROM FRAME WHERE Id = '1_{id}'"
        Dim COMMAND8 As New System.Data.OleDb.OleDbCommand(command_8, CO)
        Dim DATA8 As System.Data.OleDb.OleDbDataReader = COMMAND8.ExecuteReader(CommandBehavior.CloseConnection)
        Try
            DATA8.Read()
            Manufacturer = DATA8.GetValue(2)
            Hight = DATA8.GetValue(3)
            Width = DATA8.GetValue(4)
            Length = DATA8.GetValue(5)
            Weight = DATA8.GetValue(6)
            Color_in = DATA8.GetValue(7)
            Material = DATA8.GetValue(8)
            Form_factor = DATA8.GetValue(9)
            Max_lenght_of_GPU = DATA8.GetValue(10)
            Water_cooling = If(DATA8.GetValue(11) = "Да", True, False)
            Cost = DATA8.GetValue(12)
            choose_Frame = New Frame(id, Manufacturer, Hight, Width, Length, Weight, Color_in,
                                     Material, Form_factor, Max_lenght_of_GPU, Water_cooling, Cost)
            Me.ResultObject = choose_Frame
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

    Private Sub FRAME_FRAME_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CO.Open
        Cmb_Color.Items.Clear()
        Cmb_water.Items.Clear()
        Dim command_1 As String = "SELECT COUNT(*) 
FROM (SELECT DISTINCT Color FROM FRAME)
UNION ALL
    Select COUNT(*)
FROM (SELECT DISTINCT Water_cooling FROM FRAME);"
        Dim COMMAND As New System.Data.OleDb.OleDbCommand(command_1, CO)
        Dim DATA1 As System.Data.OleDb.OleDbDataReader = COMMAND.ExecuteReader(CommandBehavior.CloseConnection)
        For i = 0 To 1
            DATA1.Read()
            all(i) = DATA1.GetValue(0)
        Next
        count1 = all(0)
        count2 = all(1)
        ReDim Color_in(0 To count1 - 1), Water(0 To count2 - 1)
        Dim command_2 As String = "SELECT DISTINCT Color FROM FRAME"
        Dim COMMAND2 As New System.Data.OleDb.OleDbCommand(command_2, CO)
        Dim DATA2 As System.Data.OleDb.OleDbDataReader = COMMAND2.ExecuteReader(CommandBehavior.CloseConnection)
        For i = 0 To count1 - 1
            DATA2.Read()
            Color_in(i) = DATA2.GetValue(0)
        Next
        Cmb_Color.Items.AddRange(Color_in)
        Cmb_Color.Items.Add("Все")
        Cmb_Color.SelectedItem = "Все"
        Dim command_3 As String = "SELECT DISTINCT Water_cooling FROM FRAME"
        Dim COMMAND3 As New System.Data.OleDb.OleDbCommand(command_3, CO)
        Dim DATA3 As System.Data.OleDb.OleDbDataReader = COMMAND3.ExecuteReader(CommandBehavior.CloseConnection)
        For i = 0 To count2 - 1
            DATA3.Read()
            Water(i) = DATA3.GetValue(0)
        Next
        Cmb_water.Items.AddRange(Water)
        Cmb_water.Items.Add("Все")
        Cmb_water.SelectedItem = "Все"
        CO.Close
    End Sub
End Class