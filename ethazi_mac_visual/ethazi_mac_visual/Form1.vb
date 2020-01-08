Imports System.Data.OleDb
Imports System.Data.OracleClient
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim StrConexion As String
    Friend conexion As MySqlConnection





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'StrConexion = "server=127.0.0.1;" _
        ' & "uid=root;" _
        ' & "pwd=;" _
        ' & "database=ethazi_mac"
        Try
            conexion = New MySqlConnection()
            conexion.ConnectionString = "server=127.0.0.1 ; userid=root ; password = ; database=ethazi_mac"
            'conexion.ConnectionString = StrConexion

            conexion.Open()
            MessageBox.Show("Conectado al servidor")
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")

        End Try

    End Sub
End Class
