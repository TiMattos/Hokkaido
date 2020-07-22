<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServicos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServicos))
        Me.txtItensManutencao = New System.Windows.Forms.TextBox()
        Me.txtKm = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNomeCliente = New System.Windows.Forms.Label()
        Me.lblVeiculo = New System.Windows.Forms.Label()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.lblAno = New System.Windows.Forms.Label()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPlaca = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbVeiculos = New System.Windows.Forms.ComboBox()
        Me.lblAlerta = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtKmAtual = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rdbServico = New System.Windows.Forms.RadioButton()
        Me.rdbRevisao = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMaodeObra = New System.Windows.Forms.TextBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtItensManutencao
        '
        Me.txtItensManutencao.Location = New System.Drawing.Point(16, 17)
        Me.txtItensManutencao.Multiline = True
        Me.txtItensManutencao.Name = "txtItensManutencao"
        Me.txtItensManutencao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtItensManutencao.Size = New System.Drawing.Size(456, 218)
        Me.txtItensManutencao.TabIndex = 5
        '
        'txtKm
        '
        Me.txtKm.Location = New System.Drawing.Point(87, 44)
        Me.txtKm.Name = "txtKm"
        Me.txtKm.Size = New System.Drawing.Size(54, 20)
        Me.txtKm.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Revisão de "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(147, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Mil Kms"
        '
        'lblNomeCliente
        '
        Me.lblNomeCliente.AutoSize = True
        Me.lblNomeCliente.Location = New System.Drawing.Point(118, 39)
        Me.lblNomeCliente.Name = "lblNomeCliente"
        Me.lblNomeCliente.Size = New System.Drawing.Size(33, 13)
        Me.lblNomeCliente.TabIndex = 21
        Me.lblNomeCliente.Text = "nome"
        '
        'lblVeiculo
        '
        Me.lblVeiculo.AutoSize = True
        Me.lblVeiculo.Location = New System.Drawing.Point(118, 90)
        Me.lblVeiculo.Name = "lblVeiculo"
        Me.lblVeiculo.Size = New System.Drawing.Size(41, 13)
        Me.lblVeiculo.TabIndex = 22
        Me.lblVeiculo.Text = "veiculo"
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Location = New System.Drawing.Point(118, 116)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(41, 13)
        Me.lblModelo.TabIndex = 23
        Me.lblModelo.Text = "modelo"
        '
        'lblAno
        '
        Me.lblAno.AutoSize = True
        Me.lblAno.Location = New System.Drawing.Point(288, 90)
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Size = New System.Drawing.Size(25, 13)
        Me.lblAno.TabIndex = 24
        Me.lblAno.Text = "ano"
        '
        'btnSalvar
        '
        Me.btnSalvar.Image = Global.SGC.My.Resources.Resources.check
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(338, 659)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 7
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Image = Global.SGC.My.Resources.Resources.remove
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(426, 659)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 23)
        Me.btnSair.TabIndex = 8
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Proprietário:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Veículo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Modelo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(251, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Ano:"
        '
        'lblPlaca
        '
        Me.lblPlaca.AutoSize = True
        Me.lblPlaca.Location = New System.Drawing.Point(288, 116)
        Me.lblPlaca.Name = "lblPlaca"
        Me.lblPlaca.Size = New System.Drawing.Size(33, 13)
        Me.lblPlaca.TabIndex = 31
        Me.lblPlaca.Text = "placa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(243, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Placa:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cmbVeiculos)
        Me.GroupBox1.Controls.Add(Me.lblAlerta)
        Me.GroupBox1.Controls.Add(Me.lblPlaca)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblNomeCliente)
        Me.GroupBox1.Controls.Add(Me.lblVeiculo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblModelo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblAno)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(489, 140)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados do Veículo"
        '
        'cmbVeiculos
        '
        Me.cmbVeiculos.FormattingEnabled = True
        Me.cmbVeiculos.Location = New System.Drawing.Point(118, 60)
        Me.cmbVeiculos.Name = "cmbVeiculos"
        Me.cmbVeiculos.Size = New System.Drawing.Size(200, 21)
        Me.cmbVeiculos.TabIndex = 34
        '
        'lblAlerta
        '
        Me.lblAlerta.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlerta.ForeColor = System.Drawing.Color.Red
        Me.lblAlerta.Location = New System.Drawing.Point(18, 17)
        Me.lblAlerta.Name = "lblAlerta"
        Me.lblAlerta.Size = New System.Drawing.Size(465, 13)
        Me.lblAlerta.TabIndex = 33
        Me.lblAlerta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtKmAtual)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.rdbServico)
        Me.GroupBox2.Controls.Add(Me.rdbRevisao)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtMaodeObra)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtKm)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 149)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(489, 78)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dados da Revisão"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(410, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Mil Kms"
        '
        'txtKmAtual
        '
        Me.txtKmAtual.Location = New System.Drawing.Point(326, 15)
        Me.txtKmAtual.Name = "txtKmAtual"
        Me.txtKmAtual.Size = New System.Drawing.Size(78, 20)
        Me.txtKmAtual.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(267, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Km atual:"
        '
        'rdbServico
        '
        Me.rdbServico.AutoSize = True
        Me.rdbServico.Location = New System.Drawing.Point(100, 19)
        Me.rdbServico.Name = "rdbServico"
        Me.rdbServico.Size = New System.Drawing.Size(61, 17)
        Me.rdbServico.TabIndex = 2
        Me.rdbServico.TabStop = True
        Me.rdbServico.Text = "Serviço"
        Me.rdbServico.UseVisualStyleBackColor = True
        '
        'rdbRevisao
        '
        Me.rdbRevisao.AutoSize = True
        Me.rdbRevisao.Location = New System.Drawing.Point(18, 19)
        Me.rdbRevisao.Name = "rdbRevisao"
        Me.rdbRevisao.Size = New System.Drawing.Size(64, 17)
        Me.rdbRevisao.TabIndex = 1
        Me.rdbRevisao.TabStop = True
        Me.rdbRevisao.Text = "Revisão"
        Me.rdbRevisao.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(250, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Mão de obra:"
        '
        'txtMaodeObra
        '
        Me.txtMaodeObra.Location = New System.Drawing.Point(326, 45)
        Me.txtMaodeObra.Name = "txtMaodeObra"
        Me.txtMaodeObra.Size = New System.Drawing.Size(127, 20)
        Me.txtMaodeObra.TabIndex = 4
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(19, 21)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs.Size = New System.Drawing.Size(455, 138)
        Me.txtObs.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtObs)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 484)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(489, 169)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Observações"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtItensManutencao)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 233)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(488, 245)
        Me.GroupBox4.TabIndex = 37
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Descrição"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 13)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Selecione o Veículo:"
        '
        'frmServicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 694)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnSalvar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmServicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Serviços"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtItensManutencao As TextBox
    Friend WithEvents txtKm As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNomeCliente As Label
    Friend WithEvents lblVeiculo As Label
    Friend WithEvents lblModelo As Label
    Friend WithEvents lblAno As Label
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPlaca As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMaodeObra As TextBox
    Friend WithEvents txtObs As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rdbServico As RadioButton
    Friend WithEvents rdbRevisao As RadioButton
    Friend WithEvents lblAlerta As Label
    Friend WithEvents txtKmAtual As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbVeiculos As ComboBox
    Friend WithEvents Label11 As Label
End Class
