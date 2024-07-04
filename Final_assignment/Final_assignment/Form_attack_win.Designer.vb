<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_attack_win
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
        Button_OK = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button_OK
        ' 
        Button_OK.Location = New Point(352, 745)
        Button_OK.Name = "Button_OK"
        Button_OK.Size = New Size(131, 40)
        Button_OK.TabIndex = 0
        Button_OK.Text = "OK"
        Button_OK.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(388, 364)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 30)
        Label1.TabIndex = 1
        Label1.Text = "勝ち"
        ' 
        ' Form_attack_win
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(845, 839)
        Controls.Add(Label1)
        Controls.Add(Button_OK)
        Name = "Form_attack_win"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button_OK As Button
    Friend WithEvents Label1 As Label
End Class
