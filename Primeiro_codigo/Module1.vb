Module Module1
    Dim strMeuNome As String
    Private strNome As String = "Carlito"
    Dim intValor As Integer = 2
    Public dblValor As Double
    Const strName As String = "Barão de mauá"
    Sub Main()
        Dim strTipo As String = String.Empty
        Console.WriteLine("Olá Mundo")
        Console.WriteLine("Digite seu nome:")
        strMeuNome = Console.ReadLine()
        Console.WriteLine("Olá " + strMeuNome)
        Console.ReadLine()
    End Sub

End Module

Module Module2
    Sub Escopo2()
        Module1.dblValor = 5
    End Sub
End Module
