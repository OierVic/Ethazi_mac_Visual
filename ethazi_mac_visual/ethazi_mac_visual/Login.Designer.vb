<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1_Login = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1_User = New System.Windows.Forms.TextBox()
        Me.TextBox1_Password = New System.Windows.Forms.TextBox()
        Me.PictureBox2_Password = New System.Windows.Forms.PictureBox()
        Me.PictureBox1_User = New System.Windows.Forms.PictureBox()
        Me.Label1_Administrazio_Aplikazioa = New System.Windows.Forms.Label()
        CType(Me.PictureBox2_Password, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1_User, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1_Login
        '
        Me.Label1_Login.AutoSize = True
        Me.Label1_Login.BackColor = System.Drawing.Color.White
        Me.Label1_Login.Font = New System.Drawing.Font("MV Boli", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Login.ForeColor = System.Drawing.Color.Blue
        Me.Label1_Login.Location = New System.Drawing.Point(454, 69)
        Me.Label1_Login.Name = "Label1_Login"
        Me.Label1_Login.Size = New System.Drawing.Size(178, 79)
        Me.Label1_Login.TabIndex = 0
        Me.Label1_Login.Text = "Login"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("MV Boli", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(447, 360)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(185, 56)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1_User
        '
        Me.TextBox1_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_User.Location = New System.Drawing.Point(410, 200)
        Me.TextBox1_User.Name = "TextBox1_User"
        Me.TextBox1_User.Size = New System.Drawing.Size(333, 30)
        Me.TextBox1_User.TabIndex = 3
        '
        'TextBox1_Password
        '
        Me.TextBox1_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_Password.Location = New System.Drawing.Point(410, 278)
        Me.TextBox1_Password.Name = "TextBox1_Password"
        Me.TextBox1_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1_Password.Size = New System.Drawing.Size(333, 30)
        Me.TextBox1_Password.TabIndex = 5
        '
        'PictureBox2_Password
        '
        Me.PictureBox2_Password.Image = Global.ethazi_mac_visual.My.Resources.Resources.kisspng_password
        Me.PictureBox2_Password.Location = New System.Drawing.Point(293, 267)
        Me.PictureBox2_Password.Name = "PictureBox2_Password"
        Me.PictureBox2_Password.Size = New System.Drawing.Size(76, 50)
        Me.PictureBox2_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2_Password.TabIndex = 7
        Me.PictureBox2_Password.TabStop = False
        '
        'PictureBox1_User
        '
        Me.PictureBox1_User.Image = Global.ethazi_mac_visual.My.Resources.Resources.user_icon
        Me.PictureBox1_User.Location = New System.Drawing.Point(293, 187)
        Me.PictureBox1_User.Name = "PictureBox1_User"
        Me.PictureBox1_User.Size = New System.Drawing.Size(76, 59)
        Me.PictureBox1_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1_User.TabIndex = 6
        Me.PictureBox1_User.TabStop = False
        '
        'Label1_Administrazio_Aplikazioa
        '
        Me.Label1_Administrazio_Aplikazioa.AutoSize = True
        Me.Label1_Administrazio_Aplikazioa.BackColor = System.Drawing.Color.White
        Me.Label1_Administrazio_Aplikazioa.Font = New System.Drawing.Font("Segoe UI Black", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_Administrazio_Aplikazioa.Location = New System.Drawing.Point(22, 23)
        Me.Label1_Administrazio_Aplikazioa.Name = "Label1_Administrazio_Aplikazioa"
        Me.Label1_Administrazio_Aplikazioa.Size = New System.Drawing.Size(349, 37)
        Me.Label1_Administrazio_Aplikazioa.TabIndex = 8
        Me.Label1_Administrazio_Aplikazioa.Text = "Administrazio Aplikazioa"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.ethazi_mac_visual.My.Resources.Resources.Fondo_Imagen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1093, 623)
        Me.Controls.Add(Me.Label1_Administrazio_Aplikazioa)
        Me.Controls.Add(Me.PictureBox2_Password)
        Me.Controls.Add(Me.PictureBox1_User)
        Me.Controls.Add(Me.TextBox1_Password)
        Me.Controls.Add(Me.TextBox1_User)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1_Login)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox2_Password, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1_User, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1_Login As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1_User As TextBox
    Friend WithEvents TextBox1_Password As TextBox
    Friend WithEvents PictureBox1_User As PictureBox
    Friend WithEvents PictureBox2_Password As PictureBox
    Friend WithEvents Label1_Administrazio_Aplikazioa As Label
End Class
