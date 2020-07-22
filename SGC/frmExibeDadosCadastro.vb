Imports INFO
Imports BLL
Imports UTIL
Imports System.IO

Public Class frmExibeDadosCadastro
    Dim mBolHabilitaCampos As Boolean = False
    Dim mObjCliente As New ClienteINFO
    Dim mObjListaVeiculos As New List(Of VeiculoINFO)
    Dim mintRegistroAtual As Integer

    Private Sub frmExibeDadosCadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TratarNavegacao()
        CarregaTela(mObjCliente)
    End Sub

    Sub New(ByVal objCliente As ClienteINFO)
        mObjCliente = objCliente
        mObjListaVeiculos = objCliente.ListaVeiculos
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Public Sub CarregaTela(ByVal pObjCliente As ClienteINFO)

        Try
            If Not IsNothing(pObjCliente) Then

                If Not pObjCliente.Nome1 = String.Empty Then
                    'lblNome.Text = pObjCliente.Nome1
                    txtNome.Text = pObjCliente.Nome1
                Else
                    ' lblNome.Text = String.Empty
                    txtNome.Text = String.Empty
                End If

                If Not pObjCliente.Endereco = String.Empty Then
                    'lblEndereco.Text = pObjCliente.Endereco
                    txtEndereco.Text = pObjCliente.Endereco

                Else
                    'lblEndereco.Text = String.Empty 
                    txtEndereco.Text = String.Empty
                End If
                If Not pObjCliente.Complemento = String.Empty Then
                    'lblComplemento.Text = pObjCliente.Complemento
                    txtComplemento.Text = pObjCliente.Complemento
                Else
                    'lblComplemento.Text = String.Empty
                    txtComplemento.Text = String.Empty
                End If

                If Not pObjCliente.Bairro = String.Empty Then
                    'lblBairro.Text = pObjCliente.Bairro
                    txtBairro.Text = pObjCliente.Bairro
                Else
                    'lblBairro.Text = String.Empty
                    txtBairro.Text = String.Empty
                End If

                If Not pObjCliente.Telefone = Integer.MinValue Then
                    'lblTelefone.Text = pObjCliente.Telefone
                    txtTelefone.Text = pObjCliente.Telefone
                Else
                    'lblTelefone.Text = String.Empty
                    txtTelefone.Text = String.Empty
                End If

                If Not pObjCliente.Email = String.Empty Then
                    'lblEmail.Text = pObjCliente.Email.Trim
                    txtEmail.Text = pObjCliente.Email.Trim
                Else
                    'lblEmail.Text = String.Empty
                    txtEmail.Text = String.Empty
                End If


                If Not pObjCliente.ListaVeiculos(0).Marca = String.Empty Then
                    lblVeiculo.Text = pObjCliente.ListaVeiculos(0).Marca
                Else
                    lblVeiculo.Text = String.Empty
                End If
                If Not pObjCliente.ListaVeiculos(0).Modelo = String.Empty Then
                    lblModelo.Text = pObjCliente.ListaVeiculos(0).Modelo
                Else
                    lblModelo.Text = String.Empty
                End If

                If Not pObjCliente.ListaVeiculos(0).Ano = Integer.MinValue Then
                    lblAno.Text = pObjCliente.ListaVeiculos(0).Ano
                Else
                    lblAno.Text = String.Empty
                End If

                If Not pObjCliente.ListaVeiculos(0).Placa = String.Empty Then
                    lblPlaca.Text = pObjCliente.ListaVeiculos(0).Placa
                Else
                    lblPlaca.Text = String.Empty
                End If
                If Not IsNothing(pObjCliente.ListaVeiculos) And pObjCliente.ListaVeiculos.Count > 0 Then

                    'btnProximoVeiculo.Enabled = True
                    'btnVoltarVeiculo.Enabled = True
                    Dim lObjVeiculo As New VeiculoINFO
                    lObjVeiculo = pObjCliente.ListaVeiculos(mintRegistroAtual)
                    PopulaVeiculo(lObjVeiculo)


                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click

        If mBolHabilitaCampos = False Then

            txtNome.Enabled = True
            txtEndereco.Enabled = True
            txtTelefone.Enabled = True
            txtEmail.Enabled = True
            txtBairro.Enabled = True
            txtComplemento.Enabled = True
            btnSalvar.Enabled = True
            mBolHabilitaCampos = True
            btnAlterar.Text = "Desabilitar campos"
            btnAlterar.TextAlign = ContentAlignment.MiddleRight

        Else
            txtNome.Enabled = False
            txtEndereco.Enabled = False
            txtTelefone.Enabled = False
            txtEmail.Enabled = False
            txtBairro.Enabled = False
            txtComplemento.Enabled = False
            btnSalvar.Enabled = False
            mBolHabilitaCampos = False
            btnAlterar.Text = "Habilitar campos"
            btnAlterar.TextAlign = ContentAlignment.MiddleRight

        End If



    End Sub

    Private Sub DesabilitaTela()
        txtNome.Enabled = False
        txtEndereco.Enabled = False
        txtTelefone.Enabled = False
        txtEmail.Enabled = False
        txtBairro.Enabled = False
        txtComplemento.Enabled = False
        btnSalvar.Enabled = False
        mBolHabilitaCampos = False
        btnAlterar.Text = "Habilitar campos"
        btnAlterar.TextAlign = ContentAlignment.MiddleRight
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim objInfo As ClienteINFO
        Dim objBll As BLLCLientes
        Try

            objInfo = New ClienteINFO

            objInfo.Nome1 = txtNome.Text.Trim
            objInfo.Endereco = txtEndereco.Text.Trim
            objInfo.Complemento = txtComplemento.Text.Trim
            objInfo.Bairro = txtBairro.Text.Trim
            objInfo.Telefone = txtTelefone.Text.Trim
            objInfo.Email = txtEmail.Text.Trim
            objInfo.ID = mObjCliente.ID
            objBll = New BLLCLientes

            If objBll.busAlterarCadastro(objInfo) Then
                MessageBox.Show("Cadastro alterado com sucesso.")
            End If

            DesabilitaTela()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnProximoVeiculo_Click(sender As Object, e As EventArgs) Handles btnProximoVeiculo.Click
        TrataRegistro(True)
    End Sub

    Private Sub TrataRegistro(ByVal pbolProximo As Boolean)
        Dim lObjveiculo As VeiculoINFO
        Dim lintRegistro As Integer

        If pbolProximo Then
            lintRegistro = mintRegistroAtual + 1
        Else
            lintRegistro = mintRegistroAtual - 1
        End If

        If (lintRegistro) >= 0 Then
            If lintRegistro <= mObjListaVeiculos.Count - 1 Then

                mintRegistroAtual = lintRegistro

                lObjveiculo = mObjListaVeiculos(mintRegistroAtual)
                PopulaVeiculo(lObjveiculo)
                Me.lblRegistros.Text = "Registro " & mintRegistroAtual + 1 & " de " & mObjListaVeiculos.Count
            End If
        End If

    End Sub

    Private Sub PopulaVeiculo(ByVal pObjVeiculo As VeiculoINFO)
        If Not pObjVeiculo.Marca = String.Empty Then
            lblVeiculo.Text = pObjVeiculo.Marca
        Else
            lblVeiculo.Text = String.Empty
        End If
        If Not pObjVeiculo.Modelo = String.Empty Then
            lblModelo.Text = pObjVeiculo.Modelo
        Else
            lblModelo.Text = String.Empty
        End If

        If Not pObjVeiculo.Ano = Integer.MinValue Then
            lblAno.Text = pObjVeiculo.Ano
        Else
            lblAno.Text = String.Empty
        End If

        If Not pObjVeiculo.Placa = String.Empty Then
            lblPlaca.Text = pObjVeiculo.Placa
        Else
            lblPlaca.Text = String.Empty
        End If
    End Sub

    Private Sub TratarNavegacao()
        Dim lbolVisivel As Boolean = False

        If (Not IsNothing(mObjListaVeiculos) AndAlso mObjListaVeiculos.Count > 1) Then
            Me.lblRegistros.Text = "Registro 1 de " & mObjListaVeiculos.Count
            mintRegistroAtual = 0
            lbolVisivel = True
        End If

        Me.lblRegistros.Visible = lbolVisivel
        Me.btnProximoVeiculo.Visible = lbolVisivel
        Me.btnVoltarVeiculo.Visible = lbolVisivel

    End Sub

    Private Sub btnVoltarVeiculo_Click(sender As Object, e As EventArgs) Handles btnVoltarVeiculo.Click
        TrataRegistro(False)
    End Sub

    Private Sub btnAdicionarVeiculo_Click(sender As Object, e As EventArgs) Handles btnAdicionarVeiculo.Click
        Dim frm As frmIncluirVeiculo

        Try
            frm = New frmIncluirVeiculo(mObjCliente)
            frm.ShowDialog()

            AtualizarCadastro()
            Me.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub AtualizarCadastro()
        Dim objBLL As BLLCLientes
        Dim id As Integer
        Dim objCliente As ClienteINFO

        objCliente = New ClienteINFO

        id = mObjCliente.ID
        objBLL = New BLLCLientes
        objCliente = objBLL.busObterClientePorID(id)

        CarregaTela(objCliente)

    End Sub
End Class