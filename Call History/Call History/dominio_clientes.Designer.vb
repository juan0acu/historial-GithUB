<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dominio_clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dominio_clientes))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bot_atras = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tx_cliente_id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.data_servicio_cliente = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bot_editar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_servicio_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.bot_atras)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(191, 350)
        Me.Panel1.TabIndex = 5
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
        Me.bot_atras.Location = New System.Drawing.Point(6, 308)
        Me.bot_atras.Name = "bot_atras"
        Me.bot_atras.Size = New System.Drawing.Size(44, 38)
        Me.bot_atras.TabIndex = 19
        Me.bot_atras.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(89, 309)
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
        'tx_cliente_id
        '
        Me.tx_cliente_id.BackColor = System.Drawing.Color.White
        Me.tx_cliente_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tx_cliente_id.Enabled = False
        Me.tx_cliente_id.Font = New System.Drawing.Font("Segoe UI Emoji", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_cliente_id.Location = New System.Drawing.Point(417, 36)
        Me.tx_cliente_id.Name = "tx_cliente_id"
        Me.tx_cliente_id.Size = New System.Drawing.Size(219, 28)
        Me.tx_cliente_id.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(312, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 26)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Cliente"
        '
        'data_servicio_cliente
        '
        Me.data_servicio_cliente.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.data_servicio_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.data_servicio_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_servicio_cliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column1, Me.Column4, Me.Column2})
        Me.data_servicio_cliente.GridColor = System.Drawing.Color.Red
        Me.data_servicio_cliente.Location = New System.Drawing.Point(196, 91)
        Me.data_servicio_cliente.Name = "data_servicio_cliente"
        Me.data_servicio_cliente.Size = New System.Drawing.Size(644, 193)
        Me.data_servicio_cliente.TabIndex = 14
        '
        'Column3
        '
        Me.Column3.HeaderText = "Dominio"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 215
        '
        'Column1
        '
        Me.Column1.HeaderText = "Servicio"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 215
        '
        'Column4
        '
        Me.Column4.HeaderText = "Panel"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 165
        '
        'Column2
        '
        Me.Column2.HeaderText = "id_servicio"
        Me.Column2.Name = "Column2"
        Me.Column2.Visible = False
        Me.Column2.Width = 150
        '
        'bot_editar
        '
        Me.bot_editar.BackColor = System.Drawing.Color.LawnGreen
        Me.bot_editar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_editar.FlatAppearance.BorderSize = 0
        Me.bot_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen
        Me.bot_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.bot_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bot_editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bot_editar.ForeColor = System.Drawing.Color.White
        Me.bot_editar.Image = CType(resources.GetObject("bot_editar.Image"), System.Drawing.Image)
        Me.bot_editar.Location = New System.Drawing.Point(836, 95)
        Me.bot_editar.Name = "bot_editar"
        Me.bot_editar.Size = New System.Drawing.Size(44, 38)
        Me.bot_editar.TabIndex = 27
        Me.bot_editar.UseVisualStyleBackColor = False
        '
        'dominio_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(885, 347)
        Me.Controls.Add(Me.bot_editar)
        Me.Controls.Add(Me.data_servicio_cliente)
        Me.Controls.Add(Me.tx_cliente_id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dominio_clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servicios Clientes"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_servicio_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents bot_atras As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tx_cliente_id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents data_servicio_cliente As DataGridView
    Friend WithEvents bot_editar As Button
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
