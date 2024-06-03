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
        Button_goukei = New Button()
        TextBox_goukei = New TextBox()
        TextBox_kosuu3 = New TextBox()
        TextBox_kosuu2 = New TextBox()
        TextBox_kosuu1 = New TextBox()
        SuspendLayout()
        ' 
        ' Button_goukei
        ' 
        Button_goukei.Location = New Point(552, 340)
        Button_goukei.Name = "Button_goukei"
        Button_goukei.Size = New Size(131, 40)
        Button_goukei.TabIndex = 0
        Button_goukei.Text = "合計"
        Button_goukei.UseVisualStyleBackColor = True
        ' 
        ' TextBox_goukei
        ' 
        TextBox_goukei.Location = New Point(176, 345)
        TextBox_goukei.Name = "TextBox_goukei"
        TextBox_goukei.Size = New Size(175, 35)
        TextBox_goukei.TabIndex = 1
        ' 
        ' TextBox_kosuu3
        ' 
        TextBox_kosuu3.Location = New Point(176, 264)
        TextBox_kosuu3.Name = "TextBox_kosuu3"
        TextBox_kosuu3.Size = New Size(175, 35)
        TextBox_kosuu3.TabIndex = 2
        ' 
        ' TextBox_kosuu2
        ' 
        TextBox_kosuu2.Location = New Point(176, 180)
        TextBox_kosuu2.Name = "TextBox_kosuu2"
        TextBox_kosuu2.Size = New Size(175, 35)
        TextBox_kosuu2.TabIndex = 3
        ' 
        ' TextBox_kosuu1
        ' 
        TextBox_kosuu1.Location = New Point(176, 95)
        TextBox_kosuu1.Name = "TextBox_kosuu1"
        TextBox_kosuu1.Size = New Size(175, 35)
        TextBox_kosuu1.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox_kosuu1)
        Controls.Add(TextBox_kosuu2)
        Controls.Add(TextBox_kosuu3)
        Controls.Add(TextBox_goukei)
        Controls.Add(Button_goukei)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button_goukei As Button
    Friend WithEvents TextBox_goukei As TextBox
    Friend WithEvents TextBox_kosuu3 As TextBox
    Friend WithEvents TextBox_kosuu2 As TextBox
    Friend WithEvents TextBox_kosuu1 As TextBox

End Class
