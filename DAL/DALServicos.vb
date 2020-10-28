Imports FirebirdSql
Imports FirebirdSql.Data
Imports FirebirdSql.Data.FirebirdClient
Imports INFO

Public Class DALServicos
    Inherits DalGenerica
    Public Function dbObterServico(ByVal IdServico As Integer) As List(Of ServicoINFO)
        Dim strSQL As String
        Dim objReader As FbDataReader
        Dim conn As FbCommand
        Dim objInfo As ServicoINFO
        Dim lLstServico As List(Of ServicoINFO)

        Try

            AbrirConexao()

            'strSQL = "SELECT C.ass_int_id_cliente,  C.ass_str_ds_nome1 , C.ass_str_ds_endereco , S.ass_str_ds_servicorealizado, " &
            '        " S.ass_dat_dt_datarevisao , S.ass_int_nr_quilometragem , S.ass_str_nr_maodeobra , S.ass_str_ds_obs FROM tbl_servicos  S " &
            '        " INNER JOIN tbl_cliente C On C.ass_int_id_cliente = S.ass_int_id_cliente " &
            '        " where C.ass_str_ds_nome1 = '" & pStrNome & "'' " &
            '        " ORDER BY S.ASS_DAT_DT_DATAREVISAO"

            strSQL = "SELECT ASS_INT_ID_SERVICO, " &
                     "ASS_INT_ID_CLIENTE, " &
                    "ASS_STR_DS_SERVICOREALIZADO, " &
                    "ASS_INT_NR_QUILOMETRAGEM, " &
                    "ASS_DAT_DT_DATAREVISAO, " &
                    "ASS_STR_NR_MAODEOBRA, " &
                    "ASS_STR_NR_VALORPECAS, " &
                    "ASS_STR_DS_OBS,  " &
                    "ASS_INT_NR_KMATUAL,  " &
                    "ASS_STR_DS_PLACA  " &
                    "FROM tbl_servicos " &
                    "WHERE ASS_INT_ID_CLIENTE = " & IdServico &
                    " ORDER BY ASS_INT_NR_QUILOMETRAGEM, ASS_DAT_DT_DATAREVISAO DESC"



            conn = New FbCommand()

            conn.CommandText = strSQL
            conn.Connection = conexao

            objReader = conn.ExecuteReader

            'FecharConexao()

            lLstServico = New List(Of ServicoINFO)

            While objReader.Read
                objInfo = New ServicoINFO

                With objInfo
                    .IdServico = objReader("ASS_INT_ID_SERVICO")
                    .IdCliente = objReader("ASS_INT_ID_CLIENTE")
                    .ServicoRealizado = objReader("ASS_STR_DS_SERVICOREALIZADO")
                    .Quilometragem = objReader("ASS_INT_NR_QUILOMETRAGEM")
                    If Not IsDBNull(objReader("ASS_DAT_DT_DATAREVISAO")) Then
                        .DataServico = objReader("ASS_DAT_DT_DATAREVISAO")
                    Else
                        .DataServico = Nothing

                    End If
                    If Not IsDBNull(objReader("ASS_STR_NR_MAODEOBRA")) Then
                        .MaodeObra = objReader("ASS_STR_NR_MAODEOBRA")
                    Else
                        .MaodeObra = String.Empty
                    End If
                    If Not IsDBNull(objReader("ASS_STR_DS_OBS")) Then
                        .Observacao = objReader("ASS_STR_DS_OBS")
                    Else
                        .Observacao = String.Empty
                    End If
                    If Not IsDBNull(objReader("ASS_INT_NR_KMATUAL")) Then
                        .KmAtual = CInt(objReader("ASS_INT_NR_KMATUAL"))
                    End If

                    If Not IsDBNull(objReader("ASS_STR_DS_PLACA")) Then
                        .Placa = objReader("ASS_STR_DS_PLACA")
                    End If

                    If Not IsDBNull(objReader("ASS_STR_NR_VALORPECAS")) Then
                        .ValorPecas = objReader("ASS_STR_NR_VALORPECAS")
                    Else
                        .ValorPecas = String.Empty
                    End If

                End With
                lLstServico.Add(objInfo)
            End While
            Return lLstServico
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function dbIncluirServicos(ByVal pObjServicos As ServicoINFO) As Boolean

        Dim strSql As String
        Dim objReader As FbDataReader
        Dim conn As FbCommand

        Try
            PreparaConexaoFB()
            AbrirConexao()

            strSql = "select gen_id(GEN_TBL_SERVICO_ID,1) from rdb$database"

            conn = New FbCommand()

            conn.CommandText = strSql
            conn.Connection = conexao

            objReader = conn.ExecuteReader

            If objReader.Read Then

                pObjServicos.IdServico = CInt(objReader("GEN_ID"))

            End If

            strSql = "insert into TBL_SERVICOS (ASS_INT_ID_SERVICO, ASS_INT_ID_CLIENTE, ASS_STR_DS_SERVICOREALIZADO, " &
                       "ASS_DAT_DT_DATAREVISAO, ASS_INT_NR_QUILOMETRAGEM, ASS_STR_NR_MAODEOBRA, ASS_STR_DS_OBS, ASS_INT_NR_KMATUAL, ASS_STR_DS_CAMINHOARQUIVO, ASS_STR_DS_PLACA ) " &
            "VALUES (" &
             "" & pObjServicos.IdServico & ", " &
             "" & pObjServicos.IdCliente & ", " &
              "'" & pObjServicos.ServicoRealizado.Trim & "', " &
                "  current_date , " &
             "'" & pObjServicos.Quilometragem.ToString & "', " &
             "'" & pObjServicos.MaodeObra & "', " &
            "'" & pObjServicos.Observacao & "', " &
            "'" & pObjServicos.KmAtual & "', " &
            "'" & pObjServicos.CaminhoArquivo & "'," &
            "'" & pObjServicos.Placa & "')"

            conn.CommandText = strSql
            conn.ExecuteNonQuery()
            FecharConexao()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function dbObterServicoPorID(ByVal IdServico As Integer) As ServicoINFO
        Dim strSQL As String
        Dim objReader As FbDataReader
        Dim conn As FbCommand
        Dim objServico As ServicoINFO

        Try

            AbrirConexao()

            strSQL = "SELECT ASS_INT_ID_SERVICO, " &
                     "ASS_INT_ID_CLIENTE, " &
                    "ASS_STR_DS_SERVICOREALIZADO, " &
                    "ASS_INT_NR_QUILOMETRAGEM, " &
                    "ASS_DAT_DT_DATAREVISAO, " &
                    "ASS_STR_NR_MAODEOBRA, " &
                    "ASS_STR_DS_OBS, " &
                    "ASS_INT_NR_KMATUAL, " &
                    "ASS_STR_DS_CAMINHOARQUIVO, " &
                    "ASS_STR_DS_PLACA, " &
                    "ASS_STR_NR_VALORPECAS, " &
                    "ASS_INT_ID_VEICULO " &
                    "FROM tbl_servicos " &
                    "WHERE ASS_INT_ID_SERVICO = " & IdServico &
                    " ORDER BY ASS_INT_NR_QUILOMETRAGEM, ASS_DAT_DT_DATAREVISAO DESC"



            conn = New FbCommand()

            conn.CommandText = strSQL
            conn.Connection = conexao

            objReader = conn.ExecuteReader

            'FecharConexao()

            objServico = New ServicoINFO

            If objReader.Read Then

                With objServico
                    .IdServico = objReader("ASS_INT_ID_SERVICO")
                    .IdCliente = objReader("ASS_INT_ID_CLIENTE")
                    .ServicoRealizado = objReader("ASS_STR_DS_SERVICOREALIZADO")
                    .Quilometragem = objReader("ASS_INT_NR_QUILOMETRAGEM")
                    If Not IsDBNull(objReader("ASS_DAT_DT_DATAREVISAO")) Then
                        .DataServico = objReader("ASS_DAT_DT_DATAREVISAO")
                    Else
                        .DataServico = Nothing

                    End If
                    If Not IsDBNull(objReader("ASS_STR_NR_MAODEOBRA")) Then
                        .MaodeObra = objReader("ASS_STR_NR_MAODEOBRA")
                    Else
                        .MaodeObra = String.Empty
                    End If
                    If Not IsDBNull(objReader("ASS_STR_DS_OBS")) Then
                        .Observacao = objReader("ASS_STR_DS_OBS")
                    Else
                        .Observacao = String.Empty
                    End If
                    If Not IsDBNull(objReader("ASS_INT_NR_KMATUAL")) Then
                        .KmAtual = objReader("ASS_INT_NR_KMATUAL")
                    Else
                        .KmAtual = String.Empty
                    End If

                    If Not IsDBNull(objReader("ASS_STR_DS_CAMINHOARQUIVO")) Then
                        .CaminhoArquivo = objReader("ASS_STR_DS_CAMINHOARQUIVO")
                    Else
                        .CaminhoArquivo = String.Empty
                    End If

                    If Not IsDBNull(objReader("ASS_STR_DS_PLACA")) Then
                        .Placa = objReader("ASS_STR_DS_PLACA")
                    Else
                        .Placa = String.Empty
                    End If

                    If Not IsDBNull(objReader("ASS_STR_NR_VALORPECAS")) Then
                        .ValorPecas = objReader("ASS_STR_NR_VALORPECAS")
                    Else
                        .ValorPecas = String.Empty
                    End If

                    If Not IsDBNull(objReader("ASS_INT_ID_VEICULO")) Then
                        .IdVeiculo = objReader("ASS_INT_ID_VEICULO")
                    Else
                        .IdVeiculo = 0
                    End If

                End With

            End If
            Return objServico
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function dbObterServicoPorData(ByVal pDataInicio As String, ByVal pDataFim As String) As List(Of ServicoINFO)
        Dim strSQL As String
        Dim objReader As FbDataReader
        Dim conn As FbCommand
        Dim objInfo As ServicoINFO
        Dim lLstServico As List(Of ServicoINFO)

        Try

            AbrirConexao()

            'strSQL = "SELECT C.ass_int_id_cliente,  C.ass_str_ds_nome1 , C.ass_str_ds_endereco , S.ass_str_ds_servicorealizado, " &
            '        " S.ass_dat_dt_datarevisao , S.ass_int_nr_quilometragem , S.ass_str_nr_maodeobra , S.ass_str_ds_obs FROM tbl_servicos  S " &
            '        " INNER JOIN tbl_cliente C On C.ass_int_id_cliente = S.ass_int_id_cliente " &
            '        " where C.ass_str_ds_nome1 = '" & pStrNome & "'' " &
            '        " ORDER BY S.ASS_DAT_DT_DATAREVISAO"

            strSQL = "SELECT ASS_INT_ID_SERVICO, " &
                     "ASS_INT_ID_CLIENTE, " &
                    "ASS_STR_DS_SERVICOREALIZADO, " &
                    "ASS_INT_NR_QUILOMETRAGEM, " &
                    "ASS_DAT_DT_DATAREVISAO, " &
                    "ASS_STR_NR_MAODEOBRA, " &
                    "ASS_STR_NR_VALORPECAS, " &
                    "ASS_STR_DS_OBS,  " &
                    "ASS_INT_NR_KMATUAL,  " &
                    "ASS_STR_DS_PLACA  " &
                    "FROM tbl_servicos " &
                    "WHERE ASS_DAT_DT_DATAREVISAO between '" & pDataInicio & "' and '" & pDataFim & "'" &
                    " ORDER BY ASS_DAT_DT_DATAREVISAO DESC"



            conn = New FbCommand()

            conn.CommandText = strSQL
            conn.Connection = conexao

            objReader = conn.ExecuteReader

            'FecharConexao()

            lLstServico = New List(Of ServicoINFO)

            While objReader.Read
                objInfo = New ServicoINFO

                With objInfo
                    .IdServico = objReader("ASS_INT_ID_SERVICO")
                    .IdCliente = objReader("ASS_INT_ID_CLIENTE")
                    .ServicoRealizado = objReader("ASS_STR_DS_SERVICOREALIZADO")
                    .Quilometragem = objReader("ASS_INT_NR_QUILOMETRAGEM")
                    If Not IsDBNull(objReader("ASS_DAT_DT_DATAREVISAO")) Then
                        .DataServico = objReader("ASS_DAT_DT_DATAREVISAO")
                    Else
                        .DataServico = Nothing

                    End If
                    If Not IsDBNull(objReader("ASS_STR_NR_MAODEOBRA")) Then
                        .MaodeObra = objReader("ASS_STR_NR_MAODEOBRA")
                    Else
                        .MaodeObra = String.Empty
                    End If
                    If Not IsDBNull(objReader("ASS_STR_DS_OBS")) Then
                        .Observacao = objReader("ASS_STR_DS_OBS")
                    Else
                        .Observacao = String.Empty
                    End If
                    If Not IsDBNull(objReader("ASS_INT_NR_KMATUAL")) Then
                        .KmAtual = CInt(objReader("ASS_INT_NR_KMATUAL"))
                    End If

                    If Not IsDBNull(objReader("ASS_STR_DS_PLACA")) Then
                        .Placa = objReader("ASS_STR_DS_PLACA")
                    End If

                    If Not IsDBNull(objReader("ASS_STR_NR_VALORPECAS")) Then
                        .ValorPecas = objReader("ASS_STR_NR_VALORPECAS")
                    Else
                        .ValorPecas = String.Empty
                    End If
                    Dim objDalCliente As New DalCliente
                    .Nome = objDalCliente.dbObterClientePorID(.IdCliente).Nome1

                End With
                lLstServico.Add(objInfo)
            End While
            Return lLstServico
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function dbObterServicosComparativo(ByVal pDataInicio As String, ByVal pDataFim As String) As List(Of ServicoINFO)
        Dim strSQL As String
        Dim objReader As FbDataReader
        Dim conn As FbCommand
        Dim objInfo As ServicoINFO
        Dim lLstServico As List(Of ServicoINFO)

        Try

            AbrirConexao()

            'strSQL = "SELECT C.ass_int_id_cliente,  C.ass_str_ds_nome1 , C.ass_str_ds_endereco , S.ass_str_ds_servicorealizado, " &
            '        " S.ass_dat_dt_datarevisao , S.ass_int_nr_quilometragem , S.ass_str_nr_maodeobra , S.ass_str_ds_obs FROM tbl_servicos  S " &
            '        " INNER JOIN tbl_cliente C On C.ass_int_id_cliente = S.ass_int_id_cliente " &
            '        " where C.ass_str_ds_nome1 = '" & pStrNome & "'' " &
            '        " ORDER BY S.ASS_DAT_DT_DATAREVISAO"

            strSQL = "SELECT ASS_STR_NR_MAODEOBRA, " &
                    "ASS_STR_NR_VALORPECAS " &
                    "FROM tbl_servicos " &
                    "WHERE ASS_DAT_DT_DATAREVISAO between '" & pDataInicio & "' and '" & pDataFim & "'"




            conn = New FbCommand()

            conn.CommandText = strSQL
            conn.Connection = conexao

            objReader = conn.ExecuteReader



            lLstServico = New List(Of ServicoINFO)

            While objReader.Read
                objInfo = New ServicoINFO

                With objInfo
                    .IdServico = objReader("ASS_INT_ID_SERVICO")
                    .IdCliente = objReader("ASS_INT_ID_CLIENTE")
                    .ServicoRealizado = objReader("ASS_STR_DS_SERVICOREALIZADO")
                    .Quilometragem = objReader("ASS_INT_NR_QUILOMETRAGEM")
                    If Not IsDBNull(objReader("ASS_DAT_DT_DATAREVISAO")) Then
                        .DataServico = objReader("ASS_DAT_DT_DATAREVISAO")
                    Else
                        .DataServico = Nothing

                    End If
                    If Not IsDBNull(objReader("ASS_STR_NR_MAODEOBRA")) Then
                        .MaodeObra = objReader("ASS_STR_NR_MAODEOBRA")
                    Else
                        .MaodeObra = String.Empty
                    End If
                    If Not IsDBNull(objReader("ASS_STR_DS_OBS")) Then
                        .Observacao = objReader("ASS_STR_DS_OBS")
                    Else
                        .Observacao = String.Empty
                    End If
                    If Not IsDBNull(objReader("ASS_INT_NR_KMATUAL")) Then
                        .KmAtual = CInt(objReader("ASS_INT_NR_KMATUAL"))
                    End If

                    If Not IsDBNull(objReader("ASS_STR_DS_PLACA")) Then
                        .Placa = objReader("ASS_STR_DS_PLACA")
                    End If

                    If Not IsDBNull(objReader("ASS_STR_NR_VALORPECAS")) Then
                        .ValorPecas = objReader("ASS_STR_NR_VALORPECAS")
                    Else
                        .ValorPecas = String.Empty
                    End If
                    Dim objDalCliente As New DalCliente
                    .Nome = objDalCliente.dbObterClientePorID(.IdCliente).Nome1

                End With
                lLstServico.Add(objInfo)
            End While
            Return lLstServico
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
