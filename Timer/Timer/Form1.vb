Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_start.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Button_stop_Click(sender As Object, e As EventArgs) Handles Button_stop.Click
        Timer1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = 100
        Label3.Text = Val(Label3.Text) + 1

        If (Label3.Text = 10) Then
            Label2.Text = Label2.Text + 1
            Label3.Text = 0
        End If

        If (Label2.Text = 60) Then
            Label1.Text = Label1.Text + 1
            Label2.Text = 0
        End If
    End Sub

    Private Sub Button_reset_Click(sender As Object, e As EventArgs) Handles Button_reset.Click
        Label1.Text = 0
        Label2.Text = 0
        Label3.Text = 0
    End Sub

End Class
