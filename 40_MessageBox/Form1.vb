Public Class Form1
    Private Sub btn_formatar_Click(sender As Object, e As EventArgs) Handles btn_formatar.Click
        'If MessageBox.Show("Mensagem", "Titulo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
        '    tb_numero.Text = "Clicou no OK"
        'Else
        '    tb_numero.Text = "Clicou no cancelar"
        'End If
        Dim result = MessageBox.Show("Mensagem", "Titulo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Yes Then
            tb_numero.Text = "Clicou no Yes"
        ElseIf result = DialogResult.No Then
            tb_numero.Text = "Clicou no No"
        Else
            tb_numero.Text = "Clicou no Cancel"
        End If
    End Sub
End Class
