Public Class Main_Form
    Private Sub Butt_start_Click(sender As Object, e As EventArgs) Handles Butt_start.Click
        Sborka.Show()
        Me.Hide()
    End Sub
    Private Sub butt_avtor_Click(sender As Object, e As EventArgs) Handles butt_avtor.Click
        MessageBox.Show("Автор: Филимонов Иван Гр.436
Дата создания 18.05.25", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub butt_exit_Click(sender As Object, e As EventArgs) Handles butt_exit.Click
        Me.Close()
    End Sub
End Class
