Public Class Form1

    Private Sub Button_hyouka_Click(sender As Object, e As EventArgs) Handles Button_hyouka.Click
        Dim tensuu As Integer
        tensuu = CInt(TextBox_tensuu.Text)
        If tensuu < 0 Or tensuu > 100 Then
            Label_hyouka.Text = "入力エラー"
        Else
            If tensuu >= 80 Then
                Label_hyouka.Text = "合格"
            Else
                Label_hyouka.Text = "不合格"
            End If
        End If
    End Sub

    Private Sub Button_reset_Click(sender As Object, e As EventArgs) Handles Button_reset.Click
        TextBox_tensuu.Text = ""
        Label_hyouka.Text = ""
    End Sub
End Class
