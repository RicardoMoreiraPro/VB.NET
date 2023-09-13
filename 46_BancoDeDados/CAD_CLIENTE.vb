Imports System.Data.Entity.Core
Imports System.Data.SqlClient
Imports System.Data.SQLite

Public Class CAD_CLIENTE
#Region "Rascunho"
    'Private dbCommand As String = ""
    'Private bindingSrc As BindingSource

    'Private dbName As String = "Banco.db"
    'Private dbPath As String = "C:\Banco VB\" & dbName
    'Private connString As String = "Data Source =" & dbPath & ";Version=3"

    'Private connection As New SQLiteConnection(connString)
    'Private command As New SQLiteCommand("", connection)
    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    connection.Open()
    '    'If connection.State = ConnectionState.Open Then
    '    '    MessageBox.Show("FUncionou " & connection.State.ToString)
    '    'End If
    '    If connection.State = ConnectionState.Open Then
    '        command.Connection = connection
    '        command.CommandText = "select * from CAD_CLIENTE"

    '        Dim rdr As SQLiteDataReader = command.ExecuteReader
    '        Using rdr
    '            While (rdr.Read())
    '                MessageBox.Show((rdr.GetInt32(0) & rdr.GetString(1)))
    '            End While
    '        End Using

    'Dim table As New DataTable
    'table.load(rdr)

    'DataGridView.DataSource = table

    '    End If
    '    connection.Close()
    'End Sub
#End Region
#Region "Propriedades"
    Public Property CODIGO As Integer
    Public Property NOME As String
    Public Property CEP As String
    Public Property ENDERECO As String
    Public Property BAIRRO As String
    Public Property COMPLEMENTO As String
    Public Property UF As String
    Public Property FONE1 As String
    Public Property FONE2 As String
    Public Property NUMERO As String

#End Region

#Region "Variáveis"
    'Private dbCommand As String = ""
    'Private bindingSrc As BindingSource

    'Private dbName As String = "Banco.db"
    'Private dbPath As String = "C:\Banco VB\" & dbName
    'Private connString As String = "Data Source =" & dbPath & ";Version=3"

    'Private connection As New SQLiteConnection(connString)
    'Private command As New SQLiteCommand("", connection)
#End Region

#Region "Funções e SubRotinas"
    'Private dbCommand As String = ""
    'Private bindingSrc As BindingSource
    'Public Function ConexaoBanco(query As String) As SQLiteConnection
    '    Dim dbName As String = "Banco.db"
    '    Dim dbPath As String = "C:\Banco VB\" & dbName
    '    Dim connString As String = "Data Source =" & dbPath & ";Version=3"

    '    Dim connection As New SQLiteConnection(connString)
    '    Dim command As New SQLiteCommand("", connection)
    '    connection.Open()

    '    command.Connection = connection
    '    command.CommandText = query

    '    Dim dataR As SQLiteDataReader = command.ExecuteReader


    '    Dim table As New DataTable
    '    table.Load(dataR)
    '    'DataGridView.DataSource = table
    '    Return connection
    'End Function

#End Region

End Class
