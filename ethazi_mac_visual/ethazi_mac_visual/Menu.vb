﻿Public Class Menu
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
                Dim pasaralLogin As New Login
                pasaralLogin.Show()
            Case Keys.Enter
                Me.Hide()
                Dim pasaralErabiltzaileak As New Erabiltzaileak
                pasaralErabiltzaileak.Show()
        End Select

    End Sub
    Private Sub Button1_Ostatuak_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1_Ostatuak.KeyDown

        Select Case e.KeyCode
            Case Keys.Escape
                End
            Case Keys.Back
                Me.Hide()
                Dim pasaralLogin As New Login
                pasaralLogin.Show()
            Case Keys.Enter




        End Select
    End Sub
    Private Sub Button1_Atzera_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1_Atzera.KeyDown

        Select Case e.KeyCode
            Case Keys.Escape
                End
            Case Keys.Back
                Me.Hide()
                Dim pasaralLogin As New Login
                pasaralLogin.Show()
            Case Keys.Enter

                Me.Hide()
                Dim pasaralLogin As New Login
                pasaralLogin.Show()


        End Select
    End Sub

    Private Sub Button1_Erabiltzaileak_Click(sender As Object, e As EventArgs) Handles Button1_Erabiltzaileak.Click
        Me.Hide()
        Dim pasaralErabiltzaileak As New Erabiltzaileak
        pasaralErabiltzaileak.Show()
    End Sub

    Private Sub Button1_Ostatuak_Click(sender As Object, e As EventArgs) Handles Button1_Ostatuak.Click

    End Sub
    Private Sub Button1_Atzera_Click(sender As Object, e As EventArgs) Handles Button1_Atzera.Click
        Me.Hide()
        Dim pasaralLogin As New Login
        pasaralLogin.Show()
    End Sub

    Private Sub Label1_Administrazio_Aplikazioa_Click(sender As Object, e As EventArgs) Handles Label1_Administrazio_Aplikazioa.Click

    End Sub
End Class