Public Class Form1
    Private Sub btn_executar_Click(sender As Object, e As EventArgs) Handles btn_executar.Click
        intNota = 1
        Soma(10, 20)
        MessageBox.Show(Media(5, 8))
    End Sub
End Class
