Public Class Form1
    Private conta As Integer = 0
    Private texto As String = "Ricardo Moreira"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'lb_nome.Left += 1
        conta += 1
        If conta > texto.ToString.Length Then
            conta = 0
        End If
        lb_nome.Text = Mid(texto, 1, conta)
    End Sub
End Class
