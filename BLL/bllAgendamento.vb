Imports DAL
Imports INFO



Public Class BLLAgendamento
    Public Function busInserirAgendamento(ByVal pObjAgendamento As AgendamentoINFO) As Boolean
        Dim objDAL As DALAgendamento
        Try
            objDAL = New DALAgendamento

            Return objDAL.dbIncluirAgendamento(pObjAgendamento)
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function busExcluirAgendamento(ByVal pIntIDAgendamento As Integer) As Boolean
        Dim objDAL As DALAgendamento
        Try
            objDAL = New DALAgendamento

            Return objDAL.dbExckuirAgendamento(pIntIDAgendamento)
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function busObterAgendamento() As List(Of AgendamentoINFO)
        Dim objDAL As DALAgendamento
        Try
            objDAL = New DALAgendamento

            Return objDAL.dbObterAgendamentos()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
