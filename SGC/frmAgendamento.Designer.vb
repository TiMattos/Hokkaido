<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgendamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgendamento))
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDataAgendamento = New System.Windows.Forms.DateTimePicker()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.dtpHoraAgendamento = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(75, 40)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(39, 13)
        Me.lblNome.TabIndex = 0
        Me.lblNome.Text = "Label1"
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(74, 65)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(39, 13)
        Me.lblEndereco.TabIndex = 1
        Me.lblEndereco.Text = "Label2"
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Location = New System.Drawing.Point(74, 91)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(39, 13)
        Me.lblTelefone.TabIndex = 2
        Me.lblTelefone.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Data:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Endereço:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Telefone:"
        '
        'dtpDataAgendamento
        '
        Me.dtpDataAgendamento.Location = New System.Drawing.Point(64, 152)
        Me.dtpDataAgendamento.Name = "dtpDataAgendamento"
        Me.dtpDataAgendamento.Size = New System.Drawing.Size(272, 20)
        Me.dtpDataAgendamento.TabIndex = 7
        '
        'btnSalvar
        '
        Me.btnSalvar.Image = Global.SGC.My.Resources.Resources.okay
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(134, 209)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(65, 23)
        Me.btnSalvar.TabIndex = 8
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Image = Global.SGC.My.Resources.Resources.remove
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(230, 209)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(65, 23)
        Me.btnSair.TabIndex = 9
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'dtpHoraAgendamento
        '
        Me.dtpHoraAgendamento.CustomFormat = "hh:mm"
        Me.dtpHoraAgendamento.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraAgendamento.Location = New System.Drawing.Point(342, 152)
        Me.dtpHoraAgendamento.Name = "dtpHoraAgendamento"
        Me.dtpHoraAgendamento.ShowUpDown = True
        Me.dtpHoraAgendamento.Size = New System.Drawing.Size(83, 20)
        Me.dtpHoraAgendamento.TabIndex = 10
        '
        'frmAgendamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 244)
        Me.Controls.Add(Me.dtpHoraAgendamento)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.dtpDataAgendamento)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTelefone)
        Me.Controls.Add(Me.lblEndereco)
        Me.Controls.Add(Me.lblNome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAgendamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agendamento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNome As Label
    Friend WithEvents lblEndereco As Label
    Friend WithEvents lblTelefone As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDataAgendamento As DateTimePicker
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents dtpHoraAgendamento As DateTimePicker
End Class
