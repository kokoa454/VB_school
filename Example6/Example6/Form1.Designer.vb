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
        Button_loop = New Button()
        TextBox_cnt = New TextBox()
        SuspendLayout()
        ' 
        ' Button_loop
        ' 
        Button_loop.Location = New Point(131, 191)
        Button_loop.Name = "Button_loop"
        Button_loop.Size = New Size(131, 40)
        Button_loop.TabIndex = 0
        Button_loop.Text = "繰り返し"
        Button_loop.UseVisualStyleBackColor = True
        ' 
        ' TextBox_cnt
        ' 
        TextBox_cnt.Location = New Point(477, 191)
        TextBox_cnt.Name = "TextBox_cnt"
        TextBox_cnt.Size = New Size(175, 35)
        TextBox_cnt.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox_cnt)
        Controls.Add(Button_loop)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button_loop As Button
    Friend WithEvents TextBox_cnt As TextBox

End Class
