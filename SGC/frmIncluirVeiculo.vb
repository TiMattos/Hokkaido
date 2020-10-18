Imports BLL
Imports INFO


Public Class frmIncluirVeiculo
    Private mIDCliente As Integer

    Sub New(ByVal objCliente As ClienteINFO)
        mIDCliente = objCliente.ID
        InitializeComponent()
    End Sub

    Private Function ValidarCampos() As Boolean
        Try
            If txtAno.Text = String.Empty Then
                MessageBox.Show("Informe o ano do veículo.")
                Return False
            End If
            If txtPlaca.Text = String.Empty Then
                MessageBox.Show("Informe a placa do veículo.")
                Return False
            End If
            If txtVeiculo.Text = String.Empty Then
                MessageBox.Show("Informe o veículo.")
                Return False
            End If
            If txtModelo.Text = String.Empty Then
                MessageBox.Show("Informe o modelo do veículo.")
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub IncluiVeiculo()
        Dim objBLL As BLLVeiculo
        Dim objInfoCliente As ClienteINFO

        Try
            objInfoCliente = New ClienteINFO
            objInfoCliente.ID = mIDCliente
            With objInfoCliente
                .Veiculo = New VeiculoINFO
                .Veiculo.Ano = txtAno.Text.ToUpper
                .Veiculo.Modelo = txtModelo.Text.ToUpper
                .Veiculo.Placa = txtPlaca.Text.ToUpper
                .Veiculo.Marca = txtVeiculo.Text.ToUpper
            End With

            objBLL = New BLLVeiculo
            If objBLL.dbIncluirVeiculo(objInfoCliente) Then
                MessageBox.Show("Veiculo incluído com sucesso.")
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            If ValidarCampos() Then
                IncluiVeiculo()
            End If
            LimparCampos()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LimparCampos()
        txtAno.Text = String.Empty
        txtModelo.Text = String.Empty
        txtPlaca.Text = String.Empty
        txtVeiculo.Text = String.Empty
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub


End Class