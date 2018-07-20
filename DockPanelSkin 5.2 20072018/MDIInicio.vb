Imports System.Windows.Forms
Imports System.IO

Public Class MDIInicio

    Dim str_FullPath As String = objControl.LeeINI(Application.StartupPath & "\conexion.ini", "conexion", "archivo")

    Dim dt_fecha_modificacion As Date
    Dim gb_segundos As Integer
    Dim ller_video As Boolean
    Dim fecha_enviada As Date
    Dim bl_pausa As Boolean = False
    Private m_ChildFormNumber As Integer

    Public Sub Consulta(sql As String)

    End Sub

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub rpt9_Click(sender As Object, e As EventArgs) Handles rpt9.Click

        objControl.limpia_Catalogos()


        frmR1.Tag = rpt9.Tag
        strLinea = rpt9.Text
        frmR1.MdiParent = Me
        frmR1.Show()

    End Sub

    Private Sub MDIInicio_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'BanderaCierre = True
        'Dim Login As New Login
        'Login.ShowDialog()
        'If BanderaCierre = False Then
        '    e.Cancel = True
        'Else
        '    End
        'End If
    End Sub

    Private Sub MDIInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        gl_DNS = "Data Source=(DESCRIPTION=" _
+ "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.3.29.221)(PORT=1521)))" _
+ "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=GEAPROD)));" _
+ "User Id=GEAINT;Password=GEAINT;"

        Application.CurrentCulture = New System.Globalization.CultureInfo("en-US")

    End Sub

    Private Sub rpt6_Click(sender As Object, e As EventArgs) Handles rpt6.Click

        objControl.limpia_Catalogos()

        Dim frmR1 As New frmR1
        frmR1.Tag = rpt6.Tag
        strLinea = rpt6.Text
        frmR1.MdiParent = Me
        frmR1.Show()

    End Sub

    Private Sub rpt8_Click(sender As Object, e As EventArgs) Handles rpt8.Click

        objControl.limpia_Catalogos()

        Dim frmR1 As New frmR1
        frmR1.Tag = rpt8.Tag
        strLinea = rpt8.Text
        frmR1.MdiParent = Me
        frmR1.Show()

    End Sub

    Private Sub rpt5_Click(sender As Object, e As EventArgs) Handles rpt5.Click

        objControl.limpia_Catalogos()

        Dim frmR1 As New frmR1
        frmR1.Tag = rpt5.Tag
        strLinea = rpt5.Text
        frmR1.MdiParent = Me
        frmR1.Show()


    End Sub

    Private Sub rpt7_Click(sender As Object, e As EventArgs) Handles rpt7.Click

        objControl.limpia_Catalogos()

        Dim frmR1 As New frmR1
        frmR1.Tag = rpt7.Tag
        strLinea = rpt7.Text
        frmR1.MdiParent = Me
        frmR1.Show()

    End Sub

    Private Sub rpt10_Click(sender As Object, e As EventArgs) Handles rpt10.Click

        objControl.limpia_Catalogos()

        Dim frmR1 As New frmR1
        frmR1.Tag = rpt10.Tag
        strLinea = rpt10.Text
        frmR1.MdiParent = Me
        frmR1.Show()

    End Sub

    Private Sub rpt4_Click(sender As Object, e As EventArgs) Handles rpt4.Click

        objControl.limpia_Catalogos()

        Dim frmR1 As New frmR1
        frmR1.Tag = rpt4.Tag
        strLinea = rpt4.Text
        frmR1.MdiParent = Me
        frmR1.Show()


    End Sub

    Private Sub rpt1_Click(sender As Object, e As EventArgs) Handles rpt1.Click

        objControl.limpia_Catalogos()

        Dim frmR1 As New frmR1
        frmR1.Tag = rpt1.Tag
        strLinea = rpt1.Text
        frmR1.MdiParent = Me
        frmR1.Show()


    End Sub

    Private Sub rpt2_Click(sender As Object, e As EventArgs) Handles rpt2.Click

        objControl.limpia_Catalogos()

        Dim frmR1 As New frmR1
        frmR1.Tag = rpt2.Tag
        strLinea = rpt2.Text
        frmR1.MdiParent = Me
        frmR1.Show()

    End Sub

    Private Sub rpt3_Click(sender As Object, e As EventArgs) Handles rpt3.Click

        objControl.limpia_Catalogos()

        Dim frmR1 As New frmR1
        frmR1.Tag = rpt3.Tag
        strLinea = rpt3.Text
        frmR1.MdiParent = Me
        frmR1.Show()

    End Sub

    Private Sub rpt11_Click(sender As Object, e As EventArgs) Handles rpt11.Click

        objControl.limpia_Catalogos()

        Dim frmR1 As New frmR1
        frmR1.Tag = rpt11.Tag
        strLinea = rpt11.Text
        frmR1.MdiParent = Me
        frmR1.Show()

    End Sub

    Private Sub rpt12_Click(sender As Object, e As EventArgs) Handles rpt12.Click

        objControl.limpia_Catalogos()

        Dim frmR1 As New frmR1
        frmR1.Tag = rpt12.Tag
        strLinea = rpt12.Text
        frmR1.MdiParent = Me
        frmR1.Show()

    End Sub

    Private Sub rpt13_Click(sender As Object, e As EventArgs) Handles rpt13.Click

        objControl.limpia_Catalogos()

        Dim frmR1 As New frmR1
        frmR1.Tag = rpt13.Tag
        strLinea = rpt13.Text
        frmR1.MdiParent = Me
        frmR1.Show()

    End Sub

    Private Sub rpt14_Click(sender As Object, e As EventArgs) Handles rpt14.Click

        objControl.limpia_Catalogos()
        Dim frmR1 As New frmR1
        frmR1.Tag = rpt14.Tag
        strLinea = rpt14.Text
        frmR1.MdiParent = Me
        frmR1.Show()

    End Sub

    Private Sub rpt15_Click(sender As Object, e As EventArgs) Handles rpt15.Click

        objControl.limpia_Catalogos()

        Dim frmR1 As New frmR1
        frmR1.Tag = rpt15.Tag
        strLinea = rpt15.Text
        frmR1.MdiParent = Me
        frmR1.Show()

    End Sub

    Private Sub rpt16_Click(sender As Object, e As EventArgs) Handles rpt16.Click

        objControl.limpia_Catalogos()

        Dim frmR1 As New frmR1
        frmR1.Tag = rpt16.Tag
        strLinea = rpt16.Text
        frmR1.MdiParent = Me
        frmR1.Show()


    End Sub

    Private Sub FileMenu_Click(sender As Object, e As EventArgs) Handles FileMenu.Click
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'actualizacion_archivo()

    End Sub

    Private Sub actualizacion_archivo()

        Timer1.Enabled = False

        Dim InfoArchivo As FileInfo
        Dim sr As System.IO.StreamReader
        Dim str_fecha_querys As String




        Try


regresar:

            InfoArchivo = New FileInfo(str_FullPath)

            If InfoArchivo.IsReadOnly = True Then

                'lblEnLectura.Text = "En Letura"
                Application.DoEvents()
                GoTo regresar
                ller_video = False

            Else
                'lblEnLectura.Text = "OK"
            End If


            If InfoArchivo.Exists = False Then
            Else


                If dt_fecha_modificacion = InfoArchivo.LastWriteTime() Then
                    Application.DoEvents()
                    GoTo regresar
                    ller_video = False
                Else
                    ller_video = True
                End If



                sr = New System.IO.StreamReader( _
                         str_FullPath, _
                         System.Text.Encoding.Default, _
                         True)

                'txtDetalle.Text = ""

                While sr.Peek() <> -1
                    ' Leer una líena del fichero
                    Dim s As String = sr.ReadLine()
                    ' Si no está vacía, añadirla al control
                    ' Si está vacía, continuar el bucle
                    If String.IsNullOrEmpty(s) Then
                        Continue While
                    End If


                    'txtDetalle.Text = txtDetalle.Text & s & vbCrLf

                    'If Mid(s, 3, 7) = "TO_DATE" Then
                    '    str_fecha_querys = Mid(s, 12, 14)
                    'End If

                    If InStr(1, Trim(s), "Sac") <> 0 Then
                        str_fecha_querys = Mid(s, InStr(1, Trim(s), "'") + 1, 8)
                    End If

                End While

                sr.Close()
                dt_fecha_modificacion = InfoArchivo.LastWriteTime()
                'lblFecha.Text = InfoArchivo.LastWriteTime()

                'lblFechaQuery.Text = str_fecha_querys
            End If


            Application.DoEvents()

            '''''''''''''''''''''''''''
            ''''''''''''''''''''''''''
            If ller_video = True Then
                ller_video = False

                'fecha_enviada = fecha(str_fecha_querys)

                'lblInicioFoto.Text = Format(fecha_enviada, "MM/dd/yyyy HH:mm:ss")
                'dtpFechaEnviada.Value = fecha_enviada
                'pbVideo.Minimum = 0
                ''pbVideo.Maximum = 20
                'pbVideo.Maximum = CInt(cmbSegundos.Text) * 2
                'pbVideo.Value = 0

                'correr_video(fecha_enviada)
                lblSac.Text = str_fecha_querys

                'str_Plaza_Cobro = "184 Fco_Velasco_Duran"
                'id_plaza_cobro = 84
                'str_Cajero_Receptor = "300053"
                'id_Cajero_Receptor = "300053"
                'str_Turno_block = "06:00 - 14:00"
                'dt_Fecha_Inicio = #10/29/2013 8:33:42 AM#
                'dt_Fecha_Fin = #10/30/2013 8:33:42 AM#
                'str_delegacion = "Delegación  IV Cuernavaca"

                If objQuerys.QueryDataSet("SELECT MATRICULE, ID_SITE, DATE_DEBUT_POSTE FROM GEADBA.FIN_POSTE WHERE SAC = '" & str_fecha_querys & "'", "automatico") = 1 Then

                    str_Plaza_Cobro = "108 Tlalpan"
                    id_plaza_cobro = oDataRow("ID_SITE")
                    str_Cajero_Receptor = oDataRow("MATRICULE")
                    id_Cajero_Receptor = oDataRow("MATRICULE")
                    'str_Turno_block = "06:00 - 14:00"

                    If CInt(Format(oDataRow("DATE_DEBUT_POSTE"), "HH")) >= 22 And CInt(Format(oDataRow("DATE_DEBUT_POSTE"), "HH")) <= 23 Then
                        dt_Fecha_Inicio = DateAdd(DateInterval.Day, 1, oDataRow("DATE_DEBUT_POSTE"))
                    Else
                        dt_Fecha_Inicio = oDataRow("DATE_DEBUT_POSTE")
                    End If



                    'dt_Fecha_Fin = oDataRow("DATE_DEBUT_POSTE")
                    str_delegacion = "Delegación  IV Cuernavaca"



                    If CInt(Format(oDataRow("DATE_DEBUT_POSTE"), "HH")) >= 6 And CInt(Format(oDataRow("DATE_DEBUT_POSTE"), "HH")) < 14 Then
                        str_Turno_block = "06:00 - 14:00"
                    ElseIf CInt(Format(oDataRow("DATE_DEBUT_POSTE"), "HH")) >= 14 And CInt(Format(oDataRow("DATE_DEBUT_POSTE"), "HH")) < 22 Then
                        str_Turno_block = "14:00 - 22:00"
                    Else
                        str_Turno_block = "22:00 - 06:00"
                    End If

                    gl_bl_bolsa_automatica = True
                    gl_str_bolsa_automatica = str_fecha_querys

                    Dim frmReporte As New frmReporteador
                    frmReporte.Tag = 5
                    frmReporte.Show()

                End If


            End If

            '''''''''''''''''''''''''''
            ''''''''''''''''''''''''''
            Application.DoEvents()

            Timer1.Enabled = True
            Application.DoEvents()

        Catch ex As Exception
            MsgBox(ex.Message)
            'GoTo regresar

        End Try

    End Sub

    Private Sub rpt14_II_Click(sender As Object, e As EventArgs) Handles rpt14_II.Click

        objControl.limpia_Catalogos()

        Dim frmR1 As New frmR1
        frmR1.Tag = rpt14_II.Tag
        strLinea = rpt14_II.Text
        frmR1.MdiParent = Me
        frmR1.Show()

    End Sub

    Private Sub rptDetalle_Turno_Carril_Click(sender As Object, e As EventArgs) Handles rptDetalle_Turno_Carril.Click

        objControl.limpia_Catalogos()

        Dim frmR1 As New frmR1
        frmR1.Tag = rptDetalle_Turno_Carril.Tag
        strLinea = rptDetalle_Turno_Carril.Text
        frmR1.MdiParent = Me
        frmR1.Show()

    End Sub

    Private Sub FormatoDeIncidencias_Click(sender As Object, e As EventArgs) Handles FormatoDeIncidencias.Click
        objControl.limpia_Catalogos()

        Dim frmR1 As New frmR1
        frmR1.Tag = FormatoDeIncidencias.Tag
        strLinea = FormatoDeIncidencias.Text
        frmR1.MdiParent = Me
        frmR1.Show()
    End Sub



End Class
