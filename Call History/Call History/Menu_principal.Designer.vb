<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_principal))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.bot_conf = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.bot_modificar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bot_salir2 = New System.Windows.Forms.PictureBox()
        Me.bot_agregar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.data_historial = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tx_numero = New System.Windows.Forms.TextBox()
        Me.bot_mas = New System.Windows.Forms.Button()
        Me.bot_ver = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.bot_mod_caso = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.bot_salir2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_historial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.bot_conf)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.bot_modificar)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.bot_salir2)
        Me.Panel1.Controls.Add(Me.bot_agregar)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(191, 737)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel4.Location = New System.Drawing.Point(6, 655)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(8, 38)
        Me.Panel4.TabIndex = 15
        '
        'bot_conf
        '
        Me.bot_conf.BackColor = System.Drawing.Color.Red
        Me.bot_conf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_conf.FlatAppearance.BorderSize = 0
        Me.bot_conf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.bot_conf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen
        Me.bot_conf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bot_conf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bot_conf.ForeColor = System.Drawing.Color.White
        Me.bot_conf.Image = CType(resources.GetObject("bot_conf.Image"), System.Drawing.Image)
        Me.bot_conf.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.bot_conf.Location = New System.Drawing.Point(13, 655)
        Me.bot_conf.Name = "bot_conf"
        Me.bot_conf.Size = New System.Drawing.Size(175, 38)
        Me.bot_conf.TabIndex = 16
        Me.bot_conf.Text = "Opciones"
        Me.bot_conf.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel3.Location = New System.Drawing.Point(6, 188)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(8, 38)
        Me.Panel3.TabIndex = 13
        Me.Panel3.Visible = False
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
        Me.bot_modificar.Location = New System.Drawing.Point(13, 188)
        Me.bot_modificar.Name = "bot_modificar"
        Me.bot_modificar.Size = New System.Drawing.Size(175, 38)
        Me.bot_modificar.TabIndex = 14
        Me.bot_modificar.Text = "Modificar"
        Me.bot_modificar.UseVisualStyleBackColor = False
        Me.bot_modificar.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel2.Location = New System.Drawing.Point(6, 133)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(8, 38)
        Me.Panel2.TabIndex = 11
        '
        'bot_salir2
        '
        Me.bot_salir2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bot_salir2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_salir2.Image = CType(resources.GetObject("bot_salir2.Image"), System.Drawing.Image)
        Me.bot_salir2.Location = New System.Drawing.Point(156, 709)
        Me.bot_salir2.Name = "bot_salir2"
        Me.bot_salir2.Size = New System.Drawing.Size(32, 25)
        Me.bot_salir2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bot_salir2.TabIndex = 11
        Me.bot_salir2.TabStop = False
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
        Me.bot_agregar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.bot_agregar.Location = New System.Drawing.Point(13, 133)
        Me.bot_agregar.Name = "bot_agregar"
        Me.bot_agregar.Size = New System.Drawing.Size(175, 38)
        Me.bot_agregar.TabIndex = 12
        Me.bot_agregar.Text = "Agregar Telf"
        Me.bot_agregar.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(0, 699)
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
        Me.PictureBox1.Size = New System.Drawing.Size(185, 124)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(196, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data Center"
        '
        'data_historial
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data_historial.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.data_historial.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.data_historial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.data_historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_historial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column7, Me.Column6, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data_historial.DefaultCellStyle = DataGridViewCellStyle2
        Me.data_historial.GridColor = System.Drawing.Color.Black
        Me.data_historial.Location = New System.Drawing.Point(3, 6)
        Me.data_historial.Name = "data_historial"
        Me.data_historial.Size = New System.Drawing.Size(932, 655)
        Me.data_historial.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "N°"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Dominio"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 230
        '
        'Column3
        '
        Me.Column3.HeaderText = "Panel"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Nivel"
        Me.Column4.Name = "Column4"
        Me.Column4.Visible = False
        Me.Column4.Width = 130
        '
        'Column5
        '
        Me.Column5.HeaderText = "Ultimo Caso °"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 130
        '
        'Column7
        '
        Me.Column7.HeaderText = "Status "
        Me.Column7.Name = "Column7"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Cant"
        Me.Column6.Name = "Column6"
        '
        'Column8
        '
        Me.Column8.HeaderText = "id_cliente"
        Me.Column8.Name = "Column8"
        Me.Column8.Visible = False
        '
        'Column9
        '
        Me.Column9.HeaderText = "list_status"
        Me.Column9.Name = "Column9"
        Me.Column9.Visible = False
        '
        'Column10
        '
        Me.Column10.HeaderText = "id_servicio_cliente"
        Me.Column10.Name = "Column10"
        Me.Column10.Visible = False
        '
        'Column11
        '
        Me.Column11.HeaderText = "descripcion_caso"
        Me.Column11.Name = "Column11"
        Me.Column11.Visible = False
        '
        'Column12
        '
        Me.Column12.HeaderText = "id_historial"
        Me.Column12.Name = "Column12"
        Me.Column12.Visible = False
        '
        'tx_numero
        '
        Me.tx_numero.BackColor = System.Drawing.Color.White
        Me.tx_numero.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_numero.ForeColor = System.Drawing.Color.Black
        Me.tx_numero.Location = New System.Drawing.Point(1011, 27)
        Me.tx_numero.Name = "tx_numero"
        Me.tx_numero.Size = New System.Drawing.Size(182, 33)
        Me.tx_numero.TabIndex = 3
        Me.tx_numero.Text = "Numero"
        Me.tx_numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bot_mas
        '
        Me.bot_mas.BackColor = System.Drawing.Color.LawnGreen
        Me.bot_mas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_mas.FlatAppearance.BorderSize = 0
        Me.bot_mas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen
        Me.bot_mas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.bot_mas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bot_mas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bot_mas.ForeColor = System.Drawing.Color.White
        Me.bot_mas.Image = CType(resources.GetObject("bot_mas.Image"), System.Drawing.Image)
        Me.bot_mas.Location = New System.Drawing.Point(1140, 108)
        Me.bot_mas.Name = "bot_mas"
        Me.bot_mas.Size = New System.Drawing.Size(44, 38)
        Me.bot_mas.TabIndex = 17
        Me.bot_mas.UseVisualStyleBackColor = False
        '
        'bot_ver
        '
        Me.bot_ver.BackColor = System.Drawing.Color.LawnGreen
        Me.bot_ver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_ver.FlatAppearance.BorderSize = 0
        Me.bot_ver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen
        Me.bot_ver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.bot_ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bot_ver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bot_ver.ForeColor = System.Drawing.Color.White
        Me.bot_ver.Image = CType(resources.GetObject("bot_ver.Image"), System.Drawing.Image)
        Me.bot_ver.Location = New System.Drawing.Point(1140, 196)
        Me.bot_ver.Name = "bot_ver"
        Me.bot_ver.Size = New System.Drawing.Size(44, 38)
        Me.bot_ver.TabIndex = 18
        Me.bot_ver.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.data_historial)
        Me.Panel5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(196, 60)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(938, 661)
        Me.Panel5.TabIndex = 19
        '
        'bot_mod_caso
        '
        Me.bot_mod_caso.BackColor = System.Drawing.Color.LawnGreen
        Me.bot_mod_caso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_mod_caso.FlatAppearance.BorderSize = 0
        Me.bot_mod_caso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen
        Me.bot_mod_caso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.bot_mod_caso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bot_mod_caso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bot_mod_caso.ForeColor = System.Drawing.Color.White
        Me.bot_mod_caso.Image = CType(resources.GetObject("bot_mod_caso.Image"), System.Drawing.Image)
        Me.bot_mod_caso.Location = New System.Drawing.Point(1140, 152)
        Me.bot_mod_caso.Name = "bot_mod_caso"
        Me.bot_mod_caso.Size = New System.Drawing.Size(44, 38)
        Me.bot_mod_caso.TabIndex = 20
        Me.bot_mod_caso.UseVisualStyleBackColor = False
        '
        'Menu_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1205, 733)
        Me.Controls.Add(Me.bot_mod_caso)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.bot_ver)
        Me.Controls.Add(Me.bot_mas)
        Me.Controls.Add(Me.tx_numero)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Menu_principal"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Historial de Llamadas"
        Me.Panel1.ResumeLayout(False)
        CType(Me.bot_salir2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_historial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bot_salir2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents bot_modificar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents bot_agregar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents data_historial As DataGridView
    Friend WithEvents tx_numero As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents bot_conf As Button
    Friend WithEvents bot_mas As Button
    Friend WithEvents bot_ver As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents bot_mod_caso As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
End Class
