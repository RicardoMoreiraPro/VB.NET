<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_windowns
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
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_novoForm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_cancelar
        '
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.Location = New System.Drawing.Point(202, 76)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 0
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(43, 76)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_ok.TabIndex = 1
        Me.btn_ok.Text = "Ok"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'btn_novoForm
        '
        Me.btn_novoForm.Location = New System.Drawing.Point(115, 123)
        Me.btn_novoForm.Name = "btn_novoForm"
        Me.btn_novoForm.Size = New System.Drawing.Size(94, 23)
        Me.btn_novoForm.TabIndex = 2
        Me.btn_novoForm.Text = "Novo Form"
        Me.btn_novoForm.UseVisualStyleBackColor = True
        '
        'F_windowns
        '
        Me.AcceptButton = Me.btn_ok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._9_Windows_Forms.My.Resources.Resources.led_verde
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CancelButton = Me.btn_cancelar
        Me.ClientSize = New System.Drawing.Size(353, 357)
        Me.Controls.Add(Me.btn_novoForm)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.btn_cancelar)
        Me.DoubleBuffered = True
        Me.Name = "F_windowns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_ok As Button
    Friend WithEvents btn_novoForm As Button
End Class
