Public Class Form1
    Private Sub Button_test_Click(sender As Object, e As EventArgs) Handles Button_test.Click
        Dim hairetsu(9) As Char
        Dim kaisuu As Integer

        For kaisuu = 0 To 9
            hairetsu(kaisuu) = "◎"
        Next kaisuu

        Debug.Print(CStr(hairetsu))
    End Sub
End Class
