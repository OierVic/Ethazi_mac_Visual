﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Erabiltzaileak
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1_Administrazio_Aplikazioa = New System.Windows.Forms.Label()
        Me.Button1_Atzera = New System.Windows.Forms.Button()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.erabiltzaile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pasahitza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefonoa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Erabiltzaile_mota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IzenAbizenak = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1_IdBuscar = New System.Windows.Forms.Label()
        Me.TextBox1_IdBuscar = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.erabiltzaile, Me.pasahitza, Me.mail, Me.telefonoa, Me.Erabiltzaile_mota, Me.IzenAbizenak})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1069, 495)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1_Administrazio_Aplikazioa
        '
        Me.Label1_Administrazio_Aplikazioa.AutoSize = True
        Me.Label1_Administrazio_Aplikazioa.BackColor = System.Drawing.Color.White
        Me.Label1_Administrazio_Aplikazioa.Font = New System.Drawing.Font("Segoe UI Black", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Administrazio_Aplikazioa.Location = New System.Drawing.Point(780, 6)
        Me.Label1_Administrazio_Aplikazioa.Name = "Label1_Administrazio_Aplikazioa"
        Me.Label1_Administrazio_Aplikazioa.Size = New System.Drawing.Size(260, 28)
        Me.Label1_Administrazio_Aplikazioa.TabIndex = 9
        Me.Label1_Administrazio_Aplikazioa.Text = "Administrazio Aplikazioa"
        '
        'Button1_Atzera
        '
        Me.Button1_Atzera.BackgroundImage = Global.ethazi_mac_visual.My.Resources.Resources.return_logo_SinFondo
        Me.Button1_Atzera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1_Atzera.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1_Atzera.Location = New System.Drawing.Point(65, 553)
        Me.Button1_Atzera.Name = "Button1_Atzera"
        Me.Button1_Atzera.Size = New System.Drawing.Size(64, 58)
        Me.Button1_Atzera.TabIndex = 1
        Me.Button1_Atzera.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1_Atzera.UseVisualStyleBackColor = True
        '
        'ID
        '
        Me.ID.Frozen = True
        Me.ID.HeaderText = "ID erabiltzaile"
        Me.ID.Name = "ID"
        Me.ID.Width = 50
        '
        'erabiltzaile
        '
        Me.erabiltzaile.Frozen = True
        Me.erabiltzaile.HeaderText = "Erabiltzailea"
        Me.erabiltzaile.Name = "erabiltzaile"
        Me.erabiltzaile.Width = 150
        '
        'pasahitza
        '
        Me.pasahitza.Frozen = True
        Me.pasahitza.HeaderText = "pasahitza"
        Me.pasahitza.Name = "pasahitza"
        Me.pasahitza.Width = 250
        '
        'mail
        '
        Me.mail.HeaderText = "Emaila"
        Me.mail.Name = "mail"
        Me.mail.Width = 200
        '
        'telefonoa
        '
        Me.telefonoa.HeaderText = "telefonoa"
        Me.telefonoa.Name = "telefonoa"
        '
        'Erabiltzaile_mota
        '
        Me.Erabiltzaile_mota.HeaderText = "Erabiltzaile Mota"
        Me.Erabiltzaile_mota.Name = "Erabiltzaile_mota"
        '
        'IzenAbizenak
        '
        Me.IzenAbizenak.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IzenAbizenak.HeaderText = "Izena eta Abizenak"
        Me.IzenAbizenak.Name = "IzenAbizenak"
        '
        'Label1_IdBuscar
        '
        Me.Label1_IdBuscar.AutoSize = True
        Me.Label1_IdBuscar.Location = New System.Drawing.Point(41, 13)
        Me.Label1_IdBuscar.Name = "Label1_IdBuscar"
        Me.Label1_IdBuscar.Size = New System.Drawing.Size(24, 13)
        Me.Label1_IdBuscar.TabIndex = 10
        Me.Label1_IdBuscar.Text = "ID :"
        '
        'TextBox1_IdBuscar
        '
        Me.TextBox1_IdBuscar.Location = New System.Drawing.Point(91, 13)
        Me.TextBox1_IdBuscar.Name = "TextBox1_IdBuscar"
        Me.TextBox1_IdBuscar.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1_IdBuscar.TabIndex = 11
        '
        'Erabiltzaileak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1093, 623)
        Me.Controls.Add(Me.TextBox1_IdBuscar)
        Me.Controls.Add(Me.Label1_IdBuscar)
        Me.Controls.Add(Me.Label1_Administrazio_Aplikazioa)
        Me.Controls.Add(Me.Button1_Atzera)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Erabiltzaileak"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1_Atzera As Button
    Friend WithEvents Label1_Administrazio_Aplikazioa As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents erabiltzaile As DataGridViewTextBoxColumn
    Friend WithEvents pasahitza As DataGridViewTextBoxColumn
    Friend WithEvents mail As DataGridViewTextBoxColumn
    Friend WithEvents telefonoa As DataGridViewTextBoxColumn
    Friend WithEvents Erabiltzaile_mota As DataGridViewTextBoxColumn
    Friend WithEvents IzenAbizenak As DataGridViewTextBoxColumn
    Friend WithEvents Label1_IdBuscar As Label
    Friend WithEvents TextBox1_IdBuscar As TextBox
End Class
