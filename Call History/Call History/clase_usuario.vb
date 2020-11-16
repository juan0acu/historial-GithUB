Imports Call_History.clase_principal
Public Class clase_usuario

    Public cls_principal As New clase_principal
    Public strsql As String

    Public Sub buscar_usuario(ByVal usuario) 'Sin adecuar
        strsql = "select * from usuarios where nick_usuario =  '" & usuario & "' "
        ingresar_sistema.cls_principal.ejecutar_consultas(strsql)
    End Sub

    Public Sub buscar_usuario_id(ByRef usuario)
        strsql = "select * from usuarios where id_usuarios =  '" & usuario & "' "
        cls_principal.ejecutar_consultas(strsql)
    End Sub

    Public Sub bloquear_usuario(ByVal usuario) 'Sin adecuar
        strsql = "UPDATE usuarios SET id_situacion=2 WHERE id_usuarios='" & usuario & "' "
        ingresar_sistema.cls_principal.ejecutar_comando(strsql)
        ' MsgBox(strsql)
    End Sub

    Public Sub desbloquear_usuario(ByVal usuario) 'Sin adecuar
        strsql = "UPDATE usuarios SET id_situacion=1 WHERE id_usuarios='" & usuario & "' "
        cls_principal.ejecutar_comando(strsql)
    End Sub

    Public Sub buscar_todos_usuarios() 'Sin adecuar
        strsql = "select * from usuarios"
        cls_principal.ejecutar_consultas(strsql)
    End Sub

    Public Sub buscar_roles() 'Sin adecuar
        strsql = "select * from rol"
        cls_principal.ejecutar_consultas(strsql)
    End Sub

    Public Sub buscar_situaciones() 'Sin adecuar
        strsql = "select * from situacion_usuario"
        cls_principal.ejecutar_consultas(strsql)
    End Sub

    Public Sub ingresar_usuario(ByVal id, ByVal id_situacion, ByVal id_rol, ByVal nombre_apellido, ByVal rut, ByVal nick, ByVal clave) 'Sin adecuar
        strsql = "insert into usuarios values(" & id & "," & id_situacion & "," & id_rol & ", '" & nombre_apellido & "', '" & rut & "','" & nick & "','" & clave & "')"
        cls_principal.ejecutar_comando(strsql)
    End Sub

    Public Sub modificar_usuario(ByVal id_rol, ByVal id_situacion, ByVal nombre, ByVal rut, ByVal nick, ByVal clave, ByVal id) 'Sin adecuar
        strsql = "update usuarios set id_situacion=" & id_situacion & ", id_rol=" & id_rol & ", nombre_apellido = '" & nombre & "', rut=  '" & rut & "', nick_usuario= '" & nick & "', clave= '" & clave & "' where id_usuarios =" & id & ""
        ' MsgBox(strsql)
        cls_principal.ejecutar_comando(strsql)
    End Sub

    Public Sub situaciones_usuarios() 'Sin adecuar
        strsql = "select * from status"
        cls_principal.ejecutar_consultas(strsql)
    End Sub

    Public Sub rol_usuario() 'Sin adecuar
        strsql = " select * from rol_usuario"
        cls_principal.ejecutar_consultas(strsql)
    End Sub
    Public Sub buscar_clientes(ByRef vacio) 'Sin adecuar
        If vacio = Nothing Or vacio = "Buscador" Then
            strsql = "select * from clientes natural join ciudad,tipo_cliente,region where clientes.id_ciudad = ciudad.id_ciudad and clientes.id_tipo_cliente = tipo_cliente.id_tipo_cliente and region.id_region = ciudad.id_region"
            cls_principal.ejecutar_consultas(strsql)
        Else
            strsql = "select * from clientes natural join ciudad,tipo_cliente,region where nombre_apellido LIKE '" & vacio & "%' and clientes.id_ciudad = ciudad.id_ciudad and clientes.id_tipo_cliente = tipo_cliente.id_tipo_cliente and region.id_region = ciudad.id_region"
            cls_principal.ejecutar_consultas(strsql)
            '"select * from cliente where nombre_apellido LIKE =  '%" & nombre & "%' "
        End If

    End Sub

    Public Sub buscar_regiones() 'Sin adecuar
        strsql = "select * from region"
        cls_principal.ejecutar_consultas(strsql)
    End Sub
    Public Sub buscar_tipo_clientes() 'Sin adecuar
        strsql = "select * from tipo_cliente"
        cls_principal.ejecutar_consultas(strsql)
    End Sub

    Public Sub buscar_ciudad(ByRef region) 'Sin adecuar
        'select * from ciudad natural join region where ciudad.id_region = 7 and ciudad.id_region = region.id_region 
        strsql = "select * from ciudad natural join region where ciudad.id_region =" & region & "  and ciudad.id_region = region.id_region "
        cls_principal.ejecutar_consultas(strsql)
    End Sub

    Public Sub ingresar_cliente(ByVal id, ByVal id_ciudad, ByVal id_tipo, ByVal nombre_apellido, ByVal rut, ByVal direccion, ByVal contacto) 'Sin adecuar
        strsql = "insert into clientes values(" & id & "," & id_ciudad & "," & id_tipo & ", '" & nombre_apellido & "', '" & rut & "','" & direccion & "','" & contacto & "')"
        cls_principal.ejecutar_comando(strsql)
    End Sub

    Public Sub modificar_cliente(ByVal id_ciudad, ByVal id_tipo_cliente, ByVal nombre, ByVal rut, ByVal direccion, ByVal contacto, ByVal id) 'Sin adecuar
        strsql = "update clientes set id_ciudad=" & id_ciudad & ", id_tipo_cliente=" & id_tipo_cliente & ", nombre_apellido = '" & nombre & "', rut=  '" & rut & "', direccion= '" & direccion & "', contacto= '" & contacto & "' where id_cliente =" & id & ""
        ' MsgBox(strsql)
        cls_principal.ejecutar_comando(strsql)
    End Sub
End Class
