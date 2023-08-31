Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = Now
        TextBox2.Text = Now.Date
        TextBox3.Text = Now.Date.AddDays(1).AddMonths(2)
    End Sub
End Class
