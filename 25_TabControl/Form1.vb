Public Class Form1
    Private Sub tc_controles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tc_controles.SelectedIndexChanged
        If tc_controles.SelectedIndex = 0 Then
            MessageBox.Show("Tab 1 selecionada")
        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class
