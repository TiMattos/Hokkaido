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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnPesquisar = New Guna.UI2.WinForms.Guna2Button()
        Me.lblTexto2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblTexto1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tmpDataFim = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.tmpDataInicio = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.DsServicosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsServicos = New SGC.dsServicos()
        Me.Guna2GroupBox3 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.grdResumo = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaodeObra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pecas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataServico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblValorMaoObra = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblValorGeral = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblValorPecas = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.DsServicosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnFechar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsServicosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsServicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox3.SuspendLayout()
        CType(Me.grdResumo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox2.SuspendLayout()
        CType(Me.DsServicosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
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
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(675, 130)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "Filtro"
        '
        'btnPesquisar
        '
        Me.btnPesquisar.CheckedState.Parent = Me.btnPesquisar
        Me.btnPesquisar.CustomImages.Parent = Me.btnPesquisar
        Me.btnPesquisar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPesquisar.ForeColor = System.Drawing.Color.White
        Me.btnPesquisar.HoverState.Parent = Me.btnPesquisar
        Me.btnPesquisar.Location = New System.Drawing.Point(531, 72)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.ShadowDecoration.Parent = Me.btnPesquisar
        Me.btnPesquisar.Size = New System.Drawing.Size(129, 36)
        Me.btnPesquisar.TabIndex = 4
        Me.btnPesquisar.Text = "Pesquisar"
        '
        'lblTexto2
        '
        Me.lblTexto2.BackColor = System.Drawing.Color.Transparent
        Me.lblTexto2.Location = New System.Drawing.Point(266, 51)
        Me.lblTexto2.Name = "lblTexto2"
        Me.lblTexto2.Size = New System.Drawing.Size(19, 15)
        Me.lblTexto2.TabIndex = 3
        Me.lblTexto2.Text = "Até"
        '
        'lblTexto1
        '
        Me.lblTexto1.BackColor = System.Drawing.Color.Transparent
        Me.lblTexto1.Location = New System.Drawing.Point(14, 51)
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
        Me.tmpDataFim.Location = New System.Drawing.Point(266, 72)
        Me.tmpDataFim.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.tmpDataFim.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.tmpDataFim.Name = "tmpDataFim"
        Me.tmpDataFim.ShadowDecoration.Parent = Me.tmpDataFim
        Me.tmpDataFim.Size = New System.Drawing.Size(232, 36)
        Me.tmpDataFim.TabIndex = 1
        Me.tmpDataFim.Value = New Date(2020, 10, 26, 0, 0, 0, 0)
        '
        'tmpDataInicio
        '
        Me.tmpDataInicio.CheckedState.Parent = Me.tmpDataInicio
        Me.tmpDataInicio.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tmpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tmpDataInicio.HoverState.Parent = Me.tmpDataInicio
        Me.tmpDataInicio.Location = New System.Drawing.Point(14, 72)
        Me.tmpDataInicio.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.tmpDataInicio.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.tmpDataInicio.Name = "tmpDataInicio"
        Me.tmpDataInicio.ShadowDecoration.Parent = Me.tmpDataInicio
        Me.tmpDataInicio.Size = New System.Drawing.Size(232, 36)
        Me.tmpDataInicio.TabIndex = 0
        Me.tmpDataInicio.Value = New Date(2020, 10, 26, 0, 0, 0, 0)
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.btnFechar)
        Me.Guna2Panel1.Controls.Add(Me.Chart1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2GroupBox3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2GroupBox2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2GroupBox1)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(-2, -1)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1245, 591)
        Me.Guna2Panel1.TabIndex = 1
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
        Me.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea1.AlignmentOrientation = CType((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical Or System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal), System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)
        ChartArea1.AxisX.Title = "Anos"
        ChartArea1.AxisY.Title = "R$"
        ChartArea1.IsSameFontSizeForAllAxes = True
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.DataSource = Me.DsServicosBindingSource1
        Legend1.Alignment = System.Drawing.StringAlignment.Center
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(14, 314)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series1.ChartArea = "ChartArea1"
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsValueShownAsLabel = True
        Series1.LabelForeColor = System.Drawing.Color.DarkGreen
        Series1.Legend = "Legend1"
        Series1.LegendText = "Ano Vigente"
        Series1.LegendToolTip = "ano atual"
        Series1.MarkerSize = 2
        Series1.Name = "Atual"
        Series2.ChartArea = "ChartArea1"
        Series2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series2.IsValueShownAsLabel = True
        Series2.LabelForeColor = System.Drawing.Color.DarkSeaGreen
        Series2.Legend = "Legend1"
        Series2.LegendText = "Ano Anterior"
        Series2.LegendToolTip = "Resultados do ano anterior."
        Series2.Name = "Passado"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(1209, 215)
        Me.Chart1.TabIndex = 3
        Me.Chart1.Text = "Chart1"
        '
        'DsServicosBindingSource1
        '
        Me.DsServicosBindingSource1.DataSource = Me.DsServicos
        Me.DsServicosBindingSource1.Position = 0
        '
        'DsServicos
        '
        Me.DsServicos.DataSetName = "dsServicos"
        Me.DsServicos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Guna2GroupBox3
        '
        Me.Guna2GroupBox3.Controls.Add(Me.grdResumo)
        Me.Guna2GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox3.Location = New System.Drawing.Point(706, 13)
        Me.Guna2GroupBox3.Name = "Guna2GroupBox3"
        Me.Guna2GroupBox3.ShadowDecoration.Parent = Me.Guna2GroupBox3
        Me.Guna2GroupBox3.Size = New System.Drawing.Size(517, 295)
        Me.Guna2GroupBox3.TabIndex = 2
        Me.Guna2GroupBox3.Text = "Serviços realizados dentro do filtro informado"
        '
        'grdResumo
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.grdResumo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdResumo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdResumo.BackgroundColor = System.Drawing.Color.White
        Me.grdResumo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdResumo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdResumo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdResumo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdResumo.ColumnHeadersHeight = 15
        Me.grdResumo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cliente, Me.MaodeObra, Me.Pecas, Me.DataServico})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdResumo.DefaultCellStyle = DataGridViewCellStyle3
        Me.grdResumo.EnableHeadersVisualStyles = False
        Me.grdResumo.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdResumo.Location = New System.Drawing.Point(16, 55)
        Me.grdResumo.Name = "grdResumo"
        Me.grdResumo.RowHeadersVisible = False
        Me.grdResumo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdResumo.Size = New System.Drawing.Size(484, 226)
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
        Me.grdResumo.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.grdResumo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.grdResumo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.grdResumo.ThemeStyle.HeaderStyle.Height = 15
        Me.grdResumo.ThemeStyle.ReadOnly = False
        Me.grdResumo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.grdResumo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdResumo.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.grdResumo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
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
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(14, 149)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(675, 159)
        Me.Guna2GroupBox2.TabIndex = 1
        Me.Guna2GroupBox2.Text = "Resumo"
        '
        'lblValorMaoObra
        '
        Me.lblValorMaoObra.BackColor = System.Drawing.Color.Transparent
        Me.lblValorMaoObra.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorMaoObra.Location = New System.Drawing.Point(266, 62)
        Me.lblValorMaoObra.Name = "lblValorMaoObra"
        Me.lblValorMaoObra.Size = New System.Drawing.Size(3, 2)
        Me.lblValorMaoObra.TabIndex = 6
        Me.lblValorMaoObra.Text = Nothing
        '
        'lblValorGeral
        '
        Me.lblValorGeral.BackColor = System.Drawing.Color.Transparent
        Me.lblValorGeral.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorGeral.Location = New System.Drawing.Point(266, 108)
        Me.lblValorGeral.Name = "lblValorGeral"
        Me.lblValorGeral.Size = New System.Drawing.Size(3, 2)
        Me.lblValorGeral.TabIndex = 4
        Me.lblValorGeral.Text = Nothing
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
        Me.lblValorPecas.Size = New System.Drawing.Size(3, 2)
        Me.lblValorPecas.TabIndex = 2
        Me.lblValorPecas.Text = Nothing
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
        'DsServicosBindingSource
        '
        Me.DsServicosBindingSource.DataSource = Me.DsServicos
        Me.DsServicosBindingSource.Position = 0
        '
        'btnFechar
        '
        Me.btnFechar.CheckedState.Parent = Me.btnFechar
        Me.btnFechar.CustomImages.Parent = Me.btnFechar
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnFechar.ForeColor = System.Drawing.Color.White
        Me.btnFechar.HoverState.Parent = Me.btnFechar
        Me.btnFechar.Location = New System.Drawing.Point(1094, 534)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.ShadowDecoration.Parent = Me.btnFechar
        Me.btnFechar.Size = New System.Drawing.Size(129, 36)
        Me.btnFechar.TabIndex = 5
        Me.btnFechar.Text = "Fechar"
        '
        'frmExibeBalancoFinanceiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1242, 571)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmExibeBalancoFinanceiro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmExibeBalancoFinanceiro"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsServicosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsServicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox3.ResumeLayout(False)
        CType(Me.grdResumo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        CType(Me.DsServicosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents DsServicosBindingSource1 As BindingSource
    Friend WithEvents DsServicos As dsServicos
    Friend WithEvents DsServicosBindingSource As BindingSource
    Friend WithEvents btnFechar As Guna.UI2.WinForms.Guna2Button
End Class
