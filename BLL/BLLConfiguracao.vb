Imports DAL
Imports INFO
Public Class BLLConfiguracao
    Public Function busObterConfiguracoes() As ConfiguracaoINFO
        Dim DAL As DALConfiguracao
        Try
            DAL = New DALConfiguracao
            Return DAL.dbObterConfiguracoes()
        Catch ex As Exception
            Throw ex
        Finally
            DAL = Nothing
        End Try
    End Function

    Public Function busAlterarSenhaEmail(ByVal strSenhaEmail As String) As Boolean
        Dim DAL As DALConfiguracao
        Try
            DAL = New DALConfiguracao

            Return DAL.dbAlterarSenhaEmail(strSenhaEmail)
        Catch ex As Exception
            Throw ex
        Finally
            DAL = Nothing '
        End Try
    End Function


End Class
