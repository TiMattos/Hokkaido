Imports INFO
Imports BLL
Public Class frmConfiguracao
    Dim mStrSenhaEmail As String = String.Empty

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            If ValidaCampos() Then

                AlteraSenha()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function ValidaCampos() As Boolean

        Try
            If txtSenha.Text = String.Empty Then
                MessageBox.Show("CAMPO NOVA SENHA OBRIGATÓRIO.")
                Return False
            End If

            If txtConfirmaSenha.Text = String.Empty Then
                MessageBox.Show("CAMPO CONFIRMA SENHA OBRIGATÓRIO.")
                Return False
            End If

            If txtSenha.Text <> txtConfirmaSenha.Text Then
                MessageBox.Show("CAMPOS NOVA SENHA E CONFIRMA SENHA NÃO SÃO IGUAIS.")
                Return False
            End If
            mStrSenhaEmail = txtSenha.Text.Trim
            Return True
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Private Sub AlteraSenha()
        Dim objBLL As BLLConfiguracao
        Try
            objBLL = New BLLConfiguracao

            If objBLL.busAlterarSenhaEmail(mStrSenhaEmail) Then
                MessageBox.Show("Senha alterada com sucesso.")
                ObterSenha()
                Limpar()
            Else
                MessageBox.Show("Ocorreu um erro na alteração de senha, informe ao Thiago.")
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub Limpar()
        txtSenha.Text = String.Empty
        txtConfirmaSenha.Text = String.Empty
    End Sub

    Private Sub txtSenha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSenha.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        If KeyAscii = 32 Then

            e.Handled = True

        End If
    End Sub

    Private Sub txtConfirmaSenha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConfirmaSenha.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        If KeyAscii = 32 Then

            e.Handled = True

        End If
    End Sub

    Private Sub frmConfiguracao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObterSenha()
    End Sub

    Private Sub ObterSenha()

        Dim objbll As BLLConfiguracao
        Dim objConfiguracao As ConfiguracaoINFO


        Try

            objbll = New BLLConfiguracao
            objConfiguracao = New ConfiguracaoINFO

            objConfiguracao = objbll.busObterConfiguracoes()

            lblSenhaAtual.Text = objConfiguracao.SenhaEmail

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class