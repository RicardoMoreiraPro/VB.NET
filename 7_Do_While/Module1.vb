Module Module1

    Sub Main()
        Dim index As Integer = 0
        Dim index2 As Integer = 0

        Do While index <= 10
            If index = 6 Then
                Console.WriteLine("Numero 6 encontrado!")
                Exit Do
            End If
            Console.WriteLine(index)
            index += 1
        Loop

        Do
            Console.WriteLine(index2)
            index2 += 1
        Loop While index2 <= 10
        Console.ReadLine()
    End Sub

End Module
