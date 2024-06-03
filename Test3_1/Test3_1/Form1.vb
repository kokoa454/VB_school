Public Class Form1
    Private Sub Button_go_Click(sender As Object, e As EventArgs) Handles Button_go.Click
        Dim dan As Integer
        Dim num As Integer

        dan = CInt(TextBox.Text)

        'For num = 1 To 9
        '   Debug.Print(dan & "×" & num & "=" & dan * num)
        'Next

        num = 1

        Do While num < 10
            Debug.Print(dan & "×" & num & "=" & (dan * num))
            num += 1
        Loop

    End Sub

    Private Sub Button_all_Click(sender As Object, e As EventArgs) Handles Button_all.Click
        Dim dan As Integer
        Dim num As Integer

        ' For dan = 1 To 9
        '   For num = 1 To 9
        '       Debug.Print(dan & "×" & num & "=" & dan * num)
        '   Next
        'Next

        dan = 1

        Do While dan < 10

            num = 1

            Do While num < 10
                Debug.Print(dan & "×" & num & "=" & (dan * num))
                num += 1
            Loop

            dan = dan + 1
        Loop
    End Sub
End Class
