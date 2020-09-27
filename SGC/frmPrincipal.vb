Imports BLL
Imports INFO
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Calendar.v3
Imports Google.Apis.Calendar.v3.Data
Imports Google.Apis.Services
Imports Google.Apis.Util
Imports System
Imports System.IO
Imports System.Linq
Imports System.Collections.Generic
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks

Public Class frmPrincipal
    Shared Scopes As String() = {CalendarService.Scope.Calendar}
    Shared ApplicationName As String = "Google Calendar API .NET Quickstart"

    Private Sub btnCadastrarClientes_Click(sender As Object, e As EventArgs)
        Dim frm As frmCadastrarCliente

        Try

            frm = New frmCadastrarCliente

            frm.ShowDialog()
            frm.Dispose()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnBuscarClientes_Click(sender As Object, e As EventArgs)
        Dim frm As frmBuscarClientes

        Try
            frm = New frmBuscarClientes
            frm.ShowDialog()
            frm.Dispose()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CadastrarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As frmCadastrarCliente

        Try

            frm = New frmCadastrarCliente

            frm.ShowDialog()
            frm.Dispose()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub BuscarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As frmBuscarClientes

        Try

            frm = New frmBuscarClientes
            frm.ShowDialog()
            frm.Dispose()
            'ObterAgendamentos()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Sair()
    End Sub

    Private Sub Sair()
        Me.Close()
        Me.Dispose()
    End Sub

    'Private Sub ObterAgendamentos()
    '    Dim objBllAgendamento As BLLAgendamento

    '    Dim lLstAgendamento As List(Of AgendamentoINFO)

    '    Try

    '        objBllAgendamento = New BLLAgendamento
    '        lLstAgendamento = New List(Of AgendamentoINFO)

    '        lLstAgendamento = objBllAgendamento.busObterAgendamento()

    '        For Each objAgendamento As AgendamentoINFO In lLstAgendamento
    '            objAgendamento.DataHora = objAgendamento.DataHora & " " & objAgendamento.Hora
    '            objAgendamento.Endereco = objAgendamento.Cliente.Endereco & " " & objAgendamento.Cliente.Complemento & " - " & objAgendamento.Cliente.Bairro
    '            objAgendamento.Nome = objAgendamento.Cliente.Nome1
    '            objAgendamento.Telefone = objAgendamento.Cliente.Telefone
    '        Next

    '        dgAgendamento.DataSource = Nothing
    '        dgAgendamento.AutoGenerateColumns = False
    '        dgAgendamento.DataSource = lLstAgendamento

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ObterAgendamentos()
        'SincronizaAgendaGoogle()
    End Sub

    'Private Sub dgAgendamento_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
    '    Dim objBll As BLLAgendamento
    '    If e.RowIndex >= 0 AndAlso e.ColumnIndex = 5 Then
    '        With DirectCast(dgAgendamento(e.ColumnIndex, e.RowIndex), DataGridViewImageCell)
    '            If MessageBox.Show("Tem certeza que deseja remover o agendamento?", "Excluir agendamento.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then



    '                objBll = New BLLAgendamento
    '                Dim ID As Integer
    '                ID = dgAgendamento.CurrentRow.Cells(0).Value
    '                If objBll.busExcluirAgendamento(ID) Then
    '                    MessageBox.Show("Agendamento excluido com sucesso.")
    '                End If

    '                ObterAgendamentos()
    '            End If
    '        End With

    '    End If
    'End Sub

    Private Sub ConfiguraçõesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As frmConfiguracao

        frm = New frmConfiguracao
        frm.ShowDialog()
        frm.Dispose()

    End Sub


    Private Sub BalançoFinanceiroToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim frm As frmCadastrarCliente

        Try

            frm = New frmCadastrarCliente

            frm.ShowDialog()
            frm.Dispose()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim frm As frmBuscarClientes

        Try

            frm = New frmBuscarClientes
            frm.ShowDialog()
            frm.Dispose()
            'ObterAgendamentos()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim frm As frmConfiguracao

        frm = New frmConfiguracao
        frm.ShowDialog()
        frm.Dispose()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Me.Close()
    End Sub

    Private Sub frmOrcamento_Click(sender As Object, e As EventArgs) Handles frmOrcamento.Click
        Dim frm As frmOrcamento

        frm = New frmOrcamento
        frm.ShowDialog()
        frm.Dispose()
    End Sub
End Class
