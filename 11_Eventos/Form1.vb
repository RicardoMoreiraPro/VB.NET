Public Class Form1
    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        MessageBox.Show("Voce clicou no formulario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Voce clicou no Botão", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        'É capturado o evento após pressionar a tecla
        If e.KeyCode = Keys.Enter Then
            MessageBox.Show("Voce pessionou a tecla Enter", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        'É capturado o evento ao pressionar a tecla, sendo possivel a tecla ser interrompida
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
