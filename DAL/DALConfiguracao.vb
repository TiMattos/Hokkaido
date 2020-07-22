Imports INFO
Imports FirebirdSql
Imports FirebirdSql.Data
Imports FirebirdSql.Data.FirebirdClient

Public Class DALConfiguracao
    Inherits DalGenerica


    Public Function dbObterConfiguracoes() As ConfiguracaoINFO
        Dim strSQL As String
        Dim objConfiguracao As ConfiguracaoINFO
        Dim objReader As FbDataReader
        Dim conn As FbCommand

        Try


            AbrirConexao()

            strSQL = "SELECT COF_STR_DS_SENHAEMAIL FROM TBL_CONFIGURACOES"

            conn = New FbCommand()

            conn.CommandText = strSQL
            conn.Connection = conexao

            objReader = conn.ExecuteReader

            objConfiguracao = New ConfiguracaoINFO

            If objReader.Read Then

                With objConfiguracao
                    If Not IsDBNull(objReader("COF_STR_DS_SENHAEMAIL")) Then
                        .SenhaEmail = CStr(objReader("COF_STR_DS_SENHAEMAIL"))
                    End If
                End With



            End If


            Return objConfiguracao


        Catch ex As Exception
            Throw ex
        Finally
            objConfiguracao = Nothing
            FecharConexao()
            objReader = Nothing
        End Try

    End Function

    Public Function dbAlterarSenhaEmail(ByVal strSenhaEmail As String) As Boolean

        Dim strSQL As String
        Dim objReader As IDataReader
        Dim conn As FbCommand

        Try

            AbrirConexao()

            strSQL = "UPDATE TBL_CONFIGURACOES SET COF_STR_DS_SENHAEMAIL =  '" & strSenhaEmail & "'"

            conn = New FbCommand()
            conn.CommandText = strSQL
            conn.Connection = conexao

            If conn.ExecuteNonQuery() > 0 Then
                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            Throw ex
        Finally
            FecharConexao()
            objReader = Nothing
        End Try

    End Function

End Class
