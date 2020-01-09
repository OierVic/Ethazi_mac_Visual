Public Class Menu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Erabiltzaileak_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1_Erabiltzaileak.KeyDown
        If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.Back Then

            'do something here...
            Me.Hide()
            Dim pasaralLogin As New Login
            pasaralLogin.Show()

        End If
    End Sub
    Private Sub Button1_Ostatuak_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1_Ostatuak.KeyDown
        If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.Back Then

            'do something here...
            Me.Hide()
            Dim pasaralLogin As New Login
            pasaralLogin.Show()

        End If
    End Sub
    Private Sub Button1_Atzera_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1_Atzera.KeyDown
        If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.Back Then

            'do something here...
            Me.Hide()
            Dim pasaralLogin As New Login
            pasaralLogin.Show()

        End If
    End Sub

    Private Sub Button1_Erabiltzaileak_Click(sender As Object, e As EventArgs) Handles Button1_Erabiltzaileak.Click

    End Sub

    Private Sub Button1_Ostatuak_Click(sender As Object, e As EventArgs) Handles Button1_Ostatuak.Click

    End Sub
    Private Sub Button1_Atzera_Click(sender As Object, e As EventArgs) Handles Button1_Atzera.Click
        Me.Hide()
        Dim pasaralLogin As New Login
        pasaralLogin.Show()
    End Sub

End Class