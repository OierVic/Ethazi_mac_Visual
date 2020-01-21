<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ostatuak
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ostatuak))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1_Administrazio_Aplikazioa = New System.Windows.Forms.Label()
        Me.Button1_Atzera = New System.Windows.Forms.Button()
        Me.Button1_Gehitu = New System.Windows.Forms.Button()
        Me.ID_Ostatu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.izena = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deskribapena = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ostatu_Mota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Logela_Kopurua = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kokapena = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefonoa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Emaila = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Latitudea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Longitudea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prezioa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Ostatu, Me.izena, Me.deskribapena, Me.Ostatu_Mota, Me.Logela_Kopurua, Me.Kokapena, Me.Telefonoa, Me.Emaila, Me.Latitudea, Me.Longitudea, Me.Prezioa})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1069, 464)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1_Administrazio_Aplikazioa
        '
        Me.Label1_Administrazio_Aplikazioa.AutoSize = True
        Me.Label1_Administrazio_Aplikazioa.BackColor = System.Drawing.Color.White
        Me.Label1_Administrazio_Aplikazioa.Font = New System.Drawing.Font("Segoe UI Black", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Administrazio_Aplikazioa.Location = New System.Drawing.Point(739, 9)
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
        Me.Button1_Atzera.Location = New System.Drawing.Point(62, 537)
        Me.Button1_Atzera.Name = "Button1_Atzera"
        Me.Button1_Atzera.Size = New System.Drawing.Size(64, 58)
        Me.Button1_Atzera.TabIndex = 10
        Me.Button1_Atzera.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1_Atzera.UseVisualStyleBackColor = True
        '
        'Button1_Gehitu
        '
        Me.Button1_Gehitu.BackgroundImage = Global.ethazi_mac_visual.My.Resources.Resources.SumaSymbol
        Me.Button1_Gehitu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1_Gehitu.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1_Gehitu.Location = New System.Drawing.Point(540, 537)
        Me.Button1_Gehitu.Name = "Button1_Gehitu"
        Me.Button1_Gehitu.Size = New System.Drawing.Size(70, 58)
        Me.Button1_Gehitu.TabIndex = 13
        Me.Button1_Gehitu.UseVisualStyleBackColor = True
        '
        'ID_Ostatu
        '
        Me.ID_Ostatu.HeaderText = "ID Ostatu"
        Me.ID_Ostatu.Name = "ID_Ostatu"
        Me.ID_Ostatu.Width = 50
        '
        'izena
        '
        Me.izena.HeaderText = "Izena"
        Me.izena.Name = "izena"
        '
        'deskribapena
        '
        Me.deskribapena.HeaderText = "Deskribapena"
        Me.deskribapena.Name = "deskribapena"
        Me.deskribapena.Width = 175
        '
        'Ostatu_Mota
        '
        Me.Ostatu_Mota.HeaderText = "Ostatu Mota"
        Me.Ostatu_Mota.Name = "Ostatu_Mota"
        Me.Ostatu_Mota.Width = 75
        '
        'Logela_Kopurua
        '
        Me.Logela_Kopurua.HeaderText = "Logela Kopurua"
        Me.Logela_Kopurua.Name = "Logela_Kopurua"
        Me.Logela_Kopurua.Width = 50
        '
        'Kokapena
        '
        Me.Kokapena.HeaderText = "Kokapena"
        Me.Kokapena.Name = "Kokapena"
        Me.Kokapena.Width = 150
        '
        'Telefonoa
        '
        Me.Telefonoa.HeaderText = "Telefonoa"
        Me.Telefonoa.Name = "Telefonoa"
        Me.Telefonoa.Width = 75
        '
        'Emaila
        '
        Me.Emaila.HeaderText = "Email"
        Me.Emaila.Name = "Emaila"
        Me.Emaila.Width = 125
        '
        'Latitudea
        '
        Me.Latitudea.HeaderText = "Latitudea"
        Me.Latitudea.Name = "Latitudea"
        Me.Latitudea.Width = 75
        '
        'Longitudea
        '
        Me.Longitudea.HeaderText = "Longitudea"
        Me.Longitudea.Name = "Longitudea"
        Me.Longitudea.Width = 75
        '
        'Prezioa
        '
        Me.Prezioa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Prezioa.HeaderText = "Prezioa €"
        Me.Prezioa.Name = "Prezioa"
        '
        'Ostatuak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1093, 623)
        Me.Controls.Add(Me.Button1_Gehitu)
        Me.Controls.Add(Me.Button1_Atzera)
        Me.Controls.Add(Me.Label1_Administrazio_Aplikazioa)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ostatuak"
        Me.Text = "Ostatuak"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1_Administrazio_Aplikazioa As Label
    Friend WithEvents Button1_Atzera As Button
    Friend WithEvents Button1_Gehitu As Button
    Friend WithEvents ID_Ostatu As DataGridViewTextBoxColumn
    Friend WithEvents izena As DataGridViewTextBoxColumn
    Friend WithEvents deskribapena As DataGridViewTextBoxColumn
    Friend WithEvents Ostatu_Mota As DataGridViewTextBoxColumn
    Friend WithEvents Logela_Kopurua As DataGridViewTextBoxColumn
    Friend WithEvents Kokapena As DataGridViewTextBoxColumn
    Friend WithEvents Telefonoa As DataGridViewTextBoxColumn
    Friend WithEvents Emaila As DataGridViewTextBoxColumn
    Friend WithEvents Latitudea As DataGridViewTextBoxColumn
    Friend WithEvents Longitudea As DataGridViewTextBoxColumn
    Friend WithEvents Prezioa As DataGridViewTextBoxColumn
End Class
