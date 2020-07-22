Imports INFO
Imports BLL

Public Class frmBuscarClientes
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            BuscarCliente()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub BuscarCliente()
        Dim objBll As BLLCLientes
        Dim objLstClientes As List(Of ClienteINFO)


        Try
            grdCliente.DataSource = Nothing


            objBll = New BLLCLientes
            objLstClientes = New List(Of ClienteINFO)

            If Not txtFiltroCliente.Text = String.Empty Then
                objLstClientes = objBll.busObterCliente(txtFiltroCliente.Text.Trim.ToUpper, cmbFiltroCliente.SelectedItem)
                If Not IsNothing(objLstClientes) AndAlso objLstClientes.Count > 0 Then
                    HabilitaBotoes(True)
                    grdCliente.AutoGenerateColumns = False
                    grdCliente.DataSource = objLstClientes
                Else
                    HabilitaBotoes(False)
                    MessageBox.Show("Nenhum registro encontrado para o filtro informado.")
                    txtFiltroCliente.Text = String.Empty
                End If

            Else
                MessageBox.Show("Infome o Filtro.")
                Me.txtFiltroCliente.Focus()

                HabilitaBotoes(False)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub grdCliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdCliente.CellContentClick

        Dim ID As Integer
        'If btnVisualizar.Selected Then
        '    ID = grdCliente.CurrentRow.Cells(0).Value
        'End If
        Dim frm As frmExibeDadosCadastro
        Dim frm2 As frmServicos
        Dim frm3 As frmHistoricoRevisao
        Dim frm4 As frmAgendamento
        Dim objBLL As BLLCLientes
        'Dim objBllServico As BLLServicos

        Try


            If e.RowIndex >= 0 AndAlso e.ColumnIndex = 4 Then
                With DirectCast(grdCliente(e.ColumnIndex, e.RowIndex), DataGridViewButtonCell)
                    If .Value Is Nothing Then
                        ID = grdCliente.CurrentRow.Cells(0).Value
                        objBLL = New BLLCLientes
                        frm = New frmExibeDadosCadastro(objBLL.busObterClientePorID(ID))
                        frm.ShowDialog()
                        frm.Dispose()

                    Else

                    End If
                End With

            End If

            If e.RowIndex >= 0 AndAlso e.ColumnIndex = 5 Then
                With DirectCast(grdCliente(e.ColumnIndex, e.RowIndex), DataGridViewButtonCell)
                    If .Value Is Nothing Then
                        ID = grdCliente.CurrentRow.Cells(0).Value
                        objBLL = New BLLCLientes
                        frm2 = New frmServicos(objBLL.busObterClientePorID(ID))
                        frm2.ShowDialog()
                        frm2.Dispose()

                    Else

                    End If
                End With

            End If

            If e.RowIndex >= 0 AndAlso e.ColumnIndex = 6 Then
                With DirectCast(grdCliente(e.ColumnIndex, e.RowIndex), DataGridViewButtonCell)
                    If .Value Is Nothing Then
                        ID = grdCliente.CurrentRow.Cells(0).Value

                        objBLL = New BLLCLientes
                        frm3 = New frmHistoricoRevisao(objBLL.busObterClientePorID(ID))
                        frm3.ShowDialog()
                        frm3.Dispose()
                    End If
                End With
            End If

            If e.RowIndex >= 0 AndAlso e.ColumnIndex = 7 Then
                With DirectCast(grdCliente(e.ColumnIndex, e.RowIndex), DataGridViewButtonCell)
                    If .Value Is Nothing Then
                        ID = grdCliente.CurrentRow.Cells(0).Value

                        objBLL = New BLLCLientes
                        frm4 = New frmAgendamento(objBLL.busObterClientePorID(ID))
                        frm4.ShowDialog()
                        frm4.Dispose()
                    End If
                End With
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Sub HabilitaBotoes(ByVal Habilita As Boolean)
        btnVisualizarCad.Enabled = Habilita
        btnAgendaServico.Enabled = Habilita
        btnHistoricoRevisao.Enabled = Habilita
        btnRealizarServico.Enabled = Habilita
    End Sub

    Private Sub frmBuscarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmbFiltroCliente.SelectedIndex = 1
        Me.txtFiltroCliente.Focus()

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnVisualizarCad_Click(sender As Object, e As EventArgs) Handles btnVisualizarCad.Click
        Dim objBLL As BLLCLientes
        Dim frm As frmExibeDadosCadastro
        Dim id As Integer

        id = grdCliente.CurrentRow.Cells(0).Value
        objBLL = New BLLCLientes
        frm = New frmExibeDadosCadastro(objBLL.busObterClientePorID(id))
        frm.ShowDialog()
        frm.Dispose()


    End Sub

    Private Sub btnRealizarServico_Click(sender As Object, e As EventArgs) Handles btnRealizarServico.Click
        Dim objBLL As BLLCLientes
        Dim id As Integer
        Dim frm2 As frmServicos

        id = grdCliente.CurrentRow.Cells(0).Value
        objBLL = New BLLCLientes
        frm2 = New frmServicos(objBLL.busObterClientePorID(id))
        frm2.ShowDialog()
        frm2.Dispose()

    End Sub

    Private Sub btnHistoricoRevisao_Click(sender As Object, e As EventArgs) Handles btnHistoricoRevisao.Click
        Dim id As Integer
        Dim objBLL As BLLCLientes
        Dim frm3 As frmHistoricoRevisao

        id = grdCliente.CurrentRow.Cells(0).Value

        objBLL = New BLLCLientes
        frm3 = New frmHistoricoRevisao(objBLL.busObterClientePorID(id))
        frm3.ShowDialog()
        frm3.Dispose()
    End Sub

    Private Sub btnAgendaServico_Click(sender As Object, e As EventArgs) Handles btnAgendaServico.Click
        Dim id As Integer
        Dim objBLL As BLLCLientes
        Dim frm4 As frmAgendamento

        id = grdCliente.CurrentRow.Cells(0).Value

        objBLL = New BLLCLientes
        frm4 = New frmAgendamento(objBLL.busObterClientePorID(id))
        frm4.ShowDialog()
        frm4.Dispose()
    End Sub
End Class