Public Class frmProgresso
    Private _podeFechar As Boolean = False



    Private Sub tmSplashTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmSplashTimer.Tick
        Application.DoEvents()
    End Sub

    Public Sub Atualizar(Optional ByVal pStrMensagem As String = "", Optional ByVal pIntProgressoAtual As Integer = 0, Optional ByVal pIntProgressoTotal As Integer = 0)
        If Not String.IsNullOrEmpty(pStrMensagem) Then
            lblMensagem.Text = pStrMensagem
        End If

        If pIntProgressoAtual <> 0 Then
            'prgSplash.Properties.Value = pIntProgressoAtual
            prgSplash.Value = pIntProgressoAtual
        End If

        If pIntProgressoTotal <> 0 Then
            ' prgSplash.Properties.Maximum = pIntProgressoTotal
            prgSplash.Minimum = pIntProgressoTotal

        End If

        Application.DoEvents()
    End Sub

    Public Sub Finalizar()
        _podeFechar = True
        Me.tmSplashTimer.Enabled = False
        Me.Close()
    End Sub

    Public Sub New(ByVal pMensagem As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'prgSplash.Properties.Minimum = 0
        'prgSplash.Properties.Value = 0
        'prgSplash.Properties.Style = Nevron.UI.WinForm.Controls.ProgressBarStyle.Gradient
        prgSplash.Minimum = 0
        prgSplash.Value = 0
        prgSplash.Style = ProgressBarStyle.Marquee
        lblMensagem.Text = pMensagem

        tmSplashTimer.Enabled = True
    End Sub

    Private Sub frmProgresso_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not _podeFechar Then
            e.Cancel = True
        End If
    End Sub

End Class