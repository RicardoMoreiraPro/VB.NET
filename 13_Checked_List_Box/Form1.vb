Public Class Form1
    Private Sub btn_adicionar_Click(sender As Object, e As EventArgs) Handles btn_adicionar.Click
        CheckedListBox1.Items.Add(4)
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        If CheckedListBox1.GetItemChecked(0) = True Then
            MessageBox.Show("Primeiro item selecionado")
        End If
    End Sub

    Private Sub btn_listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click
        For Each item In CheckedListBox1.Items
            MessageBox.Show(item.ToString)
        Next
    End Sub
End Class
