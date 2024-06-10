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
        Button_yobidashi = New Button()
        SuspendLayout()
        ' 
        ' Button_yobidashi
        ' 
        Button_yobidashi.Location = New Point(335, 193)
        Button_yobidashi.Name = "Button_yobidashi"
        Button_yobidashi.Size = New Size(131, 40)
        Button_yobidashi.TabIndex = 0
        Button_yobidashi.Text = "呼び出し"
        Button_yobidashi.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button_yobidashi)
        Name = "Form1"
        Text = "Example8"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button_yobidashi As Button

End Class
