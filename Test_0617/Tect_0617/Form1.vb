Public Class Form1
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Dim circle As Coodinates
        If RadioButton_Black.Checked = True Then
            If e.Button = MouseButtons.Left Then
                circle = New Coodinates(e.X, e.Y)
                Me.CreateGraphics.FillEllipse(Brushes.Black, circle.px, circle.py, 10, 10)
            End If
        End If

        If RadioButton_Red.Checked = True Then
            If e.Button = MouseButtons.Left Then
                circle = New Coodinates(e.X, e.Y)
                Me.CreateGraphics.FillEllipse(Brushes.Red, circle.px, circle.py, 10, 10)
            End If
        End If
    End Sub

    Private Sub Button_clear_Click(sender As Object, e As EventArgs) Handles Button_clear.Click
        Refresh()
    End Sub
End Class
