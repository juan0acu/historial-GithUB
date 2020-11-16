Imports Call_History.clase_principal
Public Class clase_ingreso_modificacion_datos
    Public cls_principal As New clase_principal
    Public strsql As String

    'ingresar nuevo número
    Public Sub ingresar_nuevo_num(id, id_nivel, observacion, cant, num)
        strsql = "insert into cliente values(" & id & "," & id_nivel & ",'" & observacion & "', " & cant & ", " & num & ")"
        cls_principal.ejecutar_comando(strsql)
    End Sub

    Public Sub ingresar_servicio_cliente(id, cliente, servicio, dominio)
        strsql = "insert into servicio_cliente values(" & id & "," & cliente & "," & servicio & ", '" & dominio & "')"
        cls_principal.ejecutar_comando(strsql)
    End Sub

    Public Sub ingresar_nuevo_caso(id, id_servicio, id_usuario, id_status, caso, fecha, descrip)
        strsql = "insert into historial values(" & id & "," & id_servicio & "," & id_usuario & "," & id_status & ",'" & caso & "'," & fecha & ", " & descrip & ")"
        cls_principal.ejecutar_comando(strsql)
    End Sub

    Public Sub modificar_caso(id, id_usuario, id_status, caso, fecha)
        'Quede aqui 14-01-20. Falta validar actualizar
        ' strsql = "update item_cerrajeria set id_tipo_llave=" & tipo & ", id_marca=" & marca & ", descripcion_llave='" & descripcion & "', modelo_llave='" & modelo & "',cantidad_actual=" & cantidad_inicial & ", cantidad_minima=" & cantidad_minima & " where id_item_cerrajeria=" & id & ""
        strsql = "update historial set id_usuario=" & id_usuario & ", id_status=" & id_status & ", caso='" & caso & "', fecha=" & fecha & " where id_historial=" & id & ""
        cls_principal.ejecutar_comando(strsql)
    End Sub

    Public Sub modificar_llamdas(id, llamada)
        'Quede aqui 14-01-20. Falta validar actualizar
        ' strsql = "update item_cerrajeria set id_tipo_llave=" & tipo & ", id_marca=" & marca & ", descripcion_llave='" & descripcion & "', modelo_llave='" & modelo & "',cantidad_actual=" & cantidad_inicial & ", cantidad_minima=" & cantidad_minima & " where id_item_cerrajeria=" & id & ""
        strsql = "update cliente set cant_llamadas=" & llamada & " where numero_telf=" & id & ""
        cls_principal.ejecutar_comando(strsql)
        'MsgBox(strsql)
    End Sub
End Class
