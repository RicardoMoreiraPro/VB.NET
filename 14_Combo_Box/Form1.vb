Public Class Form1
    Private conta As Integer = 0
    Dim dados As New DataSet
    Private Sub cb_dados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_dados.SelectedIndexChanged
        If cb_dados.SelectedIndex = 1 Then
            MessageBox.Show("Item Ricardo selecionado")
        End If
    End Sub

    Private Sub cb_dados_SelectedValueChanged(sender As Object, e As EventArgs) Handles cb_dados.SelectedValueChanged
        If cb_dados.SelectedValue = 3 Then
            MessageBox.Show("Valor 3 selecionado")
        End If
    End Sub

    Private Sub btn_inserir_Click(sender As Object, e As EventArgs) Handles btn_inserir.Click
        cb_dados.Items.Add(InputBox("Digite um nome", "Inserir nome"))
    End Sub

    Private Sub btn_dados_Click(sender As Object, e As EventArgs) Handles btn_dados.Click


        Dim novo As DataRow = dados.Tables(0).NewRow
        conta += 1
        novo.Item("Nome") = "João"
        novo.Item("Codigo") = conta
        dados.Tables(0).Rows.Add(novo)
        dados.Tables(0).AcceptChanges()

        cb_dados.DisplayMember = "Nome"
        cb_dados.ValueMember = "Codigo"
        cb_dados.DataSource = dados.Tables(0)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        dados.Tables.Add()
        dados.Tables(0).Columns.Add("Nome", GetType(String))
        dados.Tables(0).Columns.Add("Codigo", GetType(Integer))
    End Sub
End Class
