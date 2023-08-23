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
        Me.rb_opcao1 = New System.Windows.Forms.RadioButton()
        Me.rb_opcao2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_2 = New System.Windows.Forms.RadioButton()
        Me.rb_1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rb_opcao1
        '
        Me.rb_opcao1.AutoSize = True
        Me.rb_opcao1.Checked = True
        Me.rb_opcao1.Location = New System.Drawing.Point(13, 24)
        Me.rb_opcao1.Name = "rb_opcao1"
        Me.rb_opcao1.Size = New System.Drawing.Size(90, 17)
        Me.rb_opcao1.TabIndex = 0
        Me.rb_opcao1.TabStop = True
        Me.rb_opcao1.Text = "RadioButton1"
        Me.rb_opcao1.UseVisualStyleBackColor = True
        '
        'rb_opcao2
        '
        Me.rb_opcao2.AutoSize = True
        Me.rb_opcao2.Location = New System.Drawing.Point(13, 57)
        Me.rb_opcao2.Name = "rb_opcao2"
        Me.rb_opcao2.Size = New System.Drawing.Size(90, 17)
        Me.rb_opcao2.TabIndex = 1
        Me.rb_opcao2.Text = "RadioButton2"
        Me.rb_opcao2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_2)
        Me.GroupBox1.Controls.Add(Me.rb_1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'rb_2
        '
        Me.rb_2.AutoSize = True
        Me.rb_2.Checked = True
        Me.rb_2.Location = New System.Drawing.Point(6, 52)
        Me.rb_2.Name = "rb_2"
        Me.rb_2.Size = New System.Drawing.Size(90, 17)
        Me.rb_2.TabIndex = 3
        Me.rb_2.TabStop = True
        Me.rb_2.Text = "RadioButton2"
        Me.rb_2.UseVisualStyleBackColor = True
        '
        'rb_1
        '
        Me.rb_1.AutoSize = True
        Me.rb_1.Location = New System.Drawing.Point(6, 19)
        Me.rb_1.Name = "rb_1"
        Me.rb_1.Size = New System.Drawing.Size(90, 17)
        Me.rb_1.TabIndex = 2
        Me.rb_1.Text = "RadioButton1"
        Me.rb_1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 371)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.rb_opcao2)
        Me.Controls.Add(Me.rb_opcao1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rb_opcao1 As RadioButton
    Friend WithEvents rb_opcao2 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb_2 As RadioButton
    Friend WithEvents rb_1 As RadioButton
End Class
