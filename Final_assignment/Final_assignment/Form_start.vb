﻿Public Class Form_start
    Private Sub Button_start_Click(sender As Object, e As EventArgs) Handles Button_start.Click
        Dim form_main As New Form_main

        AddHandler form_main.FormClosed, AddressOf closeForm_main

        Me.Hide()
        form_main.Show()

    End Sub

    Private Sub Button_close_Click(sender As Object, e As EventArgs) Handles Button_close.Click
        'Me.Close()

        Application.Exit()
    End Sub

    Private Sub closeForm_main(sender As Object, e As FormClosedEventArgs)
        Application.Exit()
    End Sub

End Class