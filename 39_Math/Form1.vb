Public Class Form1
    Private dblNumero As Double = 1.935
    Private Sub tb_formatar_Click(sender As Object, e As EventArgs) Handles btn_formatar.Click
        MessageBox.Show(Math.Abs(dblNumero))
        tb_numero.Text = Math.Round(dblNumero, 2)
    End Sub
End Class
