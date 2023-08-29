Public Class Form1
    ''' <summary>
    ''' Função para somar 2 numeros.
    ''' </summary>
    ''' <param name="int1">informe o primeiro numero</param>
    ''' <param name="int2">informe o segundo numero</param>
    ''' <returns>Soma dos parametros.</returns>
    Private Function Soma(ByRef int1 As Integer, int2 As Integer, Optional int5 As Integer = 0) As Integer
        Dim resultado As Integer = int1 + int2 + int5
        int1 = 10
        int2 = 100
        Return resultado
    End Function

    Private Sub btn_executar_Click(sender As Object, e As EventArgs) Handles btn_executar.Click
        Dim int3 As Integer = 30
        Dim int4 As Integer = 80
        MessageBox.Show(Soma(int3, int4, 200))
        MessageBox.Show(int3)
        MessageBox.Show(int4)
    End Sub
End Class
