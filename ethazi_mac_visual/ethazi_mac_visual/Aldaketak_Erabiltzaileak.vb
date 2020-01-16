Imports MySql.Data.MySqlClient

Public Class Aldaketak_Erabiltzaileak
    Public ventana As String

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

        Select Case ventana
            Case "erabiltzaileak"

                Label1_Titulua.Text = "Erabiltzailea"
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
                ComboBox1_ErabiltzaileMota.Text = "Mota 1 - Altua"
                '7 bloque
                'TextBox1_Izena.Text = ethazi_mac_visual.Erabiltzaileak.erabiltzailea.IzenAbizenak.ToString


            Case "ostatuak"
                Label1_Titulua.Text = "Ostatuak"


            Case "erreserbak"
                Label1_Titulua.Text = "Erreserbak"


        End Select
    End Sub

    Private Sub Button1_Gehitu_Click(sender As Object, e As EventArgs) Handles Button1_Gehitu.Click


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


            Dim cmd1 As New MySqlCommand("INSERT INTO erabiltzaile (id_erabiltzaile, erabiltzaile,pasahitza,mail,telefonoa,Erabiltzaile_mota,IzenAbizenak) VALUES (" & MaxCount + 1 & ", '" & TextBox1_Erabiltzailea.Text & "', '" & TextBox1_Pasahitza.Text & "', '" & TextBox1_Emaila.Text & "', '" & TextBox1_Telefonoa.Text & "', " & ComboBox1_ErabiltzaileMota.SelectedIndex + 1 & ", '" & TextBox1_IzenaAbizenak.Text & "')", Login.conexionBD)

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
                ethazi_mac_visual.Erabiltzaileak.DataGridView1.Rows.Add(MaxCount + 1, TextBox1_Erabiltzailea.Text, TextBox1_Pasahitza.Text, TextBox1_Emaila.Text, TextBox1_Telefonoa.Text, ComboBox1_ErabiltzaileMota.SelectedIndex, TextBox1_IzenaAbizenak.Text)

                Me.TextBox1_Erabiltzailea.Text = ""
                Me.TextBox1_Pasahitza.Text = ""
                Me.TextBox1_Emaila.Text = ""
                Me.TextBox1_Telefonoa.Text = ""
                Me.ComboBox1_ErabiltzaileMota.Text = "Mota 1 - Altua"
                Me.TextBox1_IzenaAbizenak.Text = ""

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                If Login.conexionBD.State = ConnectionState.Open Then
                    Login.conexionBD.Close()
                End If
            End Try



        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button1_Aldaketa.Click
        If MessageBox.Show("Seguru datu hauek aldatu nahi dituzula ?", "ERABILTZAILEA ALDATU", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Dim cmd1 As New MySqlCommand("UPDATE erabiltzaile SET erabiltzaile = '" & TextBox1_Erabiltzailea.Text & "', pasahitza = '" & TextBox1_Pasahitza.Text & "', mail = '" & TextBox1_Emaila.Text & "', telefonoa = '" & TextBox1_Telefonoa.Text & "', Erabiltzaile_mota = " & ComboBox1_ErabiltzaileMota.SelectedIndex + 1 & ", IzenAbizenak = '" & TextBox1_IzenaAbizenak.Text & "'    WHERE id_erabiltzaile = " & Label1_Id_Insert.Text, Login.conexionBD)

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

    Private Sub Button1_Kendu_Click(sender As Object, e As EventArgs) Handles Button1_Kendu.Click
        If MessageBox.Show("Seguru datu hauek ezabatu nahi dituzula ?", "ERABILTZAILEA KENDU", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

        End If
    End Sub

    Private Sub Button1_Atzera_Click(sender As Object, e As EventArgs) Handles Button1_Atzera.Click
        Me.Hide()
        ethazi_mac_visual.Erabiltzaileak.Show()
        ethazi_mac_visual.Erabiltzaileak.Enabled = True
    End Sub

End Class