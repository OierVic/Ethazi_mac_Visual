Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class Aldaketak_Erabiltzaileak
    'Public ventana As String

    'Erabiltzaileak
    'Public erabiltzaile As Erabiltzaile = New Erabiltzaile()
    'Public id As String
    'Public erabiltzailea As String
    'Public pasahitza As String
    'Public Emaila As String
    'Public telefonoa As String
    'Public erabiltzaileMota As String
    'Public IzenaAbizenak As String
    'Osatuak

    Dim _enabledCerrar As Boolean = False
    <System.ComponentModel.DefaultValue(False), System.ComponentModel.Description("Definitu inprimakian itxi botoia gaitzen den edo ez")>
    Public Property EnabledCerrar() As Boolean
        Get
            Return _enabledCerrar
        End Get
        Set(ByVal Value As Boolean)
            If _enabledCerrar <> Value Then
                _enabledCerrar = Value
            End If
        End Set
    End Property
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            If _enabledCerrar = False Then
                Const CS_NOCLOSE As Integer = &H200
                cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            End If
            Return cp
        End Get
    End Property

    Private Sub Aldaketak_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        'ventana = ethazi_mac_visual.Menu.accionEnviar
        'Select Case accion
        '    'Case "erabiltzailea gehitu"


        '    '    MsgBox("erabiltzailea gehitu")

        '    Case "erabiltzailea aldatu"


        '        MsgBox("erabiltzailea aldatu")

        '    Case "erabiltzailea kendu"


        'MsgBox(ethazi_mac_visual.Erabiltzaileak.erabiltzailea.id.ToString)


        'End Select

        'Select Case ventana
        'Case "erabiltzaileak"

        'Label1_Titulua.Text = "Erabiltzailea"
        '1 bloque
        'Label1_Id_Insert.Text = ethazi_mac_visual.Erabiltzaileak.erabiltzailea.id.ToString
        '2 bloque
        'TextBox1_Erabiltzaileak.Text = ethazi_mac_visual.Erabiltzaileak.erabiltzailea.erabiltzaile.ToString
        '3 bloque
        'TextBox1_Pasahitza.Text = ethazi_mac_visual.Erabiltzaileak.erabiltzailea.pasahitza.ToString
        '4 bloque
        'TextBox1_Emaila.Text = ethazi_mac_visual.Erabiltzaileak.erabiltzailea.emaila.ToString
        '5 bloque
        'TextBox1_Telefonoa.Text = ethazi_mac_visual.Erabiltzaileak.erabiltzailea.telefonoa.ToString
        '6 bloque
        'Erabiltzaile Mota da
        'ComboBox1.Enabled = False
        ComboBox1_ErabiltzaileMota.Text = "Mota 0 - Super Administratzailea"
        '7 bloque
        'TextBox1_Izena.Text = ethazi_mac_visual.Erabiltzaileak.erabiltzailea.IzenAbizenak.ToString


        'Case "ostatuak"
        'Label1_Titulua.Text = "Ostatuak"


        'Case "erreserbak"
        'Label1_Titulua.Text = "Erreserbak"


        'End Select
    End Sub
    Private Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail,
                "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function

    Private Sub Button1_Gehitu_Click(sender As Object, e As EventArgs) Handles Button1_Gehitu.Click
        Dim TodoLosDatosBien As Boolean = True

        If ComboBox1_ErabiltzaileMota.Text.Equals("Mota 0 - Super Administratzailea") Then
            ComboBox1_ErabiltzaileMota.SelectedIndex = 0
        ElseIf ComboBox1_ErabiltzaileMota.Text.Equals("Mota 1 - Bezeroa") Then
            ComboBox1_ErabiltzaileMota.SelectedIndex = 1
        ElseIf ComboBox1_ErabiltzaileMota.Text.Equals("Mota 2 - Bezeroentzako Arreta kontua") Then
            ComboBox1_ErabiltzaileMota.SelectedIndex = 2
        End If





        'validacion de campos

        'Erabiltzaile, Pasahitza, IzenaAbizenak
        TextBox1_Erabiltzailea.BackColor = Color.Green
        TextBox1_Pasahitza.BackColor = Color.Green
        TextBox1_IzenaAbizenak.BackColor = Color.Green

        'Que los campos no sean blancos

        If Len(Trim(TextBox1_Erabiltzailea.Text)) = 0 Then
            TextBox1_Erabiltzailea.BackColor = Color.Red
            TodoLosDatosBien = False
        End If
        If Len(Trim(TextBox1_Pasahitza.Text)) = 0 Then
            TextBox1_Pasahitza.BackColor = Color.Red
            TodoLosDatosBien = False
        End If
        If Len(Trim(TextBox1_Emaila.Text)) = 0 Then
            TextBox1_Emaila.BackColor = Color.Red
            TodoLosDatosBien = False
        End If
        If Len(Trim(TextBox1_Telefonoa.Text)) = 0 Then
            TextBox1_Telefonoa.BackColor = Color.Red
            TodoLosDatosBien = False
        End If
        'If Len(Trim(ComboBox1_ErabiltzaileMota.SelectedValue)) = 0 Then
        '    ComboBox1_ErabiltzaileMota.BackColor = Color.Red
        '    TodoLosDatosBien = False
        'End If
        If Len(Trim(TextBox1_IzenaAbizenak.Text)) = 0 Then
            TextBox1_IzenaAbizenak.BackColor = Color.Red
            TodoLosDatosBien = False
        End If



        'Telefonoa
        Try
            Dim telefonovalidar As Integer
            telefonovalidar = TextBox1_Telefonoa.Text
            TextBox1_Telefonoa.BackColor = Color.Green

        Catch ex As Exception
            TodoLosDatosBien = False
            TextBox1_Telefonoa.BackColor = Color.Red
        End Try

        'Erabiltzaile Mota
        If ComboBox1_ErabiltzaileMota.SelectedIndex = 0 Or ComboBox1_ErabiltzaileMota.SelectedIndex = 1 Or ComboBox1_ErabiltzaileMota.SelectedIndex = 2 Then
            ComboBox1_ErabiltzaileMota.BackColor = Color.Green

        Else
            TodoLosDatosBien = False
            ComboBox1_ErabiltzaileMota.BackColor = Color.Red

        End If


        'Emaila
        If validar_Mail(TextBox1_Emaila.Text) = False Then
            TodoLosDatosBien = False
            TextBox1_Emaila.BackColor = Color.Red
        ElseIf validar_Mail(TextBox1_Emaila.Text) = True Then
            TextBox1_Emaila.BackColor = Color.Green

        End If

        If TodoLosDatosBien = False Then
            MsgBox("Daturen bat txarto dago. Mesedez berraztertu")
        End If

        If TodoLosDatosBien = True Then



            If MessageBox.Show("Seguru datu hauek erregistratu nahi dituzula ?", "ERABILTZAILEA GEHITU", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                Dim MaxCount As Integer
                Dim cmd2 As New MySqlCommand("SELECT Count(Id_erabiltzaile) FROM erabiltzaile", Login.conexionBD)

                Try
                    Login.conexionBD.Open()

                    MaxCount = cmd2.ExecuteScalar

                    Login.conexionBD.Close()

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally

                    If Login.conexionBD.State = ConnectionState.Open Then
                        Login.conexionBD.Close()
                    End If

                End Try


                Dim cmd1 As New MySqlCommand("INSERT INTO erabiltzaile (id_erabiltzaile, erabiltzaile,pasahitza,mail,telefonoa,Erabiltzaile_mota,IzenAbizenak) VALUES (" & MaxCount + 1 & ", '" & TextBox1_Erabiltzailea.Text & "', '" & TextBox1_Pasahitza.Text & "', '" & TextBox1_Emaila.Text & "', '" & TextBox1_Telefonoa.Text & "', " & ComboBox1_ErabiltzaileMota.SelectedIndex & ", '" & TextBox1_IzenaAbizenak.Text & "')", Login.conexionBD)

                Try
                    Login.conexionBD.Open()

                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try

                Try

                    cmd1.ExecuteNonQuery()
                    Login.conexionBD.Close()
                    MsgBox("Datuak ondo gehitu dira")

                    Me.Hide()
                    ethazi_mac_visual.Erabiltzaileak.Show()
                    ethazi_mac_visual.Erabiltzaileak.Enabled = True
                    'ethazi_mac_visual.Erabiltzaileak.DataGridView1.Rows.Add(MaxCount + 1, TextBox1_Erabiltzailea.Text, TextBox1_Pasahitza.Text, TextBox1_Emaila.Text, TextBox1_Telefonoa.Text, ComboBox1_ErabiltzaileMota.SelectedIndex + 1, TextBox1_IzenaAbizenak.Text)

                    Me.TextBox1_Erabiltzailea.Text = ""
                    Me.TextBox1_Pasahitza.Text = ""
                    Me.TextBox1_Emaila.Text = ""
                    Me.TextBox1_Telefonoa.Text = ""
                    Me.ComboBox1_ErabiltzaileMota.Text = "Mota 0 - Super Administratzailea"
                    Me.TextBox1_IzenaAbizenak.Text = ""

                    'Quitar los colores
                    Me.TextBox1_Erabiltzailea.BackColor = SystemColors.Window
                    Me.TextBox1_Pasahitza.BackColor = SystemColors.Window
                    Me.TextBox1_Emaila.BackColor = Color.White
                    Me.TextBox1_Telefonoa.BackColor = SystemColors.Window
                    Me.ComboBox1_ErabiltzaileMota.BackColor = SystemColors.Window
                    Me.TextBox1_IzenaAbizenak.BackColor = SystemColors.Window


                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                Finally
                    If Login.conexionBD.State = ConnectionState.Open Then
                        Login.conexionBD.Close()
                    End If
                End Try






                'Borramos todo el datagriedview y luego hacemos un select y asi actualizamos todo
                ethazi_mac_visual.Erabiltzaileak.DataGridView1.Rows.Clear()



                Dim cmd3 As New MySqlCommand("SELECT * FROM erabiltzaile", Login.conexionBD)
                Dim dr As MySqlDataReader

                Try
                    Login.conexionBD.Open()
                    dr = cmd3.ExecuteReader
                Catch ex As Exception
                    MsgBox("Errorea datu basearekin")

                End Try
                ethazi_mac_visual.Erabiltzaileak.DataGridView1.AllowUserToAddRows = False
                ethazi_mac_visual.Erabiltzaileak.DataGridView1.AllowUserToDeleteRows = False
                ethazi_mac_visual.Erabiltzaileak.DataGridView1.AllowUserToOrderColumns = False
                ethazi_mac_visual.Erabiltzaileak.DataGridView1.ReadOnly = True
                ethazi_mac_visual.Erabiltzaileak.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                ethazi_mac_visual.Erabiltzaileak.DataGridView1.MultiSelect = False
                ethazi_mac_visual.Erabiltzaileak.DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None

                ethazi_mac_visual.Erabiltzaileak.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                ethazi_mac_visual.Erabiltzaileak.DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

                'Color que se selecciona
                ethazi_mac_visual.Erabiltzaileak.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Aqua

                While dr.Read

                    Try
                        ethazi_mac_visual.Erabiltzaileak.DataGridView1.Rows.Add(dr.Item(0), dr.Item(1), dr.Item(2), dr.Item(3), dr.Item(4), dr.Item(5), dr.Item(6))
                        ethazi_mac_visual.Erabiltzaileak.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString)
                    End Try


                End While

                If Login.conexionBD.State = ConnectionState.Open Then
                    dr.Close()
                    Login.conexionBD.Close()
                End If


            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button1_Aldaketa.Click
        Dim TodoLosDatosBien As Boolean = True

        If ComboBox1_ErabiltzaileMota.Text.Equals("Mota 0 - Super Administratzailea") Then
            ComboBox1_ErabiltzaileMota.SelectedIndex = 0
        ElseIf ComboBox1_ErabiltzaileMota.Text.Equals("Mota 1 - Bezeroa") Then
            ComboBox1_ErabiltzaileMota.SelectedIndex = 1
        ElseIf ComboBox1_ErabiltzaileMota.Text.Equals("Mota 2 - Bezeroentzako Arreta kontua") Then
            ComboBox1_ErabiltzaileMota.SelectedIndex = 2
        End If

        'validacion de campos

        'Erabiltzaile, Pasahitza, IzenaAbizenak
        TextBox1_Erabiltzailea.BackColor = Color.Green
        TextBox1_Pasahitza.BackColor = Color.Green
        TextBox1_IzenaAbizenak.BackColor = Color.Green

        'Telefonoa
        Try
            Dim telefonovalidar As Integer
            telefonovalidar = TextBox1_Telefonoa.Text
            TextBox1_Telefonoa.BackColor = Color.Green

        Catch ex As Exception
            TodoLosDatosBien = False
            TextBox1_Telefonoa.BackColor = Color.Red
        End Try

        'Erabiltzaile Mota
        If ComboBox1_ErabiltzaileMota.SelectedIndex = 0 Or ComboBox1_ErabiltzaileMota.SelectedIndex = 1 Or ComboBox1_ErabiltzaileMota.SelectedIndex = 2 Then
            ComboBox1_ErabiltzaileMota.BackColor = Color.Green
        Else
            TodoLosDatosBien = False
            ComboBox1_ErabiltzaileMota.BackColor = Color.Red

        End If


        'Emaila
        If validar_Mail(TextBox1_Emaila.Text) = False Then
            TodoLosDatosBien = False
            TextBox1_Emaila.BackColor = Color.Red
        ElseIf validar_Mail(TextBox1_Emaila.Text) = True Then
            TextBox1_Emaila.BackColor = Color.Green

        End If

        If TodoLosDatosBien = False Then
            MsgBox("Daturen bat txarto dago. Mesedez berraztertu")
        End If


        If TodoLosDatosBien = True Then




            If MessageBox.Show("Seguru datu hauek aldatu nahi dituzula ?", "ERABILTZAILEA ALDATU", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                If ComboBox1_ErabiltzaileMota.Text.Equals("Mota 0 - Super Administratzailea") Then
                    ComboBox1_ErabiltzaileMota.SelectedIndex = 0
                ElseIf ComboBox1_ErabiltzaileMota.Text.Equals("Mota 1 - Bezeroa") Then
                    ComboBox1_ErabiltzaileMota.SelectedIndex = 1
                ElseIf ComboBox1_ErabiltzaileMota.Text.Equals("Mota 2 - Bezeroentzako Arreta kontua") Then
                    ComboBox1_ErabiltzaileMota.SelectedIndex = 2
                End If


                Dim cmd1 As New MySqlCommand("UPDATE erabiltzaile SET erabiltzaile = '" & TextBox1_Erabiltzailea.Text & "', pasahitza = '" & TextBox1_Pasahitza.Text & "', mail = '" & TextBox1_Emaila.Text & "', telefonoa = '" & TextBox1_Telefonoa.Text & "', Erabiltzaile_mota = " & ComboBox1_ErabiltzaileMota.SelectedIndex & ", IzenAbizenak = '" & TextBox1_IzenaAbizenak.Text & "'    WHERE id_erabiltzaile = " & Label1_Id_Insert.Text, Login.conexionBD)

                Try
                    Login.conexionBD.Open()

                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try

                Try

                    cmd1.ExecuteNonQuery()
                    Login.conexionBD.Close()
                    MsgBox("Datuak ondo aldatu dira")

                    Me.Hide()
                    ethazi_mac_visual.Erabiltzaileak.Show()
                    ethazi_mac_visual.Erabiltzaileak.Enabled = True

                    'Vaciar TextBox
                    Me.TextBox1_Erabiltzailea.Text = ""
                    Me.TextBox1_Pasahitza.Text = ""
                    Me.TextBox1_Emaila.Text = ""
                    Me.TextBox1_Telefonoa.Text = ""
                    Me.ComboBox1_ErabiltzaileMota.Text = "Mota 0 - Super Administratzailea"
                    Me.TextBox1_IzenaAbizenak.Text = ""

                    'Quitar los colores
                    Me.TextBox1_Erabiltzailea.BackColor = SystemColors.Window
                    Me.TextBox1_Pasahitza.BackColor = SystemColors.Window
                    Me.TextBox1_Emaila.BackColor = SystemColors.Window
                    Me.TextBox1_Telefonoa.BackColor = SystemColors.Window
                    Me.ComboBox1_ErabiltzaileMota.BackColor = SystemColors.Window
                    Me.TextBox1_IzenaAbizenak.BackColor = SystemColors.Window



                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                Finally
                    If Login.conexionBD.State = ConnectionState.Open Then
                        Login.conexionBD.Close()
                    End If
                End Try


                'Borramos todo el datagriedview y luego hacemos un select y asi actualizamos todo
                ethazi_mac_visual.Erabiltzaileak.DataGridView1.Rows.Clear()



                Dim cmd2 As New MySqlCommand("SELECT * FROM erabiltzaile", Login.conexionBD)
                Dim dr As MySqlDataReader

                Try
                    Login.conexionBD.Open()
                    dr = cmd2.ExecuteReader
                Catch ex As Exception
                    MsgBox("Errorea datu basearekin")

                End Try
                ethazi_mac_visual.Erabiltzaileak.DataGridView1.AllowUserToAddRows = False
                ethazi_mac_visual.Erabiltzaileak.DataGridView1.AllowUserToDeleteRows = False
                ethazi_mac_visual.Erabiltzaileak.DataGridView1.AllowUserToOrderColumns = False
                ethazi_mac_visual.Erabiltzaileak.DataGridView1.ReadOnly = True
                ethazi_mac_visual.Erabiltzaileak.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                ethazi_mac_visual.Erabiltzaileak.DataGridView1.MultiSelect = False
                ethazi_mac_visual.Erabiltzaileak.DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None

                ethazi_mac_visual.Erabiltzaileak.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                ethazi_mac_visual.Erabiltzaileak.DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

                'Color que se selecciona
                ethazi_mac_visual.Erabiltzaileak.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Aqua

                While dr.Read

                    Try
                        ethazi_mac_visual.Erabiltzaileak.DataGridView1.Rows.Add(dr.Item(0), dr.Item(1), dr.Item(2), dr.Item(3), dr.Item(4), dr.Item(5), dr.Item(6))
                        ethazi_mac_visual.Erabiltzaileak.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString)
                    End Try


                End While

                If Login.conexionBD.State = ConnectionState.Open Then
                    dr.Close()
                    Login.conexionBD.Close()
                End If



            End If

        End If

    End Sub

    Private Sub Button1_Kendu_Click(sender As Object, e As EventArgs) Handles Button1_Kendu.Click
        If MessageBox.Show("Seguru datu hauek ezabatu nahi dituzula ?", "ERABILTZAILEA KENDU", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Dim cmd1 As New MySqlCommand("DELETE FROM erabiltzaile WHERE id_erabiltzaile = '" & Label1_Id_Insert.Text & "'", Login.conexionBD)

            Try
                Login.conexionBD.Open()

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

            Try

                cmd1.ExecuteNonQuery()
                Login.conexionBD.Close()
                MsgBox("Datuak ondo ezabatu dira")

                Me.Hide()
                ethazi_mac_visual.Erabiltzaileak.Show()
                ethazi_mac_visual.Erabiltzaileak.Enabled = True

                'Vaciar TextBox
                Me.TextBox1_Erabiltzailea.Text = ""
                Me.TextBox1_Pasahitza.Text = ""
                Me.TextBox1_Emaila.Text = ""
                Me.TextBox1_Telefonoa.Text = ""
                Me.ComboBox1_ErabiltzaileMota.Text = "Mota 0 - Super Administratzailea"
                Me.TextBox1_IzenaAbizenak.Text = ""

                'Quitar los colores
                Me.TextBox1_Erabiltzailea.BackColor = SystemColors.Window
                Me.TextBox1_Pasahitza.BackColor = SystemColors.Window
                Me.TextBox1_Emaila.BackColor = SystemColors.Window
                Me.TextBox1_Telefonoa.BackColor = SystemColors.Window
                Me.ComboBox1_ErabiltzaileMota.BackColor = SystemColors.Window
                Me.TextBox1_IzenaAbizenak.BackColor = SystemColors.Window


            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                If Login.conexionBD.State = ConnectionState.Open Then
                    Login.conexionBD.Close()
                End If
            End Try


            'Borramos todo el datagriedview y luego hacemos un select y asi actualizamos todo
            ethazi_mac_visual.Erabiltzaileak.DataGridView1.Rows.Clear()



            Dim cmd2 As New MySqlCommand("SELECT * FROM erabiltzaile", Login.conexionBD)
            Dim dr As MySqlDataReader

            Try
                Login.conexionBD.Open()
                dr = cmd2.ExecuteReader
            Catch ex As Exception
                MsgBox("Errorea datu basearekin")

            End Try
            ethazi_mac_visual.Erabiltzaileak.DataGridView1.AllowUserToAddRows = False
            ethazi_mac_visual.Erabiltzaileak.DataGridView1.AllowUserToDeleteRows = False
            ethazi_mac_visual.Erabiltzaileak.DataGridView1.AllowUserToOrderColumns = False
            ethazi_mac_visual.Erabiltzaileak.DataGridView1.ReadOnly = True
            ethazi_mac_visual.Erabiltzaileak.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            ethazi_mac_visual.Erabiltzaileak.DataGridView1.MultiSelect = False
            ethazi_mac_visual.Erabiltzaileak.DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None

            ethazi_mac_visual.Erabiltzaileak.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            ethazi_mac_visual.Erabiltzaileak.DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

            'Color que se selecciona
            ethazi_mac_visual.Erabiltzaileak.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Aqua

            While dr.Read

                Try
                    ethazi_mac_visual.Erabiltzaileak.DataGridView1.Rows.Add(dr.Item(0), dr.Item(1), dr.Item(2), dr.Item(3), dr.Item(4), dr.Item(5), dr.Item(6))
                    ethazi_mac_visual.Erabiltzaileak.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try


            End While

            If Login.conexionBD.State = ConnectionState.Open Then
                dr.Close()
                Login.conexionBD.Close()
            End If

        End If
    End Sub

    Private Sub Button1_Atzera_Click(sender As Object, e As EventArgs) Handles Button1_Atzera.Click
        Me.Hide()
        ethazi_mac_visual.Erabiltzaileak.Show()
        ethazi_mac_visual.Erabiltzaileak.Enabled = True

        'Vaciar TextBox
        Me.TextBox1_Erabiltzailea.Text = ""
        Me.TextBox1_Pasahitza.Text = ""
        Me.TextBox1_Emaila.Text = ""
        Me.TextBox1_Telefonoa.Text = ""
        Me.ComboBox1_ErabiltzaileMota.Text = "Mota 0 - Super Administratzailea"
        Me.TextBox1_IzenaAbizenak.Text = ""

        'Quitar los colores
        Me.TextBox1_Erabiltzailea.BackColor = SystemColors.Window
        Me.TextBox1_Pasahitza.BackColor = SystemColors.Window
        Me.TextBox1_Emaila.BackColor = SystemColors.Window
        Me.TextBox1_Telefonoa.BackColor = SystemColors.Window
        Me.ComboBox1_ErabiltzaileMota.BackColor = SystemColors.Window
        Me.TextBox1_IzenaAbizenak.BackColor = SystemColors.Window


    End Sub

End Class