Public Class Form1
    Private Sub 開くToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 開くToolStripMenuItem.Click
        Dim yomikomi_file As String
        Dim yomikomi As IO.StreamReader
        Dim yomikomi_gyou As String
        Dim kakikomi As IO.StreamWriter
        Dim x_y(1), kakikomi_gyou As String

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            yomikomi_file = OpenFileDialog1.FileName
            kakikomi = New IO.StreamWriter("コピー.txt")
            yomikomi = New IO.StreamReader(yomikomi_file)
            yomikomi_gyou = yomikomi.ReadLine

            Do While IsNothing(yomikomi_gyou) = False
                x_y = yomikomi_gyou.Split
                kakikomi_gyou = x_y(0) & " " & x_y(1)
                kakikomi.WriteLine(kakikomi_gyou)
                yomikomi_gyou = yomikomi.ReadLine
            Loop

            yomikomi.Close()
            kakikomi.Close()
        End If
    End Sub
End Class