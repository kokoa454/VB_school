<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_tutorial
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_tutorial))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Button_OK = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.Control
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(420, 567)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("游ゴシック", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(59, 184)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 26)
        Label1.TabIndex = 1
        Label1.Text = "①"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("游ゴシック", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(207, 372)
        Label2.Name = "Label2"
        Label2.Size = New Size(32, 26)
        Label2.TabIndex = 2
        Label2.Text = "②"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("游ゴシック", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(269, 479)
        Label3.Name = "Label3"
        Label3.Size = New Size(32, 26)
        Label3.TabIndex = 3
        Label3.Text = "③"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("HGPｺﾞｼｯｸE", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(461, 12)
        Label4.Name = "Label4"
        Label4.Size = New Size(153, 24)
        Label4.TabIndex = 4
        Label4.Text = "チュートリアル"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("HGPｺﾞｼｯｸM", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label5.Location = New Point(461, 52)
        Label5.Name = "Label5"
        Label5.Size = New Size(436, 38)
        Label5.TabIndex = 5
        Label5.Text = "このゲームはタイトル通り、" & vbCrLf & "日本で革命を目指す市民団体を運営するゲームです。"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("HGPｺﾞｼｯｸM", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label6.Location = New Point(461, 148)
        Label6.Name = "Label6"
        Label6.Size = New Size(283, 19)
        Label6.TabIndex = 6
        Label6.Text = "画面構成は3つに分かれています。"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("HGPｺﾞｼｯｸM", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label7.Location = New Point(461, 191)
        Label7.Name = "Label7"
        Label7.Size = New Size(169, 75)
        Label7.TabIndex = 7
        Label7.Text = "アオ線：政府側画面" & vbCrLf & vbCrLf & "ピンク線：退陣要求度画面" & vbCrLf & vbCrLf & "ミドリ線：市民団体側画面"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("HGPｺﾞｼｯｸM", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label8.Location = New Point(461, 326)
        Label8.Name = "Label8"
        Label8.Size = New Size(133, 19)
        Label8.TabIndex = 8
        Label8.Text = "各部分について"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("HGPｺﾞｼｯｸM", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label9.Location = New Point(461, 372)
        Label9.Name = "Label9"
        Label9.Size = New Size(506, 105)
        Label9.TabIndex = 9
        Label9.Text = "①　森首相の発言が表示されます。" & vbCrLf & "　　 " & ChrW(8221) & "失言大魔王" & ChrW(8221) & "は数々の失言をするため、その度に退陣要求度が微増します。" & vbCrLf & vbCrLf & "②　市民団体が行った行動の成功/失敗が表示されます。" & vbCrLf & vbCrLf & "③　コマンドをマウスホバーすると、成功率や必要準備日数が表示されます。" & vbCrLf & "　　 各コマンドによって違うので、最初はよく確認しましょう。"
        ' 
        ' Button_OK
        ' 
        Button_OK.Location = New Point(669, 545)
        Button_OK.Name = "Button_OK"
        Button_OK.Size = New Size(84, 34)
        Button_OK.TabIndex = 10
        Button_OK.Text = "OK"
        Button_OK.UseVisualStyleBackColor = True
        ' 
        ' Form_tutorial
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(984, 611)
        ControlBox = False
        Controls.Add(Button_OK)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        MaximizeBox = False
        MaximumSize = New Size(1000, 650)
        MinimizeBox = False
        MinimumSize = New Size(1000, 650)
        Name = "Form_tutorial"
        Text = "革命的市民団体シミュレーター"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button_OK As Button
End Class
