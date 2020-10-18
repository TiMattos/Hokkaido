<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmExibeDadosCadastro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExibeDadosCadastro))
        Me.btnRemoverVeiculo = New System.Windows.Forms.Button()
        Me.btnProximoVeiculo = New System.Windows.Forms.Button()
        Me.btnVoltarVeiculo = New System.Windows.Forms.Button()
        Me.btnAdicionarVeiculo = New System.Windows.Forms.Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnSair = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSalvar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAlterar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblRegistros = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblAno = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblModelo = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblPlaca = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblVeiculo = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtTelefone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtBairro = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtComplemento = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEndereco = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNome = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRemoverVeiculo
        '
        Me.btnRemoverVeiculo.Image = Global.SGC.My.Resources.Resources.remove_minus_sign
        Me.btnRemoverVeiculo.Location = New System.Drawing.Point(255, 130)
        Me.btnRemoverVeiculo.Name = "btnRemoverVeiculo"
        Me.btnRemoverVeiculo.Size = New System.Drawing.Size(27, 28)
        Me.btnRemoverVeiculo.TabIndex = 26
        Me.btnRemoverVeiculo.UseVisualStyleBackColor = True
        '
        'btnProximoVeiculo
        '
        Me.btnProximoVeiculo.Image = Global.SGC.My.Resources.Resources.arrow_large_right
        Me.btnProximoVeiculo.Location = New System.Drawing.Point(222, 130)
        Me.btnProximoVeiculo.Name = "btnProximoVeiculo"
        Me.btnProximoVeiculo.Size = New System.Drawing.Size(27, 28)
        Me.btnProximoVeiculo.TabIndex = 25
        Me.btnProximoVeiculo.UseVisualStyleBackColor = True
        '
        'btnVoltarVeiculo
        '
        Me.btnVoltarVeiculo.Image = Global.SGC.My.Resources.Resources.arrow_large_left
        Me.btnVoltarVeiculo.Location = New System.Drawing.Point(188, 130)
        Me.btnVoltarVeiculo.Name = "btnVoltarVeiculo"
        Me.btnVoltarVeiculo.Size = New System.Drawing.Size(27, 28)
        Me.btnVoltarVeiculo.TabIndex = 24
        Me.btnVoltarVeiculo.UseVisualStyleBackColor = True
        '
        'btnAdicionarVeiculo
        '
        Me.btnAdicionarVeiculo.Image = Global.SGC.My.Resources.Resources.add
        Me.btnAdicionarVeiculo.Location = New System.Drawing.Point(155, 130)
        Me.btnAdicionarVeiculo.Name = "btnAdicionarVeiculo"
        Me.btnAdicionarVeiculo.Size = New System.Drawing.Size(27, 28)
        Me.btnAdicionarVeiculo.TabIndex = 23
        Me.btnAdicionarVeiculo.UseVisualStyleBackColor = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.btnSair)
        Me.Guna2Panel1.Controls.Add(Me.btnSalvar)
        Me.Guna2Panel1.Controls.Add(Me.btnAlterar)
        Me.Guna2Panel1.Controls.Add(Me.Guna2GroupBox2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2GroupBox1)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(-5, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(539, 510)
        Me.Guna2Panel1.TabIndex = 22
        '
        'btnSair
        '
        Me.btnSair.CheckedState.Parent = Me.btnSair
        Me.btnSair.CustomImages.Parent = Me.btnSair
        Me.btnSair.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSair.ForeColor = System.Drawing.Color.White
        Me.btnSair.HoverState.Parent = Me.btnSair
        Me.btnSair.Location = New System.Drawing.Point(398, 461)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.ShadowDecoration.Parent = Me.btnSair
        Me.btnSair.Size = New System.Drawing.Size(119, 35)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "Sair"
        '
        'btnSalvar
        '
        Me.btnSalvar.CheckedState.Parent = Me.btnSalvar
        Me.btnSalvar.CustomImages.Parent = Me.btnSalvar
        Me.btnSalvar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSalvar.ForeColor = System.Drawing.Color.White
        Me.btnSalvar.HoverState.Parent = Me.btnSalvar
        Me.btnSalvar.Location = New System.Drawing.Point(260, 462)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.ShadowDecoration.Parent = Me.btnSalvar
        Me.btnSalvar.Size = New System.Drawing.Size(119, 35)
        Me.btnSalvar.TabIndex = 3
        Me.btnSalvar.Text = "Salvar"
        '
        'btnAlterar
        '
        Me.btnAlterar.CheckedState.Parent = Me.btnAlterar
        Me.btnAlterar.CustomImages.Parent = Me.btnAlterar
        Me.btnAlterar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAlterar.ForeColor = System.Drawing.Color.White
        Me.btnAlterar.HoverState.Parent = Me.btnAlterar
        Me.btnAlterar.Location = New System.Drawing.Point(18, 462)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.ShadowDecoration.Parent = Me.btnAlterar
        Me.btnAlterar.Size = New System.Drawing.Size(130, 35)
        Me.btnAlterar.TabIndex = 2
        Me.btnAlterar.Text = "Habilitar campos"
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Controls.Add(Me.lblRegistros)
        Me.Guna2GroupBox2.Controls.Add(Me.lblAno)
        Me.Guna2GroupBox2.Controls.Add(Me.btnRemoverVeiculo)
        Me.Guna2GroupBox2.Controls.Add(Me.btnProximoVeiculo)
        Me.Guna2GroupBox2.Controls.Add(Me.lblModelo)
        Me.Guna2GroupBox2.Controls.Add(Me.btnVoltarVeiculo)
        Me.Guna2GroupBox2.Controls.Add(Me.lblPlaca)
        Me.Guna2GroupBox2.Controls.Add(Me.btnAdicionarVeiculo)
        Me.Guna2GroupBox2.Controls.Add(Me.lblVeiculo)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel10)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(18, 269)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(499, 186)
        Me.Guna2GroupBox2.TabIndex = 1
        Me.Guna2GroupBox2.Text = "Dados do Veículo"
        '
        'lblRegistros
        '
        Me.lblRegistros.BackColor = System.Drawing.Color.Transparent
        Me.lblRegistros.Location = New System.Drawing.Point(207, 164)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(0, 0)
        Me.lblRegistros.TabIndex = 27
        Me.lblRegistros.Text = Nothing
        '
        'lblAno
        '
        Me.lblAno.BackColor = System.Drawing.Color.Transparent
        Me.lblAno.Location = New System.Drawing.Point(320, 99)
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Size = New System.Drawing.Size(21, 15)
        Me.lblAno.TabIndex = 7
        Me.lblAno.Text = "ano"
        '
        'lblModelo
        '
        Me.lblModelo.BackColor = System.Drawing.Color.Transparent
        Me.lblModelo.Location = New System.Drawing.Point(320, 59)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(37, 15)
        Me.lblModelo.TabIndex = 6
        Me.lblModelo.Text = "modelo"
        '
        'lblPlaca
        '
        Me.lblPlaca.BackColor = System.Drawing.Color.Transparent
        Me.lblPlaca.Location = New System.Drawing.Point(73, 99)
        Me.lblPlaca.Name = "lblPlaca"
        Me.lblPlaca.Size = New System.Drawing.Size(29, 15)
        Me.lblPlaca.TabIndex = 5
        Me.lblPlaca.Text = "placa"
        '
        'lblVeiculo
        '
        Me.lblVeiculo.BackColor = System.Drawing.Color.Transparent
        Me.lblVeiculo.Location = New System.Drawing.Point(73, 59)
        Me.lblVeiculo.Name = "lblVeiculo"
        Me.lblVeiculo.Size = New System.Drawing.Size(37, 15)
        Me.lblVeiculo.TabIndex = 4
        Me.lblVeiculo.Text = "veiculo"
        '
        'Guna2HtmlLabel10
        '
        Me.Guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel10.Location = New System.Drawing.Point(274, 99)
        Me.Guna2HtmlLabel10.Name = "Guna2HtmlLabel10"
        Me.Guna2HtmlLabel10.Size = New System.Drawing.Size(25, 15)
        Me.Guna2HtmlLabel10.TabIndex = 3
        Me.Guna2HtmlLabel10.Text = "Ano:"
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(28, 99)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(33, 15)
        Me.Guna2HtmlLabel9.TabIndex = 2
        Me.Guna2HtmlLabel9.Text = "Placa:"
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(255, 59)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(41, 15)
        Me.Guna2HtmlLabel8.TabIndex = 1
        Me.Guna2HtmlLabel8.Text = "Modelo:"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(28, 59)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(36, 15)
        Me.Guna2HtmlLabel7.TabIndex = 0
        Me.Guna2HtmlLabel7.Text = "Marca:"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2GroupBox1.Controls.Add(Me.txtEmail)
        Me.Guna2GroupBox1.Controls.Add(Me.txtTelefone)
        Me.Guna2GroupBox1.Controls.Add(Me.txtBairro)
        Me.Guna2GroupBox1.Controls.Add(Me.txtComplemento)
        Me.Guna2GroupBox1.Controls.Add(Me.txtEndereco)
        Me.Guna2GroupBox1.Controls.Add(Me.txtNome)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(18, 11)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(499, 252)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "Dados do Cliente"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(43, 211)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(31, 15)
        Me.Guna2HtmlLabel6.TabIndex = 11
        Me.Guna2HtmlLabel6.Text = "E-mail"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(32, 179)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(45, 15)
        Me.Guna2HtmlLabel5.TabIndex = 10
        Me.Guna2HtmlLabel5.Text = "Telefone"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(46, 147)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(30, 15)
        Me.Guna2HtmlLabel4.TabIndex = 9
        Me.Guna2HtmlLabel4.Text = "Bairro"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(3, 117)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(67, 15)
        Me.Guna2HtmlLabel3.TabIndex = 8
        Me.Guna2HtmlLabel3.Text = "Complemento"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(28, 87)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(49, 15)
        Me.Guna2HtmlLabel2.TabIndex = 7
        Me.Guna2HtmlLabel2.Text = "Endereço"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(43, 53)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(31, 15)
        Me.Guna2HtmlLabel1.TabIndex = 6
        Me.Guna2HtmlLabel1.Text = "Nome"
        '
        'txtEmail
        '
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.Parent = Me.txtEmail
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.Enabled = False
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.FocusedState.Parent = Me.txtEmail
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.HoverState.Parent = Me.txtEmail
        Me.txtEmail.Location = New System.Drawing.Point(90, 204)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderText = ""
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.ShadowDecoration.Parent = Me.txtEmail
        Me.txtEmail.Size = New System.Drawing.Size(394, 26)
        Me.txtEmail.TabIndex = 5
        '
        'txtTelefone
        '
        Me.txtTelefone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTelefone.DefaultText = ""
        Me.txtTelefone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTelefone.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTelefone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTelefone.DisabledState.Parent = Me.txtTelefone
        Me.txtTelefone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTelefone.Enabled = False
        Me.txtTelefone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTelefone.FocusedState.Parent = Me.txtTelefone
        Me.txtTelefone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTelefone.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTelefone.HoverState.Parent = Me.txtTelefone
        Me.txtTelefone.Location = New System.Drawing.Point(90, 172)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefone.PlaceholderText = ""
        Me.txtTelefone.SelectedText = ""
        Me.txtTelefone.ShadowDecoration.Parent = Me.txtTelefone
        Me.txtTelefone.Size = New System.Drawing.Size(394, 26)
        Me.txtTelefone.TabIndex = 4
        '
        'txtBairro
        '
        Me.txtBairro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBairro.DefaultText = ""
        Me.txtBairro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBairro.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBairro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBairro.DisabledState.Parent = Me.txtBairro
        Me.txtBairro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBairro.Enabled = False
        Me.txtBairro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBairro.FocusedState.Parent = Me.txtBairro
        Me.txtBairro.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBairro.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBairro.HoverState.Parent = Me.txtBairro
        Me.txtBairro.Location = New System.Drawing.Point(90, 140)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBairro.PlaceholderText = ""
        Me.txtBairro.SelectedText = ""
        Me.txtBairro.ShadowDecoration.Parent = Me.txtBairro
        Me.txtBairro.Size = New System.Drawing.Size(394, 26)
        Me.txtBairro.TabIndex = 3
        '
        'txtComplemento
        '
        Me.txtComplemento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtComplemento.DefaultText = ""
        Me.txtComplemento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtComplemento.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtComplemento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtComplemento.DisabledState.Parent = Me.txtComplemento
        Me.txtComplemento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtComplemento.Enabled = False
        Me.txtComplemento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtComplemento.FocusedState.Parent = Me.txtComplemento
        Me.txtComplemento.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtComplemento.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtComplemento.HoverState.Parent = Me.txtComplemento
        Me.txtComplemento.Location = New System.Drawing.Point(90, 108)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtComplemento.PlaceholderText = ""
        Me.txtComplemento.SelectedText = ""
        Me.txtComplemento.ShadowDecoration.Parent = Me.txtComplemento
        Me.txtComplemento.Size = New System.Drawing.Size(394, 26)
        Me.txtComplemento.TabIndex = 2
        '
        'txtEndereco
        '
        Me.txtEndereco.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEndereco.DefaultText = ""
        Me.txtEndereco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEndereco.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEndereco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEndereco.DisabledState.Parent = Me.txtEndereco
        Me.txtEndereco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEndereco.Enabled = False
        Me.txtEndereco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEndereco.FocusedState.Parent = Me.txtEndereco
        Me.txtEndereco.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEndereco.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEndereco.HoverState.Parent = Me.txtEndereco
        Me.txtEndereco.Location = New System.Drawing.Point(90, 76)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEndereco.PlaceholderText = ""
        Me.txtEndereco.SelectedText = ""
        Me.txtEndereco.ShadowDecoration.Parent = Me.txtEndereco
        Me.txtEndereco.Size = New System.Drawing.Size(394, 26)
        Me.txtEndereco.TabIndex = 1
        '
        'txtNome
        '
        Me.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNome.DefaultText = ""
        Me.txtNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNome.DisabledState.Parent = Me.txtNome
        Me.txtNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNome.Enabled = False
        Me.txtNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNome.FocusedState.Parent = Me.txtNome
        Me.txtNome.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNome.HoverState.Parent = Me.txtNome
        Me.txtNome.Location = New System.Drawing.Point(90, 44)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNome.PlaceholderText = ""
        Me.txtNome.SelectedText = ""
        Me.txtNome.ShadowDecoration.Parent = Me.txtNome
        Me.txtNome.Size = New System.Drawing.Size(394, 26)
        Me.txtNome.TabIndex = 0
        '
        'frmExibeDadosCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 509)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmExibeDadosCadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dados do Cliente"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRemoverVeiculo As Button
    Friend WithEvents btnProximoVeiculo As Button
    Friend WithEvents btnVoltarVeiculo As Button
    Friend WithEvents btnAdicionarVeiculo As Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnSair As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSalvar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAlterar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblAno As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblModelo As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblPlaca As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblVeiculo As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtTelefone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtBairro As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtComplemento As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEndereco As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNome As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblRegistros As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
