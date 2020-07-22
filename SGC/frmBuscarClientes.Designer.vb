<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarClientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarClientes))
        Me.txtFiltroCliente = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbFiltroCliente = New System.Windows.Forms.ComboBox()
        Me.grdCliente = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.endereco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnVisualizar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnAgendar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnHistoricoServicos = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnAgendarServico = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnVisualizarCad = New System.Windows.Forms.Button()
        Me.btnRealizarServico = New System.Windows.Forms.Button()
        Me.btnHistoricoRevisao = New System.Windows.Forms.Button()
        Me.btnAgendaServico = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFiltroCliente
        '
        Me.txtFiltroCliente.Location = New System.Drawing.Point(24, 80)
        Me.txtFiltroCliente.Name = "txtFiltroCliente"
        Me.txtFiltroCliente.Size = New System.Drawing.Size(191, 20)
        Me.txtFiltroCliente.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtFiltroCliente)
        Me.GroupBox1.Controls.Add(Me.cmbFiltroCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 115)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro"
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.SGC.My.Resources.Resources.search
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(248, 77)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar por:"
        '
        'cmbFiltroCliente
        '
        Me.cmbFiltroCliente.FormattingEnabled = True
        Me.cmbFiltroCliente.Items.AddRange(New Object() {"-Selecione-", "Nome", "Endereço", "Placa"})
        Me.cmbFiltroCliente.Location = New System.Drawing.Point(24, 38)
        Me.cmbFiltroCliente.Name = "cmbFiltroCliente"
        Me.cmbFiltroCliente.Size = New System.Drawing.Size(191, 21)
        Me.cmbFiltroCliente.TabIndex = 0
        '
        'grdCliente
        '
        Me.grdCliente.AllowUserToAddRows = False
        Me.grdCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grdCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Nome, Me.endereco, Me.telefone, Me.btnVisualizar, Me.btnAgendar, Me.btnHistoricoServicos, Me.btnAgendarServico})
        Me.grdCliente.EnableHeadersVisualStyles = False
        Me.grdCliente.Location = New System.Drawing.Point(25, 144)
        Me.grdCliente.Name = "grdCliente"
        Me.grdCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.grdCliente.RowTemplate.ReadOnly = True
        Me.grdCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdCliente.Size = New System.Drawing.Size(552, 225)
        Me.grdCliente.TabIndex = 2
        '
        'id
        '
        Me.id.DataPropertyName = "ID"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'Nome
        '
        Me.Nome.DataPropertyName = "Nome1"
        Me.Nome.HeaderText = "Nome"
        Me.Nome.Name = "Nome"
        '
        'endereco
        '
        Me.endereco.DataPropertyName = "Endereco"
        Me.endereco.HeaderText = "Endereço"
        Me.endereco.Name = "endereco"
        '
        'telefone
        '
        Me.telefone.DataPropertyName = "Telefone"
        Me.telefone.HeaderText = "Telefone"
        Me.telefone.Name = "telefone"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.btnVisualizar.HeaderText = "Visualizar"
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Text = "Visualizar"
        Me.btnVisualizar.Visible = False
        '
        'btnAgendar
        '
        Me.btnAgendar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.btnAgendar.HeaderText = "Cadastrar Serviço"
        Me.btnAgendar.Name = "btnAgendar"
        Me.btnAgendar.Text = "Cadastrar serviço"
        Me.btnAgendar.Visible = False
        '
        'btnHistoricoServicos
        '
        Me.btnHistoricoServicos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.btnHistoricoServicos.HeaderText = "Histórico de revisões"
        Me.btnHistoricoServicos.Name = "btnHistoricoServicos"
        Me.btnHistoricoServicos.Visible = False
        '
        'btnAgendarServico
        '
        Me.btnAgendarServico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.btnAgendarServico.HeaderText = "Agendar Serviço"
        Me.btnAgendarServico.Name = "btnAgendarServico"
        Me.btnAgendarServico.Visible = False
        '
        'btnSair
        '
        Me.btnSair.Image = Global.SGC.My.Resources.Resources.remove
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(655, 343)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(60, 26)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnVisualizarCad
        '
        Me.btnVisualizarCad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizarCad.Enabled = False
        Me.btnVisualizarCad.Image = Global.SGC.My.Resources.Resources.search
        Me.btnVisualizarCad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVisualizarCad.Location = New System.Drawing.Point(583, 144)
        Me.btnVisualizarCad.Name = "btnVisualizarCad"
        Me.btnVisualizarCad.Size = New System.Drawing.Size(132, 23)
        Me.btnVisualizarCad.TabIndex = 3
        Me.btnVisualizarCad.Text = "Visualizar Cadastro"
        Me.btnVisualizarCad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVisualizarCad.UseVisualStyleBackColor = True
        '
        'btnRealizarServico
        '
        Me.btnRealizarServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRealizarServico.Enabled = False
        Me.btnRealizarServico.Image = Global.SGC.My.Resources.Resources.gem_okay
        Me.btnRealizarServico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRealizarServico.Location = New System.Drawing.Point(583, 173)
        Me.btnRealizarServico.Name = "btnRealizarServico"
        Me.btnRealizarServico.Size = New System.Drawing.Size(132, 23)
        Me.btnRealizarServico.TabIndex = 4
        Me.btnRealizarServico.Text = "Realizar Serviço"
        Me.btnRealizarServico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRealizarServico.UseVisualStyleBackColor = True
        '
        'btnHistoricoRevisao
        '
        Me.btnHistoricoRevisao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHistoricoRevisao.Enabled = False
        Me.btnHistoricoRevisao.Image = Global.SGC.My.Resources.Resources.information
        Me.btnHistoricoRevisao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistoricoRevisao.Location = New System.Drawing.Point(583, 202)
        Me.btnHistoricoRevisao.Name = "btnHistoricoRevisao"
        Me.btnHistoricoRevisao.Size = New System.Drawing.Size(132, 23)
        Me.btnHistoricoRevisao.TabIndex = 5
        Me.btnHistoricoRevisao.Text = "Histórico de Revisões"
        Me.btnHistoricoRevisao.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHistoricoRevisao.UseVisualStyleBackColor = True
        '
        'btnAgendaServico
        '
        Me.btnAgendaServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgendaServico.Enabled = False
        Me.btnAgendaServico.Image = Global.SGC.My.Resources.Resources.calendar_day_new
        Me.btnAgendaServico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgendaServico.Location = New System.Drawing.Point(583, 231)
        Me.btnAgendaServico.Name = "btnAgendaServico"
        Me.btnAgendaServico.Size = New System.Drawing.Size(132, 23)
        Me.btnAgendaServico.TabIndex = 6
        Me.btnAgendaServico.Text = "Agendar Serviço"
        Me.btnAgendaServico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgendaServico.UseVisualStyleBackColor = True
        '
        'frmBuscarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 395)
        Me.Controls.Add(Me.btnAgendaServico)
        Me.Controls.Add(Me.btnHistoricoRevisao)
        Me.Controls.Add(Me.btnRealizarServico)
        Me.Controls.Add(Me.btnVisualizarCad)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.grdCliente)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscarClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Área de Gerenciamento de Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtFiltroCliente As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbFiltroCliente As ComboBox
    Friend WithEvents grdCliente As DataGridView
    Friend WithEvents btnSair As Button
    Friend WithEvents btnVisualizarCad As Button
    Friend WithEvents btnRealizarServico As Button
    Friend WithEvents btnHistoricoRevisao As Button
    Friend WithEvents btnAgendaServico As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents endereco As DataGridViewTextBoxColumn
    Friend WithEvents telefone As DataGridViewTextBoxColumn
    Friend WithEvents btnVisualizar As DataGridViewButtonColumn
    Friend WithEvents btnAgendar As DataGridViewButtonColumn
    Friend WithEvents btnHistoricoServicos As DataGridViewButtonColumn
    Friend WithEvents btnAgendarServico As DataGridViewButtonColumn
End Class
