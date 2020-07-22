Imports INFO
Public Class ClienteINFO

    Private _id As Integer
    Private _nome1 As String
    Private _nome2 As String
    Private _endereco As String
    Private _complemento As String
    Private _bairro As String
    Private _telefone As String
    Private _email As String
    Private _veiculo As VeiculoINFO
    Private _lstVeiculos As List(Of VeiculoINFO)

    Public Property ID As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property


    Public Property Nome1 As String
        Get
            Return _nome1
        End Get
        Set(value As String)
            _nome1 = value
        End Set
    End Property

    Public Property Nome2 As String
        Get
            Return _nome2

        End Get
        Set(value As String)
            _nome2 = value
        End Set
    End Property
    Public Property Endereco As String
        Get
            Return _endereco

        End Get
        Set(value As String)
            _endereco = value
        End Set
    End Property

    Public Property Complemento As String
        Get
            Return _complemento

        End Get
        Set(value As String)
            _complemento = value
        End Set
    End Property

    Public Property Bairro As String
        Get
            Return _bairro

        End Get
        Set(value As String)
            _bairro = value
        End Set
    End Property
    Public Property Telefone As String
        Get
            Return _telefone
        End Get
        Set(value As String)
            _telefone = value
        End Set
    End Property
    Public Property Email As String
        Get
            Return _email

        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property Veiculo As VeiculoINFO
        Get
            Return _veiculo
        End Get
        Set(value As VeiculoINFO)
            _veiculo = value
        End Set
    End Property

    Public Property ListaVeiculos As List(Of VeiculoINFO)
        Get
            Return _lstVeiculos
        End Get
        Set(value As List(Of VeiculoINFO))
            _lstVeiculos = value
        End Set
    End Property

End Class
