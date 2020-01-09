﻿Imports MySql.Data.MySqlClient

Public Class Login
    Dim StrConexion As String
    'Friend conexion As MySqlConnection
    Dim conexionBD As MySqlConnection





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexionBD = New MySqlConnection()
            conexionBD.ConnectionString = "server=127.0.0.1 ; userid=root ; password = ; database=ethazi_mac"
            'conexion.ConnectionString = StrConexion

            conexionBD.Open()
            'MessageBox.Show("Conectado al servidor")
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        Finally
            If conexionBD.State = ConnectionState.Open Then conexionBD.Close()
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim erabiltzailea As String
        Dim pasahitza As String
        Dim aurkituta As Boolean

        Dim SQL As String = "SELECT erabiltzaile, pasahitza FROM erabiltzaile"
        Dim cmd1 As New MySqlCommand(SQL, conexionBD)
        Dim dr As MySqlDataReader

        Try
            conexionBD.Open()
            dr = cmd1.ExecuteReader
        Catch ex As Exception
            MsgBox("Errorea datu basearekin")

        End Try



        While dr.Read

            'MsgBox("0: " & dr.Item(0))
            'MsgBox("1: " & dr.Item(1))
            erabiltzailea = dr.Item(0)
            pasahitza = dr.Item(1)
            If TextBox1_User.Text.Equals(erabiltzailea) And TextBox1_Password.Text.Equals(pasahitza) Then
                aurkituta = True

            End If

        End While

        If aurkituta = True Then
            Me.Hide()
            Dim pasaralMenu As New Menu
            pasaralMenu.Show()
        ElseIf aurkituta = False Then
            MsgBox("Erabiltzailea edo pasahitza txarto daude")
        End If

        If conexionBD.State = ConnectionState.Open Then
            dr.Close()
            conexionBD.Close()
        End If

    End Sub
    Private Sub TextBox1_User_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1_User.KeyDown

        'If e.KeyCode = Keys.Enter Then

        '    'do something here...
        '    Me.Hide()
        '    Dim pasarform2 As New Menu
        '    pasarform2.Show()

        'End If

        If e.KeyCode = Keys.Enter Then





            Dim erabiltzailea As String
            Dim pasahitza As String
            Dim aurkituta As Boolean

            Dim SQL As String = "SELECT erabiltzaile, pasahitza FROM erabiltzaile"
            Dim cmd1 As New MySqlCommand(SQL, conexionBD)
            Dim dr As MySqlDataReader

            Try
                conexionBD.Open()
                dr = cmd1.ExecuteReader
            Catch ex As Exception
                MsgBox("Errorea datu basearekin")

            End Try



            While dr.Read

                erabiltzailea = dr.Item(0)
                pasahitza = dr.Item(1)
                If TextBox1_User.Text.Equals(erabiltzailea) And TextBox1_Password.Text.Equals(pasahitza) Then
                    aurkituta = True

                End If

            End While

            If aurkituta = True Then
                Me.Hide()
                Dim pasaralMenu As New Menu
                pasaralMenu.Show()
            ElseIf aurkituta = False Then
                MsgBox("Erabiltzailea edo pasahitza txarto daude")
            End If

            If conexionBD.State = ConnectionState.Open Then
                dr.Close()
                conexionBD.Close()
            End If


        End If

    End Sub
    Private Sub TextBox1_Password_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1_Password.KeyDown

        ' If e.KeyCode = Keys.Enter Then

        'do something here...
        'Me.Hide()
        'Dim pasarform2 As New Menu
        'pasarform2.Show()

        'End If

        If e.KeyCode = Keys.Enter Then

            Dim erabiltzailea As String
            Dim pasahitza As String
            Dim aurkituta As Boolean

            Dim SQL As String = "SELECT erabiltzaile, pasahitza FROM erabiltzaile"
            Dim cmd1 As New MySqlCommand(SQL, conexionBD)
            Dim dr As MySqlDataReader

            Try
                conexionBD.Open()
                dr = cmd1.ExecuteReader
            Catch ex As Exception
                MsgBox("Errorea datu basearekin")

            End Try



            While dr.Read

                'MsgBox("0: " & dr.Item(0))
                'MsgBox("1: " & dr.Item(1))
                erabiltzailea = dr.Item(0)
                pasahitza = dr.Item(1)
                If TextBox1_User.Text.Equals(erabiltzailea) And TextBox1_Password.Text.Equals(pasahitza) Then
                    aurkituta = True

                End If

            End While

            If aurkituta = True Then
                Me.Hide()
                Dim pasaralMenu As New Menu
                pasaralMenu.Show()
            ElseIf aurkituta = False Then
                MsgBox("Erabiltzailea edo pasahitza txarto daude")
            End If

            If conexionBD.State = ConnectionState.Open Then
                dr.Close()
                conexionBD.Close()
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1_User.Click
        MsgBox("Escriba su usuario")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2_Password.Click
        MsgBox("Escriba su contraseña")
    End Sub
End Class
