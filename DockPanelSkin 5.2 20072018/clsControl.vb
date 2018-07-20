Imports System.Data
Imports System.Data.SqlClient

Public Class clsControl

    Public Sub limpia_Catalogos()

        strLinea = ""
        strLinea1 = ""
        strLinea2 = ""
        strLinea3 = ""
        strLinea4 = ""
        strLinea5 = ""
        strLinea6 = ""
        strLinea7 = ""
        strLinea8 = ""
        strLinea9 = ""
        strLinea10 = ""
        strLinea11 = ""
        strLinea12 = ""
        strLinea13 = ""

        strLinea_tag = ""
        strLinea_tag1 = ""
        strLinea_tag2 = ""
        strLinea_tag3 = ""
        strLinea_tag4 = ""
        strLinea_tag5 = ""
        strLinea_tag6 = ""
        strLinea_tag7 = ""
        strLinea_tag8 = ""

        strLinea_tag9 = ""
        strLinea_tag10 = ""
        strLinea_tag11 = ""
        strLinea_tag12 = ""
        strLinea_tag13 = ""
        strLinea_tag14 = ""
        strLinea_tag15 = ""
        strLinea_tag16 = ""

        strLinea_tag17 = ""
        strLinea_tag18 = ""
        strLinea_tag19 = ""
        strLinea_tag20 = ""
        strLinea_tag21 = ""
        strLinea_tag22 = ""
        strLinea_tag23 = ""
        strLinea_tag24 = ""

        strLinea_tag25 = ""
        strLinea_tag26 = ""
        strLinea_tag27 = ""
        strLinea_tag28 = ""
        strLinea_tag29 = ""
        strLinea_tag30 = ""
        strLinea_tag31 = ""
        strLinea_tag32 = ""
        strLinea_tag33 = ""
        strLinea_tag34 = ""

        glintWidthAnt = 0
        glintHeigtAnt = 0

        'str_Plaza_Cobro = ""
        'id_plaza_cobro = 0

        'str_Cajero_Receptor = ""
        'id_Cajero_Receptor = 0

        'id_Turno = 0
        'str_Turno_block = ""

        'dt_Fecha_Inicio = Nothing
        'dt_Fecha_Fin = Nothing
    End Sub


    Public Sub agregar_datacolum(ByRef columna As DataColumn, ByVal int_tipo As Integer, ByVal Nombre_colum As String)

        Select Case int_tipo

            Case 1 'double
                columna = New DataColumn
                columna.DataType = System.Type.GetType("System.Double")
                columna.ColumnName = Nombre_colum
                columna.ReadOnly = True
                columna.Unique = False


            Case 2 'string

                columna = New DataColumn
                columna.DataType = System.Type.GetType("System.String")
                columna.ColumnName = Nombre_colum
                columna.ReadOnly = True
                columna.Unique = False
            Case 3 'date

                columna = New DataColumn
                columna.DataType = System.Type.GetType("System.DateTime")
                columna.ColumnName = Nombre_colum
                columna.ReadOnly = True
                columna.Unique = False



        End Select

    End Sub

    Function fecha(ByVal cadena As String) As Date
        'fecha = CDate(Mid(cadena, 7, 2) & "/" & Mid(cadena, 5, 2) & "/" & Mid(cadena, 1, 4) & " " & Mid(cadena, 9, 2) & ":" & Mid(cadena, 11, 2) & ":" & Mid(cadena, 13, 2))
        fecha = CDate(Mid(cadena, 5, 2) & "/" & Mid(cadena, 7, 2) & "/" & Mid(cadena, 1, 4) & " " & Mid(cadena, 9, 2) & ":" & Mid(cadena, 11, 2) & ":" & Mid(cadena, 13, 2))
        Exit Function
    End Function

    Public Function LeeINI(ByVal Ruta As String, ByVal Seccion As String, ByVal Variable As String) As String
        On Error GoTo ErrLeeINI
        'Dim Resultado As String * 255
        Dim Resultado As String
        Resultado = New String(Chr(0), 255)

        Dim Caracteres As Long

        Caracteres = GetPrivateProfileString(Seccion, Variable, "", Resultado, 255, Ruta)
        LeeINI = Left$(Resultado, Caracteres)
        Exit Function
ErrLeeINI:
        LeeINI = ""
    End Function

    Public Function Dato(sql As String) As String
        Try
            Dim conexion As New SqlConnection("Server=localhost\SQLEXPRESS;Database=Pruebas;Trusted_Connection=True;")
            Dim cmd As New SqlCommand
            Dim consulta As String = "select " & sql & " from Parametrizable"
            conexion.Open()
            cmd.CommandText = consulta
            cmd.Connection = conexion
            Dato = cmd.ExecuteScalar
            conexion.Close()
        Catch
            Dato = ""
        End Try
    End Function

    Public Function BitacoraSQL(Fecha As String, reporte As String)
        Dim conexion As New SqlConnection("Server=localhost\SQLEXPRESS;Database=Pruebas;Trusted_Connection=True;")
        Dim cmd As New SqlCommand
        Dim consulta As String = "select top 1 Version from BitacoraReportes where fecha=convert (date,'" & Fecha & "',103) and ReporteImp='" & reporte & "' order by FechaHoraImp desc"
        conexion.Open()
        cmd.CommandText = consulta
        cmd.Connection = conexion
        BitacoraSQL = cmd.ExecuteScalar
        conexion.Close()
    End Function

    Public Sub Insert(capufe As String, FechaHora As String, fecha As String, version As String, reporte As String)
        Try
            Dim conexion As New SqlConnection("Server=localhost\SQLEXPRESS;Database=Pruebas;Trusted_Connection=True;")
            Dim cmd As New SqlCommand
            Dim consulta As String = "insert into BitacoraReportes values ('" & capufe & "',convert (datetime,'" & FechaHora & "',103),
                                    convert (date,'" & fecha & "',103),'" & version & "','" & reporte & "')"
            conexion.Open()
            cmd.CommandText = consulta
            cmd.Connection = conexion
            cmd.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
