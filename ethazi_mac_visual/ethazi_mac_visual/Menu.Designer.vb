﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.Button1_Ostatuak = New System.Windows.Forms.Button()
        Me.Button1_Erabiltzaileak = New System.Windows.Forms.Button()
        Me.Button1_Atzera = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1_Ostatuak
        '
        Me.Button1_Ostatuak.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1_Ostatuak.Location = New System.Drawing.Point(438, 251)
        Me.Button1_Ostatuak.Name = "Button1_Ostatuak"
        Me.Button1_Ostatuak.Size = New System.Drawing.Size(253, 73)
        Me.Button1_Ostatuak.TabIndex = 0
        Me.Button1_Ostatuak.Text = "Ostatuak"
        Me.Button1_Ostatuak.UseVisualStyleBackColor = True
        '
        'Button1_Erabiltzaileak
        '
        Me.Button1_Erabiltzaileak.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1_Erabiltzaileak.Location = New System.Drawing.Point(438, 56)
        Me.Button1_Erabiltzaileak.Name = "Button1_Erabiltzaileak"
        Me.Button1_Erabiltzaileak.Size = New System.Drawing.Size(253, 71)
        Me.Button1_Erabiltzaileak.TabIndex = 1
        Me.Button1_Erabiltzaileak.Text = "Erabiltzaileak"
        Me.Button1_Erabiltzaileak.UseVisualStyleBackColor = True
        '
        'Button1_Atzera
        '
        Me.Button1_Atzera.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1_Atzera.Location = New System.Drawing.Point(438, 427)
        Me.Button1_Atzera.Name = "Button1_Atzera"
        Me.Button1_Atzera.Size = New System.Drawing.Size(253, 61)
        Me.Button1_Atzera.TabIndex = 2
        Me.Button1_Atzera.Text = "Atzera"
        Me.Button1_Atzera.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1093, 623)
        Me.Controls.Add(Me.Button1_Atzera)
        Me.Controls.Add(Me.Button1_Erabiltzaileak)
        Me.Controls.Add(Me.Button1_Ostatuak)
        Me.Name = "Menu"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1_Ostatuak As Button
    Friend WithEvents Button1_Erabiltzaileak As Button
    Friend WithEvents Button1_Atzera As Button
End Class