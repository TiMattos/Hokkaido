Imports DAL
Imports INFO

Public Class BLLServicos

    Public Function busInserirServico(ByVal pObjServico As ServicoINFO) As Boolean
        Dim objDAL As DALServicos
        Try
            objDAL = New DALServicos

            Return objDAL.dbIncluirServicos(pObjServico)
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function busExcluirServico(ByVal pObjServico As ServicoINFO) As Boolean
        Dim objDAL As DALServicos
        Try
            objDAL = New DALServicos

            Return objDAL.dbExcluirServico(pObjServico)
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function busObterServicos(ByVal pIdCliente As Integer) As List(Of ServicoINFO)
        Dim DAL As DALServicos

        Try
            DAL = New DALServicos

            Return DAL.dbObterServico(pIdCliente)
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function busObterServicoPorID(ByVal pIdCliente As Integer) As ServicoINFO
        Dim DAL As DALServicos

        Try
            DAL = New DALServicos

            Return DAL.dbObterServicoPorID(pIdCliente)
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function busObterServicosPorData(ByVal pDataInicio As String, ByVal pDataFinal As String) As List(Of ServicoINFO)
        Dim DAL As DALServicos

        Try
            DAL = New DALServicos

            Return DAL.dbObterServicoPorData(pDataInicio, pDataFinal)
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function busObterServicosComparativo(ByVal pDataInicio As String, ByVal pDataFinal As String) As List(Of ServicoINFO)
        Dim DAL As DALServicos

        Try
            DAL = New DALServicos

            Return DAL.dbObterServicosComparativo(pDataInicio, pDataFinal)
        Catch ex As Exception
            Throw ex
        End Try

    End Function
End Class
