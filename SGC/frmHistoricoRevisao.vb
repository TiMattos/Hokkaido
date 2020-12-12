Imports BLL
Imports INFO
Imports UTIL
Imports System.Net.Mail
Imports System.IO


Public Class frmHistoricoRevisao
    Private mObjCliente As ClienteINFO
    Private mObjLstServicos As List(Of ServicoINFO) = Nothing

    Private Sub frmHistoricoRevisao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PreencheGrid()
    End Sub

    Sub New(ByVal objCliente As ClienteINFO)
        mObjCliente = objCliente
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub PreencheGrid()

        Dim bllServico As BLLServicos
        Dim lListServicos As List(Of ServicoINFO)
        Dim listFiltro As List(Of ServicoINFO)
        Dim objFiltroServico As ServicoINFO


        Try
            bllServico = New BLLServicos
            lListServicos = New List(Of ServicoINFO)
            listFiltro = New List(Of ServicoINFO)
            objFiltroServico = New ServicoINFO
            mObjLstServicos = New List(Of ServicoINFO)

            grdRevisoesRealizados.DataSource = Nothing
            grdRevisoesRealizados.AutoGenerateColumns = False
            lListServicos = bllServico.busObterServicos(mObjCliente.ID)
            mObjLstServicos = lListServicos
            'For i As Integer = 0 To lListServicos.Count - 1
            listFiltro = (From S In lListServicos Where S.Quilometragem > 0 Select S).ToList()
            ' listFiltro.Add(objFiltroServico)
            'Next
            grdRevisoesRealizados.DataSource = listFiltro

            listFiltro = New List(Of ServicoINFO)

            listFiltro = (From S In lListServicos Where S.Quilometragem = 0 Select S).ToList()

            dgvServicosRealizados.AutoGenerateColumns = False
            dgvServicosRealizados.DataSource = listFiltro
            'grdServicosRealizados.DataSource = bllServico.busObterServicos(mObjCliente.ID)

        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    Private Sub grdRevisoesRealizados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdRevisoesRealizados.CellContentClick
        Dim objBLL As BLLServicos
        Dim id As Integer
        Dim objServico As ServicoINFO


        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 4 Then
            With DirectCast(grdRevisoesRealizados(e.ColumnIndex, e.RowIndex), DataGridViewButtonCell)
                If .Value Is Nothing Then
                    id = grdRevisoesRealizados.CurrentRow.Cells(0).Value
                    objBLL = New BLLServicos
                    objServico = New ServicoINFO

                    objServico = objBLL.busObterServicoPorID(id)
                    'Dim CaminhoArquivo As String = Directory.GetCurrentDirectory & "\Relatorios de Servicos realizados" & "\" & mObjCliente.Veiculo.Placa & "_" & objServico.Quilometragem & "KM" & ".PDF"
                    GerarRelatorio(objServico)
                    'If Not File.Exists(objServico.CaminhoArquivo) Then
                    '    MessageBox.Show("Não foi possível exibir, arquivo de Revisão não encontrado")

                    'Else
                    '    Process.Start(objServico.CaminhoArquivo)
                    'End If

                End If
            End With
        ElseIf e.RowIndex >= 0 AndAlso e.ColumnIndex = 5 Then
            With DirectCast(grdRevisoesRealizados(e.ColumnIndex, e.RowIndex), DataGridViewButtonCell)
                If .Value Is Nothing Then

                    id = grdRevisoesRealizados.CurrentRow.Cells(0).Value
                    objBLL = New BLLServicos
                    objServico = New ServicoINFO

                    objServico = objBLL.busObterServicoPorID(id)

                    Dim bll As New BLLCLientes
                    Dim frm As New frmServicos(bll.busObterClientePorID(objServico.IdCliente), True, objServico)
                    frm.ShowDialog()
                    'Dim CaminhoArquivo As String = Directory.GetCurrentDirectory & "\Relatorios de Servicos realizados" & "\" & mObjCliente.Veiculo.Placa & "_" & objServico.Quilometragem & "KM" & ".PDF"

                    'If Not File.Exists(objServico.CaminhoArquivo) Then
                    '    MessageBox.Show("Não foi possível exibir, arquivo de Revisão não encontrado")

                    'Else
                    '    Process.Start(objServico.CaminhoArquivo)
                    'End If

                End If
            End With
        ElseIf e.RowIndex >= 0 AndAlso e.ColumnIndex = 6 Then
            With DirectCast(grdRevisoesRealizados(e.ColumnIndex, e.RowIndex), DataGridViewButtonCell)
                If .Value Is Nothing Then

                    id = grdRevisoesRealizados.CurrentRow.Cells(0).Value
                    objBLL = New BLLServicos
                    objServico = New ServicoINFO

                    objServico = objBLL.busObterServicoPorID(id)

                    If MessageBox.Show("Tem certeza que deseja excluir a revisão de " & objServico.Quilometragem & " KM do veiculo placa " & objServico.Placa & " ?", "Excluir revisão", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        If objBLL.busExcluirServico(objServico) Then
                            MessageBox.Show("Revisão excluida com sucesso.")
                        End If
                    End If

                End If
            End With
        End If
    End Sub
    Private Sub GerarRelatorio(ByVal objServicos As ServicoINFO)
        Dim dsRelServico As New dsServicos
        Dim crServico As crRelServicosRealizados = Nothing
        Dim lObj() As Object = Nothing
        Dim lobjFrmVisualizador As New frmViewer
        Dim objBLLVeiculo As New BLLVeiculo
        Dim objVeiculo As New VeiculoINFO
        Dim objBllCliente As New BLLCLientes

        crServico = New crRelServicosRealizados
        objVeiculo = objBLLVeiculo.busObterVeiculoPorID(objServicos.IdVeiculo)
        lObj = New Object(8) {}

        lObj.SetValue(objBllCliente.busObterClientePorID(objServicos.IdCliente).Nome1, 0)
        lObj.SetValue(objServicos.ServicoRealizado, 1)
        lObj.SetValue(objVeiculo.Marca & " - " & objVeiculo.Modelo, 2)
        lObj.SetValue(objServicos.KmAtual, 3)
        lObj.SetValue(objVeiculo.Placa, 4)
        lObj.SetValue(objServicos.MaodeObra.Replace("R$", "").Replace(",", "").Replace(".", ""), 5)
        lObj.SetValue(objServicos.Observacao, 6)
        'If rdbRevisao.Checked Then
        lObj.SetValue("REVISÃO DE " & objServicos.Quilometragem & " MIL KMs", 7)
        ' ElseIf rdbServico.Checked Then
        ' lObj.SetValue(String.Empty, 7)
        'End If

        If objServicos.KmAtual <> 0 Then
            lObj.SetValue("KM ATUAL: " & objServicos.KmAtual, 8)
        Else
            lObj.SetValue(String.Empty, 8)
        End If


        dsRelServico.Servicos.Rows.Add(lObj)

        lObj = Nothing

        crServico.SetDataSource(dsRelServico)



        'sbBarraMensagem("GERANDO DOCUMENTO, AGURADE...")

        lobjFrmVisualizador.crVisualizador.ReportSource = crServico
        lobjFrmVisualizador.ShowDialog()
    End Sub

    Private Sub dgvServicosRealizados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServicosRealizados.CellContentClick
        Dim objBLL As BLLServicos
        Dim id As Integer
        Dim objServico As ServicoINFO


        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 2 Then
            With DirectCast(dgvServicosRealizados(e.ColumnIndex, e.RowIndex), DataGridViewButtonCell)
                If .Value Is Nothing Then
                    id = dgvServicosRealizados.CurrentRow.Cells(0).Value
                    objBLL = New BLLServicos
                    objServico = New ServicoINFO

                    objServico = objBLL.busObterServicoPorID(id)
                    'Dim CaminhoArquivo As String = Directory.GetCurrentDirectory & "\Relatorios de Servicos realizados" & "\" & mObjCliente.Veiculo.Placa & "_" & objServico.Quilometragem & "KM" & ".PDF"

                    If Not File.Exists(objServico.CaminhoArquivo) Then
                        MessageBox.Show("Não foi possível exibir, arquivo de Revisão não encontrado")

                    Else
                        Process.Start(objServico.CaminhoArquivo)
                    End If

                Else

                End If
            End With

        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        GerarRelatorioHistorico(False)
    End Sub

    Private Sub GerarRelatorioHistorico(ByVal pBolEnviarEmail As Boolean)
        Dim dsHistorico As New dsHistoricoRevisao
        Dim crHistorico As crHistoricoRevisoes = Nothing
        Dim lObj() As Object = Nothing
        Dim lobjFrmVisualizador As New frmViewer
        Dim lLstServicoPorData As List(Of ServicoINFO)
        Try
            Me.lblAlerta.Text = "AGUARDE, GERANDO HISTÓRICO..."
            Me.lblAlerta.Refresh()
            Application.UseWaitCursor = True
            Application.DoEvents()


            crHistorico = New crHistoricoRevisoes

            lObj = New Object(5) {}

            lObj.SetValue(mObjCliente.Nome1, 1)
            lObj.SetValue(String.Empty, 2)

            lLstServicoPorData = New List(Of ServicoINFO)

            lLstServicoPorData = (From x In mObjLstServicos Order By x.DataServico Ascending).ToList

            For Each servico As ServicoINFO In lLstServicoPorData
                With servico

                    If .Quilometragem = 0 Then
                        lObj.SetValue("SERVIÇO", 0)

                    Else
                        lObj.SetValue("REVISÃO DE " & .Quilometragem, 0)

                    End If

                    lObj.SetValue(.ServicoRealizado.Replace("/", vbCrLf), 3)

                    lObj.SetValue(.DataServico, 4)
                    lObj.SetValue(.Veiculo, 5)

                End With

                dsHistorico.Historico.Rows.Add(lObj)
            Next

            crHistorico.SetDataSource(dsHistorico)

            If Not pBolEnviarEmail Then
                lobjFrmVisualizador.crVisualizador.ReportSource = crHistorico
                Application.UseWaitCursor = False
                Application.DoEvents()

                lobjFrmVisualizador.ShowDialog()
            End If



            Me.lblAlerta.Text = String.Empty
            Me.lblAlerta.Refresh()

            If Not MessageBox.Show("Deseja enviar o histórico de revisões por email?", "Envial email", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Exit Sub
            End If

            Dim CaminhoArquivo As String = Directory.GetCurrentDirectory & "\Temp"
            Dim CaminhoArquivoCompleto As String = CaminhoArquivo & "\" & "Historico" & ".PDF"

            If Not Directory.Exists(CaminhoArquivo) Then
                Directory.CreateDirectory(CaminhoArquivo)
            End If

            Me.lblAlerta.Text = "GERANDO ARQUIVO TEMPORÁRIO..."
            Me.lblAlerta.Refresh()
            crHistorico.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, CaminhoArquivoCompleto)

            Me.lblAlerta.Text = "AGUARDE, ENVIANDO EMAIL..."
            Me.lblAlerta.Refresh()
            Application.UseWaitCursor = True
            Application.DoEvents()
            EnviarEmail(CaminhoArquivoCompleto)



            Me.lblAlerta.Text = String.Empty
            Me.lblAlerta.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Me.lblAlerta.Text = String.Empty
            Me.lblAlerta.Refresh()

            lObj = Nothing
            lobjFrmVisualizador = Nothing
            dsHistorico = Nothing
            crHistorico = Nothing
            Application.UseWaitCursor = False
            Application.DoEvents()
        End Try

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub EnviarEmail(ByVal pCaminhoArquivo As String)
        'Define os dados do e-mail
        Dim nomeRemetente As String
        Dim emailRemetente As String
        Dim senha As String
        Dim objBLL As BLLConfiguracao
        Dim objConfiguracao As ConfiguracaoINFO

        objBLL = New BLLConfiguracao
        objConfiguracao = New ConfiguracaoINFO

        nomeRemetente = "Hokkaido Auto Honda"
        emailRemetente = "hokkaidoautohonda@gmail.com"
        'senha = "Hkd@06/11/16"
        objConfiguracao = objBLL.busObterConfiguracoes()
        senha = objConfiguracao.SenhaEmail

        Dim emailDestinatario As String
        Dim emailComCopia As String
        Dim emailComCopiaOculta As String

        emailDestinatario = mObjCliente.Email
        emailComCopia = "email@comcopia.com.br"
        emailComCopiaOculta = "email@comcopiaoculta.com.br"


        'Host da porta SMTP
        Dim SMTP As String

        SMTP = "smtp.gmail.com"

        Dim assuntoMensagem As String
        Dim conteudoMensagem As String

        assuntoMensagem = "Histórico de revisões e serviços Hokkaido Auto Honda."
        conteudoMensagem = "Agradecemos pela sua preferência e confiança, " & vbCrLf & " " &
                            "Segue em anexo o histórico de revisões e serviços realizados em seu veículo. " & vbCrLf & " " &
                             " " & vbCrLf & " " &
                            "Atenciosamente, " & vbCrLf & " " &
                           " " & vbCrLf & " " &
                            "Hokkaido Auto Honda."


        'Cria objeto com dados do e-mail.
        Dim objEmail As New System.Net.Mail.MailMessage()

        'Define o Campo From e ReplyTo do e-mail.
        objEmail.From = New System.Net.Mail.MailAddress("<" & emailRemetente & ">")
        'objEmail.ReplyTo = New System.Net.Mail.MailAddress("Nome <email@seudominio.com.br>")

        'Define os destinatários do e-mail.
        objEmail.To.Add("<" & emailDestinatario & ">")

        'Define a prioridade do e-mail.
        objEmail.Priority = System.Net.Mail.MailPriority.Normal

        'Define o formato do e-mail HTML (caso não queira HTML alocar valor false)
        objEmail.IsBodyHtml = False

        'Define o título do e-mail.
        objEmail.Subject = assuntoMensagem

        'Define o corpo do e-mail.
        'objEmail.Body = "<b>" & conteudoMensagem & "</b>"
        objEmail.Body = conteudoMensagem

        objEmail.Attachments.Add(New Attachment(pCaminhoArquivo))

        'Para evitar problemas com caracteres "estranhos", configuramos o Charset para "ISO-8859-1"
        objEmail.SubjectEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1")
        objEmail.BodyEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1")



        'Cria objeto com os dados do SMTP
        Dim objSmtp As New System.Net.Mail.SmtpClient(SMTP, 587)
        objSmtp.UseDefaultCredentials = False

        'Alocamos o endereço do host para enviar os e-mails  
        objSmtp.Credentials = New System.Net.NetworkCredential(emailRemetente, senha)
        objSmtp.Host = SMTP
        objSmtp.Port = 587

        'Caso utilize conta de email do exchange da locaweb deve habilitar o SSL
        objSmtp.EnableSsl = True

        'Enviamos o e-mail através do método .send()

        Try
            objSmtp.Send(objEmail)
            Me.lblAlerta.Text = "E-mail enviado com sucesso !"
            Application.UseWaitCursor = False
            Application.DoEvents()
            MessageBox.Show("E-mail enviado com sucesso !")

        Catch ex As Exception
            MessageBox.Show("Ocorreram problemas no envio do e-mail. Erro = " & ex.Message)

        End Try
        'excluímos o objeto de e-mail da memória
        objEmail.Dispose()
        objSmtp.Dispose()
        Me.lblAlerta.Text = String.Empty
        Application.UseWaitCursor = False
        Application.DoEvents()

        'anexo.Dispose();
    End Sub

    Private Sub btnEnviarEmail_Click(sender As Object, e As EventArgs) Handles btnEnviarEmail.Click
        GerarRelatorioHistorico(True)
    End Sub
End Class