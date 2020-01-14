Public Class Aldaketak
    Public ventana As String

    'Erabiltzaileak
    Public erabiltzaile As Erabiltzaile = New Erabiltzaile()
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


        '        MsgBox("erabiltzailea kendu")


        'End Select

        Select Case ventana
            Case "erabiltzaileak"

                Label1_Titulua.Text = "Erabiltzailea"
                TextBox1_Id.Text = erabiltzaile.id


            Case "ostatuak"
                Label1_Titulua.Text = "Ostatuak"


            Case "erreserbak"
                Label1_Titulua.Text = "Erreserbak"


        End Select
    End Sub
End Class