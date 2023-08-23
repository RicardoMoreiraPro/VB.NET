Public Class Form1
    Private Sub btn_adicionar_Click(sender As Object, e As EventArgs) Handles btn_adicionar.Click
        lv_arquivos.Items.Add(InputBox("Digite o nome do item", "Adicionar item"))
    End Sub
End Class
