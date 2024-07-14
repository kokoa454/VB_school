Public Class Form_lose
    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click
        Application.Exit()
    End Sub

    Private Sub Form_lose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Controls.Add(Label1)
        PictureBox1.Controls.Add(Label2)
        PictureBox1.Controls.Add(Label3)
        PictureBox1.Controls.Add(Label4)
    End Sub
End Class