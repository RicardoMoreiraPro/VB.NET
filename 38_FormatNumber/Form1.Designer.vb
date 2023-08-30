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
        Me.tb_numero = New System.Windows.Forms.TextBox()
        Me.btn_formatar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tb_numero
        '
        Me.tb_numero.Location = New System.Drawing.Point(64, 52)
        Me.tb_numero.Name = "tb_numero"
        Me.tb_numero.Size = New System.Drawing.Size(100, 20)
        Me.tb_numero.TabIndex = 0
        '
        'btn_formatar
        '
        Me.btn_formatar.Location = New System.Drawing.Point(64, 78)
        Me.btn_formatar.Name = "btn_formatar"
        Me.btn_formatar.Size = New System.Drawing.Size(100, 23)
        Me.btn_formatar.TabIndex = 1
        Me.btn_formatar.Text = "Formatar"
        Me.btn_formatar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(213, 229)
        Me.Controls.Add(Me.btn_formatar)
        Me.Controls.Add(Me.tb_numero)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_numero As TextBox
    Friend WithEvents btn_formatar As Button
End Class
