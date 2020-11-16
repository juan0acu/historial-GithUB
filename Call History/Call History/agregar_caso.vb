Imports Call_History.clase_busquedas
Imports Call_History.clase_ingreso_modificacion_datos

Public Class agregar_caso
    Public cls_busqueda As New clase_busquedas
    Public cls_ingresar As New clase_ingreso_modificacion_datos

    Private Sub bot_atras_Click(sender As Object, e As EventArgs) Handles bot_atras.Click
        todo_Cero()
        Me.Close()
    End Sub

    Private Sub agregar_caso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If modificar_casos = True Then
            cargar_combo()
            list_status.Text = status_actual
            bot_modificar.Visible = True
            p_mod.Visible = True
            Bot_aceptar.Visible = False
        Else
            cargar_combo()
            list_status.Text = status_actual
        End If

    End Sub

    Public Sub cargar_combo()
        cb_status.Items.Clear()
        list_status.Items.Clear()
        cb_status.ResetText()

        cls_busqueda.status()
        Do While cls_busqueda.cls_principal.reader1.Read()
            '   MsgBox("entro ready")
            cb_status.Items.Add(cls_busqueda.cls_principal.reader1.Item("descripcion_status"))
            list_status.Items.Add(cls_busqueda.cls_principal.reader1.Item("id_status"))
        Loop
        cls_busqueda.cls_principal.reader1.Close()

    End Sub

    Private Sub cb_status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_status.SelectedIndexChanged
        list_status.SelectedIndex = cb_status.SelectedIndex
    End Sub

    Private Sub list_status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles list_status.SelectedIndexChanged
        cb_status.SelectedIndex = list_status.SelectedIndex

    End Sub

    Private Sub Bot_aceptar_Click(sender As Object, e As EventArgs) Handles Bot_aceptar.Click
        Dim resultado As MsgBoxResult
        resultado = MsgBox("Esta seguro de agregar este nuevo caso a este cliente", MsgBoxStyle.YesNo)
        If resultado = MsgBoxResult.Yes Then
            'ingresar caso
            Dim fecha_inv As Integer
            fecha_inv = Format(date_fecha_caso.Value, "yyyyMMdd")
            cls_ingresar.ingresar_nuevo_caso(0, tx_servicio_cliente.Text, usuario_actual, list_status.Text, tx_descrip.Text, fecha_inv, tx_caso.Text + 1)
            'activar las cantidad de llamadas
            cls_ingresar.modificar_llamdas(tx_numero.Text, tx_llamadas.Text + 1)

            MsgBox("Nuevo caso agregado")
            todo_Cero()
            Dim fmr As New Menu_principal
            fmr.tx_numero.Text = "Numero"
            fmr.cargar_registros()
            Me.Close()
            fmr.tx_numero.Text = "Numero"
            fmr.cargar_registros()
        Else

        End If
    End Sub

    Public Sub todo_Cero()
        tx_numero.Text = Nothing
        tx_dominio.Text = Nothing
        tx_caso.Text = Nothing
        tx_descrip.Text = Nothing
        tx_servicio_cliente.Text = Nothing
        date_fecha_caso.Value = Today
        cb_status.ResetText()
        Bot_aceptar.Visible = True
        p_mod.Visible = False
        bot_modificar.Visible = False
        modificar_casos = False

    End Sub

    Private Sub bot_modificar_Click(sender As Object, e As EventArgs) Handles bot_modificar.Click
        Dim resultado As MsgBoxResult
        resultado = MsgBox("Esta seguro de actualizar este caso ", MsgBoxStyle.YesNo)
        If resultado = MsgBoxResult.Yes Then
            'ingresar caso
            Dim fecha_inv As Integer
            fecha_inv = Format(date_fecha_caso.Value, "yyyyMMdd")
            cls_ingresar.modificar_caso(tx_id_cliente.Text, usuario_actual, list_status.Text, tx_descrip.Text, fecha_inv)
            cls_ingresar.modificar_llamdas(tx_numero.Text, tx_llamadas.Text + 1)
            MsgBox("Caso Actualizado")
            todo_Cero()
            Dim fmr As New Menu_principal
            fmr.tx_numero.Text = "Numero"
            fmr.cargar_registros()
            Me.Close()
            fmr.tx_numero.Text = "Numero"
            fmr.cargar_registros()
        Else

        End If
    End Sub

    Private Sub bot_cancelar_Click(sender As Object, e As EventArgs) Handles bot_cancelar.Click
        todo_Cero()
        Me.Close()
    End Sub
End Class