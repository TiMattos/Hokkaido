Imports FirebirdSql
Imports FirebirdSql.Data
Imports FirebirdSql.Data.FirebirdClient
Imports INFO
Imports DAL
Public Class DalVeiculo
    Inherits DalGenerica
    Public Function dbListarVeiculos(ByVal pObjCliente As ClienteINFO) As List(Of VeiculoINFO)
        Dim strSQL As String
        Dim conn As FbCommand
        Dim lstVeiculos As List(Of VeiculoINFO)
        Dim objVeiculos As VeiculoINFO
        Dim objReader As FbDataReader

        Try
            AbrirConexao()

            strSQL = "SELECT ASS_INT_ID_VEICULO, ASS_STR_DS_MARCA, ASS_STR_DS_PLACA, ASS_INT_NR_ANO, ASS_STR_DS_MODELO FROM TBL_VEICULO WHERE ASS_INT_ID_CLIENTE = " & pObjCliente.ID

            conn = New FbCommand()

            conn.CommandText = strSQL
            conn.Connection = conexao

            objReader = conn.ExecuteReader

            lstVeiculos = New List(Of VeiculoINFO)
            While objReader.Read
                objVeiculos = New VeiculoINFO
                With objVeiculos
                    .Ano = CInt(objReader("ASS_INT_NR_ANO"))
                    .ID = CInt(objReader("ASS_INT_ID_VEICULO"))
                    .Marca = CStr(objReader("ASS_STR_DS_MARCA"))
                    .Placa = CStr(objReader("ASS_STR_DS_PLACA"))
                    .Modelo = CStr(objReader("ASS_STR_DS_MODELO"))

                End With
                lstVeiculos.Add(objVeiculos)
            End While

            Return lstVeiculos

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function dbObterVeiculosPorID(ByVal pIntID As Integer) As VeiculoINFO
        Dim strSQL As String
        Dim conn As FbCommand
        Dim objVeiculo As VeiculoINFO
        Dim objReader As FbDataReader

        Try
            AbrirConexao()

            strSQL = "SELECT ASS_INT_ID_CLIENTE, ASS_INT_ID_VEICULO, ASS_STR_DS_MARCA, ASS_STR_DS_PLACA, ASS_INT_NR_ANO, ASS_STR_DS_MODELO FROM TBL_VEICULO WHERE ASS_INT_ID_VEICULO = " & pIntID

            conn = New FbCommand()

            conn.CommandText = strSQL
            conn.Connection = conexao

            objReader = conn.ExecuteReader

            objVeiculo = New VeiculoINFO

            If objReader.Read Then

                With objVeiculo
                    .Ano = CInt(objReader("ASS_INT_NR_ANO"))
                    .ID = CInt(objReader("ASS_INT_ID_VEICULO"))
                    .Marca = CStr(objReader("ASS_STR_DS_MARCA"))
                    .Placa = CStr(objReader("ASS_STR_DS_PLACA"))
                    .Modelo = CStr(objReader("ASS_STR_DS_MODELO"))
                    .IDCliente = CInt(objReader("ASS_INT_ID_CLIENTE"))
                End With
            End If

            Return objVeiculo

        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Public Function dbIncluirVeiculo(ByVal pObjCliente As ClienteINFO) As Boolean
        Dim strSQL As String
        Dim conn As FbCommand
        Dim objReader As FbDataReader

        Try

            AbrirConexao()

            strSQL = "select gen_id(GEN_TBL_VEICULO_ID,1) from rdb$database"

            conn = New FbCommand()

            conn.CommandText = strSQL
            conn.Connection = conexao

            objReader = conn.ExecuteReader

            If objReader.Read Then
                pObjCliente.Veiculo.ID = CInt(objReader("GEN_ID"))
            End If

            strSQL = "INSERT into TBL_VEICULO (ASS_INT_ID_VEICULO, ASS_INT_ID_CLIENTE, ASS_STR_DS_MARCA, ASS_STR_DS_PLACA, ASS_INT_NR_ANO, ASS_STR_DS_MODELO)" &
                     " VALUES (" &
                     "" & pObjCliente.Veiculo.ID & "," &
                     "" & pObjCliente.ID & "," &
            "'" & pObjCliente.Veiculo.Marca & "', " &
             "'" & pObjCliente.Veiculo.Placa & "', " &
            "" & pObjCliente.Veiculo.Ano & ", " &
            "'" & pObjCliente.Veiculo.Modelo & "') "

            conn.CommandText = strSQL
            conn.ExecuteNonQuery()
            FecharConexao()

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

End Class
