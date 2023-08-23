Public Class Form1
    Private Sub mtb_cpf_KeyDown(sender As Object, e As KeyEventArgs) Handles mtb_cpf.KeyDown
        'If e.KeyCode = Keys.Enter And mtb_cpf.TextLength > 0 Then
        '    If mtb_cpf.TextLength = 11 Then
        '        mtb_cpf.Mask = "###,###,###-##"
        '    End If
        'End If
    End Sub

    Private Sub mtb_cpf_TextChanged(sender As Object, e As EventArgs) Handles mtb_cpf.TextChanged
        If mtb_cpf.TextLength = 11 Then
            mtb_cpf.Mask = "###,###,###-##"
        End If
        mtb_cpf.SelectionStart = mtb_cpf.TextLength
    End Sub
End Class
