Public Class Form1
    Private Sub Button_calc_Click(sender As Object, e As EventArgs) Handles Button_calc.Click
        Dim numAdult, numChild, feeAdult, feeChild, sum As Integer
        'Dim rsltAdult, rsltChild As Integer

        feeAdult = 15000
        feeChild = 7500

        If (TextBox_adult.Text = "") Then
            numAdult = 0
            TextBox_adult.Text = numAdult
        Else
            numAdult = CInt(TextBox_adult.Text)
        End If

        If (TextBox_child.Text = "") Then
            numChild = 0
            TextBox_child.Text = numChild
        Else
            numChild = CInt(TextBox_child.Text)
        End If

        'rsltAdult = Function_calcAdult(numAdult)
        'rsltChild = Function_calcChild(numChild)

        'sum = rsltAdult + rsltChild

        sum = Function_calc(numAdult, numChild, feeAdult, feeChild)

        TextBox_show.Text = CStr(sum)
    End Sub
End Class
