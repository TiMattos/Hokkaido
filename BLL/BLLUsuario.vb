Imports DAL
Imports INFO
Public Class BLLUsuario


    Public Function busObterUsuario(ByVal pStrUsuario As String) As UsuarioINFO
        Dim objDal As DALUsuario
        Try
            objDal = New DALUsuario

            Return objDal.dbObterUsuario(pStrUsuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
