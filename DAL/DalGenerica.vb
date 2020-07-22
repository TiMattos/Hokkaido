Imports FirebirdSql
Imports FirebirdSql.Data
Imports FirebirdSql.Data.FirebirdClient
Imports System.IO
Public Class DalGenerica
    Public strConexao As New FbConnectionStringBuilder
    Public conexao As New FbConnection

    Public Sub PreparaConexaoFB()
        strConexao.ServerType = FbServerType.Default
        strConexao.DataSource = "localhost"
        strConexao.UserID = "SYSDBA"
        strConexao.Port = 3050
        strConexao.Password = "masterkey"
        strConexao.Dialect = 3
        'strConexao.Database = "C:\Banco de Dados\Firebird\DBSGC.FDB"
        strConexao.Database = Directory.GetCurrentDirectory & "\DBSGC.FDB"
        strConexao.Pooling = False
    End Sub
    Public Sub AbrirConexao()

        PreparaConexaoFB()
        conexao.ConnectionString = strConexao.ToString
        conexao.Open()
    End Sub

    Public Sub FecharConexao()
        conexao.Close()
    End Sub
End Class
