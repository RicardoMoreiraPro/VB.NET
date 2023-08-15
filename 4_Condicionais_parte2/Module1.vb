Module Module1
    Private nota1 As Double
    Private nota2 As Double
    Private nota3 As Double
    Private nota4 As Double
    Private media As Double
    Sub Main()
        Console.WriteLine("Informe a nota 1")
        nota1 = Console.ReadLine()
        Console.WriteLine("Informe a nota 2")
        nota2 = Console.ReadLine()
        Console.WriteLine("Informe a nota 3")
        nota3 = Console.ReadLine()
        Console.WriteLine("Informe a nota 4")
        nota4 = Console.ReadLine()
        media = (nota1 + nota2 + nota3 + nota4) / 4

        If (media >= 6) Then
            Console.WriteLine("Aprovado, nota: " & media)
        Else
            Console.WriteLine("Reprovado, nota: " & media)
        End If
        Console.ReadLine()
        Select Case media
            Case >= 6
                Console.WriteLine("Aprovado, nota: " & media)
            Case Else
                Console.WriteLine("Reprovado, nota: " & media)
        End Select
        Console.ReadLine()
    End Sub

End Module
