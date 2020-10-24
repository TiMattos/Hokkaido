<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExibeBalancoFinanceiro
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.rdbMesAno = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rdbPeriodo = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.cmbAno = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbMes = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnPesquisar = New Guna.UI2.WinForms.Guna2Button()
        Me.lblTexto2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblTexto1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tmpDataFim = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.tmpDataInicio = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.grdResumo = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaodeObra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pecas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataServico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2GroupBox3 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblValorMaoObra = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblValorGeral = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblValorPecas = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.grdResumo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox2.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.rdbMesAno)
        Me.Guna2GroupBox1.Controls.Add(Me.rdbPeriodo)
        Me.Guna2GroupBox1.Controls.Add(Me.cmbAno)
        Me.Guna2GroupBox1.Controls.Add(Me.cmbMes)
        Me.Guna2GroupBox1.Controls.Add(Me.btnPesquisar)
        Me.Guna2GroupBox1.Controls.Add(Me.lblTexto2)
        Me.Guna2GroupBox1.Controls.Add(Me.lblTexto1)
        Me.Guna2GroupBox1.Controls.Add(Me.tmpDataFim)
        Me.Guna2GroupBox1.Controls.Add(Me.tmpDataInicio)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(14, 13)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(517, 176)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "Filtro"
        '
        'rdbMesAno
        '
        Me.rdbMesAno.AutoSize = True
        Me.rdbMesAno.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdbMesAno.CheckedState.BorderThickness = 0
        Me.rdbMesAno.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdbMesAno.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rdbMesAno.CheckedState.InnerOffset = -4
        Me.rdbMesAno.Location = New System.Drawing.Point(266, 45)
        Me.rdbMesAno.Name = "rdbMesAno"
        Me.rdbMesAno.Size = New System.Drawing.Size(100, 19)
        Me.rdbMesAno.TabIndex = 8
        Me.rdbMesAno.Text = "Por mês e ano"
        Me.rdbMesAno.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rdbMesAno.UncheckedState.BorderThickness = 2
        Me.rdbMesAno.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdbMesAno.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rdbPeriodo
        '
        Me.rdbPeriodo.AutoSize = True
        Me.rdbPeriodo.Checked = True
        Me.rdbPeriodo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdbPeriodo.CheckedState.BorderThickness = 0
        Me.rdbPeriodo.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdbPeriodo.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rdbPeriodo.CheckedState.InnerOffset = -4
        Me.rdbPeriodo.Location = New System.Drawing.Point(14, 45)
        Me.rdbPeriodo.Name = "rdbPeriodo"
        Me.rdbPeriodo.Size = New System.Drawing.Size(87, 19)
        Me.rdbPeriodo.TabIndex = 7
        Me.rdbPeriodo.TabStop = True
        Me.rdbPeriodo.Text = "Por período"
        Me.rdbPeriodo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rdbPeriodo.UncheckedState.BorderThickness = 2
        Me.rdbPeriodo.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdbPeriodo.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'cmbAno
        '
        Me.cmbAno.BackColor = System.Drawing.Color.Transparent
        Me.cmbAno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAno.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbAno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbAno.FocusedState.Parent = Me.cmbAno
        Me.cmbAno.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbAno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbAno.HoverState.Parent = Me.cmbAno
        Me.cmbAno.ItemHeight = 30
        Me.cmbAno.Items.AddRange(New Object() {"2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbAno.ItemsAppearance.Parent = Me.cmbAno
        Me.cmbAno.Location = New System.Drawing.Point(266, 87)
        Me.cmbAno.Name = "cmbAno"
        Me.cmbAno.ShadowDecoration.Parent = Me.cmbAno
        Me.cmbAno.Size = New System.Drawing.Size(232, 36)
        Me.cmbAno.TabIndex = 6
        '
        'cmbMes
        '
        Me.cmbMes.BackColor = System.Drawing.Color.Transparent
        Me.cmbMes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMes.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbMes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbMes.FocusedState.Parent = Me.cmbMes
        Me.cmbMes.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbMes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbMes.HoverState.Parent = Me.cmbMes
        Me.cmbMes.ItemHeight = 30
        Me.cmbMes.Items.AddRange(New Object() {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"})
        Me.cmbMes.ItemsAppearance.Parent = Me.cmbMes
        Me.cmbMes.Location = New System.Drawing.Point(14, 87)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.ShadowDecoration.Parent = Me.cmbMes
        Me.cmbMes.Size = New System.Drawing.Size(232, 36)
        Me.cmbMes.TabIndex = 5
        '
        'btnPesquisar
        '
        Me.btnPesquisar.CheckedState.Parent = Me.btnPesquisar
        Me.btnPesquisar.CustomImages.Parent = Me.btnPesquisar
        Me.btnPesquisar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPesquisar.ForeColor = System.Drawing.Color.White
        Me.btnPesquisar.HoverState.Parent = Me.btnPesquisar
        Me.btnPesquisar.Location = New System.Drawing.Point(369, 127)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.ShadowDecoration.Parent = Me.btnPesquisar
        Me.btnPesquisar.Size = New System.Drawing.Size(129, 41)
        Me.btnPesquisar.TabIndex = 4
        Me.btnPesquisar.Text = "Pesquisar"
        '
        'lblTexto2
        '
        Me.lblTexto2.BackColor = System.Drawing.Color.Transparent
        Me.lblTexto2.Location = New System.Drawing.Point(266, 64)
        Me.lblTexto2.Name = "lblTexto2"
        Me.lblTexto2.Size = New System.Drawing.Size(19, 15)
        Me.lblTexto2.TabIndex = 3
        Me.lblTexto2.Text = "Até"
        '
        'lblTexto1
        '
        Me.lblTexto1.BackColor = System.Drawing.Color.Transparent
        Me.lblTexto1.Location = New System.Drawing.Point(14, 64)
        Me.lblTexto1.Name = "lblTexto1"
        Me.lblTexto1.Size = New System.Drawing.Size(17, 15)
        Me.lblTexto1.TabIndex = 2
        Me.lblTexto1.Text = "De"
        '
        'tmpDataFim
        '
        Me.tmpDataFim.CheckedState.Parent = Me.tmpDataFim
        Me.tmpDataFim.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tmpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tmpDataFim.HoverState.Parent = Me.tmpDataFim
        Me.tmpDataFim.Location = New System.Drawing.Point(266, 85)
        Me.tmpDataFim.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.tmpDataFim.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.tmpDataFim.Name = "tmpDataFim"
        Me.tmpDataFim.ShadowDecoration.Parent = Me.tmpDataFim
        Me.tmpDataFim.Size = New System.Drawing.Size(232, 36)
        Me.tmpDataFim.TabIndex = 1
        Me.tmpDataFim.Value = New Date(2020, 10, 24, 13, 2, 29, 4)
        '
        'tmpDataInicio
        '
        Me.tmpDataInicio.CheckedState.Parent = Me.tmpDataInicio
        Me.tmpDataInicio.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tmpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tmpDataInicio.HoverState.Parent = Me.tmpDataInicio
        Me.tmpDataInicio.Location = New System.Drawing.Point(14, 85)
        Me.tmpDataInicio.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.tmpDataInicio.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.tmpDataInicio.Name = "tmpDataInicio"
        Me.tmpDataInicio.ShadowDecoration.Parent = Me.tmpDataInicio
        Me.tmpDataInicio.Size = New System.Drawing.Size(232, 36)
        Me.tmpDataInicio.TabIndex = 0
        Me.tmpDataInicio.Value = New Date(2020, 10, 24, 13, 2, 29, 4)
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Chart1)
        Me.Guna2Panel1.Controls.Add(Me.grdResumo)
        Me.Guna2Panel1.Controls.Add(Me.Guna2GroupBox3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2GroupBox2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2GroupBox1)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(-2, -1)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(869, 636)
        Me.Guna2Panel1.TabIndex = 1
        '
        'grdResumo
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.grdResumo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.grdResumo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdResumo.BackgroundColor = System.Drawing.Color.White
        Me.grdResumo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdResumo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdResumo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdResumo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.grdResumo.ColumnHeadersHeight = 15
        Me.grdResumo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cliente, Me.MaodeObra, Me.Pecas, Me.DataServico})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdResumo.DefaultCellStyle = DataGridViewCellStyle9
        Me.grdResumo.EnableHeadersVisualStyles = False
        Me.grdResumo.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdResumo.Location = New System.Drawing.Point(28, 422)
        Me.grdResumo.Name = "grdResumo"
        Me.grdResumo.RowHeadersVisible = False
        Me.grdResumo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdResumo.Size = New System.Drawing.Size(484, 150)
        Me.grdResumo.TabIndex = 0
        Me.grdResumo.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.grdResumo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.grdResumo.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.grdResumo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdResumo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.grdResumo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.grdResumo.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.grdResumo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdResumo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdResumo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.grdResumo.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdResumo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.grdResumo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.grdResumo.ThemeStyle.HeaderStyle.Height = 15
        Me.grdResumo.ThemeStyle.ReadOnly = False
        Me.grdResumo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.grdResumo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdResumo.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdResumo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdResumo.ThemeStyle.RowsStyle.Height = 22
        Me.grdResumo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdResumo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'cliente
        '
        Me.cliente.DataPropertyName = "Nome"
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.Name = "cliente"
        '
        'MaodeObra
        '
        Me.MaodeObra.DataPropertyName = "MaodeObra"
        Me.MaodeObra.HeaderText = "Mão de obra"
        Me.MaodeObra.Name = "MaodeObra"
        '
        'Pecas
        '
        Me.Pecas.DataPropertyName = "ValorPecas"
        Me.Pecas.HeaderText = "Peças"
        Me.Pecas.Name = "Pecas"
        '
        'DataServico
        '
        Me.DataServico.DataPropertyName = "DataServico"
        Me.DataServico.HeaderText = "Data do Serviço"
        Me.DataServico.Name = "DataServico"
        '
        'Guna2GroupBox3
        '
        Me.Guna2GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox3.Location = New System.Drawing.Point(14, 372)
        Me.Guna2GroupBox3.Name = "Guna2GroupBox3"
        Me.Guna2GroupBox3.ShadowDecoration.Parent = Me.Guna2GroupBox3
        Me.Guna2GroupBox3.Size = New System.Drawing.Size(517, 216)
        Me.Guna2GroupBox3.TabIndex = 2
        Me.Guna2GroupBox3.Text = "Serviços realizados dentro do filtro informado"
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Controls.Add(Me.lblValorMaoObra)
        Me.Guna2GroupBox2.Controls.Add(Me.lblValorGeral)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2GroupBox2.Controls.Add(Me.lblValorPecas)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(14, 195)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(517, 159)
        Me.Guna2GroupBox2.TabIndex = 1
        Me.Guna2GroupBox2.Text = "Resumo"
        '
        'lblValorMaoObra
        '
        Me.lblValorMaoObra.BackColor = System.Drawing.Color.Transparent
        Me.lblValorMaoObra.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorMaoObra.Location = New System.Drawing.Point(266, 62)
        Me.lblValorMaoObra.Name = "lblValorMaoObra"
        Me.lblValorMaoObra.Size = New System.Drawing.Size(133, 23)
        Me.lblValorMaoObra.TabIndex = 6
        Me.lblValorMaoObra.Text = "Guna2HtmlLabel9"
        '
        'lblValorGeral
        '
        Me.lblValorGeral.BackColor = System.Drawing.Color.Transparent
        Me.lblValorGeral.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorGeral.Location = New System.Drawing.Point(266, 108)
        Me.lblValorGeral.Name = "lblValorGeral"
        Me.lblValorGeral.Size = New System.Drawing.Size(133, 23)
        Me.lblValorGeral.TabIndex = 4
        Me.lblValorGeral.Text = "Guna2HtmlLabel7"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(131, 108)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(86, 23)
        Me.Guna2HtmlLabel6.TabIndex = 3
        Me.Guna2HtmlLabel6.Text = "Valor geral:"
        '
        'lblValorPecas
        '
        Me.lblValorPecas.BackColor = System.Drawing.Color.Transparent
        Me.lblValorPecas.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorPecas.Location = New System.Drawing.Point(266, 85)
        Me.lblValorPecas.Name = "lblValorPecas"
        Me.lblValorPecas.Size = New System.Drawing.Size(133, 23)
        Me.lblValorPecas.TabIndex = 2
        Me.lblValorPecas.Text = "Guna2HtmlLabel5"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(65, 85)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(152, 23)
        Me.Guna2HtmlLabel4.TabIndex = 1
        Me.Guna2HtmlLabel4.Text = "Valor total de peças:"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(14, 62)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(203, 23)
        Me.Guna2HtmlLabel3.TabIndex = 0
        Me.Guna2HtmlLabel3.Text = "Valor total de mão de obra:"
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(537, 13)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(300, 300)
        Me.Chart1.TabIndex = 3
        Me.Chart1.Text = "Chart1"
        '
        'frmExibeBalancoFinanceiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 599)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmExibeBalancoFinanceiro"
        Me.Text = "frmExibeBalancoFinanceiro"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.grdResumo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblTexto1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tmpDataFim As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents tmpDataInicio As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnPesquisar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblTexto2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblValorMaoObra As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblValorGeral As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblValorPecas As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents grdResumo As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2GroupBox3 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents MaodeObra As DataGridViewTextBoxColumn
    Friend WithEvents Pecas As DataGridViewTextBoxColumn
    Friend WithEvents DataServico As DataGridViewTextBoxColumn
    Friend WithEvents rdbMesAno As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rdbPeriodo As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents cmbAno As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbMes As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
