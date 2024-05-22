Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hensuu_Integer As Integer
        Dim hensuu_Double As Double
        Dim hensuu_String As String
        Dim hensuu_Date As Date

        hensuu_Integer = 3.14
        hensuu_Double = 100
        hensuu_String = 9999
        hensuu_Date = "1999 / 7 / 31"
        Debug.Print("hensuu_Integer=" & hensuu_Integer)
        Debug.Print("hensuu_Double=" & hensuu_Double)
        Debug.Print("hensuu_String=" & hensuu_String)
        Debug.Print("hensuu_Date=" & hensuu_Date)
    End Sub
End Class
