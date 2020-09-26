Imports BLL
Imports INFO
Imports System.IO
Imports UTIL

Public Class frmCadastrarCliente

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim objBllCliente As BLLCLientes
        Dim objInfoCliente As ClienteINFO


        Try

            objBllCliente = New BLLCLientes
            objInfoCliente = New ClienteINFO

            If ValidaCadastro() Then

                objInfoCliente.Nome1 = txtNome.Text.Trim.ToUpper

                objInfoCliente.Telefone = txtTelefone.Text.Trim
                objInfoCliente.Endereco = txtEndereco.Text.Trim.ToUpper
                objInfoCliente.Complemento = txtComplemento.Text.Trim.ToUpper
                objInfoCliente.Bairro = txtBairro.Text.Trim.ToUpper
                objInfoCliente.Email = txtEmail.Text.Trim.ToUpper


                objInfoCliente.Veiculo = New VeiculoINFO

                objInfoCliente.Veiculo.Modelo = txtModelo.Text.Trim.ToUpper
                objInfoCliente.Veiculo.Ano = txtAno.Text.Trim.ToUpper
                objInfoCliente.Veiculo.Marca = txtVeiculo.Text.Trim.ToUpper
                'objInfoCliente.Veiculo.Foto = Funcoes.ImageToArrayByte(pctFoto.Image)
                objInfoCliente.Veiculo.Placa = txtPlaca.Text.Trim.ToUpper
                If objBllCliente.busInserirCadastro(objInfoCliente) Then
                    MessageBox.Show("Cadastro realizado com sucesso.")
                    Limpar()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




    End Sub

    Private Sub Limpar()

        txtNome.Text = String.Empty
        txtBairro.Text = String.Empty
        txtComplemento.Text = String.Empty
        txtEndereco.Text = String.Empty
        txtModelo.Text = String.Empty
        txtAno.Text = String.Empty
        txtTelefone.Text = String.Empty
        txtVeiculo.Text = String.Empty
        txtEmail.Text = String.Empty
        txtPlaca.Text = String.Empty
    End Sub

    Private Function ValidaCadastro() As Boolean
        Try
            If txtNome.Text = String.Empty Then
                MessageBox.Show("Nome obrigatório.")
                Return False
            End If

            If txtEndereco.Text = String.Empty Then
                MessageBox.Show("Endereço obrigatório.")
                Return False
            End If

            If txtTelefone.Text = String.Empty Then
                MessageBox.Show("Telefone obrigatório.")
                Return False
            End If

            If txtVeiculo.Text = String.Empty Then
                MessageBox.Show("Veículo obrigatório.")
                Return False
            End If
            If txtModelo.Text = String.Empty Then
                MessageBox.Show("Modelo obrigatório.")
                Return False
            End If


            If txtAno.Text = String.Empty Then
                MessageBox.Show("Ano obrigatório.")
                Return False
            End If

            If txtPlaca.Text = String.Empty Then
                MessageBox.Show("Placa obrigatório.")
                Return False
            End If
            If txtEmail.Text = String.Empty Then
                MessageBox.Show("Email obrigatório")
                Return False
            End If
            Return True
        Catch ex As Exception

            Throw ex
        End Try

    End Function



    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnCarregarImagem_Click(sender As Object, e As EventArgs)
        Dim ImageAUsar As Image

        Using OFD As New OpenFileDialog With {.Filter = "Jpg (*.jpg)|*.jpg"}
            If OFD.ShowDialog = DialogResult.OK Then
                ImageAUsar = Image.FromFile(OFD.FileName)
                'pctFoto.Image = ImageAUsar
            End If
        End Using

    End Sub


    Private Sub txtAno_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub

    Private Sub txtTelefone_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub

    'Private Sub txtNome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNome.KeyPress
    '    Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

    '    KeyAscii = CShort(SoLETRAS(KeyAscii))

    '    If KeyAscii = 0 Then

    '        e.Handled = True

    '    End If
    'End Sub

    Private Sub txtVeiculo_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoLETRAS(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub

    Private Sub frmCadastrarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNome.Focus()
    End Sub


End Class