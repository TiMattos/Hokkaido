Imports BLL
Public Class frmExibeBalancoFinanceiro
    Private Sub frmExibeBalancoFinanceiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Dim bll As New BLLServicos
        Try
            If Validar() Then
                bll.busObterServicosPorData(tmpDataInicio.Value, tmpDataFim.Value)
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
End Class