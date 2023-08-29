Public Class Form1
    Private objUtil As New Util

    Private Sub btn_rotina_Click(sender As Object, e As EventArgs) Handles btn_rotina.Click
        'objUtil.mostraNome()
        objUtil.nome2 = "Nome do aluno"
        MessageBox.Show(objUtil.nome2 & " " & objUtil.nota2)

        MessageBox.Show(objUtil.media())
    End Sub
End Class
