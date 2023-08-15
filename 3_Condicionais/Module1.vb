Module Module1

    Sub Main()
        Dim num1 As Integer = 5

        If num1 < 5 Then
            Console.WriteLine("Num1 é menor que 5, Num1 é igual a " & num1)
        ElseIf num1 > 5 Then
            Console.WriteLine("Num1 é maior que 5, Num1 é igual a " & num1)
        Else
            Console.WriteLine("Num1 é igual a 5.")
        End If
        Console.ReadLine()

        Dim num2 As Integer = 10
        If num2 = 10 Or num2 = 13 Then
            Console.WriteLine("Num2 é igual a 10 ou 11")
        End If
        Console.ReadLine()

        Select Case num1
            Case 1
                Console.WriteLine("Num1 é igual a 1")
            Case 3, 4
                Console.WriteLine("Num1 é igual a 3 ou 4")
            Case 5
                Console.WriteLine("Num1 é igual a 5")
            Case 7
                Console.WriteLine("Num1 é igual a 7")
            Case Else
                Console.WriteLine("Num1 não é nenhum dos valores mencionados acima")
        End Select
        Console.ReadLine()

        Dim nome As String = "Ricardo"

        Select Case nome
            Case "Felipe"
                Console.Write("Esse não é meu nome")
            Case "Ricardo"
                Console.WriteLine("Correto, esse é meu nome")
        End Select
    End Sub

End Module
