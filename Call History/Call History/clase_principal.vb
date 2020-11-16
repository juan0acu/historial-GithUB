Imports MySql.Data.MySqlClient
Public Class clase_principal
    Public miconexion As MySqlConnection = New MySqlConnection

    Public micomando As New MySqlCommand
    Public reader1 As MySqlDataReader

    Public strsql As String
    Public caracter_invalido As Boolean
    Public caracter_invalido_alfanumerico As Boolean
    Public caracter_especial_invalido As Boolean
    'mi primer metodo, para la conexion. LISTO
    Public Sub conectar_bd()
        '192.168.56.1/24
        '"server=localhost;database=historial;uid=root;pwd=;"
        miconexion.ConnectionString = "server=localhost;database=historial;uid=root;pwd=;"
        miconexion.Open()
    End Sub

    'para ejecutar consultas
    Public Sub ejecutar_consultas(ByVal strsql)
        micomando.Connection = Ingresar_sistema.cls_principal.miconexion 'se realiza de esta forma para q solo teniendo como llamado ingresar al sistema solo utilize una sola coneccion 
        micomando.CommandText = strsql 'ojo la variable STRSQL la estoy reciviendo como parametro para que me pueda servir en todas mis clases 
        reader1 = micomando.ExecuteReader
    End Sub


    'para ejecutar comandos sql
    Public Sub ejecutar_comando(ByVal strsql)
        'para ejecutar los comandos insert, update, delete solo para esos.
        micomando.Connection = Ingresar_sistema.cls_principal.miconexion
        micomando.CommandText = strsql
        micomando.ExecuteNonQuery()
    End Sub

    Public Sub validar_numerico(ByVal var_ascii)
        caracter_invalido = False

        If var_ascii = 8 Or var_ascii = 13 Or var_ascii = 22 Then 'para saber si esta pulsando la tecla borrar!

        ElseIf var_ascii < 48 Or var_ascii > 57 Then 'para ver si son solo números!
            caracter_invalido = True

        End If
    End Sub

    Public Sub validar_alfanumerio(ByVal var_ascii) 'esto es para saber si son solo numeros es el metodo que me lo permite
        caracter_invalido_alfanumerico = False
        If var_ascii = 8 Or var_ascii = 13 Or var_ascii = 22 Or var_ascii = 241 Or var_ascii = 209 Or var_ascii = 32 Then 'para saber si esta pulsando la tecla borrar!

        ElseIf var_ascii < 65 Or var_ascii > 90 Then 'para ver si son solo LETRAS!
            caracter_invalido_alfanumerico = True

        End If
    End Sub

    Public Sub validar_especiales(ByVal var_ascii) 'sin caracteres que puedan modificar mis sentencias SQL
        caracter_especial_invalido = False
        ' *=42 ,=44 '=39 "=34 &=38 (=40 )=41 ==61 .=46
        If var_ascii = 42 Or var_ascii = 44 Or var_ascii = 39 Or var_ascii = 22 Or var_ascii = 34 Or var_ascii = 38 Or var_ascii = 40 Or var_ascii = 41 Or var_ascii = 61 Or var_ascii = 46 Then
            caracter_especial_invalido = True
        End If
    End Sub
End Class
