Imports Call_History.clase_busquedas
Imports Call_History.clase_principal
Imports Call_History.clase_ingreso_modificacion_datos
Public Class ingresar_cliente
    'Modulo listo
    Public cls_busquedas As New clase_busquedas
    Public cls_principal As New clase_principal
    Public cls_ingresar As New clase_ingreso_modificacion_datos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        todo_cero()
        Me.Close()

    End Sub

    Private Sub ingresar_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_combo()
        txt_numero.Focus()
        list_tipo.Text = 2
    End Sub

    Public Sub llenar_combo()

        comb_tipo.Items.Clear()
        comb_tipo.ResetText()
        list_tipo.Items.Clear()
        cls_busquedas.buscar_nivel_cliente()
        Do While cls_busquedas.cls_principal.reader1.Read()

            comb_tipo.Items.Add(cls_busquedas.cls_principal.reader1.Item("descripcion_nivel"))
            list_tipo.Items.Add(cls_busquedas.cls_principal.reader1.Item("id_nivel"))
        Loop
        cls_busquedas.cls_principal.reader1.Close()
        list_tipo.Text = 2
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comb_tipo.SelectedIndexChanged
        list_tipo.SelectedIndex = comb_tipo.SelectedIndex

    End Sub

    Private Sub Bot_aceptar_Click(sender As Object, e As EventArgs) Handles Bot_aceptar.Click
        Dim resultado As MsgBoxResult
        resultado = MsgBox("Seguro de agregar este nuevo número", MsgBoxStyle.YesNo)
        If resultado = MsgBoxResult.Yes Then
            validar_campos_ing()
            'validar si numero existe
            cls_busquedas.ver_numero_cliente(txt_numero.Text)
            If cls_busquedas.cls_principal.reader1.HasRows() Then
                cls_busquedas.cls_principal.reader1.Close()
                MsgBox("El número " & txt_numero.Text & ", ya se encuentra registrado en la base de datos.")
            Else
                cls_busquedas.cls_principal.reader1.Close()
                'Ingresar Cliente ejecutar comando
                cls_ingresar.ingresar_nuevo_num(0, list_tipo.Text, txt_observacion.Text, 0, txt_numero.Text)
                MsgBox("Nuevo número ingresado")
                todo_cero()
                'Buscar ultimo cliente, guardarlo en una constante 
                cls_busquedas.ultimo_cliente_agregado()
                cls_busquedas.cls_principal.reader1.Read()
                ultimo_cliente_agregado = cls_busquedas.cls_principal.reader1.Item("id_cliente")
                cls_busquedas.cls_principal.reader1.Close()

                agregar_servicio_cliente.ShowDialog()
                Me.Close()
            End If

        End If
    End Sub

    Public Sub validar_campos_ing()

        If txt_numero.Text = Nothing Then
            MsgBox("Ingrese número")

        ElseIf comb_tipo.SelectedIndex < 0 Then
            MsgBox("Seleccione un Tipo de cliente")

        ElseIf txt_observacion.Text = Nothing Then
            MsgBox("Agrege alguna observación")
        Else

        End If
    End Sub

    Private Sub txt_numero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_numero.KeyPress
        Dim var_ascci As String
        var_ascci = Asc(e.KeyChar)
        cls_principal.validar_numerico(var_ascci)

        If cls_principal.caracter_invalido = True Then

            MsgBox("Caracter invalido")
            e.KeyChar = ""
        End If

        If var_ascci = "13" Then  'ADECUAR
            'EJECUTAR

        End If
    End Sub

    Public Sub todo_cero()
        txt_numero.Text = Nothing

        llenar_combo()
    End Sub

    Private Sub bot_cancelar_Click(sender As Object, e As EventArgs) Handles bot_cancelar.Click
        todo_cero()
    End Sub

    Private Sub list_tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles list_tipo.SelectedIndexChanged
        comb_tipo.SelectedIndex = list_tipo.SelectedIndex
    End Sub
End Class