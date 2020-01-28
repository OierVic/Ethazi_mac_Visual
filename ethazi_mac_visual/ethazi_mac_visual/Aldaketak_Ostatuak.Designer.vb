<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Aldaketak_Ostatuak
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Aldaketak_Ostatuak))
        Me.Label1_Tituloa = New System.Windows.Forms.Label()
        Me.Label1_Id_Ostatu = New System.Windows.Forms.Label()
        Me.Label1_Id_Ostatu_Insert = New System.Windows.Forms.Label()
        Me.Label1_Izena = New System.Windows.Forms.Label()
        Me.TextBox1_Izena = New System.Windows.Forms.TextBox()
        Me.Label1_Deskribapena = New System.Windows.Forms.Label()
        Me.RichTextBox1_Deskribapena = New System.Windows.Forms.RichTextBox()
        Me.Label1_Ostatu_mota = New System.Windows.Forms.Label()
        Me.ComboBox1_Ostatu_Mota = New System.Windows.Forms.ComboBox()
        Me.Label1_Logela_kop = New System.Windows.Forms.Label()
        Me.NumericUpDown1_Logela_kop = New System.Windows.Forms.NumericUpDown()
        Me.Label1_Kokapena = New System.Windows.Forms.Label()
        Me.RichTextBox1_Kokapena = New System.Windows.Forms.RichTextBox()
        Me.Label1_Telefonoa = New System.Windows.Forms.Label()
        Me.TextBox1_Telefonoa = New System.Windows.Forms.TextBox()
        Me.Label1_Email = New System.Windows.Forms.Label()
        Me.TextBox1_Email = New System.Windows.Forms.TextBox()
        Me.Label1_Latitudea = New System.Windows.Forms.Label()
        Me.TextBox1_Latitudea = New System.Windows.Forms.TextBox()
        Me.Label1_Longitudea = New System.Windows.Forms.Label()
        Me.TextBox1_Longitudea = New System.Windows.Forms.TextBox()
        Me.Label1_Prezioa = New System.Windows.Forms.Label()
        Me.TextBox1_Prezioa = New System.Windows.Forms.TextBox()
        Me.Label1_Euros = New System.Windows.Forms.Label()
        Me.Button1_Kendu = New System.Windows.Forms.Button()
        Me.Button1_Aldaketa = New System.Windows.Forms.Button()
        Me.Button1_Gehitu = New System.Windows.Forms.Button()
        Me.Button1_Atzera = New System.Windows.Forms.Button()
        CType(Me.NumericUpDown1_Logela_kop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1_Tituloa
        '
        Me.Label1_Tituloa.AutoSize = True
        Me.Label1_Tituloa.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Tituloa.Location = New System.Drawing.Point(337, 21)
        Me.Label1_Tituloa.Name = "Label1_Tituloa"
        Me.Label1_Tituloa.Size = New System.Drawing.Size(137, 46)
        Me.Label1_Tituloa.TabIndex = 0
        Me.Label1_Tituloa.Text = "Ostatua"
        '
        'Label1_Id_Ostatu
        '
        Me.Label1_Id_Ostatu.AutoSize = True
        Me.Label1_Id_Ostatu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Id_Ostatu.Location = New System.Drawing.Point(12, 85)
        Me.Label1_Id_Ostatu.Name = "Label1_Id_Ostatu"
        Me.Label1_Id_Ostatu.Size = New System.Drawing.Size(83, 20)
        Me.Label1_Id_Ostatu.TabIndex = 1
        Me.Label1_Id_Ostatu.Text = "Id Ostatu :"
        Me.Label1_Id_Ostatu.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1_Id_Ostatu_Insert
        '
        Me.Label1_Id_Ostatu_Insert.AutoSize = True
        Me.Label1_Id_Ostatu_Insert.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Id_Ostatu_Insert.ForeColor = System.Drawing.Color.Blue
        Me.Label1_Id_Ostatu_Insert.Location = New System.Drawing.Point(109, 84)
        Me.Label1_Id_Ostatu_Insert.Name = "Label1_Id_Ostatu_Insert"
        Me.Label1_Id_Ostatu_Insert.Size = New System.Drawing.Size(36, 21)
        Me.Label1_Id_Ostatu_Insert.TabIndex = 2
        Me.Label1_Id_Ostatu_Insert.Text = "null"
        '
        'Label1_Izena
        '
        Me.Label1_Izena.AutoSize = True
        Me.Label1_Izena.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Izena.Location = New System.Drawing.Point(175, 86)
        Me.Label1_Izena.Name = "Label1_Izena"
        Me.Label1_Izena.Size = New System.Drawing.Size(57, 20)
        Me.Label1_Izena.TabIndex = 3
        Me.Label1_Izena.Text = "Izena :"
        '
        'TextBox1_Izena
        '
        Me.TextBox1_Izena.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_Izena.Location = New System.Drawing.Point(238, 85)
        Me.TextBox1_Izena.MaxLength = 45
        Me.TextBox1_Izena.Name = "TextBox1_Izena"
        Me.TextBox1_Izena.Size = New System.Drawing.Size(197, 26)
        Me.TextBox1_Izena.TabIndex = 4
        '
        'Label1_Deskribapena
        '
        Me.Label1_Deskribapena.AutoSize = True
        Me.Label1_Deskribapena.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Deskribapena.Location = New System.Drawing.Point(12, 126)
        Me.Label1_Deskribapena.Name = "Label1_Deskribapena"
        Me.Label1_Deskribapena.Size = New System.Drawing.Size(116, 20)
        Me.Label1_Deskribapena.TabIndex = 5
        Me.Label1_Deskribapena.Text = "Deskribapena :"
        '
        'RichTextBox1_Deskribapena
        '
        Me.RichTextBox1_Deskribapena.Font = New System.Drawing.Font("Microsoft Sans Serif", 0.15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, CType(0, Byte))
        Me.RichTextBox1_Deskribapena.Location = New System.Drawing.Point(30, 149)
        Me.RichTextBox1_Deskribapena.MaxLength = 1500
        Me.RichTextBox1_Deskribapena.Name = "RichTextBox1_Deskribapena"
        Me.RichTextBox1_Deskribapena.Size = New System.Drawing.Size(779, 108)
        Me.RichTextBox1_Deskribapena.TabIndex = 6
        Me.RichTextBox1_Deskribapena.Text = ""
        '
        'Label1_Ostatu_mota
        '
        Me.Label1_Ostatu_mota.AutoSize = True
        Me.Label1_Ostatu_mota.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Ostatu_mota.Location = New System.Drawing.Point(462, 88)
        Me.Label1_Ostatu_mota.Name = "Label1_Ostatu_mota"
        Me.Label1_Ostatu_mota.Size = New System.Drawing.Size(105, 20)
        Me.Label1_Ostatu_mota.TabIndex = 7
        Me.Label1_Ostatu_mota.Text = "Ostatu Mota :"
        '
        'ComboBox1_Ostatu_Mota
        '
        Me.ComboBox1_Ostatu_Mota.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1_Ostatu_Mota.FormattingEnabled = True
        Me.ComboBox1_Ostatu_Mota.Items.AddRange(New Object() {"Campings", "Agroturismos", "Casas Rurales", "Albergues"})
        Me.ComboBox1_Ostatu_Mota.Location = New System.Drawing.Point(573, 88)
        Me.ComboBox1_Ostatu_Mota.Name = "ComboBox1_Ostatu_Mota"
        Me.ComboBox1_Ostatu_Mota.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox1_Ostatu_Mota.TabIndex = 8
        '
        'Label1_Logela_kop
        '
        Me.Label1_Logela_kop.AutoSize = True
        Me.Label1_Logela_kop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Logela_kop.Location = New System.Drawing.Point(438, 281)
        Me.Label1_Logela_kop.Name = "Label1_Logela_kop"
        Me.Label1_Logela_kop.Size = New System.Drawing.Size(129, 20)
        Me.Label1_Logela_kop.TabIndex = 9
        Me.Label1_Logela_kop.Text = "Logela Kopurua :"
        '
        'NumericUpDown1_Logela_kop
        '
        Me.NumericUpDown1_Logela_kop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1_Logela_kop.Location = New System.Drawing.Point(610, 279)
        Me.NumericUpDown1_Logela_kop.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown1_Logela_kop.Name = "NumericUpDown1_Logela_kop"
        Me.NumericUpDown1_Logela_kop.ReadOnly = True
        Me.NumericUpDown1_Logela_kop.Size = New System.Drawing.Size(87, 26)
        Me.NumericUpDown1_Logela_kop.TabIndex = 10
        Me.NumericUpDown1_Logela_kop.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label1_Kokapena
        '
        Me.Label1_Kokapena.AutoSize = True
        Me.Label1_Kokapena.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Kokapena.Location = New System.Drawing.Point(12, 281)
        Me.Label1_Kokapena.Name = "Label1_Kokapena"
        Me.Label1_Kokapena.Size = New System.Drawing.Size(89, 20)
        Me.Label1_Kokapena.TabIndex = 11
        Me.Label1_Kokapena.Text = "Kokapena :"
        '
        'RichTextBox1_Kokapena
        '
        Me.RichTextBox1_Kokapena.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1_Kokapena.Location = New System.Drawing.Point(113, 284)
        Me.RichTextBox1_Kokapena.MaxLength = 90
        Me.RichTextBox1_Kokapena.Name = "RichTextBox1_Kokapena"
        Me.RichTextBox1_Kokapena.Size = New System.Drawing.Size(303, 83)
        Me.RichTextBox1_Kokapena.TabIndex = 12
        Me.RichTextBox1_Kokapena.Text = ""
        '
        'Label1_Telefonoa
        '
        Me.Label1_Telefonoa.AutoSize = True
        Me.Label1_Telefonoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Telefonoa.Location = New System.Drawing.Point(479, 323)
        Me.Label1_Telefonoa.Name = "Label1_Telefonoa"
        Me.Label1_Telefonoa.Size = New System.Drawing.Size(88, 20)
        Me.Label1_Telefonoa.TabIndex = 13
        Me.Label1_Telefonoa.Text = "Telefonoa :"
        '
        'TextBox1_Telefonoa
        '
        Me.TextBox1_Telefonoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_Telefonoa.Location = New System.Drawing.Point(610, 317)
        Me.TextBox1_Telefonoa.MaxLength = 9
        Me.TextBox1_Telefonoa.Name = "TextBox1_Telefonoa"
        Me.TextBox1_Telefonoa.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1_Telefonoa.TabIndex = 14
        '
        'Label1_Email
        '
        Me.Label1_Email.AutoSize = True
        Me.Label1_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Email.Location = New System.Drawing.Point(45, 388)
        Me.Label1_Email.Name = "Label1_Email"
        Me.Label1_Email.Size = New System.Drawing.Size(56, 20)
        Me.Label1_Email.TabIndex = 15
        Me.Label1_Email.Text = "Email :"
        '
        'TextBox1_Email
        '
        Me.TextBox1_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_Email.Location = New System.Drawing.Point(113, 382)
        Me.TextBox1_Email.MaxLength = 80
        Me.TextBox1_Email.Name = "TextBox1_Email"
        Me.TextBox1_Email.Size = New System.Drawing.Size(303, 26)
        Me.TextBox1_Email.TabIndex = 16
        '
        'Label1_Latitudea
        '
        Me.Label1_Latitudea.AutoSize = True
        Me.Label1_Latitudea.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Latitudea.Location = New System.Drawing.Point(483, 364)
        Me.Label1_Latitudea.Name = "Label1_Latitudea"
        Me.Label1_Latitudea.Size = New System.Drawing.Size(84, 20)
        Me.Label1_Latitudea.TabIndex = 17
        Me.Label1_Latitudea.Text = "Latitudea :"
        '
        'TextBox1_Latitudea
        '
        Me.TextBox1_Latitudea.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_Latitudea.Location = New System.Drawing.Point(607, 355)
        Me.TextBox1_Latitudea.MaxLength = 45
        Me.TextBox1_Latitudea.Name = "TextBox1_Latitudea"
        Me.TextBox1_Latitudea.Size = New System.Drawing.Size(213, 26)
        Me.TextBox1_Latitudea.TabIndex = 18
        '
        'Label1_Longitudea
        '
        Me.Label1_Longitudea.AutoSize = True
        Me.Label1_Longitudea.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Longitudea.Location = New System.Drawing.Point(483, 399)
        Me.Label1_Longitudea.Name = "Label1_Longitudea"
        Me.Label1_Longitudea.Size = New System.Drawing.Size(97, 20)
        Me.Label1_Longitudea.TabIndex = 19
        Me.Label1_Longitudea.Text = "Longitudea :"
        '
        'TextBox1_Longitudea
        '
        Me.TextBox1_Longitudea.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_Longitudea.Location = New System.Drawing.Point(610, 399)
        Me.TextBox1_Longitudea.MaxLength = 45
        Me.TextBox1_Longitudea.Name = "TextBox1_Longitudea"
        Me.TextBox1_Longitudea.Size = New System.Drawing.Size(199, 26)
        Me.TextBox1_Longitudea.TabIndex = 20
        '
        'Label1_Prezioa
        '
        Me.Label1_Prezioa.AutoSize = True
        Me.Label1_Prezioa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Prezioa.Location = New System.Drawing.Point(31, 423)
        Me.Label1_Prezioa.Name = "Label1_Prezioa"
        Me.Label1_Prezioa.Size = New System.Drawing.Size(70, 20)
        Me.Label1_Prezioa.TabIndex = 26
        Me.Label1_Prezioa.Text = "Prezioa :"
        '
        'TextBox1_Prezioa
        '
        Me.TextBox1_Prezioa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_Prezioa.Location = New System.Drawing.Point(113, 423)
        Me.TextBox1_Prezioa.MaxLength = 6
        Me.TextBox1_Prezioa.Name = "TextBox1_Prezioa"
        Me.TextBox1_Prezioa.Size = New System.Drawing.Size(88, 26)
        Me.TextBox1_Prezioa.TabIndex = 27
        '
        'Label1_Euros
        '
        Me.Label1_Euros.AutoSize = True
        Me.Label1_Euros.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Euros.Location = New System.Drawing.Point(209, 424)
        Me.Label1_Euros.Name = "Label1_Euros"
        Me.Label1_Euros.Size = New System.Drawing.Size(23, 25)
        Me.Label1_Euros.TabIndex = 29
        Me.Label1_Euros.Text = "€"
        '
        'Button1_Kendu
        '
        Me.Button1_Kendu.BackgroundImage = Global.ethazi_mac_visual.My.Resources.Resources.Papelera_Borrar
        Me.Button1_Kendu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1_Kendu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1_Kendu.Location = New System.Drawing.Point(607, 473)
        Me.Button1_Kendu.Name = "Button1_Kendu"
        Me.Button1_Kendu.Size = New System.Drawing.Size(72, 67)
        Me.Button1_Kendu.TabIndex = 25
        Me.Button1_Kendu.UseVisualStyleBackColor = True
        '
        'Button1_Aldaketa
        '
        Me.Button1_Aldaketa.BackgroundImage = Global.ethazi_mac_visual.My.Resources.Resources.cambiar_icono_lapiz
        Me.Button1_Aldaketa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1_Aldaketa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1_Aldaketa.Location = New System.Drawing.Point(479, 474)
        Me.Button1_Aldaketa.Name = "Button1_Aldaketa"
        Me.Button1_Aldaketa.Size = New System.Drawing.Size(78, 67)
        Me.Button1_Aldaketa.TabIndex = 24
        Me.Button1_Aldaketa.UseVisualStyleBackColor = True
        '
        'Button1_Gehitu
        '
        Me.Button1_Gehitu.BackgroundImage = Global.ethazi_mac_visual.My.Resources.Resources.SumaSymbol
        Me.Button1_Gehitu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1_Gehitu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1_Gehitu.Location = New System.Drawing.Point(538, 474)
        Me.Button1_Gehitu.Name = "Button1_Gehitu"
        Me.Button1_Gehitu.Size = New System.Drawing.Size(79, 67)
        Me.Button1_Gehitu.TabIndex = 23
        Me.Button1_Gehitu.UseVisualStyleBackColor = True
        '
        'Button1_Atzera
        '
        Me.Button1_Atzera.BackgroundImage = Global.ethazi_mac_visual.My.Resources.Resources.HouseSimbolo
        Me.Button1_Atzera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1_Atzera.Location = New System.Drawing.Point(30, 458)
        Me.Button1_Atzera.Name = "Button1_Atzera"
        Me.Button1_Atzera.Size = New System.Drawing.Size(88, 83)
        Me.Button1_Atzera.TabIndex = 22
        Me.Button1_Atzera.UseVisualStyleBackColor = True
        '
        'Aldaketak_Ostatuak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(842, 553)
        Me.Controls.Add(Me.Label1_Euros)
        Me.Controls.Add(Me.TextBox1_Prezioa)
        Me.Controls.Add(Me.Label1_Prezioa)
        Me.Controls.Add(Me.Button1_Kendu)
        Me.Controls.Add(Me.Button1_Aldaketa)
        Me.Controls.Add(Me.Button1_Gehitu)
        Me.Controls.Add(Me.Button1_Atzera)
        Me.Controls.Add(Me.TextBox1_Longitudea)
        Me.Controls.Add(Me.Label1_Longitudea)
        Me.Controls.Add(Me.TextBox1_Latitudea)
        Me.Controls.Add(Me.Label1_Latitudea)
        Me.Controls.Add(Me.TextBox1_Email)
        Me.Controls.Add(Me.Label1_Email)
        Me.Controls.Add(Me.TextBox1_Telefonoa)
        Me.Controls.Add(Me.Label1_Telefonoa)
        Me.Controls.Add(Me.RichTextBox1_Kokapena)
        Me.Controls.Add(Me.Label1_Kokapena)
        Me.Controls.Add(Me.NumericUpDown1_Logela_kop)
        Me.Controls.Add(Me.Label1_Logela_kop)
        Me.Controls.Add(Me.ComboBox1_Ostatu_Mota)
        Me.Controls.Add(Me.Label1_Ostatu_mota)
        Me.Controls.Add(Me.RichTextBox1_Deskribapena)
        Me.Controls.Add(Me.Label1_Deskribapena)
        Me.Controls.Add(Me.TextBox1_Izena)
        Me.Controls.Add(Me.Label1_Izena)
        Me.Controls.Add(Me.Label1_Id_Ostatu_Insert)
        Me.Controls.Add(Me.Label1_Id_Ostatu)
        Me.Controls.Add(Me.Label1_Tituloa)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Aldaketak_Ostatuak"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aldaketak Ostatuak"
        CType(Me.NumericUpDown1_Logela_kop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1_Tituloa As Label
    Friend WithEvents Label1_Id_Ostatu As Label
    Friend WithEvents Label1_Id_Ostatu_Insert As Label
    Friend WithEvents Label1_Izena As Label
    Friend WithEvents TextBox1_Izena As TextBox
    Friend WithEvents Label1_Deskribapena As Label
    Friend WithEvents RichTextBox1_Deskribapena As RichTextBox
    Friend WithEvents Label1_Ostatu_mota As Label
    Friend WithEvents ComboBox1_Ostatu_Mota As ComboBox
    Friend WithEvents Label1_Logela_kop As Label
    Friend WithEvents NumericUpDown1_Logela_kop As NumericUpDown
    Friend WithEvents Label1_Kokapena As Label
    Friend WithEvents RichTextBox1_Kokapena As RichTextBox
    Friend WithEvents Label1_Telefonoa As Label
    Friend WithEvents TextBox1_Telefonoa As TextBox
    Friend WithEvents Label1_Email As Label
    Friend WithEvents TextBox1_Email As TextBox
    Friend WithEvents Label1_Latitudea As Label
    Friend WithEvents TextBox1_Latitudea As TextBox
    Friend WithEvents Label1_Longitudea As Label
    Friend WithEvents TextBox1_Longitudea As TextBox
    Friend WithEvents Button1_Atzera As Button
    Friend WithEvents Button1_Gehitu As Button
    Friend WithEvents Button1_Aldaketa As Button
    Friend WithEvents Button1_Kendu As Button
    Friend WithEvents Label1_Prezioa As Label
    Friend WithEvents TextBox1_Prezioa As TextBox
    Friend WithEvents Label1_Euros As Label
End Class
