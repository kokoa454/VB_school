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
        components = New ComponentModel.Container()
        Button_start = New Button()
        Button_stop = New Button()
        Button_reset = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Timer1 = New Timer(components)
        TextBox_min = New TextBox()
        TextBox_sec = New TextBox()
        SuspendLayout()
        ' 
        ' Button_start
        ' 
        Button_start.Location = New Point(159, 293)
        Button_start.Name = "Button_start"
        Button_start.Size = New Size(131, 72)
        Button_start.TabIndex = 0
        Button_start.Text = "START"
        Button_start.UseVisualStyleBackColor = True
        ' 
        ' Button_stop
        ' 
        Button_stop.Location = New Point(373, 293)
        Button_stop.Name = "Button_stop"
        Button_stop.Size = New Size(131, 72)
        Button_stop.TabIndex = 1
        Button_stop.Text = "STOP"
        Button_stop.UseVisualStyleBackColor = True
        ' 
        ' Button_reset
        ' 
        Button_reset.Location = New Point(373, 479)
        Button_reset.Name = "Button_reset"
        Button_reset.Size = New Size(131, 72)
        Button_reset.TabIndex = 2
        Button_reset.Text = "RESET"
        Button_reset.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13F)
        Label4.Location = New Point(290, 145)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 42)
        Label4.TabIndex = 7
        Label4.Text = "分"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13F)
        Label5.Location = New Point(526, 140)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 42)
        Label5.TabIndex = 8
        Label5.Text = "秒"
        ' 
        ' Timer1
        ' 
        ' 
        ' TextBox_min
        ' 
        TextBox_min.Font = New Font("Segoe UI", 30F)
        TextBox_min.Location = New Point(112, 81)
        TextBox_min.Name = "TextBox_min"
        TextBox_min.Size = New Size(155, 101)
        TextBox_min.TabIndex = 9
        TextBox_min.Text = "0"
        TextBox_min.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox_sec
        ' 
        TextBox_sec.Font = New Font("Segoe UI", 30F)
        TextBox_sec.Location = New Point(372, 81)
        TextBox_sec.Name = "TextBox_sec"
        TextBox_sec.Size = New Size(148, 101)
        TextBox_sec.TabIndex = 10
        TextBox_sec.Text = "0"
        TextBox_sec.TextAlign = HorizontalAlignment.Center
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(686, 592)
        Controls.Add(TextBox_sec)
        Controls.Add(TextBox_min)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Button_reset)
        Controls.Add(Button_stop)
        Controls.Add(Button_start)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button_start As Button
    Friend WithEvents Button_stop As Button
    Friend WithEvents Button_reset As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox_min As TextBox
    Friend WithEvents TextBox_sec As TextBox

End Class
