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
        showText = New Label()
        inputText = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Button_OK
        ' 
        Button_OK.Location = New Point(231, 356)
        Button_OK.Name = "Button_OK"
        Button_OK.Size = New Size(131, 40)
        Button_OK.TabIndex = 0
        Button_OK.Text = "OK"
        Button_OK.UseVisualStyleBackColor = True
        ' 
        ' showText
        ' 
        showText.AutoSize = True
        showText.Location = New Point(102, 187)
        showText.Name = "showText"
        showText.Size = New Size(121, 30)
        showText.TabIndex = 1
        showText.Text = "Visual Basic"
        ' 
        ' inputText
        ' 
        inputText.Location = New Point(371, 182)
        inputText.Name = "inputText"
        inputText.Size = New Size(175, 35)
        inputText.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(415, 356)
        Button1.Name = "Button1"
        Button1.Size = New Size(131, 40)
        Button1.TabIndex = 3
        Button1.Text = "OK"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(605, 450)
        Controls.Add(Button1)
        Controls.Add(inputText)
        Controls.Add(showText)
        Controls.Add(Button_OK)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button_OK As Button
    Friend WithEvents showText As Label
    Friend WithEvents inputText As TextBox
    Friend WithEvents Button1 As Button

End Class
