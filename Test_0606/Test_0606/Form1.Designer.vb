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
        Button_clear = New Button()
        Button_calc = New Button()
        TextBox_sum = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        TextBox10 = New TextBox()
        TextBox11 = New TextBox()
        SuspendLayout()
        ' 
        ' Button_clear
        ' 
        Button_clear.Location = New Point(597, 716)
        Button_clear.Name = "Button_clear"
        Button_clear.Size = New Size(131, 40)
        Button_clear.TabIndex = 11
        Button_clear.Text = "クリア"
        Button_clear.UseVisualStyleBackColor = True
        ' 
        ' Button_calc
        ' 
        Button_calc.Location = New Point(597, 496)
        Button_calc.Name = "Button_calc"
        Button_calc.Size = New Size(131, 40)
        Button_calc.TabIndex = 10
        Button_calc.Text = "計算"
        Button_calc.UseVisualStyleBackColor = True
        ' 
        ' TextBox_sum
        ' 
        TextBox_sum.Enabled = False
        TextBox_sum.Location = New Point(202, 716)
        TextBox_sum.Name = "TextBox_sum"
        TextBox_sum.Size = New Size(175, 35)
        TextBox_sum.TabIndex = 12
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(202, 612)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(175, 35)
        TextBox2.TabIndex = 9
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(202, 550)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(175, 35)
        TextBox3.TabIndex = 8
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(202, 496)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(175, 35)
        TextBox4.TabIndex = 7
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(202, 441)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(175, 35)
        TextBox5.TabIndex = 6
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(202, 385)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(175, 35)
        TextBox6.TabIndex = 5
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(202, 327)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(175, 35)
        TextBox7.TabIndex = 4
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(202, 266)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(175, 35)
        TextBox8.TabIndex = 3
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(202, 215)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(175, 35)
        TextBox9.TabIndex = 2
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(202, 156)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(175, 35)
        TextBox10.TabIndex = 1
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(202, 98)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(175, 35)
        TextBox11.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 816)
        Controls.Add(TextBox11)
        Controls.Add(TextBox10)
        Controls.Add(TextBox9)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox_sum)
        Controls.Add(Button_calc)
        Controls.Add(Button_clear)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button_clear As Button
    Friend WithEvents Button_calc As Button
    Friend WithEvents TextBox_sum As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox

End Class
