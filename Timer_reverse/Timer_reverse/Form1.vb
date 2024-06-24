Public Class Form1
    Private Sub Button_start_Click(sender As Object, e As EventArgs) Handles Button_start.Click
        If (TextBox_min.Text > 0 And TextBox_sec.Text > 60 Or TextBox_sec.Text = 0) Then
            MessageBox.Show("正しい値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Timer1.Enabled = False
            TextBox_min.Text = 0
            TextBox_sec.Text = 0
        Else
            Timer1.Enabled = True
        End If

    End Sub

    Private Sub Button_stop_Click(sender As Object, e As EventArgs) Handles Button_stop.Click
        Timer1.Enabled = False
    End Sub

    Private Sub Button_reset_Click(sender As Object, e As EventArgs) Handles Button_reset.Click
        Timer1.Enabled = False
        TextBox_min.Text = 0
        TextBox_sec.Text = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Timer1.Interval = 1000
        TextBox_sec.Text = Val(TextBox_sec.Text) - 1

        If (TextBox_sec.Text = 0) Then
            If (TextBox_min.Text <> 0) Then
                TextBox_min.Text = Val(TextBox_min.Text) - 1
                TextBox_sec.Text = 59
            End If
        End If

        If (TextBox_sec.Text = 0) Then
            Timer1.Enabled = False
        End If

        If (TextBox_min.Text = 0 And TextBox_sec.Text <= 10) Then
            TextBox_min.ForeColor = Color.Red
            TextBox_sec.ForeColor = Color.Red
        End If
    End Sub
End Class
