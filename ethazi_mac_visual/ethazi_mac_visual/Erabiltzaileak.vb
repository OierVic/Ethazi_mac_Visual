Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class Erabiltzaileak
    Dim dataset As DataSet
    Dim adaptador As MySqlDataAdapter
    'Dim conexionBD As New MySqlConnection("server=127.0.0.1 ; userid=root ; password = ; database=ethazi_mac")
    'Dim dt As DataTable
    Public erabiltzailea As Erabiltzaile

    Private Sub Erabiltzaileak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim conexionBD As New MySqlConnection("server=127.0.0.1 ; userid=root ; password = ; database=ethazi_mac")
        'dataset = New DataSet

        'Dim command As MySqlCommand

        'Try
        '    conexionBD.Open()
        '    command = New MySqlCommand("Select * from erabiltzaile", conexionBD)
        '    adaptador = New MySqlDataAdapter(command)
        '    Dim cmb As New MySqlCommandBuilder(adaptador)

        '    dataset.Clear()
        '    adaptador.Fill(dataset, "command")

        '    'DataGridView1.DataSource = dataset.Tables("command")
        '    DataGridView1.Rows.Add("Hola", "Que tal")
        '    DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    conexionBD.Close()
        'Finally
        '    If conexionBD.State = ConnectionState.Open Then conexionBD.Close()
        'End Try


        'Dim SQL As String = "SELECT * FROM erabiltzaile"
        Dim cmd1 As New MySqlCommand("SELECT * FROM erabiltzaile", Login.conexionBD)
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
        DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Aqua
        'DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black

        'DataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty

        'DataGridView1.RowsDefaultCellStyle.BackColor = Color.LightGray
        'DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray

        'DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        'DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black
        'DataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.Black

        While dr.Read

            Try
                DataGridView1.Rows.Add(dr.Item(0), dr.Item(1), dr.Item(2), dr.Item(3), dr.Item(4), dr.Item(5), dr.Item(6))
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
                'Me.Hide()
                'Dim pasaralMenu As New Menu
                'pasaralMenu.Show()

                Me.Hide()
                ethazi_mac_visual.Menu.Show()
        End Select

    End Sub

    Private Sub Button1_Atzera_Click(sender As Object, e As EventArgs) Handles Button1_Atzera.Click
        'Me.Hide()
        'Dim pasaralMenu As New Menu
        'pasaralMenu.Show()

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

    Private Sub TextBox1_IdBuscar_TextChanged(sender As Object, e As EventArgs)
        'consultaDinamica(TextBox1_IdBuscar.Text, DataGridView1)
    End Sub

    Private Sub Button1_Gehitu_Click(sender As Object, e As EventArgs) Handles Button1_Gehitu.Click

        'Me.Hide()
        Me.Enabled = False
        Aldaketak_Erabiltzaileak.Show()
        ethazi_mac_visual.Aldaketak_Erabiltzaileak.Button1_Gehitu.Visible = True
        ethazi_mac_visual.Aldaketak_Erabiltzaileak.Button1_Aldaketa.Visible = False
        ethazi_mac_visual.Aldaketak_Erabiltzaileak.Button1_Kendu.Visible = False


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

        'Añadir un id nuevo sumando el maximo del ultimo

        MaxCount = MaxCount + 1

        ethazi_mac_visual.Aldaketak_Erabiltzaileak.Label1_Id_Insert.Text = MaxCount.ToString


        'Vaciar TextBox
        ethazi_mac_visual.Aldaketak_Erabiltzaileak.TextBox1_Erabiltzailea.Text = ""
        ethazi_mac_visual.Aldaketak_Erabiltzaileak.TextBox1_Pasahitza.Text = ""
        ethazi_mac_visual.Aldaketak_Erabiltzaileak.TextBox1_Emaila.Text = ""
        ethazi_mac_visual.Aldaketak_Erabiltzaileak.TextBox1_Telefonoa.Text = ""
        ethazi_mac_visual.Aldaketak_Erabiltzaileak.ComboBox1_ErabiltzaileMota.Text = "Mota 0 - Super Administratzailea"
        ethazi_mac_visual.Aldaketak_Erabiltzaileak.TextBox1_IzenaAbizenak.Text = ""


        'Quitar los colores
        ethazi_mac_visual.Aldaketak_Erabiltzaileak.TextBox1_Erabiltzailea.BackColor = SystemColors.Window
        ethazi_mac_visual.Aldaketak_Erabiltzaileak.TextBox1_Pasahitza.BackColor = SystemColors.Window
        ethazi_mac_visual.Aldaketak_Erabiltzaileak.TextBox1_Emaila.BackColor = SystemColors.Window
        ethazi_mac_visual.Aldaketak_Erabiltzaileak.TextBox1_Telefonoa.BackColor = SystemColors.Window
        ethazi_mac_visual.Aldaketak_Erabiltzaileak.ComboBox1_ErabiltzaileMota.BackColor = SystemColors.Window
        ethazi_mac_visual.Aldaketak_Erabiltzaileak.TextBox1_IzenaAbizenak.BackColor = SystemColors.Window


    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            erabiltzailea = New Erabiltzaile()

            'Dim id As Integer = CType(DataGridView1.Item(1, e.RowIndex).Value, Integer)
            'ethazi_mac_visual.Aldaketak.erabiltzaile.id = DataGridView1.CurrentRow.Cells(e.RowIndex).Value

            'Dim value As String = DataGridView1.Rows[DataGridView.SelectedRows[0].Index].Cells[X].Value.ToString()
            'ethazi_mac_visual.Aldaketak.erabiltzaile.id = CInt(DataGridView1.Rows[DataGridView.SelectedRows[0].Index].Cells[X].Value.ToString())

            'ethazi_mac_visual.Aldaketak.erabiltzaile.id = DataGridView1.Rows[e.RowIndex].Cells[0].Value.toString
            'ethazi_mac_visual.Aldaketak.erabiltzaile.id = DataGridView1.CurrentRow.Cells(e.RowIndex).Value

            If (e.RowIndex >= 0) Then
                'MsgBox(DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString & "-" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "-" & DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString & "-" & DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString & "-" & DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString & "-" & DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString & "-" & DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString)

                Dim idString As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                erabiltzailea.id = CInt(idString)
                erabiltzailea.erabiltzaile = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                erabiltzailea.pasahitza = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                erabiltzailea.emaila = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                erabiltzailea.telefonoa = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                erabiltzailea.ErabiltzaileMota = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
                erabiltzailea.IzenAbizenak = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString

                ethazi_mac_visual.Aldaketak_Erabiltzaileak.Label1_Id_Insert.Text = erabiltzailea.id
                ethazi_mac_visual.Aldaketak_Erabiltzaileak.TextBox1_Erabiltzailea.Text = erabiltzailea.erabiltzaile
                ethazi_mac_visual.Aldaketak_Erabiltzaileak.TextBox1_Pasahitza.Text = erabiltzailea.pasahitza
                ethazi_mac_visual.Aldaketak_Erabiltzaileak.TextBox1_Emaila.Text = erabiltzailea.emaila
                ethazi_mac_visual.Aldaketak_Erabiltzaileak.TextBox1_Telefonoa.Text = erabiltzailea.telefonoa
                ethazi_mac_visual.Aldaketak_Erabiltzaileak.TextBox1_IzenaAbizenak.Text = erabiltzailea.IzenAbizenak

                ethazi_mac_visual.Aldaketak_Erabiltzaileak.Button1_Gehitu.Visible = False
                ethazi_mac_visual.Aldaketak_Erabiltzaileak.Button1_Aldaketa.Visible = True
                ethazi_mac_visual.Aldaketak_Erabiltzaileak.Button1_Kendu.Visible = True

                'Quitar los colores
                ethazi_mac_visual.Aldaketak_Erabiltzaileak.TextBox1_Erabiltzailea.BackColor = SystemColors.Window
                ethazi_mac_visual.Aldaketak_Erabiltzaileak.TextBox1_Pasahitza.BackColor = SystemColors.Window
                ethazi_mac_visual.Aldaketak_Erabiltzaileak.TextBox1_Emaila.BackColor = SystemColors.Window
                ethazi_mac_visual.Aldaketak_Erabiltzaileak.TextBox1_Telefonoa.BackColor = SystemColors.Window
                ethazi_mac_visual.Aldaketak_Erabiltzaileak.ComboBox1_ErabiltzaileMota.BackColor = SystemColors.Window
                ethazi_mac_visual.Aldaketak_Erabiltzaileak.TextBox1_IzenaAbizenak.BackColor = SystemColors.Window


            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




        'Me.Hide()
        Me.Enabled = False
        Aldaketak_Erabiltzaileak.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub dgvFill()

        'TextBox1_Buscar.BackColor = Color.LightBlue

        'If DataGridView1.DataSource Is Nothing Then
        '    Exit Sub
        'End If


        'Dim myDGV1 As DataGridView = DataGridView1
        'With myDGV1
        '    .RowsDefaultCellStyle.BackColor = Color.FromName(cboDfColor.SelectedItem)
        '    .AlternatingRowsDefaultCellStyle.BackColor = Color.FromName(cboAltColor.SelectedItem)
        'End With

    End Sub
    Private Sub notFound()

        'Dim txtS As TextBox = TextBox1_Buscar
        'With txtS
        '    .BackColor = Color.White
        '    .Select()
        '    .SelectAll()
        'End With

        'If DataGridView1.DataSource Is Nothing Then
        '    Exit Sub
        'End If


        'Dim dgv As DataGridView = DataGridView1
        'With dgv
        '    .RowsDefaultCellStyle.BackColor = Color.White
        '    .AlternatingRowsDefaultCellStyle.BackColor = Color.White
        'End With
    End Sub
    Private Sub Button1_Buscar_Click(sender As Object, e As EventArgs)
        '        On Error GoTo SearchErr

        '        If TextBox1_Buscar.Text = "" Then
        '            Call notFound()
        '            Exit Sub

        '        Else

        '            Dim cantFind As String = TextBox1_Buscar.Text
        '            Me.dgvFill()

        '            Table1BindingSource1.Filter = "(Convert(ID erabiltzaile, 'System.String') LIKE '" & TextBox1_Buscar.Text & "')" &
        '                "OR (erabiltzaile LIKE '" & TextBox1_Buscar.Text & "') OR (Lastname LIKE '" & TextBox1_Buscar.Text & "')" &
        '                "OR (Phone LIKE '" & TextBox1_Buscar.Text & "') OR (Email LIKE '" & TextBox1_Buscar.Text & "')" &
        '                "OR (Facebook LIKE '" & TextBox1_Buscar.Text & "')"

        '            If Table1BindingSource1.Count <> 0 Then
        '                With DataGridView1
        '                    .DataSource = Table1BindingSource1
        '                End With

        '            Else

        '                Me.notFound()

        '                MsgBox("--> " & cantFind & vbNewLine &
        '                       "The search item was not found.",
        '                       MsgBoxStyle.Information, "Hey Boss!")

        '                Table1BindingSource1.Filter = Nothing

        '                With DataGridView1
        '                    .ClearSelection()
        '                    .ReadOnly = True
        '                    .MultiSelect = False
        '                    .DataSource = Table1BindingSource1
        '                End With

        '            End If

        '        End If

        'ErrExit:
        '        Exit Sub
        'SearchErr:
        '        MsgBox("Error Number " & Err.Number & vbNewLine &
        '               "Error Description " & Err.Description, MsgBoxStyle.Critical,
        '               "Reset Error!")
        '        Resume ErrExit

    End Sub

    'Private Sub Button1_Aldatu_Click(sender As Object, e As EventArgs)
    '    ethazi_mac_visual.Menu.accionEnviar = "erabiltzailea aldatu"
    '    Me.Hide()
    '    Aldaketak.Show()
    'End Sub

    'Private Sub Button1_Kendu_Click(sender As Object, e As EventArgs)
    '    ethazi_mac_visual.Menu.accionEnviar = "erabiltzailea kendu"
    '    Me.Hide()
    '    Aldaketak.Show()
    'End Sub


    'Sub consultaDinamica(ByVal id As String, ByVal dgv As DataGridView)
    '    adaptador = New MySqlDataAdapter("Select * from erabiltzaile where id like " & id + "%", conexionBD)
    '    dt = New DataTable
    '    adaptador.Fill(dt)
    '    dgv.DataSource = dt


    'End Sub

End Class