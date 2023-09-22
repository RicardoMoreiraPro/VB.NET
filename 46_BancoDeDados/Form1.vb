Imports System.Data.SQLite

Public Class Form1
#Region "Variáveis"
    Private frmcliente As frmCadCliente = Nothing
    Private frmconsulta As frmConsulta = Nothing

#End Region
    Private Sub tsb_cliente_Click(sender As Object, e As EventArgs) Handles tsb_cliente.Click
        If frmcliente Is Nothing Then
            frmcliente = New frmCadCliente
            frmcliente.Show()
        Else
            If frmcliente.IsHandleCreated = True Then
                frmcliente.Activate()
            Else
                frmcliente = New frmCadCliente
                frmcliente.Show()
            End If
        End If
    End Sub

    Private Sub ms_cadastro_Click(sender As Object, e As EventArgs) Handles ms_cadastro.Click
        tsb_cliente_Click(Nothing, Nothing)
    End Sub

    Private Sub ms_consulta_Click(sender As Object, e As EventArgs) Handles ms_consulta.Click
        If frmconsulta Is Nothing Then
            frmconsulta = New frmConsulta
            frmconsulta.Show()
        Else
            If frmconsulta.IsHandleCreated = True Then
                frmconsulta.Activate()
            Else
                frmconsulta = New frmConsulta
                frmconsulta.Show()
            End If
        End If
    End Sub

    Private Sub tsb_consultar_Click(sender As Object, e As EventArgs) Handles tsb_consultar.Click
        ms_consulta_Click(Nothing, Nothing)
    End Sub
End Class
