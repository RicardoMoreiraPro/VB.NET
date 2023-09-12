<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadCliente))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_codigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tb_nome = New System.Windows.Forms.TextBox()
        Me.tb_cep = New System.Windows.Forms.TextBox()
        Me.tb_endereco = New System.Windows.Forms.TextBox()
        Me.tb_bairro = New System.Windows.Forms.TextBox()
        Me.tb_numero = New System.Windows.Forms.TextBox()
        Me.tb_complemento = New System.Windows.Forms.TextBox()
        Me.tb_fone1 = New System.Windows.Forms.TextBox()
        Me.tb_fone2 = New System.Windows.Forms.TextBox()
        Me.btn_pesquisarCliente = New System.Windows.Forms.Button()
        Me.tsb_incluir = New System.Windows.Forms.ToolStripButton()
        Me.tsb_consultar = New System.Windows.Forms.ToolStripButton()
        Me.tsb_editar = New System.Windows.Forms.ToolStripButton()
        Me.tsb_salvar = New System.Windows.Forms.ToolStripButton()
        Me.tsb_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.tsb_sair = New System.Windows.Forms.ToolStripButton()
        Me.tb_uf = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsb_incluir, Me.tsb_consultar, Me.tsb_editar, Me.ToolStripSeparator1, Me.tsb_salvar, Me.tsb_cancelar, Me.ToolStripSeparator2, Me.tsb_sair})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(526, 39)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 358)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(526, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(405, 17)
        Me.ToolStripStatusLabel1.Text = "[F2] - Incluir |  [F3] - Colsultar |  [F4] - Editar |  [F5] - Salvar |  [ESC] - C" &
    "ancelar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tb_uf)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btn_pesquisarCliente)
        Me.GroupBox1.Controls.Add(Me.tb_fone2)
        Me.GroupBox1.Controls.Add(Me.tb_fone1)
        Me.GroupBox1.Controls.Add(Me.tb_complemento)
        Me.GroupBox1.Controls.Add(Me.tb_numero)
        Me.GroupBox1.Controls.Add(Me.tb_bairro)
        Me.GroupBox1.Controls.Add(Me.tb_endereco)
        Me.GroupBox1.Controls.Add(Me.tb_cep)
        Me.GroupBox1.Controls.Add(Me.tb_nome)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tb_codigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(521, 315)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código: "
        '
        'tb_codigo
        '
        Me.tb_codigo.Enabled = False
        Me.tb_codigo.Location = New System.Drawing.Point(58, 13)
        Me.tb_codigo.Name = "tb_codigo"
        Me.tb_codigo.Size = New System.Drawing.Size(76, 20)
        Me.tb_codigo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CEP:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Endereço:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Bairro:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Numero:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Complemento:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 251)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Fone1:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 283)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Fone2:"
        '
        'tb_nome
        '
        Me.tb_nome.Enabled = False
        Me.tb_nome.Location = New System.Drawing.Point(58, 45)
        Me.tb_nome.Name = "tb_nome"
        Me.tb_nome.Size = New System.Drawing.Size(399, 20)
        Me.tb_nome.TabIndex = 10
        '
        'tb_cep
        '
        Me.tb_cep.Enabled = False
        Me.tb_cep.Location = New System.Drawing.Point(43, 76)
        Me.tb_cep.Name = "tb_cep"
        Me.tb_cep.Size = New System.Drawing.Size(115, 20)
        Me.tb_cep.TabIndex = 11
        '
        'tb_endereco
        '
        Me.tb_endereco.Enabled = False
        Me.tb_endereco.Location = New System.Drawing.Point(68, 106)
        Me.tb_endereco.Name = "tb_endereco"
        Me.tb_endereco.Size = New System.Drawing.Size(389, 20)
        Me.tb_endereco.TabIndex = 12
        '
        'tb_bairro
        '
        Me.tb_bairro.Enabled = False
        Me.tb_bairro.Location = New System.Drawing.Point(49, 135)
        Me.tb_bairro.Name = "tb_bairro"
        Me.tb_bairro.Size = New System.Drawing.Size(408, 20)
        Me.tb_bairro.TabIndex = 13
        '
        'tb_numero
        '
        Me.tb_numero.Enabled = False
        Me.tb_numero.Location = New System.Drawing.Point(58, 190)
        Me.tb_numero.Name = "tb_numero"
        Me.tb_numero.Size = New System.Drawing.Size(100, 20)
        Me.tb_numero.TabIndex = 14
        '
        'tb_complemento
        '
        Me.tb_complemento.Enabled = False
        Me.tb_complemento.Location = New System.Drawing.Point(86, 219)
        Me.tb_complemento.Name = "tb_complemento"
        Me.tb_complemento.Size = New System.Drawing.Size(371, 20)
        Me.tb_complemento.TabIndex = 15
        '
        'tb_fone1
        '
        Me.tb_fone1.Enabled = False
        Me.tb_fone1.Location = New System.Drawing.Point(52, 249)
        Me.tb_fone1.Name = "tb_fone1"
        Me.tb_fone1.Size = New System.Drawing.Size(171, 20)
        Me.tb_fone1.TabIndex = 16
        '
        'tb_fone2
        '
        Me.tb_fone2.Enabled = False
        Me.tb_fone2.Location = New System.Drawing.Point(52, 281)
        Me.tb_fone2.Name = "tb_fone2"
        Me.tb_fone2.Size = New System.Drawing.Size(171, 20)
        Me.tb_fone2.TabIndex = 17
        '
        'btn_pesquisarCliente
        '
        Me.btn_pesquisarCliente.Enabled = False
        Me.btn_pesquisarCliente.Image = Global._46_BancoDeDados.My.Resources.Resources.pesquisar_usuario
        Me.btn_pesquisarCliente.Location = New System.Drawing.Point(140, 9)
        Me.btn_pesquisarCliente.Name = "btn_pesquisarCliente"
        Me.btn_pesquisarCliente.Size = New System.Drawing.Size(30, 26)
        Me.btn_pesquisarCliente.TabIndex = 18
        Me.btn_pesquisarCliente.UseVisualStyleBackColor = True
        '
        'tsb_incluir
        '
        Me.tsb_incluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_incluir.Image = Global._46_BancoDeDados.My.Resources.Resources.adicionar
        Me.tsb_incluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsb_incluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_incluir.Name = "tsb_incluir"
        Me.tsb_incluir.Size = New System.Drawing.Size(36, 36)
        Me.tsb_incluir.Text = "Incluir"
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
        'tsb_editar
        '
        Me.tsb_editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_editar.Image = Global._46_BancoDeDados.My.Resources.Resources.editar_arquivo
        Me.tsb_editar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsb_editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_editar.Name = "tsb_editar"
        Me.tsb_editar.Size = New System.Drawing.Size(36, 36)
        Me.tsb_editar.Text = "Editar"
        '
        'tsb_salvar
        '
        Me.tsb_salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_salvar.Enabled = False
        Me.tsb_salvar.Image = Global._46_BancoDeDados.My.Resources.Resources.salvar__1_
        Me.tsb_salvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsb_salvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_salvar.Name = "tsb_salvar"
        Me.tsb_salvar.Size = New System.Drawing.Size(36, 36)
        Me.tsb_salvar.Text = "Salvar"
        '
        'tsb_cancelar
        '
        Me.tsb_cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_cancelar.Enabled = False
        Me.tsb_cancelar.Image = Global._46_BancoDeDados.My.Resources.Resources.cancelar
        Me.tsb_cancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsb_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_cancelar.Name = "tsb_cancelar"
        Me.tsb_cancelar.Size = New System.Drawing.Size(36, 36)
        Me.tsb_cancelar.Text = "Cancelar"
        '
        'tsb_sair
        '
        Me.tsb_sair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_sair.Image = Global._46_BancoDeDados.My.Resources.Resources.sair
        Me.tsb_sair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsb_sair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_sair.Name = "tsb_sair"
        Me.tsb_sair.Size = New System.Drawing.Size(36, 36)
        Me.tsb_sair.Text = "Sair"
        '
        'tb_uf
        '
        Me.tb_uf.Enabled = False
        Me.tb_uf.Location = New System.Drawing.Point(34, 161)
        Me.tb_uf.Name = "tb_uf"
        Me.tb_uf.Size = New System.Drawing.Size(124, 20)
        Me.tb_uf.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "UF:"
        '
        'frmCadCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 380)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Enabled = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCadCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro Cliente"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsb_incluir As ToolStripButton
    Friend WithEvents tsb_consultar As ToolStripButton
    Friend WithEvents tsb_editar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsb_salvar As ToolStripButton
    Friend WithEvents tsb_cancelar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsb_sair As ToolStripButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_pesquisarCliente As Button
    Friend WithEvents tb_fone2 As TextBox
    Friend WithEvents tb_fone1 As TextBox
    Friend WithEvents tb_complemento As TextBox
    Friend WithEvents tb_numero As TextBox
    Friend WithEvents tb_bairro As TextBox
    Friend WithEvents tb_endereco As TextBox
    Friend WithEvents tb_cep As TextBox
    Friend WithEvents tb_nome As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_codigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_uf As TextBox
    Friend WithEvents Label10 As Label
End Class
