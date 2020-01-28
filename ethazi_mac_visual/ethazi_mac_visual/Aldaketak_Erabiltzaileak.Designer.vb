<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aldaketak_Erabiltzaileak
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

    Private Const V As Boolean = False

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Aldaketak_Erabiltzaileak))
        Me.Label1_Titulua = New System.Windows.Forms.Label()
        Me.Label1_Id = New System.Windows.Forms.Label()
        Me.Label1_Erabiltzaileak = New System.Windows.Forms.Label()
        Me.TextBox1_Erabiltzailea = New System.Windows.Forms.TextBox()
        Me.Label1_Pasahitza = New System.Windows.Forms.Label()
        Me.TextBox1_Pasahitza = New System.Windows.Forms.TextBox()
        Me.Label1_Emaila = New System.Windows.Forms.Label()
        Me.TextBox1_Emaila = New System.Windows.Forms.TextBox()
        Me.Label1_Telefonoa = New System.Windows.Forms.Label()
        Me.TextBox1_Telefonoa = New System.Windows.Forms.TextBox()
        Me.Label1_ErabiltzaileMota = New System.Windows.Forms.Label()
        Me.ComboBox1_ErabiltzaileMota = New System.Windows.Forms.ComboBox()
        Me.Label1_IzenAbizenak = New System.Windows.Forms.Label()
        Me.TextBox1_IzenaAbizenak = New System.Windows.Forms.TextBox()
        Me.Label1_Id_Insert = New System.Windows.Forms.Label()
        Me.Button1_Atzera = New System.Windows.Forms.Button()
        Me.Button1_Kendu = New System.Windows.Forms.Button()
        Me.Button1_Aldaketa = New System.Windows.Forms.Button()
        Me.Button1_Gehitu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1_Titulua
        '
        Me.Label1_Titulua.AutoSize = True
        Me.Label1_Titulua.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Titulua.Location = New System.Drawing.Point(291, 21)
        Me.Label1_Titulua.Name = "Label1_Titulua"
        Me.Label1_Titulua.Size = New System.Drawing.Size(197, 46)
        Me.Label1_Titulua.TabIndex = 1
        Me.Label1_Titulua.Text = "Erabiltzailea"
        '
        'Label1_Id
        '
        Me.Label1_Id.AutoSize = True
        Me.Label1_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Id.Location = New System.Drawing.Point(23, 96)
        Me.Label1_Id.Name = "Label1_Id"
        Me.Label1_Id.Size = New System.Drawing.Size(121, 20)
        Me.Label1_Id.TabIndex = 2
        Me.Label1_Id.Text = "Id Erabiltzailea :"
        '
        'Label1_Erabiltzaileak
        '
        Me.Label1_Erabiltzaileak.AutoSize = True
        Me.Label1_Erabiltzaileak.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Erabiltzaileak.Location = New System.Drawing.Point(216, 96)
        Me.Label1_Erabiltzaileak.Name = "Label1_Erabiltzaileak"
        Me.Label1_Erabiltzaileak.Size = New System.Drawing.Size(103, 20)
        Me.Label1_Erabiltzaileak.TabIndex = 3
        Me.Label1_Erabiltzaileak.Text = "Erabiltzailea :"
        '
        'TextBox1_Erabiltzailea
        '
        Me.TextBox1_Erabiltzailea.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_Erabiltzailea.Location = New System.Drawing.Point(333, 90)
        Me.TextBox1_Erabiltzailea.MaxLength = 45
        Me.TextBox1_Erabiltzailea.Name = "TextBox1_Erabiltzailea"
        Me.TextBox1_Erabiltzailea.Size = New System.Drawing.Size(173, 26)
        Me.TextBox1_Erabiltzailea.TabIndex = 4
        '
        'Label1_Pasahitza
        '
        Me.Label1_Pasahitza.AutoSize = True
        Me.Label1_Pasahitza.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Pasahitza.Location = New System.Drawing.Point(529, 90)
        Me.Label1_Pasahitza.Name = "Label1_Pasahitza"
        Me.Label1_Pasahitza.Size = New System.Drawing.Size(87, 20)
        Me.Label1_Pasahitza.TabIndex = 5
        Me.Label1_Pasahitza.Text = "Pasahitza :"
        '
        'TextBox1_Pasahitza
        '
        Me.TextBox1_Pasahitza.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_Pasahitza.Location = New System.Drawing.Point(622, 87)
        Me.TextBox1_Pasahitza.MaxLength = 150
        Me.TextBox1_Pasahitza.Name = "TextBox1_Pasahitza"
        Me.TextBox1_Pasahitza.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1_Pasahitza.Size = New System.Drawing.Size(159, 26)
        Me.TextBox1_Pasahitza.TabIndex = 6
        '
        'Label1_Emaila
        '
        Me.Label1_Emaila.AutoSize = True
        Me.Label1_Emaila.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Emaila.Location = New System.Drawing.Point(1, 171)
        Me.Label1_Emaila.Name = "Label1_Emaila"
        Me.Label1_Emaila.Size = New System.Drawing.Size(65, 20)
        Me.Label1_Emaila.TabIndex = 7
        Me.Label1_Emaila.Text = "Emaila :"
        '
        'TextBox1_Emaila
        '
        Me.TextBox1_Emaila.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_Emaila.Location = New System.Drawing.Point(72, 168)
        Me.TextBox1_Emaila.MaxLength = 45
        Me.TextBox1_Emaila.Name = "TextBox1_Emaila"
        Me.TextBox1_Emaila.Size = New System.Drawing.Size(255, 26)
        Me.TextBox1_Emaila.TabIndex = 8
        '
        'Label1_Telefonoa
        '
        Me.Label1_Telefonoa.AutoSize = True
        Me.Label1_Telefonoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Telefonoa.Location = New System.Drawing.Point(329, 174)
        Me.Label1_Telefonoa.Name = "Label1_Telefonoa"
        Me.Label1_Telefonoa.Size = New System.Drawing.Size(88, 20)
        Me.Label1_Telefonoa.TabIndex = 9
        Me.Label1_Telefonoa.Text = "Telefonoa :"
        '
        'TextBox1_Telefonoa
        '
        Me.TextBox1_Telefonoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_Telefonoa.Location = New System.Drawing.Point(429, 171)
        Me.TextBox1_Telefonoa.MaxLength = 9
        Me.TextBox1_Telefonoa.Name = "TextBox1_Telefonoa"
        Me.TextBox1_Telefonoa.Size = New System.Drawing.Size(108, 26)
        Me.TextBox1_Telefonoa.TabIndex = 10
        '
        'Label1_ErabiltzaileMota
        '
        Me.Label1_ErabiltzaileMota.AutoSize = True
        Me.Label1_ErabiltzaileMota.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_ErabiltzaileMota.Location = New System.Drawing.Point(543, 174)
        Me.Label1_ErabiltzaileMota.Name = "Label1_ErabiltzaileMota"
        Me.Label1_ErabiltzaileMota.Size = New System.Drawing.Size(134, 20)
        Me.Label1_ErabiltzaileMota.TabIndex = 11
        Me.Label1_ErabiltzaileMota.Text = "Erabiltzaile Mota :"
        '
        'ComboBox1_ErabiltzaileMota
        '
        Me.ComboBox1_ErabiltzaileMota.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1_ErabiltzaileMota.FormattingEnabled = True
        Me.ComboBox1_ErabiltzaileMota.Items.AddRange(New Object() {"Mota 0 - Super Administratzailea", "Mota 1 - Bezeroa", "Mota 2 - Bezeroentzako Arreta kontua"})
        Me.ComboBox1_ErabiltzaileMota.Location = New System.Drawing.Point(683, 171)
        Me.ComboBox1_ErabiltzaileMota.Name = "ComboBox1_ErabiltzaileMota"
        Me.ComboBox1_ErabiltzaileMota.Size = New System.Drawing.Size(147, 28)
        Me.ComboBox1_ErabiltzaileMota.TabIndex = 12
        '
        'Label1_IzenAbizenak
        '
        Me.Label1_IzenAbizenak.AutoSize = True
        Me.Label1_IzenAbizenak.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_IzenAbizenak.Location = New System.Drawing.Point(31, 248)
        Me.Label1_IzenAbizenak.Name = "Label1_IzenAbizenak"
        Me.Label1_IzenAbizenak.Size = New System.Drawing.Size(154, 20)
        Me.Label1_IzenAbizenak.TabIndex = 13
        Me.Label1_IzenAbizenak.Text = "Izena eta Abizenak :"
        '
        'TextBox1_IzenaAbizenak
        '
        Me.TextBox1_IzenaAbizenak.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_IzenaAbizenak.Location = New System.Drawing.Point(200, 242)
        Me.TextBox1_IzenaAbizenak.MaxLength = 100
        Me.TextBox1_IzenaAbizenak.Name = "TextBox1_IzenaAbizenak"
        Me.TextBox1_IzenaAbizenak.Size = New System.Drawing.Size(416, 26)
        Me.TextBox1_IzenaAbizenak.TabIndex = 14
        '
        'Label1_Id_Insert
        '
        Me.Label1_Id_Insert.AutoSize = True
        Me.Label1_Id_Insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Id_Insert.ForeColor = System.Drawing.Color.Blue
        Me.Label1_Id_Insert.Location = New System.Drawing.Point(150, 96)
        Me.Label1_Id_Insert.Name = "Label1_Id_Insert"
        Me.Label1_Id_Insert.Size = New System.Drawing.Size(35, 20)
        Me.Label1_Id_Insert.TabIndex = 15
        Me.Label1_Id_Insert.Text = "Null"
        '
        'Button1_Atzera
        '
        Me.Button1_Atzera.BackgroundImage = Global.ethazi_mac_visual.My.Resources.Resources.HouseSimbolo
        Me.Button1_Atzera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1_Atzera.Location = New System.Drawing.Point(35, 437)
        Me.Button1_Atzera.Name = "Button1_Atzera"
        Me.Button1_Atzera.Size = New System.Drawing.Size(88, 82)
        Me.Button1_Atzera.TabIndex = 21
        Me.Button1_Atzera.UseVisualStyleBackColor = True
        '
        'Button1_Kendu
        '
        Me.Button1_Kendu.BackgroundImage = Global.ethazi_mac_visual.My.Resources.Resources.Papelera_Borrar
        Me.Button1_Kendu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1_Kendu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1_Kendu.Location = New System.Drawing.Point(622, 437)
        Me.Button1_Kendu.Name = "Button1_Kendu"
        Me.Button1_Kendu.Size = New System.Drawing.Size(84, 82)
        Me.Button1_Kendu.TabIndex = 20
        Me.Button1_Kendu.UseVisualStyleBackColor = True
        '
        'Button1_Aldaketa
        '
        Me.Button1_Aldaketa.BackgroundImage = Global.ethazi_mac_visual.My.Resources.Resources.cambiar_icono_lapiz
        Me.Button1_Aldaketa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1_Aldaketa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1_Aldaketa.Location = New System.Drawing.Point(497, 437)
        Me.Button1_Aldaketa.Name = "Button1_Aldaketa"
        Me.Button1_Aldaketa.Size = New System.Drawing.Size(84, 82)
        Me.Button1_Aldaketa.TabIndex = 19
        Me.Button1_Aldaketa.UseVisualStyleBackColor = True
        '
        'Button1_Gehitu
        '
        Me.Button1_Gehitu.BackgroundImage = Global.ethazi_mac_visual.My.Resources.Resources.SumaSymbol
        Me.Button1_Gehitu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1_Gehitu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1_Gehitu.Location = New System.Drawing.Point(547, 437)
        Me.Button1_Gehitu.Name = "Button1_Gehitu"
        Me.Button1_Gehitu.Size = New System.Drawing.Size(89, 82)
        Me.Button1_Gehitu.TabIndex = 18
        Me.Button1_Gehitu.UseVisualStyleBackColor = True
        '
        'Aldaketak_Erabiltzaileak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(852, 545)
        Me.Controls.Add(Me.Button1_Atzera)
        Me.Controls.Add(Me.Button1_Kendu)
        Me.Controls.Add(Me.Button1_Aldaketa)
        Me.Controls.Add(Me.Button1_Gehitu)
        Me.Controls.Add(Me.Label1_Id_Insert)
        Me.Controls.Add(Me.TextBox1_IzenaAbizenak)
        Me.Controls.Add(Me.Label1_IzenAbizenak)
        Me.Controls.Add(Me.ComboBox1_ErabiltzaileMota)
        Me.Controls.Add(Me.Label1_ErabiltzaileMota)
        Me.Controls.Add(Me.TextBox1_Telefonoa)
        Me.Controls.Add(Me.Label1_Telefonoa)
        Me.Controls.Add(Me.TextBox1_Emaila)
        Me.Controls.Add(Me.Label1_Emaila)
        Me.Controls.Add(Me.TextBox1_Pasahitza)
        Me.Controls.Add(Me.Label1_Pasahitza)
        Me.Controls.Add(Me.TextBox1_Erabiltzailea)
        Me.Controls.Add(Me.Label1_Erabiltzaileak)
        Me.Controls.Add(Me.Label1_Id)
        Me.Controls.Add(Me.Label1_Titulua)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Aldaketak_Erabiltzaileak"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aldaketak Erabiltzailea"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1_Titulua As Label
    Friend WithEvents Label1_Id As Label
    Friend WithEvents Label1_Erabiltzaileak As Label
    Friend WithEvents TextBox1_Erabiltzailea As TextBox
    Friend WithEvents Label1_Pasahitza As Label
    Friend WithEvents TextBox1_Pasahitza As TextBox
    Friend WithEvents Label1_Emaila As Label
    Friend WithEvents TextBox1_Emaila As TextBox
    Friend WithEvents Label1_Telefonoa As Label
    Friend WithEvents TextBox1_Telefonoa As TextBox
    Friend WithEvents Label1_ErabiltzaileMota As Label
    Friend WithEvents ComboBox1_ErabiltzaileMota As ComboBox
    Friend WithEvents Label1_IzenAbizenak As Label
    Friend WithEvents TextBox1_IzenaAbizenak As TextBox
    Friend WithEvents Label1_Id_Insert As Label
    Friend WithEvents Button1_Gehitu As Button
    Friend WithEvents Button1_Aldaketa As Button
    Friend WithEvents Button1_Kendu As Button
    Friend WithEvents Button1_Atzera As Button
End Class
