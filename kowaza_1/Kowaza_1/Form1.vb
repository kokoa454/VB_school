Public Class Form_main
    Private Sub Button_JP_Click(sender As Object, e As EventArgs) Handles Button_JP.Click
        Dim form As New Form_JP
        form.Show()
    End Sub

    Private Sub Button_Eng_Click(sender As Object, e As EventArgs) Handles Button_Eng.Click
        Dim form As New Form_Eng
        form.Show()
    End Sub
End Class
