<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BalançoFinanceiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgAgendamento = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEndereço = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTelefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRemover = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgAgendamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.ConfiguraçõesToolStripMenuItem, Me.SairToolStripMenuItem, Me.BalançoFinanceiroToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(734, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarClientesToolStripMenuItem})
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.CadastroToolStripMenuItem.Text = "Cadastro"
        '
        'CadastrarClientesToolStripMenuItem
        '
        Me.CadastrarClientesToolStripMenuItem.Name = "CadastrarClientesToolStripMenuItem"
        Me.CadastrarClientesToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.CadastrarClientesToolStripMenuItem.Text = "Incluir Cadastro"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarClienteToolStripMenuItem})
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(114, 20)
        Me.BuscarToolStripMenuItem.Text = "Gerenciar Clientes"
        '
        'BuscarClienteToolStripMenuItem
        '
        Me.BuscarClienteToolStripMenuItem.Name = "BuscarClienteToolStripMenuItem"
        Me.BuscarClienteToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.BuscarClienteToolStripMenuItem.Text = "Gerenciar Cadastro"
        '
        'ConfiguraçõesToolStripMenuItem
        '
        Me.ConfiguraçõesToolStripMenuItem.Name = "ConfiguraçõesToolStripMenuItem"
        Me.ConfiguraçõesToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.ConfiguraçõesToolStripMenuItem.Text = "Configurações"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'BalançoFinanceiroToolStripMenuItem
        '
        Me.BalançoFinanceiroToolStripMenuItem.Name = "BalançoFinanceiroToolStripMenuItem"
        Me.BalançoFinanceiroToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.BalançoFinanceiroToolStripMenuItem.Text = "Balanço Financeiro"
        Me.BalançoFinanceiroToolStripMenuItem.Visible = False
        '
        'dgAgendamento
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgAgendamento.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgAgendamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgAgendamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAgendamento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.colData, Me.colEndereço, Me.colTelefone, Me.colNome, Me.colRemover})
        Me.dgAgendamento.Location = New System.Drawing.Point(6, 19)
        Me.dgAgendamento.Name = "dgAgendamento"
        Me.dgAgendamento.RowTemplate.ReadOnly = True
        Me.dgAgendamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgAgendamento.Size = New System.Drawing.Size(698, 274)
        Me.dgAgendamento.TabIndex = 8
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'colData
        '
        Me.colData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colData.DataPropertyName = "DataHora"
        Me.colData.HeaderText = "Data / Hora"
        Me.colData.Name = "colData"
        '
        'colEndereço
        '
        Me.colEndereço.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colEndereço.DataPropertyName = "Endereco"
        Me.colEndereço.HeaderText = "Endereço"
        Me.colEndereço.Name = "colEndereço"
        '
        'colTelefone
        '
        Me.colTelefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colTelefone.DataPropertyName = "Telefone"
        Me.colTelefone.HeaderText = "Telefone"
        Me.colTelefone.Name = "colTelefone"
        '
        'colNome
        '
        Me.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNome.DataPropertyName = "Nome"
        Me.colNome.HeaderText = "Nome"
        Me.colNome.Name = "colNome"
        '
        'colRemover
        '
        Me.colRemover.HeaderText = "Remover"
        Me.colRemover.Image = Global.SGC.My.Resources.Resources.remove_outline
        Me.colRemover.Name = "colRemover"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgAgendamento)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(710, 313)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Próximo Agendamentos"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Remover"
        Me.DataGridViewImageColumn1.Image = Global.SGC.My.Resources.Resources.remove_outline
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 473)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(734, 32)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 505)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sistema de Gerenciamento de Clientes - SGP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgAgendamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgAgendamento As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents colData As DataGridViewTextBoxColumn
    Friend WithEvents colEndereço As DataGridViewTextBoxColumn
    Friend WithEvents colTelefone As DataGridViewTextBoxColumn
    Friend WithEvents colNome As DataGridViewTextBoxColumn
    Friend WithEvents colRemover As DataGridViewImageColumn
    Friend WithEvents ConfiguraçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents BalançoFinanceiroToolStripMenuItem As ToolStripMenuItem
End Class
