Public Class VeiculoINFO
    Private _id As Integer
    Private _modelo As String
    Private _marca As String
    Private _ano As Integer
    Private _placa As String
    Private _foto As Byte()
    Private _idCliente As Integer

    Public Property Foto As Byte()
        Get
            Return _foto

        End Get
        Set(value As Byte())
            _foto = value
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

    Public Property Modelo As String
        Get
            Return _modelo
        End Get
        Set(value As String)
            _modelo = value
        End Set
    End Property


    Public Property Marca As String
        Get
            Return _marca
        End Get
        Set(value As String)
            _marca = value
        End Set
    End Property

    Public Property Ano As Integer
        Get
            Return _ano
        End Get
        Set(value As Integer)
            _ano = value
        End Set
    End Property

    Public Property Placa As String
        Get
            Return _placa
        End Get
        Set(value As String)
            _placa = value
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
