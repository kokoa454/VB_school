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
        btn1 = New Button()
        btn2 = New Button()
        lbl1 = New Label()
        SuspendLayout()
        ' 
        ' btn1
        ' 
        btn1.Font = New Font("Segoe UI", 25F)
        btn1.Location = New Point(56, 222)
        btn1.Name = "btn1"
        btn1.Size = New Size(375, 157)
        btn1.TabIndex = 0
        btn1.Text = "Да"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.FlatStyle = FlatStyle.System
        btn2.Font = New Font("Segoe UI", 5F)
        btn2.Location = New Point(657, 333)
        btn2.Name = "btn2"
        btn2.Size = New Size(58, 35)
        btn2.TabIndex = 1
        btn2.Text = "нет"
        btn2.UseVisualStyleBackColor = True
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.Font = New Font("Segoe UI", 20F)
        lbl1.Location = New Point(122, 77)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(562, 62)
        lbl1.TabIndex = 3
        lbl1.Text = "Поддерживаете Путина?"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lbl1)
        Controls.Add(btn2)
        Controls.Add(btn1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents lbl1 As Label

End Class
