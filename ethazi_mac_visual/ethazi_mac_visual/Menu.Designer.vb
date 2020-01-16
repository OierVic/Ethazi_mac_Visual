<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.Button1_Ostatuak = New System.Windows.Forms.Button()
        Me.Button1_Erabiltzaileak = New System.Windows.Forms.Button()
        Me.Button1_Atzera = New System.Windows.Forms.Button()
        Me.Label1_Administrazio_Aplikazioa = New System.Windows.Forms.Label()
        Me.Button1_Erreserbak = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1_Ostatuak
        '
        Me.Button1_Ostatuak.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1_Ostatuak.Location = New System.Drawing.Point(438, 194)
        Me.Button1_Ostatuak.Name = "Button1_Ostatuak"
        Me.Button1_Ostatuak.Size = New System.Drawing.Size(253, 73)
        Me.Button1_Ostatuak.TabIndex = 0
        Me.Button1_Ostatuak.Text = "Ostatuak"
        Me.Button1_Ostatuak.UseVisualStyleBackColor = True
        '
        'Button1_Erabiltzaileak
        '
        Me.Button1_Erabiltzaileak.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1_Erabiltzaileak.Location = New System.Drawing.Point(438, 63)
        Me.Button1_Erabiltzaileak.Name = "Button1_Erabiltzaileak"
        Me.Button1_Erabiltzaileak.Size = New System.Drawing.Size(253, 71)
        Me.Button1_Erabiltzaileak.TabIndex = 1
        Me.Button1_Erabiltzaileak.Text = "Erabiltzaileak"
        Me.Button1_Erabiltzaileak.UseVisualStyleBackColor = True
        '
        'Button1_Atzera
        '
        Me.Button1_Atzera.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1_Atzera.Location = New System.Drawing.Point(438, 441)
        Me.Button1_Atzera.Name = "Button1_Atzera"
        Me.Button1_Atzera.Size = New System.Drawing.Size(253, 69)
        Me.Button1_Atzera.TabIndex = 2
        Me.Button1_Atzera.Text = "Atzera"
        Me.Button1_Atzera.UseVisualStyleBackColor = True
        '
        'Label1_Administrazio_Aplikazioa
        '
        Me.Label1_Administrazio_Aplikazioa.AutoSize = True
        Me.Label1_Administrazio_Aplikazioa.BackColor = System.Drawing.Color.White
        Me.Label1_Administrazio_Aplikazioa.Font = New System.Drawing.Font("Segoe UI Black", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Administrazio_Aplikazioa.Location = New System.Drawing.Point(28, 22)
        Me.Label1_Administrazio_Aplikazioa.Name = "Label1_Administrazio_Aplikazioa"
        Me.Label1_Administrazio_Aplikazioa.Size = New System.Drawing.Size(349, 37)
        Me.Label1_Administrazio_Aplikazioa.TabIndex = 9
        Me.Label1_Administrazio_Aplikazioa.Text = "Administrazio Aplikazioa"
        '
        'Button1_Erreserbak
        '
        Me.Button1_Erreserbak.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1_Erreserbak.Location = New System.Drawing.Point(438, 320)
        Me.Button1_Erreserbak.Name = "Button1_Erreserbak"
        Me.Button1_Erreserbak.Size = New System.Drawing.Size(253, 75)
        Me.Button1_Erreserbak.TabIndex = 10
        Me.Button1_Erreserbak.Text = "Erreserbak"
        Me.Button1_Erreserbak.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.ethazi_mac_visual.My.Resources.Resources.Imagen_fondo2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1093, 623)
        Me.Controls.Add(Me.Button1_Erreserbak)
        Me.Controls.Add(Me.Label1_Administrazio_Aplikazioa)
        Me.Controls.Add(Me.Button1_Atzera)
        Me.Controls.Add(Me.Button1_Erabiltzaileak)
        Me.Controls.Add(Me.Button1_Ostatuak)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1_Ostatuak As Button
    Friend WithEvents Button1_Erabiltzaileak As Button
    Friend WithEvents Button1_Atzera As Button
    Friend WithEvents Label1_Administrazio_Aplikazioa As Label
    Friend WithEvents Button1_Erreserbak As Button
End Class
