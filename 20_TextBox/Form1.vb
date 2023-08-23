Public Class Form1
    Private Sub tb_dados_TextChanged(sender As Object, e As EventArgs) Handles tb_dados.TextChanged
        If tb_dados.Text = "Ricardo" Then
            MessageBox.Show("Esse é meu nome")
        End If
    End Sub
End Class
