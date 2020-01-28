Imports MySql.Data.MySqlClient

Public Class Erreserbak
    Public Erreserba As Erreserba

    Private Sub Erreserbak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim conexionBD As New MySqlConnection("server=127.0.0.1 ; userid=root ; password = ; database=ethazi_mac")
        'conexionBD = Login.conexionBD
        'Dim SQL As String = "SELECT * FROM erreserba"
        Dim cmd1 As New MySqlCommand("SELECT * FROM erreserba", Login.conexionBD)
        Dim dr As MySqlDataReader

        Try
            Login.conexionBD.Open()
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
                DataGridView1.Rows.Add(dr.Item(0), dr.Item(1), dr.Item(2), dr.Item(3), dr.Item(4), dr.Item(5), dr.Item(6))
                DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Chartreuse
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try


        End While

        If Login.conexionBD.State = ConnectionState.Open Then
            dr.Close()
            Login.conexionBD.Close()
        End If
    End Sub

    Private Sub Button1_Atzera_Click(sender As Object, e As EventArgs) Handles Button1_Atzera.Click
        Me.Hide()
        ethazi_mac_visual.Menu.Show()
    End Sub

    Private Sub Button1_Atzera_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1_Atzera.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                End
            Case Keys.Back
                Me.Hide()
                ethazi_mac_visual.Menu.Show()
            Case Keys.Enter
                Me.Hide()
                ethazi_mac_visual.Menu.Show()

        End Select
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                End
            Case Keys.Back
                Me.Hide()
                ethazi_mac_visual.Menu.Show()
        End Select

    End Sub

    Private Sub Button1_Gehitu_Click(sender As Object, e As EventArgs) Handles Button1_Gehitu.Click
        'Me.Hide()
        Me.Enabled = False
        Aldaketak_Erreserbak.Show()
        ethazi_mac_visual.Aldaketak_Erreserbak.Button1_Gehitu.Visible = True
        ethazi_mac_visual.Aldaketak_Erreserbak.Button1_Aldaketa.Visible = False
        ethazi_mac_visual.Aldaketak_Erreserbak.Button1_Kendu.Visible = False


        Dim MaxCount As Integer
        Dim cmd2 As New MySqlCommand("SELECT Count(id_Erreserba) FROM erreserba", Login.conexionBD)

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

        'Añadir un id nuevo sumando el maximo del ultimo

        MaxCount = MaxCount + 1

        ethazi_mac_visual.Aldaketak_Erreserbak.Label1_Id_Erreserba_Insert.Text = MaxCount.ToString

        'Vaciar TextBox
        ethazi_mac_visual.Aldaketak_Erreserbak.TextBox1_ID_Ostatu.Text = ""
        ethazi_mac_visual.Aldaketak_Erreserbak.TextBox1_ID_Erabiltzaile.Text = ""
        ethazi_mac_visual.Aldaketak_Erreserbak.DateTimePicker1_Hasiera_Data.Value = DateTime.Now
        ethazi_mac_visual.Aldaketak_Erreserbak.DateTimePicker1_Amaiera_Data.Value = DateTime.Now.AddDays(1)




        'Quitar los colores
        ethazi_mac_visual.Aldaketak_Erreserbak.TextBox1_ID_Ostatu.BackColor = SystemColors.Window
        ethazi_mac_visual.Aldaketak_Erreserbak.TextBox1_ID_Erabiltzaile.BackColor = SystemColors.Window
        ethazi_mac_visual.Aldaketak_Erreserbak.DateTimePicker1_Hasiera_Data.BackColor = SystemColors.Window
        ethazi_mac_visual.Aldaketak_Erreserbak.DateTimePicker1_Amaiera_Data.BackColor = SystemColors.Window


    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            Erreserba = New Erreserba()


            If (e.RowIndex >= 0) Then

                Erreserba.id = CInt(Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString)
                Erreserba.id_ostatu = CInt(Me.DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString)
                Erreserba.id_erabiltzaile = CInt(Me.DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString)
                Erreserba.Erreserba_Data = CDate(Me.DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString)
                Erreserba.Hasiera_Data = CDate(Me.DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString)
                Erreserba.Amaiera_Data = CDate(Me.DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString)
                Erreserba.Prezio_Guztira = CDbl(Me.DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString)


                ethazi_mac_visual.Aldaketak_Erreserbak.Label1_Id_Erreserba_Insert.Text = Erreserba.id
                ethazi_mac_visual.Aldaketak_Erreserbak.TextBox1_ID_Ostatu.Text = Erreserba.id_ostatu
                ethazi_mac_visual.Aldaketak_Erreserbak.TextBox1_ID_Erabiltzaile.Text = Erreserba.id_erabiltzaile
                ethazi_mac_visual.Aldaketak_Erreserbak.DateTimePicker1_Hasiera_Data.Value = Erreserba.Hasiera_Data
                ethazi_mac_visual.Aldaketak_Erreserbak.DateTimePicker1_Amaiera_Data.Value = Erreserba.Amaiera_Data



                ethazi_mac_visual.Aldaketak_Erreserbak.Button1_Gehitu.Visible = False
                ethazi_mac_visual.Aldaketak_Erreserbak.Button1_Aldaketa.Visible = True
                ethazi_mac_visual.Aldaketak_Erreserbak.Button1_Kendu.Visible = True

                'Quitar los colores
                ethazi_mac_visual.Aldaketak_Erreserbak.TextBox1_ID_Ostatu.BackColor = SystemColors.Window
                ethazi_mac_visual.Aldaketak_Erreserbak.TextBox1_ID_Erabiltzaile.BackColor = SystemColors.Window
                ethazi_mac_visual.Aldaketak_Erreserbak.DateTimePicker1_Hasiera_Data.BackColor = SystemColors.Window
                ethazi_mac_visual.Aldaketak_Erreserbak.DateTimePicker1_Amaiera_Data.BackColor = SystemColors.Window



            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




        'Me.Hide()
        Me.Enabled = False
        Aldaketak_Erreserbak.Show()
    End Sub
End Class