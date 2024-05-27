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
        TextBox_tensuu = New TextBox()
        Label_hyouka = New Label()
        Button_hyouka = New Button()
        Button_reset = New Button()
        SuspendLayout()
        ' 
        ' TextBox_tensuu
        ' 
        TextBox_tensuu.Location = New Point(97, 197)
        TextBox_tensuu.Name = "TextBox_tensuu"
        TextBox_tensuu.Size = New Size(175, 35)
        TextBox_tensuu.TabIndex = 0
        ' 
        ' Label_hyouka
        ' 
        Label_hyouka.AutoSize = True
        Label_hyouka.Location = New Point(355, 192)
        Label_hyouka.Name = "Label_hyouka"
        Label_hyouka.Size = New Size(0, 30)
        Label_hyouka.TabIndex = 1
        ' 
        ' Button_hyouka
        ' 
        Button_hyouka.Location = New Point(568, 197)
        Button_hyouka.Name = "Button_hyouka"
        Button_hyouka.Size = New Size(131, 40)
        Button_hyouka.TabIndex = 2
        Button_hyouka.Text = "評価"
        Button_hyouka.UseVisualStyleBackColor = True
        ' 
        ' Button_reset
        ' 
        Button_reset.Location = New Point(568, 294)
        Button_reset.Name = "Button_reset"
        Button_reset.Size = New Size(131, 40)
        Button_reset.TabIndex = 3
        Button_reset.Text = "リセット"
        Button_reset.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12.0F, 30.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button_reset)
        Controls.Add(Button_hyouka)
        Controls.Add(Label_hyouka)
        Controls.Add(TextBox_tensuu)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox_tensuu As TextBox
    Friend WithEvents Label_hyouka As Label
    Friend WithEvents Button_hyouka As Button
    Friend WithEvents Button_reset As Button

End Class
