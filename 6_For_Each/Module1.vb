Module Module1

    Sub Main()
        Dim num As Integer() = {1, 2, 3, 4, 5}
        Dim letra As String() = {"A", "B", "C", "D", "E"}
        'For Each Linha As System.IO.DriveInfo In My.Computer.FileSystem.Drives
        '    Console.WriteLine(Linha.Name)
        'Next
        'For i As Integer = 0 To num.Length - 1
        '    Console.WriteLine(num(i))
        'Next
        'For Each linha As Integer In num
        '    Console.WriteLine(linha)
        'Next
        Dim result As New System.Text.StringBuilder
        For Each n As Integer In num
            For Each l As String In letra
                If n = 3 Then
                    Continue For
                End If
                result.Append(n & l)
                result.Append(" ")
            Next
        Next
        Console.WriteLine(result)
        Console.ReadLine()
    End Sub

End Module
