Public Class Coodinates
    Private x As Integer
    Private y As Integer

    Public Property px() As Integer
        Get
            Return x
        End Get
        Set(value As Integer)
            x = value
        End Set
    End Property

    Public Property py() As Integer
        Get
            Return y
        End Get
        Set(value As Integer)
            y = value
        End Set
    End Property

    Public Sub New(ByVal x As Integer, ByVal y As Integer)
        Me.x = x
        Me.y = y
    End Sub
End Class
