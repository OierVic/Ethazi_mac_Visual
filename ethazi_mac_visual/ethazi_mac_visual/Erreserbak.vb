﻿Imports MySql.Data.MySqlClient

Public Class Erreserbak
    Private Sub Erreserbak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexionBD As New MySqlConnection("server=127.0.0.1 ; userid=root ; password = ; database=ethazi_mac")

        Dim SQL As String = "SELECT * FROM erreserba"
        Dim cmd1 As New MySqlCommand(SQL, conexionBD)
        Dim dr As MySqlDataReader

        Try
            conexionBD.Open()
            dr = cmd1.ExecuteReader
        Catch ex As Exception
            MsgBox("Errorea datu basearekin")

        End Try
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToOrderColumns = False
        DataGridView1.ReadOnly = True
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None

        'DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        'DataGridView1.AllowUserToResizeRows = False
        DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

        'Color que se selecciona
        DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Green

        While dr.Read

            Try
                DataGridView1.Rows.Add(dr.Item(0), dr.Item(1), dr.Item(2), dr.Item(3))
                DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Chartreuse
            Catch ex As Exception
                MsgBox("Datu baseko datuak gehiago edo gutxiago dira edo basu basea ez da zuzena")
            End Try


        End While

        If conexionBD.State = ConnectionState.Open Then
            dr.Close()
            conexionBD.Close()
        End If
    End Sub

    Private Sub Button1_Atzera_Click(sender As Object, e As EventArgs) Handles Button1_Atzera.Click
        Me.Hide()
        Dim pasaralMenu As New Menu
        pasaralMenu.Show()
    End Sub

    Private Sub Button1_Atzera_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1_Atzera.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                End
            Case Keys.Back
                Me.Hide()
                Dim pasaralMenu As New Menu
                pasaralMenu.Show()
            Case Keys.Enter
                Me.Hide()
                Dim pasaralMenu As New Menu
                pasaralMenu.Show()

        End Select
    End Sub
End Class