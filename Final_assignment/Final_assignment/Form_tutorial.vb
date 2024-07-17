Public Class Form_tutorial
    Private Sub closeForm_tutorial(sender As Object, e As FormClosedEventArgs)
        Application.Exit()
    End Sub

    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click
        Dim form_start As New Form_start

        AddHandler form_start.FormClosed, AddressOf closeForm_tutorial

        Me.Hide()
        form_start.Show()
    End Sub
End Class
