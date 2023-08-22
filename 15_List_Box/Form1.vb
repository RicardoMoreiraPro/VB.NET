Public Class Form1
    Private dados As New DataSet
    Private conta As Integer = 0
    Private Sub btn_adicionar_Click(sender As Object, e As EventArgs) Handles btn_adicionar.Click
        lb_lista.Items.Add(InputBox("Digite o item", "Inserir"))
    End Sub

    Private Sub lb_lista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_lista.SelectedIndexChanged
        If lb_lista.SelectedIndex = 0 Then
            lb_lista.BackColor = Color.Green
        End If
    End Sub

    Private Sub lb_lista_SelectedValueChanged(sender As Object, e As EventArgs) Handles lb_lista.SelectedValueChanged
        If lb_lista.SelectedValue = 2 Then
            lb_lista.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        dados.Tables.Add()
        dados.Tables(0).Columns.Add("Codigo", GetType(Integer))
        dados.Tables(0).Columns.Add("Nome", GetType(String))
    End Sub

    Private Sub btn_dados_Click(sender As Object, e As EventArgs) Handles btn_dados.Click
        Dim nova As DataRow = dados.Tables(0).NewRow
        nova.Item("Nome") = "Marcio"
        conta += 1
        nova.Item("Codigo") = conta
        dados.Tables(0).Rows.Add(nova)
        dados.Tables(0).AcceptChanges()
        lb_lista.DisplayMember = "Nome"
        lb_lista.ValueMember = "Codigo"
        lb_lista.DataSource = dados.Tables(0)
    End Sub
End Class
