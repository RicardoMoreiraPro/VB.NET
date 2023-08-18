<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JanelaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LadoALadoHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LadoALadoVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.JanelaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.NovoToolStripMenuItem.Text = "Novo "
        '
        'JanelaToolStripMenuItem
        '
        Me.JanelaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascataToolStripMenuItem, Me.LadoALadoHorizontalToolStripMenuItem, Me.LadoALadoVerticalToolStripMenuItem})
        Me.JanelaToolStripMenuItem.Name = "JanelaToolStripMenuItem"
        Me.JanelaToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.JanelaToolStripMenuItem.Text = "Janela"
        '
        'CascataToolStripMenuItem
        '
        Me.CascataToolStripMenuItem.Name = "CascataToolStripMenuItem"
        Me.CascataToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.CascataToolStripMenuItem.Text = "Cascata"
        '
        'LadoALadoHorizontalToolStripMenuItem
        '
        Me.LadoALadoHorizontalToolStripMenuItem.Name = "LadoALadoHorizontalToolStripMenuItem"
        Me.LadoALadoHorizontalToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.LadoALadoHorizontalToolStripMenuItem.Text = "Lado a lado horizontal"
        '
        'LadoALadoVerticalToolStripMenuItem
        '
        Me.LadoALadoVerticalToolStripMenuItem.Name = "LadoALadoVerticalToolStripMenuItem"
        Me.LadoALadoVerticalToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.LadoALadoVerticalToolStripMenuItem.Text = "Lado a lado Vertical"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NovoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JanelaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CascataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LadoALadoHorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LadoALadoVerticalToolStripMenuItem As ToolStripMenuItem
End Class
