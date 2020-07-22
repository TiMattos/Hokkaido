Public Class frmMensagem

    Private strMensagem As String
    Sub New(ByVal pMensagem As String)

        ' This call is required by the designer.
        InitializeComponent()
        strMensagem = pMensagem
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmMensagem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblMensagem.Text = strMensagem
    End Sub
End Class