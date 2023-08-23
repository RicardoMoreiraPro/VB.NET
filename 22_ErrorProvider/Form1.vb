Imports System.ComponentModel

Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_Validating(sender As Object, e As CancelEventArgs) Handles TextBox1.Validating
        If TextBox1.TextLength = 0 Then
            ep_valida.SetError(TextBox1, "Favor informar dados")
        End If
    End Sub
End Class
