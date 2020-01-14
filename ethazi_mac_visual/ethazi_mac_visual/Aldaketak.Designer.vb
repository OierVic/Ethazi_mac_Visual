<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aldaketak
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
        Me.TextBox1_Id = New System.Windows.Forms.TextBox()
        Me.Label1_Titulua = New System.Windows.Forms.Label()
        Me.Label1_Id = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1_Id
        '
        Me.TextBox1_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_Id.Location = New System.Drawing.Point(67, 93)
        Me.TextBox1_Id.Name = "TextBox1_Id"
        Me.TextBox1_Id.Size = New System.Drawing.Size(117, 26)
        Me.TextBox1_Id.TabIndex = 0
        '
        'Label1_Titulua
        '
        Me.Label1_Titulua.AutoSize = True
        Me.Label1_Titulua.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Titulua.Location = New System.Drawing.Point(343, 19)
        Me.Label1_Titulua.Name = "Label1_Titulua"
        Me.Label1_Titulua.Size = New System.Drawing.Size(122, 46)
        Me.Label1_Titulua.TabIndex = 1
        Me.Label1_Titulua.Text = "Tituloa"
        '
        'Label1_Id
        '
        Me.Label1_Id.AutoSize = True
        Me.Label1_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Id.Location = New System.Drawing.Point(30, 93)
        Me.Label1_Id.Name = "Label1_Id"
        Me.Label1_Id.Size = New System.Drawing.Size(31, 20)
        Me.Label1_Id.TabIndex = 2
        Me.Label1_Id.Text = "Id :"
        '
        'Aldaketak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(842, 545)
        Me.Controls.Add(Me.Label1_Id)
        Me.Controls.Add(Me.Label1_Titulua)
        Me.Controls.Add(Me.TextBox1_Id)
        Me.Name = "Aldaketak"
        Me.Text = "Aldaketak"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1_Id As TextBox
    Friend WithEvents Label1_Titulua As Label
    Friend WithEvents Label1_Id As Label
End Class
