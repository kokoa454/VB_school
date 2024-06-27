Imports System.Security.Cryptography

Public Class Form1

    Private Sub Progressbar1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_barBottom1.Text = 0
        Label_barBottom3.Text = 100
        Label_days.Text = 365 * 4

        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_demoMarch.Click
        Dim num = RandomNumberGenerator.GetInt32(0, 20)
        If num = 0 Or num <= 10 Then
            If (ProgressBar1.Value > 15) Then
                ProgressBar1.Value = ProgressBar1.Value - 15
            End If
            Label_result.Text = "SNSで大批判をくらった..." & vbCrLf & "国民は我々に厳しい目を向けている。" & vbCrLf & "政権が退陣するまで" & 100 - ProgressBar1.Value & "%"
        Else
            ProgressBar1.Value = ProgressBar1.Value + num
            Label_barBottom1.Text = ProgressBar1.Value.ToString
            Label_result.Text = "我々の言葉が国民に心に響いた！" & vbCrLf & "政権が退陣するまで" & 100 - ProgressBar1.Value & "%"
        End If

        Label_days.Text = Label_days.Text - 100

    End Sub

    Private Sub Button_youtube_Click(sender As Object, e As EventArgs) Handles Button_youtube.Click
        Dim num = RandomNumberGenerator.GetInt32(0, 5)
        If num = 0 Or num = 1 Then
            If (ProgressBar1.Value > 2) Then
                ProgressBar1.Value = ProgressBar1.Value - 2
            End If
            Label_result.Text = "視聴者０人..." & vbCrLf & "国民は我々に関心がないようだ。" & vbCrLf & "政権が退陣するまで" & 100 - ProgressBar1.Value & "%"
        Else
            ProgressBar1.Value = ProgressBar1.Value + num
            Label_barBottom1.Text = ProgressBar1.Value.ToString
            Label_result.Text = "我々の言葉が国民に心に響いた！" & vbCrLf & "政権が退陣するまで" & 100 - ProgressBar1.Value & "%"
        End If

        Label_days.Text = Label_days.Text - 30

    End Sub

    Private Sub Button_sabotage_Click(sender As Object, e As EventArgs) Handles Button_sabotage.Click
        Dim num = RandomNumberGenerator.GetInt32(0, 10)
        If num = 0 Or num <= 3 Then
            If (ProgressBar1.Value > 3) Then
                ProgressBar1.Value = ProgressBar1.Value - 3
            End If
            Label_result.Text = "諜報員が暗殺され、サボタージュ失敗..." & vbCrLf & "これからの妨害工作はより一層難しくなるであろう。" & vbCrLf & "政権が退陣するまで" & 100 - ProgressBar1.Value & "%"
        Else
            ProgressBar1.Value = ProgressBar1.Value + num
            Label_barBottom1.Text = ProgressBar1.Value.ToString
            Label_result.Text = "サボタージュ成功！企業と政府の汚職を公表！！" & vbCrLf & "政権が退陣するまで" & 100 - ProgressBar1.Value & "%"
        End If

        Label_days.Text = Label_days.Text - 70
    End Sub

    Private Sub Button_education_Click(sender As Object, e As EventArgs) Handles Button_education.Click
        Dim num = RandomNumberGenerator.GetInt32(0, 5)
        If num = 0 Or num = 1 Then
            If (ProgressBar1.Value > 2) Then
                ProgressBar1.Value = ProgressBar1.Value - 2
            End If
            Label_result.Text = "我々の行動がSNSで晒され笑いものに..." & vbCrLf & "政権が退陣するまで" & 100 - ProgressBar1.Value & "%"
        Else
            ProgressBar1.Value = ProgressBar1.Value + num
            Label_barBottom1.Text = ProgressBar1.Value.ToString
            Label_result.Text = "エリート大学生が加入！" & vbCrLf & "彼の後輩たちもメンバーとして加入してくれるだろう。" & vbCrLf & "政権が退陣するまで" & 100 - ProgressBar1.Value & "%"
        End If

        Label_days.Text = Label_days.Text - 30
    End Sub
End Class
