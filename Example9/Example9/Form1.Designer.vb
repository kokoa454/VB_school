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
        MenuStrip1 = New MenuStrip()
        ファイルToolStripMenuItem = New ToolStripMenuItem()
        開くToolStripMenuItem = New ToolStripMenuItem()
        保存ToolStripMenuItem = New ToolStripMenuItem()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(28, 28)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ファイルToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(844, 38)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ファイルToolStripMenuItem
        ' 
        ファイルToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {開くToolStripMenuItem, 保存ToolStripMenuItem})
        ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem"
        ファイルToolStripMenuItem.Size = New Size(93, 34)
        ファイルToolStripMenuItem.Text = "ファイル"
        ' 
        ' 開くToolStripMenuItem
        ' 
        開くToolStripMenuItem.Name = "開くToolStripMenuItem"
        開くToolStripMenuItem.Size = New Size(315, 40)
        開くToolStripMenuItem.Text = "開く"
        ' 
        ' 保存ToolStripMenuItem
        ' 
        保存ToolStripMenuItem.Name = "保存ToolStripMenuItem"
        保存ToolStripMenuItem.Size = New Size(315, 40)
        保存ToolStripMenuItem.Text = "保存"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(844, 648)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ファイルToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 開くToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 保存ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog

End Class
