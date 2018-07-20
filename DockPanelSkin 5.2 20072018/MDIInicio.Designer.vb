<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIInicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIInicio))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreliquidaciónTránsitoVehicularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rpt1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.rpt2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.rpt3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.rpt4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.rpt5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.rpt7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.rpt10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.rpt9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.rpt6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.rpt8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.rpt11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.rpt12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.rpt13 = New System.Windows.Forms.ToolStripMenuItem()
        Me.rpt14 = New System.Windows.Forms.ToolStripMenuItem()
        Me.rpt15 = New System.Windows.Forms.ToolStripMenuItem()
        Me.rpt16 = New System.Windows.Forms.ToolStripMenuItem()
        Me.rpt14_II = New System.Windows.Forms.ToolStripMenuItem()
        Me.rptDetalle_Turno_Carril = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatoDeIncidencias = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.V100ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblSac = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.ReportesMenu, Me.HelpMenu, Me.V100ToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 9
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(41, 20)
        Me.FileMenu.Text = "&Salir"
        '
        'ReportesMenu
        '
        Me.ReportesMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreliquidaciónTránsitoVehicularToolStripMenuItem, Me.rpt4, Me.rpt5, Me.rpt7, Me.rpt10, Me.rpt9, Me.rpt6, Me.rpt8, Me.rpt11, Me.rpt12, Me.rpt13, Me.rpt14, Me.rpt15, Me.rpt16, Me.rpt14_II, Me.rptDetalle_Turno_Carril, Me.FormatoDeIncidencias})
        Me.ReportesMenu.Name = "ReportesMenu"
        Me.ReportesMenu.Size = New System.Drawing.Size(65, 20)
        Me.ReportesMenu.Text = "&Reportes"
        '
        'PreliquidaciónTránsitoVehicularToolStripMenuItem
        '
        Me.PreliquidaciónTránsitoVehicularToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rpt1, Me.rpt2, Me.rpt3})
        Me.PreliquidaciónTránsitoVehicularToolStripMenuItem.Name = "PreliquidaciónTránsitoVehicularToolStripMenuItem"
        Me.PreliquidaciónTránsitoVehicularToolStripMenuItem.Size = New System.Drawing.Size(862, 22)
        Me.PreliquidaciónTránsitoVehicularToolStripMenuItem.Text = "Preliquidación Tránsito Vehicular"
        Me.PreliquidaciónTránsitoVehicularToolStripMenuItem.Visible = False
        '
        'rpt1
        '
        Me.rpt1.Name = "rpt1"
        Me.rpt1.Size = New System.Drawing.Size(273, 22)
        Me.rpt1.Tag = "1"
        Me.rpt1.Text = "Preliquidación de cajero-receptor"
        '
        'rpt2
        '
        Me.rpt2.Name = "rpt2"
        Me.rpt2.Size = New System.Drawing.Size(273, 22)
        Me.rpt2.Tag = "2"
        Me.rpt2.Text = "Preliquidación de turno"
        '
        'rpt3
        '
        Me.rpt3.Name = "rpt3"
        Me.rpt3.Size = New System.Drawing.Size(273, 22)
        Me.rpt3.Tag = "3"
        Me.rpt3.Text = "Preliquidación de día / plaza de cobro"
        '
        'rpt4
        '
        Me.rpt4.Name = "rpt4"
        Me.rpt4.Size = New System.Drawing.Size(862, 22)
        Me.rpt4.Tag = "4"
        Me.rpt4.Text = "Bitácora de Operación"
        '
        'rpt5
        '
        Me.rpt5.Name = "rpt5"
        Me.rpt5.Size = New System.Drawing.Size(862, 22)
        Me.rpt5.Tag = "5"
        Me.rpt5.Text = "Preliquidación de Cajero-Receptor para Tránsito Vehicular y Comparativo Prelimina" &
    "r de Aforo e Ingreso para Tránsito Vehícular"
        '
        'rpt7
        '
        Me.rpt7.Name = "rpt7"
        Me.rpt7.Size = New System.Drawing.Size(862, 22)
        Me.rpt7.Tag = "7"
        Me.rpt7.Text = "Preliquidación de Turno/Carriles y Comparativo Preliminar de Aforo e Ingreso por " &
    "Turno"
        '
        'rpt10
        '
        Me.rpt10.Name = "rpt10"
        Me.rpt10.Size = New System.Drawing.Size(862, 22)
        Me.rpt10.Tag = "10"
        Me.rpt10.Text = "Preliquidación de Día/Caseta y Comparativo Preliminar de Aforo e Ingreso por Día"
        '
        'rpt9
        '
        Me.rpt9.Name = "rpt9"
        Me.rpt9.Size = New System.Drawing.Size(862, 22)
        Me.rpt9.Tag = "9"
        Me.rpt9.Text = "Comparativo Preliminar de Aforo e Ingreso para Tránsito Vehícular"
        Me.rpt9.Visible = False
        '
        'rpt6
        '
        Me.rpt6.Name = "rpt6"
        Me.rpt6.Size = New System.Drawing.Size(862, 22)
        Me.rpt6.Tag = "6"
        Me.rpt6.Text = "Comparativo Preliminar de Aforo e Ingreso por Turno"
        Me.rpt6.Visible = False
        '
        'rpt8
        '
        Me.rpt8.Name = "rpt8"
        Me.rpt8.Size = New System.Drawing.Size(862, 22)
        Me.rpt8.Tag = "8"
        Me.rpt8.Text = "Comparativo Preliminar de Aforo e Ingreso por Día"
        Me.rpt8.Visible = False
        '
        'rpt11
        '
        Me.rpt11.Name = "rpt11"
        Me.rpt11.Size = New System.Drawing.Size(862, 22)
        Me.rpt11.Tag = "11"
        Me.rpt11.Text = "Comparativo Preliminar de Aforo e Ingreso para Tránsito Vehícular (Cerrados)"
        Me.rpt11.Visible = False
        '
        'rpt12
        '
        Me.rpt12.Name = "rpt12"
        Me.rpt12.Size = New System.Drawing.Size(862, 22)
        Me.rpt12.Tag = "12"
        Me.rpt12.Text = "Comparativo Preliminar de Aforo e Ingreso por Turno (Cerrados)"
        Me.rpt12.Visible = False
        '
        'rpt13
        '
        Me.rpt13.Name = "rpt13"
        Me.rpt13.Size = New System.Drawing.Size(862, 22)
        Me.rpt13.Tag = "13"
        Me.rpt13.Text = "Comparativo Preliminar de Aforo e Ingreso por Día (Cerrados)"
        Me.rpt13.Visible = False
        '
        'rpt14
        '
        Me.rpt14.Name = "rpt14"
        Me.rpt14.Size = New System.Drawing.Size(862, 22)
        Me.rpt14.Tag = "14"
        Me.rpt14.Text = "Preliquidación de Cajero-Receptor para Tránsito Vehicular (Cerrados) y Comparativ" &
    "o Preliminar de Aforo e Ingreso para Tránsito Vehícular (Cerrados)"
        '
        'rpt15
        '
        Me.rpt15.Name = "rpt15"
        Me.rpt15.Size = New System.Drawing.Size(862, 22)
        Me.rpt15.Tag = "15"
        Me.rpt15.Text = "Preliquidación de Turno/Carriles (Cerrados) y Comparativo Preliminar de Aforo e I" &
    "ngreso por Turno (Cerrados)"
        '
        'rpt16
        '
        Me.rpt16.Name = "rpt16"
        Me.rpt16.Size = New System.Drawing.Size(862, 22)
        Me.rpt16.Tag = "16"
        Me.rpt16.Text = "Preliquidación de Día/Caseta (Cerrados) y Comparativo Preliminar de Aforo e Ingre" &
    "so por Día (Cerrados)"
        '
        'rpt14_II
        '
        Me.rpt14_II.Name = "rpt14_II"
        Me.rpt14_II.Size = New System.Drawing.Size(862, 22)
        Me.rpt14_II.Tag = "1411"
        Me.rpt14_II.Text = "Preliquidación de Cajero-Receptor para Tránsito Vehicular (Cerrados) y Comparativ" &
    "o Preliminar de Aforo e Ingreso para Tránsito Vehícular (Cerrados II)"
        '
        'rptDetalle_Turno_Carril
        '
        Me.rptDetalle_Turno_Carril.Name = "rptDetalle_Turno_Carril"
        Me.rptDetalle_Turno_Carril.Size = New System.Drawing.Size(862, 22)
        Me.rptDetalle_Turno_Carril.Tag = "1001"
        Me.rptDetalle_Turno_Carril.Text = "Detalle de incidencias"
        '
        'FormatoDeIncidencias
        '
        Me.FormatoDeIncidencias.Name = "FormatoDeIncidencias"
        Me.FormatoDeIncidencias.Size = New System.Drawing.Size(862, 22)
        Me.FormatoDeIncidencias.Tag = "17"
        Me.FormatoDeIncidencias.Text = "Formato de incidencias "
        '
        'HelpMenu
        '
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(24, 20)
        Me.HelpMenu.Text = "?"
        '
        'V100ToolStripMenuItem
        '
        Me.V100ToolStripMenuItem.Name = "V100ToolStripMenuItem"
        Me.V100ToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.V100ToolStripMenuItem.Text = "V 3.3.0"
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSac})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblSac
        '
        Me.lblSac.Name = "lblSac"
        Me.lblSac.Size = New System.Drawing.Size(0, 17)
        '
        'MDIInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MDIInicio"
        Me.Text = "Reportes Caseta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreliquidaciónTránsitoVehicularToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rpt1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rpt2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rpt3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rpt9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rpt6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rpt8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rpt5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rpt7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rpt10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rpt4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rpt11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rpt12 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rpt13 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rpt14 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents V100ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rpt15 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rpt16 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblSac As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents rpt14_II As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rptDetalle_Turno_Carril As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormatoDeIncidencias As System.Windows.Forms.ToolStripMenuItem
End Class
