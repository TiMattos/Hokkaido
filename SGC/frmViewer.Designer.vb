<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewer))
        Me.crVisualizador = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crVisualizador
        '
        Me.crVisualizador.ActiveViewIndex = -1
        Me.crVisualizador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crVisualizador.Cursor = System.Windows.Forms.Cursors.Default
        Me.crVisualizador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crVisualizador.Location = New System.Drawing.Point(0, 0)
        Me.crVisualizador.Name = "crVisualizador"
        Me.crVisualizador.Size = New System.Drawing.Size(985, 749)
        Me.crVisualizador.TabIndex = 0
        '
        'frmViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 749)
        Me.Controls.Add(Me.crVisualizador)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewer"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Visualizador"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents crVisualizador As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
