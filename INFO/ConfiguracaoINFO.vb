Public Class ConfiguracaoINFO
    Private Property _SenhaEmail As String

    Public Property SenhaEmail As String
        Get
            Return _SenhaEmail
        End Get
        Set(value As String)
            _SenhaEmail = value
        End Set
    End Property

End Class
