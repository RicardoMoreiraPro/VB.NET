Public Class Form1
    Private Sub rb_opcao1_CheckedChanged(sender As Object, e As EventArgs) Handles rb_opcao1.CheckedChanged
        rb_1.Enabled = rb_opcao1.Checked
        rb_2.Enabled = rb_opcao1.Checked
    End Sub
End Class
