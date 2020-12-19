Imports System.Globalization
Imports BLL
Imports INFO
Public Class frmExibeBalancoFinanceiro
    Dim mListServicos As New List(Of ServicoINFO)
    Private Sub frmExibeBalancoFinanceiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bll As New BLLServicos
        Dim PrimeiroDiaDoAno, UltimoDiaDoAno As Date
        Dim strPrimeiroDiaDoAno, strUltimoDiaDoAno, strPrimeiroDiaDoAnoAnterior, strUltimoDiaDoAnoAnterior As String
        Dim lLstServicosAnoAnterior, lLstServicosAnoCorrente As List(Of ServicoINFO)

        tmpDataInicio.Value = Date.Now
        tmpDataFim.Value = Date.Now

        PrimeiroDiaDoAno = "01/01/" & Date.Now.AddYears(-1).Year
        UltimoDiaDoAno = "30/12/" & Date.Now.AddYears(-1).Year


        strPrimeiroDiaDoAno = "01/01/" & Date.Now.Year
        strUltimoDiaDoAno = "12/30/" & Date.Now.Year
        'strPrimeiroDiaDoAnoAnterior = "01/01/" & Date.Now.AddYears(-1).Year.ToString("MM/dd/yyyy", CultureInfo.CreateSpecificCulture("en-US"))
        'strUltimoDiaDoAnoAnterior = "30/12/" & Date.Now.AddYears(-1).Year.ToString("MM/dd/yyyy", CultureInfo.CreateSpecificCulture("en-US"))
        strPrimeiroDiaDoAnoAnterior = "01/01/" & Date.Now.AddYears(-1).Year
        strUltimoDiaDoAnoAnterior = "12/30/" & Date.Now.AddYears(-1).Year

        Try
            lLstServicosAnoAnterior = bll.busObterServicosPorData(strPrimeiroDiaDoAnoAnterior, strUltimoDiaDoAnoAnterior)
            lLstServicosAnoCorrente = bll.busObterServicosPorData(strPrimeiroDiaDoAno, strUltimoDiaDoAno)

            Chart1.ChartAreas(0).AxisX.Interval = 1

            Chart1.Series("Passado").Points.AddXY("JANEIRO", Aggregate servico In lLstServicosAnoAnterior
                           Where servico.DataServico.Month = 1
                           Into Sum(CInt(servico.MaodeObra.Replace("R$", "")) + CInt(servico.ValorPecas.Replace("R$", ""))))

            Chart1.Series("Atual").Points.AddXY("JANEIRO", Aggregate servico In lLstServicosAnoCorrente
                           Where servico.DataServico.Month = 1
                           Into Sum(CInt(servico.MaodeObra.Replace("R$", "")) + CInt(servico.ValorPecas.Replace("R$", ""))))

            Chart1.Series("Passado").Points.AddXY("FEVEREIRO", Aggregate servico In lLstServicosAnoAnterior
                           Where servico.DataServico.Month = 2
                           Into Sum(CInt(servico.MaodeObra.Replace("R$", "")) + CInt(servico.ValorPecas.Replace("R$", ""))))

            Chart1.Series("Atual").Points.AddXY("FEVEREIRO", Aggregate servico In lLstServicosAnoCorrente
                           Where servico.DataServico.Month = 2
                           Into Sum(CInt(servico.MaodeObra.Replace("R$", "")) + CInt(servico.ValorPecas.Replace("R$", ""))))

            Chart1.Series("Passado").Points.AddXY("MARÇO", Aggregate servico In lLstServicosAnoAnterior
                           Where servico.DataServico.Month = 3
                           Into Sum(CInt(servico.MaodeObra.Replace("R$", "")) + CInt(servico.ValorPecas.Replace("R$", ""))))

            Chart1.Series("Atual").Points.AddXY("MARÇO", Aggregate servico In lLstServicosAnoCorrente
                           Where servico.DataServico.Month = 3
                           Into Sum(CInt(servico.MaodeObra.Replace("R$", "")) + CInt(servico.ValorPecas.Replace("R$", ""))))

            Chart1.Series("Passado").Points.AddXY("ABRIL", Aggregate servico In lLstServicosAnoAnterior
                           Where servico.DataServico.Month = 4
                           Into Sum(CInt(servico.MaodeObra.Replace("R$", "")) + CInt(servico.ValorPecas.Replace("R$", ""))))

            Chart1.Series("Atual").Points.AddXY("ABRIL", Aggregate servico In lLstServicosAnoCorrente
                           Where servico.DataServico.Month = 4
                           Into Sum(CInt(servico.MaodeObra.Replace("R$", "")) + CInt(servico.ValorPecas.Replace("R$", ""))))

            Chart1.Series("Passado").Points.AddXY("MAIO", Aggregate servico In lLstServicosAnoAnterior
                           Where servico.DataServico.Month = 5
                           Into Sum(CInt(servico.MaodeObra.Replace("R$", "")) + CInt(servico.ValorPecas.Replace("R$", ""))))

            Chart1.Series("Atual").Points.AddXY("MAIO", Aggregate servico In lLstServicosAnoCorrente
                           Where servico.DataServico.Month = 5
                           Into Sum(CInt(servico.MaodeObra.Replace("R$", "")) + CInt(servico.ValorPecas.Replace("R$", ""))))

            Chart1.Series("Passado").Points.AddXY("JUNHO", Aggregate servico In lLstServicosAnoAnterior
                           Where servico.DataServico.Month = 6
                           Into Sum(CInt(servico.MaodeObra.Replace("R$", "")) + CInt(servico.ValorPecas.Replace("R$", ""))))

            Chart1.Series("Atual").Points.AddXY("JUNHO", Aggregate servico In lLstServicosAnoCorrente
                           Where servico.DataServico.Month = 6
                           Into Sum(CInt(servico.MaodeObra.Replace("R$", "")) + CInt(servico.ValorPecas.Replace("R$", ""))))

            Chart1.Series("Passado").Points.AddXY("JULHO", Aggregate servico In lLstServicosAnoAnterior
                           Where servico.DataServico.Month = 7
                           Into Sum(CInt(servico.MaodeObra.Replace("R$", "")) + CInt(servico.ValorPecas.Replace("R$", ""))))

            Chart1.Series("Atual").Points.AddXY("JULHO", Aggregate servico In lLstServicosAnoCorrente
                           Where servico.DataServico.Month = 7
                           Into Sum(CInt(servico.MaodeObra.Replace("R$", "")) + CInt(servico.ValorPecas.Replace("R$", ""))))

            Chart1.Series("Passado").Points.AddXY("AGOSTO", Aggregate servico In lLstServicosAnoAnterior
                           Where servico.DataServico.Month = 8
                           Into Sum(CInt(servico.MaodeObra.Replace("R$", "")) + CInt(servico.ValorPecas.Replace("R$", ""))))

            Chart1.Series("Atual").Points.AddXY("AGOSTO", Aggregate servico In lLstServicosAnoCorrente
                           Where servico.DataServico.Month = 8
                           Into Sum(CInt(servico.MaodeObra.Replace("R$", "")) + CInt(servico.ValorPecas.Replace("R$", ""))))

            Chart1.Series("Passado").Points.AddXY("SETEMBRO", Aggregate servico In lLstServicosAnoAnterior
                           Where servico.DataServico.Month = 9
                           Into Sum(CInt(servico.MaodeObra.Replace("R$", "")) + CInt(servico.ValorPecas.Replace("R$", ""))))

            Chart1.Series("Atual").Points.AddXY("SETEMBRO", Aggregate servico In lLstServicosAnoCorrente
                           Where servico.DataServico.Month = 9
                           Into Sum(CInt(servico.MaodeObra.Replace("R$", "")) + CInt(servico.ValorPecas.Replace("R$", ""))))

            Chart1.Series("Passado").Points.AddXY("OUTUBRO", Aggregate servico In lLstServicosAnoAnterior
                           Where servico.DataServico.Month = 10
                           Into Sum(CInt(servico.MaodeObra.Replace("R$", "")) + CInt(servico.ValorPecas.Replace("R$", ""))))

            Chart1.Series("Atual").Points.AddXY("OUTUBRO", Aggregate servico In lLstServicosAnoCorrente
                           Where servico.DataServico.Month = 10
                           Into Sum(CInt(servico.MaodeObra.Replace("R$", "")) + CInt(servico.ValorPecas.Replace("R$", ""))))

            Chart1.Series("Passado").Points.AddXY("NOVEMBRO", Aggregate servico In lLstServicosAnoAnterior
                           Where servico.DataServico.Month = 11
                           Into Sum(CInt(servico.MaodeObra.Replace("R$", "")) + CInt(servico.ValorPecas.Replace("R$", ""))))

            Chart1.Series("Atual").Points.AddXY("NOVEMBRO", Aggregate servico In lLstServicosAnoCorrente
                           Where servico.DataServico.Month = 11
                           Into Sum(CInt(servico.MaodeObra.Replace("R$", "")) + CInt(servico.ValorPecas.Replace("R$", ""))))

            Chart1.Series("Passado").Points.AddXY("DEZEMBRO", Aggregate servico In lLstServicosAnoAnterior
                           Where servico.DataServico.Month = 12
                           Into Sum(CInt(servico.MaodeObra.Replace("R$", "")) + CInt(servico.ValorPecas.Replace("R$", ""))))

            Chart1.Series("Atual").Points.AddXY("DEZEMBRO", Aggregate servico In lLstServicosAnoCorrente
                          Where servico.DataServico.Month = 12
                          Into Sum(CInt(servico.MaodeObra.Replace("R$", "")) + CInt(servico.ValorPecas.Replace("R$", ""))))


        Catch ex As Exception

        End Try
    End Sub
    Private Sub CarregarTela()

        lblTexto1.Text = "De"
        lblTexto2.Text = "Até"

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
                Return False
            End If
            If tmpDataInicio.Value = Date.MinValue Then
                MessageBox.Show("Data Inválida")
                Return False
            End If
            If tmpDataFim.Value < tmpDataInicio.Value Then
                MessageBox.Show("Data final menor que a data inicial.")
                Return False
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

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub
End Class