<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aldaketak_Erreserbak
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Aldaketak_Erreserbak))
        Me.Label1_Tituloa = New System.Windows.Forms.Label()
        Me.Label1_Id_Erreserba = New System.Windows.Forms.Label()
        Me.Label1_Id_Erreserba_Insert = New System.Windows.Forms.Label()
        Me.Label1_ID_Ostatu = New System.Windows.Forms.Label()
        Me.TextBox1_ID_Ostatu = New System.Windows.Forms.TextBox()
        Me.Label1_ID_Erabiltzaile = New System.Windows.Forms.Label()
        Me.TextBox1_ID_Erabiltzaile = New System.Windows.Forms.TextBox()
        Me.Label1_Hasiera_Data = New System.Windows.Forms.Label()
        Me.Label1_Amaiera_Data = New System.Windows.Forms.Label()
        Me.DateTimePicker1_Hasiera_Data = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1_Amaiera_Data = New System.Windows.Forms.DateTimePicker()
        Me.Button1_Kendu = New System.Windows.Forms.Button()
        Me.Button1_Aldaketa = New System.Windows.Forms.Button()
        Me.Button1_Gehitu = New System.Windows.Forms.Button()
        Me.Button1_Atzera = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1_Tituloa
        '
        Me.Label1_Tituloa.AutoSize = True
        Me.Label1_Tituloa.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Tituloa.Location = New System.Drawing.Point(320, 25)
        Me.Label1_Tituloa.Name = "Label1_Tituloa"
        Me.Label1_Tituloa.Size = New System.Drawing.Size(160, 46)
        Me.Label1_Tituloa.TabIndex = 0
        Me.Label1_Tituloa.Text = "Erreserba"
        '
        'Label1_Id_Erreserba
        '
        Me.Label1_Id_Erreserba.AutoSize = True
        Me.Label1_Id_Erreserba.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Id_Erreserba.Location = New System.Drawing.Point(26, 95)
        Me.Label1_Id_Erreserba.Name = "Label1_Id_Erreserba"
        Me.Label1_Id_Erreserba.Size = New System.Drawing.Size(108, 20)
        Me.Label1_Id_Erreserba.TabIndex = 1
        Me.Label1_Id_Erreserba.Text = "ID Erreserba :"
        '
        'Label1_Id_Erreserba_Insert
        '
        Me.Label1_Id_Erreserba_Insert.AutoSize = True
        Me.Label1_Id_Erreserba_Insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Id_Erreserba_Insert.ForeColor = System.Drawing.Color.Blue
        Me.Label1_Id_Erreserba_Insert.Location = New System.Drawing.Point(140, 91)
        Me.Label1_Id_Erreserba_Insert.Name = "Label1_Id_Erreserba_Insert"
        Me.Label1_Id_Erreserba_Insert.Size = New System.Drawing.Size(42, 25)
        Me.Label1_Id_Erreserba_Insert.TabIndex = 2
        Me.Label1_Id_Erreserba_Insert.Text = "null"
        '
        'Label1_ID_Ostatu
        '
        Me.Label1_ID_Ostatu.AutoSize = True
        Me.Label1_ID_Ostatu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_ID_Ostatu.Location = New System.Drawing.Point(247, 99)
        Me.Label1_ID_Ostatu.Name = "Label1_ID_Ostatu"
        Me.Label1_ID_Ostatu.Size = New System.Drawing.Size(86, 20)
        Me.Label1_ID_Ostatu.TabIndex = 3
        Me.Label1_ID_Ostatu.Text = "ID Ostatu :"
        '
        'TextBox1_ID_Ostatu
        '
        Me.TextBox1_ID_Ostatu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_ID_Ostatu.Location = New System.Drawing.Point(354, 96)
        Me.TextBox1_ID_Ostatu.MaxLength = 10
        Me.TextBox1_ID_Ostatu.Name = "TextBox1_ID_Ostatu"
        Me.TextBox1_ID_Ostatu.Size = New System.Drawing.Size(81, 26)
        Me.TextBox1_ID_Ostatu.TabIndex = 4
        '
        'Label1_ID_Erabiltzaile
        '
        Me.Label1_ID_Erabiltzaile.AutoSize = True
        Me.Label1_ID_Erabiltzaile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_ID_Erabiltzaile.Location = New System.Drawing.Point(471, 96)
        Me.Label1_ID_Erabiltzaile.Name = "Label1_ID_Erabiltzaile"
        Me.Label1_ID_Erabiltzaile.Size = New System.Drawing.Size(115, 20)
        Me.Label1_ID_Erabiltzaile.TabIndex = 5
        Me.Label1_ID_Erabiltzaile.Text = "ID Erabiltzaile :"
        '
        'TextBox1_ID_Erabiltzaile
        '
        Me.TextBox1_ID_Erabiltzaile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_ID_Erabiltzaile.Location = New System.Drawing.Point(592, 95)
        Me.TextBox1_ID_Erabiltzaile.Name = "TextBox1_ID_Erabiltzaile"
        Me.TextBox1_ID_Erabiltzaile.Size = New System.Drawing.Size(186, 26)
        Me.TextBox1_ID_Erabiltzaile.TabIndex = 6
        '
        'Label1_Hasiera_Data
        '
        Me.Label1_Hasiera_Data.AutoSize = True
        Me.Label1_Hasiera_Data.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Hasiera_Data.Location = New System.Drawing.Point(12, 176)
        Me.Label1_Hasiera_Data.Name = "Label1_Hasiera_Data"
        Me.Label1_Hasiera_Data.Size = New System.Drawing.Size(111, 20)
        Me.Label1_Hasiera_Data.TabIndex = 9
        Me.Label1_Hasiera_Data.Text = "Hasiera Data :"
        '
        'Label1_Amaiera_Data
        '
        Me.Label1_Amaiera_Data.AutoSize = True
        Me.Label1_Amaiera_Data.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Amaiera_Data.Location = New System.Drawing.Point(400, 177)
        Me.Label1_Amaiera_Data.Name = "Label1_Amaiera_Data"
        Me.Label1_Amaiera_Data.Size = New System.Drawing.Size(115, 20)
        Me.Label1_Amaiera_Data.TabIndex = 10
        Me.Label1_Amaiera_Data.Text = "Amaiera Data :"
        '
        'DateTimePicker1_Hasiera_Data
        '
        Me.DateTimePicker1_Hasiera_Data.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1_Hasiera_Data.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.DateTimePicker1_Hasiera_Data.CalendarTitleForeColor = System.Drawing.SystemColors.Highlight
        Me.DateTimePicker1_Hasiera_Data.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1_Hasiera_Data.Location = New System.Drawing.Point(129, 176)
        Me.DateTimePicker1_Hasiera_Data.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1_Hasiera_Data.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1_Hasiera_Data.Name = "DateTimePicker1_Hasiera_Data"
        Me.DateTimePicker1_Hasiera_Data.Size = New System.Drawing.Size(265, 23)
        Me.DateTimePicker1_Hasiera_Data.TabIndex = 24
        '
        'DateTimePicker1_Amaiera_Data
        '
        Me.DateTimePicker1_Amaiera_Data.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1_Amaiera_Data.Checked = False
        Me.DateTimePicker1_Amaiera_Data.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1_Amaiera_Data.Location = New System.Drawing.Point(544, 176)
        Me.DateTimePicker1_Amaiera_Data.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1_Amaiera_Data.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1_Amaiera_Data.Name = "DateTimePicker1_Amaiera_Data"
        Me.DateTimePicker1_Amaiera_Data.Size = New System.Drawing.Size(286, 23)
        Me.DateTimePicker1_Amaiera_Data.TabIndex = 25
        Me.DateTimePicker1_Amaiera_Data.Value = New Date(2020, 1, 21, 0, 0, 0, 0)
        '
        'Button1_Kendu
        '
        Me.Button1_Kendu.BackgroundImage = Global.ethazi_mac_visual.My.Resources.Resources.Papelera_Borrar
        Me.Button1_Kendu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1_Kendu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1_Kendu.Location = New System.Drawing.Point(578, 438)
        Me.Button1_Kendu.Name = "Button1_Kendu"
        Me.Button1_Kendu.Size = New System.Drawing.Size(72, 67)
        Me.Button1_Kendu.TabIndex = 28
        Me.Button1_Kendu.UseVisualStyleBackColor = True
        '
        'Button1_Aldaketa
        '
        Me.Button1_Aldaketa.BackgroundImage = Global.ethazi_mac_visual.My.Resources.Resources.cambiar_icono_lapiz
        Me.Button1_Aldaketa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1_Aldaketa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1_Aldaketa.Location = New System.Drawing.Point(437, 437)
        Me.Button1_Aldaketa.Name = "Button1_Aldaketa"
        Me.Button1_Aldaketa.Size = New System.Drawing.Size(78, 67)
        Me.Button1_Aldaketa.TabIndex = 27
        Me.Button1_Aldaketa.UseVisualStyleBackColor = True
        '
        'Button1_Gehitu
        '
        Me.Button1_Gehitu.BackgroundImage = Global.ethazi_mac_visual.My.Resources.Resources.SumaSymbol
        Me.Button1_Gehitu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1_Gehitu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1_Gehitu.Location = New System.Drawing.Point(507, 437)
        Me.Button1_Gehitu.Name = "Button1_Gehitu"
        Me.Button1_Gehitu.Size = New System.Drawing.Size(79, 67)
        Me.Button1_Gehitu.TabIndex = 26
        Me.Button1_Gehitu.UseVisualStyleBackColor = True
        '
        'Button1_Atzera
        '
        Me.Button1_Atzera.BackgroundImage = Global.ethazi_mac_visual.My.Resources.Resources.HouseSimbolo
        Me.Button1_Atzera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1_Atzera.Location = New System.Drawing.Point(34, 431)
        Me.Button1_Atzera.Name = "Button1_Atzera"
        Me.Button1_Atzera.Size = New System.Drawing.Size(88, 83)
        Me.Button1_Atzera.TabIndex = 23
        Me.Button1_Atzera.UseVisualStyleBackColor = True
        '
        'Aldaketak_Erreserbak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(842, 553)
        Me.Controls.Add(Me.Button1_Kendu)
        Me.Controls.Add(Me.Button1_Aldaketa)
        Me.Controls.Add(Me.Button1_Gehitu)
        Me.Controls.Add(Me.DateTimePicker1_Amaiera_Data)
        Me.Controls.Add(Me.DateTimePicker1_Hasiera_Data)
        Me.Controls.Add(Me.Button1_Atzera)
        Me.Controls.Add(Me.Label1_Amaiera_Data)
        Me.Controls.Add(Me.Label1_Hasiera_Data)
        Me.Controls.Add(Me.TextBox1_ID_Erabiltzaile)
        Me.Controls.Add(Me.Label1_ID_Erabiltzaile)
        Me.Controls.Add(Me.TextBox1_ID_Ostatu)
        Me.Controls.Add(Me.Label1_ID_Ostatu)
        Me.Controls.Add(Me.Label1_Id_Erreserba_Insert)
        Me.Controls.Add(Me.Label1_Id_Erreserba)
        Me.Controls.Add(Me.Label1_Tituloa)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Aldaketak_Erreserbak"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aldaketak Erreserbak"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1_Tituloa As Label
    Friend WithEvents Label1_Id_Erreserba As Label
    Friend WithEvents Label1_Id_Erreserba_Insert As Label
    Friend WithEvents Label1_ID_Ostatu As Label
    Friend WithEvents TextBox1_ID_Ostatu As TextBox
    Friend WithEvents Label1_ID_Erabiltzaile As Label
    Friend WithEvents TextBox1_ID_Erabiltzaile As TextBox
    Friend WithEvents Label1_Hasiera_Data As Label
    Friend WithEvents Label1_Amaiera_Data As Label
    Friend WithEvents Button1_Atzera As Button
    Friend WithEvents DateTimePicker1_Hasiera_Data As DateTimePicker
    Friend WithEvents DateTimePicker1_Amaiera_Data As DateTimePicker
    Friend WithEvents Button1_Gehitu As Button
    Friend WithEvents Button1_Aldaketa As Button
    Friend WithEvents Button1_Kendu As Button
End Class
