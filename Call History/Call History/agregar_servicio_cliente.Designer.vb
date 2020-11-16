<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregar_servicio_cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(agregar_servicio_cliente))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bot_atras = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tx_dominio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tx_cliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_panel = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.data_servicio = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bot_cancelar = New System.Windows.Forms.Button()
        Me.bot_asociar = New System.Windows.Forms.Button()
        Me.tx_id_cliente = New System.Windows.Forms.TextBox()
        Me.lis_panel = New System.Windows.Forms.ListBox()
        Me.bot_ver_dominios = New System.Windows.Forms.Button()
        Me.date_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_servicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.bot_atras)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(191, 454)
        Me.Panel1.TabIndex = 4
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
        Me.bot_atras.Location = New System.Drawing.Point(6, 408)
        Me.bot_atras.Name = "bot_atras"
        Me.bot_atras.Size = New System.Drawing.Size(44, 38)
        Me.bot_atras.TabIndex = 19
        Me.bot_atras.UseVisualStyleBackColor = False
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
        'tx_dominio
        '
        Me.tx_dominio.BackColor = System.Drawing.Color.White
        Me.tx_dominio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tx_dominio.Font = New System.Drawing.Font("Segoe UI Emoji", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_dominio.Location = New System.Drawing.Point(310, 44)
        Me.tx_dominio.Name = "tx_dominio"
        Me.tx_dominio.Size = New System.Drawing.Size(219, 28)
        Me.tx_dominio.TabIndex = 7
        Me.tx_dominio.Text = "dominio.cl"
        Me.tx_dominio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(205, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 26)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Dominio"
        '
        'tx_cliente
        '
        Me.tx_cliente.BackColor = System.Drawing.Color.White
        Me.tx_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tx_cliente.Enabled = False
        Me.tx_cliente.Font = New System.Drawing.Font("Segoe UI Emoji", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_cliente.Location = New System.Drawing.Point(310, 97)
        Me.tx_cliente.Name = "tx_cliente"
        Me.tx_cliente.Size = New System.Drawing.Size(219, 28)
        Me.tx_cliente.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(205, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 26)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cliente"
        '
        'cb_panel
        '
        Me.cb_panel.BackColor = System.Drawing.Color.White
        Me.cb_panel.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_panel.FormattingEnabled = True
        Me.cb_panel.Location = New System.Drawing.Point(310, 153)
        Me.cb_panel.Name = "cb_panel"
        Me.cb_panel.Size = New System.Drawing.Size(201, 34)
        Me.cb_panel.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(205, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 26)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Panel"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(205, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 26)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Servicios"
        '
        'data_servicio
        '
        Me.data_servicio.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.data_servicio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.data_servicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_servicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.data_servicio.GridColor = System.Drawing.Color.Red
        Me.data_servicio.Location = New System.Drawing.Point(210, 252)
        Me.data_servicio.Name = "data_servicio"
        Me.data_servicio.Size = New System.Drawing.Size(493, 193)
        Me.data_servicio.TabIndex = 13
        '
        'Column1
        '
        Me.Column1.HeaderText = "Servicio"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 450
        '
        'Column2
        '
        Me.Column2.HeaderText = "id_servicio"
        Me.Column2.Name = "Column2"
        Me.Column2.Visible = False
        Me.Column2.Width = 150
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
        Me.bot_cancelar.Location = New System.Drawing.Point(686, 193)
        Me.bot_cancelar.Name = "bot_cancelar"
        Me.bot_cancelar.Size = New System.Drawing.Size(91, 31)
        Me.bot_cancelar.TabIndex = 23
        Me.bot_cancelar.Text = "Cancelar"
        Me.bot_cancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bot_cancelar.UseVisualStyleBackColor = False
        '
        'bot_asociar
        '
        Me.bot_asociar.BackColor = System.Drawing.Color.LawnGreen
        Me.bot_asociar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_asociar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen
        Me.bot_asociar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson
        Me.bot_asociar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bot_asociar.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bot_asociar.ForeColor = System.Drawing.Color.Black
        Me.bot_asociar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bot_asociar.Location = New System.Drawing.Point(686, 135)
        Me.bot_asociar.Name = "bot_asociar"
        Me.bot_asociar.Size = New System.Drawing.Size(91, 31)
        Me.bot_asociar.TabIndex = 22
        Me.bot_asociar.Text = "Asociar"
        Me.bot_asociar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bot_asociar.UseVisualStyleBackColor = False
        '
        'tx_id_cliente
        '
        Me.tx_id_cliente.BackColor = System.Drawing.Color.White
        Me.tx_id_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tx_id_cliente.Font = New System.Drawing.Font("Segoe UI Emoji", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_id_cliente.Location = New System.Drawing.Point(729, 42)
        Me.tx_id_cliente.Name = "tx_id_cliente"
        Me.tx_id_cliente.Size = New System.Drawing.Size(48, 28)
        Me.tx_id_cliente.TabIndex = 24
        Me.tx_id_cliente.Visible = False
        '
        'lis_panel
        '
        Me.lis_panel.FormattingEnabled = True
        Me.lis_panel.Location = New System.Drawing.Point(546, 129)
        Me.lis_panel.Name = "lis_panel"
        Me.lis_panel.Size = New System.Drawing.Size(120, 95)
        Me.lis_panel.TabIndex = 25
        Me.lis_panel.Visible = False
        '
        'bot_ver_dominios
        '
        Me.bot_ver_dominios.BackColor = System.Drawing.Color.LawnGreen
        Me.bot_ver_dominios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_ver_dominios.FlatAppearance.BorderSize = 0
        Me.bot_ver_dominios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen
        Me.bot_ver_dominios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.bot_ver_dominios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bot_ver_dominios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bot_ver_dominios.ForeColor = System.Drawing.Color.White
        Me.bot_ver_dominios.Image = CType(resources.GetObject("bot_ver_dominios.Image"), System.Drawing.Image)
        Me.bot_ver_dominios.Location = New System.Drawing.Point(713, 76)
        Me.bot_ver_dominios.Name = "bot_ver_dominios"
        Me.bot_ver_dominios.Size = New System.Drawing.Size(44, 38)
        Me.bot_ver_dominios.TabIndex = 26
        Me.bot_ver_dominios.UseVisualStyleBackColor = False
        '
        'date_fecha
        '
        Me.date_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_fecha.Location = New System.Drawing.Point(457, 377)
        Me.date_fecha.Name = "date_fecha"
        Me.date_fecha.Size = New System.Drawing.Size(98, 20)
        Me.date_fecha.TabIndex = 27
        Me.date_fecha.Visible = False
        '
        'agregar_servicio_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.date_fecha)
        Me.Controls.Add(Me.bot_ver_dominios)
        Me.Controls.Add(Me.lis_panel)
        Me.Controls.Add(Me.tx_id_cliente)
        Me.Controls.Add(Me.bot_cancelar)
        Me.Controls.Add(Me.bot_asociar)
        Me.Controls.Add(Me.data_servicio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cb_panel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tx_cliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tx_dominio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "agregar_servicio_cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Servicio a Cliente"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_servicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents bot_atras As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tx_dominio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tx_cliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_panel As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents data_servicio As DataGridView
    Friend WithEvents bot_cancelar As Button
    Friend WithEvents bot_asociar As Button
    Friend WithEvents tx_id_cliente As TextBox
    Friend WithEvents lis_panel As ListBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents bot_ver_dominios As Button
    Friend WithEvents date_fecha As DateTimePicker
End Class
