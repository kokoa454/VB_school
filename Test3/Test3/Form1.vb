Public Class Form1
    Private Sub Button_test_Click(sender As Object, e As EventArgs) Handles Button_test.Click
        Dim kosuu As Integer
        'kosuu = 0

        'Do While kosuu < 20
        '   Debug.Write("◎")
        '   kosuu = kosuu + 1
        'Loop

        For kosuu = 0 To 19
            Debug.Write("◎")
        Next kosuu
    End Sub
End Class
