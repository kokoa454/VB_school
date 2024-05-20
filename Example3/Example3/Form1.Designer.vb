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
        Button_calc = New Button()
        TextBox_left = New TextBox()
        TextBox_result = New TextBox()
        Label_plus = New Label()
        Label_equal = New Label()
        TextBox_right = New TextBox()
        SuspendLayout()
        ' 
        ' Button_calc
        ' 
        Button_calc.Location = New Point(334, 324)
        Button_calc.Name = "Button_calc"
        Button_calc.Size = New Size(131, 40)
        Button_calc.TabIndex = 0
        Button_calc.Text = "文字列結合"
        Button_calc.UseVisualStyleBackColor = True
        ' 
        ' TextBox_left
        ' 
        TextBox_left.Location = New Point(52, 181)
        TextBox_left.Name = "TextBox_left"
        TextBox_left.Size = New Size(175, 35)
        TextBox_left.TabIndex = 1
        ' 
        ' TextBox_result
        ' 
        TextBox_result.Location = New Point(588, 181)
        TextBox_result.Name = "TextBox_result"
        TextBox_result.Size = New Size(175, 35)
        TextBox_result.TabIndex = 2
        ' 
        ' Label_plus
        ' 
        Label_plus.AutoSize = True
        Label_plus.Location = New Point(259, 186)
        Label_plus.Name = "Label_plus"
        Label_plus.Size = New Size(27, 30)
        Label_plus.TabIndex = 3
        Label_plus.Text = "+"
        ' 
        ' Label_equal
        ' 
        Label_equal.AutoSize = True
        Label_equal.Location = New Point(524, 184)
        Label_equal.Name = "Label_equal"
        Label_equal.Size = New Size(27, 30)
        Label_equal.TabIndex = 4
        Label_equal.Text = "="
        ' 
        ' TextBox_right
        ' 
        TextBox_right.Location = New Point(317, 181)
        TextBox_right.Name = "TextBox_right"
        TextBox_right.Size = New Size(175, 35)
        TextBox_right.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox_right)
        Controls.Add(Label_equal)
        Controls.Add(Label_plus)
        Controls.Add(TextBox_result)
        Controls.Add(TextBox_left)
        Controls.Add(Button_calc)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button_calc As Button
    Friend WithEvents TextBox_left As TextBox
    Friend WithEvents TextBox_result As TextBox
    Friend WithEvents Label_plus As Label
    Friend WithEvents Label_equal As Label
    Friend WithEvents TextBox_right As TextBox

End Class
