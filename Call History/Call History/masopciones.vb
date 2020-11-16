Imports Call_History.clase_busquedas
Public Class masopciones
    Public cls_busqueda As New clase_busquedas

    Private Sub bot_agregar_Click(sender As Object, e As EventArgs) Handles bot_agregar.Click
        numero_cliente = 0
        desde_opcion = False
        Dim numero As Integer
        numero = InputBox("Ingrese el número para ver servicios. ")
        cls_busqueda.ver_numero_cliente(numero)
        If cls_busqueda.cls_principal.reader1.HasRows() Then
            cls_busqueda.cls_principal.reader1.Close()
            numero_cliente = numero
            desde_opcion = True
            dominio_clientes.ShowDialog()
        Else
            cls_busqueda.cls_principal.reader1.Close()
            MsgBox("Número que esta ingresando" & numero & "no existe en la base de datos.")
        End If
        'Problema en ver servicios no lo esta mostrado
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        numero_cliente = 0
        ct_id_cliente = 0
        desde_opcion = False
        Dim numero As Integer
        numero = InputBox("Ingrese el número para ver agregar dominio. ")
        cls_busqueda.ver_numero_cliente(numero)
        If cls_busqueda.cls_principal.reader1.HasRows() Then
            cls_busqueda.cls_principal.reader1.Read()
            ct_id_cliente = cls_busqueda.cls_principal.reader1.Item("id_cliente")
            cls_busqueda.cls_principal.reader1.Close()
            numero_cliente = numero
            desde_opcion = True
            agregar_servicio_cliente.ShowDialog()
        Else
            cls_busqueda.cls_principal.reader1.Close()
            MsgBox("Número que esta ingresando" & numero & "no existe en la base de datos.")
        End If
    End Sub

    Private Sub bot_atras_Click(sender As Object, e As EventArgs) Handles bot_atras.Click
        Me.Close()
    End Sub
End Class