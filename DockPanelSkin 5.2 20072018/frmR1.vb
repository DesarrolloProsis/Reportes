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


        'encargado de turno RODRIGO'


        strConsulta = "SELECT NOM FROM TABLE_PERSONNEL WHERE MATRICULE LIKE '4%%%%%' ORDER BY NOM "
        glstrTabla = "TABLE_PERSONNEL"

        oDataAdapter = New OracleDataAdapter(strConsulta, oConexion)
        oDataAdapter.SelectCommand.CommandTimeout = 10000
        oDataAdapter.Fill(dtsPlasaCobro, glstrTabla)

        oDataAdapter = Nothing

        cmbEncargadoTurno.DataSource = dtsPlasaCobro.Tables("TABLE_PERSONNEL")
        cmbEncargadoTurno.DisplayMember = "TABLE_PERSONNEL"
        cmbEncargadoTurno.ValueMember = "NOM"
        cmbEncargadoTurno.SelectedValue = 1

        'se inician los combobox en un valor  RODRIGO'

        cmbDelegacion.SelectedIndex = 0
        cmbPlazaCobro.SelectedIndex = 0
        cmbTurnoBlo.SelectedIndex = 1

        'cmbTurno.DataSource = dtsPlasaCobro.Tables("FIN_POSTE")
        'cmbTurno.DisplayMember = "NUMERO_POSTE"
        'cmbTurno.ValueMember = "NUMERO_POSTE"
        'cmbTurno.SelectedValue = -1


        '''''carril (modifique codigo cambios rodrigo)



        'strConsulta = "Select ID_LANE FROM GPOS_EOJ GROUP BY ID_LANE ORDER BY ID_LANE"
        'glstrTabla = "ID_LANE"

        'oDataAdapter = New OracleDataAdapter(strConsulta, oConexion)

        'oDataAdapter.SelectCommand.CommandTimeout = 10000
        'oDataAdapter.Fill(dtsPlasaCobro, glstrTabla)

        'oDataAdapter = Nothing


        'cmbCarril.DataSource = dtsPlasaCobro.Tables("ID_LANE")
        'cmbCarril.DisplayMember = "ID_LANE"
        'cmbCarril.ValueMember = "ID_LANE"
        'cmbCarril.SelectedValue = "ID_LANE"



        'controles
        lblCajeroReceptor.Visible = False
        txtCajeroReceptor.Visible = False

        lblTurno.Visible = False
        'cmbTurno.Visible = False
        cmbTurnoBlo.Visible = False

        lblEncargadoTurno.Visible = False
        cmbEncargadoTurno.Visible = False

        lblDelegacion.Visible = False
        cmbDelegacion.Visible = False

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
        'txbCarril.Visible = False

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

                dtpFechaInicio.CustomFormat = "MM/dd/yyyy"


                lblTurno.Visible = True
                'cmbTurno.Visible = True
                cmbTurnoBlo.Visible = True

                lblDelegacion.Visible = True
                cmbDelegacion.Visible = True

            Case 6, 7, 12, 15
                str_delegacion = cmbDelegacion.Text

                'cmbDelegacion.SelectedItem = str_delegacion
                'cmbDelegacion.SelectedValue = str_delegacion
                'cmbDelegacion.SelectedItem = 1
                cmbPlazaCobro.SelectedValue = 1
                lblFecha1.Text = "Fecha"

                lblPlazaCobro.Visible = True
                cmbPlazaCobro.Visible = True

                'lblCajeroReceptor.Visible = True
                'txtCajeroReceptor.Visible = True

                lblFecha1.Visible = True
                dtpFechaInicio.Visible = True

                dtpFechaInicio.Format = DateTimePickerFormat.Custom

                dtpFechaInicio.CustomFormat = "MM/dd/yyyy"


                lblTurno.Visible = True
                'cmbTurno.Visible = True
                cmbTurnoBlo.Visible = True

                lblDelegacion.Visible = True
                cmbDelegacion.Visible = True

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

            Case 8, 10, 13, 16, 1001
                lblFecha1.Text = "Fecha"


                lblPlazaCobro.Visible = True
                cmbPlazaCobro.Visible = True

                'lblCajeroReceptor.Visible = True
                'txtCajeroReceptor.Visible = True

                lblFecha1.Visible = True
                dtpFechaInicio.Visible = True

                dtpFechaInicio.Format = DateTimePickerFormat.Custom

                dtpFechaInicio.CustomFormat = "MM/dd/yyyy"


                'lblTurno.Visible = True
                'cmbTurno.Visible = True
                'cmbTurnoBlo.Visible = True

                lblDelegacion.Visible = True
                cmbDelegacion.Visible = True


            Case 9

                lblFecha1.Text = "Fecha"

                lblPlazaCobro.Visible = True
                cmbPlazaCobro.Visible = True

                lblCajeroReceptor.Visible = True
                txtCajeroReceptor.Visible = True

                lblFecha1.Visible = True
                dtpFechaInicio.Visible = True

                dtpFechaInicio.Format = DateTimePickerFormat.Custom
                dtpFechaInicio.CustomFormat = "MM/dd/yyyy"


                lblTurno.Visible = True
                'cmbTurno.Visible = True

                lblDelegacion.Visible = True
                cmbDelegacion.Visible = True
                cmbDelegacion.SelectedItem = 1
                cmbPlazaCobro.SelectedValue = 1

            Case 17


                lblFecha1.Text = "Fecha"

                lblPlazaCobro.Visible = True
                cmbPlazaCobro.Visible = True

                lblCajeroReceptor.Visible = True
                txtCajeroReceptor.Visible = True

                lblFecha1.Visible = True
                dtpFechaInicio.Visible = True

                dtpFechaInicio.Format = DateTimePickerFormat.Custom

                dtpFechaInicio.CustomFormat = "MM/dd/yyyy"
                lblCarril.Visible = True
                cmbCarril.Visible = True
                ' TextBox1.Visible = false
                lblEncargadoTurno.Visible = True
                cmbEncargadoTurno.Visible = True

                lblTurno.Visible = True
                'cmbTurno.Visible = True
                cmbTurnoBlo.Visible = True

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
                'Mexico acapulco
                'str_Plaza_Cobro = "1" & cmbPlazaCobro.Text
                str_Plaza_Cobro = "0" & cmbPlazaCobro.Text
                id_plaza_cobro = cmbPlazaCobro.SelectedValue

                str_Cajero_Receptor = Trim(txtCajeroReceptor.Text)
                id_Cajero_Receptor = CDbl(txtCajeroReceptor.Text)

                'id_Turno = CDbl(cmbTurno.Text)
                str_Turno_block = Trim(cmbTurnoBlo.Text)


                dt_Fecha_Inicio = dtpFechaInicio.Value
                'dt_Fecha_Fin = dtpFechaFin.Value



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
                'Mexico acapulco
                'str_Plaza_Cobro = "1" & cmbPlazaCobro.Text
                str_Plaza_Cobro = "0" & cmbPlazaCobro.Text
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
                'Mexico acapulco
                'str_Plaza_Cobro = "1" & cmbPlazaCobro.Text
                str_Plaza_Cobro = "0" & cmbPlazaCobro.Text
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
                'Mexico acapulco
                'str_Plaza_Cobro = "1" & cmbPlazaCobro.Text
                str_Plaza_Cobro = "0" & cmbPlazaCobro.Text
                id_plaza_cobro = cmbPlazaCobro.SelectedValue

                dt_Fecha_Inicio = dtpFechaInicio.Value
                dt_Fecha_Fin = dtpFechaFin.Value

                str_delegacion = cmbDelegacion.Text

            Case 5, 9, 11, 14, 1411
                'Preliquidación de Cajero-Receptor para Tránsito Vehicular
                insert = "C"
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
                'Mexico acapulco
                'str_Plaza_Cobro = "1" & cmbPlazaCobro.Text
                str_Plaza_Cobro = "0" & cmbPlazaCobro.Text
                id_plaza_cobro = cmbPlazaCobro.SelectedValue

                str_Cajero_Receptor = Trim(txtCajeroReceptor.Text)
                id_Cajero_Receptor = CDbl(txtCajeroReceptor.Text)

                'id_Turno = CDbl(cmbTurno.Text)
                str_Turno_block = Trim(cmbTurnoBlo.Text)

                dt_Fecha_Inicio = dtpFechaInicio.Value
                dt_Fecha_Fin = dtpFechaFin.Value

                str_delegacion = cmbDelegacion.Text

                '''''''''''''''''''''''''''Fin''''''''''''''''''''''''''''''''''''<

            Case 6, 7, 12, 15
                insert = "T"
                str_delegacion = cmbDelegacion.Text

                cmbDelegacion.SelectedValue = str_delegacion

                dt_Fecha_Inicio = dtpFechaInicio.Value
                dt_Fecha_Fin = dtpFechaFin.Value

                str_delegacion = cmbDelegacion.Text

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


                'Mexico acapulco
                'str_Plaza_Cobro = "1" & cmbPlazaCobro.Text
                str_Plaza_Cobro = "0" & cmbPlazaCobro.Text

                id_plaza_cobro = cmbPlazaCobro.SelectedValue

                'str_Cajero_Receptor = Trim(txtCajeroReceptor.Text)
                'id_Cajero_Receptor = CDbl(txtCajeroReceptor.Text)

                'id_Turno = CDbl(cmbTurno.Text)
                str_Turno_block = Trim(cmbTurnoBlo.Text)

                dt_Fecha_Inicio = dtpFechaInicio.Value
                dt_Fecha_Fin = dtpFechaFin.Value

                str_delegacion = cmbDelegacion.Text

                If banValidaciones Then
                    ValidaCarrilesCerrados()
                End If
                If banValidaciones Then
                    ValidaBolsas()
                End If
                If banValidaciones Then
                    ValidaComentarios()
                End If




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

            Case 8, 10, 13, 16, 1001
                insert = "D"
                If cmbDelegacion.Text = "" Then
                    MsgBox("Favor de seleccionar la delegación", MsgBoxStyle.Information, "Verificar")
                    Exit Sub
                End If

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''Inicio
                If cmbPlazaCobro.SelectedValue = Nothing Then
                    MsgBox("Favor de seleccionar la plaza de cobro", MsgBoxStyle.Information, "Verificar")
                    Exit Sub
                End If

                'Mexico acapulco
                'str_Plaza_Cobro = "1" & cmbPlazaCobro.Text
                str_Plaza_Cobro = "0" & cmbPlazaCobro.Text
                id_plaza_cobro = cmbPlazaCobro.SelectedValue
                str_delegacion = cmbDelegacion.Text

                'str_Cajero_Receptor = Trim(txtCajeroReceptor.Text)
                'id_Cajero_Receptor = CDbl(txtCajeroReceptor.Text)

                'id_Turno = CDbl(cmbTurno.Text)
                'str_Turno_block = Trim(cmbTurnoBlo.Text)


           'modifique codigo rodrigo
            Case 17
                str_delegacion = cmbDelegacion.Text
                str_encargado_turno = cmbEncargadoTurno.Text
                cmbDelegacion.SelectedValue = str_delegacion
                dt_carril = cmbCarril.Text
                dt_Fecha_Inicio = dtpFechaInicio.Value
                dt_Fecha_Fin = dtpFechaFin.Value
                str_Cajero_Receptor = txtCajeroReceptor.Text
                str_delegacion = cmbDelegacion.Text

                If cmbDelegacion.Text = "" Then
                    MsgBox("Favor de seleccionar la delegación", MsgBoxStyle.Information, "Verificar")
                    Exit Sub
                End If
                If cmbEncargadoTurno.Text = "" Then
                    MsgBox("Favor de poner el encargado de turno", MsgBoxStyle.Information, "Verificar")
                    Exit Sub
                End If

                If cmbPlazaCobro.SelectedValue = Nothing Then
                    MsgBox("Favor de seleccionar la plaza de cobro", MsgBoxStyle.Information, "Verificar")
                    Exit Sub
                End If

                If txtCajeroReceptor.Text = "" Then
                    MsgBox("Favor de seleccionar cajero-receptor", MsgBoxStyle.Information, "Verificar")
                    Exit Sub
                End If

                'If cmbCarril.SelectedValue = Nothing Then
                '    MsgBox("Favor de seleccionar el carril", MsgBoxStyle.Information, "Verificar")
                '    Exit Sub
                'End If
                'If txbCarril.Text = "" Then
                '    MsgBox("Favor de seleccionar el carril", MsgBoxStyle.Information, "Verificar")
                '    Exit Sub
                'End If
                If cmbTurnoBlo.Text = "" Then
                    MsgBox("Favor de seleccionar el turno", MsgBoxStyle.Information, "Verificar")
                    Exit Sub
                End If


                'Mexico acapulco
                'str_Plaza_Cobro = "1" & cmbPlazaCobro.Text
                str_Plaza_Cobro = "0" & cmbPlazaCobro.Text
                id_plaza_cobro = cmbPlazaCobro.SelectedValue

                str_Turno_block = Trim(cmbTurnoBlo.Text)
                dt_Fecha_Inicio = dtpFechaInicio.Value
                dt_Fecha_Fin = dtpFechaFin.Value

                str_delegacion = cmbDelegacion.Text

                If banValidaciones Then
                    ValidaCarrilesCerrados()
                End If
                If banValidaciones Then
                    ValidaBolsas()
                End If
                If banValidaciones Then
                    ValidaComentarios()
                End If

        End Select

        'frmReporte.ShowDialog()

        If banValidaciones = True Then
            frmReporte.Show()
        Else
            banValidaciones = True
        End If


    End Sub

    Private Sub btnGenerarReporte_Click(sender As Object, e As EventArgs) Handles btnGenerarReporte.Click

        generar_reporte()

    End Sub

    Private Sub ValidaCarrilesCerrados()

        Dim consulta As String
        Dim consulta2 As String
        Dim cmd As OracleCommand = New OracleCommand()
        Dim conexion As OracleConnection = New OracleConnection()

        conexion.ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.3.29.221)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=GEAPROD)));User Id=GEADBA;Password=FGEUORJVNE;"

        Dim fecInicioD As String = CDate(Format(DateAdd(DateInterval.Day, -1, dt_Fecha_Inicio), "MM/dd/yyyy"))
        Dim fechaSelect As String = dtpFechaInicio.Value.ToString("MM/dd/yyyy")
        Dim TempTurno As String = cmbTurnoBlo.SelectedItem
        Dim turnoP As String = ""
        Dim FechaInicio As String = ""
        Dim FechaFinal As String = ""

        Dim mensaje As String = "Los Carriles "

        Dim carriles As List(Of Carril) = New List(Of Carril)
        Dim carriles_cerrados As List(Of Carril) = New List(Of Carril)

        'Se seleciona el turno
        Select Case TempTurno
            Case "22:00 - 06:00"
                turnoP = "1"
                FechaInicio = fecInicioD + " 22:00:00"
                FechaFinal = fechaSelect + " 23:59:59"
            Case "06:00 - 14:00"
                turnoP = "2"
                FechaInicio = fechaSelect + " 06:00:00"
                FechaFinal = fechaSelect + " 23:59:59"
            Case "14:00 - 22:00"
                turnoP = "3"
                FechaInicio = fechaSelect + " 14:00:00"
                FechaFinal = fechaSelect + " 23:59:59"
        End Select

        consulta = "SELECT	LANE_ASSIGN.Id_plaza,
 		            LANE_ASSIGN.Id_lane,
		            TO_CHAR(LANE_ASSIGN.MSG_DHM,'MM/DD/YY HH24:MI:SS') AS FECHA_INICIO,
 		            LANE_ASSIGN.SHIFT_NUMBER,
 		            LANE_ASSIGN.OPERATION_ID,
		            TO_CHAR(LANE_ASSIGN.ASSIGN_DHM,'MM/DD/YY') AS FECHA,
		            LTRIM(TO_CHAR(LANE_ASSIGN.JOB_NUMBER,'09')) AS EMPLEADO,
		            LANE_ASSIGN.STAFF_NUMBER,
		            LANE_ASSIGN.IN_CHARGE_SHIFT_NUMBER
                     FROM 	LANE_ASSIGN
                     WHERE	 SHIFT_NUMBER = " & turnoP & "
                      AND LANE_ASSIGN.OPERATION_ID ='NA'
                     AND ((MSG_DHM >= TO_DATE('" & FechaInicio & "','MM-DD-YYYY HH24:MI:SS')) AND (MSG_DHM <= TO_DATE('" & FechaFinal & "','MM-DD-YYYY HH24:MI:SS')))
	                    ORDER BY LANE_ASSIGN.Id_PLAZA,
 			                     LANE_ASSIGN.Id_LANE,
 			                     LANE_ASSIGN.MSG_DHM "

        'Se llaman a todos los carriles con NA
        conexion.Open()
        cmd.CommandText = consulta
        cmd.Connection = conexion
        Dim dataReader As OracleDataReader = cmd.ExecuteReader()
        Dim carril As Carril
        While dataReader.Read
            carril = New Carril()
            carril.LANE = dataReader.Item("ID_LANE")
            carril.FECHA = dataReader.Item("FECHA_INICIO")
            carril.MATRICULE = dataReader.Item("STAFF_NUMBER")
            carriles.Add(carril)

        End While
        conexion.Close()

        'Se verifican que los carriles se encuentren cerrados en la tabla FIN_POSTE
        For Each tp As Carril In carriles
            consulta2 = "SELECT COUNT(*) FROM FIN_POSTE WHERE 
                    DATE_DEBUT_POSTE = TO_DATE('" & tp.FECHA & "','MM/DD/YY HH24:MI:SS')
                    AND VOIE = '" & tp.LANE & "' AND MATRICULE='" & tp.MATRICULE & "'"

            conexion.Open()
            cmd.CommandText = consulta2
            cmd.Connection = conexion

            If cmd.ExecuteScalar < 1 Then
                carril = New Carril()
                carril.LANE = tp.LANE
                carril.FECHA = tp.FECHA
                carril.MATRICULE = tp.MATRICULE
                carriles_cerrados.Add(carril)
                banValidaciones = False
            End If
            conexion.Close()
        Next


        For Each tp2 As Carril In carriles_cerrados
            mensaje = mensaje + tp2.LANE + ","
        Next

        If banValidaciones = False Then
            MsgBox(mensaje + " aun no estan Cerrados ", vbCritical, "¡¡¡¡Advertencia!!!!")
        End If

    End Sub

    Private Sub ValidaBolsas()
        Dim TempTurno As String = cmbTurnoBlo.SelectedItem
        Dim fechaSelect As String = dtpFechaInicio.Value.ToString("MM/dd/yyyy")
        'Dim fecInicioD As String = dtpFechaInicio.Value.Year.ToString() + "/" + dtpFechaInicio.Value.Month.ToString() + "/" + dtpFechaInicio.Value.AddDays(-1).ToString("dd")
        Dim fecInicioD As String = CDate(Format(DateAdd(DateInterval.Day, -1, dt_Fecha_Inicio), "MM/dd/yyyy"))

        Dim turnoP As String = ""
        Dim FechaInicio As String = ""
        Dim FechaFinal As String = ""
        'Valida  el  turno selecionado
        Select Case TempTurno
            Case "22:00 - 06:00"
                turnoP = "1"
                FechaInicio = fecInicioD + " 22:00:00"
                FechaFinal = fechaSelect + " 23:59:59"
            Case "06:00 - 14:00"
                turnoP = "2"
                FechaInicio = fechaSelect + " 06:00:00"
                FechaFinal = fechaSelect + " 23:59:59"
            Case "14:00 - 22:00"
                turnoP = "3"
                FechaInicio = fechaSelect + " 14:00:00"
                FechaFinal = fechaSelect + " 23:59:59"
        End Select

        'Verifica que todos los carriles cerrados tengan bolsa
        Dim consulta As String = "SELECT TO_CHAR( C.DATE_FIN_POSTE,'yyyy-mm-dd') AS FECHA, " +
                                  "C.MATRICULE AS cajero, " +
                                  "C.VOIE AS Carril, " +
                                  "C.NUMERO_POSTE AS Corte, " +
                                  "TO_CHAR(C.DATE_DEBUT_POSTE,'HH24:mi:SS') AS Inicio_Turno, " +
                                  "TO_CHAR(C.DATE_FIN_POSTE,'HH24:mi:SS') AS Fin_Turno, " +
                                "'Entrega no realizada de bolsa '||C.VOIE||' Inicio '||TO_CHAR(C.DATE_DEBUT_POSTE,'HH24:mi:SS')||',Fin '||TO_CHAR(C.DATE_FIN_POSTE,'HH24:mi:SS')||' '||A.MATRICULE||'/'|| A.NOM AS Aviso " +
                            "FROM FIN_POSTE C " +
                            "LEFT JOIN TABLE_PERSONNEL  A ON C.Matricule = A.Matricule " +
                            "WHERE C.DATE_DEBUT_POSTE " +
                            "BETWEEN to_date('" + FechaInicio + "' ,'mm-dd-yyyy HH24:mi:SS') " +
                            "AND to_date('" + FechaFinal + "' ,'mm-dd-yyyy HH24:mi:SS') " +
                            "AND SAC IS NULL AND FIN_POSTE_CPT22 = " + turnoP + "AND C.ID_MODE_VOIE in (1,7)"

        Dim cmd As OracleCommand = New OracleCommand()
        Dim conexion As OracleConnection = New OracleConnection
        conexion.ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.3.29.221)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=GEAPROD)));User Id=GEADBA;Password=FGEUORJVNE;"
        conexion.Open()
        cmd.CommandText = consulta
        cmd.Connection = conexion
        Dim dataReader As OracleDataReader = cmd.ExecuteReader()
        While dataReader.Read
            banValidaciones = False
            MessageBox.Show(dataReader.Item("Aviso").ToString(), ErrorToString, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End While
        conexion.Close()
    End Sub

    Private Sub ValidaComentarios()
        Dim TempTurno As String = cmbTurnoBlo.SelectedItem
        Dim fechaSelect As String = dtpFechaInicio.Value.ToString("MM/dd/yyyy")
        'Dim fecInicioD As String = dtpFechaInicio.Value.Year.ToString() + "/" + dtpFechaInicio.Value.Month.ToString() + "/" + dtpFechaInicio.Value.AddDays(-1).ToString("dd")
        Dim fecInicioD As String = CDate(Format(DateAdd(DateInterval.Day, -1, dt_Fecha_Inicio), "MM/dd/yyyy"))

        Dim turnoP As String = ""
        Dim FechaInicio As String = ""
        Dim FechaFinal As String = ""
        'Valida  el  turno selecionado
        Select Case TempTurno
            Case "22:00 - 06:00"
                turnoP = "1"
                FechaInicio = fecInicioD + " 22:00:00"
                FechaFinal = fechaSelect + " 23:59:59"
            Case "06:00 - 14:00"
                turnoP = "2"
                FechaInicio = fechaSelect + " 06:00:00"
                FechaFinal = fechaSelect + " 23:59:59"
            Case "14:00 - 22:00"
                turnoP = "3"
                FechaInicio = fechaSelect + " 14:00:00"
                FechaFinal = fechaSelect + " 23:59:59"
        End Select
        'Valida que se  hayan capturado los  comentarios  en la  entrega de  Bolsa
        ' SE MODIFICIO DATE_FIN_POSTE POR C.DATE_DEBUT_POSTE [RODRIGO]
        Dim consulta As String = "SELECT " +
                                    "C.COMMENTAIRE AS COMENTARIOS, " +
                                    "C.SAC AS BOLSA, " +
                                    "C.OPERATING_SHIFT AS TURNO, " +
                                    "C.DATE_REDDITION AS FECHA, " +
                                    "C.RED_TXT1, " +
                                    "'Declaracion sin comentarios  carril '||C.RED_TXT1||' bolsa '||TO_CHAR(C.SAC)||' '||A.MATRICULE||'/'|| A.NOM AS Aviso " +
                                "FROM REDDITION  C " +
                                "LEFT JOIN TABLE_PERSONNEL  A ON C.Matricule = A.Matricule " +
                                "WHERE DATE_REDDITION " +
                                "BETWEEN to_date('" + FechaInicio + "' ,'mm-dd-yyyy HH24:mi:SS') " +
                                    "AND to_date('" + FechaFinal + "' ,'mm-dd-yyyy HH24:mi:SS') " +
                                 " AND COMMENTAIRE IS NULL AND C.OPERATING_SHIFT  = " + turnoP
        Dim cmd As OracleCommand = New OracleCommand()
        Dim conexion As OracleConnection = New OracleConnection
        conexion.ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.3.29.221)(PORT = 1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=GEAPROD)));User Id=GEADBA;Password=FGEUORJVNE;"
        conexion.Open()
        cmd.CommandText = consulta
        cmd.Connection = conexion
        Dim dataReader As OracleDataReader = cmd.ExecuteReader()
        While dataReader.Read
            banValidaciones = False
            MessageBox.Show(dataReader.Item("Aviso").ToString(), ErrorToString, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End While
        conexion.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub btnAutomatico_Click(sender As Object, e As EventArgs) Handles btnAutomatico.Click

        Dim strQuerys As String
        Dim h_inicio_turno As Date
        Dim h_fin_turno As Date
        Dim No_Turno As String

        strQuerys = "Select GEADBA.FIN_POSTE.ID_RESEAU, GEADBA.FIN_POSTE.ID_GARE, GEADBA.TYPE_VOIE.LIBELLE_COURT_VOIE_L2, GEADBA.FIN_POSTE.VOIE, TO_CHAR(GEADBA.FIN_POSTE.NUMERO_POSTE, 'FM09') AS Expr1, " & _
"TO_CHAR(GEADBA.FIN_POSTE.DATE_FIN_POSTE, 'MM/DD/YY') AS Expr2, TO_CHAR(GEADBA.FIN_POSTE.DATE_FIN_POSTE, 'HH24:MI') AS Expr3, " & _
"GEADBA.FIN_POSTE.MATRICULE, GEADBA.FIN_POSTE.SAC AS Expr4, GEADBA.FIN_POSTE.ID_VOIE, " & _
"TO_CHAR(GEADBA.FIN_POSTE.DATE_DEBUT_POSTE, 'YYYYMMDDHH24MISS') AS Expr5, TO_CHAR(GEADBA.FIN_POSTE.DATE_FIN_POSTE, 'YYYYMMDDHH24MISS') AS Expr6, GEADBA.TYPE_VOIE.LIBELLE_COURT_VOIE, 0 AS Expr7, " & _
"FOLIO_NUMBER_CLOSE, INITIAL_EVENT_NUMBER, FINAL_EVENT_NUMBER " & _
"FROM GEADBA.TYPE_VOIE, GEADBA.FIN_POSTE, GEADBA.SITE_GARE " & _
"WHERE GEADBA.TYPE_VOIE.ID_VOIE = GEADBA.FIN_POSTE.ID_VOIE AND GEADBA.FIN_POSTE.ID_RESEAU = GEADBA.SITE_GARE.ID_RESEAU AND " & _
"GEADBA.FIN_POSTE.ID_GARE = GEADBA.SITE_GARE.ID_GARE AND (GEADBA.SITE_GARE.ID_RESEAU = '01') AND " & _
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

        strQuerys = strQuerys & "AND (GEADBA.FIN_POSTE.DATE_DEBUT_POSTE >= TO_DATE('" & Format(h_inicio_turno, "yyyyMMddHHmmss") & "', 'YYYYMMDDHH24MISS')) AND " & _
   "(GEADBA.FIN_POSTE.DATE_DEBUT_POSTE <= TO_DATE('" & Format(h_fin_turno, "yyyyMMddHHmmss") & "', 'YYYYMMDDHH24MISS')) "

        'mando señal automatica
        If gl_bl_bolsa_automatica = True Then

            strQuerys = strQuerys & "AND SAC = '" & gl_str_bolsa_automatica & "' "

        End If

        '    strQuerys = strQuerys & "AND (GEADBA.FIN_POSTE.DATE_FIN_POSTE >= TO_DATE('" & Format(dt_Fecha_Inicio, "yyyyMMddHHmmss") & "', 'YYYYMMDDHH24MISS')) AND " & _
        '"(GEADBA.FIN_POSTE.DATE_FIN_POSTE <= TO_DATE('" & Format(dt_Fecha_Fin, "yyyyMMddHHmmss") & "', 'YYYYMMDDHH24MISS')) "
        strQuerys = strQuerys & "AND (GEADBA.FIN_POSTE.ID_VOIE = '1' OR " & _
     "GEADBA.FIN_POSTE.ID_VOIE = '2' OR " & _
     "GEADBA.FIN_POSTE.ID_VOIE = '3' OR " & _
     "GEADBA.FIN_POSTE.ID_VOIE = '4' OR " & _
     "GEADBA.FIN_POSTE.ID_VOIE = 'X') " & _
     "AND GEADBA.FIN_POSTE.SAC is not null " & _
     "ORDER BY GEADBA.FIN_POSTE.ID_GARE, GEADBA.TYPE_VOIE.ID_VOIE, GEADBA.FIN_POSTE.VOIE, GEADBA.FIN_POSTE.DATE_FIN_POSTE, " & _
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

    Private Sub cmbTurnoBlo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTurnoBlo.SelectedIndexChanged
        Carriles()
    End Sub

    Private Sub dtpFechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaInicio.ValueChanged
        Carriles()
    End Sub

    Private Sub Carriles()

        Try
            Dim h_inicio_turno As Date
            Dim h_fin_turno As Date
            Dim No_Turno As String
            Dim strConsulta As String

            dt_carril = cmbCarril.Text
            str_Turno_block = Trim(cmbTurnoBlo.Text)
            dt_Fecha_Inicio = dtpFechaInicio.Value

            'Ya selecciono turno"
            If dt_Fecha_Inicio = #1/1/0001 12:00:00 AM# Then
                dt_Fecha_Inicio = Now
            End If

            str_Turno_block = Trim(cmbTurnoBlo.Text)

            If Mid(Trim(str_Turno_block), 1, 2) = "06" Then
                h_inicio_turno = CDate(Format(dt_Fecha_Inicio, "MM/dd/yyyy") & " 06:00:00")
                h_fin_turno = CDate(Format(dt_Fecha_Inicio, "MM/dd/yyyy") & " 13:59:59")
                No_Turno = "MATUTINO"
                id_Turno = 2
            ElseIf Mid(Trim(str_Turno_block), 1, 2) = "14" Then
                h_inicio_turno = CDate(Format(dt_Fecha_Inicio, "MM/dd/yyyy") & " 14:00:00")
                h_fin_turno = CDate(Format(dt_Fecha_Inicio, "MM/dd/yyyy") & " 21:59:59")
                No_Turno = "VESPERTINO"
                id_Turno = 3
            ElseIf Mid(Trim(str_Turno_block), 1, 2) = "22" Then
                h_inicio_turno = CDate(Format(DateAdd(DateInterval.Day, -1, dt_Fecha_Inicio), "MM/dd/yyyy") & " 22:00:00")
                h_fin_turno = CDate(Format(dt_Fecha_Inicio, "MM/dd/yyyy") & " 05:59:59")
                No_Turno = "NOCTURNO"
                id_Turno = 1
            End If

            strConsulta = "select DISTINCT VOIE from fin_poste where Date_fin_poste >= TO_DATE('" & Format(h_inicio_turno, "yyyyMMddHHmmss") & "','YYYYMMDDHH24MISS')
        AND Date_fin_poste <= TO_DATE('" & Format(h_fin_turno, "yyyyMMddHHmmss") & "','YYYYMMDDHH24MISS') ORDER BY VOIE"

            Dim oDataAdapter = New OracleDataAdapter(strConsulta, oConexion)

            Dim ds As New DataSet("FIN_POSTE")

            Dim Datable As New DataTable
            ''Dim Datable As DataTable = new datatable("RELLENO") 
            'Dim columna As DataColumn = Datable.Columns.Add(
            '"%%", Type.GetType("System.Int32"))
            'workCol.AllowDBNull = False
            'workCol.Unique = True
            'Datable.Columns.Add("%%", Type.GetType("System.String"))
            'Datable.Columns.Add("A%", Type.GetType("System.String"))
            'Datable.Columns.Add("B%", Type.GetType("System.string"))
            'MODIFICAR AQUI


            oDataAdapter.fill(Datable)
            cmbCarril.DataSource = Datable
            cmbCarril.DisplayMember = "VOIE"
            cmbCarril.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

End Class