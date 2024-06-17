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
        RadioButton_Black = New RadioButton()
        RadioButton_Red = New RadioButton()
        Button_clear = New Button()
        SuspendLayout()
        ' 
        ' RadioButton_Black
        ' 
        RadioButton_Black.AutoSize = True
        RadioButton_Black.Location = New Point(946, 648)
        RadioButton_Black.Name = "RadioButton_Black"
        RadioButton_Black.Size = New Size(60, 34)
        RadioButton_Black.TabIndex = 0
        RadioButton_Black.TabStop = True
        RadioButton_Black.Text = "黒"
        RadioButton_Black.UseVisualStyleBackColor = True
        ' 
        ' RadioButton_Red
        ' 
        RadioButton_Red.AutoSize = True
        RadioButton_Red.Location = New Point(946, 703)
        RadioButton_Red.Name = "RadioButton_Red"
        RadioButton_Red.Size = New Size(60, 34)
        RadioButton_Red.TabIndex = 1
        RadioButton_Red.TabStop = True
        RadioButton_Red.Text = "赤"
        RadioButton_Red.UseVisualStyleBackColor = True
        ' 
        ' Button_clear
        ' 
        Button_clear.Location = New Point(914, 561)
        Button_clear.Name = "Button_clear"
        Button_clear.Size = New Size(131, 40)
        Button_clear.TabIndex = 2
        Button_clear.Text = "クリア"
        Button_clear.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1057, 798)
        Controls.Add(Button_clear)
        Controls.Add(RadioButton_Red)
        Controls.Add(RadioButton_Black)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RadioButton_Black As RadioButton
    Friend WithEvents RadioButton_Red As RadioButton
    Friend WithEvents Button_clear As Button

End Class
