Imports MySql.Data.MySqlClient

Public Class Aldaketak_Erreserbak
    Private Sub Aldaketak_Erreserbak_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Atzera_Click(sender As Object, e As EventArgs) Handles Button1_Atzera.Click
        Me.Hide()
        ethazi_mac_visual.Erreserbak.Show()
        ethazi_mac_visual.Erreserbak.Enabled = True


        'Vaciar TextBox
        Me.TextBox1_ID_Ostatu.Text = ""
        Me.TextBox1_ID_Erabiltzaile.Text = ""
        Me.DateTimePicker1_Hasiera_Data.Value = DateTime.Now
        Me.DateTimePicker1_Amaiera_Data.Value = DateTime.Now.AddDays(5)




        'Quitar los colores
        Me.TextBox1_ID_Ostatu.BackColor = SystemColors.Window
        Me.TextBox1_ID_Erabiltzaile.BackColor = SystemColors.Window
        Me.DateTimePicker1_Hasiera_Data.BackColor = SystemColors.Window
        Me.DateTimePicker1_Amaiera_Data.BackColor = SystemColors.Window


    End Sub

    Private Sub Button1_Gehitu_Click(sender As Object, e As EventArgs) Handles Button1_Gehitu.Click

    End Sub

    Private Sub Button1_Aldaketa_Click(sender As Object, e As EventArgs) Handles Button1_Aldaketa.Click

    End Sub

    Private Sub Button1_Kendu_Click(sender As Object, e As EventArgs) Handles Button1_Kendu.Click
        If MessageBox.Show("Seguru datu hauek ezabatu nahi dituzula ?", "ERRESERBA KENDU", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Dim cmd1 As New MySqlCommand("DELETE FROM erreserba WHERE id_Erreserba = " & Label1_Id_Erreserba_Insert.Text, Login.conexionBD)

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
                ethazi_mac_visual.Erreserbak.Show()
                ethazi_mac_visual.Erreserbak.Enabled = True

                'Vaciar TextBox
                Me.TextBox1_ID_Ostatu.Text = ""
                Me.TextBox1_ID_Erabiltzaile.Text = ""
                Me.DateTimePicker1_Hasiera_Data.Value = DateTime.Now
                Me.DateTimePicker1_Amaiera_Data.Value = DateTime.Now.AddDays(5)




                'Quitar los colores
                Me.TextBox1_ID_Ostatu.BackColor = SystemColors.Window
                Me.TextBox1_ID_Erabiltzaile.BackColor = SystemColors.Window
                Me.DateTimePicker1_Hasiera_Data.BackColor = SystemColors.Window
                Me.DateTimePicker1_Amaiera_Data.BackColor = SystemColors.Window

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                If Login.conexionBD.State = ConnectionState.Open Then
                    Login.conexionBD.Close()
                End If
            End Try


            'Borramos todo el datagriedview y luego hacemos un select y asi actualizamos todo
            ethazi_mac_visual.Erreserbak.DataGridView1.Rows.Clear()



            Dim cmd2 As New MySqlCommand("SELECT * FROM erreserba", Login.conexionBD)
            Dim dr As MySqlDataReader

            Try
                Login.conexionBD.Open()
                dr = cmd2.ExecuteReader
            Catch ex As Exception
                MsgBox("Errorea datu basearekin")

            End Try
            ethazi_mac_visual.Erreserbak.DataGridView1.AllowUserToAddRows = False
            ethazi_mac_visual.Erreserbak.DataGridView1.AllowUserToDeleteRows = False
            ethazi_mac_visual.Erreserbak.DataGridView1.AllowUserToOrderColumns = False
            ethazi_mac_visual.Erreserbak.DataGridView1.ReadOnly = True
            ethazi_mac_visual.Erreserbak.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            ethazi_mac_visual.Erreserbak.DataGridView1.MultiSelect = False
            ethazi_mac_visual.Erreserbak.DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None

            ethazi_mac_visual.Erreserbak.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            ethazi_mac_visual.Erreserbak.DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

            'Color que se selecciona
            ethazi_mac_visual.Erreserbak.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Aqua

            While dr.Read

                Try
                    ethazi_mac_visual.Erreserbak.DataGridView1.Rows.Add(dr.Item(0), dr.Item(1), dr.Item(2), dr.Item(3), dr.Item(4), dr.Item(5), dr.Item(6))
                    ethazi_mac_visual.Erreserbak.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Chartreuse
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