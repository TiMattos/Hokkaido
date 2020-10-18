<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncluirVeiculo
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIncluirVeiculo))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.txtVeiculo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 15)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Placa:"
        '
        'txtPlaca
        '
        Me.txtPlaca.Location = New System.Drawing.Point(67, 127)
        Me.txtPlaca.MaxLength = 7
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(151, 23)
        Me.txtPlaca.TabIndex = 9
        '
        'txtAno
        '
        Me.txtAno.Location = New System.Drawing.Point(317, 87)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(100, 23)
        Me.txtAno.TabIndex = 8
        '
        'txtVeiculo
        '
        Me.txtVeiculo.Location = New System.Drawing.Point(67, 59)
        Me.txtVeiculo.Name = "txtVeiculo"
        Me.txtVeiculo.Size = New System.Drawing.Size(350, 23)
        Me.txtVeiculo.TabIndex = 12
        Me.txtVeiculo.Text = "HONDA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Modelo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Veículo:"
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(67, 90)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(151, 23)
        Me.txtModelo.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(277, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Ano:"
        '
        'btnSair
        '
        Me.btnSair.Image = Global.SGC.My.Resources.Resources.remove
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(395, 219)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(66, 23)
        Me.btnSair.TabIndex = 23
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Image = Global.SGC.My.Resources.Resources.okay
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(279, 219)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(66, 23)
        Me.btnSalvar.TabIndex = 22
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2GroupBox1)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnSair)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnSalvar)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(-7, 12)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(491, 256)
        Me.Guna2GradientPanel1.TabIndex = 24
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.Label9)
        Me.Guna2GroupBox1.Controls.Add(Me.txtVeiculo)
        Me.Guna2GroupBox1.Controls.Add(Me.txtPlaca)
        Me.Guna2GroupBox1.Controls.Add(Me.Label7)
        Me.Guna2GroupBox1.Controls.Add(Me.txtAno)
        Me.Guna2GroupBox1.Controls.Add(Me.txtModelo)
        Me.Guna2GroupBox1.Controls.Add(Me.Label8)
        Me.Guna2GroupBox1.Controls.Add(Me.Label6)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(19, 13)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(442, 200)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "Dados do Veículo"
        '
        'frmIncluirVeiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 285)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmIncluirVeiculo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Incluir Veículo"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPlaca As TextBox
    Friend WithEvents txtAno As TextBox
    Friend WithEvents txtVeiculo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSair As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
End Class
