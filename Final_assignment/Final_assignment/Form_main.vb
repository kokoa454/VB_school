Imports System.Security.Cryptography

Public Class Form_main
    Private Sub Progressbar1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_barBottom1.Text = 0
        Label_barBottom3.Text = 100
        Label_days.Text = 365 * 4 + 1

        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0

        Label_Fukuda.Text = "首相！" & vbCrLf & "市民団体が抗議してきましたぞ"
        Label_Mori.Text = "やっかいな奴らだ..." & vbCrLf & "警察でも自衛隊でも総動員しろ！"
    End Sub

    Private Sub updateProgressBar(ByVal value As Integer)
        If (ProgressBar1.Value + value < ProgressBar1.Minimum) Then
            ProgressBar1.Value = ProgressBar1.Minimum
        ElseIf (ProgressBar1.Value + value > ProgressBar1.Maximum) Then
            ProgressBar1.Value = ProgressBar1.Maximum
        Else
            ProgressBar1.Value += value
        End If
    End Sub

    Private Sub checkDays()
        If (Label_days.Text <= 0) Then
            Label_days.Text = "0"
            Label_Fukuda.Text = "首相！" & vbCr & "我々の勝利です！" & "革命なんてカスですな！"
            Label_Mori.Text = "日本は神の国、暴力で政権を取ろうなどと馬鹿なことは考えるべきではなかったな！"

            Dim form_lose As New Form_lose
            AddHandler form_lose.FormClosed, AddressOf closeForms

            form_lose.ShowDialog()
        End If
    End Sub

    Private Sub checkWin()
        Label_Fukuda.Text = "首相..." & vbCrLf & "我々の敗北です......."
        Label_Mori.Text = "なんだと！ふざけるな！" & vbCrLf & "福田くんがちゃんとしてないからだろ！！"

        Dim form_win As New Form_win
        AddHandler form_win.FormClosed, AddressOf closeForms

        form_win.ShowDialog()
    End Sub

    Private Sub commentFukuda()
        If (ProgressBar1.Value >= 80) Then
            Label_Fukuda.Text = "ま...まずい" & vbCrLf & "あと少しで暴力革命を起こされてしまう"

        ElseIf (ProgressBar1.Value >= 60) Then
            Label_Fukuda.Text = "首相！" & vbCrLf & "我らも妨害工作を始めようとしましょう"

        ElseIf (ProgressBar1.Value >= 40) Then
            Label_Fukuda.Text = "経団連に頼めば組織票が手に入りますから安泰ですな"

        ElseIf (ProgressBar1.Value >= 20) Then
            Label_Fukuda.Text = "なかなか奴らもやりますな"

        End If
    End Sub

    Private Sub commentMori()
        Dim num = RandomNumberGenerator.GetInt32(0, 36)
        Label_Mori.ForeColor = Color.Red

        Select Case num    'do nothing if 9 to 36'
            Case "0"
                Label_Mori.Text = "森首相による失言！" & vbCrLf & "「関心がない、といって寝てしまってくれれば、それでいいんですけれども」 at 衆議院"
                Label_Fukuda.Text = "首相！！" & vbCrLf & "何を言ってるんですか！支持率が下がりましたよ！"
                updateProgressBar(5)

            Case "1"
                Label_Mori.Text = "森首相による失言！" & vbCrLf & "「子どもを一人もつくらない女性の面倒を、税金でみなさいというのはおかしい」"
                Label_Fukuda.Text = "首相！！" & vbCrLf & "何を言ってるんですか！支持率が下がりましたよ！"
                updateProgressBar(5)

            Case "2"
                Label_Mori.Text = "森首相による失言！" & vbCrLf & "「見事にひっくり返った。あの子、大事なときには必ず転ぶ」 at オリンピック講演"
                Label_Fukuda.Text = "首相！！" & vbCrLf & "何を言ってるんですか！支持率が下がりましたよ！"
                updateProgressBar(5)

            Case "3"
                Label_Mori.Text = "森首相による失言！" & vbCrLf & "「国家も歌えないような選手は日本の選手ではない」 at スポーツ大会開会式"
                Label_Fukuda.Text = "首相！！" & vbCrLf & "何を言ってるんですか！支持率が下がりましたよ！"
                updateProgressBar(5)

            Case "4"
                Label_Mori.Text = "森首相による失言！" & vbCrLf & "「女性が入っている理事会は時間がかかる」"
                Label_Fukuda.Text = "首相！！" & vbCrLf & "何を言ってるんですか！支持率が下がりましたよ！"
                updateProgressBar(5)

            Case "5"
                Label_Mori.Text = "森首相による失言！" & vbCrLf & "「言葉は悪いが、大阪はたんつぼだ」"
                Label_Fukuda.Text = "首相！！" & vbCrLf & "何を言ってるんですか！支持率が下がりましたよ！"
                updateProgressBar(5)

            Case "6"
                Label_Mori.Text = "森首相による失言！" & vbCrLf & "「イット革命だ！あ、アイティーか」"
                Label_Fukuda.Text = "首相！！" & vbCrLf & "何を言ってるんですか！支持率が下がりましたよ！"
                updateProgressBar(5)

            Case "7"
                Label_Mori.Text = "森首相による失言！" & vbCrLf & "「日本の国、まさに天皇を中心としている神の国」"
                Label_Fukuda.Text = "首相！！" & vbCrLf & "何を言ってるんですか！支持率が下がりましたよ！"
                updateProgressBar(5)

            Case "8"
                Label_Mori.Text = "森首相による失言！" & vbCrLf & "「私が官邸に行かないことで、何が遅れたのか」 at 事故会見"
                Label_Fukuda.Text = "首相！！" & vbCrLf & "何を言ってるんですか！支持率が下がりましたよ！"
                updateProgressBar(5)

        End Select
    End Sub

    Private Sub refreshComments()
        Label_Mori.Text = ""
        Label_Fukuda.Text = ""
    End Sub

    Private Sub sabotageByGov()
        If (ProgressBar1.Value >= 65) Then
            Dim num = RandomNumberGenerator.GetInt32(0, 45)

            Select Case num    'do nothing if 9 to 45'
                Case "0"
                    updateProgressBar(-8)

                    Label_barBottom1.Text = ProgressBar1.Value.ToString

                    Dim form_sabotageByGov As New Form_sabotageByGov
                    form_sabotageByGov.text_form_sabotageByGov = "公安によって同志が逮捕" & vbCrLf & "他メンバーの士気が低下..."
                    form_sabotageByGov.ShowDialog()

                Case "1"
                    updateProgressBar(-8)

                    Label_barBottom1.Text = ProgressBar1.Value.ToString

                    Dim form_sabotageByGov As New Form_sabotageByGov
                    form_sabotageByGov.text_form_sabotageByGov = "警察による家宅捜索" & vbCrLf & "サボタージュ用書類を持っていかれた..."
                    form_sabotageByGov.ShowDialog()

                Case "2"
                    updateProgressBar(-10)

                    Label_barBottom1.Text = ProgressBar1.Value.ToString

                    Dim form_sabotageByGov As New Form_sabotageByGov
                    form_sabotageByGov.text_form_sabotageByGov = "スパイの潜入が発覚" & vbCrLf & "革命的データをすべて暗号化されてしまった..."
                    form_sabotageByGov.ShowDialog()

                Case "3"
                    updateProgressBar(-6)

                    Label_barBottom1.Text = ProgressBar1.Value.ToString

                    Dim form_sabotageByGov As New Form_sabotageByGov
                    form_sabotageByGov.text_form_sabotageByGov = "政府がインターネットの監視強化" & vbCrLf & "革命活動が露見しやすくなった..."
                    form_sabotageByGov.ShowDialog()

                Case "4"
                    updateProgressBar(-7)

                    Label_barBottom1.Text = ProgressBar1.Value.ToString

                    Dim form_sabotageByGov As New Form_sabotageByGov
                    form_sabotageByGov.text_form_sabotageByGov = "メディアが我々の活動を強く批判" & vbCrLf & "我々に対する国民の目が厳しくなった..."
                    form_sabotageByGov.ShowDialog()

                Case "5"
                    updateProgressBar(-10)

                    Label_barBottom1.Text = ProgressBar1.Value.ToString

                    Dim form_sabotageByGov As New Form_sabotageByGov
                    form_sabotageByGov.text_form_sabotageByGov = "政府によるフェイクニュース" & vbCrLf & "我々の信用を失墜させられた..."
                    form_sabotageByGov.ShowDialog()

                Case "6"
                    updateProgressBar(-8)

                    Label_barBottom1.Text = ProgressBar1.Value.ToString

                    Dim form_sabotageByGov As New Form_sabotageByGov
                    form_sabotageByGov.text_form_sabotageByGov = "同志が裏切り、政府に寝返った" & vbCrLf & "情報の流出が止まらない..."
                    form_sabotageByGov.ShowDialog()

                Case "7"
                    updateProgressBar(-9)

                    Label_barBottom1.Text = ProgressBar1.Value.ToString

                    Dim form_sabotageByGov As New Form_sabotageByGov
                    form_sabotageByGov.text_form_sabotageByGov = "外国勢力による介入." & vbCrLf & "我々の活動に多数の妨害工作が発見された..."
                    form_sabotageByGov.ShowDialog()

                Case "8"
                    updateProgressBar(-10)

                    Label_barBottom1.Text = ProgressBar1.Value.ToString

                    Dim form_sabotageByGov As New Form_sabotageByGov
                    form_sabotageByGov.text_form_sabotageByGov = "重要拠点の陥落" & vbCrLf & "多くの資料が焼却されてしまった..."
                    form_sabotageByGov.ShowDialog()
            End Select
        End If
    End Sub

    Public Sub canAttack()
        If (ProgressBar1.Value >= 90) Then
            Button_attack.Visible = True
        Else
            Button_attack.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_demoMarch.Click
        refreshComments()

        Dim num = RandomNumberGenerator.GetInt32(0, 20)
        If num = 0 Or num <= 10 Then
            If (ProgressBar1.Value > 15) Then
                updateProgressBar(-15)

                Label_barBottom1.Text = ProgressBar1.Value.ToString
            End If
            Label_result.Text = "SNSで大批判をくらった..." & vbCrLf & "国民は我々に厳しい目を向けている。" & vbCrLf & "政権が退陣するまで" & 100 - ProgressBar1.Value & "%"
        Else
            updateProgressBar(num)

            Label_barBottom1.Text = ProgressBar1.Value.ToString
            Label_result.Text = "我々の言葉が国民の心に響いた！" & vbCrLf & "政権が退陣するまで" & 100 - ProgressBar1.Value & "%"
        End If

        Label_days.Text = Label_days.Text - 120

        checkDays()

        If (ProgressBar1.Value >= 100) Then
            checkWin()

        Else
            canAttack()
            commentFukuda()
            commentMori()
            sabotageByGov()
        End If
    End Sub

    Private Sub Button_youtube_Click(sender As Object, e As EventArgs) Handles Button_youtube.Click
        refreshComments()

        Dim num = RandomNumberGenerator.GetInt32(0, 6)
        If num = 0 Or num <= 2 Then
            If (ProgressBar1.Value > 2) Then
                updateProgressBar(-2)

                Label_barBottom1.Text = ProgressBar1.Value.ToString
            End If
            Label_result.Text = "視聴者０人..." & vbCrLf & "国民は我々に関心がないようだ。" & vbCrLf & "政権が退陣するまで" & 100 - ProgressBar1.Value & "%"
        Else
            updateProgressBar(num)

            Label_barBottom1.Text = ProgressBar1.Value.ToString
            Label_result.Text = "我々の言葉が国民に心に響いた！" & vbCrLf & "政権が退陣するまで" & 100 - ProgressBar1.Value & "%"
        End If

        Label_days.Text = Label_days.Text - 30

        checkDays()

        If (ProgressBar1.Value >= 100) Then
            checkWin()

        Else
            canAttack()
            commentFukuda()
            commentMori()
            sabotageByGov()
        End If
    End Sub

    Private Sub Button_sabotage_Click(sender As Object, e As EventArgs) Handles Button_sabotage.Click
        refreshComments()

        Dim num = RandomNumberGenerator.GetInt32(0, 10)
        If num = 0 Or num <= 3 Then
            If (ProgressBar1.Value > 3) Then
                updateProgressBar(-3)

                Label_barBottom1.Text = ProgressBar1.Value.ToString
            End If
            Label_result.Text = "諜報員が暗殺され、サボタージュ失敗..." & vbCrLf & "これからの妨害工作はより一層難しくなるであろう。" & vbCrLf & "政権が退陣するまで" & 100 - ProgressBar1.Value & "%"
        Else
            updateProgressBar(num)

            Label_barBottom1.Text = ProgressBar1.Value.ToString
            Label_result.Text = "サボタージュ成功！企業と政府の汚職を公表！！" & vbCrLf & "政権が退陣するまで" & 100 - ProgressBar1.Value & "%"
        End If

        Label_days.Text = Label_days.Text - 60

        checkDays()

        If (ProgressBar1.Value >= 100) Then
            checkWin()

        Else
            canAttack()
            commentFukuda()
            commentMori()
            sabotageByGov()
        End If
    End Sub

    Private Sub Button_education_Click(sender As Object, e As EventArgs) Handles Button_education.Click
        refreshComments()

        Dim num = RandomNumberGenerator.GetInt32(0, 8)
        If num = 0 Or num = 1 Then
            If (ProgressBar1.Value > 2) Then
                updateProgressBar(-2)

                Label_barBottom1.Text = ProgressBar1.Value.ToString
            End If
            Label_result.Text = "我々の行動がSNSで晒され笑いものに..." & vbCrLf & "政権が退陣するまで" & 100 - ProgressBar1.Value & "%"
        Else
            updateProgressBar(num)

            Label_barBottom1.Text = ProgressBar1.Value.ToString
            Label_result.Text = "エリート大学生が加入！" & vbCrLf & "彼の後輩たちもメンバーとして加入してくれるだろう。" & vbCrLf & "政権が退陣するまで" & 100 - ProgressBar1.Value & "%"
        End If

        Label_days.Text = Label_days.Text - 30

        checkDays()

        If (ProgressBar1.Value >= 100) Then
            checkWin()

        Else
            canAttack()
            commentFukuda()
            commentMori()
            sabotageByGov()
        End If
    End Sub

    Private Sub Button_contact_Click(sender As Object, e As EventArgs) Handles Button_contact.Click
        refreshComments()

        Dim num = RandomNumberGenerator.GetInt32(0, 5)
        If num = 0 Or num = 1 Then
            updateProgressBar(-3)

            Label_barBottom1.Text = ProgressBar1.Value.ToString
            Label_result.Text = "通信中に突然の停電、連絡不可能に..." & vbCrLf & "政権が退陣するまで" & 100 - ProgressBar1.Value & "%"
        Else
            updateProgressBar(num)

            Label_barBottom1.Text = ProgressBar1.Value.ToString
            Label_result.Text = "革命に関する新しい知見を得た！" & vbCrLf & "政権が退陣するまで" & 100 - ProgressBar1.Value & "%"
        End If

        Label_days.Text = Label_days.Text - 20

        checkDays()

        If (ProgressBar1.Value >= 100) Then
            checkWin()

        Else
            canAttack()
            commentFukuda()
            commentMori()
            sabotageByGov()
        End If
    End Sub

    Private Sub Button_attack_Click(sender As Object, e As EventArgs) Handles Button_attack.Click
        refreshComments()

        Dim num = RandomNumberGenerator.GetInt32(0, 100)
        If num <= 50 Then
            ProgressBar1.Value = 0
            Label_Fukuda.Text = "首相！" & vbCrLf & "アメリカが助けに来てくれましたぞ！"
            Label_Mori.Text = "戦後アメリカの犬を演じてきたかいがあったな！"
            Label_result.Text = "アメリカ政府が介入！" & vbCrLf & "我々の敗北が確定した..."

            Dim form_attack_lose As New Form_attack_lose
            AddHandler form_attack_lose.FormClosed, AddressOf closeForms

            form_attack_lose.ShowDialog()
        Else
            ProgressBar1.Value = 100
            Label_barBottom1.Text = ProgressBar1.Value.ToString
            Label_Fukuda.Text = "首相..." & vbCrLf & "遂に革命を起こされてしまいましたぞ..."
            Label_Mori.Text = "女性が政治に入ってきたせいで日本は軟弱化してしまった！"
            Label_result.Text = "政府を破壊！" & vbCrLf & "新革命政府を樹立。新しい日本の始まりだ..."

            Dim form_attack_win As New Form_attack_win
            AddHandler form_attack_win.FormClosed, AddressOf closeForms

            form_attack_win.ShowDialog()
        End If

        Label_days.Text = 0
    End Sub

    Private Sub closeForms(sender As Object, e As FormClosedEventArgs)
        Application.Exit()
    End Sub

End Class
