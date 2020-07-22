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
End Class
