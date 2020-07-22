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
        Me.lblVeiculo = New System.Windows.Forms.Label()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.lblPlaca = New System.Windows.Forms.Label()
        Me.lblAno = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblRegistros = New System.Windows.Forms.Label()
        Me.btnRemoverVeiculo = New System.Windows.Forms.Button()
        Me.btnProximoVeiculo = New System.Windows.Forms.Button()
        Me.btnVoltarVeiculo = New System.Windows.Forms.Button()
        Me.btnAdicionarVeiculo = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblVeiculo
        '
        Me.lblVeiculo.AutoSize = True
        Me.lblVeiculo.Location = New System.Drawing.Point(77, 39)
        Me.lblVeiculo.Name = "lblVeiculo"
        Me.lblVeiculo.Size = New System.Drawing.Size(41, 13)
        Me.lblVeiculo.TabIndex = 4
        Me.lblVeiculo.Text = "veiculo"
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Location = New System.Drawing.Point(268, 39)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(41, 13)
        Me.lblModelo.TabIndex = 5
        Me.lblModelo.Text = "modelo"
        '
        'lblPlaca
        '
        Me.lblPlaca.AutoSize = True
        Me.lblPlaca.Location = New System.Drawing.Point(70, 81)
        Me.lblPlaca.Name = "lblPlaca"
        Me.lblPlaca.Size = New System.Drawing.Size(33, 13)
        Me.lblPlaca.TabIndex = 6
        Me.lblPlaca.Text = "placa"
        '
        'lblAno
        '
        Me.lblAno.AutoSize = True
        Me.lblAno.Location = New System.Drawing.Point(245, 81)
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Size = New System.Drawing.Size(25, 13)
        Me.lblAno.TabIndex = 7
        Me.lblAno.Text = "ano"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "VEÍCULO:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(206, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "MODELO:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(20, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "PLACA:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtTelefone)
        Me.GroupBox1.Controls.Add(Me.txtBairro)
        Me.GroupBox1.Controls.Add(Me.txtComplemento)
        Me.GroupBox1.Controls.Add(Me.txtEndereco)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(469, 213)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados Cliente"
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(110, 185)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(326, 20)
        Me.txtEmail.TabIndex = 26
        '
        'txtTelefone
        '
        Me.txtTelefone.Enabled = False
        Me.txtTelefone.Location = New System.Drawing.Point(110, 157)
        Me.txtTelefone.MaxLength = 11
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(326, 20)
        Me.txtTelefone.TabIndex = 25
        '
        'txtBairro
        '
        Me.txtBairro.Enabled = False
        Me.txtBairro.Location = New System.Drawing.Point(110, 125)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(326, 20)
        Me.txtBairro.TabIndex = 24
        '
        'txtComplemento
        '
        Me.txtComplemento.Enabled = False
        Me.txtComplemento.Location = New System.Drawing.Point(110, 95)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(326, 20)
        Me.txtComplemento.TabIndex = 23
        '
        'txtEndereco
        '
        Me.txtEndereco.Enabled = False
        Me.txtEndereco.Location = New System.Drawing.Point(110, 61)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(326, 20)
        Me.txtEndereco.TabIndex = 22
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.Location = New System.Drawing.Point(110, 31)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(326, 20)
        Me.txtNome.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(62, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "EMAIL:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "TELEFONE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "COMPLEMENTO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "BAIRRO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "ENDEREÇO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "NOME:"
        '
        'btnAlterar
        '
        Me.btnAlterar.Image = Global.SGC.My.Resources.Resources.contact_blue_edit
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlterar.Location = New System.Drawing.Point(27, 449)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(126, 23)
        Me.btnAlterar.TabIndex = 20
        Me.btnAlterar.Text = "Habilitar campos"
        Me.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblRegistros)
        Me.GroupBox2.Controls.Add(Me.btnRemoverVeiculo)
        Me.GroupBox2.Controls.Add(Me.btnProximoVeiculo)
        Me.GroupBox2.Controls.Add(Me.btnVoltarVeiculo)
        Me.GroupBox2.Controls.Add(Me.btnAdicionarVeiculo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblModelo)
        Me.GroupBox2.Controls.Add(Me.lblVeiculo)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.lblPlaca)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lblAno)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 254)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(468, 189)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dados Veículo"
        '
        'lblRegistros
        '
        Me.lblRegistros.AutoSize = True
        Me.lblRegistros.Location = New System.Drawing.Point(196, 163)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(0, 13)
        Me.lblRegistros.TabIndex = 28
        '
        'btnRemoverVeiculo
        '
        Me.btnRemoverVeiculo.Image = Global.SGC.My.Resources.Resources.remove_minus_sign
        Me.btnRemoverVeiculo.Location = New System.Drawing.Point(256, 127)
        Me.btnRemoverVeiculo.Name = "btnRemoverVeiculo"
        Me.btnRemoverVeiculo.Size = New System.Drawing.Size(27, 28)
        Me.btnRemoverVeiculo.TabIndex = 26
        Me.btnRemoverVeiculo.UseVisualStyleBackColor = True
        '
        'btnProximoVeiculo
        '
        Me.btnProximoVeiculo.Image = Global.SGC.My.Resources.Resources.arrow_large_right
        Me.btnProximoVeiculo.Location = New System.Drawing.Point(223, 127)
        Me.btnProximoVeiculo.Name = "btnProximoVeiculo"
        Me.btnProximoVeiculo.Size = New System.Drawing.Size(27, 28)
        Me.btnProximoVeiculo.TabIndex = 25
        Me.btnProximoVeiculo.UseVisualStyleBackColor = True
        '
        'btnVoltarVeiculo
        '
        Me.btnVoltarVeiculo.Image = Global.SGC.My.Resources.Resources.arrow_large_left
        Me.btnVoltarVeiculo.Location = New System.Drawing.Point(189, 127)
        Me.btnVoltarVeiculo.Name = "btnVoltarVeiculo"
        Me.btnVoltarVeiculo.Size = New System.Drawing.Size(27, 28)
        Me.btnVoltarVeiculo.TabIndex = 24
        Me.btnVoltarVeiculo.UseVisualStyleBackColor = True
        '
        'btnAdicionarVeiculo
        '
        Me.btnAdicionarVeiculo.Image = Global.SGC.My.Resources.Resources.add
        Me.btnAdicionarVeiculo.Location = New System.Drawing.Point(156, 127)
        Me.btnAdicionarVeiculo.Name = "btnAdicionarVeiculo"
        Me.btnAdicionarVeiculo.Size = New System.Drawing.Size(27, 28)
        Me.btnAdicionarVeiculo.TabIndex = 23
        Me.btnAdicionarVeiculo.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(206, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "ANO:"
        '
        'btnSair
        '
        Me.btnSair.Image = Global.SGC.My.Resources.Resources.remove
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(435, 449)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(59, 23)
        Me.btnSair.TabIndex = 14
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Enabled = False
        Me.btnSalvar.Image = Global.SGC.My.Resources.Resources.okay
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(350, 449)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(69, 23)
        Me.btnSalvar.TabIndex = 21
        Me.btnSalvar.Text = "Salvar alterações"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'frmExibeDadosCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 483)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAlterar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmExibeDadosCadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dados do Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblVeiculo As Label
    Friend WithEvents lblModelo As Label
    Friend WithEvents lblPlaca As Label
    Friend WithEvents lblAno As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSair As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtTelefone As TextBox
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents txtComplemento As TextBox
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents btnAlterar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents lblRegistros As Label
    Friend WithEvents btnRemoverVeiculo As Button
    Friend WithEvents btnProximoVeiculo As Button
    Friend WithEvents btnVoltarVeiculo As Button
    Friend WithEvents btnAdicionarVeiculo As Button
End Class
