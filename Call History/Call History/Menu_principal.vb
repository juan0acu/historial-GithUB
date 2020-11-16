Imports Call_History.clase_busquedas
Public Class Menu_principal
    Public cls_busqueda As New clase_busquedas

    Private Sub bot_salir2_Click(sender As Object, e As EventArgs) Handles bot_salir2.Click
        Application.Exit()
    End Sub

    Private Sub bot_agregar_Click(sender As Object, e As EventArgs) Handles bot_agregar.Click
        ingresar_cliente.ShowDialog()
    End Sub

    Private Sub bot_conf_Click(sender As Object, e As EventArgs) Handles bot_conf.Click
        masopciones.ShowDialog()
    End Sub

    Private Sub tx_numero_Leave(sender As Object, e As EventArgs) Handles tx_numero.Leave
        If tx_numero.Text = "" Then
            tx_numero.Text = "Numero"
            tx_numero.ForeColor = Color.LightGray
        End If
    End Sub

    Private Sub tx_numero_Enter(sender As Object, e As EventArgs) Handles tx_numero.Enter
        If tx_numero.Text = "Numero" Then
            tx_numero.Text = ""
            tx_numero.ForeColor = Color.LightGray
        End If
    End Sub

    Private Sub bot_mas_Click(sender As Object, e As EventArgs) Handles bot_mas.Click
        ' MsgBox("entro")
        ' Dim fmr As R_variacion_precios = CType(Owner, R_variacion_precios)
        'fmr.text_id.Text = data_productos.CurrentRow.Cells(0).Value.ToString()
        If data_historial.CurrentRow.Cells.ToString = Nothing Then
            MsgBox("Seleccionar el último caso, para agregar uno nuevo")
        Else
            Dim fmr As New agregar_caso
            fmr.tx_numero.Text = data_historial.CurrentRow.Cells(0).Value.ToString()
            fmr.tx_dominio.Text = data_historial.CurrentRow.Cells(1).Value.ToString()
            status_actual = data_historial.CurrentRow.Cells(8).Value.ToString()
            fmr.tx_caso.Text = data_historial.CurrentRow.Cells(4).Value.ToString()
            fmr.tx_servicio_cliente.Text = data_historial.CurrentRow.Cells(9).Value.ToString()
            fmr.tx_llamadas.Text = data_historial.CurrentRow.Cells(6).Value.ToString()
            fmr.ShowDialog()
            If tx_numero.Text <> Nothing Then
                tx_numero.Text = Nothing
            Else
                tx_numero.Text = "Numero"
            End If

        End If

    End Sub

    Private Sub Menu_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub buscar_historial()

    End Sub

    Private Sub tx_numero_TextChanged(sender As Object, e As EventArgs) Handles tx_numero.TextChanged
        cargar_registros()
    End Sub

    Public Sub cargar_registros()
        ' MsgBox("primera entrada")
        Dim indice As Integer = 0, repetido As String = Nothing
        cls_busqueda.buscar_historial_actual(tx_numero.Text)
        ' MsgBox("paso1")
        data_historial.Rows.Clear()

        If cls_busqueda.cls_principal.reader1.HasRows() Then
            '   MsgBox("pasohas")
            Do While cls_busqueda.cls_principal.reader1.Read()
                If repetido = cls_busqueda.cls_principal.reader1.Item("dominio") Then

                Else
                    data_historial.Rows.Add()
                    data_historial.Rows(indice).Cells(0).Value = cls_busqueda.cls_principal.reader1.Item("numero_telf")
                    data_historial.Rows(indice).Cells(1).Value = cls_busqueda.cls_principal.reader1.Item("dominio")
                    data_historial.Rows(indice).Cells(2).Value = cls_busqueda.cls_principal.reader1.Item("descripcion_panel")
                    data_historial.Rows(indice).Cells(3).Value = cls_busqueda.cls_principal.reader1.Item("descripcion_nivel")
                    data_historial.Rows(indice).Cells(4).Value = cls_busqueda.cls_principal.reader1.Item("num_caso")
                    data_historial.Rows(indice).Cells(6).Value = cls_busqueda.cls_principal.reader1.Item("cant_llamadas")
                    data_historial.Rows(indice).Cells(5).Value = cls_busqueda.cls_principal.reader1.Item("descripcion_status")
                    data_historial.Rows(indice).Cells(7).Value = cls_busqueda.cls_principal.reader1.Item("id_cliente")
                    data_historial.Rows(indice).Cells(8).Value = cls_busqueda.cls_principal.reader1.Item("id_status")
                    data_historial.Rows(indice).Cells(9).Value = cls_busqueda.cls_principal.reader1.Item("id_servicio_cliente")
                    data_historial.Rows(indice).Cells(10).Value = cls_busqueda.cls_principal.reader1.Item("caso")
                    data_historial.Rows(indice).Cells(11).Value = cls_busqueda.cls_principal.reader1.Item("id_historial")
                    indice += 1
                    repetido = cls_busqueda.cls_principal.reader1.Item("dominio")
                End If

            Loop
            cls_busqueda.cls_principal.reader1.Close()
        Else
            cls_busqueda.cls_principal.reader1.Close()
            MsgBox("No hay registros almacenados con ese número")
        End If

    End Sub

    Private Sub bot_mod_caso_Click(sender As Object, e As EventArgs) Handles bot_mod_caso.Click
        ' MsgBox("entro")
        ' Dim fmr As R_variacion_precios = CType(Owner, R_variacion_precios)
        'fmr.text_id.Text = data_productos.CurrentRow.Cells(0).Value.ToString()
        If data_historial.CurrentRow.Cells.ToString = Nothing Then
            MsgBox("Seleccionar el caso, para modificar")
        Else
            modificar_casos = True

            Dim fmr As New agregar_caso
            fmr.tx_numero.Text = data_historial.CurrentRow.Cells(0).Value.ToString()
            fmr.tx_dominio.Text = data_historial.CurrentRow.Cells(1).Value.ToString()
            status_actual = data_historial.CurrentRow.Cells(8).Value.ToString()
            fmr.tx_caso.Text = data_historial.CurrentRow.Cells(4).Value.ToString()
            fmr.tx_servicio_cliente.Text = data_historial.CurrentRow.Cells(9).Value.ToString()
            fmr.tx_descrip.Text = data_historial.CurrentRow.Cells(10).Value.ToString()
            fmr.tx_id_cliente.Text = data_historial.CurrentRow.Cells(11).Value.ToString()
            fmr.tx_llamadas.Text = data_historial.CurrentRow.Cells(6).Value.ToString()
            fmr.ShowDialog()
            If tx_numero.Text <> Nothing Then
                tx_numero.Text = Nothing
            Else
                tx_numero.Text = "Numero"
            End If

        End If
    End Sub

    Private Sub bot_ver_Click(sender As Object, e As EventArgs) Handles bot_ver.Click
        Dim fmr As New ver_casos
        fmr.tx_numero.Text = data_historial.CurrentRow.Cells(0).Value.ToString()
        fmr.tx_dominio.Text = data_historial.CurrentRow.Cells(1).Value.ToString()
        fmr.ShowDialog()
    End Sub
End Class