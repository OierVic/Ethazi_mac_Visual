Public Class Menu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Atzera_Click(sender As Object, e As EventArgs) Handles Button1_Atzera.Click
        Me.Hide()
        Dim pasaralLogin As New Login
        pasaralLogin.Show()
    End Sub

    Private Sub Button1_Atzera_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1_Atzera.KeyDown
        If e.KeyCode = Keys.Escape Then

            'do something here...
            Me.Hide()
            Dim pasaralLogin As New Login
            pasaralLogin.Show()

        End If
    End Sub
End Class