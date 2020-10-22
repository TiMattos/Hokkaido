Imports INFO
Imports BLL
Imports UTIL
Imports System.Net.Mail
Imports System.IO


Public Class frmServicos
    Private mFrmSplash As frmProgresso

    Dim pb As ProgressBar
    Dim mObjCliente As ClienteINFO
    Private Delegate Sub CarregarRelatorioDelegate()



    Sub New(ByVal objCliente As ClienteINFO)
        mObjCliente = objCliente
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmServicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.rdbRevisao.Checked = True
        Me.cmbVeiculos.Enabled = True

        PreencheTela()
    End Sub

    Private Sub PreencheTela()

        Try
            lblNomeCliente.Text = mObjCliente.Nome1

            cmbVeiculos.DataSource = mObjCliente.ListaVeiculos
            cmbVeiculos.ValueMember = "Modelo"

            If mObjCliente.ListaVeiculos.Count = 1 Then
                cmbVeiculos.Enabled = False
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub

    Private Function ValidaCampos() As Boolean

        Try

            If txtItensManutencao.Text = String.Empty Then
                MessageBox.Show("Informe o serviço prestado.")
                Return False
            End If

            If rdbRevisao.Checked Then
                If txtKm.Text = String.Empty Then
                    MessageBox.Show("Informe a KM da manutenção.")
                    Return False
                End If
            End If


            Return True
        Catch ex As Exception
            Throw ex
        End Try


    End Function


    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        CadastrarServico()
    End Sub

    Private Sub CadastrarServico()
        Dim objbll As BLLServicos
        Dim objInfoServicos As ServicoINFO

        Dim dsRelServico As New dsServicos
        Dim crServico As crRelServicosRealizados = Nothing
        Dim lObj() As Object = Nothing
        Dim lobjFrmVisualizador As New frmViewer
        Dim valorMO As Single

        Try
            'Me.lblAlerta.Text = String.Empty

            If Not ValidaCampos() Then
                Exit Sub
            End If

            objbll = New BLLServicos
            objInfoServicos = New ServicoINFO
            If rdbRevisao.Checked Then
                objInfoServicos.Quilometragem = CInt(txtKm.Text.Trim)
            ElseIf rdbServico.Checked Then
                objInfoServicos.Quilometragem = 0
            End If

            objInfoServicos.ServicoRealizado = txtItensManutencao.Text.Trim.Replace("" & vbCrLf & "", "/").ToUpper
            objInfoServicos.IdCliente = mObjCliente.ID
            objInfoServicos.Nome = mObjCliente.Nome1.ToUpper
            objInfoServicos.Veiculo = lblModelo.Text.ToUpper
            If Not txtMaodeObra.Text = String.Empty Then
                valorMO = txtMaodeObra.Text.Trim.ToUpper
            Else
                valorMO = 0
            End If

            objInfoServicos.MaodeObra = valorMO.ToString("C").ToUpper
            objInfoServicos.Observacao = txtObs.Text.Trim.Replace("" & vbCrLf & "", "/").ToUpper
            If Not txtKmAtual.Text = String.Empty Then
                objInfoServicos.KmAtual = CInt(txtKmAtual.Text.Trim.ToUpper)
            Else
                objInfoServicos.KmAtual = 0
            End If
            objInfoServicos.Placa = lblPlaca.Text.ToUpper

            Dim strTipoServico As String = String.Empty
            If rdbRevisao.Checked Then
                strTipoServico = "REVISÃO"
            ElseIf rdbServico.Checked Then
                strTipoServico = "SERVIÇO"
            End If

            Dim CaminhoArquivo As String = Directory.GetCurrentDirectory & "\Relatorios de Servicos realizados"
            Dim CaminhoArquivoCompleto As String = CaminhoArquivo & "\" & strTipoServico & "_" & Date.Now.ToString.Replace("/", "").Replace(":", "").Replace(" ", "") & ".PDF"
            'Dim CaminhoArquivoCompleto As String = CaminhoArquivo & "\" & lblPlaca.Text & "_" & objInfoServicos.Quilometragem & "KM" & ".PDF"
            If Not Directory.Exists(CaminhoArquivo) Then
                Directory.CreateDirectory(CaminhoArquivo)

            End If

            objInfoServicos.CaminhoArquivo = CaminhoArquivoCompleto

            If objbll.busInserirServico(objInfoServicos) Then
                MessageBox.Show("Serviço cadastrado com sucesso.")

            Else
                MessageBox.Show("Ocorreu um erro no cadastramento do serviço")
                Exit Sub
            End If

            'Me.lblAlerta.Text = "AGUARDE, GERANDO ORDEM DE SERVIÇO..."
            Application.UseWaitCursor = True
            Application.DoEvents()

            crServico = New crRelServicosRealizados
            lObj = New Object(8) {}

            lObj.SetValue(objInfoServicos.Nome, 0)
            lObj.SetValue(txtItensManutencao.Text, 1)
            lObj.SetValue(lblVeiculo.Text & " - " & cmbVeiculos.SelectedValue.ToString, 2)
            lObj.SetValue(objInfoServicos.Quilometragem, 3)
            lObj.SetValue(lblPlaca.Text, 4)
            lObj.SetValue(objInfoServicos.MaodeObra, 5)
            lObj.SetValue(txtObs.Text.Trim, 6)
            If rdbRevisao.Checked Then
                lObj.SetValue("REVISÃO DE " & objInfoServicos.Quilometragem & " MIL KMs", 7)
            ElseIf rdbServico.Checked Then
                lObj.SetValue(String.Empty, 7)
            End If

            If objInfoServicos.KmAtual <> 0 Then
                lObj.SetValue("KM ATUAL: " & objInfoServicos.KmAtual, 8)
            Else
                lObj.SetValue(String.Empty, 8)
            End If


            dsRelServico.Servicos.Rows.Add(lObj)

            lObj = Nothing

            crServico.SetDataSource(dsRelServico)



            'sbBarraMensagem("GERANDO DOCUMENTO, AGURADE...")

            lobjFrmVisualizador.crVisualizador.ReportSource = crServico

            '& "\" & mObjCliente.Veiculo.Placa & "_" & objInfoServicos.Quilometragem & "KM" & ".PDF"


            'Dim CaminhoArquivoCompleto As String = CaminhoArquivo & "\" & strTipoServico & "_" & Date.Now & ".PDF"
            ''Dim CaminhoArquivoCompleto As String = CaminhoArquivo & "\" & lblPlaca.Text & "_" & objInfoServicos.Quilometragem & "KM" & ".PDF"
            'If Not Directory.Exists(CaminhoArquivo) Then
            '    Directory.CreateDirectory(CaminhoArquivo)

            'End If

            crServico.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, CaminhoArquivoCompleto)


            Application.UseWaitCursor = False
            Application.DoEvents()

            'lobjFrmVisualizador.ShowDialog()
            crServico.PrintToPrinter(1, 0, 0, 1)

            'Me.lblAlerta.Text = String.Empty
            'Me.lblAlerta.Refresh()
            'If MessageBox.Show("Deseja enviar o relatório de manutenção por email?", "Enviar Email?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            '    'sbBarraMensagem("ENVIANDO EMAIL, AGURADE...")
            '    Me.lblAlerta.Text = "AGUARDE, ENVIANDO EMAIL..."
            '    Me.lblAlerta.Refresh()
            '    Application.UseWaitCursor = True
            '    Application.DoEvents()
            '    EnviarEmail(CaminhoArquivoCompleto)
            'End If

            Limpar()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            'Me.lblAlerta.Text = String.Empty
        End Try

    End Sub


    'Private Sub ExibirProgresso()
    '    mFrmSplash = New frmProgresso()
    '    mFrmSplash.prgSplash.Visible = False
    '    mFrmSplash.prgSplash.Visible = True
    '    mFrmSplash.Show(Me)
    '    mFrmSplash.BringToFront()
    '    mFrmSplash.Cursor = Cursors.WaitCursor

    '    mFrmSplash.Atualizar("Aguarde...")
    '    'mFrmSplash.prgSplash.BeginWait()

    'End Sub

    'Private Sub FecharProgresso()
    '    If Not IsNothing(mFrmSplash) Then
    '        'mFrmSplash.prgSplash.EndWait()
    '        ' mFrmSplash.prgSplash.EndInvoke()
    '        mFrmSplash.Close()
    '        mFrmSplash.Dispose()
    '        mFrmSplash = Nothing
    '    End If
    '    'btnSair.Enabled = True
    '    'btnOK.Enabled = True
    'End Sub


    Public Sub sbBarraMensagem(ByVal pMensagem As String)
        Dim frm As frmMensagem
        'Mudando o cursor
        If pMensagem Is Nothing Then
            Cursor.Current = Cursors.Default
        Else
            Cursor.Current = Cursors.WaitCursor
        End If

        'Atribuindo a Mensagem
        frm = New frmMensagem(pMensagem)
        frm.ShowDialog()
        'Me.txtGerando.Text = pMensagem
        My.Application.DoEvents()

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

        assuntoMensagem = "Ordem de serviço Hokkaido Auto Honda."
        conteudoMensagem = "Agradecemos pela sua preferência e confiança, " & vbCrLf & " " &
                            "Segue em anexo a ordem de serviço realizado em seu veículo. " & vbCrLf & " " &
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
            'Me.lblAlerta.Text = "E-mail enviado com sucesso !"
            Application.UseWaitCursor = False
            Application.DoEvents()
            MessageBox.Show("E-mail enviado com sucesso !")
        Catch ex As Exception
            MessageBox.Show("Ocorreram problemas no envio do e-mail. Erro = " & ex.Message)
        End Try
        'excluímos o objeto de e-mail da memória
        objEmail.Dispose()
        'anexo.Dispose();
    End Sub
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()
    End Sub

    Private Sub Limpar()
        'lblPlaca.Text = String.Empty
        'lblVeiculo.Text = String.Empty
        'lblNomeCliente.Text = String.Empty
        'lblModelo.Text = String.Empty
        'lblAno.Text = String.Empty
        txtItensManutencao.Text = String.Empty
        txtKm.Text = String.Empty
        txtMaodeObra.Text = String.Empty
        txtObs.Text = String.Empty
        txtKmAtual.Text = String.Empty

    End Sub

    Private Sub rdbServico_CheckedChanged(sender As Object, e As EventArgs) Handles rdbServico.CheckedChanged
        If rdbServico.Checked Then
            Label1.Enabled = False
            txtKm.Enabled = False
            Label2.Enabled = False
        End If
    End Sub

    Private Sub rdbRevisao_CheckedChanged(sender As Object, e As EventArgs) Handles rdbRevisao.CheckedChanged
        Label1.Enabled = True
        txtKm.Enabled = True
        Label2.Enabled = True
    End Sub

    Private Sub txtKmAtual_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub

    Private Sub txtMaodeObra_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub

    Private Sub cmbVeiculos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVeiculos.SelectedIndexChanged

        Dim objVeiculo As VeiculoINFO

        Try
            objVeiculo = New VeiculoINFO
            objVeiculo = cmbVeiculos.SelectedItem

            lblVeiculo.Text = objVeiculo.Marca
            lblModelo.Text = objVeiculo.Modelo
            lblAno.Text = objVeiculo.Ano
            lblPlaca.Text = objVeiculo.Placa

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub TxtKmAtual_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtKmAtual.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub

    Private Sub TxtMaodeObra_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtMaodeObra.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub

    Private Sub TxtKm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKm.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub
End Class