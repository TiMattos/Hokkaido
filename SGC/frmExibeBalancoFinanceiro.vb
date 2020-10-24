Imports System.Globalization
Imports BLL
Imports INFO
Public Class frmExibeBalancoFinanceiro
    Dim mListServicos As New List(Of ServicoINFO)
    Private Sub frmExibeBalancoFinanceiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub CarregarTela()
        rdbPeriodo.Checked = True
        lblTexto1.Text = "De"
        lblTexto2.Text = "Até"
        cmbMes.Visible = False
        cmbAno.Visible = False
    End Sub

    Private Sub BtnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Dim bll As New BLLServicos
        Dim strDataInicial, strDataFinal As String

        Try
            If Validar() Then
                strDataInicial = tmpDataInicio.Value.ToString("MM/dd/yyyy", CultureInfo.CreateSpecificCulture("en-US"))

                strDataFinal = tmpDataFim.Value.ToString("MM/dd/yyyy", CultureInfo.CreateSpecificCulture("en-US"))

                mListServicos = bll.busObterServicosPorData(strDataInicial, strDataFinal)

                RealizarLancamentos()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function Validar() As Boolean

        Try
            If tmpDataFim.Value = Date.MinValue Then
                MessageBox.Show("Data Inválida")
            End If
            If tmpDataInicio.Value = Date.MinValue Then
                MessageBox.Show("Data Inválida")
            End If
            If tmpDataFim.Value < tmpDataInicio.Value Then
                MessageBox.Show("Data final menor que a data inicial.")
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub RealizarLancamentos()
        Try
            grdResumo.DataSource = Nothing
            If Not IsNothing(mListServicos) Then
                lblValorMaoObra.Text = (Aggregate servico As ServicoINFO In mListServicos
                                           Where servico.MaodeObra IsNot Nothing
                                               Into Sum(CInt(servico.MaodeObra))).ToString("C")

                lblValorPecas.Text = (Aggregate servico As ServicoINFO In mListServicos
                                           Where servico.ValorPecas IsNot Nothing
                                               Into Sum(CInt(servico.ValorPecas))).ToString("C")

                lblValorGeral.Text = (CInt(lblValorMaoObra.Text) + CInt(lblValorPecas.Text)).ToString("C")

                grdResumo.AutoGenerateColumns = False
                grdResumo.DataSource = mListServicos


            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub RdbPeriodo_CheckedChanged(sender As Object, e As EventArgs) Handles rdbPeriodo.CheckedChanged
        If rdbPeriodo.Checked Then
            lblTexto1.Text = "De"
            lblTexto2.Text = "Até"
            cmbMes.Visible = False
            cmbAno.Visible = False

        End If

    End Sub
End Class