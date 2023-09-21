<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsulta
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tb_cep = New System.Windows.Forms.TextBox()
        Me.tb_nome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.colCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEndereco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBairro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colComplemento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFone1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFone2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tb_cep)
        Me.GroupBox1.Controls.Add(Me.tb_nome)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(647, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar por"
        '
        'tb_cep
        '
        Me.tb_cep.Location = New System.Drawing.Point(490, 28)
        Me.tb_cep.Name = "tb_cep"
        Me.tb_cep.Size = New System.Drawing.Size(134, 20)
        Me.tb_cep.TabIndex = 3
        '
        'tb_nome
        '
        Me.tb_nome.Location = New System.Drawing.Point(47, 28)
        Me.tb_nome.Name = "tb_nome"
        Me.tb_nome.Size = New System.Drawing.Size(384, 20)
        Me.tb_nome.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(456, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CEP:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgv_dados)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(803, 319)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.AllowUserToDeleteRows = False
        Me.dgv_dados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCodigo, Me.colNome, Me.colCep, Me.ColEndereco, Me.colNumero, Me.colBairro, Me.colComplemento, Me.colUF, Me.colFone1, Me.colFone2})
        Me.dgv_dados.Location = New System.Drawing.Point(6, 10)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.ReadOnly = True
        Me.dgv_dados.Size = New System.Drawing.Size(791, 303)
        Me.dgv_dados.TabIndex = 0
        '
        'colCodigo
        '
        Me.colCodigo.DataPropertyName = "CODIGO"
        Me.colCodigo.HeaderText = "Código"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.ReadOnly = True
        '
        'colNome
        '
        Me.colNome.DataPropertyName = "NOME"
        Me.colNome.HeaderText = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.ReadOnly = True
        '
        'colCep
        '
        Me.colCep.DataPropertyName = "CEP"
        Me.colCep.HeaderText = "CEP"
        Me.colCep.Name = "colCep"
        Me.colCep.ReadOnly = True
        '
        'ColEndereco
        '
        Me.ColEndereco.DataPropertyName = "ENDERECO"
        Me.ColEndereco.HeaderText = "Endereço"
        Me.ColEndereco.Name = "ColEndereco"
        Me.ColEndereco.ReadOnly = True
        '
        'colNumero
        '
        Me.colNumero.DataPropertyName = "NUMERO"
        Me.colNumero.HeaderText = "Numero"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.ReadOnly = True
        '
        'colBairro
        '
        Me.colBairro.DataPropertyName = "BAIRRO"
        Me.colBairro.HeaderText = "Bairro"
        Me.colBairro.Name = "colBairro"
        Me.colBairro.ReadOnly = True
        '
        'colComplemento
        '
        Me.colComplemento.DataPropertyName = "COMPLEMENTO"
        Me.colComplemento.HeaderText = "Complemento"
        Me.colComplemento.Name = "colComplemento"
        Me.colComplemento.ReadOnly = True
        '
        'colUF
        '
        Me.colUF.DataPropertyName = "UF"
        Me.colUF.HeaderText = "UF"
        Me.colUF.Name = "colUF"
        Me.colUF.ReadOnly = True
        '
        'colFone1
        '
        Me.colFone1.DataPropertyName = "FONE1"
        Me.colFone1.HeaderText = "Fone1"
        Me.colFone1.Name = "colFone1"
        Me.colFone1.ReadOnly = True
        '
        'colFone2
        '
        Me.colFone2.DataPropertyName = "FONE2"
        Me.colFone2.HeaderText = "Fone2"
        Me.colFone2.Name = "colFone2"
        Me.colFone2.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(680, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tb_cep As TextBox
    Friend WithEvents tb_nome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents colCodigo As DataGridViewTextBoxColumn
    Friend WithEvents colNome As DataGridViewTextBoxColumn
    Friend WithEvents colCep As DataGridViewTextBoxColumn
    Friend WithEvents ColEndereco As DataGridViewTextBoxColumn
    Friend WithEvents colNumero As DataGridViewTextBoxColumn
    Friend WithEvents colBairro As DataGridViewTextBoxColumn
    Friend WithEvents colComplemento As DataGridViewTextBoxColumn
    Friend WithEvents colUF As DataGridViewTextBoxColumn
    Friend WithEvents colFone1 As DataGridViewTextBoxColumn
    Friend WithEvents colFone2 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
