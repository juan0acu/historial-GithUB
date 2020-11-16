<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ingresar_sistema
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ingresar_sistema))
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.bot_mostra_clave = New System.Windows.Forms.PictureBox()
        Me.bot_ingresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.text_contrasena = New System.Windows.Forms.TextBox()
        Me.text_usuario = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bot_minimizar = New System.Windows.Forms.PictureBox()
        Me.bot_cerrar = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_mostra_clave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Location = New System.Drawing.Point(1, -1)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(289, 330)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'bot_mostra_clave
        '
        Me.bot_mostra_clave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_mostra_clave.Image = CType(resources.GetObject("bot_mostra_clave.Image"), System.Drawing.Image)
        Me.bot_mostra_clave.Location = New System.Drawing.Point(710, 166)
        Me.bot_mostra_clave.Name = "bot_mostra_clave"
        Me.bot_mostra_clave.Size = New System.Drawing.Size(30, 30)
        Me.bot_mostra_clave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bot_mostra_clave.TabIndex = 15
        Me.bot_mostra_clave.TabStop = False
        '
        'bot_ingresar
        '
        Me.bot_ingresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bot_ingresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_ingresar.FlatAppearance.BorderSize = 0
        Me.bot_ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.bot_ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bot_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bot_ingresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bot_ingresar.ForeColor = System.Drawing.Color.White
        Me.bot_ingresar.Location = New System.Drawing.Point(297, 237)
        Me.bot_ingresar.Name = "bot_ingresar"
        Me.bot_ingresar.Size = New System.Drawing.Size(441, 40)
        Me.bot_ingresar.TabIndex = 11
        Me.bot_ingresar.Text = "ACCEDER"
        Me.bot_ingresar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(291, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 33)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "LOGIN"
        '
        'text_contrasena
        '
        Me.text_contrasena.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.text_contrasena.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.text_contrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_contrasena.ForeColor = System.Drawing.Color.DimGray
        Me.text_contrasena.Location = New System.Drawing.Point(297, 169)
        Me.text_contrasena.Name = "text_contrasena"
        Me.text_contrasena.Size = New System.Drawing.Size(441, 22)
        Me.text_contrasena.TabIndex = 13
        Me.text_contrasena.Text = "CONTRASEÑA"
        Me.text_contrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'text_usuario
        '
        Me.text_usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.text_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.text_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_usuario.ForeColor = System.Drawing.Color.DimGray
        Me.text_usuario.Location = New System.Drawing.Point(297, 97)
        Me.text_usuario.Name = "text_usuario"
        Me.text_usuario.Size = New System.Drawing.Size(441, 22)
        Me.text_usuario.TabIndex = 12
        Me.text_usuario.Text = "USUARIO"
        Me.text_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(750, 330)
        Me.ShapeContainer1.TabIndex = 16
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.White
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 318
        Me.LineShape2.X2 = 733
        Me.LineShape2.Y1 = 209
        Me.LineShape2.Y2 = 209
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 315
        Me.LineShape1.X2 = 730
        Me.LineShape1.Y1 = 130
        Me.LineShape1.Y2 = 130
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(3, 285)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(92, 33)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'bot_minimizar
        '
        Me.bot_minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_minimizar.Image = CType(resources.GetObject("bot_minimizar.Image"), System.Drawing.Image)
        Me.bot_minimizar.Location = New System.Drawing.Point(701, 3)
        Me.bot_minimizar.Name = "bot_minimizar"
        Me.bot_minimizar.Size = New System.Drawing.Size(20, 20)
        Me.bot_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bot_minimizar.TabIndex = 19
        Me.bot_minimizar.TabStop = False
        '
        'bot_cerrar
        '
        Me.bot_cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_cerrar.Image = CType(resources.GetObject("bot_cerrar.Image"), System.Drawing.Image)
        Me.bot_cerrar.Location = New System.Drawing.Point(727, 3)
        Me.bot_cerrar.Name = "bot_cerrar"
        Me.bot_cerrar.Size = New System.Drawing.Size(20, 20)
        Me.bot_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bot_cerrar.TabIndex = 18
        Me.bot_cerrar.TabStop = False
        '
        'ingresar_sistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(750, 330)
        Me.Controls.Add(Me.bot_minimizar)
        Me.Controls.Add(Me.bot_cerrar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bot_mostra_clave)
        Me.Controls.Add(Me.bot_ingresar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.text_contrasena)
        Me.Controls.Add(Me.text_usuario)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ingresar_sistema"
        Me.Opacity = 0.8R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresar a Call History"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_mostra_clave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents bot_mostra_clave As PictureBox
    Friend WithEvents bot_ingresar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents text_contrasena As TextBox
    Friend WithEvents text_usuario As TextBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bot_minimizar As PictureBox
    Friend WithEvents bot_cerrar As PictureBox
End Class
