Imports BLL
Imports INFO
Imports UTIL
'Imports Google
'Imports Google.GData.Calendar
'Imports Google.GData.Client
'Imports Google.GData.Extensions

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


Public Class frmAgendamento
    Private mObjCliente As ClienteINFO
    Shared Scopes As String() = {CalendarService.Scope.Calendar}
    Shared ApplicationName As String = "Google Calendar API .NET Quickstart"

    Public Sub CriarEvento()
        Dim Credencial As UserCredential

        Using stream = New FileStream("client_secret.json", FileMode.CreateNew, FileAccess.Write)
            Dim credPath As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal)
            credPath = Path.Combine(credPath, ".credentials/calendar-dotnet-quickstart.json")

            Credencial = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, Scopes, "user",
                                                                     CancellationToken.None, New Store.FileDataStore(credPath, True)).Result
            Console.WriteLine("Credential file saved to: " & credPath)
        End Using

        ' Create Google Calendar API service.
        Dim service = New CalendarService(New BaseClientService.Initializer() With {.HttpClientInitializer = Credencial,
    .ApplicationName = ApplicationName})
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

        Dim evento As New [Event]
        evento.Description = "oi"
        evento.Summary = "summario"
        evento.Location = "local"
        ' Dim startDateTime As DateTime = New DateTime("2015-05-28T09:00:00-07:00")
        Dim start As EventDateTime = New EventDateTime
        evento.Start = start
        Dim endTime As EventDateTime = New EventDateTime
        evento.End = endTime
        Dim calendarId As String = "primary"
        service.Events.Insert(evento, calendarId).Execute()



        If events.Items IsNot Nothing AndAlso events.Items.Count > 0 Then
            For Each eventItem As [Event] In events.Items
                Dim [when] As String = eventItem.Start.DateTime.ToString()
                If [String].IsNullOrEmpty([when]) Then
                    [when] = eventItem.Start.[Date]
                End If
                Console.WriteLine("{0} ({1})", eventItem.Summary, [when])
            Next

        Else
            Console.WriteLine("No upcoming events found.")
        End If
        Console.Read()





    End Sub


    Sub New(ByVal objCliente As ClienteINFO)
        mObjCliente = objCliente
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub CarregaTela()
        Try
            lblNome.Text = mObjCliente.Nome1
            lblTelefone.Text = mObjCliente.Telefone
            lblEndereco.Text = mObjCliente.Endereco & " - " & mObjCliente.Complemento & " - " & mObjCliente.Bairro
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub frmAgendamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregaTela()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        InsereAgendamento()
    End Sub

    Private Sub InsereAgendamento()
        Dim objInfo As AgendamentoINFO
        Dim objBll As BLLAgendamento

        Try
            ' SincronizaAgendaGoogle()
            'Dim g As New GoogleCalSvc
            'Dim retorno As String

            'retorno = g.A1CreateEvent("Primary", "teste", Now.Date, Now.Date, "teste", "teste", "teste")

            objBll = New BLLAgendamento
            objInfo = New AgendamentoINFO

            objInfo.DataHora = dtpDataAgendamento.Value.Date.Date
            objInfo.Hora = CStr(dtpHoraAgendamento.Value.Hour & ":" & dtpHoraAgendamento.Value.Minute)
            objInfo.IDCliente = mObjCliente.ID

            If objBll.busInserirAgendamento(objInfo) Then
                MessageBox.Show("Agendamento realizado com sucesso.")
                Me.Close()

            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub


End Class