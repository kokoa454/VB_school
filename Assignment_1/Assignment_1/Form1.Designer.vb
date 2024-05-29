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
        Button_OK = New Button()
        Button_Reset = New Button()
        Label_ID = New Label()
        Label_Pass = New Label()
        TextBox_ID = New TextBox()
        TextBox_Pass = New TextBox()
        SuspendLayout()
        ' 
        ' Button_OK
        ' 
        Button_OK.Location = New Point(462, 267)
        Button_OK.Name = "Button_OK"
        Button_OK.Size = New Size(131, 40)
        Button_OK.TabIndex = 0
        Button_OK.Text = "OK"
        Button_OK.UseVisualStyleBackColor = True
        ' 
        ' Button_Reset
        ' 
        Button_Reset.Location = New Point(636, 267)
        Button_Reset.Name = "Button_Reset"
        Button_Reset.Size = New Size(131, 40)
        Button_Reset.TabIndex = 1
        Button_Reset.Text = "Reset"
        Button_Reset.UseVisualStyleBackColor = True
        ' 
        ' Label_ID
        ' 
        Label_ID.AutoSize = True
        Label_ID.Location = New Point(88, 111)
        Label_ID.Name = "Label_ID"
        Label_ID.Size = New Size(34, 30)
        Label_ID.TabIndex = 2
        Label_ID.Text = "ID"
        ' 
        ' Label_Pass
        ' 
        Label_Pass.AutoSize = True
        Label_Pass.Location = New Point(60, 275)
        Label_Pass.Name = "Label_Pass"
        Label_Pass.Size = New Size(100, 30)
        Label_Pass.TabIndex = 3
        Label_Pass.Text = "パスワード"
        ' 
        ' TextBox_ID
        ' 
        TextBox_ID.Location = New Point(185, 108)
        TextBox_ID.Name = "TextBox_ID"
        TextBox_ID.Size = New Size(175, 35)
        TextBox_ID.TabIndex = 4
        ' 
        ' TextBox_Pass
        ' 
        TextBox_Pass.Location = New Point(185, 272)
        TextBox_Pass.Name = "TextBox_Pass"
        TextBox_Pass.Size = New Size(175, 35)
        TextBox_Pass.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox_Pass)
        Controls.Add(TextBox_ID)
        Controls.Add(Label_Pass)
        Controls.Add(Label_ID)
        Controls.Add(Button_Reset)
        Controls.Add(Button_OK)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button_OK As Button
    Friend WithEvents Button_Reset As Button
    Friend WithEvents Label_ID As Label
    Friend WithEvents Label_Pass As Label
    Friend WithEvents TextBox_ID As TextBox
    Friend WithEvents TextBox_Pass As TextBox

End Class
