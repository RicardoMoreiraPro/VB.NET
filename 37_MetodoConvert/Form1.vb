Public Class Form1
    Private intNumero As Integer
    Private dblNumero As Double
    Private Sub btn_convert_Click(sender As Object, e As EventArgs) Handles btn_convert.Click
        If IsNumeric(tb_numero.Text) = True Then
            intNumero = Convert.ToInt32(tb_numero.Text)
            dblNumero = Convert.ToDouble(tb_numero.Text)
        End If
        MessageBox.Show(intNumero)
        MessageBox.Show(dblNumero)
    End Sub
End Class
