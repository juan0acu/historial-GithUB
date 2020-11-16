Imports Call_History.clase_busquedas

Public Class dominio_clientes
    Public cls_buscar As New clase_busquedas
    'Solo falta modificar 85 %
    Private Sub dominio_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If desde_opcion = True Then
            tx_cliente_id.Text = numero_cliente
            buscar_dominio_servicio()
        Else

        End If

    End Sub

    Private Sub bot_ver_dominios_Click(sender As Object, e As EventArgs) Handles bot_editar.Click

    End Sub

    Public Sub buscar_dominio_servicio()
        Dim indice As Integer = 0

        data_servicio_cliente.Rows.Clear()
        cls_buscar.servicios_asociados_cliente(tx_cliente_id.Text)
        If cls_buscar.cls_principal.reader1.HasRows() Then
            Do While cls_buscar.cls_principal.reader1.Read()
                data_servicio_cliente.Rows.Add()
                data_servicio_cliente.Rows(indice).Cells(0).Value = cls_buscar.cls_principal.reader1.Item("dominio")
                data_servicio_cliente.Rows(indice).Cells(1).Value = cls_buscar.cls_principal.reader1.Item("nomb_servicio")
                data_servicio_cliente.Rows(indice).Cells(2).Value = cls_buscar.cls_principal.reader1.Item("descripcion_panel")
                data_servicio_cliente.Rows(indice).Cells(3).Value = cls_buscar.cls_principal.reader1.Item("id_servicio_cliente")
                indice += 1

            Loop
            cls_buscar.cls_principal.reader1.Close()
        Else
            cls_buscar.cls_principal.reader1.Close()
            MsgBox("Cliente no tiene Servicios asociados")
        End If
    End Sub

    Private Sub bot_atras_Click(sender As Object, e As EventArgs) Handles bot_atras.Click
        todo_cero()
        Me.Close()
    End Sub

    Public Sub todo_cero()
        tx_cliente_id.Text = Nothing
        desde_opcion = False
        data_servicio_cliente.Rows.Clear()

    End Sub
End Class