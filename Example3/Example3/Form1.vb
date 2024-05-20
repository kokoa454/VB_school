Public Class Form1
    Private Sub Button_calc_Click(sender As Object, e As EventArgs) Handles Button_calc.Click
        Dim left As Integer
        Dim right As Integer

        left = CInt(TextBox_left.Text)
        right = CInt(TextBox_right.Text)
        TextBox_result.Text = CStr(left + right)
    End Sub
End Class
