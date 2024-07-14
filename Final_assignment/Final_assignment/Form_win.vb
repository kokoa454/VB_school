Public Class Form_win
    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click
        Application.Exit()
    End Sub

    Private Sub Form_win_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Controls.Add(Label1)
        PictureBox1.Controls.Add(Label2)
        PictureBox1.Controls.Add(Label3)
        PictureBox1.Controls.Add(Label4)
        PictureBox1.Controls.Add(Label5)
        PictureBox1.Controls.Add(Label6)
        PictureBox1.Controls.Add(Label7)
        PictureBox1.Controls.Add(Label8)
        PictureBox1.Controls.Add(Label9)
        PictureBox1.Controls.Add(Label10)
    End Sub
End Class