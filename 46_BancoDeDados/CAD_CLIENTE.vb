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

    Private dbName As String = "Banco.db"
    Private dbPath As String = "C:\Banco VB\" & dbName
    Private connString As String = "Data Source =" & dbPath & ";Version=3"

    Private connection As New SQLiteConnection(connString)
    Private command As New SQLiteCommand("", connection)


#End Region

#Region "Funções e SubRotinas"
    Public Function ExecutaGet(ByVal sql As String) As DataTable
        connection.Open()
        command.Connection = connection
        command.CommandText = sql
        Dim dataR As SQLiteDataReader = command.ExecuteReader
        Dim table As New DataTable
        table.Load(dataR)
        connection.Close()
        Return table

    End Function
    'Public Function ExecutaSet(ByVal sql As String) As DataTable
    '    connection.Open()
    '    Dim cmd As SQLiteConnection = command.Connection
    '    cmd = connection
    '    Dim tex As String = command.CommandText = sql
    '    Dim da As SQLiteDataAdapter = command.ExecuteScalar
    '    Dim dt As DataTable = New DataTable
    '    da = New SQLiteDataAdapter(tex, cmd)
    '    command.ExecuteNonQuery()
    '    dt.Load(da)
    '    Return dt
    '    connection.Close()
    'End Function
    'Public Function ExecutaSet(ByRef adf As String) As DataTable
    '    connection.Open()
    '    command.Connection = connection
    '    command.CommandText = adf
    '    Dim dataR As SQLiteDataAdapter = command.ExecuteScalar
    '    Dim dt As DataTable = New DataTable
    '    Dim consulta As String = "Select * from CAD_CLIENTE"
    '    dt = ExecutaGet(consulta)
    '    Return dt
    '    connection.Close()
    'End Function
    Public Function ExecutaSet(sql As String) As DataTable
        connection.Open()
        command.Connection = connection
        command.CommandText = sql
        Dim ds As New DataSet
        Dim dataR As SQLiteDataAdapter
        dataR = New SQLiteDataAdapter(sql, connection)
        dataR.Fill(ds)
        Dim dt As DataTable = Refresh(ds)
        connection.Close()
        Return dt

    End Function
    Public Function Refresh(ByVal sql As DataSet) As DataTable

        command.Connection = connection
        command.CommandText = "Select * from CAD_CLIENTE"
        Dim dataR As SQLiteDataReader = command.ExecuteReader
        Dim table As New DataTable
        table.Load(dataR)
        Return table

    End Function

    Public Sub ExecutaSet2(sql As String)
        connection.Open()
        command.Connection = connection
        command.CommandText = sql
        Dim ds As New DataSet
        Dim dataR As SQLiteDataAdapter
        dataR = New SQLiteDataAdapter(sql, connection)
        dataR.Fill(ds)
        connection.Close()
    End Sub



#End Region

End Class
