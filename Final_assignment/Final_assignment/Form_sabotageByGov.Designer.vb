﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_sabotageByGov
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
        Label_text1 = New Label()
        Label_mainText = New Label()
        SuspendLayout()
        ' 
        ' Button_OK
        ' 
        Button_OK.Location = New Point(315, 354)
        Button_OK.Name = "Button_OK"
        Button_OK.Size = New Size(131, 40)
        Button_OK.TabIndex = 0
        Button_OK.Text = "OK"
        Button_OK.UseVisualStyleBackColor = True
        ' 
        ' Label_text1
        ' 
        Label_text1.AutoSize = True
        Label_text1.Font = New Font("Segoe UI", 20F)
        Label_text1.Location = New Point(164, 41)
        Label_text1.Name = "Label_text1"
        Label_text1.Size = New Size(433, 62)
        Label_text1.TabIndex = 1
        Label_text1.Text = "政府による妨害！！"
        ' 
        ' Label_mainText
        ' 
        Label_mainText.ImageAlign = ContentAlignment.MiddleRight
        Label_mainText.Location = New Point(35, 174)
        Label_mainText.Name = "Label_mainText"
        Label_mainText.Size = New Size(675, 96)
        Label_mainText.TabIndex = 2
        Label_mainText.Text = "Label_mainText"
        Label_mainText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form_sabotageByGov
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(751, 434)
        Controls.Add(Label_mainText)
        Controls.Add(Label_text1)
        Controls.Add(Button_OK)
        Name = "Form_sabotageByGov"
        Text = "sabotageByGov"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button_OK As Button
    Friend WithEvents Label_text1 As Label
    Friend WithEvents Label_mainText As Label
End Class