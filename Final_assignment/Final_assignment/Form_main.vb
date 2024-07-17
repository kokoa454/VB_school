Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports NAudio.Wave

'チュートリアルみたいなのつけて、「～～～するゲームです」みたいなの書いて、失言したら5%上がりますみたいなの書こうかな

Public Class Form_main
    Private waveOut As WaveOutEvent
    Private mp3Reader As Mp3FileReader
    Private stopMusic As Boolean = False 'the flag to stop the music

    Private Sub Progressbar1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'NAudio setting to play Прощание_Славянки.mp3
        mp3Reader = New Mp3FileReader("..\..\..\music\Прощание_Славянки.mp3")
        waveOut = New WaveOutEvent()
        AddHandler waveOut.PlaybackStopped, AddressOf OnPlaybackStopped
        waveOut.Init(mp3Reader)
        waveOut.Volume = 0.1
        waveOut.Play()

        'initialize the text
        Label_barBottom1.Text = 0
        Label_barBottom3.Text = 100
        Label_days.Text = 365 * 4 + 1

        'initialize the ProgressBar
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0

        'Fukuda's and Mori's first comments
        Label_Fukuda.Text = "首相！" & vbCrLf & "市民団体が抗議してきましたぞ"
        Label_Mori.Text = "やっかいな奴らだ..." & vbCrLf & "警察でも自衛隊でも総動員しろ！"

        'mousehover action
        ToolTip_demoMarch.SetToolTip(Button_demoMarch, "成功率：50%" & vbCrLf & "     成功したら10～20%上昇" & vbCrLf & "     失敗したら15%下落" & vbCrLf & vbCrLf & "必要準備日数：120日")
        ToolTip_youtube.SetToolTip(Button_youtube, "成功率：75%" & vbCrLf & "     成功したら2～8%上昇" & vbCrLf & "     失敗したら2%下落" & vbCrLf & vbCrLf & "必要準備日数：30日")
        ToolTip_sabotage.SetToolTip(Button_sabotage, "成功率：67%" & vbCrLf & "     成功したら4～10%上昇" & vbCrLf & "     失敗したら3%下落" & vbCrLf & vbCrLf & "必要準備日数：60日")
        ToolTip_education.SetToolTip(Button_education, "成功率：75%" & vbCrLf & "     成功したら2～8%上昇" & vbCrLf & "     失敗したら2%下落" & vbCrLf & vbCrLf & "必要準備日数：30日")
        ToolTip_contact.SetToolTip(Button_contact, "成功率：60%" & vbCrLf & "     成功したら2～5%上昇" & vbCrLf & "     失敗したら3%下落" & vbCrLf & vbCrLf & "必要準備日数：20日")
        ToolTip_attack.SetToolTip(Button_attack, "【警告】このコマンドは政府に武装攻撃を仕掛けます！" & vbCrLf & "　　　　　攻撃の勝敗によってゲームの勝敗も決定します" & vbCrLf & "　　　　　コマンドを押さずに勝利することも可能です" & vbCrLf & vbCrLf & "成功率：50%" & vbCrLf & "     成功したら勝利" & vbCrLf & "     失敗したら敗北")
    End Sub

    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        'remove event handler before stopping and disposing
        RemoveHandler waveOut.PlaybackStopped, AddressOf OnPlaybackStopped
        waveOut.Stop()
        mp3Reader.Dispose()
        waveOut.Dispose()
        MyBase.OnFormClosing(e)
    End Sub

    Private Sub OnPlaybackStopped(sender As Object, e As StoppedEventArgs)
        'check if waveOut and mp3Reader are still valid
        If mp3Reader IsNot Nothing AndAlso waveOut IsNot Nothing AndAlso Not stopMusic Then
            mp3Reader.Position = 0  'Reset the position to the beginning of the file
            waveOut.Play()  'Start playing again
        End If
    End Sub

    Private Sub updateProgressBar(ByVal value As Integer)
        'do not update ProgressBar if the value is under minimum or over maximum
        If (ProgressBar1.Value + value < ProgressBar1.Minimum) Then
            ProgressBar1.Value = ProgressBar1.Minimum
        ElseIf (ProgressBar1.Value + value > ProgressBar1.Maximum) Then
            ProgressBar1.Value = ProgressBar1.Maximum
        Else
            ProgressBar1.Value += value
        End If
    End Sub

    Private Sub checkDays()
        'the player loses after 4 yrs
        If (Label_days.Text <= 0) Then
            Label_days.Text = "0"
            Label_Fukuda.Text = "首相！" & vbCr & "我々の勝利です！" & "革命なんてカスですな！"
            Label_Mori.Text = "日本は神の国、暴力で政権を取ろうなどと馬鹿なことは考えるべきではなかったな！"

            stopMusic = True    'Set the flag to stop music
            waveOut.Stop()

            'open Form_lose
            Dim form_lose As New Form_lose
            AddHandler form_lose.FormClosed, AddressOf closeForms
            form_lose.ShowDialog()
        End If
    End Sub

    Private Sub checkWin()
        'the player wins if the value of ProgressBar is equal to 100 or over 100
        Label_Fukuda.Text = "首相..." & vbCrLf & "我々の敗北です......."
        Label_Mori.Text = "なんだと！ふざけるな！" & vbCrLf & "福田くんがちゃんとしてないからだろ！！"

        stopMusic = True
        waveOut.Stop()

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

        Select Case num    'do nothing if 9 to 36
            Case "0"
                Label_Mori.Text = "森首相による失言！" & vbCrLf & "「関心がない、といって寝てしまってくれれば、それでいいんですけれども」 at 衆議院"
                Label_Fukuda.Text = "首相！！" & vbCrLf & "何を言ってるんですか！支持率が下がりましたよ！"
                updateProgressBar(5)
                Label_barBottom1.Text = ProgressBar1.Value.ToString

            Case "1"
                Label_Mori.Text = "森首相による失言！" & vbCrLf & "「子どもを一人もつくらない女性の面倒を、税金でみなさいというのはおかしい」"
                Label_Fukuda.Text = "首相！！" & vbCrLf & "何を言ってるんですか！支持率が下がりましたよ！"
                updateProgressBar(5)
                Label_barBottom1.Text = ProgressBar1.Value.ToString

            Case "2"
                Label_Mori.Text = "森首相による失言！" & vbCrLf & "「見事にひっくり返った。あの子、大事なときには必ず転ぶ」 at オリンピック講演"
                Label_Fukuda.Text = "首相！！" & vbCrLf & "何を言ってるんですか！支持率が下がりましたよ！"
                updateProgressBar(5)
                Label_barBottom1.Text = ProgressBar1.Value.ToString

            Case "3"
                Label_Mori.Text = "森首相による失言！" & vbCrLf & "「国家も歌えないような選手は日本の選手ではない」 at スポーツ大会開会式"
                Label_Fukuda.Text = "首相！！" & vbCrLf & "何を言ってるんですか！支持率が下がりましたよ！"
                updateProgressBar(5)
                Label_barBottom1.Text = ProgressBar1.Value.ToString

            Case "4"
                Label_Mori.Text = "森首相による失言！" & vbCrLf & "「女性が入っている理事会は時間がかかる」"
                Label_Fukuda.Text = "首相！！" & vbCrLf & "何を言ってるんですか！支持率が下がりましたよ！"
                updateProgressBar(5)
                Label_barBottom1.Text = ProgressBar1.Value.ToString

            Case "5"
                Label_Mori.Text = "森首相による失言！" & vbCrLf & "「言葉は悪いが、大阪はたんつぼだ」"
                Label_Fukuda.Text = "首相！！" & vbCrLf & "何を言ってるんですか！支持率が下がりましたよ！"
                updateProgressBar(5)
                Label_barBottom1.Text = ProgressBar1.Value.ToString

            Case "6"
                Label_Mori.Text = "森首相による失言！" & vbCrLf & "「イット革命だ！あ、アイティーか」"
                Label_Fukuda.Text = "首相！！" & vbCrLf & "何を言ってるんですか！支持率が下がりましたよ！"
                updateProgressBar(5)
                Label_barBottom1.Text = ProgressBar1.Value.ToString

            Case "7"
                Label_Mori.Text = "森首相による失言！" & vbCrLf & "「日本の国、まさに天皇を中心としている神の国」"
                Label_Fukuda.Text = "首相！！" & vbCrLf & "何を言ってるんですか！支持率が下がりましたよ！"
                updateProgressBar(5)
                Label_barBottom1.Text = ProgressBar1.Value.ToString

            Case "8"
                Label_Mori.Text = "森首相による失言！" & vbCrLf & "「私が官邸に行かないことで、何が遅れたのか」 at 事故会見"
                Label_Fukuda.Text = "首相！！" & vbCrLf & "何を言ってるんですか！支持率が下がりましたよ！"
                updateProgressBar(5)
                Label_barBottom1.Text = ProgressBar1.Value.ToString

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

                    Dim form_sabotageByGov As New Form_sabotageByGov
                    form_sabotageByGov.text_form_sabotageByGov = "公安によって同志が逮捕" & vbCrLf & "他メンバーの士気が低下..." & vbCrLf & "退陣要求度に-8%"
                    form_sabotageByGov.ShowDialog()

                Case "1"
                    updateProgressBar(-8)

                    Dim form_sabotageByGov As New Form_sabotageByGov
                    form_sabotageByGov.text_form_sabotageByGov = "警察による家宅捜索" & vbCrLf & "サボタージュ用書類を持っていかれた..." & vbCrLf & "退陣要求度に-8%"
                    form_sabotageByGov.ShowDialog()

                Case "2"
                    updateProgressBar(-10)

                    Dim form_sabotageByGov As New Form_sabotageByGov
                    form_sabotageByGov.text_form_sabotageByGov = "スパイの潜入が発覚" & vbCrLf & "革命的データをすべて暗号化されてしまった..." & vbCrLf & "退陣要求度に-10%"
                    form_sabotageByGov.ShowDialog()

                Case "3"
                    updateProgressBar(-6)

                    Dim form_sabotageByGov As New Form_sabotageByGov
                    form_sabotageByGov.text_form_sabotageByGov = "政府がインターネットの監視強化" & vbCrLf & "革命活動が露見しやすくなった..." & vbCrLf & "退陣要求度に-6%"
                    form_sabotageByGov.ShowDialog()

                Case "4"
                    updateProgressBar(-7)

                    Dim form_sabotageByGov As New Form_sabotageByGov
                    form_sabotageByGov.text_form_sabotageByGov = "メディアが我々の活動を強く批判" & vbCrLf & "我々に対する国民の目が厳しくなった..." & vbCrLf & "退陣要求度に-7%"
                    form_sabotageByGov.ShowDialog()

                Case "5"
                    updateProgressBar(-10)

                    Dim form_sabotageByGov As New Form_sabotageByGov
                    form_sabotageByGov.text_form_sabotageByGov = "政府によるフェイクニュース" & vbCrLf & "我々の信用を失墜させられた..." & vbCrLf & "退陣要求度に-10%"
                    form_sabotageByGov.ShowDialog()

                Case "6"
                    updateProgressBar(-8)

                    Dim form_sabotageByGov As New Form_sabotageByGov
                    form_sabotageByGov.text_form_sabotageByGov = "同志が裏切り、政府に寝返った" & vbCrLf & "情報の流出が止まらない..." & vbCrLf & "退陣要求度に-8%"
                    form_sabotageByGov.ShowDialog()

                Case "7"
                    updateProgressBar(-9)

                    Dim form_sabotageByGov As New Form_sabotageByGov
                    form_sabotageByGov.text_form_sabotageByGov = "外国勢力による介入." & vbCrLf & "我々の活動に多数の妨害工作が発見された..." & vbCrLf & "退陣要求度に-9%"
                    form_sabotageByGov.ShowDialog()

                Case "8"
                    updateProgressBar(-10)

                    Dim form_sabotageByGov As New Form_sabotageByGov
                    form_sabotageByGov.text_form_sabotageByGov = "重要拠点の陥落" & vbCrLf & "多くの資料が焼却されてしまった..." & vbCrLf & "退陣要求度に-10%"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_demoMarch.Click  'Button of action 国会前でデモ集会を敢行
        refreshComments()

        commentFukuda()
        commentMori()
        sabotageByGov()

        Dim num = RandomNumberGenerator.GetInt32(0, 20)
        If num = 0 Or num <= 10 Then    'fail if 0 to 10
            If (ProgressBar1.Value >= 15) Then
                updateProgressBar(-15)
            Else
                ProgressBar1.Value = 0

            End If
            Label_barBottom1.Text = ProgressBar1.Value.ToString
            Label_result.Text = "SNSで大批判をくらった..." & vbCrLf & "国民は我々に厳しい目を向けている。" & vbCrLf & "退陣要求度に-15%" & vbCrLf & "政権が退陣するまで" & 100 - ProgressBar1.Value & "%"
        Else
            updateProgressBar(num)

            Label_barBottom1.Text = ProgressBar1.Value.ToString
            Label_result.Text = "我々の言葉が国民の心に響いた！" & vbCrLf & "退陣要求度に+" & num & "%" & vbCrLf & "政権が退陣するまで" & 100 - ProgressBar1.Value & "%"
        End If

        Label_days.Text = Label_days.Text - 120

        checkDays()

        If (ProgressBar1.Value >= 100) Then
            checkWin()

        Else
            canAttack()
        End If
    End Sub

    Private Sub Button_youtube_Click(sender As Object, e As EventArgs) Handles Button_youtube.Click 'Button of action Youtubeで闘争を生配信
        refreshComments()

        commentFukuda()
        commentMori()
        sabotageByGov()

        Dim num = RandomNumberGenerator.GetInt32(0, 8)
        If num = 0 Or num <= 2 Then     'fail if 0 to 2
            If (ProgressBar1.Value >= 2) Then
                updateProgressBar(-2)

            Else
                ProgressBar1.Value = 0

            End If
            Label_barBottom1.Text = ProgressBar1.Value.ToString
            Label_result.Text = "視聴者０人..." & vbCrLf & "国民は我々に関心がないようだ。" & vbCrLf & "退陣要求度に-2%" & vbCrLf & "政権が退陣するまで" & 100 - ProgressBar1.Value & "%"
        Else
            updateProgressBar(num)

            Label_barBottom1.Text = ProgressBar1.Value.ToString
            Label_result.Text = "我々の言葉が国民に心に響いた！" & vbCrLf & "退陣要求度に+" & num & "%" & vbCrLf & "政権が退陣するまで" & 100 - ProgressBar1.Value & "%"
        End If

        Label_days.Text = Label_days.Text - 30

        checkDays()

        If (ProgressBar1.Value >= 100) Then
            checkWin()

        Else
            canAttack()

        End If
    End Sub

    Private Sub Button_sabotage_Click(sender As Object, e As EventArgs) Handles Button_sabotage.Click   'Button of action 政府との癒着企業にサボタージュ
        refreshComments()

        commentFukuda()
        commentMori()
        sabotageByGov()

        Dim num = RandomNumberGenerator.GetInt32(0, 10)
        If num = 0 Or num <= 3 Then     'fail if 0 to 3
            If (ProgressBar1.Value >= 3) Then
                updateProgressBar(-3)

            Else
                ProgressBar1.Value = 0

            End If
            Label_barBottom1.Text = ProgressBar1.Value.ToString
            Label_result.Text = "諜報員が暗殺され、サボタージュ失敗..." & vbCrLf & "これからの妨害工作はより一層難しくなるであろう。" & vbCrLf & "退陣要求度に-3%" & vbCrLf & "政権が退陣するまで" & 100 - ProgressBar1.Value & "%"
        Else
            updateProgressBar(num)

            Label_barBottom1.Text = ProgressBar1.Value.ToString
            Label_result.Text = "サボタージュ成功！企業と政府の汚職を公表！！" & vbCrLf & "退陣要求度に+" & num & "%" & vbCrLf & "政権が退陣するまで" & 100 - ProgressBar1.Value & "%"
        End If

        Label_days.Text = Label_days.Text - 60

        checkDays()

        If (ProgressBar1.Value >= 100) Then
            checkWin()

        Else
            canAttack()

        End If
    End Sub

    Private Sub Button_education_Click(sender As Object, e As EventArgs) Handles Button_education.Click     'Button of action 大学でメンバー勧誘　思想教育セミナーを開催
        refreshComments()

        commentFukuda()
        commentMori()
        sabotageByGov()

        Dim num = RandomNumberGenerator.GetInt32(0, 8)
        If num = 0 Or num = 1 Then      'fail if 0 or 1
            If (ProgressBar1.Value >= 2) Then
                updateProgressBar(-2)
            Else
                ProgressBar1.Value = 0

            End If
            Label_barBottom1.Text = ProgressBar1.Value.ToString
            Label_result.Text = "我々の行動がSNSで晒され笑いものに..." & vbCrLf & "退陣要求度に-2%" & vbCrLf & "政権が退陣するまで" & 100 - ProgressBar1.Value & "%"
        Else
            updateProgressBar(num)

            Label_barBottom1.Text = ProgressBar1.Value.ToString
            Label_result.Text = "エリート大学生が加入！" & vbCrLf & "彼の後輩たちもメンバーとして加入してくれるだろう。" & vbCrLf & "退陣要求度に+" & num & "%" & vbCrLf & "政権が退陣するまで" & 100 - ProgressBar1.Value & "%"
        End If

        Label_days.Text = Label_days.Text - 30

        checkDays()

        If (ProgressBar1.Value >= 100) Then
            checkWin()

        Else
            canAttack()

        End If
    End Sub

    Private Sub Button_contact_Click(sender As Object, e As EventArgs) Handles Button_contact.Click     'Button of action 他国の同志とお互いの活動を共有
        refreshComments()

        commentFukuda()
        commentMori()
        sabotageByGov()

        Dim num = RandomNumberGenerator.GetInt32(0, 5)
        If num = 0 Or num = 1 Then      'fail if 0 or 1
            If (ProgressBar1.Value >= 3) Then
                updateProgressBar(-3)

            Else
                ProgressBar1.Value = 0

            End If
            Label_barBottom1.Text = ProgressBar1.Value.ToString
            Label_result.Text = "通信中に突然の停電、連絡不可能に..." & vbCrLf & "退陣要求度に-3%" & vbCrLf & "政権が退陣するまで" & 100 - ProgressBar1.Value & "%"
        Else
            updateProgressBar(num)

            Label_barBottom1.Text = ProgressBar1.Value.ToString
            Label_result.Text = "革命に関する新しい知見を得た！" & vbCrLf & "退陣要求度に+" & num & "%" & vbCrLf & "政権が退陣するまで" & 100 - ProgressBar1.Value & "%"
        End If

        Label_days.Text = Label_days.Text - 20

        checkDays()

        If (ProgressBar1.Value >= 100) Then
            checkWin()

        Else
            canAttack()

        End If
    End Sub

    Private Sub Button_attack_Click(sender As Object, e As EventArgs) Handles Button_attack.Click   'Button of action 政府部に全員で武装攻撃（最終手段）
        refreshComments()

        Dim num = RandomNumberGenerator.GetInt32(0, 2)
        If num = 0 Then 'fail if 0
            ProgressBar1.Value = 0
            Label_Fukuda.Text = "首相！" & vbCrLf & "アメリカが助けに来てくれましたぞ！"
            Label_Mori.Text = "戦後アメリカの犬を演じてきたかいがあったな！"
            Label_result.Text = "アメリカ政府が介入！" & vbCrLf & "我々の敗北が確定した..."

            stopMusic = True
            waveOut.Stop()

            Dim form_attack_lose As New Form_attack_lose
            AddHandler form_attack_lose.FormClosed, AddressOf closeForms

            form_attack_lose.ShowDialog()
        Else
            ProgressBar1.Value = 100
            Label_barBottom1.Text = ProgressBar1.Value.ToString
            Label_Fukuda.Text = "首相..." & vbCrLf & "遂に革命を起こされてしまいましたぞ..."
            Label_Mori.Text = "女性が政治に入ってきたせいで日本は軟弱化してしまった！"
            Label_result.Text = "政府を破壊！" & vbCrLf & "新革命政府を樹立。新しい日本の始まりだ..."

            stopMusic = True
            waveOut.Stop()

            Dim form_attack_win As New Form_attack_win
            AddHandler form_attack_win.FormClosed, AddressOf closeForms

            form_attack_win.ShowDialog()
        End If

        Label_days.Text = 0
    End Sub

    Private Sub closeForms(sender As Object, e As FormClosedEventArgs)  'close Form_main
        Application.Exit()
    End Sub

End Class
