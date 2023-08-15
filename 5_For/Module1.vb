Module Module1

    Sub Main()
        'For i As Integer = 0 To 10
        'If i = 7 Then
        'Exit For   'para interromper o for quando chegar no 7
        'End If
        'Console.WriteLine(i)
        'Next
        'Console.ReadLine()
        'For i As Integer = 0 To 10
        'If i = 7 Then
        'Continue For     'para pular o 7
        'End If
        'Console.WriteLine(i)
        'Next
        'Console.ReadLine()

        'For i As Integer = 20 To 1 Step -1
        'Console.WriteLine(i)
        'Next
        'Console.ReadLine()
        For i As Integer = 1 To 3
            Dim texto As New System.Text.StringBuilder
            For a As Integer = 20 To 1 Step -3
                If a = 17 Then
                    Continue For
                End If
                texto.Append(a)
                texto.Append(" ")
            Next
            Console.WriteLine(texto)
        Next
        Console.ReadLine()
    End Sub

End Module
