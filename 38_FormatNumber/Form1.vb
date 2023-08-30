Public Class Form1
    Private Sub btn_formatar_Click(sender As Object, e As EventArgs) Handles btn_formatar.Click
        If IsNumeric(tb_numero.Text) = True Then
            tb_numero.Text = FormatNumber(Convert.ToDouble(tb_numero.Text), 6)
        End If
        MessageBox.Show(tb_numero.Text)
    End Sub
End Class
