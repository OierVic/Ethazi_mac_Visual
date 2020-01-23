Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class Aldaketak_Ostatuak

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

    Private Sub Aldaketak_Ostatuak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ComboBox1_Ostatu_Mota.Text = "Campings"
    End Sub

    Private Sub Button1_Atzera_Click(sender As Object, e As EventArgs) Handles Button1_Atzera.Click
        Me.Hide()
        ethazi_mac_visual.Ostatuak.Show()
        ethazi_mac_visual.Ostatuak.Enabled = True


        'Vaciar TextBox
        Me.TextBox1_Izena.Text = ""
        Me.RichTextBox1_Deskribapena.Text = ""
        Me.ComboBox1_Ostatu_Mota.Text = "Campings"
        Me.NumericUpDown1_Logela_kop.Value = 5
        Me.RichTextBox1_Kokapena.Text = ""
        Me.TextBox1_Telefonoa.Text = ""
        Me.TextBox1_Email.Text = ""
        Me.TextBox1_Latitudea.Text = ""
        Me.TextBox1_Longitudea.Text = ""
        Me.TextBox1_Prezioa.Text = ""

        'Quitar los colores
        Me.TextBox1_Izena.BackColor = SystemColors.Window
        Me.RichTextBox1_Deskribapena.BackColor = SystemColors.Window
        Me.ComboBox1_Ostatu_Mota.BackColor = SystemColors.Window
        Me.NumericUpDown1_Logela_kop.BackColor = SystemColors.Window
        Me.RichTextBox1_Kokapena.BackColor = SystemColors.Window
        Me.TextBox1_Telefonoa.BackColor = SystemColors.Window
        Me.TextBox1_Email.BackColor = SystemColors.Window
        Me.TextBox1_Latitudea.BackColor = SystemColors.Window
        Me.TextBox1_Longitudea.BackColor = SystemColors.Window
        Me.TextBox1_Prezioa.BackColor = SystemColors.Window

    End Sub
    Private Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail,
                "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function

    Private Sub Button1_Gehitu_Click(sender As Object, e As EventArgs) Handles Button1_Gehitu.Click
        Dim TodoLosDatosBien As Boolean = True

        If ComboBox1_Ostatu_Mota.Text.Equals("Campings") Then
            ComboBox1_Ostatu_Mota.SelectedIndex = 0
        End If


        'validacion de campos
        NumericUpDown1_Logela_kop.BackColor = Color.Green
        'Que los campos no sean blancos
        'Izena, Deskribapena, Kokapena, 

        If Len(Trim(TextBox1_Izena.Text)) = 0 Then
            TextBox1_Izena.BackColor = Color.Red
            TodoLosDatosBien = False
        Else
            TextBox1_Izena.BackColor = Color.Green
        End If



        If Len(Trim(RichTextBox1_Deskribapena.Text)) = 0 Then
            RichTextBox1_Deskribapena.BackColor = Color.Red
            TodoLosDatosBien = False
        Else
            RichTextBox1_Deskribapena.BackColor = Color.Green
        End If



        If Len(Trim(RichTextBox1_Kokapena.Text)) = 0 Then
            RichTextBox1_Kokapena.BackColor = Color.Red
            TodoLosDatosBien = False
        Else
            RichTextBox1_Kokapena.BackColor = Color.Green
        End If



        If Len(Trim(TextBox1_Email.Text)) = 0 Then
            TextBox1_Email.BackColor = Color.Red
            TodoLosDatosBien = False
        Else
            TextBox1_Email.BackColor = Color.Green
        End If



        If Len(Trim(TextBox1_Telefonoa.Text)) = 0 Then
            TextBox1_Telefonoa.BackColor = Color.Red
            TodoLosDatosBien = False
        Else
            TextBox1_Telefonoa.BackColor = Color.Green
        End If



        If Len(Trim(TextBox1_Latitudea.Text)) = 0 Then
            TextBox1_Latitudea.BackColor = Color.Red
            TodoLosDatosBien = False
        Else
            TextBox1_Latitudea.BackColor = Color.Green
        End If



        If Len(Trim(TextBox1_Longitudea.Text)) = 0 Then
            TextBox1_Longitudea.BackColor = Color.Red
            TodoLosDatosBien = False
        Else
            TextBox1_Longitudea.BackColor = Color.Green
        End If



        If Len(Trim(TextBox1_Prezioa.Text)) = 0 Then
            TextBox1_Prezioa.BackColor = Color.Red
            TodoLosDatosBien = False
        Else
            TextBox1_Prezioa.BackColor = Color.Green
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

        'Ostatu Mota
        If ComboBox1_Ostatu_Mota.SelectedIndex = -1 Then
            ComboBox1_Ostatu_Mota.BackColor = Color.Red
            TodoLosDatosBien = False
        Else
            ComboBox1_Ostatu_Mota.BackColor = Color.Green
        End If


        'Emaila
        If validar_Mail(TextBox1_Email.Text) = False Then
            TodoLosDatosBien = False
            TextBox1_Email.BackColor = Color.Red
        ElseIf validar_Mail(TextBox1_Email.Text) = True Then
            TextBox1_Email.BackColor = Color.Green
        End If

        'Validar Latitudea
        Try
            Dim LatidudeaDouble As Double = CDbl(TextBox1_Latitudea.Text)
            TextBox1_Latitudea.BackColor = Color.Green

        Catch ex As Exception
            TodoLosDatosBien = False
            TextBox1_Latitudea.BackColor = Color.Red
        End Try


        'Validar Longitudea
        Try
            Dim LongitudeaDouble As Double = CDbl(TextBox1_Longitudea.Text)
            TextBox1_Longitudea.BackColor = Color.Green

        Catch ex As Exception
            TodoLosDatosBien = False
            TextBox1_Longitudea.BackColor = Color.Red
        End Try

        'Validar Prezioa
        Try
            Dim PrezioaDouble As Double = CDbl(TextBox1_Prezioa.Text)
            TextBox1_Prezioa.BackColor = Color.Green

        Catch ex As Exception
            TodoLosDatosBien = False
            TextBox1_Prezioa.BackColor = Color.Red
        End Try

        If TextBox1_Prezioa.Text.Contains(",") Then
            TodoLosDatosBien = False
            TextBox1_Prezioa.BackColor = Color.Red
            MsgBox("Punto batekin '.' jarri behar da ez komarekin ")
        End If

        If TodoLosDatosBien = False Then
            MsgBox("Daturen bat txarto dago. Mesedez berraztertu")
        End If

        If TodoLosDatosBien = True Then



            If MessageBox.Show("Seguru datu hauek erregistratu nahi dituzula ?", "OSTATUA GEHITU", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                Dim MaxCount As Integer
                Dim cmd2 As New MySqlCommand("SELECT Count(id_Ostatu) FROM ostatu", Login.conexionBD)

                Try
                    Login.conexionBD.Open()

                    MaxCount = cmd2.ExecuteScalar

                    Login.conexionBD.Close()

                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                Finally

                    If Login.conexionBD.State = ConnectionState.Open Then
                        Login.conexionBD.Close()
                    End If

                End Try


                Dim cmd1 As New MySqlCommand("INSERT INTO ostatu (id_Ostatu, Izena,Deskribapena,Ostatu_mota,Logela_kop,Kokapena,Telefonoa,Email,Latitudea,Longitudea,Prezioa) VALUES (" & MaxCount + 1 & ", '" & TextBox1_Izena.Text & "', '" & RichTextBox1_Deskribapena.Text & "', '" & ComboBox1_Ostatu_Mota.Text & "', " & NumericUpDown1_Logela_kop.Value & ", '" & RichTextBox1_Kokapena.Text & "', '" & TextBox1_Telefonoa.Text & "', '" & TextBox1_Email.Text & "', '" & TextBox1_Latitudea.Text & "', '" & TextBox1_Longitudea.Text & "', " & TextBox1_Prezioa.Text & ")", Login.conexionBD)

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
                    ethazi_mac_visual.Ostatuak.Show()
                    ethazi_mac_visual.Ostatuak.Enabled = True


                    'Vaciar TextBox
                    Me.TextBox1_Izena.Text = ""
                    Me.RichTextBox1_Deskribapena.Text = ""
                    Me.ComboBox1_Ostatu_Mota.Text = "Campings"
                    Me.NumericUpDown1_Logela_kop.Value = 5
                    Me.RichTextBox1_Kokapena.Text = ""
                    Me.TextBox1_Telefonoa.Text = ""
                    Me.TextBox1_Email.Text = ""
                    Me.TextBox1_Latitudea.Text = ""
                    Me.TextBox1_Longitudea.Text = ""
                    Me.TextBox1_Prezioa.Text = ""

                    'Quitar los colores
                    Me.TextBox1_Izena.BackColor = SystemColors.Window
                    Me.RichTextBox1_Deskribapena.BackColor = SystemColors.Window
                    Me.ComboBox1_Ostatu_Mota.BackColor = SystemColors.Window
                    Me.NumericUpDown1_Logela_kop.BackColor = SystemColors.Window
                    Me.RichTextBox1_Kokapena.BackColor = SystemColors.Window
                    Me.TextBox1_Telefonoa.BackColor = SystemColors.Window
                    Me.TextBox1_Email.BackColor = SystemColors.Window
                    Me.TextBox1_Latitudea.BackColor = SystemColors.Window
                    Me.TextBox1_Longitudea.BackColor = SystemColors.Window
                    Me.TextBox1_Prezioa.BackColor = SystemColors.Window


                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                Finally
                    If Login.conexionBD.State = ConnectionState.Open Then
                        Login.conexionBD.Close()
                    End If
                End Try






                'Borramos todo el datagriedview y luego hacemos un select y asi actualizamos todo
                ethazi_mac_visual.Ostatuak.DataGridView1.Rows.Clear()



                Dim cmd3 As New MySqlCommand("SELECT * FROM ostatu", Login.conexionBD)
                Dim dr As MySqlDataReader

                Try
                    Login.conexionBD.Open()
                    dr = cmd3.ExecuteReader
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)

                End Try
                ethazi_mac_visual.Ostatuak.DataGridView1.AllowUserToAddRows = False
                ethazi_mac_visual.Ostatuak.DataGridView1.AllowUserToDeleteRows = False
                ethazi_mac_visual.Ostatuak.DataGridView1.AllowUserToOrderColumns = False
                ethazi_mac_visual.Ostatuak.DataGridView1.ReadOnly = True
                ethazi_mac_visual.Ostatuak.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                ethazi_mac_visual.Ostatuak.DataGridView1.MultiSelect = False
                ethazi_mac_visual.Ostatuak.DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None

                ethazi_mac_visual.Ostatuak.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                ethazi_mac_visual.Ostatuak.DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

                'Color que se selecciona
                ethazi_mac_visual.Ostatuak.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Green

                While dr.Read

                    Try
                        ethazi_mac_visual.Ostatuak.DataGridView1.Rows.Add(dr.Item(0), dr.Item(1), dr.Item(2), dr.Item(3), dr.Item(4), dr.Item(5), dr.Item(6), dr.Item(7), dr.Item(8), dr.Item(9), dr.Item(10))
                        ethazi_mac_visual.Ostatuak.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
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

    Private Sub Button1_Aldaketa_Click(sender As Object, e As EventArgs) Handles Button1_Aldaketa.Click


        Dim TodoLosDatosBien As Boolean = True

        If ComboBox1_Ostatu_Mota.Text.Equals("Campings") Then
            ComboBox1_Ostatu_Mota.SelectedIndex = 0
        End If


        'validacion de campos
        NumericUpDown1_Logela_kop.BackColor = Color.Green
        'Que los campos no sean blancos
        'Izena, Deskribapena, Kokapena, 

        If Len(Trim(TextBox1_Izena.Text)) = 0 Then
            TextBox1_Izena.BackColor = Color.Red
            TodoLosDatosBien = False
        Else
            TextBox1_Izena.BackColor = Color.Green
        End If



        If Len(Trim(RichTextBox1_Deskribapena.Text)) = 0 Then
            RichTextBox1_Deskribapena.BackColor = Color.Red
            TodoLosDatosBien = False
        Else
            RichTextBox1_Deskribapena.BackColor = Color.Green
        End If



        If Len(Trim(RichTextBox1_Kokapena.Text)) = 0 Then
            RichTextBox1_Kokapena.BackColor = Color.Red
            TodoLosDatosBien = False
        Else
            RichTextBox1_Kokapena.BackColor = Color.Green
        End If



        If Len(Trim(TextBox1_Email.Text)) = 0 Then
            TextBox1_Email.BackColor = Color.Red
            TodoLosDatosBien = False
        Else
            TextBox1_Email.BackColor = Color.Green
        End If



        If Len(Trim(TextBox1_Telefonoa.Text)) = 0 Then
            TextBox1_Telefonoa.BackColor = Color.Red
            TodoLosDatosBien = False
        Else
            TextBox1_Telefonoa.BackColor = Color.Green
        End If



        If Len(Trim(TextBox1_Latitudea.Text)) = 0 Then
            TextBox1_Latitudea.BackColor = Color.Red
            TodoLosDatosBien = False
        Else
            TextBox1_Latitudea.BackColor = Color.Green
        End If



        If Len(Trim(TextBox1_Longitudea.Text)) = 0 Then
            TextBox1_Longitudea.BackColor = Color.Red
            TodoLosDatosBien = False
        Else
            TextBox1_Longitudea.BackColor = Color.Green
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

        'Ostatu Mota
        If ComboBox1_Ostatu_Mota.SelectedIndex = -1 Then
            ComboBox1_Ostatu_Mota.BackColor = Color.Red
            TodoLosDatosBien = False
        Else
            ComboBox1_Ostatu_Mota.BackColor = Color.Green
        End If


        'Emaila
        If validar_Mail(TextBox1_Email.Text) = False Then
            TodoLosDatosBien = False
            TextBox1_Email.BackColor = Color.Red
        ElseIf validar_Mail(TextBox1_Email.Text) = True Then
            TextBox1_Email.BackColor = Color.Green
        End If

        'Validar Latitudea
        Try
            Dim LatidudeaDouble As Double = CDbl(TextBox1_Latitudea.Text)
            TextBox1_Latitudea.BackColor = Color.Green

        Catch ex As Exception
            TodoLosDatosBien = False
            TextBox1_Latitudea.BackColor = Color.Red
        End Try


        'Validar Longitudea
        Try
            Dim LongitudeaDouble As Double = CDbl(TextBox1_Longitudea.Text)
            TextBox1_Longitudea.BackColor = Color.Green

        Catch ex As Exception
            TodoLosDatosBien = False
            TextBox1_Longitudea.BackColor = Color.Red
        End Try

        'Validar Prezioa
        Try
            Dim PrezioaDouble As Double = CDbl(TextBox1_Prezioa.Text)
            TextBox1_Prezioa.BackColor = Color.Green

        Catch ex As Exception
            TodoLosDatosBien = False
            TextBox1_Prezioa.BackColor = Color.Red
        End Try

        If TextBox1_Prezioa.Text.Contains(",") Then
            TodoLosDatosBien = False
            TextBox1_Prezioa.BackColor = Color.Red
            MsgBox("Punto batekin '.' jarri behar da ez komarekin ")
        End If




        If TodoLosDatosBien = False Then
            MsgBox("Daturen bat txarto dago. Mesedez berraztertu")
        End If


        If TodoLosDatosBien = True Then




            If MessageBox.Show("Seguru datu hauek aldatu nahi dituzula ?", "OSTATUA ALDATU", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

                Dim cmd1 As New MySqlCommand("UPDATE ostatu SET Izena = '" & TextBox1_Izena.Text & "', Deskribapena = '" & RichTextBox1_Deskribapena.Text & "', Ostatu_mota = '" & ComboBox1_Ostatu_Mota.Text & "', Logela_kop = '" & NumericUpDown1_Logela_kop.Text & "', Kokapena = '" & RichTextBox1_Kokapena.Text & "', Telefonoa = " & TextBox1_Telefonoa.Text & ", Email = '" & TextBox1_Email.Text & "', Latitudea = '" & TextBox1_Latitudea.Text & "', Longitudea = '" & TextBox1_Longitudea.Text & "', Prezioa = " & TextBox1_Prezioa.Text & " WHERE id_Ostatu = " & Label1_Id_Ostatu_Insert.Text, Login.conexionBD)

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
                    ethazi_mac_visual.Ostatuak.Show()
                    ethazi_mac_visual.Ostatuak.Enabled = True

                    'Vaciar TextBox
                    Me.TextBox1_Izena.Text = ""
                    Me.RichTextBox1_Deskribapena.Text = ""
                    Me.ComboBox1_Ostatu_Mota.Text = "Campings"
                    Me.NumericUpDown1_Logela_kop.Value = 5
                    Me.RichTextBox1_Kokapena.Text = ""
                    Me.TextBox1_Telefonoa.Text = ""
                    Me.TextBox1_Email.Text = ""
                    Me.TextBox1_Latitudea.Text = ""
                    Me.TextBox1_Longitudea.Text = ""
                    Me.TextBox1_Prezioa.Text = ""

                    'Quitar los colores
                    Me.TextBox1_Izena.BackColor = SystemColors.Window
                    Me.RichTextBox1_Deskribapena.BackColor = SystemColors.Window
                    Me.ComboBox1_Ostatu_Mota.BackColor = SystemColors.Window
                    Me.NumericUpDown1_Logela_kop.BackColor = SystemColors.Window
                    Me.RichTextBox1_Kokapena.BackColor = SystemColors.Window
                    Me.TextBox1_Telefonoa.BackColor = SystemColors.Window
                    Me.TextBox1_Email.BackColor = SystemColors.Window
                    Me.TextBox1_Latitudea.BackColor = SystemColors.Window
                    Me.TextBox1_Longitudea.BackColor = SystemColors.Window
                    Me.TextBox1_Prezioa.BackColor = SystemColors.Window



                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                Finally
                    If Login.conexionBD.State = ConnectionState.Open Then
                        Login.conexionBD.Close()
                    End If
                End Try


                'Borramos todo el datagriedview y luego hacemos un select y asi actualizamos todo
                ethazi_mac_visual.Ostatuak.DataGridView1.Rows.Clear()



                Dim cmd2 As New MySqlCommand("SELECT * FROM ostatu", Login.conexionBD)
                Dim dr As MySqlDataReader

                Try
                    Login.conexionBD.Open()
                    dr = cmd2.ExecuteReader
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)

                End Try
                ethazi_mac_visual.Ostatuak.DataGridView1.AllowUserToAddRows = False
                ethazi_mac_visual.Ostatuak.DataGridView1.AllowUserToDeleteRows = False
                ethazi_mac_visual.Ostatuak.DataGridView1.AllowUserToOrderColumns = False
                ethazi_mac_visual.Ostatuak.DataGridView1.ReadOnly = True
                ethazi_mac_visual.Ostatuak.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                ethazi_mac_visual.Ostatuak.DataGridView1.MultiSelect = False
                ethazi_mac_visual.Ostatuak.DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None

                ethazi_mac_visual.Ostatuak.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                ethazi_mac_visual.Ostatuak.DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

                'Color que se selecciona
                ethazi_mac_visual.Ostatuak.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Aqua

                While dr.Read

                    Try
                        ethazi_mac_visual.Ostatuak.DataGridView1.Rows.Add(dr.Item(0), dr.Item(1), dr.Item(2), dr.Item(3), dr.Item(4), dr.Item(5), dr.Item(6), dr.Item(7), dr.Item(8), dr.Item(9), dr.Item(10))
                        ethazi_mac_visual.Ostatuak.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
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

        If MessageBox.Show("Seguru datu hauek ezabatu nahi dituzula ?", "OSTATUA KENDU", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Dim cmd1 As New MySqlCommand("DELETE FROM ostatu WHERE id_Ostatu = " & Label1_Id_Ostatu_Insert.Text, Login.conexionBD)

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
                ethazi_mac_visual.Ostatuak.Show()
                ethazi_mac_visual.Ostatuak.Enabled = True

                'Vaciar TextBox
                Me.TextBox1_Izena.Text = ""
                Me.RichTextBox1_Deskribapena.Text = ""
                Me.ComboBox1_Ostatu_Mota.Text = "Campings"
                Me.NumericUpDown1_Logela_kop.Value = 5
                Me.RichTextBox1_Kokapena.Text = ""
                Me.TextBox1_Telefonoa.Text = ""
                Me.TextBox1_Email.Text = ""
                Me.TextBox1_Latitudea.Text = ""
                Me.TextBox1_Longitudea.Text = ""
                Me.TextBox1_Prezioa.Text = ""

                'Quitar los colores
                Me.TextBox1_Izena.BackColor = SystemColors.Window
                Me.RichTextBox1_Deskribapena.BackColor = SystemColors.Window
                Me.ComboBox1_Ostatu_Mota.BackColor = SystemColors.Window
                Me.NumericUpDown1_Logela_kop.BackColor = SystemColors.Window
                Me.RichTextBox1_Kokapena.BackColor = SystemColors.Window
                Me.TextBox1_Telefonoa.BackColor = SystemColors.Window
                Me.TextBox1_Email.BackColor = SystemColors.Window
                Me.TextBox1_Latitudea.BackColor = SystemColors.Window
                Me.TextBox1_Longitudea.BackColor = SystemColors.Window
                Me.TextBox1_Prezioa.BackColor = SystemColors.Window

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                If Login.conexionBD.State = ConnectionState.Open Then
                    Login.conexionBD.Close()
                End If
            End Try


            'Borramos todo el datagriedview y luego hacemos un select y asi actualizamos todo
            ethazi_mac_visual.Ostatuak.DataGridView1.Rows.Clear()



            Dim cmd2 As New MySqlCommand("SELECT * FROM ostatu", Login.conexionBD)
            Dim dr As MySqlDataReader

            Try
                Login.conexionBD.Open()
                dr = cmd2.ExecuteReader
            Catch ex As Exception
                MsgBox("Errorea datu basearekin")

            End Try
            ethazi_mac_visual.Ostatuak.DataGridView1.AllowUserToAddRows = False
            ethazi_mac_visual.Ostatuak.DataGridView1.AllowUserToDeleteRows = False
            ethazi_mac_visual.Ostatuak.DataGridView1.AllowUserToOrderColumns = False
            ethazi_mac_visual.Ostatuak.DataGridView1.ReadOnly = True
            ethazi_mac_visual.Ostatuak.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            ethazi_mac_visual.Ostatuak.DataGridView1.MultiSelect = False
            ethazi_mac_visual.Ostatuak.DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None

            ethazi_mac_visual.Ostatuak.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            ethazi_mac_visual.Ostatuak.DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

            'Color que se selecciona
            ethazi_mac_visual.Ostatuak.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Aqua

            While dr.Read

                Try
                    ethazi_mac_visual.Ostatuak.DataGridView1.Rows.Add(dr.Item(0), dr.Item(1), dr.Item(2), dr.Item(3), dr.Item(4), dr.Item(5), dr.Item(6), dr.Item(7), dr.Item(8), dr.Item(9), dr.Item(10))
                    ethazi_mac_visual.Ostatuak.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
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
End Class