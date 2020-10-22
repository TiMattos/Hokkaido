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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarClientes))
        Me.grdCliente = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Endereco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Placa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnSair = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAgendaServico = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHistoricoRevisao = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRealizarServico = New Guna.UI2.WinForms.Guna2Button()
        Me.btnVisualizarCad = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnBuscar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbFiltroCliente = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtFiltroCliente = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.grdCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdCliente
        '
        Me.grdCliente.AllowUserToAddRows = False
        Me.grdCliente.AllowUserToResizeColumns = False
        Me.grdCliente.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.grdCliente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdCliente.BackgroundColor = System.Drawing.Color.White
        Me.grdCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grdCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdCliente.ColumnHeadersHeight = 25
        Me.grdCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nome1, Me.Endereco, Me.Placa})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdCliente.DefaultCellStyle = DataGridViewCellStyle3
        Me.grdCliente.EnableHeadersVisualStyles = False
        Me.grdCliente.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdCliente.Location = New System.Drawing.Point(15, 235)
        Me.grdCliente.Name = "grdCliente"
        Me.grdCliente.ReadOnly = True
        Me.grdCliente.RowHeadersVisible = False
        Me.grdCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grdCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdCliente.Size = New System.Drawing.Size(502, 289)
        Me.grdCliente.TabIndex = 7
        Me.grdCliente.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.grdCliente.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.grdCliente.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.grdCliente.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdCliente.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.grdCliente.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.grdCliente.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.grdCliente.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdCliente.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdCliente.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.grdCliente.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.grdCliente.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.grdCliente.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdCliente.ThemeStyle.HeaderStyle.Height = 25
        Me.grdCliente.ThemeStyle.ReadOnly = True
        Me.grdCliente.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.grdCliente.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdCliente.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.grdCliente.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.grdCliente.ThemeStyle.RowsStyle.Height = 22
        Me.grdCliente.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdCliente.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "id"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'Nome1
        '
        Me.Nome1.DataPropertyName = "Nome1"
        Me.Nome1.HeaderText = "Nome"
        Me.Nome1.Name = "Nome1"
        Me.Nome1.ReadOnly = True
        '
        'Endereco
        '
        Me.Endereco.DataPropertyName = "Endereco"
        Me.Endereco.HeaderText = "Endereço"
        Me.Endereco.Name = "Endereco"
        Me.Endereco.ReadOnly = True
        '
        'Placa
        '
        Me.Placa.DataPropertyName = "Placa"
        Me.Placa.HeaderText = "Placa"
        Me.Placa.Name = "Placa"
        Me.Placa.ReadOnly = True
        Me.Placa.Visible = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.btnSair)
        Me.Guna2Panel1.Controls.Add(Me.btnAgendaServico)
        Me.Guna2Panel1.Controls.Add(Me.btnHistoricoRevisao)
        Me.Guna2Panel1.Controls.Add(Me.btnRealizarServico)
        Me.Guna2Panel1.Controls.Add(Me.btnVisualizarCad)
        Me.Guna2Panel1.Controls.Add(Me.Guna2GroupBox1)
        Me.Guna2Panel1.Controls.Add(Me.grdCliente)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(-3, -7)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(733, 564)
        Me.Guna2Panel1.TabIndex = 8
        '
        'btnSair
        '
        Me.btnSair.CheckedState.Parent = Me.btnSair
        Me.btnSair.CustomImages.Parent = Me.btnSair
        Me.btnSair.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSair.ForeColor = System.Drawing.Color.White
        Me.btnSair.HoverState.Parent = Me.btnSair
        Me.btnSair.Location = New System.Drawing.Point(523, 479)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.ShadowDecoration.Parent = Me.btnSair
        Me.btnSair.Size = New System.Drawing.Size(180, 45)
        Me.btnSair.TabIndex = 13
        Me.btnSair.Text = "Sair"
        '
        'btnAgendaServico
        '
        Me.btnAgendaServico.CheckedState.Parent = Me.btnAgendaServico
        Me.btnAgendaServico.CustomImages.Parent = Me.btnAgendaServico
        Me.btnAgendaServico.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAgendaServico.ForeColor = System.Drawing.Color.White
        Me.btnAgendaServico.HoverState.Parent = Me.btnAgendaServico
        Me.btnAgendaServico.Location = New System.Drawing.Point(523, 388)
        Me.btnAgendaServico.Name = "btnAgendaServico"
        Me.btnAgendaServico.ShadowDecoration.Parent = Me.btnAgendaServico
        Me.btnAgendaServico.Size = New System.Drawing.Size(180, 45)
        Me.btnAgendaServico.TabIndex = 12
        Me.btnAgendaServico.Text = "Agendar Serviço"
        Me.btnAgendaServico.Visible = False
        '
        'btnHistoricoRevisao
        '
        Me.btnHistoricoRevisao.CheckedState.Parent = Me.btnHistoricoRevisao
        Me.btnHistoricoRevisao.CustomImages.Parent = Me.btnHistoricoRevisao
        Me.btnHistoricoRevisao.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnHistoricoRevisao.ForeColor = System.Drawing.Color.White
        Me.btnHistoricoRevisao.HoverState.Parent = Me.btnHistoricoRevisao
        Me.btnHistoricoRevisao.Location = New System.Drawing.Point(523, 337)
        Me.btnHistoricoRevisao.Name = "btnHistoricoRevisao"
        Me.btnHistoricoRevisao.ShadowDecoration.Parent = Me.btnHistoricoRevisao
        Me.btnHistoricoRevisao.Size = New System.Drawing.Size(180, 45)
        Me.btnHistoricoRevisao.TabIndex = 11
        Me.btnHistoricoRevisao.Text = "Histório de revisões e serviços"
        '
        'btnRealizarServico
        '
        Me.btnRealizarServico.CheckedState.Parent = Me.btnRealizarServico
        Me.btnRealizarServico.CustomImages.Parent = Me.btnRealizarServico
        Me.btnRealizarServico.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRealizarServico.ForeColor = System.Drawing.Color.White
        Me.btnRealizarServico.HoverState.Parent = Me.btnRealizarServico
        Me.btnRealizarServico.Location = New System.Drawing.Point(523, 286)
        Me.btnRealizarServico.Name = "btnRealizarServico"
        Me.btnRealizarServico.ShadowDecoration.Parent = Me.btnRealizarServico
        Me.btnRealizarServico.Size = New System.Drawing.Size(180, 45)
        Me.btnRealizarServico.TabIndex = 10
        Me.btnRealizarServico.Text = "Realizar Serviço"
        '
        'btnVisualizarCad
        '
        Me.btnVisualizarCad.CheckedState.Parent = Me.btnVisualizarCad
        Me.btnVisualizarCad.CustomImages.Parent = Me.btnVisualizarCad
        Me.btnVisualizarCad.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnVisualizarCad.ForeColor = System.Drawing.Color.White
        Me.btnVisualizarCad.HoverState.Parent = Me.btnVisualizarCad
        Me.btnVisualizarCad.Location = New System.Drawing.Point(523, 235)
        Me.btnVisualizarCad.Name = "btnVisualizarCad"
        Me.btnVisualizarCad.ShadowDecoration.Parent = Me.btnVisualizarCad
        Me.btnVisualizarCad.Size = New System.Drawing.Size(180, 45)
        Me.btnVisualizarCad.TabIndex = 9
        Me.btnVisualizarCad.Text = "Visualizar Cadastro"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.btnBuscar)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2GroupBox1.Controls.Add(Me.cmbFiltroCliente)
        Me.Guna2GroupBox1.Controls.Add(Me.txtFiltroCliente)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(15, 19)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(502, 200)
        Me.Guna2GroupBox1.TabIndex = 8
        Me.Guna2GroupBox1.Text = "Filtro"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.SGC.My.Resources.Resources.search
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscar.CheckedState.Parent = Me.btnBuscar
        Me.btnBuscar.CustomImages.Parent = Me.btnBuscar
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.HoverState.Parent = Me.btnBuscar
        Me.btnBuscar.Image = Global.SGC.My.Resources.Resources.search
        Me.btnBuscar.Location = New System.Drawing.Point(421, 133)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.ShadowDecoration.Parent = Me.btnBuscar
        Me.btnBuscar.Size = New System.Drawing.Size(43, 36)
        Me.btnBuscar.TabIndex = 3
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(27, 61)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(54, 15)
        Me.Guna2HtmlLabel1.TabIndex = 2
        Me.Guna2HtmlLabel1.Text = "Buscar por"
        '
        'cmbFiltroCliente
        '
        Me.cmbFiltroCliente.Animated = True
        Me.cmbFiltroCliente.BackColor = System.Drawing.Color.Transparent
        Me.cmbFiltroCliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbFiltroCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFiltroCliente.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbFiltroCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbFiltroCliente.FocusedState.Parent = Me.cmbFiltroCliente
        Me.cmbFiltroCliente.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbFiltroCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbFiltroCliente.HoverState.Parent = Me.cmbFiltroCliente
        Me.cmbFiltroCliente.ItemHeight = 30
        Me.cmbFiltroCliente.Items.AddRange(New Object() {"Nome", "Placa", "Endereço"})
        Me.cmbFiltroCliente.ItemsAppearance.Parent = Me.cmbFiltroCliente
        Me.cmbFiltroCliente.Location = New System.Drawing.Point(27, 84)
        Me.cmbFiltroCliente.Name = "cmbFiltroCliente"
        Me.cmbFiltroCliente.ShadowDecoration.Parent = Me.cmbFiltroCliente
        Me.cmbFiltroCliente.Size = New System.Drawing.Size(197, 36)
        Me.cmbFiltroCliente.TabIndex = 1
        '
        'txtFiltroCliente
        '
        Me.txtFiltroCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFiltroCliente.DefaultText = ""
        Me.txtFiltroCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFiltroCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFiltroCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFiltroCliente.DisabledState.Parent = Me.txtFiltroCliente
        Me.txtFiltroCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFiltroCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFiltroCliente.FocusedState.Parent = Me.txtFiltroCliente
        Me.txtFiltroCliente.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFiltroCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFiltroCliente.HoverState.Parent = Me.txtFiltroCliente
        Me.txtFiltroCliente.Location = New System.Drawing.Point(27, 133)
        Me.txtFiltroCliente.Name = "txtFiltroCliente"
        Me.txtFiltroCliente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFiltroCliente.PlaceholderText = ""
        Me.txtFiltroCliente.SelectedText = ""
        Me.txtFiltroCliente.ShadowDecoration.Parent = Me.txtFiltroCliente
        Me.txtFiltroCliente.Size = New System.Drawing.Size(376, 36)
        Me.txtFiltroCliente.TabIndex = 0
        '
        'frmBuscarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 541)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscarClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Área de Gerenciamento de Clientes"
        CType(Me.grdCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdCliente As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents btnBuscar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbFiltroCliente As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtFiltroCliente As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSair As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAgendaServico As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHistoricoRevisao As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRealizarServico As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnVisualizarCad As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nome1 As DataGridViewTextBoxColumn
    Friend WithEvents Endereco As DataGridViewTextBoxColumn
    Friend WithEvents Placa As DataGridViewTextBoxColumn
End Class
