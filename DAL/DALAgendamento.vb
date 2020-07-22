Imports INFO
Imports FirebirdSql
Imports FirebirdSql.Data
Imports FirebirdSql.Data.FirebirdClient

Public Class DALAgendamento
    Inherits DalGenerica

    Public Function dbIncluirAgendamento(ByVal pObjAgendamento As AgendamentoINFO) As Boolean

        Dim strSql As String
        Dim objReader As FbDataReader
        Dim conn As FbCommand

        Try
            PreparaConexaoFB()
            AbrirConexao()

            strSql = "select gen_id(GEN_TBL_AGENDAMENTO_ID,1) from rdb$database"

            conn = New FbCommand()

            conn.CommandText = strSql
            conn.Connection = conexao

            objReader = conn.ExecuteReader

            If objReader.Read Then

                pObjAgendamento.ID = CInt(objReader("GEN_ID"))

            End If

            strSql = "insert into TBL_AGENDAMENTO (ASS_INT_ID_AGENDAMENTO, ASS_DAT_DT_DATAAGENDAMENTO, ASS_INT_ID_CLIENTE, ASS_STR_HR_HORAAGENDAMENTO " &
                       ") " &
            "VALUES (" &
             "" & pObjAgendamento.ID & ", " &
             "'" & pObjAgendamento.DataHora.ToString("MM/dd/yyyy") & "', " &
              "" & pObjAgendamento.IDCliente & "," &
               "'" & pObjAgendamento.Hora & "')"

            conn.CommandText = strSql
            conn.ExecuteNonQuery()
            FecharConexao()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function dbExckuirAgendamento(ByVal pIntIDAgendamento As Integer) As Boolean

        Dim strSql As String
        Dim objReader As FbDataReader
        Dim conn As FbCommand

        Try
            PreparaConexaoFB()
            AbrirConexao()

            conn = New FbCommand()

            conn.Connection = conexao

            strSql = "DELETE FROM TBL_AGENDAMENTO WHERE ASS_INT_ID_AGENDAMENTO =  " & pIntIDAgendamento

            conn.CommandText = strSql
            conn.ExecuteNonQuery()
            FecharConexao()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function dbObterAgendamentos() As List(Of AgendamentoINFO)
        Dim lLstAgendamento As List(Of AgendamentoINFO)
        Dim objAgendamento As AgendamentoINFO
        Dim strSQL As String
        Dim objReader As FbDataReader
        Dim conn As FbCommand
        Dim objDalCLiente As DalCliente
        Try


            PreparaConexaoFB()
            AbrirConexao()

            strSQL = "SELECT ASS_INT_ID_AGENDAMENTO, ASS_DAT_DT_DATAAGENDAMENTO, ASS_INT_ID_CLIENTE, ASS_STR_HR_HORAAGENDAMENTO FROM TBL_AGENDAMENTO " &
                      "WHERE ASS_DAT_DT_DATAAGENDAMENTO > '" & Now.Date.ToString("MM/dd/yyyy") & "'"

            conn = New FbCommand()

            conn.CommandText = strSQL
            conn.Connection = conexao

            objReader = conn.ExecuteReader


            lLstAgendamento = New List(Of AgendamentoINFO)

            While objReader.Read

                objAgendamento = New AgendamentoINFO
                With objAgendamento
                    .DataHora = CDate(objReader("ASS_DAT_DT_DATAAGENDAMENTO"))
                    If Not IsDBNull(objReader("ASS_STR_HR_HORAAGENDAMENTO")) Then
                        .Hora = CStr(objReader("ASS_STR_HR_HORAAGENDAMENTO").ToString)
                    End If
                    .ID = CInt(objReader("ASS_INT_ID_AGENDAMENTO"))
                    objDalCLiente = New DalCliente
                    .Cliente = objDalCLiente.dbObterClientePorID(CInt(objReader("ASS_INT_ID_CLIENTE")))
                End With

                lLstAgendamento.Add(objAgendamento)
            End While

            Return lLstAgendamento
        Catch ex As Exception

        End Try
    End Function
End Class
