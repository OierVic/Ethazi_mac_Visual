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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label1_Id_Ostatu = New System.Windows.Forms.Label()
        Me.Label1_Id_Ostatu_Insert = New System.Windows.Forms.Label()
        Me.Label1_Izena = New System.Windows.Forms.Label()
        Me.TextBox1_Izena = New System.Windows.Forms.TextBox()
        Me.Label1_Deskribapena = New System.Windows.Forms.Label()
        Me.RichTextBox1_Deskribapena = New System.Windows.Forms.RichTextBox()
        Me.Label1_Ostatu_mota = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1_Logela_kop = New System.Windows.Forms.Label()
        Me.NumericUpDown1_Logela_kop = New System.Windows.Forms.NumericUpDown()
        CType(Me.NumericUpDown1_Logela_kop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(337, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Titulua"
        '
        'Label1_Id_Ostatu
        '
        Me.Label1_Id_Ostatu.AutoSize = True
        Me.Label1_Id_Ostatu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Id_Ostatu.Location = New System.Drawing.Point(35, 86)
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
        Me.Label1_Id_Ostatu_Insert.Location = New System.Drawing.Point(133, 85)
        Me.Label1_Id_Ostatu_Insert.Name = "Label1_Id_Ostatu_Insert"
        Me.Label1_Id_Ostatu_Insert.Size = New System.Drawing.Size(36, 21)
        Me.Label1_Id_Ostatu_Insert.TabIndex = 2
        Me.Label1_Id_Ostatu_Insert.Text = "null"
        '
        'Label1_Izena
        '
        Me.Label1_Izena.AutoSize = True
        Me.Label1_Izena.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Izena.Location = New System.Drawing.Point(204, 86)
        Me.Label1_Izena.Name = "Label1_Izena"
        Me.Label1_Izena.Size = New System.Drawing.Size(57, 20)
        Me.Label1_Izena.TabIndex = 3
        Me.Label1_Izena.Text = "Izena :"
        '
        'TextBox1_Izena
        '
        Me.TextBox1_Izena.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_Izena.Location = New System.Drawing.Point(267, 83)
        Me.TextBox1_Izena.Name = "TextBox1_Izena"
        Me.TextBox1_Izena.Size = New System.Drawing.Size(213, 26)
        Me.TextBox1_Izena.TabIndex = 4
        '
        'Label1_Deskribapena
        '
        Me.Label1_Deskribapena.AutoSize = True
        Me.Label1_Deskribapena.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Deskribapena.Location = New System.Drawing.Point(502, 83)
        Me.Label1_Deskribapena.Name = "Label1_Deskribapena"
        Me.Label1_Deskribapena.Size = New System.Drawing.Size(116, 20)
        Me.Label1_Deskribapena.TabIndex = 5
        Me.Label1_Deskribapena.Text = "Deskribapena :"
        '
        'RichTextBox1_Deskribapena
        '
        Me.RichTextBox1_Deskribapena.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, CType(0, Byte))
        Me.RichTextBox1_Deskribapena.Location = New System.Drawing.Point(635, 83)
        Me.RichTextBox1_Deskribapena.Name = "RichTextBox1_Deskribapena"
        Me.RichTextBox1_Deskribapena.Size = New System.Drawing.Size(195, 97)
        Me.RichTextBox1_Deskribapena.TabIndex = 6
        Me.RichTextBox1_Deskribapena.Text = ""
        '
        'Label1_Ostatu_mota
        '
        Me.Label1_Ostatu_mota.AutoSize = True
        Me.Label1_Ostatu_mota.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Ostatu_mota.Location = New System.Drawing.Point(36, 152)
        Me.Label1_Ostatu_mota.Name = "Label1_Ostatu_mota"
        Me.Label1_Ostatu_mota.Size = New System.Drawing.Size(105, 20)
        Me.Label1_Ostatu_mota.TabIndex = 7
        Me.Label1_Ostatu_mota.Text = "Ostatu Mota :"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Campings", "Agroturismos", "Casas Rurales", "Albergues"})
        Me.ComboBox1.Location = New System.Drawing.Point(147, 151)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'Label1_Logela_kop
        '
        Me.Label1_Logela_kop.AutoSize = True
        Me.Label1_Logela_kop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Logela_kop.Location = New System.Drawing.Point(289, 149)
        Me.Label1_Logela_kop.Name = "Label1_Logela_kop"
        Me.Label1_Logela_kop.Size = New System.Drawing.Size(129, 20)
        Me.Label1_Logela_kop.TabIndex = 9
        Me.Label1_Logela_kop.Text = "Logela Kopurua :"
        '
        'NumericUpDown1_Logela_kop
        '
        Me.NumericUpDown1_Logela_kop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1_Logela_kop.Location = New System.Drawing.Point(435, 147)
        Me.NumericUpDown1_Logela_kop.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown1_Logela_kop.Name = "NumericUpDown1_Logela_kop"
        Me.NumericUpDown1_Logela_kop.ReadOnly = True
        Me.NumericUpDown1_Logela_kop.Size = New System.Drawing.Size(87, 26)
        Me.NumericUpDown1_Logela_kop.TabIndex = 10
        Me.NumericUpDown1_Logela_kop.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Aldaketak_Ostatuak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(842, 545)
        Me.Controls.Add(Me.NumericUpDown1_Logela_kop)
        Me.Controls.Add(Me.Label1_Logela_kop)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1_Ostatu_mota)
        Me.Controls.Add(Me.RichTextBox1_Deskribapena)
        Me.Controls.Add(Me.Label1_Deskribapena)
        Me.Controls.Add(Me.TextBox1_Izena)
        Me.Controls.Add(Me.Label1_Izena)
        Me.Controls.Add(Me.Label1_Id_Ostatu_Insert)
        Me.Controls.Add(Me.Label1_Id_Ostatu)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Aldaketak_Ostatuak"
        Me.Text = "Aldaketak Erabiltzailea"
        CType(Me.NumericUpDown1_Logela_kop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label1_Id_Ostatu As Label
    Friend WithEvents Label1_Id_Ostatu_Insert As Label
    Friend WithEvents Label1_Izena As Label
    Friend WithEvents TextBox1_Izena As TextBox
    Friend WithEvents Label1_Deskribapena As Label
    Friend WithEvents RichTextBox1_Deskribapena As RichTextBox
    Friend WithEvents Label1_Ostatu_mota As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1_Logela_kop As Label
    Friend WithEvents NumericUpDown1_Logela_kop As NumericUpDown
End Class
