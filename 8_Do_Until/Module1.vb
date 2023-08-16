Module Module1

    Sub Main()
        Dim index As Integer = 0
        Dim index2 As Integer = 0
        Do Until index > 10
            Console.WriteLine(index)
            index += 1
        Loop
        Do
            Console.WriteLine(index2)
            index2 += 1
        Loop Until index2 > 10
        Console.ReadLine()
    End Sub

End Module
