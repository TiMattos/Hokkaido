Public Class ServicoINFO

    Private Property _servicoRealiado As String
    Private Property _idServicos As Integer
    Private Property _idCliente As Integer
    Private Property _quilometragem As Integer
    Private Property _nome As String
    Private Property _veiculos As String
    Private Property _DataRevisao As Date
    Private Property _maodeObra As String
    Private Property _observacao As String
    Private Property _kmAtual As String
    Private Property _caminhoArquivo As String
    Private Property _placa As String

    Public Property Placa As String
        Get
            Return _placa

        End Get
        Set(value As String)
            _placa = value
        End Set
    End Property

    Public Property Observacao As String
        Get
            Return _observacao
        End Get
        Set(value As String)
            _observacao = value
        End Set
    End Property

    Public Property MaodeObra As String
        Get
            Return _maodeObra
        End Get
        Set(value As String)
            _maodeObra = value
        End Set
    End Property

    Public Property DataServico As Date
        Get
            Return _DataRevisao

        End Get
        Set(value As Date)
            _DataRevisao = value
        End Set
    End Property


    Public Property ServicoRealizado As String
        Get
            Return _servicoRealiado
        End Get
        Set(value As String)
            _servicoRealiado = value
        End Set
    End Property

    Public Property IdServico As Integer
        Get
            Return _idServicos

        End Get
        Set(value As Integer)
            _idServicos = value
        End Set
    End Property

    Public Property IdCliente As Integer
        Get
            Return _idCliente

        End Get
        Set(value As Integer)
            _idCliente = value
        End Set
    End Property

    Public Property Quilometragem As Integer
        Get
            Return _quilometragem

        End Get
        Set(value As Integer)
            _quilometragem = value
        End Set
    End Property

    Public Property Veiculo As String
        Get
            Return _veiculos
        End Get
        Set(value As String)
            _veiculos = value
        End Set
    End Property

    Public Property Nome As String
        Get
            Return _nome
        End Get
        Set(value As String)
            _nome = value
        End Set
    End Property

    Public Property KmAtual As String
        Get
            Return _kmAtual
        End Get
        Set(value As String)
            _kmAtual = value
        End Set
    End Property

    Public Property CaminhoArquivo As String
        Get
            Return _caminhoArquivo
        End Get
        Set(value As String)
            _caminhoArquivo = value
        End Set
    End Property
End Class
