Imports FirebirdSql
Imports FirebirdSql.Data
Imports FirebirdSql.Data.FirebirdClient
Imports INFO
Public Class DALUsuario
    Inherits DalGenerica
    Public Function dbObterUsuario(ByVal pStrUsuario As String) As UsuarioINFO

        Dim sql As String
        Dim conn As FbCommand
        Dim objReader As FbDataReader
        Dim objInfoUsuario As UsuarioINFO


        Try

            AbrirConexao()

            sql = "SELECT ASS_INT_ID_USUARIO, ASS_STR_DS_USUARIO, ASS_STR_DS_SENHA FROM tbl_usuarios " &
                  " WHERE ASS_STR_DS_USUARIO = '" & pStrUsuario.ToString.ToUpper & "' "

            conn = New FbCommand()

            conn.CommandText = sql
            conn.Connection = conexao

            objReader = conn.ExecuteReader
            objInfoUsuario = New UsuarioINFO
            If objReader.Read Then
                With objInfoUsuario
                    .ID = objReader("ASS_INT_ID_USUARIO")
                    If Not IsDBNull(objReader("ASS_STR_DS_USUARIO")) Then
                        .Login = objReader("ASS_STR_DS_USUARIO")
                    End If
                    If Not IsDBNull(objReader("ASS_STR_DS_SENHA")) Then
                        .Senha = objReader("ASS_STR_DS_SENHA")
                    End If

                End With
            Else
                objInfoUsuario = Nothing
            End If


            Return objInfoUsuario

        Catch ex As Exception
            Throw ex
        Finally
            FecharConexao()
            objReader = Nothing

        End Try

    End Function
End Class
