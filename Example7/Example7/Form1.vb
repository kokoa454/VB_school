Public Class Form1
    Private Sub Button_goukei_Click(sender As Object, e As EventArgs) Handles Button_goukei.Click
        Dim bangou, kosuu, goukei As Integer
        Dim ctl(2) As Control

        For bangou = 0 To 2
            ctl(bangou) = Me.Controls(bangou)
        Next bangou

        goukei = 0

        For bangou = 0 To 2
            kosuu = CInt(ctl(bangou).Text)
            goukei = goukei + kosuu
        Next bangou

        TextBox_goukei.Text = CStr(goukei)
    End Sub
End Class
