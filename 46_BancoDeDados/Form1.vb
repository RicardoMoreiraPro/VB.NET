Imports System.Data.SQLite

Public Class Form1
    Private Sub tsb_cliente_Click(sender As Object, e As EventArgs) Handles tsb_cliente.Click
        Dim fca As New frmConsulta
        fca.ShowDialog()
    End Sub
End Class
