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
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tmpDataFim = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.tmpDataInicio = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnPesquisar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.btnPesquisar)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2GroupBox1.Controls.Add(Me.tmpDataFim)
        Me.Guna2GroupBox1.Controls.Add(Me.tmpDataInicio)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(14, 13)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(517, 157)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "Filtro"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(14, 50)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(17, 17)
        Me.Guna2HtmlLabel1.TabIndex = 2
        Me.Guna2HtmlLabel1.Text = "De"
        '
        'tmpDataFim
        '
        Me.tmpDataFim.CheckedState.Parent = Me.tmpDataFim
        Me.tmpDataFim.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tmpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.tmpDataFim.HoverState.Parent = Me.tmpDataFim
        Me.tmpDataFim.Location = New System.Drawing.Point(266, 71)
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
        Me.tmpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.tmpDataInicio.HoverState.Parent = Me.tmpDataInicio
        Me.tmpDataInicio.Location = New System.Drawing.Point(14, 71)
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
        Me.Guna2Panel1.Controls.Add(Me.Guna2GroupBox2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2GroupBox1)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(-2, -1)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(562, 494)
        Me.Guna2Panel1.TabIndex = 1
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(266, 50)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(21, 17)
        Me.Guna2HtmlLabel2.TabIndex = 3
        Me.Guna2HtmlLabel2.Text = "Até"
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(14, 195)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(517, 281)
        Me.Guna2GroupBox2.TabIndex = 1
        Me.Guna2GroupBox2.Text = "Guna2GroupBox2"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(14, 62)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(98, 17)
        Me.Guna2HtmlLabel3.TabIndex = 0
        Me.Guna2HtmlLabel3.Text = "Guna2HtmlLabel3"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(14, 85)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(98, 17)
        Me.Guna2HtmlLabel4.TabIndex = 1
        Me.Guna2HtmlLabel4.Text = "Guna2HtmlLabel4"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(148, 85)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(98, 17)
        Me.Guna2HtmlLabel5.TabIndex = 2
        Me.Guna2HtmlLabel5.Text = "Guna2HtmlLabel5"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(14, 108)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(98, 17)
        Me.Guna2HtmlLabel6.TabIndex = 3
        Me.Guna2HtmlLabel6.Text = "Guna2HtmlLabel6"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(148, 108)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(98, 17)
        Me.Guna2HtmlLabel7.TabIndex = 4
        Me.Guna2HtmlLabel7.Text = "Guna2HtmlLabel7"
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(14, 210)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(98, 17)
        Me.Guna2HtmlLabel8.TabIndex = 5
        Me.Guna2HtmlLabel8.Text = "Guna2HtmlLabel8"
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(148, 62)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(98, 17)
        Me.Guna2HtmlLabel9.TabIndex = 6
        Me.Guna2HtmlLabel9.Text = "Guna2HtmlLabel9"
        '
        'btnPesquisar
        '
        Me.btnPesquisar.CheckedState.Parent = Me.btnPesquisar
        Me.btnPesquisar.CustomImages.Parent = Me.btnPesquisar
        Me.btnPesquisar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPesquisar.ForeColor = System.Drawing.Color.White
        Me.btnPesquisar.HoverState.Parent = Me.btnPesquisar
        Me.btnPesquisar.Location = New System.Drawing.Point(369, 113)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.ShadowDecoration.Parent = Me.btnPesquisar
        Me.btnPesquisar.Size = New System.Drawing.Size(129, 41)
        Me.btnPesquisar.TabIndex = 4
        Me.btnPesquisar.Text = "Pesquisar"
        '
        'frmExibeBalancoFinanceiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 487)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "frmExibeBalancoFinanceiro"
        Me.Text = "frmExibeBalancoFinanceiro"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tmpDataFim As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents tmpDataInicio As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnPesquisar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
