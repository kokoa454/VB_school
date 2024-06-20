Public Class Form1
    Private circleBlack(1000) As Coodinates
    Private vlmCircleBlack As Integer = 0

    Private circleRed(1000) As Coodinates
    Private vlmCircleRed As Integer = 0
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If RadioButton_Black.Checked = True Then
            If e.Button = MouseButtons.Left Then
                circleBlack(vlmCircleBlack) = New Coodinates(e.X, e.Y)
                Me.CreateGraphics.FillEllipse(Brushes.Black, circleBlack(vlmCircleBlack).px, circleBlack(vlmCircleBlack).py, 10, 10)
                vlmCircleBlack = vlmCircleBlack + 1
            End If
        End If

        If RadioButton_Red.Checked = True Then
            If e.Button = MouseButtons.Left Then
                circleRed(vlmCircleRed) = New Coodinates(e.X, e.Y)
                Me.CreateGraphics.FillEllipse(Brushes.Red, circleRed(vlmCircleRed).px, circleRed(vlmCircleRed).py, 10, 10)
            End If
        End If
    End Sub

    Private Sub Button_clear_Click(sender As Object, e As EventArgs) Handles Button_clear.Click
        Refresh()
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim i As Integer

        For i = 0 To vlmCircleBlack - 1
            e.Graphics.FillEllipse(Brushes.Black, circleBlack(i).px, circleBlack(i).py, 10, 10)
        Next i

        For i = 0 To vlmCircleRed - 1
            e.Graphics.FillEllipse(Brushes.Red, circleRed(i).px, circleRed(i).py, 10, 10)
        Next i
    End Sub
End Class

