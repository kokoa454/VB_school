Public Class Form_attack_lose
    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click
        Form_main.Close()
        Me.Close()
        Form_start.Close()
    End Sub
End Class