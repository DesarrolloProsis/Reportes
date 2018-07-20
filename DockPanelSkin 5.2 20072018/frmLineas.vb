Public Class frmLineas

    Private Sub frmListas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        listas()

        'Public gl_hieght_int As Integer
        'Public gl_width_int As Integer
        'Public gl_bl_camibo_tamaño As Boolean

        If gl_bl_camibo_tamaño = True Then
            Me.Height = gl_hieght_int
            Me.Width = gl_width_int
        End If
        gl_bl_camibo_tamaño = False

    End Sub

    Sub listas()

        Dim strConsulta As String
        Dim cont As Integer
        'Dim contColores As Integer
        'Dim oDataRowListas() As DataRow

        Select Case Me.Tag


            Case 1 'Plaza de Cobro
                Me.Text = "Plaza de Cobro"

                strConsulta = "SELECT ID_SITE, NOM_SITE, NOM_SITE_L2 " & _
                "FROM TYPE_SITE " & _
                "ORDER BY NOM_SITE"

                glstrTabla = "TYPE_SITE"

                ltvListas.Columns.Clear()
                ltvListas.Items.Clear()
                ltvListas.LabelEdit = False

                If objQuerys.QueryDataSet(strConsulta, glstrTabla) = 1 Then

                    For cont = 1 To 2
                        ltvListas.Columns.Add(New ColumnHeader)
                    Next

                    ltvListas.Columns(0).Text = "No."
                    ltvListas.Columns(0).Width = 80

                    ltvListas.Columns(1).Text = "Plaza de Cobro"
                    ltvListas.Columns(1).Width = 300

                    For modGlobal.iPosicionFilaActual = 0 To oDataSet.Tables(glstrTabla).Rows.Count - 1

                        oDataRow = oDataSet.Tables(glstrTabla).Rows(iPosicionFilaActual)

                        With ltvListas.Items.Add(oDataRow("ID_SITE"))

                            .SubItems.Add(oDataRow("NOM_SITE"))
                            .tag = oDataRow("ID_SITE")

                        End With

                    Next

                    lblContador.Text = oDataSet.Tables(glstrTabla).Rows.Count & "  registros."
                Else
                    MessageBox.Show("No exiten datos,verificar", "Catalogos", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Me.Close()
                End If

            Case 2 'Cajero-Receptor

                Me.Text = "Cajero-Receptor"

                strConsulta = "SELECT MATRICULE, NOM, PRENOM, SITE_AUTORISES " & _
                                "FROM TABLE_PERSONNEL "

                If IsNumeric(strLinea) Then
                    strConsulta = strConsulta & "WHERE SITE_AUTORISES LIKE '%" & strLinea & "%' "
                End If

                If IsNumeric(strLinea1) Then
                    strConsulta = strConsulta & "and MATRICULE LIKE '%" & strLinea1 & "%' "
                End If

                If Trim(strLinea2) <> "" Then
                    strConsulta = strConsulta & "and (NOM LIKE '%" & strLinea2 & "%' or PRENOM LIKE '%" & strLinea2 & "%') "
                End If

                strConsulta = strConsulta & "ORDER BY NOM, PRENOM"

                glstrTabla = "TABLE_PERSONNEL"

                ltvListas.Columns.Clear()
                ltvListas.Items.Clear()
                ltvListas.LabelEdit = False

                If objQuerys.QueryDataSet(strConsulta, glstrTabla) = 1 Then

                    For cont = 1 To 2
                        ltvListas.Columns.Add(New ColumnHeader)
                    Next

                    ltvListas.Columns(0).Text = "Matricula"
                    ltvListas.Columns(0).Width = 90

                    ltvListas.Columns(1).Text = "Nombre"
                    ltvListas.Columns(1).Width = 300

                    'ltvListas.Columns(1).Text = "Plazas Autorizadas"
                    'ltvListas.Columns(1).Width = 300


                    For modGlobal.iPosicionFilaActual = 0 To oDataSet.Tables(glstrTabla).Rows.Count - 1

                        oDataRow = oDataSet.Tables(glstrTabla).Rows(iPosicionFilaActual)

                        With ltvListas.Items.Add(oDataRow("MATRICULE"))

                            .SubItems.Add(Trim(oDataRow("NOM")) & " " & Trim(oDataRow("PRENOM")))
                            .tag = oDataRow("MATRICULE")

                        End With

                    Next

                    lblContador.Text = oDataSet.Tables(glstrTabla).Rows.Count & "  registros."
                Else
                    MessageBox.Show("No exiten datos,verificar", "Catalogos", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Me.Close()
                End If


            Case 3 'Encargado de turno

                Me.Text = "Cajero-Receptor"

                strConsulta = "SELECT MATRICULE, NOM, PRENOM, SITE_AUTORISES " & _
                                "FROM TABLE_PERSONNEL "

                'queda mendiente el campo de plaza autoirzada (00 en base de datos)
                'If IsNumeric(strLinea) Then
                '    strConsulta = strConsulta & "WHERE SITE_AUTORISES LIKE '%" & strLinea & "%' "
                'End If

                strConsulta = strConsulta & "WHERE MATRICULE LIKE '4%' "

                If IsNumeric(strLinea1) Then
                    strConsulta = strConsulta & "and MATRICULE LIKE '%" & strLinea1 & "%' "
                End If

                If Trim(strLinea2) <> "" Then
                    strConsulta = strConsulta & "and (NOM LIKE '%" & strLinea2 & "%' or PRENOM LIKE '%" & strLinea2 & "%') "
                End If

                strConsulta = strConsulta & "ORDER BY NOM, PRENOM"

                glstrTabla = "TABLE_PERSONNEL"

                ltvListas.Columns.Clear()
                ltvListas.Items.Clear()
                ltvListas.LabelEdit = False

                If objQuerys.QueryDataSet(strConsulta, glstrTabla) = 1 Then

                    For cont = 1 To 2
                        ltvListas.Columns.Add(New ColumnHeader)
                    Next

                    ltvListas.Columns(0).Text = "Matricula"
                    ltvListas.Columns(0).Width = 90

                    ltvListas.Columns(1).Text = "Nombre"
                    ltvListas.Columns(1).Width = 300

                    'ltvListas.Columns(1).Text = "Plazas Autorizadas"
                    'ltvListas.Columns(1).Width = 300


                    For modGlobal.iPosicionFilaActual = 0 To oDataSet.Tables(glstrTabla).Rows.Count - 1

                        oDataRow = oDataSet.Tables(glstrTabla).Rows(iPosicionFilaActual)

                        With ltvListas.Items.Add(oDataRow("MATRICULE"))

                            .SubItems.Add(Trim(oDataRow("NOM")) & " " & Trim(oDataRow("PRENOM")))
                            .tag = oDataRow("MATRICULE")

                        End With

                    Next

                    lblContador.Text = oDataSet.Tables(glstrTabla).Rows.Count & "  registros."
                Else
                    MessageBox.Show("No exiten datos,verificar", "Catalogos", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Me.Close()
                End If
                '''''''''''''
            Case 4 'vARIOS TURNOS

                Me.Text = "Turnos"



                glstrTabla = "TABLE"

                ltvListas.Columns.Clear()
                ltvListas.Items.Clear()
                ltvListas.LabelEdit = False

                If objQuerys.QueryDataSet(strLinea, glstrTabla) = 1 Then

                    For cont = 1 To 4
                        ltvListas.Columns.Add(New ColumnHeader)
                    Next

                    ltvListas.Columns(0).Text = "Inicio"
                    ltvListas.Columns(0).Width = 130

                    ltvListas.Columns(1).Text = "Fin"
                    ltvListas.Columns(1).Width = 130

                    ltvListas.Columns(2).Text = "Carril"
                    ltvListas.Columns(2).Width = 80

                    ltvListas.Columns(3).Text = "Bolsa"
                    ltvListas.Columns(3).Width = 80



                    For modGlobal.iPosicionFilaActual = 0 To oDataSet.Tables(glstrTabla).Rows.Count - 1

                        oDataRow = oDataSet.Tables(glstrTabla).Rows(iPosicionFilaActual)

                        With ltvListas.Items.Add(Format(objControl.fecha(oDataRow("Expr5")), "MM/dd/yyyy HH:mm:ss"))

                            .SubItems.Add(Format(objControl.fecha(oDataRow("Expr6")), "MM/dd/yyyy HH:mm:ss"))
                            .SubItems.Add(oDataRow("VOIE"))
                            .SubItems.Add(oDataRow("Expr4"))

                        End With

                    Next

                    lblContador.Text = oDataSet.Tables(glstrTabla).Rows.Count & "  registros."
                Else
                    MessageBox.Show("No exiten datos,verificar", "Catalogos", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Me.Close()
                End If

            Case 5 'vARIOS cerrados

                Me.Text = "Carriles Cerrados"



                glstrTabla = "TABLE"

                ltvListas.Columns.Clear()
                ltvListas.Items.Clear()
                ltvListas.LabelEdit = False



                If objQuerys.QueryDataSet(strLinea, glstrTabla) = 1 Then

                    For cont = 1 To 3
                        ltvListas.Columns.Add(New ColumnHeader)
                    Next

                    'strQuerys = "SELECT ID_NETWORK, ID_PLAZA,ID_LANE, LANE, BEGIN_DHM, END_DHM, BAG_NUMBER, REPORT_FLAG, GENERATION_DHM " & _
                    ltvListas.Columns(0).Text = "Inicio"
                    ltvListas.Columns(0).Width = 130

                    ltvListas.Columns(1).Text = "Fin"
                    ltvListas.Columns(1).Width = 130

                    ltvListas.Columns(2).Text = "Carril"
                    ltvListas.Columns(2).Width = 80



                    For modGlobal.iPosicionFilaActual = 0 To oDataSet.Tables(glstrTabla).Rows.Count - 1

                        oDataRow = oDataSet.Tables(glstrTabla).Rows(iPosicionFilaActual)

                        With ltvListas.Items.Add(Format(oDataRow("BEGIN_DHM"), "MM/dd/yyyy HH:mm:ss"))

                            .SubItems.Add(Format(oDataRow("END_DHM"), "MM/dd/yyyy HH:mm:ss"))
                            .SubItems.Add(oDataRow("LANE"))
                            .Tag = oDataRow("ID_PLAZA")
                        End With

                    Next

                    lblContador.Text = oDataSet.Tables(glstrTabla).Rows.Count & "  registros."
                Else
                    MessageBox.Show("No exiten datos,verificar", "Catalogos", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Me.Close()
                End If



            Case 6 'carriles siempre cerrados

                Dim strQuerys As String
                Dim cont2 As Integer

                Dim h_inicio_turno As Date = CDate(strLinea2)
                Dim h_fin_turno As Date = CDate(strLinea3)

                Me.Text = "Carriles Cerrados"



                glstrTabla = "TABLE"

                ltvListas.Columns.Clear()
                ltvListas.Items.Clear()
                ltvListas.LabelEdit = False


                For cont = 1 To 3
                    ltvListas.Columns.Add(New ColumnHeader)
                Next

                'strQuerys = "SELECT ID_NETWORK, ID_PLAZA,ID_LANE, LANE, BEGIN_DHM, END_DHM, BAG_NUMBER, REPORT_FLAG, GENERATION_DHM " & _
                ltvListas.Columns(0).Text = "Inicio"
                ltvListas.Columns(0).Width = 130

                ltvListas.Columns(1).Text = "Fin"
                ltvListas.Columns(1).Width = 130

                ltvListas.Columns(2).Text = "Carril"
                ltvListas.Columns(2).Width = 80


                strQuerys = "SELECT VOIE, NUM_SEQUENCE FROM SEQ_VOIE_TOD"

                If objQuerys.QueryDataSetCuatro(strQuerys, "SEQ_VOIE_TOD") = 1 Then

                    For cont2 = 0 To oDataSetCuatro.Tables("SEQ_VOIE_TOD").Rows.Count - 1

                        oDataRowCuatro = oDataSetCuatro.Tables("SEQ_VOIE_TOD").Rows.Item(cont2)


                        strQuerys = "SELECT	* FROM 	FIN_POSTE " & _
                            "WHERE	VOIE = '" & oDataRowCuatro("VOIE") & "' " & _
                            "AND ((DATE_DEBUT_POSTE >= TO_DATE('" & Format(h_inicio_turno, "yyyyMMddHHmmss") & "','YYYYMMDDHH24MISS')) " & _
                            "AND (DATE_DEBUT_POSTE <= TO_DATE('" & Format(h_fin_turno, "yyyyMMddHHmmss") & "','YYYYMMDDHH24MISS'))) "

                        If objQuerys.QueryDataSet(strQuerys, "FIN_POSTE") = 0 Then


                            strQuerys = "SELECT * " & _
    "FROM CLOSED_LANE_REPORT, SITE_GARE " & _
    "where " & _
    "CLOSED_LANE_REPORT.ID_PLAZA	=	SITE_GARE.id_Gare " & _
     "AND	SITE_GARE.id_Site		=	'" & Mid(id_plaza_cobro, 2, 2) & "' " & _
     "AND	LANE		=	'" & oDataRowCuatro("VOIE") & "' " & _
     "AND ((BEGIN_DHM >= TO_DATE('" & Format(h_inicio_turno, "yyyyMMddHHmmss") & "','YYYYMMDDHH24MISS')) " & _
    "AND (BEGIN_DHM <= TO_DATE('" & Format(h_fin_turno, "yyyyMMddHHmmss") & "','YYYYMMDDHH24MISS'))) " & _
    "order by BEGIN_DHM"

                            If objQuerys.QueryDataSet(strQuerys, "CLOSED_LANE_REPORT") = 0 Then



                                With ltvListas.Items.Add(Format(h_inicio_turno, "MM/dd/yyyy HH:mm:ss"))

                                    .SubItems.Add(Format(h_fin_turno, "MM/dd/yyyy HH:mm:ss"))
                                    .SubItems.Add(oDataRowCuatro("VOIE"))
                                    '.Tag = oDataRow("ID_PLAZA")
                                End With
                            
                            End If


                        End If

                    Next

                End If


                'If objQuerys.QueryDataSet(strLinea, glstrTabla) = 1 Then

                '    For cont = 1 To 3
                '        ltvListas.Columns.Add(New ColumnHeader)
                '    Next

                '    'strQuerys = "SELECT ID_NETWORK, ID_PLAZA,ID_LANE, LANE, BEGIN_DHM, END_DHM, BAG_NUMBER, REPORT_FLAG, GENERATION_DHM " & _
                '    ltvListas.Columns(0).Text = "Inicio"
                '    ltvListas.Columns(0).Width = 130

                '    ltvListas.Columns(1).Text = "Fin"
                '    ltvListas.Columns(1).Width = 130

                '    ltvListas.Columns(2).Text = "Carril"
                '    ltvListas.Columns(2).Width = 80



                '    For modGlobal.iPosicionFilaActual = 0 To oDataSet.Tables(glstrTabla).Rows.Count - 1

                '        oDataRow = oDataSet.Tables(glstrTabla).Rows(iPosicionFilaActual)

                '        With ltvListas.Items.Add(Format(oDataRow("BEGIN_DHM"), "MM/dd/yyyy HH:mm:ss"))

                '            .SubItems.Add(Format(oDataRow("END_DHM"), "MM/dd/yyyy HH:mm:ss"))
                '            .SubItems.Add(oDataRow("LANE"))
                '            .Tag = oDataRow("ID_PLAZA")
                '        End With

                '    Next

                '    lblContador.Text = oDataSet.Tables(glstrTabla).Rows.Count & "  registros."
                'Else
                '    MessageBox.Show("No exiten datos,verificar", "Catalogos", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                '    Me.Close()
                'End If



        End Select

        objControl.limpia_Catalogos()

    End Sub

    Private Sub ltvListas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ltvListas.DoubleClick
        If ltvListas.SelectedItems.Count > 0 Then
            seleccionar()
            Me.Close()
        End If

    End Sub

    Private Sub ltvListas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ltvListas.KeyPress

        Dim keyascii As Short = Asc(e.KeyChar)

        If keyascii = 13 Then
            If ltvListas.SelectedItems.Count > 0 Then
                seleccionar()
                Me.Close()
            End If

        End If
    End Sub

    Sub seleccionar()
        Select Case Me.Tag
            Case 1 'Plaza de Cobro

                strLinea = ltvListas.SelectedItems.Item(0).SubItems(1).Text
                strLinea1 = ltvListas.SelectedItems.Item(0).Tag

            Case 2 'Cajero-Receptor

                strLinea = ltvListas.SelectedItems.Item(0).SubItems(1).Text
                strLinea1 = ltvListas.SelectedItems.Item(0).Tag

            Case 3 'Encargado de Turno

                strLinea = ltvListas.SelectedItems.Item(0).SubItems(1).Text
                strLinea1 = ltvListas.SelectedItems.Item(0).Tag
              


            Case 4 'varios turnos

                strLinea1 = ltvListas.SelectedItems.Item(0).Text
                strLinea2 = ltvListas.SelectedItems.Item(0).SubItems(1).Text
                strLinea3 = ltvListas.SelectedItems.Item(0).SubItems(2).Text
                strLinea4 = ltvListas.SelectedItems.Item(0).SubItems(3).Text
                '***********************Cambios Daniel(Prosis)************************************************
                carrilTemp = ltvListas.SelectedItems.Item(0).SubItems(2).Text
                '*********************************************************************************************

            Case 5 'carriles cancelados

                strLinea1 = ltvListas.SelectedItems.Item(0).Text
                strLinea2 = ltvListas.SelectedItems.Item(0).SubItems(1).Text
                strLinea3 = ltvListas.SelectedItems.Item(0).SubItems(2).Text
                strLinea4 = ltvListas.SelectedItems.Item(0).Tag

            Case 6 'carriles cancelados

                strLinea1 = ltvListas.SelectedItems.Item(0).Text
                strLinea2 = ltvListas.SelectedItems.Item(0).SubItems(1).Text
                strLinea3 = ltvListas.SelectedItems.Item(0).SubItems(2).Text
                'strLinea4 = ltvListas.SelectedItems.Item(0).Tag

        End Select
    End Sub

    Private Sub ltvListas_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ltvListas.KeyUp

        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select

    End Sub


End Class