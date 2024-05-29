Public Class Form1
    Private Sub Button_loop_Click(sender As Object, e As EventArgs) Handles Button_loop.Click
        Dim kaisuu As Integer
        Dim syori_kaisuu As Integer

        kaisuu = CInt(TextBox_cnt.Text)

        For syori_kaisuu = 0 To kaisuu Step 2
            Debug.Print("syori_kaisuu=" & syori_kaisuu)
        Next syori_kaisuu
    End Sub
End Class
