Public Class Form1
    Private Sub Button_calc_Click(sender As Object, e As EventArgs) Handles Button_calc.Click
        Dim num, vlm, sum, avg As Integer
        Dim ctl As Control

        num = 0
        sum = 0

        'For num = 0 To 9
        'ctl = Me.Controls(num)

        'If ctl.Text = "" Then
        'TextBox_sum.Text = "ERROR"
        'Exit For
        'Else
        'vlm = CInt(ctl.Text)
        'sum = sum + vlm
        'End If
        'Next num

        'If num = 10 Then
        'avg = sum / num
        'TextBox_sum.Text = CStr(avg)
        'End If

        Dim cnt As Integer

        cnt = 0

        For num = 0 To 9
            ctl = Me.Controls(num)
            If ctl.Text = "" Then
            Else
                vlm = CInt(ctl.Text)
                sum = sum + vlm
                cnt = cnt + 1
            End If
        Next

        avg = sum / cnt
        TextBox_sum.Text = CStr(avg)

    End Sub

    Private Sub Button_clear_Click(sender As Object, e As EventArgs) Handles Button_clear.Click
        Dim num As Integer
        Dim ctl As Control

        For num = 0 To 10
            ctl = Me.Controls(num)
            ctl.Text = ""
        Next
    End Sub
End Class
