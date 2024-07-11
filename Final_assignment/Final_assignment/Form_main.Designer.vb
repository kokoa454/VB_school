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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_main))
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
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label_Fukuda = New Label()
        PictureBox4 = New PictureBox()
        Label_Mori = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label_enemyName
        ' 
        Label_enemyName.AutoSize = True
        Label_enemyName.Font = New Font("HGP明朝E", 14F, FontStyle.Bold)
        Label_enemyName.Location = New Point(62, 4)
        Label_enemyName.Margin = New Padding(2, 0, 2, 0)
        Label_enemyName.Name = "Label_enemyName"
        Label_enemyName.Size = New Size(129, 19)
        Label_enemyName.TabIndex = 0
        Label_enemyName.Text = "第三次森内閣"
        ' 
        ' Label_days
        ' 
        Label_days.Font = New Font("HGP明朝B", 12F)
        Label_days.Location = New Point(473, 11)
        Label_days.Margin = New Padding(2, 0, 2, 0)
        Label_days.Name = "Label_days"
        Label_days.Size = New Size(42, 15)
        Label_days.TabIndex = 1
        Label_days.Text = "0"
        Label_days.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label_text1
        ' 
        Label_text1.AutoSize = True
        Label_text1.Font = New Font("HGP明朝B", 12F)
        Label_text1.Location = New Point(405, 9)
        Label_text1.Margin = New Padding(2, 0, 2, 0)
        Label_text1.Name = "Label_text1"
        Label_text1.Size = New Size(64, 16)
        Label_text1.TabIndex = 2
        Label_text1.Text = "残り日数"
        ' 
        ' Label_text2
        ' 
        Label_text2.AutoSize = True
        Label_text2.Font = New Font("HGP明朝B", 12F)
        Label_text2.Location = New Point(519, 10)
        Label_text2.Margin = New Padding(2, 0, 2, 0)
        Label_text2.Name = "Label_text2"
        Label_text2.Size = New Size(23, 16)
        Label_text2.TabIndex = 3
        Label_text2.Text = "日"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.ForeColor = Color.Red
        ProgressBar1.Location = New Point(52, 366)
        ProgressBar1.Margin = New Padding(2)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(497, 20)
        ProgressBar1.TabIndex = 4
        ' 
        ' Label_barBottom1
        ' 
        Label_barBottom1.Font = New Font("HGS明朝B", 12F)
        Label_barBottom1.Location = New Point(428, 402)
        Label_barBottom1.Margin = New Padding(2, 0, 2, 0)
        Label_barBottom1.Name = "Label_barBottom1"
        Label_barBottom1.Size = New Size(41, 15)
        Label_barBottom1.TabIndex = 5
        Label_barBottom1.Text = "0"
        Label_barBottom1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label_barBottom2
        ' 
        Label_barBottom2.AutoSize = True
        Label_barBottom2.Font = New Font("HGS明朝B", 12F)
        Label_barBottom2.Location = New Point(473, 402)
        Label_barBottom2.Margin = New Padding(2, 0, 2, 0)
        Label_barBottom2.Name = "Label_barBottom2"
        Label_barBottom2.Size = New Size(15, 16)
        Label_barBottom2.TabIndex = 6
        Label_barBottom2.Text = "/"
        Label_barBottom2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label_barBottom3
        ' 
        Label_barBottom3.Font = New Font("HGS明朝B", 12F)
        Label_barBottom3.Location = New Point(492, 402)
        Label_barBottom3.Margin = New Padding(2, 0, 2, 0)
        Label_barBottom3.Name = "Label_barBottom3"
        Label_barBottom3.Size = New Size(40, 15)
        Label_barBottom3.TabIndex = 7
        Label_barBottom3.Text = "0"
        Label_barBottom3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label_barTop
        ' 
        Label_barTop.AutoSize = True
        Label_barTop.BackColor = SystemColors.Control
        Label_barTop.Font = New Font("HG明朝B", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(128))
        Label_barTop.Location = New Point(45, 338)
        Label_barTop.Margin = New Padding(2, 0, 2, 0)
        Label_barTop.Name = "Label_barTop"
        Label_barTop.Size = New Size(77, 12)
        Label_barTop.TabIndex = 8
        Label_barTop.Text = "退陣まで残り"
        ' 
        ' Label_barBottom4
        ' 
        Label_barBottom4.AutoSize = True
        Label_barBottom4.Font = New Font("HGS明朝B", 12F)
        Label_barBottom4.Location = New Point(534, 401)
        Label_barBottom4.Margin = New Padding(2, 0, 2, 0)
        Label_barBottom4.Name = "Label_barBottom4"
        Label_barBottom4.Size = New Size(15, 16)
        Label_barBottom4.TabIndex = 9
        Label_barBottom4.Text = "%"
        ' 
        ' Button_demoMarch
        ' 
        Button_demoMarch.Font = New Font("HGP明朝B", 13F)
        Button_demoMarch.Location = New Point(45, 527)
        Button_demoMarch.Margin = New Padding(2)
        Button_demoMarch.Name = "Button_demoMarch"
        Button_demoMarch.Size = New Size(144, 66)
        Button_demoMarch.TabIndex = 10
        Button_demoMarch.Text = "国会前で" & vbCrLf & "デモ集会を敢行"
        Button_demoMarch.UseVisualStyleBackColor = True
        ' 
        ' Label_result
        ' 
        Label_result.BorderStyle = BorderStyle.Fixed3D
        Label_result.Font = New Font("HGP明朝B", 12.8571434F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label_result.Location = New Point(45, 435)
        Label_result.Margin = New Padding(2, 0, 2, 0)
        Label_result.Name = "Label_result"
        Label_result.Size = New Size(497, 79)
        Label_result.TabIndex = 11
        Label_result.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button_youtube
        ' 
        Button_youtube.Font = New Font("HGP明朝B", 13F)
        Button_youtube.Location = New Point(211, 527)
        Button_youtube.Margin = New Padding(2)
        Button_youtube.Name = "Button_youtube"
        Button_youtube.Size = New Size(148, 66)
        Button_youtube.TabIndex = 12
        Button_youtube.Text = "Youtubeで" & vbCrLf & "闘争を生放送"
        Button_youtube.UseVisualStyleBackColor = True
        ' 
        ' Button_sabotage
        ' 
        Button_sabotage.Font = New Font("HGP明朝B", 12F)
        Button_sabotage.Location = New Point(400, 528)
        Button_sabotage.Margin = New Padding(2)
        Button_sabotage.Name = "Button_sabotage"
        Button_sabotage.Size = New Size(142, 66)
        Button_sabotage.TabIndex = 13
        Button_sabotage.Text = "政府との癒着企業" & vbCrLf & "にサボタージュ"
        Button_sabotage.UseVisualStyleBackColor = True
        ' 
        ' Button_education
        ' 
        Button_education.Font = New Font("HGP明朝B", 11F)
        Button_education.Location = New Point(45, 608)
        Button_education.Margin = New Padding(2)
        Button_education.Name = "Button_education"
        Button_education.Size = New Size(144, 66)
        Button_education.TabIndex = 14
        Button_education.Text = "大学でメンバー勧誘" & vbCrLf & "思想教育セミナー" & vbCrLf & "を開催"
        Button_education.UseVisualStyleBackColor = True
        ' 
        ' Button_contact
        ' 
        Button_contact.Font = New Font("HGP明朝B", 13F)
        Button_contact.Location = New Point(211, 607)
        Button_contact.Margin = New Padding(2)
        Button_contact.Name = "Button_contact"
        Button_contact.Size = New Size(148, 66)
        Button_contact.TabIndex = 15
        Button_contact.Text = "他国の同志と" & vbCrLf & "お互いの活動を共有"
        Button_contact.UseVisualStyleBackColor = True
        ' 
        ' Button_attack
        ' 
        Button_attack.BackColor = Color.Red
        Button_attack.Font = New Font("HGP明朝B", 13F)
        Button_attack.ForeColor = Color.Yellow
        Button_attack.Location = New Point(398, 608)
        Button_attack.Margin = New Padding(2)
        Button_attack.Name = "Button_attack"
        Button_attack.Size = New Size(144, 66)
        Button_attack.TabIndex = 16
        Button_attack.Text = "政府部に全員で" & vbCrLf & "武装攻撃" & vbCrLf & "（最終手段）"
        Button_attack.UseVisualStyleBackColor = False
        Button_attack.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(50, 28)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(151, 151)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(436, 69)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(122, 110)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 18
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(232, 28)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(198, 179)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 19
        PictureBox3.TabStop = False
        ' 
        ' Label_Fukuda
        ' 
        Label_Fukuda.Font = New Font("Segoe UI", 10F)
        Label_Fukuda.Location = New Point(270, 69)
        Label_Fukuda.Name = "Label_Fukuda"
        Label_Fukuda.Size = New Size(123, 95)
        Label_Fukuda.TabIndex = 20
        Label_Fukuda.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(45, 213)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(497, 94)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 21
        PictureBox4.TabStop = False
        ' 
        ' Label_Mori
        ' 
        Label_Mori.Font = New Font("HG明朝B", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label_Mori.Location = New Point(133, 226)
        Label_Mori.Name = "Label_Mori"
        Label_Mori.Size = New Size(336, 55)
        Label_Mori.TabIndex = 22
        ' 
        ' Form_main
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(570, 701)
        Controls.Add(Label_Mori)
        Controls.Add(PictureBox4)
        Controls.Add(Label_Fukuda)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
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
        Margin = New Padding(2)
        Name = "Form_main"
        StartPosition = FormStartPosition.CenterScreen
        Text = "革命的市民団体シミュレーター"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label_Fukuda As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label_Mori As Label

End Class
