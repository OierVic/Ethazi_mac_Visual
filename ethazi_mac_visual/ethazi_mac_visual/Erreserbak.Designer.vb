<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Erreserbak
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Erreserbak))
        Me.Label1_Administrazio_Aplikazioa = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id_Erreserba = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_Ostatu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_Erabiltzaile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Erreserba_data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1_Atzera = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1_Administrazio_Aplikazioa
        '
        Me.Label1_Administrazio_Aplikazioa.AutoSize = True
        Me.Label1_Administrazio_Aplikazioa.BackColor = System.Drawing.Color.White
        Me.Label1_Administrazio_Aplikazioa.Font = New System.Drawing.Font("Segoe UI Black", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Administrazio_Aplikazioa.Location = New System.Drawing.Point(766, 18)
        Me.Label1_Administrazio_Aplikazioa.Name = "Label1_Administrazio_Aplikazioa"
        Me.Label1_Administrazio_Aplikazioa.Size = New System.Drawing.Size(260, 28)
        Me.Label1_Administrazio_Aplikazioa.TabIndex = 10
        Me.Label1_Administrazio_Aplikazioa.Text = "Administrazio Aplikazioa"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Erreserba, Me.id_Ostatu, Me.id_Erabiltzaile, Me.Erreserba_data})
        Me.DataGridView1.Location = New System.Drawing.Point(51, 79)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1015, 419)
        Me.DataGridView1.TabIndex = 11
        '
        'id_Erreserba
        '
        Me.id_Erreserba.HeaderText = "ID Erreserba"
        Me.id_Erreserba.Name = "id_Erreserba"
        Me.id_Erreserba.Width = 75
        '
        'id_Ostatu
        '
        Me.id_Ostatu.HeaderText = "ID Ostatu"
        Me.id_Ostatu.Name = "id_Ostatu"
        Me.id_Ostatu.Width = 200
        '
        'id_Erabiltzaile
        '
        Me.id_Erabiltzaile.HeaderText = "ID Erabiltzaile"
        Me.id_Erabiltzaile.Name = "id_Erabiltzaile"
        Me.id_Erabiltzaile.Width = 350
        '
        'Erreserba_data
        '
        Me.Erreserba_data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Erreserba_data.HeaderText = "Erreserba Data"
        Me.Erreserba_data.Name = "Erreserba_data"
        '
        'Button1_Atzera
        '
        Me.Button1_Atzera.BackgroundImage = Global.ethazi_mac_visual.My.Resources.Resources.return_logo_SinFondo
        Me.Button1_Atzera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1_Atzera.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1_Atzera.Location = New System.Drawing.Point(85, 535)
        Me.Button1_Atzera.Name = "Button1_Atzera"
        Me.Button1_Atzera.Size = New System.Drawing.Size(64, 58)
        Me.Button1_Atzera.TabIndex = 12
        Me.Button1_Atzera.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1_Atzera.UseVisualStyleBackColor = True
        '
        'Erreserbak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1093, 623)
        Me.Controls.Add(Me.Button1_Atzera)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1_Administrazio_Aplikazioa)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Erreserbak"
        Me.Text = "Erreserbak"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1_Administrazio_Aplikazioa As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents id_Erreserba As DataGridViewTextBoxColumn
    Friend WithEvents id_Ostatu As DataGridViewTextBoxColumn
    Friend WithEvents id_Erabiltzaile As DataGridViewTextBoxColumn
    Friend WithEvents Erreserba_data As DataGridViewTextBoxColumn
    Friend WithEvents Button1_Atzera As Button
End Class
