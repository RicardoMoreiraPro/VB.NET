Public Class Form1
    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        Dim frm As New Form2
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CascataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascataToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub LadoALadoHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LadoALadoHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub LadoALadoVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LadoALadoVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
End Class
