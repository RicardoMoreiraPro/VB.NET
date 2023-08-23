Public Class Form1
    Private Sub Button1_MouseMove(sender As Object, e As MouseEventArgs) Handles Button1.MouseMove
        tt_dica.SetToolTip(Button1, "Clique aqui")
        tt_dica.IsBalloon = True
    End Sub
End Class
