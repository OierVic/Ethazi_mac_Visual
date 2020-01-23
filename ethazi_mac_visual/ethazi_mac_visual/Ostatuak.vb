Imports MySql.Data.MySqlClient

Public Class Ostatuak
    Public Ostatua As Ostatua

    Private Sub Ostatuak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim conexionBD As New MySqlConnection("server=127.0.0.1 ; userid=root ; password = ; database=ethazi_mac")

        'Dim SQL As String = "SELECT * FROM ostatu"
        Dim cmd1 As New MySqlCommand("SELECT * FROM ostatu", Login.conexionBD)
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
                DataGridView1.Rows.Add(dr.Item(0), dr.Item(1), dr.Item(2), dr.Item(3), dr.Item(4), dr.Item(5), dr.Item(6), dr.Item(7), dr.Item(8), dr.Item(9), dr.Item(10))
                DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try


        End While

        If Login.conexionBD.State = ConnectionState.Open Then
            dr.Close()
            Login.conexionBD.Close()
        End If
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

    Private Sub Button1_Gehitu_Click(sender As Object, e As EventArgs) Handles Button1_Gehitu.Click

        'Me.Hide()
        Me.Enabled = False
        Aldaketak_Ostatuak.Show()
        ethazi_mac_visual.Aldaketak_Ostatuak.Button1_Gehitu.Visible = True
        ethazi_mac_visual.Aldaketak_Ostatuak.Button1_Aldaketa.Visible = False
        ethazi_mac_visual.Aldaketak_Ostatuak.Button1_Kendu.Visible = False


        Dim MaxCount As Integer
        Dim cmd2 As New MySqlCommand("SELECT Count(id_Ostatu) FROM ostatu", Login.conexionBD)

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

        ethazi_mac_visual.Aldaketak_Ostatuak.Label1_Id_Ostatu_Insert.Text = MaxCount.ToString

        'Vaciar TextBox
        ethazi_mac_visual.Aldaketak_Ostatuak.TextBox1_Izena.Text = ""
        ethazi_mac_visual.Aldaketak_Ostatuak.RichTextBox1_Deskribapena.Text = ""
        ethazi_mac_visual.Aldaketak_Ostatuak.ComboBox1_Ostatu_Mota.Text = "Campings"
        ethazi_mac_visual.Aldaketak_Ostatuak.NumericUpDown1_Logela_kop.Value = 5
        ethazi_mac_visual.Aldaketak_Ostatuak.RichTextBox1_Kokapena.Text = ""
        ethazi_mac_visual.Aldaketak_Ostatuak.TextBox1_Telefonoa.Text = ""
        ethazi_mac_visual.Aldaketak_Ostatuak.TextBox1_Email.Text = ""
        ethazi_mac_visual.Aldaketak_Ostatuak.TextBox1_Latitudea.Text = ""
        ethazi_mac_visual.Aldaketak_Ostatuak.TextBox1_Longitudea.Text = ""
        ethazi_mac_visual.Aldaketak_Ostatuak.TextBox1_Prezioa.Text = ""


        'Quitar los colores
        ethazi_mac_visual.Aldaketak_Ostatuak.TextBox1_Izena.BackColor = SystemColors.Window
        ethazi_mac_visual.Aldaketak_Ostatuak.RichTextBox1_Deskribapena.BackColor = SystemColors.Window
        ethazi_mac_visual.Aldaketak_Ostatuak.ComboBox1_Ostatu_Mota.BackColor = SystemColors.Window
        ethazi_mac_visual.Aldaketak_Ostatuak.NumericUpDown1_Logela_kop.BackColor = SystemColors.Window
        ethazi_mac_visual.Aldaketak_Ostatuak.RichTextBox1_Kokapena.BackColor = SystemColors.Window
        ethazi_mac_visual.Aldaketak_Ostatuak.TextBox1_Telefonoa.BackColor = SystemColors.Window
        ethazi_mac_visual.Aldaketak_Ostatuak.TextBox1_Email.BackColor = SystemColors.Window
        ethazi_mac_visual.Aldaketak_Ostatuak.TextBox1_Latitudea.BackColor = SystemColors.Window
        ethazi_mac_visual.Aldaketak_Ostatuak.TextBox1_Longitudea.BackColor = SystemColors.Window
        ethazi_mac_visual.Aldaketak_Ostatuak.TextBox1_Prezioa.BackColor = SystemColors.Window


    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            Ostatua = New Ostatua()


            If (e.RowIndex >= 0) Then

                'Dim idString As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                Ostatua.id = CInt(Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString)
                Ostatua.izena = Me.DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                Ostatua.deskribapena = Me.DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                Ostatua.OstatuMota = Me.DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                Ostatua.LogelaKop = CInt(Me.DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString)
                Ostatua.Kokapena = Me.DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
                Ostatua.Telefonoa = Me.DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
                Ostatua.Email = Me.DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
                Ostatua.Latitudea = Me.DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString
                Ostatua.Longitudea = Me.DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString
                Ostatua.Prezioa = CDbl(Me.DataGridView1.Rows(e.RowIndex).Cells(10).Value.ToString)


                ethazi_mac_visual.Aldaketak_Ostatuak.Label1_Id_Ostatu_Insert.Text = Ostatua.id
                ethazi_mac_visual.Aldaketak_Ostatuak.TextBox1_Izena.Text = Ostatua.izena
                ethazi_mac_visual.Aldaketak_Ostatuak.RichTextBox1_Deskribapena.Text = Ostatua.deskribapena
                ethazi_mac_visual.Aldaketak_Ostatuak.ComboBox1_Ostatu_Mota.Text = Ostatua.OstatuMota
                ethazi_mac_visual.Aldaketak_Ostatuak.NumericUpDown1_Logela_kop.Value = Ostatua.LogelaKop
                ethazi_mac_visual.Aldaketak_Ostatuak.RichTextBox1_Kokapena.Text = Ostatua.Kokapena
                ethazi_mac_visual.Aldaketak_Ostatuak.TextBox1_Telefonoa.Text = Ostatua.Telefonoa
                ethazi_mac_visual.Aldaketak_Ostatuak.TextBox1_Email.Text = Ostatua.Email
                ethazi_mac_visual.Aldaketak_Ostatuak.TextBox1_Latitudea.Text = Ostatua.Latitudea
                ethazi_mac_visual.Aldaketak_Ostatuak.TextBox1_Longitudea.Text = Ostatua.Longitudea
                ethazi_mac_visual.Aldaketak_Ostatuak.TextBox1_Prezioa.Text = Ostatua.Prezioa


                ethazi_mac_visual.Aldaketak_Ostatuak.Button1_Gehitu.Visible = False
                ethazi_mac_visual.Aldaketak_Ostatuak.Button1_Aldaketa.Visible = True
                ethazi_mac_visual.Aldaketak_Ostatuak.Button1_Kendu.Visible = True

                'Quitar los colores
                ethazi_mac_visual.Aldaketak_Ostatuak.TextBox1_Izena.BackColor = SystemColors.Window
                ethazi_mac_visual.Aldaketak_Ostatuak.RichTextBox1_Deskribapena.BackColor = SystemColors.Window
                ethazi_mac_visual.Aldaketak_Ostatuak.ComboBox1_Ostatu_Mota.BackColor = SystemColors.Window
                ethazi_mac_visual.Aldaketak_Ostatuak.NumericUpDown1_Logela_kop.BackColor = SystemColors.Window
                ethazi_mac_visual.Aldaketak_Ostatuak.RichTextBox1_Kokapena.BackColor = SystemColors.Window
                ethazi_mac_visual.Aldaketak_Ostatuak.TextBox1_Telefonoa.BackColor = SystemColors.Window
                ethazi_mac_visual.Aldaketak_Ostatuak.TextBox1_Email.BackColor = SystemColors.Window
                ethazi_mac_visual.Aldaketak_Ostatuak.TextBox1_Latitudea.BackColor = SystemColors.Window
                ethazi_mac_visual.Aldaketak_Ostatuak.TextBox1_Longitudea.BackColor = SystemColors.Window
                ethazi_mac_visual.Aldaketak_Ostatuak.TextBox1_Prezioa.BackColor = SystemColors.Window


            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




        'Me.Hide()
        Me.Enabled = False
        Aldaketak_Ostatuak.Show()
    End Sub
End Class