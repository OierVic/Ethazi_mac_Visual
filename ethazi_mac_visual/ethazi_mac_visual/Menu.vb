Public Class Menu
    'Public accionEnviar As String = ""
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Erabiltzaileak_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1_Erabiltzaileak.KeyDown
        'If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.Back Then

        '    'do something here...
        '    Me.Hide()
        '    Dim pasaralLogin As New Login
        '    pasaralLogin.Show()

        'ElseIf e.KeyCode = Keys.Enter Then

        '    'do something here...
        '    Me.Hide()
        '    Dim pasaralErabiltzaileak As New Erabiltzaileak
        '    pasaralErabiltzaileak.Show()

        'End If

        Select Case e.KeyCode
            Case Keys.Escape
                End

            Case Keys.Back
                Me.Hide()
                Login.Show()


            Case Keys.Enter
                Me.Hide()
                Erabiltzaileak.Show()

        End Select

    End Sub
    Private Sub Button1_Ostatuak_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1_Ostatuak.KeyDown

        Select Case e.KeyCode
            Case Keys.Escape
                End
            Case Keys.Back

                Me.Hide()
                Login.Show()
            Case Keys.Enter

                Me.Hide()
                Ostatuak.Show()

        End Select
    End Sub
    Private Sub Button1_Erreserbak_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1_Erreserbak.KeyDown

        Select Case e.KeyCode
            Case Keys.Escape
                End
            Case Keys.Back

                Me.Hide()
                Login.Show()
            Case Keys.Enter

                Me.Hide()
                Erreserbak.Show()
        End Select

    End Sub
    Private Sub Button1_Atzera_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1_Atzera.KeyDown

        Select Case e.KeyCode
            Case Keys.Escape
                End
            Case Keys.Back

                Me.Hide()
                Login.Show()
            Case Keys.Enter
                Me.Hide()
                Login.Show()

        End Select
    End Sub

    Private Sub Button1_Erabiltzaileak_Click(sender As Object, e As EventArgs) Handles Button1_Erabiltzaileak.Click
        'Aldaketak_Erabiltzaileak.ventana = "erabiltzaileak"

        Me.Hide()
        Erabiltzaileak.Show()
    End Sub

    Private Sub Button1_Ostatuak_Click(sender As Object, e As EventArgs) Handles Button1_Ostatuak.Click
        'Aldaketak_Erabiltzaileak.ventana = "ostatuak"

        Me.Hide()
        Ostatuak.Show()
    End Sub
    Private Sub Button1_Erreserbak_Click(sender As Object, e As EventArgs) Handles Button1_Erreserbak.Click
        'Aldaketak_Erabiltzaileak.ventana = "erreserbak"

        Me.Hide()
        Erreserbak.Show()
    End Sub
    Private Sub Button1_Atzera_Click(sender As Object, e As EventArgs) Handles Button1_Atzera.Click
        Me.Hide()
        Login.Show()

        ethazi_mac_visual.Login.TextBox1_User.Text = ""
        ethazi_mac_visual.Login.TextBox1_Password.Text = ""


    End Sub



End Class