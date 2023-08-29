Module Util
    Public intNota As Integer
    Public Sub Soma(ByVal intNum1 As Integer, ByVal intNum2 As Integer)
        MessageBox.Show(intNum1 + intNum2)
    End Sub
    Public Function Media(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return (num1 + num2) / 2
    End Function
End Module
