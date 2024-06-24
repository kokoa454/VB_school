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
        Label1 = New Label()
        Button_start = New Button()
        Button_stop = New Button()
        Button_reset = New Button()
        Timer1 = New System.Windows.Forms.Timer(components)
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 30F)
        Label1.Location = New Point(186, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 93)
        Label1.TabIndex = 0
        Label1.Text = "0"
        ' 
        ' Button_start
        ' 
        Button_start.Location = New Point(160, 188)
        Button_start.Name = "Button_start"
        Button_start.Size = New Size(131, 40)
        Button_start.TabIndex = 1
        Button_start.Text = "START"
        Button_start.UseVisualStyleBackColor = True
        ' 
        ' Button_stop
        ' 
        Button_stop.Location = New Point(525, 188)
        Button_stop.Name = "Button_stop"
        Button_stop.Size = New Size(131, 40)
        Button_stop.TabIndex = 2
        Button_stop.Text = "STOP"
        Button_stop.UseVisualStyleBackColor = True
        ' 
        ' Button_reset
        ' 
        Button_reset.Location = New Point(160, 344)
        Button_reset.Name = "Button_reset"
        Button_reset.Size = New Size(131, 40)
        Button_reset.TabIndex = 3
        Button_reset.Text = "RESET"
        Button_reset.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 30F)
        Label2.Location = New Point(364, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 93)
        Label2.TabIndex = 4
        Label2.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 30F)
        Label3.Location = New Point(546, 37)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 93)
        Label3.TabIndex = 5
        Label3.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(270, 100)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 30)
        Label4.TabIndex = 6
        Label4.Text = "分"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(473, 100)
        Label5.Name = "Label5"
        Label5.Size = New Size(35, 30)
        Label5.TabIndex = 7
        Label5.Text = "秒"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button_reset)
        Controls.Add(Button_stop)
        Controls.Add(Button_start)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button_start As Button
    Friend WithEvents Button_stop As Button
    Friend WithEvents Button_reset As Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class
