﻿Public Class Aldaketak_Ostatuak
    Private Sub Aldaketak_Ostatuak_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Atzera_Click(sender As Object, e As EventArgs) Handles Button1_Atzera.Click



        'Vaciar TextBox
        Me.TextBox1_Izena.Text = ""
        Me.RichTextBox1_Deskribapena.Text = ""
        Me.ComboBox1_Ostatu_Mota.Text = "Campings"
        Me.NumericUpDown1_Logela_kop.Value = 5
        Me.RichTextBox1_Kokapena.Text = ""
        Me.TextBox1_Telefonoa.Text = ""
        Me.TextBox1_Email.Text = ""
        Me.TextBox1_Latitudea.Text = ""
        Me.TextBox1_Longitudea.Text = ""

        'Quitar los colores
        Me.TextBox1_Izena.BackColor = SystemColors.Window
        Me.RichTextBox1_Deskribapena.BackColor = SystemColors.Window
        Me.ComboBox1_Ostatu_Mota.BackColor = SystemColors.Window
        Me.NumericUpDown1_Logela_kop.BackColor = SystemColors.Window
        Me.RichTextBox1_Kokapena.BackColor = SystemColors.Window
        Me.TextBox1_Telefonoa.BackColor = SystemColors.Window
        Me.TextBox1_Email.BackColor = SystemColors.Window
        Me.TextBox1_Latitudea.BackColor = SystemColors.Window
        Me.TextBox1_Longitudea.BackColor = SystemColors.Window

    End Sub
End Class