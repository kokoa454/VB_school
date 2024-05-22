<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Button_jikkou = New Button()
        Label_hyouji = New Label()
        SuspendLayout()
        ' 
        ' Button_jikkou
        ' 
        Button_jikkou.Location = New Point(176, 201)
        Button_jikkou.Name = "Button_jikkou"
        Button_jikkou.Size = New Size(131, 40)
        Button_jikkou.TabIndex = 0
        Button_jikkou.Text = "実行"
        Button_jikkou.UseVisualStyleBackColor = True
        ' 
        ' Label_hyouji
        ' 
        Label_hyouji.AutoSize = True
        Label_hyouji.BorderStyle = BorderStyle.FixedSingle
        Label_hyouji.Location = New Point(483, 206)
        Label_hyouji.Name = "Label_hyouji"
        Label_hyouji.Size = New Size(144, 32)
        Label_hyouji.TabIndex = 1
        Label_hyouji.Text = "メソッドのテスト"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label_hyouji)
        Controls.Add(Button_jikkou)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button_jikkou As Button
    Friend WithEvents Label_hyouji As Label

End Class
