Public Class Util
    Public nota As Integer = 10
    Public nome As String
    Public nota5 As Integer = 6
    Public Property nome2 As String
    Public ReadOnly Property nota2 As Integer
        Get
            Return nota
        End Get
    End Property
    Public Sub mostraNome()
        nome = "Ricardo"
        MessageBox.Show(nome)
    End Sub
    Public Function media() As Double
        Return (nota + nota5) / 2
    End Function
End Class
