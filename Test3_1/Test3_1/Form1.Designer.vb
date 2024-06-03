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
        Label_text = New Label()
        TextBox = New TextBox()
        Button_go = New Button()
        Button_all = New Button()
        SuspendLayout()
        ' 
        ' Label_text
        ' 
        Label_text.AutoSize = True
        Label_text.Location = New Point(92, 190)
        Label_text.Name = "Label_text"
        Label_text.Size = New Size(97, 30)
        Label_text.TabIndex = 0
        Label_text.Text = "何の段？"
        ' 
        ' TextBox
        ' 
        TextBox.Location = New Point(293, 192)
        TextBox.Name = "TextBox"
        TextBox.Size = New Size(175, 35)
        TextBox.TabIndex = 1
        ' 
        ' Button_go
        ' 
        Button_go.Location = New Point(588, 190)
        Button_go.Name = "Button_go"
        Button_go.Size = New Size(131, 40)
        Button_go.TabIndex = 2
        Button_go.Text = "GO"
        Button_go.UseVisualStyleBackColor = True
        ' 
        ' Button_all
        ' 
        Button_all.Location = New Point(588, 285)
        Button_all.Name = "Button_all"
        Button_all.Size = New Size(131, 40)
        Button_all.TabIndex = 3
        Button_all.Text = "ALL"
        Button_all.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button_all)
        Controls.Add(Button_go)
        Controls.Add(TextBox)
        Controls.Add(Label_text)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label_text As Label
    Friend WithEvents TextBox As TextBox
    Friend WithEvents Button_go As Button
    Friend WithEvents Button_all As Button

End Class
