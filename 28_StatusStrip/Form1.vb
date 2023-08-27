Public Class Form1
    Private Sub btn_iniciar_MouseEnter(sender As Object, e As EventArgs) Handles btn_iniciar.MouseEnter
        tssl_principal.Text = "Botão iniciar"
    End Sub

    Private Sub Form1_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        tssl_principal.Text = ""
    End Sub
End Class
