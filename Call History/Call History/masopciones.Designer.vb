<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class masopciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(masopciones))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bot_atras = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bot_agregar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.bot_atras)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(101, 760)
        Me.Panel1.TabIndex = 1
        '
        'bot_atras
        '
        Me.bot_atras.BackColor = System.Drawing.Color.LawnGreen
        Me.bot_atras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_atras.FlatAppearance.BorderSize = 0
        Me.bot_atras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen
        Me.bot_atras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.bot_atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bot_atras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bot_atras.ForeColor = System.Drawing.Color.White
        Me.bot_atras.Image = CType(resources.GetObject("bot_atras.Image"), System.Drawing.Image)
        Me.bot_atras.Location = New System.Drawing.Point(0, 723)
        Me.bot_atras.Name = "bot_atras"
        Me.bot_atras.Size = New System.Drawing.Size(44, 38)
        Me.bot_atras.TabIndex = 20
        Me.bot_atras.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(1, 685)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 38)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 89)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel2.Location = New System.Drawing.Point(128, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 55)
        Me.Panel2.TabIndex = 13
        '
        'bot_agregar
        '
        Me.bot_agregar.BackColor = System.Drawing.Color.Red
        Me.bot_agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_agregar.FlatAppearance.BorderSize = 0
        Me.bot_agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.bot_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen
        Me.bot_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bot_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bot_agregar.ForeColor = System.Drawing.Color.White
        Me.bot_agregar.Image = CType(resources.GetObject("bot_agregar.Image"), System.Drawing.Image)
        Me.bot_agregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bot_agregar.Location = New System.Drawing.Point(135, 54)
        Me.bot_agregar.Name = "bot_agregar"
        Me.bot_agregar.Size = New System.Drawing.Size(123, 55)
        Me.bot_agregar.TabIndex = 14
        Me.bot_agregar.Text = "Ver Servicios"
        Me.bot_agregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bot_agregar.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel3.Location = New System.Drawing.Point(298, 54)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 55)
        Me.Panel3.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(305, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 55)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "+ Servicios"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'masopciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(795, 759)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.bot_agregar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "masopciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Más Opciones"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bot_atras As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents bot_agregar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
End Class
