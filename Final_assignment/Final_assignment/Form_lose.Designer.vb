<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_lose
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_lose))
        Button_OK = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button_OK
        ' 
        Button_OK.Location = New Point(450, 700)
        Button_OK.Margin = New Padding(2)
        Button_OK.Name = "Button_OK"
        Button_OK.Size = New Size(76, 20)
        Button_OK.TabIndex = 0
        Button_OK.Text = "OK"
        Button_OK.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("HGSMinchoE", 28F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(320, 30)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(348, 38)
        Label1.TabIndex = 3
        Label1.Text = "残念だ、同志諸君..."
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("HGSMinchoB", 12F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(283, 98)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(423, 32)
        Label2.TabIndex = 4
        Label2.Text = "我々の革命は失敗に終わった。" & vbCrLf & "しかし、子どもや孫の代に再び革命の火は灯るであろう！"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("HGSMinchoB", 10F)
        Label3.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label3.Location = New Point(27, 179)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(276, 14)
        Label3.TabIndex = 5
        Label3.Text = "我々は次の法律によって裁かれるであろう:"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("HGSMinchoB", 12F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(69, 231)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(847, 400)
        Label4.TabIndex = 10
        Label4.Text = resources.GetString("Label4.Text")
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(985, 763)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Form_lose
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(984, 761)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button_OK)
        Controls.Add(PictureBox1)
        Margin = New Padding(2)
        MaximizeBox = False
        MaximumSize = New Size(1000, 800)
        MinimizeBox = False
        MinimumSize = New Size(1000, 800)
        Name = "Form_lose"
        StartPosition = FormStartPosition.CenterScreen
        Text = "革命的市民団体シミュレーター"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button_OK As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
