Public Class Form1
    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        'MessageBox.Show("Voce clicou no formulario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        'É capturado o evento após liberar a tecla pressionada
        If e.KeyCode = Keys.A Then
            MessageBox.Show("Tecla A liberada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub TextBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseDown
        If e.Button = MouseButtons.Right Then
            MessageBox.Show("Botão direito pressionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.Green
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Yellow
    End Sub

    Private Sub Form1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDoubleClick
        MessageBox.Show("Clique duplo acionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Voce tem certeza que deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox1.Text = ""
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        TextBox1.Text = "Digita ai moss"
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        TextBox1.Text = ""
    End Sub
End Class
