Public Class Form1
    ''' <summary>
    ''' Sub rotina para passar o nome e o ano do cliente.
    ''' </summary>
    ''' <param name="strNome">Informe o nome do cliente</param>
    ''' <param name="intAno">Informe quantos anos o cliente tem</param>
    Private Sub Ativa(ByRef strNome As String, ByVal intAno As Integer, Optional bln As Boolean = False)
        MessageBox.Show("O nome do cliente é " & strNome & "." & vbNewLine &
                        "A idade é " & intAno, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        strNome = "Barão"
    End Sub

    Private Sub btn_executar_Click(sender As Object, e As EventArgs) Handles btn_executar.Click
        Dim nome As String = "Ricardo"
        Ativa(nome, 25)
        MessageBox.Show("Barão")
    End Sub
End Class
