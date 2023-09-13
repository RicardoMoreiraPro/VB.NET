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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AgendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_cadastro = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_consulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsb_cliente = New System.Windows.Forms.ToolStripButton()
        Me.tsb_consultar = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgendaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(667, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AgendaToolStripMenuItem
        '
        Me.AgendaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ms_cadastro, Me.ms_consulta})
        Me.AgendaToolStripMenuItem.Name = "AgendaToolStripMenuItem"
        Me.AgendaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.AgendaToolStripMenuItem.Text = "Agenda"
        '
        'ms_cadastro
        '
        Me.ms_cadastro.Image = Global._46_BancoDeDados.My.Resources.Resources.local_na_rede_internet
        Me.ms_cadastro.Name = "ms_cadastro"
        Me.ms_cadastro.Size = New System.Drawing.Size(121, 22)
        Me.ms_cadastro.Text = "Cadastro"
        '
        'ms_consulta
        '
        Me.ms_consulta.Image = Global._46_BancoDeDados.My.Resources.Resources.lupa
        Me.ms_consulta.Name = "ms_consulta"
        Me.ms_consulta.Size = New System.Drawing.Size(121, 22)
        Me.ms_consulta.Text = "Consulta"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsb_cliente, Me.tsb_consultar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(667, 39)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsb_cliente
        '
        Me.tsb_cliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_cliente.Image = Global._46_BancoDeDados.My.Resources.Resources.local_na_rede_internet
        Me.tsb_cliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsb_cliente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_cliente.Name = "tsb_cliente"
        Me.tsb_cliente.Size = New System.Drawing.Size(36, 36)
        Me.tsb_cliente.Text = "Cadastro Cliente"
        '
        'tsb_consultar
        '
        Me.tsb_consultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_consultar.Image = Global._46_BancoDeDados.My.Resources.Resources.lupa
        Me.tsb_consultar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsb_consultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_consultar.Name = "tsb_consultar"
        Me.tsb_consultar.Size = New System.Drawing.Size(36, 36)
        Me.tsb_consultar.Text = "Consultar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 367)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AgendaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ms_cadastro As ToolStripMenuItem
    Friend WithEvents ms_consulta As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsb_cliente As ToolStripButton
    Friend WithEvents tsb_consultar As ToolStripButton
End Class
