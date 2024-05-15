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
        Button_blue = New Button()
        Label_color = New Label()
        SuspendLayout()
        ' 
        ' Button_blue
        ' 
        Button_blue.Location = New Point(547, 192)
        Button_blue.Name = "Button_blue"
        Button_blue.Size = New Size(131, 40)
        Button_blue.TabIndex = 0
        Button_blue.Text = "青くする"
        Button_blue.UseVisualStyleBackColor = True
        ' 
        ' Label_color
        ' 
        Label_color.AutoSize = True
        Label_color.Location = New Point(155, 192)
        Label_color.Name = "Label_color"
        Label_color.Size = New Size(287, 30)
        Label_color.TabIndex = 1
        Label_color.Text = "ボタンをクリックすると青くなります"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label_color)
        Controls.Add(Button_blue)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button_blue As Button
    Friend WithEvents Label_color As Label

End Class
