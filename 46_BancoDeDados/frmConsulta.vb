﻿Imports System.Data.Entity.Core
Imports System.Data.SQLite
Imports System.Security.Cryptography.X509Certificates

Public Class frmConsulta
    Dim cadCliente As New CAD_CLIENTE
    Private Sub frmConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "Codigo base"
        'Dim dbName As String = "Banco.db"
        'Dim dbPath As String = "C:\Banco VB\" & dbName
        'Dim connString As String = "Data Source =" & dbPath & ";Version=3"

        'Dim connection As New SQLiteConnection(connString)
        'Dim command As New SQLiteCommand("", connection)
        'connection.Open()

        'command.Connection = connection
        'command.CommandText = "Select * from CAD_CLIENTE"

        'Dim dataR As SQLiteDataReader = command.ExecuteReader


        'Dim table As New DataTable
        'table.Load(dataR)
        'dgv_dados.DataSource = table
        'connection.Close()
#End Region
        Dim query As String = "Select * from CAD_CLIENTE"

        Dim table As DataTable = cadCliente.ExecutaGet(query)
        dgv_dados.DataSource = table
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim quer As String = "insert into CAD_CLIENTE(NOME, CEP) values ('Ricardo', '235665')"
        Dim tab As DataTable = cadCliente.ExecutaSet(quer)
        dgv_dados.DataSource = tab
    End Sub
End Class