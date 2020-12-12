<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHistoricoRevisao
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistoricoRevisao))
        Me.grdRevisoesRealizados = New System.Windows.Forms.DataGridView()
        Me.dgvServicosRealizados = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewButtonColumn2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.lblAlerta = New System.Windows.Forms.Label()
        Me.btnEnviarEmail = New System.Windows.Forms.Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQuilometragem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Placa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataRevisao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnVisualizarRevisão = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnEditar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnExcluir = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnImprimirRevisao = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.grdRevisoesRealizados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvServicosRealizados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdRevisoesRealizados
        '
        Me.grdRevisoesRealizados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grdRevisoesRealizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRevisoesRealizados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.colQuilometragem, Me.Placa, Me.dataRevisao, Me.btnVisualizarRevisão, Me.btnEditar, Me.btnExcluir, Me.btnImprimirRevisao})
        Me.grdRevisoesRealizados.Location = New System.Drawing.Point(6, 19)
        Me.grdRevisoesRealizados.Name = "grdRevisoesRealizados"
        Me.grdRevisoesRealizados.RowHeadersVisible = False
        Me.grdRevisoesRealizados.Size = New System.Drawing.Size(598, 254)
        Me.grdRevisoesRealizados.TabIndex = 4
        '
        'dgvServicosRealizados
        '
        Me.dgvServicosRealizados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvServicosRealizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServicosRealizados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewButtonColumn1, Me.DataGridViewButtonColumn2})
        Me.dgvServicosRealizados.Location = New System.Drawing.Point(6, 19)
        Me.dgvServicosRealizados.Name = "dgvServicosRealizados"
        Me.dgvServicosRealizados.RowHeadersVisible = False
        Me.dgvServicosRealizados.Size = New System.Drawing.Size(598, 207)
        Me.dgvServicosRealizados.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdServico"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 43
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DataServico"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewButtonColumn1
        '
        Me.DataGridViewButtonColumn1.HeaderText = "Visualizar Revisão"
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        '
        'DataGridViewButtonColumn2
        '
        Me.DataGridViewButtonColumn2.HeaderText = "Imprimir"
        Me.DataGridViewButtonColumn2.Name = "DataGridViewButtonColumn2"
        Me.DataGridViewButtonColumn2.Visible = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.SGC.My.Resources.Resources.search
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(506, 314)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(123, 27)
        Me.btnImprimir.TabIndex = 6
        Me.btnImprimir.Text = "Visualizar Histórico"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdRevisoesRealizados)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(610, 279)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Revisões"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvServicosRealizados)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 328)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(610, 232)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Serviços"
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(554, 566)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 23)
        Me.btnSair.TabIndex = 9
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'lblAlerta
        '
        Me.lblAlerta.AutoSize = True
        Me.lblAlerta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlerta.ForeColor = System.Drawing.Color.Red
        Me.lblAlerta.Location = New System.Drawing.Point(22, 304)
        Me.lblAlerta.Name = "lblAlerta"
        Me.lblAlerta.Size = New System.Drawing.Size(0, 13)
        Me.lblAlerta.TabIndex = 11
        '
        'btnEnviarEmail
        '
        Me.btnEnviarEmail.Image = Global.SGC.My.Resources.Resources.mail_dark
        Me.btnEnviarEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnviarEmail.Location = New System.Drawing.Point(342, 297)
        Me.btnEnviarEmail.Name = "btnEnviarEmail"
        Me.btnEnviarEmail.Size = New System.Drawing.Size(152, 27)
        Me.btnEnviarEmail.TabIndex = 12
        Me.btnEnviarEmail.Text = "Enviar histórico por Email"
        Me.btnEnviarEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEnviarEmail.UseVisualStyleBackColor = True
        Me.btnEnviarEmail.Visible = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.btnImprimir)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, -17)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(639, 640)
        Me.Guna2Panel1.TabIndex = 13
        '
        'id
        '
        Me.id.DataPropertyName = "IdServico"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.Visible = False
        Me.id.Width = 43
        '
        'colQuilometragem
        '
        Me.colQuilometragem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colQuilometragem.DataPropertyName = "Quilometragem"
        Me.colQuilometragem.HeaderText = "Revisão de"
        Me.colQuilometragem.Name = "colQuilometragem"
        '
        'Placa
        '
        Me.Placa.DataPropertyName = "placa"
        Me.Placa.HeaderText = "Placa"
        Me.Placa.Name = "Placa"
        '
        'dataRevisao
        '
        Me.dataRevisao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dataRevisao.DataPropertyName = "DataServico"
        Me.dataRevisao.HeaderText = "Data"
        Me.dataRevisao.Name = "dataRevisao"
        '
        'btnVisualizarRevisão
        '
        Me.btnVisualizarRevisão.HeaderText = "Visualizar Revisão"
        Me.btnVisualizarRevisão.Name = "btnVisualizarRevisão"
        '
        'btnEditar
        '
        Me.btnEditar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.btnEditar.HeaderText = "Editar"
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Width = 40
        '
        'btnExcluir
        '
        Me.btnExcluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.btnExcluir.HeaderText = "Excluir"
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Width = 44
        '
        'btnImprimirRevisao
        '
        Me.btnImprimirRevisao.HeaderText = "Imprimir"
        Me.btnImprimirRevisao.Name = "btnImprimirRevisao"
        Me.btnImprimirRevisao.Visible = False
        '
        'frmHistoricoRevisao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 601)
        Me.Controls.Add(Me.btnEnviarEmail)
        Me.Controls.Add(Me.lblAlerta)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHistoricoRevisao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Histórico de Revisões"
        CType(Me.grdRevisoesRealizados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvServicosRealizados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdRevisoesRealizados As DataGridView
    Friend WithEvents dgvServicosRealizados As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn1 As DataGridViewButtonColumn
    Friend WithEvents DataGridViewButtonColumn2 As DataGridViewButtonColumn
    Friend WithEvents btnImprimir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSair As Button
    Friend WithEvents lblAlerta As Label
    Friend WithEvents btnEnviarEmail As Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents colQuilometragem As DataGridViewTextBoxColumn
    Friend WithEvents Placa As DataGridViewTextBoxColumn
    Friend WithEvents dataRevisao As DataGridViewTextBoxColumn
    Friend WithEvents btnVisualizarRevisão As DataGridViewButtonColumn
    Friend WithEvents btnEditar As DataGridViewButtonColumn
    Friend WithEvents btnExcluir As DataGridViewButtonColumn
    Friend WithEvents btnImprimirRevisao As DataGridViewButtonColumn
End Class
