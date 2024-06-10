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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox_adult = New TextBox()
        TextBox_child = New TextBox()
        TextBox_show = New TextBox()
        SuspendLayout()
        ' 
        ' Button_calc
        ' 
        Button_calc.Location = New Point(612, 322)
        Button_calc.Name = "Button_calc"
        Button_calc.Size = New Size(131, 40)
        Button_calc.TabIndex = 3
        Button_calc.Text = "購入"
        Button_calc.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(107, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 30)
        Label1.TabIndex = 1
        Label1.Text = "大人"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(414, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 30)
        Label2.TabIndex = 2
        Label2.Text = "枚"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(107, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 30)
        Label3.TabIndex = 3
        Label3.Text = "小人"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(414, 169)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 30)
        Label4.TabIndex = 4
        Label4.Text = "枚"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(87, 322)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 30)
        Label5.TabIndex = 5
        Label5.Text = "合計金額"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(414, 324)
        Label6.Name = "Label6"
        Label6.Size = New Size(35, 30)
        Label6.TabIndex = 6
        Label6.Text = "円"
        ' 
        ' TextBox_adult
        ' 
        TextBox_adult.Location = New Point(211, 86)
        TextBox_adult.Name = "TextBox_adult"
        TextBox_adult.Size = New Size(175, 35)
        TextBox_adult.TabIndex = 1
        ' 
        ' TextBox_child
        ' 
        TextBox_child.Location = New Point(211, 164)
        TextBox_child.Name = "TextBox_child"
        TextBox_child.Size = New Size(175, 35)
        TextBox_child.TabIndex = 2
        ' 
        ' TextBox_show
        ' 
        TextBox_show.Enabled = False
        TextBox_show.Location = New Point(211, 319)
        TextBox_show.Name = "TextBox_show"
        TextBox_show.Size = New Size(175, 35)
        TextBox_show.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox_show)
        Controls.Add(TextBox_child)
        Controls.Add(TextBox_adult)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button_calc)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button_calc As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_adult As TextBox
    Friend WithEvents TextBox_child As TextBox
    Friend WithEvents TextBox_show As TextBox

End Class
