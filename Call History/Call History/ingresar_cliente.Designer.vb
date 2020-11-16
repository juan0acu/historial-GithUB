<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ingresar_cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ingresar_cliente))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comb_tipo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_observacion = New System.Windows.Forms.TextBox()
        Me.Bot_aceptar = New System.Windows.Forms.Button()
        Me.bot_cancelar = New System.Windows.Forms.Button()
        Me.list_tipo = New System.Windows.Forms.ListBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(16, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 104)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-4, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(191, 454)
        Me.Panel1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LawnGreen
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(6, 408)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 38)
        Me.Button1.TabIndex = 19
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(89, 409)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 38)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(340, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Número"
        '
        'txt_numero
        '
        Me.txt_numero.BackColor = System.Drawing.Color.White
        Me.txt_numero.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_numero.Font = New System.Drawing.Font("Segoe UI Emoji", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero.Location = New System.Drawing.Point(445, 50)
        Me.txt_numero.MaxLength = 9
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(201, 28)
        Me.txt_numero.TabIndex = 5
        Me.txt_numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(273, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tipo de Cliente"
        Me.Label2.Visible = False
        '
        'comb_tipo
        '
        Me.comb_tipo.BackColor = System.Drawing.Color.White
        Me.comb_tipo.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comb_tipo.FormattingEnabled = True
        Me.comb_tipo.Location = New System.Drawing.Point(445, 101)
        Me.comb_tipo.Name = "comb_tipo"
        Me.comb_tipo.Size = New System.Drawing.Size(201, 34)
        Me.comb_tipo.TabIndex = 8
        Me.comb_tipo.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(299, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 26)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Observación"
        Me.Label3.Visible = False
        '
        'txt_observacion
        '
        Me.txt_observacion.BackColor = System.Drawing.Color.White
        Me.txt_observacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_observacion.Font = New System.Drawing.Font("Segoe UI Emoji", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_observacion.Location = New System.Drawing.Point(445, 169)
        Me.txt_observacion.Multiline = True
        Me.txt_observacion.Name = "txt_observacion"
        Me.txt_observacion.Size = New System.Drawing.Size(230, 124)
        Me.txt_observacion.TabIndex = 10
        Me.txt_observacion.Text = "Clien Nuevo"
        Me.txt_observacion.Visible = False
        '
        'Bot_aceptar
        '
        Me.Bot_aceptar.BackColor = System.Drawing.Color.LawnGreen
        Me.Bot_aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen
        Me.Bot_aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson
        Me.Bot_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_aceptar.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_aceptar.ForeColor = System.Drawing.Color.Black
        Me.Bot_aceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bot_aceptar.Location = New System.Drawing.Point(348, 353)
        Me.Bot_aceptar.Name = "Bot_aceptar"
        Me.Bot_aceptar.Size = New System.Drawing.Size(91, 31)
        Me.Bot_aceptar.TabIndex = 20
        Me.Bot_aceptar.Text = "Aceptar"
        Me.Bot_aceptar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bot_aceptar.UseVisualStyleBackColor = False
        '
        'bot_cancelar
        '
        Me.bot_cancelar.BackColor = System.Drawing.Color.Red
        Me.bot_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.bot_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson
        Me.bot_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bot_cancelar.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bot_cancelar.ForeColor = System.Drawing.Color.Black
        Me.bot_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bot_cancelar.Location = New System.Drawing.Point(555, 353)
        Me.bot_cancelar.Name = "bot_cancelar"
        Me.bot_cancelar.Size = New System.Drawing.Size(91, 31)
        Me.bot_cancelar.TabIndex = 21
        Me.bot_cancelar.Text = "Cancelar"
        Me.bot_cancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bot_cancelar.UseVisualStyleBackColor = False
        '
        'list_tipo
        '
        Me.list_tipo.FormattingEnabled = True
        Me.list_tipo.Location = New System.Drawing.Point(668, 50)
        Me.list_tipo.Name = "list_tipo"
        Me.list_tipo.Size = New System.Drawing.Size(120, 95)
        Me.list_tipo.TabIndex = 22
        Me.list_tipo.Visible = False
        '
        'ingresar_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.list_tipo)
        Me.Controls.Add(Me.bot_cancelar)
        Me.Controls.Add(Me.Bot_aceptar)
        Me.Controls.Add(Me.txt_observacion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.comb_tipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_numero)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ingresar_cliente"
        Me.Opacity = 0.85R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ingresar Nuevo Cliente"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents comb_tipo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_observacion As TextBox
    Friend WithEvents Bot_aceptar As Button
    Friend WithEvents bot_cancelar As Button
    Friend WithEvents list_tipo As ListBox
End Class
