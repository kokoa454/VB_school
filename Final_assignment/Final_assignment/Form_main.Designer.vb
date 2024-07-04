<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label_enemyName = New Label()
        Label_days = New Label()
        Label_text1 = New Label()
        Label_text2 = New Label()
        ProgressBar1 = New ProgressBar()
        Label_barBottom1 = New Label()
        Label_barBottom2 = New Label()
        Label_barBottom3 = New Label()
        Label_barTop = New Label()
        Label_barBottom4 = New Label()
        Button_demoMarch = New Button()
        Label_result = New Label()
        Button_youtube = New Button()
        Button_sabotage = New Button()
        Button_education = New Button()
        Button_contact = New Button()
        Button_attack = New Button()
        SuspendLayout()
        ' 
        ' Label_enemyName
        ' 
        Label_enemyName.AutoSize = True
        Label_enemyName.Location = New Point(82, 53)
        Label_enemyName.Name = "Label_enemyName"
        Label_enemyName.Size = New Size(57, 30)
        Label_enemyName.TabIndex = 0
        Label_enemyName.Text = "政権"
        ' 
        ' Label_days
        ' 
        Label_days.Font = New Font("Segoe UI", 10F)
        Label_days.Location = New Point(662, 52)
        Label_days.Name = "Label_days"
        Label_days.Size = New Size(72, 30)
        Label_days.TabIndex = 1
        Label_days.Text = "0"
        Label_days.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label_text1
        ' 
        Label_text1.AutoSize = True
        Label_text1.Font = New Font("Segoe UI", 10F)
        Label_text1.Location = New Point(551, 51)
        Label_text1.Name = "Label_text1"
        Label_text1.Size = New Size(105, 32)
        Label_text1.TabIndex = 2
        Label_text1.Text = "残り日数"
        ' 
        ' Label_text2
        ' 
        Label_text2.AutoSize = True
        Label_text2.Font = New Font("Segoe UI", 10F)
        Label_text2.Location = New Point(725, 53)
        Label_text2.Name = "Label_text2"
        Label_text2.Size = New Size(39, 32)
        Label_text2.TabIndex = 3
        Label_text2.Text = "日"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.ForeColor = Color.Red
        ProgressBar1.Location = New Point(46, 246)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(739, 40)
        ProgressBar1.TabIndex = 4
        ' 
        ' Label_barBottom1
        ' 
        Label_barBottom1.Font = New Font("Segoe UI", 10F)
        Label_barBottom1.Location = New Point(592, 316)
        Label_barBottom1.Name = "Label_barBottom1"
        Label_barBottom1.Size = New Size(70, 30)
        Label_barBottom1.TabIndex = 5
        Label_barBottom1.Text = "0"
        Label_barBottom1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label_barBottom2
        ' 
        Label_barBottom2.AutoSize = True
        Label_barBottom2.Font = New Font("Segoe UI", 10F)
        Label_barBottom2.Location = New Point(662, 314)
        Label_barBottom2.Name = "Label_barBottom2"
        Label_barBottom2.Size = New Size(23, 32)
        Label_barBottom2.TabIndex = 6
        Label_barBottom2.Text = "/"
        Label_barBottom2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label_barBottom3
        ' 
        Label_barBottom3.Font = New Font("Segoe UI", 10F)
        Label_barBottom3.Location = New Point(681, 316)
        Label_barBottom3.Name = "Label_barBottom3"
        Label_barBottom3.Size = New Size(68, 30)
        Label_barBottom3.TabIndex = 7
        Label_barBottom3.Text = "0"
        Label_barBottom3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label_barTop
        ' 
        Label_barTop.AutoSize = True
        Label_barTop.BackColor = SystemColors.Control
        Label_barTop.Location = New Point(46, 198)
        Label_barTop.Name = "Label_barTop"
        Label_barTop.Size = New Size(128, 30)
        Label_barTop.TabIndex = 8
        Label_barTop.Text = "退陣まで残り"
        ' 
        ' Label_barBottom4
        ' 
        Label_barBottom4.AutoSize = True
        Label_barBottom4.Font = New Font("Segoe UI", 10F)
        Label_barBottom4.Location = New Point(755, 316)
        Label_barBottom4.Name = "Label_barBottom4"
        Label_barBottom4.Size = New Size(34, 32)
        Label_barBottom4.TabIndex = 9
        Label_barBottom4.Text = "%"
        ' 
        ' Button_demoMarch
        ' 
        Button_demoMarch.Font = New Font("Segoe UI", 11F)
        Button_demoMarch.Location = New Point(46, 542)
        Button_demoMarch.Name = "Button_demoMarch"
        Button_demoMarch.Size = New Size(246, 132)
        Button_demoMarch.TabIndex = 10
        Button_demoMarch.Text = "国会前で" & vbCrLf & "デモ集会を敢行"
        Button_demoMarch.UseVisualStyleBackColor = True
        ' 
        ' Label_result
        ' 
        Label_result.Font = New Font("Segoe UI", 13F)
        Label_result.Location = New Point(94, 367)
        Label_result.Name = "Label_result"
        Label_result.Size = New Size(646, 158)
        Label_result.TabIndex = 11
        Label_result.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button_youtube
        ' 
        Button_youtube.Font = New Font("Segoe UI", 11F)
        Button_youtube.Location = New Point(298, 542)
        Button_youtube.Name = "Button_youtube"
        Button_youtube.Size = New Size(253, 132)
        Button_youtube.TabIndex = 12
        Button_youtube.Text = "Youtubeで" & vbCrLf & "闘争を生放送"
        Button_youtube.UseVisualStyleBackColor = True
        ' 
        ' Button_sabotage
        ' 
        Button_sabotage.Font = New Font("Segoe UI", 11F)
        Button_sabotage.Location = New Point(555, 542)
        Button_sabotage.Name = "Button_sabotage"
        Button_sabotage.Size = New Size(244, 132)
        Button_sabotage.TabIndex = 13
        Button_sabotage.Text = "政府との癒着企業" & vbCrLf & "にサボタージュ"
        Button_sabotage.UseVisualStyleBackColor = True
        ' 
        ' Button_education
        ' 
        Button_education.Font = New Font("Segoe UI", 11F)
        Button_education.Location = New Point(46, 692)
        Button_education.Name = "Button_education"
        Button_education.Size = New Size(246, 132)
        Button_education.TabIndex = 14
        Button_education.Text = "大学でメンバー勧誘" & vbCrLf & "思想教育セミナー" & vbCrLf & "を開催"
        Button_education.UseVisualStyleBackColor = True
        ' 
        ' Button_contact
        ' 
        Button_contact.Font = New Font("Segoe UI", 11F)
        Button_contact.Location = New Point(298, 692)
        Button_contact.Name = "Button_contact"
        Button_contact.Size = New Size(253, 132)
        Button_contact.TabIndex = 15
        Button_contact.Text = "他国の同志と" & vbCrLf & "お互いの活動を共有"
        Button_contact.UseVisualStyleBackColor = True
        ' 
        ' Button_attack
        ' 
        Button_attack.BackColor = Color.Red
        Button_attack.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button_attack.ForeColor = Color.Yellow
        Button_attack.Location = New Point(555, 692)
        Button_attack.Name = "Button_attack"
        Button_attack.Size = New Size(246, 132)
        Button_attack.TabIndex = 16
        Button_attack.Text = "政府部に全員で" & vbCrLf & "武装攻撃" & vbCrLf & "（最終手段）"
        Button_attack.UseVisualStyleBackColor = False
        Button_attack.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(824, 927)
        Controls.Add(Button_attack)
        Controls.Add(Button_contact)
        Controls.Add(Button_education)
        Controls.Add(Button_sabotage)
        Controls.Add(Button_youtube)
        Controls.Add(Label_result)
        Controls.Add(Button_demoMarch)
        Controls.Add(Label_barBottom4)
        Controls.Add(Label_barTop)
        Controls.Add(Label_barBottom3)
        Controls.Add(Label_barBottom2)
        Controls.Add(Label_barBottom1)
        Controls.Add(ProgressBar1)
        Controls.Add(Label_text2)
        Controls.Add(Label_text1)
        Controls.Add(Label_days)
        Controls.Add(Label_enemyName)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label_enemyName As Label
    Friend WithEvents Label_days As Label
    Friend WithEvents Label_text1 As Label
    Friend WithEvents Label_text2 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label_barBottom1 As Label
    Friend WithEvents Label_barBottom2 As Label
    Friend WithEvents Label_barBottom3 As Label
    Friend WithEvents Label_barTop As Label
    Friend WithEvents Label_barBottom4 As Label
    Friend WithEvents Button_demoMarch As Button
    Friend WithEvents Label_result As Label
    Friend WithEvents Button_youtube As Button
    Friend WithEvents Button_sabotage As Button
    Friend WithEvents Button_education As Button
    Friend WithEvents Button_contact As Button
    Friend WithEvents Button_attack As Button

End Class
