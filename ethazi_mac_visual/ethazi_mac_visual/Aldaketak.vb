Public Class Aldaketak
    Private accion As String
    Private Sub Aldaketak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accion = ethazi_mac_visual.Menu.accionEnviar
        Select Case accion
            Case "erabiltzailea gehitu"


                MsgBox("erabiltzailea gehitu")

            Case "erabiltzailea aldatu"


                MsgBox("erabiltzailea aldatu")

            Case "erabiltzailea kendu"


                MsgBox("erabiltzailea kendu")


        End Select
    End Sub
End Class