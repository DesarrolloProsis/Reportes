<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmR1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblFecha2 = New System.Windows.Forms.Label()
        Me.lblFecha1 = New System.Windows.Forms.Label()
        Me.lblEncargadoTurno = New System.Windows.Forms.Label()
        Me.lblCarril = New System.Windows.Forms.Label()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.lblCajeroReceptor = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.cmbTurnoBlo = New System.Windows.Forms.ComboBox()
        Me.txtCajeroReceptor = New System.Windows.Forms.TextBox()
        Me.cmbPlazaCobro = New System.Windows.Forms.ComboBox()
        Me.lblPlazaCobro = New System.Windows.Forms.Label()
        Me.btnGenerarReporte = New System.Windows.Forms.Button()
        Me.cmbDelegacion = New System.Windows.Forms.ComboBox()
        Me.lblDelegacion = New System.Windows.Forms.Label()
        Me.btnAutomatico = New System.Windows.Forms.Button()
        Me.cmbCarril = New System.Windows.Forms.ComboBox()
        Me.cmbEncargadoTurno = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblFecha2
        '
        Me.lblFecha2.AutoSize = True
        Me.lblFecha2.Location = New System.Drawing.Point(18, 266)
        Me.lblFecha2.Name = "lblFecha2"
        Me.lblFecha2.Size = New System.Drawing.Size(54, 13)
        Me.lblFecha2.TabIndex = 35
        Me.lblFecha2.Text = "Fecha Fin"
        '
        'lblFecha1
        '
        Me.lblFecha1.AutoSize = True
        Me.lblFecha1.Location = New System.Drawing.Point(18, 240)
        Me.lblFecha1.Name = "lblFecha1"
        Me.lblFecha1.Size = New System.Drawing.Size(65, 13)
        Me.lblFecha1.TabIndex = 34
        Me.lblFecha1.Text = "Fecha Inicio"
        '
        'lblEncargadoTurno
        '
        Me.lblEncargadoTurno.AutoSize = True
        Me.lblEncargadoTurno.Location = New System.Drawing.Point(18, 207)
        Me.lblEncargadoTurno.Name = "lblEncargadoTurno"
        Me.lblEncargadoTurno.Size = New System.Drawing.Size(105, 13)
        Me.lblEncargadoTurno.TabIndex = 33
        Me.lblEncargadoTurno.Text = "Encargado de Turno"
        '
        'lblCarril
        '
        Me.lblCarril.AutoSize = True
        Me.lblCarril.Location = New System.Drawing.Point(18, 178)
        Me.lblCarril.Name = "lblCarril"
        Me.lblCarril.Size = New System.Drawing.Size(30, 13)
        Me.lblCarril.TabIndex = 32
        Me.lblCarril.Text = "Carril"
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.Location = New System.Drawing.Point(17, 149)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(35, 13)
        Me.lblTurno.TabIndex = 31
        Me.lblTurno.Text = "Turno"
        '
        'lblCajeroReceptor
        '
        Me.lblCajeroReceptor.AutoSize = True
        Me.lblCajeroReceptor.Location = New System.Drawing.Point(17, 121)
        Me.lblCajeroReceptor.Name = "lblCajeroReceptor"
        Me.lblCajeroReceptor.Size = New System.Drawing.Size(84, 13)
        Me.lblCajeroReceptor.TabIndex = 30
        Me.lblCajeroReceptor.Text = "Cajero-Receptor"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(12, 13)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(117, 22)
        Me.btnOK.TabIndex = 29
        Me.btnOK.Text = "&Salir"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.CustomFormat = "MM/dd/yyyy HH:mm:ss"
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaFin.Location = New System.Drawing.Point(127, 262)
        Me.dtpFechaFin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(148, 20)
        Me.dtpFechaFin.TabIndex = 28
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.CustomFormat = "MM/dd/yyyy HH:mm:ss"
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaInicio.Location = New System.Drawing.Point(127, 235)
        Me.dtpFechaInicio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(148, 20)
        Me.dtpFechaInicio.TabIndex = 27
        '
        'cmbTurnoBlo
        '
        Me.cmbTurnoBlo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTurnoBlo.FormattingEnabled = True
        Me.cmbTurnoBlo.Items.AddRange(New Object() {"22:00 - 06:00", "06:00 - 14:00", "14:00 - 22:00"})
        Me.cmbTurnoBlo.Location = New System.Drawing.Point(127, 145)
        Me.cmbTurnoBlo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbTurnoBlo.Name = "cmbTurnoBlo"
        Me.cmbTurnoBlo.Size = New System.Drawing.Size(148, 21)
        Me.cmbTurnoBlo.TabIndex = 24
        '
        'txtCajeroReceptor
        '
        Me.txtCajeroReceptor.Location = New System.Drawing.Point(127, 117)
        Me.txtCajeroReceptor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCajeroReceptor.MaxLength = 6
        Me.txtCajeroReceptor.Name = "txtCajeroReceptor"
        Me.txtCajeroReceptor.Size = New System.Drawing.Size(148, 20)
        Me.txtCajeroReceptor.TabIndex = 23
        '
        'cmbPlazaCobro
        '
        Me.cmbPlazaCobro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlazaCobro.FormattingEnabled = True
        Me.cmbPlazaCobro.Items.AddRange(New Object() {"Delegación  IV"})
        Me.cmbPlazaCobro.Location = New System.Drawing.Point(127, 89)
        Me.cmbPlazaCobro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbPlazaCobro.Name = "cmbPlazaCobro"
        Me.cmbPlazaCobro.Size = New System.Drawing.Size(148, 21)
        Me.cmbPlazaCobro.TabIndex = 22
        '
        'lblPlazaCobro
        '
        Me.lblPlazaCobro.AutoSize = True
        Me.lblPlazaCobro.Location = New System.Drawing.Point(18, 93)
        Me.lblPlazaCobro.Name = "lblPlazaCobro"
        Me.lblPlazaCobro.Size = New System.Drawing.Size(79, 13)
        Me.lblPlazaCobro.TabIndex = 21
        Me.lblPlazaCobro.Text = "Plaza de Cobro"
        '
        'btnGenerarReporte
        '
        Me.btnGenerarReporte.Location = New System.Drawing.Point(12, 307)
        Me.btnGenerarReporte.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGenerarReporte.Name = "btnGenerarReporte"
        Me.btnGenerarReporte.Size = New System.Drawing.Size(117, 22)
        Me.btnGenerarReporte.TabIndex = 20
        Me.btnGenerarReporte.Text = "&Generar Reportes"
        Me.btnGenerarReporte.UseVisualStyleBackColor = True
        '
        'cmbDelegacion
        '
        Me.cmbDelegacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDelegacion.FormattingEnabled = True
        Me.cmbDelegacion.Items.AddRange(New Object() {"Delegación  III Queretaro"})
        Me.cmbDelegacion.Location = New System.Drawing.Point(127, 59)
        Me.cmbDelegacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbDelegacion.Name = "cmbDelegacion"
        Me.cmbDelegacion.Size = New System.Drawing.Size(148, 21)
        Me.cmbDelegacion.TabIndex = 19
        '
        'lblDelegacion
        '
        Me.lblDelegacion.AutoSize = True
        Me.lblDelegacion.Location = New System.Drawing.Point(18, 64)
        Me.lblDelegacion.Name = "lblDelegacion"
        Me.lblDelegacion.Size = New System.Drawing.Size(61, 13)
        Me.lblDelegacion.TabIndex = 18
        Me.lblDelegacion.Text = "Delegación"
        '
        'btnAutomatico
        '
        Me.btnAutomatico.Location = New System.Drawing.Point(161, 307)
        Me.btnAutomatico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAutomatico.Name = "btnAutomatico"
        Me.btnAutomatico.Size = New System.Drawing.Size(102, 22)
        Me.btnAutomatico.TabIndex = 36
        Me.btnAutomatico.Text = "Automatico"
        Me.btnAutomatico.UseVisualStyleBackColor = True
        '
        'cmbCarril
        '
        Me.cmbCarril.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarril.Enabled = False
        Me.cmbCarril.FormattingEnabled = True
        Me.cmbCarril.Location = New System.Drawing.Point(127, 175)
        Me.cmbCarril.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbCarril.Name = "cmbCarril"
        Me.cmbCarril.Size = New System.Drawing.Size(148, 21)
        Me.cmbCarril.TabIndex = 25
        '
        'cmbEncargadoTurno
        '
        Me.cmbEncargadoTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEncargadoTurno.FormattingEnabled = True
        Me.cmbEncargadoTurno.Location = New System.Drawing.Point(129, 203)
        Me.cmbEncargadoTurno.Name = "cmbEncargadoTurno"
        Me.cmbEncargadoTurno.Size = New System.Drawing.Size(145, 21)
        Me.cmbEncargadoTurno.TabIndex = 37
        '
        'frmR1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 342)
        Me.Controls.Add(Me.cmbEncargadoTurno)
        Me.Controls.Add(Me.btnAutomatico)
        Me.Controls.Add(Me.lblFecha2)
        Me.Controls.Add(Me.lblFecha1)
        Me.Controls.Add(Me.lblEncargadoTurno)
        Me.Controls.Add(Me.lblCarril)
        Me.Controls.Add(Me.lblTurno)
        Me.Controls.Add(Me.lblCajeroReceptor)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.cmbCarril)
        Me.Controls.Add(Me.cmbTurnoBlo)
        Me.Controls.Add(Me.txtCajeroReceptor)
        Me.Controls.Add(Me.cmbPlazaCobro)
        Me.Controls.Add(Me.lblPlazaCobro)
        Me.Controls.Add(Me.btnGenerarReporte)
        Me.Controls.Add(Me.cmbDelegacion)
        Me.Controls.Add(Me.lblDelegacion)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmR1"
        Me.Text = "frmR1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFecha2 As System.Windows.Forms.Label
    Friend WithEvents lblFecha1 As System.Windows.Forms.Label
    Friend WithEvents lblEncargadoTurno As System.Windows.Forms.Label
    Friend WithEvents lblCarril As System.Windows.Forms.Label
    Friend WithEvents lblTurno As System.Windows.Forms.Label
    Friend WithEvents lblCajeroReceptor As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbTurnoBlo As System.Windows.Forms.ComboBox
    Friend WithEvents txtCajeroReceptor As System.Windows.Forms.TextBox
    Friend WithEvents cmbPlazaCobro As System.Windows.Forms.ComboBox
    Friend WithEvents lblPlazaCobro As System.Windows.Forms.Label
    Friend WithEvents btnGenerarReporte As System.Windows.Forms.Button
    Friend WithEvents cmbDelegacion As System.Windows.Forms.ComboBox
    Friend WithEvents lblDelegacion As System.Windows.Forms.Label
    Friend WithEvents btnAutomatico As System.Windows.Forms.Button
    Friend WithEvents cmbCarril As ComboBox
    Friend WithEvents cmbEncargadoTurno As ComboBox
End Class
