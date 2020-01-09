<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.erabiltzaile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pasahitza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefonoa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Erabiltzaile_mota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IzenAbizenak = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.erabiltzaile, Me.pasahitza, Me.mail, Me.telefonoa, Me.Erabiltzaile_mota, Me.IzenAbizenak})
        Me.DataGridView1.Location = New System.Drawing.Point(57, 35)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(978, 543)
        Me.DataGridView1.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "ID erabiltzaile"
        Me.ID.Name = "ID"
        '
        'erabiltzaile
        '
        Me.erabiltzaile.HeaderText = "Erabiltzailea"
        Me.erabiltzaile.Name = "erabiltzaile"
        '
        'pasahitza
        '
        Me.pasahitza.HeaderText = "pasahitza"
        Me.pasahitza.Name = "pasahitza"
        '
        'mail
        '
        Me.mail.HeaderText = "Emaila"
        Me.mail.Name = "mail"
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
        'Erabiltzaileak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1093, 623)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Erabiltzaileak"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents erabiltzaile As DataGridViewTextBoxColumn
    Friend WithEvents pasahitza As DataGridViewTextBoxColumn
    Friend WithEvents mail As DataGridViewTextBoxColumn
    Friend WithEvents telefonoa As DataGridViewTextBoxColumn
    Friend WithEvents Erabiltzaile_mota As DataGridViewTextBoxColumn
    Friend WithEvents IzenAbizenak As DataGridViewTextBoxColumn
End Class
