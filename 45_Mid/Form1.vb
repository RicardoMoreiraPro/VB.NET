Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = Mid(TextBox1.Text, 1, 9)
    End Sub
End Class
