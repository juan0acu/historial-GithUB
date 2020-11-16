Imports Call_History.clase_principal
Public Class clase_busquedas

    Public cls_principal As New clase_principal
    Public strsql As String

    'Busqueda de tipo de cliente
    Public Sub buscar_nivel_cliente() 'Sin adecuar
        strsql = "select * from nivel"
        cls_principal.ejecutar_consultas(strsql)
    End Sub

    Public Sub ultimo_cliente_agregado()
        strsql = "Select * from cliente order by id_cliente desc"
        cls_principal.ejecutar_consultas(strsql)
    End Sub

    Public Sub saber_cliente(id)
        strsql = "Select * from cliente where id_cliente=" & id & ""
        cls_principal.ejecutar_consultas(strsql)
    End Sub

    Public Sub paneles()
        strsql = "Select * from panel"
        cls_principal.ejecutar_consultas(strsql)
    End Sub

    Public Sub servicios(id_panel)
        strsql = "Select * from servicios where id_panel=" & id_panel & ""
        cls_principal.ejecutar_consultas(strsql)
    End Sub

    Public Sub servicios_asociados_cliente(numero) 'Problema en ver servicios no lo esta mostrado
        'SELECT * FROM cliente natural join servicio_cliente,servicios where numero_telf = 978130685 and cliente.id_cliente = servicio_cliente.id_cliente and servicios.id_servicios = servicio_cliente.id_servicio
        '    strsql = "Select * from servicio_cliente natural join cliente,servicios where numero_telf=" & numero & " and cliente.id_cliente = servicio_cliente.id_servicio_cliente and servicios.id_servicios = servicio_cliente.id_servicio_cliente"
        strsql = "SELECT * FROM cliente natural join servicio_cliente,servicios,panel where numero_telf =" & numero & " and cliente.id_cliente = servicio_cliente.id_cliente and servicios.id_servicios = servicio_cliente.id_servicio and servicios.id_panel = panel.id_panel
"

        cls_principal.ejecutar_consultas(strsql)
    End Sub

    Public Sub ver_dominio_con_servicio(dominio)
        strsql = "select * from servicio_cliente where dominio='" & dominio & "'"
        cls_principal.ejecutar_consultas(strsql)
    End Sub

    Public Sub ver_numero_cliente(numero)

        strsql = "select * from cliente where numero_telf=" & numero & ""
        cls_principal.ejecutar_consultas(strsql)
    End Sub

    Public Sub buscar_historial_actual(numero)
        'strsql = "select * from item_vario natural join tipo_vario,marca where modelo Like '%" & vacio & "%' and item_vario.id_tipo_vario = tipo_vario.id_tipo_vario and item_vario.id_marca = marca.id_marca" like
        If numero = Nothing Or numero = "Numero" Then
            strsql = "SELECT * FROM cliente natural join nivel, historial,panel,servicio_cliente,servicios,status,usuarios where cliente.id_nivel = nivel.id_nivel and servicio_cliente.id_cliente = cliente.id_cliente and servicio_cliente.id_servicio = servicios.id_servicios and servicios.id_panel = panel.id_panel and servicio_cliente.id_servicio_cliente = historial.id_servicio_cliente and historial.id_status = status.id_status and historial.id_usuario = usuarios.id_usuarios order by dominio,num_caso desc"
            cls_principal.ejecutar_consultas(strsql)
        Else
            strsql = "SELECT * FROM cliente natural join nivel, historial,panel,servicio_cliente,servicios,status,usuarios where numero_telf Like '%" & numero & "%' and cliente.id_nivel = nivel.id_nivel and servicio_cliente.id_cliente = cliente.id_cliente and servicio_cliente.id_servicio = servicios.id_servicios and servicios.id_panel = panel.id_panel and servicio_cliente.id_servicio_cliente = historial.id_servicio_cliente and historial.id_status = status.id_status and historial.id_usuario = usuarios.id_usuarios order by dominio,num_caso desc"
            cls_principal.ejecutar_consultas(strsql)
        End If
        'SELECT * FROM `cliente` natural join nivel, historial,panel,servicio_cliente,servicios,status where cliente.id_nivel = nivel.id_nivel and servicio_cliente.id_cliente = cliente.id_cliente and servicio_cliente.id_servicio = servicios.id_servicios and servicios.id_panel = panel.id_panel and servicio_cliente.id_servicio_cliente = historial.id_servicio_cliente and historial.id_status = status.id_status and numero_telf = 978130685 order by num_caso asc
    End Sub

    Public Sub status()
        strsql = "select * from status"
        cls_principal.ejecutar_consultas(strsql)
    End Sub

    Public Sub ultimo_servicio_agregado()
        strsql = "Select * from servicio_cliente order by id_servicio_cliente desc"
        cls_principal.ejecutar_consultas(strsql)
    End Sub


End Class
