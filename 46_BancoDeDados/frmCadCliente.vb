Public Class frmCadCliente
#Region "Variaveis"
    Private Enum Opcao As Integer
        Cancelar = 0
        Incluir = 1
        Editar = 2
        Consultar = 3
    End Enum
    Private intOpcao As Opcao
#End Region
#Region "SubRotinas"
    Private Sub AtivaDesativa(ByRef status As Boolean)
        If status = False Then
            tb_codigo.Enabled = status
            btn_pesquisarCliente.Enabled = status
        End If
        tb_nome.Enabled = status
        tb_cep.Enabled = status
        btn_correio.Enabled = status
        tb_endereco.Enabled = status
        tb_bairro.Enabled = status
        tb_uf.Enabled = status
        tb_numero.Enabled = status
        tb_complemento.Enabled = status
        tb_fone1.Enabled = status
        tb_fone2.Enabled = status
    End Sub
    Private Sub CancelaOperacao()
        If intOpcao = Opcao.Incluir And tb_nome.TextLength > 0 Then
            If MessageBox.Show("Você tem certeza que deseja cancelar a Inclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If
        ElseIf intOpcao = Opcao.Editar And tb_codigo.Enabled = False Then
            If MessageBox.Show("Você tem certeza que deseja cancelar a edição?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If
        End If
        intOpcao = Opcao.Cancelar
        tb_codigo.Clear()
        tb_nome.Clear()
        tb_cep.Clear()
        tb_endereco.Clear()
        tb_bairro.Clear()
        tb_uf.Clear()
        tb_numero.Clear()
        tb_complemento.Clear()
        tb_fone1.Clear()
        tb_fone2.Clear()

        AtivaDesativa(False)

        tsb_incluir.Enabled = True
        tsb_editar.Enabled = True
        tsb_consultar.Enabled = True
        tsb_salvar.Enabled = False
        tsb_cancelar.Enabled = False
    End Sub

#End Region

    Private Sub tsb_incluir_Click(sender As Object, e As EventArgs) Handles tsb_incluir.Click
        intOpcao = Opcao.Incluir

        AtivaDesativa(True)

        tsb_incluir.Enabled = False
        tsb_editar.Enabled = False
        tsb_consultar.Enabled = False

        tsb_salvar.Enabled = True
        tsb_cancelar.Enabled = True
        tb_nome.Focus()
    End Sub

    Private Sub tsb_consultar_Click(sender As Object, e As EventArgs) Handles tsb_consultar.Click
        intOpcao = Opcao.Consultar

        tsb_incluir.Enabled = False
        tsb_editar.Enabled = False
        tsb_consultar.Enabled = False

        tsb_cancelar.Enabled = True
        tb_codigo.Enabled = True
        btn_pesquisarCliente.Enabled = True
        tb_codigo.Focus()
    End Sub

    Private Sub tsb_editar_Click(sender As Object, e As EventArgs) Handles tsb_editar.Click
        intOpcao = Opcao.Editar

        tsb_incluir.Enabled = False
        tsb_editar.Enabled = False
        tsb_consultar.Enabled = False

        tsb_cancelar.Enabled = True
        tb_codigo.Enabled = True
        btn_pesquisarCliente.Enabled = True
        tb_codigo.Focus()
    End Sub

    Private Sub tsb_cancelar_Click(sender As Object, e As EventArgs) Handles tsb_cancelar.Click
        CancelaOperacao()
    End Sub

    Private Sub tsb_sair_Click(sender As Object, e As EventArgs) Handles tsb_sair.Click
        Me.Close()
    End Sub

    Private Sub frmCadCliente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If intOpcao = Opcao.Incluir And tb_nome.TextLength > 0 Then
            If MessageBox.Show("Você tem certeza que deseja cancelar a Inclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                e.Cancel = True
            End If
        ElseIf intOpcao = Opcao.Editar And tb_codigo.Enabled = False Then
            If MessageBox.Show("Você tem certeza que deseja cancelar a edição?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub frmCadCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If tsb_incluir.Enabled = True And e.KeyCode = Keys.F2 Then
            tsb_incluir_Click(Nothing, Nothing)
        ElseIf tsb_consultar.Enabled = True And e.KeyCode = Keys.F3 Then
            tsb_consultar_Click(Nothing, Nothing)
        ElseIf tsb_editar.Enabled = True And e.KeyCode = Keys.F4 Then
            tsb_editar_Click(Nothing, Nothing)
        ElseIf tsb_salvar.Enabled = True And e.KeyCode = Keys.F5 Then
            tsb_salvar_Click(Nothing, Nothing)
        ElseIf tsb_cancelar.Enabled = True And e.KeyCode = Keys.Escape Then
            tsb_cancelar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub tsb_salvar_Click(sender As Object, e As EventArgs) Handles tsb_salvar.Click

    End Sub
End Class