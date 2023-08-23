Imports System.Drawing
Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btn_abrir_Click(sender As Object, e As EventArgs) Handles btn_abrir.Click
        ofd_abrir.Filter = "Imagens jpg|*.jpg"
        ofd_abrir.Title = "Selecionar imagem"
        ofd_abrir.FileName = ""
        If ofd_abrir.ShowDialog(Me) = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(ofd_abrir.FileName)
        End If
    End Sub
End Class
