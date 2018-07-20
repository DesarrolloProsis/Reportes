Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmR1

    Dim dtsPlasaCobro As New DataSet

    Private Sub frmR1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed


        MDIInicio.FileMenu.Enabled = True
        MDIInicio.ReportesMenu.Enabled = True
        MDIInicio.HelpMenu.Enabled = True


    End Sub

    Private Sub frmR1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MDIInicio.FileMenu.Enabled = False
        MDIInicio.ReportesMenu.Enabled = False
        MDIInicio.HelpMenu.Enabled = False


        Dim strConsulta As String
        Me.Text = strLinea


        If oConexion.State = ConnectionState.Closed Then
            oConexion.ConnectionString = gl_DNS
            oConexion.Open()
        End If





        strConsulta = "SELECT ID_SITE, NOM_SITE, NOM_SITE_L2, ID_SITE ||' '|| NOM_SITE as PlazaCobro " & _
               "FROM TYPE_SITE " & _
               "ORDER BY NOM_SITE"

        glstrTabla = "TYPE_SITE"

        Dim oDataAdapter = New OracleDataAdapter(strConsulta, oConexion)

        oDataAdapter.SelectCommand.CommandTimeout = 10000
        oDataAdapter.Fill(dtsPlasaCobro, glstrTabla)

        oDataAdapter = Nothing


        cmbPlazaCobro.DataSource = dtsPlasaCobro.Tables("TYPE_SITE")
        cmbPlazaCobro.DisplayMember = "PlazaCobro"
        cmbPlazaCobro.ValueMember = "ID_SITE"
        cmbPlazaCobro.SelectedValue = -1


        'strConsulta = "Select JOB_NUMBER FROM GPOS_EOJ GROUP BY JOB_NUMBER ORDER BY JOB_NUMBER"

        strConsulta = "SELECT NUMERO_POSTE, COUNT(*) AS No_Turno " & _
        "FROM FIN_POSTE " & _
        "GROUP BY NUMERO_POSTE " & _
        "ORDER BY NUMERO_POSTE"

        glstrTabla = "FIN_POSTE"



        oDataAdapter = New OracleDataAdapter(strConsulta, oConexion)

        oDataAdapter.SelectCommand.CommandTimeout = 10000
        oDataAdapter.Fill(dtsPlasaCobro, glstrTabla)

        oDataAdapter = Nothing


        '************************************* Seleccion de Encargado de Turno

        strConsulta = "SELECT MATRICULE, rtrim(NOM)||' '||rtrim(PRENOM) AS NOMBRE FROM TABLE_PERSONNEL WHERE MATRICULE LIKE '4%%%%%' ORDER BY NOM "
        glstrTabla = "TABLE_PERSONNEL"

        oDataAdapter = New OracleDataAdapter(strConsulta, oConexion)
        oDataAdapter.SelectCommand.CommandTimeout = 10000
        oDataAdapter.Fill(dtsPlasaCobro, glstrTabla)

        oDataAdapter = Nothing

        cmbEncargadoTurno.DataSource = dtsPlasaCobro.Tables("TABLE_PERSONNEL")
        cmbEncargadoTurno.DisplayMember = "NOMBRE"
        cmbEncargadoTurno.ValueMember = "MATRICULE"
        cmbEncargadoTurno.SelectedValue = 1

        '**********************************************************************

        'cmbTurno.DataSource = dtsPlasaCobro.Tables("FIN_POSTE")
        'cmbTurno.DisplayMember = "NUMERO_POSTE"
        'cmbTurno.ValueMember = "NUMERO_POSTE"
        'cmbTurno.SelectedValue = -1


        'carril
        strConsulta = "Select ID_LANE FROM GPOS_EOJ GROUP BY ID_LANE ORDER BY ID_LANE"
        glstrTabla = "ID_LANE"

        oDataAdapter = New OracleDataAdapter(strConsulta, oConexion)

        oDataAdapter.SelectCommand.CommandTimeout = 10000
        oDataAdapter.Fill(dtsPlasaCobro, glstrTabla)

        oDataAdapter = Nothing


        cmbCarril.DataSource = dtsPlasaCobro.Tables("ID_LANE")
        cmbCarril.DisplayMember = "ID_LANE"
        cmbCarril.ValueMember = "ID_LANE"
        cmbCarril.SelectedValue = -1



        'controles
        lblCajeroReceptor.Visible = False
        txtCajeroReceptor.Visible = False

        lblTurno.Visible = False
        'cmbTurno.Visible = False
        cmbTurnoBlo.Visible = False

        lblEncargadoTurno.Visible = False
        txtEncargadoTurno.Visible = False

        lblDelegacion.Visible = False
        cmbDelegacion.Visible = False

        lblEncargadoTurno.Visible = False
        cmbEncargadoTurno.Visible = False

        lblFecha2.Visible = False
        dtpFechaFin.Visible = False

        lblPlazaCobro.Visible = False
        cmbPlazaCobro.Visible = False

        lblFecha1.Visible = False
        dtpFechaInicio.Visible = False

        lblFecha2.Visible = False
        dtpFechaFin.Visible = False

        lblCarril.Visible = False
        cmbCarril.Visible = False

        txtComentario.Visible = False
        lblObservaciones.Visible = False

        Select Case Me.Tag
            Case 1

                lblFecha1.Text = "Fecha"

                lblPlazaCobro.Visible = True
                cmbPlazaCobro.Visible = True

                lblCajeroReceptor.Visible = True
                txtCajeroReceptor.Visible = True

                lblFecha1.Visible = True
                dtpFechaInicio.Visible = True

                dtpFechaInicio.Format = DateTimePickerFormat.Custom
                'dtpFechaInicio.CustomFormat = "MM/dd/yyyy"
                dtpFechaInicio.CustomFormat = "MM/dd/yyyy"

                'lblFecha2.Visible = True
                'dtpFechaFin.Visible = True

                'dtpFechaFin.Format = DateTimePickerFormat.Custom
                'dtpFechaFin.CustomFormat = "MM/dd/yyyy HH:mm"

                lblTurno.Visible = True
                'cmbTurno.Visible = True
                cmbTurnoBlo.Visible = True

                lblDelegacion.Visible = True
                cmbDelegacion.Visible = True

            Case 2

                lblFecha1.Text = "Fecha"

                lblFecha1.Visible = True
                dtpFechaInicio.Visible = True

                lblPlazaCobro.Visible = True
                cmbPlazaCobro.Visible = True

                dtpFechaInicio.Format = DateTimePickerFormat.Custom
                'dtpFechaInicio.CustomFormat = "MM/dd/yyyy"
                dtpFechaInicio.CustomFormat = "MM/dd/yyyy"


                lblTurno.Visible = True
                'cmbTurno.Visible = True
                cmbTurnoBlo.Visible = True

                'lblEncargadoTurno.Visible = True
                'txtEncargadoTurno.Visible = True

                lblDelegacion.Visible = True
                cmbDelegacion.Visible = True

            Case 3

                lblFecha1.Text = "Fecha"

                lblFecha1.Visible = True
                dtpFechaInicio.Visible = True

                lblPlazaCobro.Visible = True
                cmbPlazaCobro.Visible = True

                dtpFechaInicio.Format = DateTimePickerFormat.Custom
                'dtpFechaInicio.CustomFormat = "MM/dd/yyyy"
                dtpFechaInicio.CustomFormat = "MM/dd/yyyy"


                'lblTurno.Visible = True
                ''cmbTurno.Visible = True
                'cmbTurnoBlo.Visible = True

                'lblEncargadoTurno.Visible = True
                'txtEncargadoTurno.Visible = True

                lblDelegacion.Visible = True
                cmbDelegacion.Visible = True

                'lblFecha1.Text = "Fecha"

                'lblFecha1.Visible = True
                'dtpFechaInicio.Visible = True

                'lblPlazaCobro.Visible = True
                'cmbPlazaCobro.Visible = True

                'lblDelegacion.Visible = True
                'cmbDelegacion.Visible = True

                'dtpFechaInicio.Format = DateTimePickerFormat.Custom
                ''dtpFechaInicio.CustomFormat = "MM/dd/yyyy"
                'dtpFechaInicio.CustomFormat = "MM/dd/yyyy"


            Case 4 'bitacora de operacion

                lblDelegacion.Visible = True
                cmbDelegacion.Visible = True

                lblPlazaCobro.Visible = True
                cmbPlazaCobro.Visible = True

                lblFecha1.Visible = True
                dtpFechaInicio.Visible = True

                lblFecha2.Visible = True
                dtpFechaFin.Visible = True

                lblFecha1.Text = "Fecha Inicial"
                lblFecha2.Text = "Fecha Final"

                dtpFechaInicio.Format = DateTimePickerFormat.Custom
                'dtpFechaInicio.CustomFormat = "MM/dd/yyyy HH:mm:ss"
                dtpFechaInicio.CustomFormat = "MM/dd/yyyy HH:mm:ss"

                dtpFechaFin.Format = DateTimePickerFormat.Custom
                'dtpFechaFin.CustomFormat = "MM/dd/yyyy HH:mm:ss"
                dtpFechaFin.CustomFormat = "MM/dd/yyyy HH:mm:ss"

            Case 5, 9, 11, 14, 1411

                lblFecha1.Text = "Fecha"

                lblPlazaCobro.Visible = True
                cmbPlazaCobro.Visible = True

                lblCajeroReceptor.Visible = True
                txtCajeroReceptor.Visible = True

                lblFecha1.Visible = True
                dtpFechaInicio.Visible = True

                dtpFechaInicio.Format = DateTimePickerFormat.Custom
                'dtpFechaInicio.CustomFormat = "MM/dd/yyyy"
                dtpFechaInicio.CustomFormat = "MM/dd/yyyy"


                lblTurno.Visible = True
                'cmbTurno.Visible = True
                cmbTurnoBlo.Visible = True

                lblDelegacion.Visible = True
                cmbDelegacion.Visible = True

            Case 6, 7, 12, 15

                lblFecha1.Text = "Fecha"

                lblPlazaCobro.Visible = True
                cmbPlazaCobro.Visible = True

                'lblCajeroReceptor.Visible = True
                'txtCajeroReceptor.Visible = True

                lblFecha1.Visible = True
                dtpFechaInicio.Visible = True

                dtpFechaInicio.Format = DateTimePickerFormat.Custom
                'dtpFechaInicio.CustomFormat = "MM/dd/yyyy"
                dtpFechaInicio.CustomFormat = "MM/dd/yyyy"


                lblTurno.Visible = True
                'cmbTurno.Visible = True
                cmbTurnoBlo.Visible = True

                lblDelegacion.Visible = True
                cmbDelegacion.Visible = True

                'ComboBox de Encargado de turno
                lblEncargadoTurno.Visible = True
                cmbEncargadoTurno.Visible = True

                'Redimensionar Formulario
                Me.Size = New Size(313, 480)
                btnGenerarReporte.Location = New Point(12, 400)
                btnAutomatico.Location = New Point(161, 400)

                'Se activa visualización de TextBox para comantarios
                txtComentario.Visible = True
                lblObservaciones.Visible = True

                'Case 7

                '    lblFecha1.Text = "Fecha"

                '    lblPlazaCobro.Visible = True
                '    cmbPlazaCobro.Visible = True

                '    lblCajeroReceptor.Visible = True
                '    txtCajeroReceptor.Visible = True

                '    lblFecha1.Visible = True
                '    dtpFechaInicio.Visible = True

                '    dtpFechaInicio.Format = DateTimePickerFormat.Custom
                '    'dtpFechaInicio.CustomFormat = "MM/dd/yyyy"
                '    dtpFechaInicio.CustomFormat = "MM/dd/yyyy"


                '    lblTurno.Visible = True
                '    'cmbTurno.Visible = True

                '    lblDelegacion.Visible = True
                '    cmbDelegacion.Visible = True

            Case 8, 10, 13, 16
                lblFecha1.Text = "Fecha"

                lblPlazaCobro.Visible = True
                cmbPlazaCobro.Visible = True

                'lblCajeroReceptor.Visible = True
                'txtCajeroReceptor.Visible = True

                lblFecha1.Visible = True
                dtpFechaInicio.Visible = True

                dtpFechaInicio.Format = DateTimePickerFormat.Custom
                'dtpFechaInicio.CustomFormat = "MM/dd/yyyy"
                dtpFechaInicio.CustomFormat = "MM/dd/yyyy"


                'lblTurno.Visible = True
                'cmbTurno.Visible = True
                'cmbTurnoBlo.Visible = True

                lblDelegacion.Visible = True
                cmbDelegacion.Visible = True

                'ComboBox de Encargado de turno
                lblEncargadoTurno.Visible = True
                cmbEncargadoTurno.Visible = True

                'Redimensionar Formulario
                Me.Size = New Size(313, 480)
                btnGenerarReporte.Location = New Point(12, 400)
                btnAutomatico.Location = New Point(161, 400)

                'Se activa visualización de TextBox para comantarios
                txtComentario.Visible = True
                lblObservaciones.Visible = True

            Case 9

                lblFecha1.Text = "Fecha"

                lblPlazaCobro.Visible = True
                cmbPlazaCobro.Visible = True

                lblCajeroReceptor.Visible = True
                txtCajeroReceptor.Visible = True

                lblFecha1.Visible = True
                dtpFechaInicio.Visible = True

                dtpFechaInicio.Format = DateTimePickerFormat.Custom
                'dtpFechaInicio.CustomFormat = "MM/dd/yyyy"
                dtpFechaInicio.CustomFormat = "MM/dd/yyyy"


                lblTurno.Visible = True
                'cmbTurno.Visible = True

                lblDelegacion.Visible = True
                cmbDelegacion.Visible = True

        End Select

    End Sub

    Private Sub generar_reporte()

        Dim strQuerys As String
        'Dim frmReporte As New frmReporte
        'frmReporte.Tag = Me.Tag
        'frmReporte.MdiParent = MDIInicio
        'frmReporte.Show()

        objControl.limpia_Catalogos()


        Dim frmReporte As New frmReporteador

        frmReporte.Tag = Me.Tag
        'frmReporte.MdiParent = MDIInicio

        Select Case Me.Tag
            Case 1

                If cmbDelegacion.Text = "" Then
                    MsgBox("Favor de seleccionar la delegación", MsgBoxStyle.Information, "Verificar")
                    Exit Sub
                End If

                If cmbPlazaCobro.SelectedValue = Nothing Then
                    MsgBox("Favor de seleccionar la plaza de cobro", MsgBoxStyle.Information, "Verificar")
                    Exit Sub
                End If

                If Not IsNumeric(txtCajeroReceptor.Text) Then
                    MsgBox("Favor de seleccionar cajero-receptor", MsgBoxStyle.Information, "Verificar")
                    Exit Sub
                End If

                'If cmbTurno.SelectedValue = Nothing Then
                '    MsgBox("Favor de seleccionar el turno", MsgBoxStyle.Information, "Verificar")
                '    Exit Sub
                'End If

                If cmbTurnoBlo.Text = "" Then
                    MsgBox("Favor de seleccionar el turno", MsgBoxStyle.Information, "Verificar")
                    Exit Sub
                End If

                str_Plaza_Cobro = "1" & cmbPlazaCobro.Text
                id_plaza_cobro = cmbPlazaCobro.SelectedValue

                str_Cajero_Receptor = Trim(txtCajeroReceptor.Text)
                id_Cajero_Receptor = CDbl(txtCajeroReceptor.Text)

                'id_Turno = CDbl(cmbTurno.Text)
                str_Turno_block = Trim(cmbTurnoBlo.Text)


                dt_Fecha_Inicio = dtpFechaInicio.Value
                'dt_Fecha_Fin = dtpFechaFin.Value

                str_delegacion = cmbDelegacion.Text


            Case 2

                If cmbDelegacion.Text = "" Then
                    MsgBox("Favor de seleccionar la delegación", MsgBoxStyle.Information, "Verificar")
                    Exit Sub
                End If

                If cmbPlazaCobro.SelectedValue = Nothing Then
                    MsgBox("Favor de seleccionar la plaza de cobro", MsgBoxStyle.Information, "Verificar")
                    Exit Sub
                End If

                'If Not IsNumeric(txtEncargadoTurno.Text) Then
                '    MsgBox("Favor de seleccionar el encargado en turno", MsgBoxStyle.Information, "Verificar")
                '    Exit Sub
                'End If

                'If cmbTurno.SelectedValue = Nothing Then
                '    MsgBox("Favor de seleccionar el turno", MsgBoxStyle.Information, "Verificar")
                '    Exit Sub
                'End If

                If cmbTurnoBlo.Text = "" Then
                    MsgBox("Favor de seleccionar el turno", MsgBoxStyle.Information, "Verificar")
                    Exit Sub
                End If


                objControl.limpia_Catalogos()

                str_Plaza_Cobro = "1" & cmbPlazaCobro.Text
                id_plaza_cobro = cmbPlazaCobro.SelectedValue

                str_Turno_block = Trim(cmbTurnoBlo.Text)

                dt_Fecha_Inicio = dtpFechaInicio.Value
                'dt_Fecha_Fin = dtpFechaFin.Value

                str_delegacion = cmbDelegacion.Text



            Case 3

                If cmbDelegacion.Text = "" Then
                    MsgBox("Favor de seleccionar la delegación", MsgBoxStyle.Information, "Verificar")
                    Exit Sub
                End If

                If cmbPlazaCobro.SelectedValue = Nothing Then
                    MsgBox("Favor de seleccionar la plaza de cobro", MsgBoxStyle.Information, "Verificar")
                    Exit Sub
                End If

                'If Not IsNumeric(txtEncargadoTurno.Text) Then
                '    MsgBox("Favor de seleccionar el encargado en turno", MsgBoxStyle.Information, "Verificar")
                '    Exit Sub
                'End If

                'If cmbTurno.SelectedValue = Nothing Then
                '    MsgBox("Favor de seleccionar el turno", MsgBoxStyle.Information, "Verificar")
                '    Exit Sub
                'End If

                'If cmbTurnoBlo.Text = "" Then
                '    MsgBox("Favor de seleccionar el turno", MsgBoxStyle.Information, "Verificar")
                '    Exit Sub
                'End If


                objControl.limpia_Catalogos()

                str_Plaza_Cobro = "1" & cmbPlazaCobro.Text
                id_plaza_cobro = cmbPlazaCobro.SelectedValue

                'str_Turno_block = Trim(cmbTurnoBlo.Text)

                dt_Fecha_Inicio = dtpFechaInicio.Value
                'dt_Fecha_Fin = dtpFechaFin.Value

                str_delegacion = cmbDelegacion.Text



            Case 4 'bitacora de operacion

                If cmbDelegacion.Text = "" Then
                    MsgBox("Favor de seleccionar la delegación", MsgBoxStyle.Information, "Verificar")
                    Exit Sub
                End If

                If cmbPlazaCobro.SelectedValue = Nothing Then
                    MsgBox("Favor de seleccionar la plaza de cobro", MsgBoxStyle.Information, "Verificar")
                    Exit Sub
                End If

                objControl.limpia_Catalogos()

                'strQuerys = "SELECT OPERATING_DATE, BOJ_DHM, JOB_NUMBER, EOJ_DHM, ID_LANE, ID_STAFF FROM GPOS_EOJ "

                ''If IsNumeric(Trim(txtPlazaCobro.Tag)) Then
                'strQuerys = strQuerys & "where ID_PLAZA = '" & cmbPlazaCobro.SelectedValue & "' "
                ''End If

                'strQuerys = strQuerys & "and BOJ_DHM >= to_date('" & Format(dtpFechaInicio.Value, "yyyy/MMM/dd") & " 00:00:00', 'YYYY-MON-DD HH24:MI:SS') AND BOJ_DHM <= to_date('" & Format(dtpFechaFin.Value, "yyyy/MMM/dd") & " 23:59:59', 'YYYY-MON-DD HH24:MI:SS') "

                'strQuerys = strQuerys & "ORDER BY BOJ_DHM"

                'strLinea = strQuerys

                str_Plaza_Cobro = "1" & cmbPlazaCobro.Text
                id_plaza_cobro = cmbPlazaCobro.SelectedValue

                dt_Fecha_Inicio = dtpFechaInicio.Value
                dt_Fecha_Fin = dtpFechaFin.Value

                str_delegacion = cmbDelegacion.Text

            Case 5, 9, 11, 14, 1411
                'Preliquidación de Cajero-Receptor para Tránsito Vehicular

                If cmbDelegacion.Text = "" Then
                    MsgBox("Favor de seleccionar la delegación", MsgBoxStyle.Information, "Verificar")
                    Exit Sub
                End If

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''Inicio
                If cmbPlazaCobro.SelectedValue = Nothing Then
                    MsgBox("Favor de seleccionar la plaza de cobro", MsgBoxStyle.Information, "Verificar")
                    Exit Sub
                End If

                If Not IsNumeric(txtCajeroReceptor.Text) Then
                    MsgBox("Favor de seleccionar cajero-receptor", MsgBoxStyle.Information, "Verificar")
                    Exit Sub
                End If

                'If cmbTurno.SelectedValue = Nothing Then
                '    MsgBox("Favor de seleccionar el turno", MsgBoxStyle.Information, "Verificar")
                '    Exit Sub
                'End If

                If cmbTurnoBlo.Text = "" Then
                    MsgBox("Favor de seleccionar el turno", MsgBoxStyle.Information, "Verificar")
                    Exit Sub
                End If


                str_Plaza_Cobro = "1" & cmbPlazaCobro.Text
                id_plaza_cobro = cmbPlazaCobro.SelectedValue

                str_Cajero_Receptor = Trim(txtCajeroReceptor.Text)
                id_Cajero_Receptor = CDbl(txtCajeroReceptor.Text)

                'id_Turno = CDbl(cmbTurno.Text)
                str_Turno_block = Trim(cmbTurnoBlo.Text)

                dt_Fecha_Inicio = dtpFechaInicio.Value
                dt_Fecha_Fin = dtpFechaFin.Value

                str_delegacion = cmbDelegacion.Text

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''Fin






            Case 6, 7, 12, 15

                If cmbDelegacion.Text = "" Then
                    MsgBox("Favor de seleccionar la delegación", MsgBoxStyle.Information, "Verificar")
                    Exit Sub
                End If

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''Inicio
                If cmbPlazaCobro.SelectedValue = Nothing Then
                    MsgBox("Favor de seleccionar la plaza de cobro", MsgBoxStyle.Information, "Verificar")
                    Exit Sub
                End If

                'If Not IsNumeric(txtCajeroReceptor.Text) Then
                '    MsgBox("Favor de seleccionar cajero-receptor", MsgBoxStyle.Information, "Verificar")
                '    Exit Sub
                'End If

                'If cmbTurno.SelectedValue = Nothing Then
                '    MsgBox("Favor de seleccionar el turno", MsgBoxStyle.Information, "Verificar")
                '    Exit Sub
                'End If

                If cmbTurnoBlo.Text = "" Then
                    MsgBox("Favor de seleccionar el turno", MsgBoxStyle.Information, "Verificar")
                    Exit Sub
                End If


                str_Plaza_Cobro = "1" & cmbPlazaCobro.Text
                id_plaza_cobro = cmbPlazaCobro.SelectedValue

                'str_Cajero_Receptor = Trim(txtCajeroReceptor.Text)
                'id_Cajero_Receptor = CDbl(txtCajeroReceptor.Text)

                'id_Turno = CDbl(cmbTurno.Text)
                str_Turno_block = Trim(cmbTurnoBlo.Text)

                dt_Fecha_Inicio = dtpFechaInicio.Value
                dt_Fecha_Fin = dtpFechaFin.Value

                str_delegacion = cmbDelegacion.Text

                srt_Encargado_Reporte = cmbEncargadoTurno.Text
                int_Encargado_Reporte = cmbEncargadoTurno.SelectedValue

                GetObservations()

                'Case 7

                '    If cmbPlazaCobro.SelectedValue = Nothing Then
                '        MsgBox("Favor de seleccionar la plaza de cobro", MsgBoxStyle.Information, "Verificar")
                '        Exit Sub
                '    End If

                '    If Not IsNumeric(txtCajeroReceptor.Text) Then
                '        MsgBox("Favor de seleccionar cajero-receptor", MsgBoxStyle.Information, "Verificar")
                '        Exit Sub
                '    End If



                '    strQuerys = "SELECT GPOS_EOJ.OPERATING_DATE, GPOS_EOJ.ID_PLAZA, TYPE_SITE.NOM_SITE, GPOS_EOJ.ID_STAFF, " & _
                '       "TABLE_PERSONNEL.NOM, TABLE_PERSONNEL.PRENOM, GPOS_EOJ.ID_LANE, GPOS_EOJ.JOB_NUMBER, " & _
                '       "GPOS_EOJ.BOJ_DHM, GPOS_EOJ.EOJ_DHM " & _
                '       "FROM GPOS_EOJ, TYPE_SITE, TABLE_PERSONNEL " & _
                '       "WHERE GPOS_EOJ.ID_PLAZA = TYPE_SITE.ID_SITE And GPOS_EOJ.ID_STAFF = TABLE_PERSONNEL.MATRICULE "

                '    If cmbPlazaCobro.SelectedValue Then
                '        strQuerys = strQuerys & "and ID_PLAZA = '" & cmbPlazaCobro.SelectedValue & "' "
                '    End If
                '    If IsNumeric(Trim(txtCajeroReceptor.Text)) Then
                '        strQuerys = strQuerys & "and ID_STAFF = '" & Trim(txtCajeroReceptor.Text) & "' "
                '    ElseIf IsNumeric(Trim(txtCajeroReceptor.Text)) Then
                '        strQuerys = strQuerys & "and ID_STAFF = '" & Trim(txtCajeroReceptor.Text) & "' "
                '    Else
                '        MsgBox("Favor de seleccionar al Cajero-Receptor")
                '        Exit Sub
                '    End If

                '    'cbmTurno


                '    strQuerys = strQuerys & "and BOJ_DHM >= to_date('" & Format(dtpFechaInicio.Value, "yyyy/MM/dd ") & "00:00:00', 'YYYY-MM-DD HH24:MI:SS') AND BOJ_DHM <= to_date('" & Format(dtpFechaInicio.Value, "yyyy/MM/dd") & " 23:59:59', 'YYYY-MM-DD HH24:MI:SS') "

                '    strQuerys = strQuerys & "ORDER BY GPOS_EOJ.ID_STAFF, GPOS_EOJ.BOJ_DHM"

                '    'plaza de cobro
                '    strLinea = strQuerys

            Case 8, 10, 13, 16
                If cmbDelegacion.Text = "" Then
                    MsgBox("Favor de seleccionar la delegación", MsgBoxStyle.Information, "Verificar")
                    Exit Sub
                End If

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''Inicio
                If cmbPlazaCobro.SelectedValue = Nothing Then
                    MsgBox("Favor de seleccionar la plaza de cobro", MsgBoxStyle.Information, "Verificar")
                    Exit Sub
                End If

                'If Not IsNumeric(txtCajeroReceptor.Text) Then
                '    MsgBox("Favor de seleccionar cajero-receptor", MsgBoxStyle.Information, "Verificar")
                '    Exit Sub
                'End If

                'If cmbTurno.SelectedValue = Nothing Then
                '    MsgBox("Favor de seleccionar el turno", MsgBoxStyle.Information, "Verificar")
                '    Exit Sub
                'End If

                'If cmbTurnoBlo.Text = "" Then
                '    MsgBox("Favor de seleccionar el turno", MsgBoxStyle.Information, "Verificar")
                '    Exit Sub
                'End If


                str_Plaza_Cobro = "1" & cmbPlazaCobro.Text
                id_plaza_cobro = cmbPlazaCobro.SelectedValue

                'str_Cajero_Receptor = Trim(txtCajeroReceptor.Text)
                'id_Cajero_Receptor = CDbl(txtCajeroReceptor.Text)

                'id_Turno = CDbl(cmbTurno.Text)
                'str_Turno_block = Trim(cmbTurnoBlo.Text)

                dt_Fecha_Inicio = dtpFechaInicio.Value
                dt_Fecha_Fin = dtpFechaFin.Value

                str_delegacion = cmbDelegacion.Text

                srt_Encargado_Reporte = cmbEncargadoTurno.Text
                int_Encargado_Reporte = cmbEncargadoTurno.SelectedValue

                GetObservations()

        End Select

        'frmReporte.ShowDialog()
        frmReporte.Show()


    End Sub

    Private Sub btnGenerarReporte_Click(sender As Object, e As EventArgs) Handles btnGenerarReporte.Click

        generar_reporte()

        'Dim strQuerys As String
        ''Dim frmReporte As New frmReporte
        ''frmReporte.Tag = Me.Tag
        ''frmReporte.MdiParent = MDIInicio
        ''frmReporte.Show()

        'objControl.limpia_Catalogos()


        'Dim frmReporte As New frmReporteador
        'frmReporte.Tag = Me.Tag
        ''frmReporte.MdiParent = MDIInicio

        'Select Case Me.Tag
        '    Case 1

        '        If cmbDelegacion.Text = "" Then
        '            MsgBox("Favor de seleccionar la delegación", MsgBoxStyle.Information, "Verificar")
        '            Exit Sub
        '        End If

        '        If cmbPlazaCobro.SelectedValue = Nothing Then
        '            MsgBox("Favor de seleccionar la plaza de cobro", MsgBoxStyle.Information, "Verificar")
        '            Exit Sub
        '        End If

        '        If Not IsNumeric(txtCajeroReceptor.Text) Then
        '            MsgBox("Favor de seleccionar cajero-receptor", MsgBoxStyle.Information, "Verificar")
        '            Exit Sub
        '        End If

        '        'If cmbTurno.SelectedValue = Nothing Then
        '        '    MsgBox("Favor de seleccionar el turno", MsgBoxStyle.Information, "Verificar")
        '        '    Exit Sub
        '        'End If

        '        If cmbTurnoBlo.Text = "" Then
        '            MsgBox("Favor de seleccionar el turno", MsgBoxStyle.Information, "Verificar")
        '            Exit Sub
        '        End If

        '        str_Plaza_Cobro = "1" & cmbPlazaCobro.Text
        '        id_plaza_cobro = cmbPlazaCobro.SelectedValue

        '        str_Cajero_Receptor = Trim(txtCajeroReceptor.Text)
        '        id_Cajero_Receptor = CDbl(txtCajeroReceptor.Text)

        '        'id_Turno = CDbl(cmbTurno.Text)
        '        str_Turno_block = Trim(cmbTurnoBlo.Text)


        '        dt_Fecha_Inicio = dtpFechaInicio.Value
        '        'dt_Fecha_Fin = dtpFechaFin.Value

        '        str_delegacion = cmbDelegacion.Text


        '    Case 2

        '        If cmbDelegacion.Text = "" Then
        '            MsgBox("Favor de seleccionar la delegación", MsgBoxStyle.Information, "Verificar")
        '            Exit Sub
        '        End If

        '        If cmbPlazaCobro.SelectedValue = Nothing Then
        '            MsgBox("Favor de seleccionar la plaza de cobro", MsgBoxStyle.Information, "Verificar")
        '            Exit Sub
        '        End If

        '        'If Not IsNumeric(txtEncargadoTurno.Text) Then
        '        '    MsgBox("Favor de seleccionar el encargado en turno", MsgBoxStyle.Information, "Verificar")
        '        '    Exit Sub
        '        'End If

        '        'If cmbTurno.SelectedValue = Nothing Then
        '        '    MsgBox("Favor de seleccionar el turno", MsgBoxStyle.Information, "Verificar")
        '        '    Exit Sub
        '        'End If

        '        If cmbTurnoBlo.Text = "" Then
        '            MsgBox("Favor de seleccionar el turno", MsgBoxStyle.Information, "Verificar")
        '            Exit Sub
        '        End If


        '        objControl.limpia_Catalogos()

        '        str_Plaza_Cobro = "1" & cmbPlazaCobro.Text
        '        id_plaza_cobro = cmbPlazaCobro.SelectedValue

        '        str_Turno_block = Trim(cmbTurnoBlo.Text)

        '        dt_Fecha_Inicio = dtpFechaInicio.Value
        '        'dt_Fecha_Fin = dtpFechaFin.Value

        '        str_delegacion = cmbDelegacion.Text



        '    Case 3

        '        If cmbDelegacion.Text = "" Then
        '            MsgBox("Favor de seleccionar la delegación", MsgBoxStyle.Information, "Verificar")
        '            Exit Sub
        '        End If

        '        If cmbPlazaCobro.SelectedValue = Nothing Then
        '            MsgBox("Favor de seleccionar la plaza de cobro", MsgBoxStyle.Information, "Verificar")
        '            Exit Sub
        '        End If

        '        'If Not IsNumeric(txtEncargadoTurno.Text) Then
        '        '    MsgBox("Favor de seleccionar el encargado en turno", MsgBoxStyle.Information, "Verificar")
        '        '    Exit Sub
        '        'End If

        '        'If cmbTurno.SelectedValue = Nothing Then
        '        '    MsgBox("Favor de seleccionar el turno", MsgBoxStyle.Information, "Verificar")
        '        '    Exit Sub
        '        'End If

        '        'If cmbTurnoBlo.Text = "" Then
        '        '    MsgBox("Favor de seleccionar el turno", MsgBoxStyle.Information, "Verificar")
        '        '    Exit Sub
        '        'End If


        '        objControl.limpia_Catalogos()

        '        str_Plaza_Cobro = "1" & cmbPlazaCobro.Text
        '        id_plaza_cobro = cmbPlazaCobro.SelectedValue

        '        'str_Turno_block = Trim(cmbTurnoBlo.Text)

        '        dt_Fecha_Inicio = dtpFechaInicio.Value
        '        'dt_Fecha_Fin = dtpFechaFin.Value

        '        str_delegacion = cmbDelegacion.Text



        '    Case 4 'bitacora de operacion

        '        If cmbDelegacion.Text = "" Then
        '            MsgBox("Favor de seleccionar la delegación", MsgBoxStyle.Information, "Verificar")
        '            Exit Sub
        '        End If

        '        If cmbPlazaCobro.SelectedValue = Nothing Then
        '            MsgBox("Favor de seleccionar la plaza de cobro", MsgBoxStyle.Information, "Verificar")
        '            Exit Sub
        '        End If

        '        objControl.limpia_Catalogos()

        '        'strQuerys = "SELECT OPERATING_DATE, BOJ_DHM, JOB_NUMBER, EOJ_DHM, ID_LANE, ID_STAFF FROM GPOS_EOJ "

        '        ''If IsNumeric(Trim(txtPlazaCobro.Tag)) Then
        '        'strQuerys = strQuerys & "where ID_PLAZA = '" & cmbPlazaCobro.SelectedValue & "' "
        '        ''End If

        '        'strQuerys = strQuerys & "and BOJ_DHM >= to_date('" & Format(dtpFechaInicio.Value, "yyyy/MMM/dd") & " 00:00:00', 'YYYY-MON-DD HH24:MI:SS') AND BOJ_DHM <= to_date('" & Format(dtpFechaFin.Value, "yyyy/MMM/dd") & " 23:59:59', 'YYYY-MON-DD HH24:MI:SS') "

        '        'strQuerys = strQuerys & "ORDER BY BOJ_DHM"

        '        'strLinea = strQuerys

        '        str_Plaza_Cobro = "1" & cmbPlazaCobro.Text
        '        id_plaza_cobro = cmbPlazaCobro.SelectedValue

        '        dt_Fecha_Inicio = dtpFechaInicio.Value
        '        dt_Fecha_Fin = dtpFechaFin.Value

        '        str_delegacion = cmbDelegacion.Text

        '    Case 5, 9, 11, 14
        '        'Preliquidación de Cajero-Receptor para Tránsito Vehicular

        '        If cmbDelegacion.Text = "" Then
        '            MsgBox("Favor de seleccionar la delegación", MsgBoxStyle.Information, "Verificar")
        '            Exit Sub
        '        End If

        '        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''Inicio
        '        If cmbPlazaCobro.SelectedValue = Nothing Then
        '            MsgBox("Favor de seleccionar la plaza de cobro", MsgBoxStyle.Information, "Verificar")
        '            Exit Sub
        '        End If

        '        If Not IsNumeric(txtCajeroReceptor.Text) Then
        '            MsgBox("Favor de seleccionar cajero-receptor", MsgBoxStyle.Information, "Verificar")
        '            Exit Sub
        '        End If

        '        'If cmbTurno.SelectedValue = Nothing Then
        '        '    MsgBox("Favor de seleccionar el turno", MsgBoxStyle.Information, "Verificar")
        '        '    Exit Sub
        '        'End If

        '        If cmbTurnoBlo.Text = "" Then
        '            MsgBox("Favor de seleccionar el turno", MsgBoxStyle.Information, "Verificar")
        '            Exit Sub
        '        End If


        '        str_Plaza_Cobro = "1" & cmbPlazaCobro.Text
        '        id_plaza_cobro = cmbPlazaCobro.SelectedValue

        '        str_Cajero_Receptor = Trim(txtCajeroReceptor.Text)
        '        id_Cajero_Receptor = CDbl(txtCajeroReceptor.Text)

        '        'id_Turno = CDbl(cmbTurno.Text)
        '        str_Turno_block = Trim(cmbTurnoBlo.Text)

        '        dt_Fecha_Inicio = dtpFechaInicio.Value
        '        dt_Fecha_Fin = dtpFechaFin.Value

        '        str_delegacion = cmbDelegacion.Text

        '        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''Fin






        '    Case 6, 7, 12, 15

        '        If cmbDelegacion.Text = "" Then
        '            MsgBox("Favor de seleccionar la delegación", MsgBoxStyle.Information, "Verificar")
        '            Exit Sub
        '        End If

        '        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''Inicio
        '        If cmbPlazaCobro.SelectedValue = Nothing Then
        '            MsgBox("Favor de seleccionar la plaza de cobro", MsgBoxStyle.Information, "Verificar")
        '            Exit Sub
        '        End If

        '        'If Not IsNumeric(txtCajeroReceptor.Text) Then
        '        '    MsgBox("Favor de seleccionar cajero-receptor", MsgBoxStyle.Information, "Verificar")
        '        '    Exit Sub
        '        'End If

        '        'If cmbTurno.SelectedValue = Nothing Then
        '        '    MsgBox("Favor de seleccionar el turno", MsgBoxStyle.Information, "Verificar")
        '        '    Exit Sub
        '        'End If

        '        If cmbTurnoBlo.Text = "" Then
        '            MsgBox("Favor de seleccionar el turno", MsgBoxStyle.Information, "Verificar")
        '            Exit Sub
        '        End If


        '        str_Plaza_Cobro = "1" & cmbPlazaCobro.Text
        '        id_plaza_cobro = cmbPlazaCobro.SelectedValue

        '        'str_Cajero_Receptor = Trim(txtCajeroReceptor.Text)
        '        'id_Cajero_Receptor = CDbl(txtCajeroReceptor.Text)

        '        'id_Turno = CDbl(cmbTurno.Text)
        '        str_Turno_block = Trim(cmbTurnoBlo.Text)

        '        dt_Fecha_Inicio = dtpFechaInicio.Value
        '        dt_Fecha_Fin = dtpFechaFin.Value

        '        str_delegacion = cmbDelegacion.Text




        '        'Case 7

        '        '    If cmbPlazaCobro.SelectedValue = Nothing Then
        '        '        MsgBox("Favor de seleccionar la plaza de cobro", MsgBoxStyle.Information, "Verificar")
        '        '        Exit Sub
        '        '    End If

        '        '    If Not IsNumeric(txtCajeroReceptor.Text) Then
        '        '        MsgBox("Favor de seleccionar cajero-receptor", MsgBoxStyle.Information, "Verificar")
        '        '        Exit Sub
        '        '    End If



        '        '    strQuerys = "SELECT GPOS_EOJ.OPERATING_DATE, GPOS_EOJ.ID_PLAZA, TYPE_SITE.NOM_SITE, GPOS_EOJ.ID_STAFF, " & _
        '        '       "TABLE_PERSONNEL.NOM, TABLE_PERSONNEL.PRENOM, GPOS_EOJ.ID_LANE, GPOS_EOJ.JOB_NUMBER, " & _
        '        '       "GPOS_EOJ.BOJ_DHM, GPOS_EOJ.EOJ_DHM " & _
        '        '       "FROM GPOS_EOJ, TYPE_SITE, TABLE_PERSONNEL " & _
        '        '       "WHERE GPOS_EOJ.ID_PLAZA = TYPE_SITE.ID_SITE And GPOS_EOJ.ID_STAFF = TABLE_PERSONNEL.MATRICULE "

        '        '    If cmbPlazaCobro.SelectedValue Then
        '        '        strQuerys = strQuerys & "and ID_PLAZA = '" & cmbPlazaCobro.SelectedValue & "' "
        '        '    End If
        '        '    If IsNumeric(Trim(txtCajeroReceptor.Text)) Then
        '        '        strQuerys = strQuerys & "and ID_STAFF = '" & Trim(txtCajeroReceptor.Text) & "' "
        '        '    ElseIf IsNumeric(Trim(txtCajeroReceptor.Text)) Then
        '        '        strQuerys = strQuerys & "and ID_STAFF = '" & Trim(txtCajeroReceptor.Text) & "' "
        '        '    Else
        '        '        MsgBox("Favor de seleccionar al Cajero-Receptor")
        '        '        Exit Sub
        '        '    End If

        '        '    'cbmTurno


        '        '    strQuerys = strQuerys & "and BOJ_DHM >= to_date('" & Format(dtpFechaInicio.Value, "yyyy/MM/dd ") & "00:00:00', 'YYYY-MM-DD HH24:MI:SS') AND BOJ_DHM <= to_date('" & Format(dtpFechaInicio.Value, "yyyy/MM/dd") & " 23:59:59', 'YYYY-MM-DD HH24:MI:SS') "

        '        '    strQuerys = strQuerys & "ORDER BY GPOS_EOJ.ID_STAFF, GPOS_EOJ.BOJ_DHM"

        '        '    'plaza de cobro
        '        '    strLinea = strQuerys

        '    Case 8, 10, 13, 16
        '        If cmbDelegacion.Text = "" Then
        '            MsgBox("Favor de seleccionar la delegación", MsgBoxStyle.Information, "Verificar")
        '            Exit Sub
        '        End If

        '        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''Inicio
        '        If cmbPlazaCobro.SelectedValue = Nothing Then
        '            MsgBox("Favor de seleccionar la plaza de cobro", MsgBoxStyle.Information, "Verificar")
        '            Exit Sub
        '        End If

        '        'If Not IsNumeric(txtCajeroReceptor.Text) Then
        '        '    MsgBox("Favor de seleccionar cajero-receptor", MsgBoxStyle.Information, "Verificar")
        '        '    Exit Sub
        '        'End If

        '        'If cmbTurno.SelectedValue = Nothing Then
        '        '    MsgBox("Favor de seleccionar el turno", MsgBoxStyle.Information, "Verificar")
        '        '    Exit Sub
        '        'End If

        '        'If cmbTurnoBlo.Text = "" Then
        '        '    MsgBox("Favor de seleccionar el turno", MsgBoxStyle.Information, "Verificar")
        '        '    Exit Sub
        '        'End If


        '        str_Plaza_Cobro = "1" & cmbPlazaCobro.Text
        '        id_plaza_cobro = cmbPlazaCobro.SelectedValue

        '        'str_Cajero_Receptor = Trim(txtCajeroReceptor.Text)
        '        'id_Cajero_Receptor = CDbl(txtCajeroReceptor.Text)

        '        'id_Turno = CDbl(cmbTurno.Text)
        '        'str_Turno_block = Trim(cmbTurnoBlo.Text)

        '        dt_Fecha_Inicio = dtpFechaInicio.Value
        '        dt_Fecha_Fin = dtpFechaFin.Value

        '        str_delegacion = cmbDelegacion.Text





        'End Select

        ''frmReporte.ShowDialog()
        'frmReporte.Show()


    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub btnAutomatico_Click(sender As Object, e As EventArgs) Handles btnAutomatico.Click

        Dim strQuerys As String
        Dim h_inicio_turno As Date
        Dim h_fin_turno As Date
        Dim No_Turno As String

        strQuerys = "SELECT GEADBA.FIN_POSTE.ID_RESEAU, GEADBA.FIN_POSTE.ID_GARE, GEADBA.TYPE_VOIE.LIBELLE_COURT_VOIE_L2, GEADBA.FIN_POSTE.VOIE, TO_CHAR(GEADBA.FIN_POSTE.NUMERO_POSTE, 'FM09') AS Expr1, " &
"TO_CHAR(GEADBA.FIN_POSTE.DATE_FIN_POSTE, 'MM/DD/YY') AS Expr2, TO_CHAR(GEADBA.FIN_POSTE.DATE_FIN_POSTE, 'HH24:MI') AS Expr3, " &
"GEADBA.FIN_POSTE.MATRICULE, GEADBA.FIN_POSTE.SAC AS Expr4, GEADBA.FIN_POSTE.ID_VOIE, " &
"TO_CHAR(GEADBA.FIN_POSTE.DATE_DEBUT_POSTE, 'YYYYMMDDHH24MISS') AS Expr5, TO_CHAR(GEADBA.FIN_POSTE.DATE_FIN_POSTE, 'YYYYMMDDHH24MISS') AS Expr6, GEADBA.TYPE_VOIE.LIBELLE_COURT_VOIE, 0 AS Expr7, " &
"FOLIO_NUMBER_CLOSE, INITIAL_EVENT_NUMBER, FINAL_EVENT_NUMBER " &
"FROM GEADBA.TYPE_VOIE, GEADBA.FIN_POSTE, GEADBA.SITE_GARE " &
"WHERE GEADBA.TYPE_VOIE.ID_VOIE = GEADBA.FIN_POSTE.ID_VOIE AND GEADBA.FIN_POSTE.ID_RESEAU = GEADBA.SITE_GARE.ID_RESEAU AND " &
"GEADBA.FIN_POSTE.ID_GARE = GEADBA.SITE_GARE.ID_GARE AND (GEADBA.SITE_GARE.ID_RESEAU = '01') AND " &
"(GEADBA.FIN_POSTE.ID_MODE_VOIE IN (1, 6, 7)) "


        If Mid(Trim(str_Turno_block), 1, 2) = "06" Then
            h_inicio_turno = CDate(Format(dt_Fecha_Inicio, "MM/dd/yyyy") & " 06:00:00")
            h_fin_turno = CDate(Format(dt_Fecha_Inicio, "MM/dd/yyyy") & " 13:59:59")
            No_Turno = "2 MATUTINO"
        ElseIf Mid(Trim(str_Turno_block), 1, 2) = "14" Then
            h_inicio_turno = CDate(Format(dt_Fecha_Inicio, "MM/dd/yyyy") & " 14:00:00")
            h_fin_turno = CDate(Format(dt_Fecha_Inicio, "MM/dd/yyyy") & " 21:59:59")
            No_Turno = "3 VESPERTINO"
        ElseIf Mid(Trim(str_Turno_block), 1, 2) = "22" Then
            'h_inicio_turno = CDate(Format(dt_Fecha_Inicio, "MM/dd/yyyy") & " 14:00:00")
            h_inicio_turno = CDate(Format(DateAdd(DateInterval.Day, -1, dt_Fecha_Inicio), "MM/dd/yyyy") & " 22:00:00")
            'h_fin_turno = CDate(Format(DateAdd(DateInterval.Day, 1, dt_Fecha_Inicio), "MM/dd/yyyy") & " 05:59:59")
            h_fin_turno = CDate(Format(dt_Fecha_Inicio, "MM/dd/yyyy") & " 05:59:59")
            No_Turno = "1 NOCTURNO"
        End If

        strQuerys = strQuerys & "AND (GEADBA.FIN_POSTE.DATE_DEBUT_POSTE >= TO_DATE('" & Format(h_inicio_turno, "yyyyMMddHHmmss") & "', 'YYYYMMDDHH24MISS')) AND " &
   "(GEADBA.FIN_POSTE.DATE_DEBUT_POSTE <= TO_DATE('" & Format(h_fin_turno, "yyyyMMddHHmmss") & "', 'YYYYMMDDHH24MISS')) "

        'mando señal automatica
        If gl_bl_bolsa_automatica = True Then

            strQuerys = strQuerys & "AND SAC = '" & gl_str_bolsa_automatica & "' "

        End If

        '    strQuerys = strQuerys & "AND (GEADBA.FIN_POSTE.DATE_FIN_POSTE >= TO_DATE('" & Format(dt_Fecha_Inicio, "yyyyMMddHHmmss") & "', 'YYYYMMDDHH24MISS')) AND " & _
        '"(GEADBA.FIN_POSTE.DATE_FIN_POSTE <= TO_DATE('" & Format(dt_Fecha_Fin, "yyyyMMddHHmmss") & "', 'YYYYMMDDHH24MISS')) "
        strQuerys = strQuerys & "AND (GEADBA.FIN_POSTE.ID_VOIE = '1' OR " &
     "GEADBA.FIN_POSTE.ID_VOIE = '2' OR " &
     "GEADBA.FIN_POSTE.ID_VOIE = '3' OR " &
     "GEADBA.FIN_POSTE.ID_VOIE = '4' OR " &
     "GEADBA.FIN_POSTE.ID_VOIE = 'X') " &
     "AND GEADBA.FIN_POSTE.SAC is not null " &
     "ORDER BY GEADBA.FIN_POSTE.ID_GARE, GEADBA.TYPE_VOIE.ID_VOIE, GEADBA.FIN_POSTE.VOIE, GEADBA.FIN_POSTE.DATE_FIN_POSTE, " &
     "GEADBA.FIN_POSTE.NUMERO_POSTE, GEADBA.FIN_POSTE.MATRICULE, Expr4"


        str_Plaza_Cobro = "1" & cmbPlazaCobro.Text
        id_plaza_cobro = cmbPlazaCobro.SelectedValue

        str_Cajero_Receptor = Trim(txtCajeroReceptor.Text)
        ' id_Cajero_Receptor = CDbl(txtCajeroReceptor.Text)

        'id_Turno = CDbl(cmbTurno.Text)
        str_Turno_block = Trim(cmbTurnoBlo.Text)


        dt_Fecha_Inicio = dtpFechaInicio.Value
        'dt_Fecha_Fin = dtpFechaFin.Value

        str_delegacion = cmbDelegacion.Text



        If objQuerys.QueryDataSetAutomatico(strQuerys, "automatico") = 1 Then

            For iPosicionFilaActualAutomatico = 0 To oDataSetAutomatico.Tables("automatico").Rows.Count - 1

                oDataRowAutomatico = oDataSetAutomatico.Tables("automatico").Rows(iPosicionFilaActualAutomatico)
                'btnGenerarReporte_Click("&Generar Reportes")
                txtCajeroReceptor.Text = oDataRowAutomatico("MATRICULE")
                generar_reporte()

            Next





        End If


    End Sub

    Private Sub GetObservations()

        Dim str As String = txtComentario.Text.PadRight(280)

        PrimeraLinea = (str).Substring(0, 80)
        SegundaLinea = (str).Substring(80, 100)
        TerceraLinea = (str).Substring(180, 100)

        If PrimeraLinea.Length = 0 Then
            PrimeraLinea = ""
        End If

        If SegundaLinea.Length = 0 Then
            SegundaLinea = ""
        End If

        If TerceraLinea.Length = 0 Then
            TerceraLinea = ""
        End If

        txtComentario.Text = ""

    End Sub

End Class