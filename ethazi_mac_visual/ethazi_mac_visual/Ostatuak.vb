Imports MySql.Data.MySqlClient

Public Class Ostatuak
    Private Sub Ostatuak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexionBD As New MySqlConnection("server=127.0.0.1 ; userid=root ; password = ; database=ethazi_mac")

        Dim SQL As String = "SELECT * FROM ostatu"
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

        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

        'Color que se selecciona
        DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Green

        While dr.Read

            Try
                DataGridView1.Rows.Add(dr.Item(0), dr.Item(1), dr.Item(2), dr.Item(3), dr.Item(4), dr.Item(5), dr.Item(6), dr.Item(7), dr.Item(8), dr.Item(9))
                DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
            Catch ex As Exception
                MsgBox("Datu baseko datuak gehiago edo gutxiago dira edo basu basea ez da zuzena")
            End Try


        End While

        If conexionBD.State = ConnectionState.Open Then
            dr.Close()
            conexionBD.Close()
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Atzera_Click(sender As Object, e As EventArgs) Handles Button1_Atzera.Click
        Me.Hide()
        Dim pasaralMenu As New Menu
        pasaralMenu.Show()
    End Sub
End Class