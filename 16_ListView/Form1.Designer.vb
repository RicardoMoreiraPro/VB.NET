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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Arquivo 1")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Arquivo 2")
        Me.lv_arquivos = New System.Windows.Forms.ListView()
        Me.btn_adicionar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lv_arquivos
        '
        Me.lv_arquivos.HideSelection = False
        Me.lv_arquivos.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
        Me.lv_arquivos.Location = New System.Drawing.Point(24, 25)
        Me.lv_arquivos.Name = "lv_arquivos"
        Me.lv_arquivos.Size = New System.Drawing.Size(319, 248)
        Me.lv_arquivos.TabIndex = 0
        Me.lv_arquivos.UseCompatibleStateImageBehavior = False
        '
        'btn_adicionar
        '
        Me.btn_adicionar.Location = New System.Drawing.Point(33, 88)
        Me.btn_adicionar.Name = "btn_adicionar"
        Me.btn_adicionar.Size = New System.Drawing.Size(75, 23)
        Me.btn_adicionar.TabIndex = 1
        Me.btn_adicionar.Text = "Adicionar"
        Me.btn_adicionar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 360)
        Me.Controls.Add(Me.btn_adicionar)
        Me.Controls.Add(Me.lv_arquivos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lv_arquivos As ListView
    Friend WithEvents btn_adicionar As Button
End Class
