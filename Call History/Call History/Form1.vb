Imports MySql.Data.MySqlClient
Imports Call_History.clase_principal

Public Class ingresar_sistema
    Public cls_principal As New clase_principal

    Public cls_usuario As New clase_usuario
    Public cedula As Integer
    Public contador As Integer = 3
    Public status_usuario As Integer = 1
    Public strsql As String
    Private cont_mostrar As Integer = 0
    Public usuario_nick As String

    Private Sub ingresar_sistema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' MsgBox("Conecto")
        cls_principal.conectar_bd()
    End Sub

    'APARIENCIA DE MANDOS PARA CAMBIAR COLOR Y POSICIONAR LETRAS
    Private Sub Text_usuario_Enter(sender As Object, e As EventArgs) Handles text_usuario.Enter
        If text_usuario.Text = "USUARIO" Then
            text_usuario.Text = ""
            text_usuario.ForeColor = Color.LightGray
        End If

    End Sub
    Private Sub Text_usuario_Leave(sender As Object, e As EventArgs) Handles text_usuario.Leave
        If text_usuario.Text = "" Then
            text_usuario.Text = "USUARIO"
            text_usuario.ForeColor = Color.LightGray
        End If
    End Sub
    Private Sub Text_contrasena_Enter(sender As Object, e As EventArgs) Handles text_contrasena.Enter
        If text_contrasena.Text = "CONTRASEÑA" Then
            text_contrasena.Text = ""
            text_contrasena.ForeColor = Color.LightGray
            text_contrasena.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub Text_contrasena_Leave(sender As Object, e As EventArgs) Handles text_contrasena.Leave
        If text_contrasena.Text = "" Then
            text_contrasena.Text = "CONTRASEÑA"
            text_contrasena.ForeColor = Color.LightGray
            text_contrasena.UseSystemPasswordChar = False
        End If
    End Sub

    'BOTONES MINIMIZAR Y CERRAR
    Private Sub Bot_minimizar_Click(sender As Object, e As EventArgs) Handles bot_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Bot_cerrar_Click(sender As Object, e As EventArgs) Handles bot_cerrar.Click
        Application.Exit()
    End Sub

    'MOSTRAR CONTRASEÑA
    Private Sub Bot_mostra_clave_MouseHover(sender As Object, e As EventArgs) Handles bot_mostra_clave.MouseHover
        If cont_mostrar = 0 Then
            text_contrasena.UseSystemPasswordChar = False
            cont_mostrar = 1
        Else
            text_contrasena.UseSystemPasswordChar = True
            cont_mostrar = 0
        End If
    End Sub

    Private Sub Bot_ingresar_Click(sender As Object, e As EventArgs) Handles bot_ingresar.Click
        ingresar_sistema_metodo()

    End Sub

    'METODO INGRESAR AL SISTEMA 
    Private Sub ingresar_sistema_metodo()
        If text_usuario.Text = Nothing Or text_usuario.Text = "USUARIO" Then
            MsgBox("Favor ingresa Usario")
            text_usuario.Focus()
        ElseIf text_contrasena.Text = Nothing Or text_contrasena.Text = "CONTRASEÑA" Then
            MsgBox("Favor ingresa Contraseña")
            text_contrasena.Focus()
        Else
            'ejecutar sentecia Validar Usuario
            cls_usuario.buscar_usuario(text_usuario.Text)
            If cls_principal.reader1.HasRows Then
                cls_principal.reader1.Read()
                If status_usuario = cls_principal.reader1.Item("id_situacion") Then

                    If text_contrasena.Text = cls_principal.reader1.Item("clave") Then
                        usuario_actual = cls_principal.reader1.Item("id_usuarios")
                        rol_usuario = cls_principal.reader1.Item("id_rol")
                        cls_principal.reader1.Close()
                        Me.Hide()
                        Menu_principal.ShowDialog()
                    Else
                        contador -= 1
                        If contador = 0 Then
                            MsgBox("Lo siento pero su Usuario ha sido bloqueado")
                            usuario_actual = cls_principal.reader1.Item("id_usuarios")
                            cls_principal.reader1.Close()
                            cls_usuario.bloquear_usuario(usuario_actual)
                            text_contrasena.Text = Nothing
                            text_contrasena.Focus()
                        ElseIf contador > 0 Then
                            MsgBox("Contraseña Invalida, quedan " & contador & "  intentos para ser bloqueado")
                            text_contrasena.Text = Nothing
                            text_contrasena.Focus()
                        End If
                        cls_principal.reader1.Close()
                        text_contrasena.Text = Nothing
                        text_contrasena.Focus()
                    End If

                Else
                    MsgBox("Lo siento pero su usuario se encuentra bloqueado por lo tanto no puede acceder al sistema, comuniquese con el Administrador.")
                    cls_principal.reader1.Close()
                    text_contrasena.Text = Nothing
                    text_usuario.Focus()
                End If
            Else
                MsgBox("Usuario no registrado en la base de datos.")
                cls_principal.reader1.Close()
                text_contrasena.Text = "CONTRASEÑA"
                text_contrasena.UseSystemPasswordChar = False
                text_usuario.Text = Nothing
                text_usuario.Focus()

            End If
        End If
    End Sub

    'VALIDAR CARACTERES INVALIDOS
    Private Sub Text_usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_usuario.KeyPress
        Dim var_ascci As String
        var_ascci = Asc(e.KeyChar)

        cls_principal.validar_especiales(var_ascci)
        If cls_principal.caracter_especial_invalido = True Then
            MsgBox("Caracter invalido")
            e.KeyChar = ""
        End If

        If var_ascci = "13" Then
            text_contrasena.Focus()
            text_contrasena.Text = Nothing
        End If

    End Sub

    Private Sub Text_contrasena_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_contrasena.KeyPress
        Dim var_ascci As String
        var_ascci = Asc(e.KeyChar)
        cls_principal.validar_especiales(var_ascci)
        If cls_principal.caracter_especial_invalido = True Then
            MsgBox("Caracter invalido")
            e.KeyChar = ""
        End If

        If var_ascci = "13" Then  'ADECUAR
            'EJECUTAR
            ingresar_sistema_metodo()
        End If
    End Sub
End Class
