
Imports DAL
Imports INFO
Public Class BLLCLientes
    Public Function busObterCliente(ByVal pStrNome As String, Optional ByVal pFiltroSelecionado As String = Nothing) As List(Of ClienteINFO)
        Dim objDal As DalCliente

        Try

            objDal = New DalCliente

            Return objDal.dbObterCliente(pStrNome, pFiltroSelecionado)
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function busObterIDCliente(ByVal pStrNome As String, Optional ByVal pFiltroSelecionado As String = Nothing) As List(Of ClienteINFO)
        Dim objDal As DalCliente

        Try

            objDal = New DalCliente

            Return objDal.dbObterCliente(pStrNome, pFiltroSelecionado)
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function busObterClientePorID(ByVal pIntID As Integer) As ClienteINFO
        Dim objDal As DalCliente

        Try

            objDal = New DalCliente

            Return objDal.dbObterClientePorID(pIntID)
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function busInserirCadastro(ByVal pObjCliente As ClienteINFO) As Boolean
        Dim objDal As DalCliente
        Try
            objDal = New DalCliente

            Return objDal.dbIncluirCadastro(pObjCliente)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function busAlterarCadastro(ByVal pObCliente As ClienteINFO) As Boolean
        Dim objDal As DalCliente
        Try
            objDal = New DalCliente

            Return objDal.dbAlterarCadastro(pObCliente)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
