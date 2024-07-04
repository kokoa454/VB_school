Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form_sabotageByGov
    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click
        Me.Close()
    End Sub

    Friend text_form_sabotageByGov As String

    Private Sub Form_sabotageByGov_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label_mainText.Text = text_form_sabotageByGov.ToString
    End Sub

End Class