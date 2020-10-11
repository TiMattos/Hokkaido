Imports UTIL
Imports Tranform.Try

Public Class frmOrcamento
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        ImprimirRelatorio()

    End Sub

    Private Sub ImprimirRelatorio()
        Dim dsRelOracamento As New dsOrcamento
        Dim crRelOrcamento As crOrcamento = Nothing
        Dim obj() As Object = Nothing
        Dim lobjFrmVisualizador As New frmViewer
        Dim cr As crOrcamento = Nothing

        Try
            crRelOrcamento = New crOrcamento
            obj = New Object(3) {}
            obj.SetValue(txtCliente.Text, 2)
            obj.SetValue(txtServicos.Text, 0)
            obj.SetValue(IIf(txtPecas.Text = String.Empty, 0, txtPecas.Text), 3)
            obj.SetValue(IIf(txtMo.Text = String.Empty, 0, txtMo.Text), 1)

            dsRelOracamento.orcamento.Rows.Add(obj)
            obj = Nothing
            crRelOrcamento.SetDataSource(dsRelOracamento)
            lobjFrmVisualizador.crVisualizador.ReportSource = crRelOrcamento
            lobjFrmVisualizador.ShowDialog()
            MessageBox.Show("Orçamento gerado com sucesso!")
            Limpar()


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()
    End Sub

    Private Sub Limpar()
        txtCliente.Text = String.Empty
        txtMo.Text = String.Empty
        txtPecas.Text = String.Empty
        txtServicos.Text = String.Empty

    End Sub

    Private Sub TxtPecas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPecas.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub

    Private Sub TxtMo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMo.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub

    Private Sub FrmOrcamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim calc As New Tranform.Try.Calculator
        calc.Add(36, 296)
        Me.Refresh()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        System.Diagnostics.Process.Start("calc.exe")
    End Sub
End Class