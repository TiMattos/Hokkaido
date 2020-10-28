Imports DAL
Imports INFO


Public Class BLLVeiculo
    Public Function dbIncluirVeiculo(ByVal pObjCliente As clienteinfo) As Boolean
        Dim objDAL As DalVeiculo
        Try
            objDAL = New DalVeiculo
            Return objDAL.dbIncluirVeiculo(pObjCliente)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function busObterVeiculoPorID(ByVal pID As Integer) As VeiculoINFO

        Dim objDAL As New DalVeiculo
        Try
            Return objDAL.dbObterVeiculosPorID(pID)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
