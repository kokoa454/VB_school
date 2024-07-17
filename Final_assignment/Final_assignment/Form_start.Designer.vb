<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_start
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
        Label1 = New Label()
        Button_start = New Button()
        Button_close = New Button()
        Button_tutorial = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("HGS明朝E", 22F, FontStyle.Bold)
        Label1.Location = New Point(25, 39)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(478, 90)
        Label1.TabIndex = 0
        Label1.Text = "ようこそ" & vbCrLf & vbCrLf & "革命的市民団体シミュレーターへ"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button_start
        ' 
        Button_start.ImageAlign = ContentAlignment.MiddleRight
        Button_start.Location = New Point(97, 187)
        Button_start.Margin = New Padding(2)
        Button_start.Name = "Button_start"
        Button_start.Size = New Size(76, 31)
        Button_start.TabIndex = 1
        Button_start.Text = "START"
        Button_start.UseVisualStyleBackColor = True
        ' 
        ' Button_close
        ' 
        Button_close.Location = New Point(353, 187)
        Button_close.Margin = New Padding(2)
        Button_close.Name = "Button_close"
        Button_close.Size = New Size(76, 31)
        Button_close.TabIndex = 2
        Button_close.Text = "CLOSE"
        Button_close.UseVisualStyleBackColor = True
        ' 
        ' Button_tutorial
        ' 
        Button_tutorial.ImageAlign = ContentAlignment.MiddleRight
        Button_tutorial.Location = New Point(227, 187)
        Button_tutorial.Margin = New Padding(2)
        Button_tutorial.Name = "Button_tutorial"
        Button_tutorial.Size = New Size(76, 31)
        Button_tutorial.TabIndex = 3
        Button_tutorial.Text = "TUTORIAL"
        Button_tutorial.UseVisualStyleBackColor = True
        ' 
        ' Form_start
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(514, 261)
        Controls.Add(Button_tutorial)
        Controls.Add(Button_close)
        Controls.Add(Button_start)
        Controls.Add(Label1)
        Margin = New Padding(2)
        MaximizeBox = False
        MaximumSize = New Size(530, 300)
        MinimizeBox = False
        MinimumSize = New Size(530, 300)
        Name = "Form_start"
        StartPosition = FormStartPosition.CenterScreen
        Text = "革命的市民団体シミュレーター"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button_start As Button
    Friend WithEvents Button_close As Button
    Friend WithEvents Button_tutorial As Button
End Class
