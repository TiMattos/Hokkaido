Public Class frmOrcamento
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        ImprimirRelatorio()

    End Sub

    Private Sub ImprimirRelatorio()
        Dim dsRelOracamento As New dsOrcamento
        Dim crRelOrcamento As crOrcamento = Nothing
        Dim obj() As Object = Nothing
        Dim lobjFrmVisualizador As New frmViewer
        Try
            crRelOrcamento = New crOrcamento
            obj = New Object(3) {}
            obj.SetValue(txtCliente.Text, 2)
            obj.SetValue(txtServicos.Text, 0)
            obj.SetValue(txtPecas.Text, 3)
            obj.SetValue(txtMo.Text, 1)

            dsRelOracamento.orcamento.Rows.Add(obj)
            obj = Nothing
            crRelOrcamento.SetDataSource(dsRelOracamento)
            lobjFrmVisualizador.crVisualizador.ReportSource = crRelOrcamento

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class