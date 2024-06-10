Module Module1
    Function Function_calcAdult(ByVal i As Integer, ByVal k As Integer)
        Return k * i
    End Function

    Function Function_calcChild(ByVal j As Integer, ByVal l As Integer)
        Return l * j
    End Function

    Function Function_calc(ByVal i As Integer, ByVal j As Integer, ByVal k As Integer, ByVal l As Integer)
        Return k * i + l * j
    End Function
End Module
