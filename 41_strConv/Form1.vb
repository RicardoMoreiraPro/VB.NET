Public Class Form1
    Private Sub btn_formatar_Click(sender As Object, e As EventArgs) Handles btn_formatar.Click
        tb_numero.Text = StrConv(tb_numero.Text, VbStrConv.Uppercase)
    End Sub
End Class
