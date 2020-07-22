Imports FirebirdSql
Imports FirebirdSql.Data
Imports FirebirdSql.Data.FirebirdClient
Imports INFO
Public Class DalCliente
    Inherits DalGenerica

    Public Function dbObterCliente(ByVal pStrFiltro As String, Optional ByVal pFiltroSelecionado As String = Nothing) As List(Of ClienteINFO)
        Dim sql As String
        Dim conn As FbCommand
        Dim objReader As FbDataReader
        Dim objInfoCliente As ClienteINFO
        Dim objLstCliente As List(Of ClienteINFO)
        Dim objDalVeiculo As DalVeiculo


        Try

            AbrirConexao()
            'sql = "SELECT ASS_INT_ID_CLIENTE, ASS_STR_DS_NOME1, ASS_STR_DS_NOME2, ASS_INT_NR_TELEFONE, " &
            '    " ASS_STR_DS_ENDERECO, ASS_STR_DS_COMPLEMENTO, ASS_STR_DS_BAIRRO FROM TBL_CLIENTE WHERE ASS_STR_DS_NOME1 = '" & pStrCliente.ToString & "'"
            sql = "SELECT C.ASS_INT_ID_CLIENTE, ASS_STR_DS_NOME1, ASS_STR_DS_NOME2, ASS_INT_NR_TELEFONE, ASS_STR_DS_ENDERECO, " &
            "ASS_STR_DS_COMPLEMENTO, ASS_STR_DS_BAIRRO, ASS_STR_DS_EMAIL FROM TBL_CLIENTE C "
            ', V.ASS_STR_DS_MODELO, V.ASS_STR_DS_MARCA, V.ASS_INT_NR_ANO, V.ASS_STR_DS_PLACA FROM TBL_CLIENTE C   " &
            If pFiltroSelecionado = "Placa" Then
                sql += "INNER join tbl_veiculo V ON C.ass_int_id_cliente = V.ass_int_id_cliente  "
            End If

            If pFiltroSelecionado = "Nome" Then
                sql += "where C.ass_str_ds_nome1 CONTAINING '" & pStrFiltro.ToString & "' "
            End If

            If pFiltroSelecionado = "Placa" Then
                sql += "where V.ASS_STR_DS_PLACA CONTAINING '" & pStrFiltro.ToString & "' "
            End If

            If pFiltroSelecionado = "Endereço" Then
                sql += "where C.ASS_STR_DS_ENDERECO CONTAINING '" & pStrFiltro.ToString & "' "
            End If

            sql += " ORDER BY C.ASS_STR_DS_NOME1 ASC"

            conn = New FbCommand()

            conn.CommandText = sql
            conn.Connection = conexao

            objReader = conn.ExecuteReader

            objLstCliente = New List(Of ClienteINFO)

            While objReader.Read
                objInfoCliente = New ClienteINFO
                With objInfoCliente
                    .ID = objReader("ASS_INT_ID_CLIENTE")
                    If Not IsDBNull(objReader("ASS_STR_DS_NOME1")) Then
                        .Nome1 = objReader("ASS_STR_DS_NOME1")
                    End If
                    If Not IsDBNull(objReader("ASS_STR_DS_NOME2")) Then
                        .Nome2 = objReader("ASS_STR_DS_NOME2")
                    End If

                    .Telefone = objReader("ASS_INT_NR_TELEFONE")
                    .Endereco = objReader("ASS_STR_DS_ENDERECO")
                    If Not IsDBNull(objReader("ASS_STR_DS_COMPLEMENTO")) Then
                        .Complemento = objReader("ASS_STR_DS_COMPLEMENTO")
                    End If

                    If Not IsDBNull(objReader("ASS_STR_DS_EMAIL")) Then
                        .Email = objReader("ASS_STR_DS_EMAIL")
                    End If


                    objDalVeiculo = New DalVeiculo
                    .ListaVeiculos = New List(Of VeiculoINFO)

                    .ListaVeiculos = objDalVeiculo.dbListarVeiculos(objInfoCliente)

                    '.Veiculo = New VeiculoINFO
                    '.Veiculo.Marca = objReader("ASS_STR_DS_MARCA")
                    '.Veiculo.Modelo = objReader("ASS_STR_DS_MODELO")
                    '.Veiculo.Ano = objReader("ASS_INT_NR_ANO")
                End With
                objLstCliente.Add(objInfoCliente)
            End While


            Return objLstCliente

        Catch ex As Exception
            Throw ex
        Finally
            FecharConexao()
            objReader = Nothing

        End Try

    End Function

    Public Function dbObterIDCliente(ByVal pStrFiltro As String, Optional ByVal pFiltroSelecionado As String = Nothing) As List(Of ClienteINFO)
        Dim sql As String
        Dim conn As FbCommand
        Dim objReader As FbDataReader
        Dim objInfoCliente As ClienteINFO
        Dim objLstCliente As List(Of ClienteINFO)

        Try

            AbrirConexao()
            'sql = "SELECT ASS_INT_ID_CLIENTE, ASS_STR_DS_NOME1, ASS_STR_DS_NOME2, ASS_INT_NR_TELEFONE, " &
            '    " ASS_STR_DS_ENDERECO, ASS_STR_DS_COMPLEMENTO, ASS_STR_DS_BAIRRO FROM TBL_CLIENTE WHERE ASS_STR_DS_NOME1 = '" & pStrCliente.ToString & "'"
            sql = "SELECT C.ASS_INT_ID_CLIENTE FROM TBL_CLIENTE C   " &
            "INNER join tbl_veiculo V ON C.ass_int_id_cliente = V.ass_int_id_cliente  "

            If pFiltroSelecionado = "Nome" Then
                sql += "where C.ass_str_ds_nome1 CONTAINING '" & pStrFiltro.ToString & "' "
            End If

            If pFiltroSelecionado = "Placa" Then
                sql += "where V.ASS_STR_DS_PLACA CONTAINING '" & pStrFiltro.ToString & "' "
            End If

            sql += " ORDER BY C.ASS_STR_DS_NOME1 ASC"

            conn = New FbCommand()

            conn.CommandText = sql
            conn.Connection = conexao

            objReader = conn.ExecuteReader

            objLstCliente = New List(Of ClienteINFO)

            While objReader.Read
                objInfoCliente = New ClienteINFO
                With objInfoCliente
                    .ID = objReader("ASS_INT_ID_CLIENTE")
                    If Not IsDBNull(objReader("ASS_STR_DS_NOME1")) Then
                        .Nome1 = objReader("ASS_STR_DS_NOME1")
                    End If
                    If Not IsDBNull(objReader("ASS_STR_DS_NOME2")) Then
                        .Nome2 = objReader("ASS_STR_DS_NOME2")
                    End If

                    .Telefone = objReader("ASS_INT_NR_TELEFONE")
                    .Endereco = objReader("ASS_STR_DS_ENDERECO")
                    If Not IsDBNull(objReader("ASS_STR_DS_COMPLEMENTO")) Then
                        .Complemento = objReader("ASS_STR_DS_COMPLEMENTO")
                    End If

                    If Not IsDBNull(objReader("ASS_STR_DS_EMAIL")) Then
                        .Email = objReader("ASS_STR_DS_EMAIL")
                    End If

                    .Veiculo = New VeiculoINFO
                    .Veiculo.Marca = objReader("ASS_STR_DS_MARCA")
                    .Veiculo.Modelo = objReader("ASS_STR_DS_MODELO")
                    .Veiculo.Ano = objReader("ASS_INT_NR_ANO")
                End With
                objLstCliente.Add(objInfoCliente)
            End While


            Return objLstCliente

        Catch ex As Exception
            Throw ex
        Finally
            FecharConexao()
            objReader = Nothing

        End Try

    End Function
    Public Function dbObterClientePorID(ByVal pIntID As Integer) As ClienteINFO
        Dim sql As String
        Dim conn As FbCommand
        Dim objReader As FbDataReader
        Dim objInfoCliente As ClienteINFO
        Dim objDalVeiculos As DalVeiculo


        Try

            AbrirConexao()
            'sql = "SELECT ASS_INT_ID_CLIENTE, ASS_STR_DS_NOME1, ASS_STR_DS_NOME2, ASS_INT_NR_TELEFONE, " &
            '    " ASS_STR_DS_ENDERECO, ASS_STR_DS_COMPLEMENTO, ASS_STR_DS_BAIRRO FROM TBL_CLIENTE WHERE ASS_STR_DS_NOME1 = '" & pStrCliente.ToString & "'"
            sql = "SELECT C.ASS_INT_ID_CLIENTE, ASS_STR_DS_NOME1, ASS_STR_DS_NOME2, ASS_INT_NR_TELEFONE, ASS_STR_DS_ENDERECO, " &
            "ASS_STR_DS_COMPLEMENTO, ASS_STR_DS_BAIRRO, ASS_STR_DS_EMAIL  FROM TBL_CLIENTE C "
            sql += "where C.ASS_INT_ID_CLIENTE = '" & pIntID & "' "

            ', V.ASS_STR_DS_MODELO, V.ASS_STR_DS_MARCA, V.ASS_INT_NR_ANO, V.ASS_STR_DS_PLACA, V.ASS_IMG_BLB_FOTO FROM TBL_CLIENTE C   " &
            '"INNER join tbl_veiculo V ON C.ass_int_id_cliente = V.ass_int_id_cliente  "
            'sql += "where C.ASS_INT_ID_CLIENTE = '" & pIntID & "' "


            conn = New FbCommand()

            conn.CommandText = sql
            conn.Connection = conexao

            objReader = conn.ExecuteReader



            objInfoCliente = New ClienteINFO

            If objReader.Read Then



                With objInfoCliente
                    .ID = objReader("ASS_INT_ID_CLIENTE")
                    If Not IsDBNull(objReader("ASS_STR_DS_NOME1")) Then
                        .Nome1 = objReader("ASS_STR_DS_NOME1")
                    End If
                    If Not IsDBNull(objReader("ASS_STR_DS_NOME2")) Then
                        .Nome2 = objReader("ASS_STR_DS_NOME2")
                    End If

                    .Telefone = objReader("ASS_INT_NR_TELEFONE")
                    .Endereco = objReader("ASS_STR_DS_ENDERECO")
                    If Not IsDBNull(objReader("ASS_STR_DS_COMPLEMENTO")) Then
                        .Complemento = objReader("ASS_STR_DS_COMPLEMENTO")
                    End If

                    If Not IsDBNull(objReader("ASS_STR_DS_BAIRRO")) Then
                        .Bairro = objReader("ASS_STR_DS_BAIRRO")
                    End If

                    If Not IsDBNull(objReader("ASS_STR_DS_EMAIL")) Then
                        .Email = objReader("ASS_STR_DS_EMAIL")
                    End If


                    objDalVeiculos = New DalVeiculo
                    .ListaVeiculos = New List(Of VeiculoINFO)

                    .ListaVeiculos = objDalVeiculos.dbListarVeiculos(objInfoCliente)



                    '.Veiculo = New VeiculoINFO
                    '.Veiculo.Marca = objReader("ASS_STR_DS_MARCA")
                    '.Veiculo.Modelo = objReader("ASS_STR_DS_MODELO")
                    '.Veiculo.Ano = objReader("ASS_INT_NR_ANO")
                    'If Not IsDBNull(objReader("ASS_STR_DS_PLACA")) Then
                    '    .Veiculo.Placa = objReader("ASS_STR_DS_PLACA")
                    'Else
                    '    .Veiculo.Placa = String.Empty
                    'End If
                    'If Not IsDBNull(objReader("ASS_IMG_BLB_FOTO")) Then
                    '    .Veiculo.Foto = DirectCast(objReader("ASS_IMG_BLB_FOTO"), Byte())
                    'End If
                End With

            End If


            Return objInfoCliente

        Catch ex As Exception
            Throw ex
        Finally
            FecharConexao()
            objReader = Nothing

        End Try

    End Function

    Public Function dbIncluirCadastro(ByVal pObjCliente As ClienteINFO) As Boolean
        Dim strSQL As String
        Dim conn As FbCommand
        Dim objReader As FbDataReader
        Dim objDalVeiculo As DalVeiculo
        Try

            PreparaConexaoFB()
            AbrirConexao()

            strSQL = "select gen_id(GEN_TBL_CLIENTE_ID,1) from rdb$database"

            conn = New FbCommand()

            conn.CommandText = strSQL
            conn.Connection = conexao

            objReader = conn.ExecuteReader
            If objReader.Read Then
                pObjCliente.ID = CInt(objReader("GEN_ID"))
            End If

            strSQL = "INSERT into TBL_CLIENTE (ASS_INT_ID_CLIENTE, ASS_STR_DS_NOME1, ASS_INT_NR_TELEFONE, ASS_STR_DS_ENDERECO, ASS_STR_DS_COMPLEMENTO, ASS_STR_DS_BAIRRO, ASS_STR_DS_EMAIL)" &
                     " VALUES (" &
                     "" & pObjCliente.ID & "," &
            "'" & pObjCliente.Nome1 & "', " &
            "'" & pObjCliente.Telefone & "', " &
            "'" & pObjCliente.Endereco & "', " &
            "'" & pObjCliente.Complemento & "', " &
            "'" & pObjCliente.Bairro & "'," &
            "'" & pObjCliente.Email & "')"

            conn.CommandText = strSQL

            objDalVeiculo = New DalVeiculo
            conn.ExecuteNonQuery()

            objDalVeiculo.dbIncluirVeiculo(pObjCliente)

            FecharConexao()

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function dbIncluirVeiculo(ByVal pObjCliente As ClienteINFO) As Boolean
        Dim strSQL As String
        Dim conn As FbCommand
        Dim objReader As FbDataReader

        Try

            PreparaConexaoFB()
            AbrirConexao()

            strSQL = "select gen_id(GEN_TBL_VEICULO_ID,1) from rdb$database"

            conn = New FbCommand()

            conn.CommandText = strSQL
            conn.Connection = conexao

            objReader = conn.ExecuteReader
            If objReader.Read Then
                pObjCliente.Veiculo = New VeiculoINFO
                pObjCliente.Veiculo.ID = CInt(objReader("GEN_ID"))
            End If

            strSQL = "INSERT into TBL_VEICULO (ASS_INT_ID_VEICULO, ASS_INT_ID_CLIENTE, ASS_STR_DS_MARCA, ASS_INT_NR_ANO, ASS_STR_DS_MODELO)" &
                     " VALUES (" &
                     "" & pObjCliente.ID & "," &
            "'" & pObjCliente.Nome1 & "', " &
            "" & pObjCliente.Telefone & ", " &
            "'" & pObjCliente.Endereco & "', " &
            "'" & pObjCliente.Complemento & "', " &
            "'" & pObjCliente.Bairro & "')"
            ' Dim lLstParams As IDataParameter
            'If Not pObjCliente.Veiculo.Foto Is Nothing AndAlso pObjCliente.Veiculo.Foto.Length > 0 Then
            '    lLstParams.Add(dbParametroBlob("ASS_IMG_BLB_FOTO", pObjCliente.Veiculo.Foto))
            'Else
            '    lLstParams.Add(dbParametroNulo("ASS_IMG_BLB_FOTO"))
            'End If



            'conn = New FbCommand()

            conn.CommandText = strSQL
            'conn.Connection = conexao

            conn.ExecuteNonQuery()
            FecharConexao()

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function dbAlterarCadastro(ByVal pObjCliente As ClienteINFO) As Boolean
        Dim strSQL As String
        Dim objReader As IDataReader
        Dim conn As FbCommand

        Try

            AbrirConexao()

            strSQL = "UPDATE tbl_cliente SET ASS_STR_DS_NOME1 = '" & pObjCliente.Nome1 & "', " &
            "ASS_STR_DS_ENDERECO = '" & pObjCliente.Endereco & "', " &
            "ASS_INT_NR_TELEFONE = " & pObjCliente.Telefone & ", " &
            "ASS_STR_DS_COMPLEMENTO = '" & pObjCliente.Complemento & "', " &
            "ASS_STR_DS_BAIRRO = '" & pObjCliente.Bairro & "', " &
            "ASS_STR_DS_EMAIL = '" & pObjCliente.Email & "'" &
            "WHERE ASS_INT_ID_CLIENTE = " & pObjCliente.ID

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
    'Protected Function dbParametroBlob(ByVal pStrNomeParam As String, ByVal pObjValor() As Byte) As IDataParameter
    '    Try
    '        Return dbParametroBlob(pStrNomeParam, pObjValor)
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    Protected Function dbParametroBlob(ByVal pStrNomeParam As String, ByVal pObjValor() As Byte) As IDataParameter
        Dim lObjParam As IDataParameter

        Try

            lObjParam = New FirebirdSql.Data.FirebirdClient.FbParameter(pStrNomeParam, pObjValor)


            lObjParam.Value = pObjValor
            Return lObjParam
        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class
