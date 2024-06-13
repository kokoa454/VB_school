<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_main
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
        Button_JP = New Button()
        Button_Eng = New Button()
        SuspendLayout()
        ' 
        ' Button_JP
        ' 
        Button_JP.Location = New Point(226, 213)
        Button_JP.Name = "Button_JP"
        Button_JP.Size = New Size(131, 40)
        Button_JP.TabIndex = 0
        Button_JP.Text = "日本語"
        Button_JP.UseVisualStyleBackColor = True
        ' 
        ' Button_Eng
        ' 
        Button_Eng.Location = New Point(454, 213)
        Button_Eng.Name = "Button_Eng"
        Button_Eng.Size = New Size(131, 40)
        Button_Eng.TabIndex = 1
        Button_Eng.Text = "English"
        Button_Eng.UseVisualStyleBackColor = True
        ' 
        ' Form_main
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button_Eng)
        Controls.Add(Button_JP)
        Name = "Form_main"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button_JP As Button
    Friend WithEvents Button_Eng As Button

End Class
