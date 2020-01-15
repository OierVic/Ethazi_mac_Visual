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
                ComboBox1.Text = "Mota 1 - Altua"
                '7 bloque
                'TextBox1_Izena.Text = ethazi_mac_visual.Erabiltzaileak.erabiltzailea.IzenAbizenak.ToString


            Case "ostatuak"
                Label1_Titulua.Text = "Ostatuak"


            Case "erreserbak"
                Label1_Titulua.Text = "Erreserbak"


        End Select
    End Sub

    Private Sub Button1_Gehitu_Click(sender As Object, e As EventArgs) Handles Button1_Gehitu.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button1_Kendu_Click(sender As Object, e As EventArgs) Handles Button1_Kendu.Click

    End Sub

    Private Sub Button1_Atzera_Click(sender As Object, e As EventArgs) Handles Button1_Atzera.Click
        Me.Hide()
        ethazi_mac_visual.Erabiltzaileak.Show()
    End Sub

End Class