<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLineas
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
        Me.ltvListas = New System.Windows.Forms.ListView()
        Me.lblContador = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ltvListas
        '
        Me.ltvListas.FullRowSelect = True
        Me.ltvListas.Location = New System.Drawing.Point(13, 13)
        Me.ltvListas.Name = "ltvListas"
        Me.ltvListas.Size = New System.Drawing.Size(577, 388)
        Me.ltvListas.TabIndex = 0
        Me.ltvListas.UseCompatibleStateImageBehavior = False
        Me.ltvListas.View = System.Windows.Forms.View.Details
        '
        'lblContador
        '
        Me.lblContador.AutoSize = True
        Me.lblContador.Location = New System.Drawing.Point(443, 415)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(39, 13)
        Me.lblContador.TabIndex = 1
        Me.lblContador.Text = "Label1"
        '
        'frmLineas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 440)
        Me.Controls.Add(Me.lblContador)
        Me.Controls.Add(Me.ltvListas)
        Me.Name = "frmLineas"
        Me.Text = "Turnos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ltvListas As System.Windows.Forms.ListView
    Friend WithEvents lblContador As System.Windows.Forms.Label
End Class
