Public Class Form1
    Private en(1000) As Zahyou
    Private en_suu As Integer = 0

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Debug.Print("1")
        If e.Button = MouseButtons.Left Then
            en(en_suu) = New Zahyou(e.X, e.Y)
            Me.CreateGraphics().FillEllipse(Brushes.Blue, en(en_suu).px, en(en_suu).py, 10, 10)
            en_suu = en_suu + 1
        End If
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Debug.Print("2")
        Dim i As Integer
        For i = 0 To en_suu - 1
            e.Graphics.FillEllipse(Brushes.Blue, en(i).px, en(i).py, 10, 10)
        Next
    End Sub

    Private Sub 保存ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 保存ToolStripMenuItem.Click
        Debug.Print("3")
        Dim hozon_file As String
        Dim i As Integer
        Dim kakikomi As IO.StreamWriter
        Dim kakikomi_gyou As String

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            hozon_file = SaveFileDialog1.FileName
            kakikomi = New IO.StreamWriter(hozon_file)

            For i = 0 To en_suu - 1
                kakikomi_gyou = en(i).px & " " & en(i).py
                kakikomi.WriteLine(kakikomi_gyou)
                Debug.Print(kakikomi_gyou)
            Next i

            kakikomi.Close()
        End If
    End Sub

    Private Sub 開くToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 開くToolStripMenuItem.Click
        Debug.Print("4")
        Dim yomikomi_file As String
        Dim yomikomi As IO.StreamReader
        Dim yomikomi_gyou As String
        Dim x_y(1) As String

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            yomikomi_file = OpenFileDialog1.FileName
            yomikomi = New IO.StreamReader(yomikomi_file)
            en_suu = 0
            yomikomi_gyou = yomikomi.ReadLine

            Do While IsNothing(yomikomi_gyou) = False
                x_y = yomikomi_gyou.Split()
                en(en_suu) = New Zahyou(CInt(x_y(0)), CInt(x_y(1)))
                en_suu = en_suu + 1
                yomikomi_gyou = yomikomi.ReadLine
            Loop

            yomikomi.Close()
            Me.Refresh()
        End If
    End Sub
End Class
