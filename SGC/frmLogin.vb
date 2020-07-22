Imports BLL
Imports INFO
Public Class frmLogin
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ValidaLogin()
    End Sub

    Private Sub ValidaLogin()
        If txtUsuario.Text = String.Empty Then
            MessageBox.Show("Informe o usuário.")
            Exit Sub
        End If
        If txtSenha.Text = String.Empty Then
            MessageBox.Show("Informe a senha.")
            Exit Sub
        End If
        VerificaLogin()
    End Sub

    Private Sub VerificaLogin()
        Dim objBll As BLLUsuario
        Dim objUsuario As UsuarioINFO

        Try
            objBll = New BLLUsuario
            objUsuario = New UsuarioINFO

            objUsuario = objBll.busObterUsuario(txtUsuario.Text.Trim.ToUpper)

            If IsNothing(objUsuario) Then
                MessageBox.Show("Usuário não encontrado.")
                Exit Sub
            End If

            If txtSenha.Text.Trim.ToUpper <> objUsuario.Senha.Trim.ToUpper Then
                MessageBox.Show("Senha incorreta.")
                Exit Sub
            End If

            Dim frm As frmPrincipal

            frm = New frmPrincipal
            Me.Hide()
            frm.ShowDialog()

            frm.Dispose()

        Catch ex As Exception
            Throw ex
        Finally
            Me.Dispose()
        End Try
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Activated
        Me.Show()
        txtUsuario.Focus()
    End Sub

    Private Sub txtSenha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSenha.KeyPress
        Try
            If e.KeyChar = Chr(Keys.Enter) Then
                ValidaLogin()
            End If
        Catch ex As Exception
            Throw ex

        End Try

    End Sub
End Class