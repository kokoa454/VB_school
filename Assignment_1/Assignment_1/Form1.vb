Public Class Form1
    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click
        Dim ID As String
        Dim password As String
        ID = "inari"
        password = "0000"

        Dim inputID As String
        Dim inputPass As String
        inputID = CStr(TextBox_ID.Text)
        inputPass = CStr(TextBox_Pass.Text)

        If ID = inputID And password = inputPass Then
            Debug.Print("ログイン成功")
        ElseIf ID <> inputID And password = inputPass Then
            Debug.Print("IDが違います")
        ElseIf ID = inputID And password <> inputPass Then
            Debug.Print("パスワードが違います")
        Else
            Debug.Print("IDとパスワードが違います")
        End If
    End Sub

    Private Sub Button_Reset_Click(sender As Object, e As EventArgs) Handles Button_Reset.Click
        TextBox_ID.Text = ""
        TextBox_Pass.Text = ""
    End Sub
End Class
