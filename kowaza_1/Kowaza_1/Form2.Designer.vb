<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_JP
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
        Button_close = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button_close
        ' 
        Button_close.Location = New Point(476, 195)
        Button_close.Name = "Button_close"
        Button_close.Size = New Size(131, 40)
        Button_close.TabIndex = 0
        Button_close.Text = "閉じる"
        Button_close.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(150, 200)
        Label1.Name = "Label1"
        Label1.Size = New Size(257, 30)
        Label1.TabIndex = 1
        Label1.Text = "これは日本語のページです。"
        ' 
        ' Form_JP
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(Button_close)
        Name = "Form_JP"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button_close As Button
    Friend WithEvents Label1 As Label
End Class
