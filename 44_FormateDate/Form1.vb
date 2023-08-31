Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = Now
        'TextBox2.Text = Now.Date.AddDays(1).AddMonths(1)
        TextBox2.Text = FormatDateTime(Now.Date, DateFormat.LongDate)
        TextBox3.Text = Format(Now.Date, "dd/MM/yy")
    End Sub
End Class
