<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgresso
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
        Me.components = New System.ComponentModel.Container()
        Me.lblMensagem = New System.Windows.Forms.Label()
        Me.prgSplash = New System.Windows.Forms.ProgressBar()
        Me.tmSplashTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblMensagem
        '
        Me.lblMensagem.AutoSize = True
        Me.lblMensagem.Location = New System.Drawing.Point(191, 16)
        Me.lblMensagem.Name = "lblMensagem"
        Me.lblMensagem.Size = New System.Drawing.Size(39, 13)
        Me.lblMensagem.TabIndex = 0
        Me.lblMensagem.Text = "Label1"
        '
        'prgSplash
        '
        Me.prgSplash.Location = New System.Drawing.Point(12, 35)
        Me.prgSplash.Name = "prgSplash"
        Me.prgSplash.Size = New System.Drawing.Size(412, 23)
        Me.prgSplash.TabIndex = 1
        '
        'tmSplashTimer
        '
        '
        'frmProgresso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 91)
        Me.Controls.Add(Me.prgSplash)
        Me.Controls.Add(Me.lblMensagem)
        Me.Name = "frmProgresso"
        Me.Text = "frmProgresso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMensagem As Label
    Friend WithEvents prgSplash As ProgressBar
    Friend WithEvents tmSplashTimer As Timer
End Class
