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
        Me.lb_lista = New System.Windows.Forms.ListBox()
        Me.btn_adicionar = New System.Windows.Forms.Button()
        Me.btn_dados = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lb_lista
        '
        Me.lb_lista.FormattingEnabled = True
        Me.lb_lista.Items.AddRange(New Object() {"Item 1", "Item2"})
        Me.lb_lista.Location = New System.Drawing.Point(12, 22)
        Me.lb_lista.Name = "lb_lista"
        Me.lb_lista.Size = New System.Drawing.Size(316, 160)
        Me.lb_lista.TabIndex = 0
        '
        'btn_adicionar
        '
        Me.btn_adicionar.Location = New System.Drawing.Point(13, 202)
        Me.btn_adicionar.Name = "btn_adicionar"
        Me.btn_adicionar.Size = New System.Drawing.Size(75, 23)
        Me.btn_adicionar.TabIndex = 1
        Me.btn_adicionar.Text = "Adicionar"
        Me.btn_adicionar.UseVisualStyleBackColor = True
        '
        'btn_dados
        '
        Me.btn_dados.Location = New System.Drawing.Point(109, 202)
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
        Me.ClientSize = New System.Drawing.Size(340, 318)
        Me.Controls.Add(Me.btn_dados)
        Me.Controls.Add(Me.btn_adicionar)
        Me.Controls.Add(Me.lb_lista)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lb_lista As ListBox
    Friend WithEvents btn_adicionar As Button
    Friend WithEvents btn_dados As Button
End Class
