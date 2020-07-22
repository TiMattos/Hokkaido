Public Class AgendamentoINFO
    Private Property _id As Integer
    Private Property _DataHora As Date
    Private Property _idCliente As Integer
    Private Property _Cliente As ClienteINFO
    Private Property _Endereco As String
    Private Property _Nome As String
    Private Property _Telefone As String
    Private Property _Hora As String

    Public Property Hora As String
        Get
            Return _Hora
        End Get
        Set(value As String)
            _Hora = value
        End Set
    End Property

    Public Property Endereco As String
        Get
            Return _Endereco
        End Get
        Set(value As String)
            _Endereco = value
        End Set
    End Property

    Public Property Nome As String
        Get
            Return _Nome
        End Get
        Set(value As String)
            _Nome = value
        End Set
    End Property
    Public Property Telefone As String
        Get
            Return _Telefone
        End Get
        Set(value As String)
            _Telefone = value
        End Set
    End Property

    Public Property Cliente As ClienteINFO
        Get
            Return _Cliente

        End Get
        Set(value As ClienteINFO)
            _Cliente = value
        End Set
    End Property
    Public Property ID As Integer
        Get
            Return _id

        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property DataHora As Date
        Get
            Return _DataHora

        End Get
        Set(value As Date)
            _DataHora = value
        End Set
    End Property

    Public Property IDCliente As Integer
        Get
            Return _idCliente

        End Get
        Set(value As Integer)
            _idCliente = value
        End Set
    End Property


End Class
