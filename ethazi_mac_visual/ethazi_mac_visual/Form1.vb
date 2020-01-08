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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'al clickar el boton
        MsgBox("Click Boton")

    End Sub
    Private Sub TextBox1_User_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1_User.KeyDown

        If e.KeyCode = Keys.Enter Then

            'do something here...
            MsgBox("Enter Usuario")

        End If

    End Sub
    Private Sub TextBox1_Password_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1_Password.KeyDown

        If e.KeyCode = Keys.Enter Then

            'do something here...
            MsgBox("Enter Password")

        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1_User.Click
        MsgBox("Escriba su usuario")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2_Password.Click
        MsgBox("Escriba su contraseña")
    End Sub
End Class
