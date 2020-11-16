<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class agregar_caso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(agregar_caso))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.p_mod = New System.Windows.Forms.Panel()
        Me.bot_modificar = New System.Windows.Forms.Button()
        Me.bot_atras = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tx_descrip = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tx_numero = New System.Windows.Forms.TextBox()
        Me.tx_caso = New System.Windows.Forms.TextBox()
        Me.cb_status = New System.Windows.Forms.ComboBox()
        Me.date_fecha_caso = New System.Windows.Forms.DateTimePicker()
        Me.bot_cancelar = New System.Windows.Forms.Button()
        Me.Bot_aceptar = New System.Windows.Forms.Button()
        Me.tx_dominio = New System.Windows.Forms.TextBox()
        Me.list_status = New System.Windows.Forms.ListBox()
        Me.tx_servicio_cliente = New System.Windows.Forms.TextBox()
        Me.tx_id_cliente = New System.Windows.Forms.TextBox()
        Me.tx_llamadas = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.p_mod)
        Me.Panel1.Controls.Add(Me.bot_modificar)
        Me.Panel1.Controls.Add(Me.bot_atras)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(187, 505)
        Me.Panel1.TabIndex = 6
        '
        'p_mod
        '
        Me.p_mod.BackColor = System.Drawing.Color.LawnGreen
        Me.p_mod.Location = New System.Drawing.Point(23, 127)
        Me.p_mod.Name = "p_mod"
        Me.p_mod.Size = New System.Drawing.Size(10, 38)
        Me.p_mod.TabIndex = 20
        Me.p_mod.Visible = False
        '
        'bot_modificar
        '
        Me.bot_modificar.BackColor = System.Drawing.Color.Red
        Me.bot_modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_modificar.FlatAppearance.BorderSize = 0
        Me.bot_modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.bot_modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen
        Me.bot_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bot_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bot_modificar.ForeColor = System.Drawing.Color.White
        Me.bot_modificar.Image = CType(resources.GetObject("bot_modificar.Image"), System.Drawing.Image)
        Me.bot_modificar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.bot_modificar.Location = New System.Drawing.Point(30, 127)
        Me.bot_modificar.Name = "bot_modificar"
        Me.bot_modificar.Size = New System.Drawing.Size(140, 38)
        Me.bot_modificar.TabIndex = 21
        Me.bot_modificar.Text = "Modificar"
        Me.bot_modificar.UseVisualStyleBackColor = False
        Me.bot_modificar.Visible = False
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
        Me.bot_atras.Location = New System.Drawing.Point(4, 459)
        Me.bot_atras.Name = "bot_atras"
        Me.bot_atras.Size = New System.Drawing.Size(44, 38)
        Me.bot_atras.TabIndex = 19
        Me.bot_atras.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(84, 460)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 38)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(13, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 104)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(230, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 26)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(230, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 26)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Dominio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(230, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 26)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(613, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 26)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Fecha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(613, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 26)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Caso #"
        '
        'tx_descrip
        '
        Me.tx_descrip.Location = New System.Drawing.Point(235, 257)
        Me.tx_descrip.Multiline = True
        Me.tx_descrip.Name = "tx_descrip"
        Me.tx_descrip.Size = New System.Drawing.Size(636, 147)
        Me.tx_descrip.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(230, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(213, 26)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Información del caso:"
        '
        'tx_numero
        '
        Me.tx_numero.BackColor = System.Drawing.Color.White
        Me.tx_numero.Enabled = False
        Me.tx_numero.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_numero.ForeColor = System.Drawing.Color.Black
        Me.tx_numero.Location = New System.Drawing.Point(314, 30)
        Me.tx_numero.Name = "tx_numero"
        Me.tx_numero.Size = New System.Drawing.Size(182, 33)
        Me.tx_numero.TabIndex = 18
        Me.tx_numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tx_caso
        '
        Me.tx_caso.BackColor = System.Drawing.Color.White
        Me.tx_caso.Enabled = False
        Me.tx_caso.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_caso.ForeColor = System.Drawing.Color.Black
        Me.tx_caso.Location = New System.Drawing.Point(689, 30)
        Me.tx_caso.Name = "tx_caso"
        Me.tx_caso.Size = New System.Drawing.Size(110, 33)
        Me.tx_caso.TabIndex = 19
        Me.tx_caso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cb_status
        '
        Me.cb_status.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_status.FormattingEnabled = True
        Me.cb_status.Location = New System.Drawing.Point(322, 125)
        Me.cb_status.Name = "cb_status"
        Me.cb_status.Size = New System.Drawing.Size(159, 29)
        Me.cb_status.TabIndex = 21
        '
        'date_fecha_caso
        '
        Me.date_fecha_caso.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_fecha_caso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_fecha_caso.Location = New System.Drawing.Point(685, 81)
        Me.date_fecha_caso.Name = "date_fecha_caso"
        Me.date_fecha_caso.Size = New System.Drawing.Size(126, 29)
        Me.date_fecha_caso.TabIndex = 22
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
        Me.bot_cancelar.Location = New System.Drawing.Point(635, 442)
        Me.bot_cancelar.Name = "bot_cancelar"
        Me.bot_cancelar.Size = New System.Drawing.Size(91, 31)
        Me.bot_cancelar.TabIndex = 24
        Me.bot_cancelar.Text = "Cancelar"
        Me.bot_cancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bot_cancelar.UseVisualStyleBackColor = False
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
        Me.Bot_aceptar.Location = New System.Drawing.Point(428, 442)
        Me.Bot_aceptar.Name = "Bot_aceptar"
        Me.Bot_aceptar.Size = New System.Drawing.Size(91, 31)
        Me.Bot_aceptar.TabIndex = 23
        Me.Bot_aceptar.Text = "Aceptar"
        Me.Bot_aceptar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bot_aceptar.UseVisualStyleBackColor = False
        '
        'tx_dominio
        '
        Me.tx_dominio.BackColor = System.Drawing.Color.White
        Me.tx_dominio.Enabled = False
        Me.tx_dominio.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_dominio.ForeColor = System.Drawing.Color.Black
        Me.tx_dominio.Location = New System.Drawing.Point(327, 77)
        Me.tx_dominio.Name = "tx_dominio"
        Me.tx_dominio.Size = New System.Drawing.Size(182, 33)
        Me.tx_dominio.TabIndex = 25
        Me.tx_dominio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'list_status
        '
        Me.list_status.FormattingEnabled = True
        Me.list_status.Location = New System.Drawing.Point(517, 125)
        Me.list_status.Name = "list_status"
        Me.list_status.Size = New System.Drawing.Size(120, 95)
        Me.list_status.TabIndex = 26
        Me.list_status.Visible = False
        '
        'tx_servicio_cliente
        '
        Me.tx_servicio_cliente.BackColor = System.Drawing.Color.White
        Me.tx_servicio_cliente.Enabled = False
        Me.tx_servicio_cliente.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_servicio_cliente.ForeColor = System.Drawing.Color.Black
        Me.tx_servicio_cliente.Location = New System.Drawing.Point(809, 116)
        Me.tx_servicio_cliente.Name = "tx_servicio_cliente"
        Me.tx_servicio_cliente.Size = New System.Drawing.Size(110, 33)
        Me.tx_servicio_cliente.TabIndex = 27
        Me.tx_servicio_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tx_servicio_cliente.Visible = False
        '
        'tx_id_cliente
        '
        Me.tx_id_cliente.BackColor = System.Drawing.Color.White
        Me.tx_id_cliente.Enabled = False
        Me.tx_id_cliente.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_id_cliente.ForeColor = System.Drawing.Color.Black
        Me.tx_id_cliente.Location = New System.Drawing.Point(809, 155)
        Me.tx_id_cliente.Name = "tx_id_cliente"
        Me.tx_id_cliente.Size = New System.Drawing.Size(110, 33)
        Me.tx_id_cliente.TabIndex = 28
        Me.tx_id_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tx_id_cliente.Visible = False
        '
        'tx_llamadas
        '
        Me.tx_llamadas.BackColor = System.Drawing.Color.White
        Me.tx_llamadas.Enabled = False
        Me.tx_llamadas.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_llamadas.ForeColor = System.Drawing.Color.Black
        Me.tx_llamadas.Location = New System.Drawing.Point(827, 457)
        Me.tx_llamadas.Name = "tx_llamadas"
        Me.tx_llamadas.Size = New System.Drawing.Size(110, 33)
        Me.tx_llamadas.TabIndex = 29
        Me.tx_llamadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tx_llamadas.Visible = False
        '
        'agregar_caso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(949, 503)
        Me.Controls.Add(Me.tx_llamadas)
        Me.Controls.Add(Me.tx_id_cliente)
        Me.Controls.Add(Me.tx_servicio_cliente)
        Me.Controls.Add(Me.list_status)
        Me.Controls.Add(Me.tx_dominio)
        Me.Controls.Add(Me.bot_cancelar)
        Me.Controls.Add(Me.Bot_aceptar)
        Me.Controls.Add(Me.date_fecha_caso)
        Me.Controls.Add(Me.cb_status)
        Me.Controls.Add(Me.tx_caso)
        Me.Controls.Add(Me.tx_numero)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tx_descrip)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "agregar_caso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Caso"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents bot_atras As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents p_mod As Panel
    Friend WithEvents bot_modificar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tx_descrip As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tx_numero As TextBox
    Friend WithEvents tx_caso As TextBox
    Friend WithEvents cb_status As ComboBox
    Friend WithEvents date_fecha_caso As DateTimePicker
    Friend WithEvents bot_cancelar As Button
    Friend WithEvents Bot_aceptar As Button
    Friend WithEvents tx_dominio As TextBox
    Friend WithEvents list_status As ListBox
    Friend WithEvents tx_servicio_cliente As TextBox
    Friend WithEvents tx_id_cliente As TextBox
    Friend WithEvents tx_llamadas As TextBox
End Class
