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

    Private Sub CadastrarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarClientesToolStripMenuItem.Click
        Dim frm As frmCadastrarCliente

        Try

            frm = New frmCadastrarCliente

            frm.ShowDialog()
            frm.Dispose()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub BuscarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarClienteToolStripMenuItem.Click
        Dim frm As frmBuscarClientes

        Try

            frm = New frmBuscarClientes
            frm.ShowDialog()
            frm.Dispose()
            ObterAgendamentos()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Sair()
    End Sub

    Private Sub Sair()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ObterAgendamentos()
        Dim objBllAgendamento As BLLAgendamento

        Dim lLstAgendamento As List(Of AgendamentoINFO)

        Try

            objBllAgendamento = New BLLAgendamento
            lLstAgendamento = New List(Of AgendamentoINFO)

            lLstAgendamento = objBllAgendamento.busObterAgendamento()

            For Each objAgendamento As AgendamentoINFO In lLstAgendamento
                objAgendamento.DataHora = objAgendamento.DataHora & " " & objAgendamento.Hora
                objAgendamento.Endereco = objAgendamento.Cliente.Endereco & " " & objAgendamento.Cliente.Complemento & " - " & objAgendamento.Cliente.Bairro
                objAgendamento.Nome = objAgendamento.Cliente.Nome1
                objAgendamento.Telefone = objAgendamento.Cliente.Telefone
            Next

            dgAgendamento.DataSource = Nothing
            dgAgendamento.AutoGenerateColumns = False
            dgAgendamento.DataSource = lLstAgendamento

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObterAgendamentos()
        SincronizaAgendaGoogle()
    End Sub

    Private Sub dgAgendamento_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgAgendamento.CellContentClick
        Dim objBll As BLLAgendamento
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 5 Then
            With DirectCast(dgAgendamento(e.ColumnIndex, e.RowIndex), DataGridViewImageCell)
                If MessageBox.Show("Tem certeza que deseja remover o agendamento?", "Excluir agendamento.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then



                    objBll = New BLLAgendamento
                    Dim ID As Integer
                    ID = dgAgendamento.CurrentRow.Cells(0).Value
                    If objBll.busExcluirAgendamento(ID) Then
                        MessageBox.Show("Agendamento excluido com sucesso.")
                    End If

                    ObterAgendamentos()
                End If
            End With

        End If
    End Sub

    Private Sub ConfiguraçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraçõesToolStripMenuItem.Click
        Dim frm As frmConfiguracao

        frm = New frmConfiguracao
        frm.ShowDialog()
        frm.Dispose()

    End Sub
    Public Sub SincronizaAgendaGoogle()
        Dim Credencial As UserCredential

        Using stream = New FileStream("client_secret.json", FileMode.Open, FileAccess.Read)
            Dim credPath As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal)
            credPath = Path.Combine(credPath, ".credentials/calendar-dotnet-quickstart.json")

            Credencial = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, Scopes, "user",
                                                                     CancellationToken.None, New Store.FileDataStore(credPath, True)).Result
            Console.WriteLine("Credential file saved to: " & credPath)


        End Using

        ' Create Google Calendar API service.
        Dim service = New CalendarService(New BaseClientService.Initializer() With {.HttpClientInitializer = Credencial,
    .ApplicationName = ApplicationName})


        '        Dim calendarId As String = "primary"
        'Event=service.events.insert(calendarId, event).execute
        'System.out.printf("Event created: %s"& vbLf, event, ., getHtmlLink)

        'Dim rule As AclRule = New AclRule

        'Dim createdRule As AclRule = service.Acl.Insert(rule, "10").Execute ' (Microsoft.VisualBasic.ChrW(112), rule).Execute

        ' Define parameters of request.
        Dim request As EventsResource.ListRequest = service.Events.List("primary")
        request.TimeMin = DateTime.Now
        request.ShowDeleted = False
        request.SingleEvents = True
        request.MaxResults = 10
        request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime

        'List events.
        Dim events As Events = request.Execute()
        Console.WriteLine("Upcoming events:")

        'Dim evento As New [Event]
        'evento.Description = "oi"
        'evento.Summary = "summario"
        'evento.Location = "local"
        '' Dim startDateTime As DateTime = New DateTime("2015-05-28T09:00:00-07:00")
        'Dim start As EventDateTime = New EventDateTime
        'evento.Start = start
        'Dim endTime As EventDateTime = New EventDateTime
        'evento.End = endTime
        'Dim calendarId As String = "primary"
        'service.Events.Insert(evento, calendarId).Execute()

        Dim lstAgendamento As New List(Of AgendamentoINFO)
        Dim objAgendamento As AgendamentoINFO


        If events.Items IsNot Nothing AndAlso events.Items.Count > 0 Then
            For Each eventItem As [Event] In events.Items
                objAgendamento = New AgendamentoINFO
                '      Dim [when] As String = eventItem.Start.DateTime.ToString()
                '       Dim Agendados As String = eventItem.Start.DateTime.ToString()

                objAgendamento.DataHora = CDate(eventItem.Start.DateTime)
                objAgendamento.Endereco = eventItem.Location

                lstAgendamento.Add(objAgendamento)

                ''     If String.IsNullOrEmpty(Agendados) Then
                '   Agendados = eventItem.Start.Date
                'End If

                'If [String].IsNullOrEmpty([when]) Then
                '    [when] = eventItem.Start.[Date]
                'End If
                '      Console.WriteLine("{0} ({1})", eventItem.Summary, [when])
            Next
            dgAgendamento.AutoGenerateColumns = False
            dgAgendamento.DataSource = lstAgendamento


        Else
            '   Console.WriteLine("No upcoming events found.")
        End If
        'Console.Read()





    End Sub

    Private Sub BalançoFinanceiroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BalançoFinanceiroToolStripMenuItem.Click

    End Sub
End Class
