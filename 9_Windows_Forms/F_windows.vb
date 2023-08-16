Public Class F_windowns
    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        MessageBox.Show("Botão Ok Executado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        MessageBox.Show("Botão Cancelar Executado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_novoForm_Click(sender As Object, e As EventArgs) Handles btn_novoForm.Click
        'Dim f_novoForm As New F_novoForm
        'f_novoForm.Show()
        Using f_novoForm As New F_novoForm
            f_novoForm.ShowDialog(Me)
        End Using
    End Sub
End Class
