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
        Me.cb_dados = New System.Windows.Forms.ComboBox()
        Me.btn_inserir = New System.Windows.Forms.Button()
        Me.btn_dados = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cb_dados
        '
        Me.cb_dados.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cb_dados.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_dados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_dados.FormattingEnabled = True
        Me.cb_dados.Items.AddRange(New Object() {"---Selecione---", "Ricardo", "Fernando", "Carlitos"})
        Me.cb_dados.Location = New System.Drawing.Point(13, 13)
        Me.cb_dados.Name = "cb_dados"
        Me.cb_dados.Size = New System.Drawing.Size(168, 21)
        Me.cb_dados.TabIndex = 0
        '
        'btn_inserir
        '
        Me.btn_inserir.Location = New System.Drawing.Point(13, 50)
        Me.btn_inserir.Name = "btn_inserir"
        Me.btn_inserir.Size = New System.Drawing.Size(75, 23)
        Me.btn_inserir.TabIndex = 1
        Me.btn_inserir.Text = "Inserir"
        Me.btn_inserir.UseVisualStyleBackColor = True
        '
        'btn_dados
        '
        Me.btn_dados.Location = New System.Drawing.Point(106, 50)
        Me.btn_dados.Name = "btn_dados"
        Me.btn_dados.Size = New System.Drawing.Size(75, 23)
        Me.btn_dados.TabIndex = 2
        Me.btn_dados.Text = "Dados"
        Me.btn_dados.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 312)
        Me.Controls.Add(Me.btn_dados)
        Me.Controls.Add(Me.btn_inserir)
        Me.Controls.Add(Me.cb_dados)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cb_dados As ComboBox
    Friend WithEvents btn_inserir As Button
    Friend WithEvents btn_dados As Button
End Class
