Imports Call_History.clase_busquedas
Imports Call_History.clase_ingreso_modificacion_datos

Public Class agregar_servicio_cliente
    'Listo
    Public cls_busquedas As New clase_busquedas
    Public cls_ingresar As New clase_ingreso_modificacion_datos

    Private Sub agregar_servicio_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If desde_opcion = True Then
            tx_id_cliente.Text = ct_id_cliente
            traer_cliente()
            cargar_comb_panel()
            tx_dominio.Focus()
        Else
            tx_id_cliente.Text = ultimo_cliente_agregado
            traer_cliente()
            cargar_comb_panel()
            tx_dominio.Focus()
        End If

    End Sub

    Public Sub traer_cliente()
        'buscar cliente agregado.
        cls_busquedas.saber_cliente(tx_id_cliente.Text)
        cls_busquedas.cls_principal.reader1.Read()
        tx_cliente.Text = cls_busquedas.cls_principal.reader1.Item("numero_telf")
        cls_busquedas.cls_principal.reader1.Close()
    End Sub

    Public Sub cargar_comb_panel()
        cb_panel.Items.Clear()
        cb_panel.ResetText()
        lis_panel.Items.Clear()

        cls_busquedas.paneles()
        Do While cls_busquedas.cls_principal.reader1.Read()
            cb_panel.Items.Add(cls_busquedas.cls_principal.reader1.Item("descripcion_panel"))
            lis_panel.Items.Add(cls_busquedas.cls_principal.reader1.Item("id_panel"))
        Loop
        cls_busquedas.cls_principal.reader1.Close()
    End Sub

    Private Sub cb_panel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_panel.SelectedIndexChanged
        Dim indice As Integer = 0
        lis_panel.SelectedIndex = cb_panel.SelectedIndex
        cls_busquedas.servicios(lis_panel.Text)
        data_servicio.Rows.Clear()
        Do While cls_busquedas.cls_principal.reader1.Read()
            data_servicio.Rows.Add()
            data_servicio.Rows(indice).Cells(0).Value = cls_busquedas.cls_principal.reader1.Item("nomb_servicio")
            data_servicio.Rows(indice).Cells(1).Value = cls_busquedas.cls_principal.reader1.Item("id_servicios")
            indice += 1
        Loop
        cls_busquedas.cls_principal.reader1.Close()
    End Sub



    Public Sub todo_cero()
        tx_cliente.Text = Nothing
        tx_dominio.Text = Nothing
        tx_id_cliente.Text = Nothing
        cb_panel.ResetText()
        data_servicio.Rows.Clear()
        Me.Close()
    End Sub

    Private Sub bot_atras_Click(sender As Object, e As EventArgs) Handles bot_atras.Click
        todo_cero()
        Me.Close()
    End Sub

    Private Sub bot_ver_dominios_Click(sender As Object, e As EventArgs) Handles bot_ver_dominios.Click
        Dim fmr As New dominio_clientes
        fmr.tx_cliente_id.Text = tx_cliente.Text
        dominio_clientes.ShowDialog()


    End Sub

    Private Sub bot_asociar_Click(sender As Object, e As EventArgs) Handles bot_asociar.Click
        Dim pregunta As MsgBoxResult
        pregunta = MsgBox("Seguro de agregar el servicio " & data_servicio.CurrentRow.Cells(0).Value.ToString(), MsgBoxStyle.YesNo)
        If pregunta = MsgBoxResult.Yes Then
            If data_servicio.CurrentRow.Cells(0).Value.ToString() = Nothing Then
                MsgBox("Favor indicar servicio a agregar")
            Else
                'agregar
                'validar si ese dominio no tiene servicio paso 1
                cls_busquedas.ver_dominio_con_servicio(tx_dominio.Text)
                If cls_busquedas.cls_principal.reader1.HasRows Then
                    MsgBox("Ese Dominio ya tiene registrado un servicio, solo actualice servicio")
                    cls_busquedas.cls_principal.reader1.Close()
                Else
                    cls_busquedas.cls_principal.reader1.Close()
                    'ingresar dominio con servicio paso 2
                    cls_ingresar.ingresar_servicio_cliente(0, tx_id_cliente.Text, data_servicio.CurrentRow.Cells(1).Value.ToString(), tx_dominio.Text)
                    'Ver ultimo agregado
                    Dim ultimo As Integer, fecha_inv As String
                    cls_busquedas.ultimo_servicio_agregado()
                    cls_busquedas.cls_principal.reader1.Read()
                    ultimo = cls_busquedas.cls_principal.reader1.Item("id_servicio_cliente")
                    cls_busquedas.cls_principal.reader1.Close()

                    fecha_inv = Format(date_fecha.Value, "yyyyMMdd")
                    cls_ingresar.ingresar_nuevo_caso(0, ultimo, usuario_actual, 1, "Ingreso nueva cuenta", fecha_inv, 0)
                    MsgBox("Servicio anexado exítosamente")

                    todo_cero()
                    Dim fmr As New Menu_principal
                    fmr.tx_numero.Text = Nothing
                    fmr.tx_numero.Text = "Numero"
                    fmr.cargar_registros()
                    Me.Close()
                    fmr.tx_numero.Text = Nothing
                    fmr.tx_numero.Text = "Numero"
                    fmr.cargar_registros()
                End If


            End If
        End If
    End Sub

    Private Sub bot_cancelar_Click(sender As Object, e As EventArgs) Handles bot_cancelar.Click
        todo_cero()
    End Sub

    Private Sub tx_dominio_Leave(sender As Object, e As EventArgs) Handles tx_dominio.Leave
        If tx_dominio.Text = "" Then
            tx_dominio.Text = "dominio.cl"
            tx_dominio.ForeColor = Color.LightGray
        End If
    End Sub

    Private Sub tx_dominio_Enter(sender As Object, e As EventArgs) Handles tx_dominio.Enter
        If tx_dominio.Text = "dominio.cl" Then
            tx_dominio.Text = ""
            tx_dominio.ForeColor = Color.LightGray
        End If
    End Sub
End Class