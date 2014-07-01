<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporte_diario
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.registro_control_tramitesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.registro_control_tramites = New control_de_tramites.registro_control_tramites()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.reporte_fecha = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.registro_control_tramitesTableAdapter = New control_de_tramites.registro_control_tramitesTableAdapters.registro_control_tramitesTableAdapter()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        CType(Me.registro_control_tramitesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.registro_control_tramites, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'registro_control_tramitesBindingSource
        '
        Me.registro_control_tramitesBindingSource.DataMember = "registro_control_tramites"
        Me.registro_control_tramitesBindingSource.DataSource = Me.registro_control_tramites
        '
        'registro_control_tramites
        '
        Me.registro_control_tramites.DataSetName = "registro_control_tramites"
        Me.registro_control_tramites.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(414, 8)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(96, 31)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'reporte_fecha
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.registro_control_tramitesBindingSource
        Me.reporte_fecha.LocalReport.DataSources.Add(ReportDataSource1)
        Me.reporte_fecha.LocalReport.ReportEmbeddedResource = "control_de_tramites.reporte_diario.rdlc"
        Me.reporte_fecha.Location = New System.Drawing.Point(7, 45)
        Me.reporte_fecha.Name = "reporte_fecha"
        Me.reporte_fecha.Size = New System.Drawing.Size(905, 377)
        Me.reporte_fecha.TabIndex = 3
        '
        'registro_control_tramitesTableAdapter
        '
        Me.registro_control_tramitesTableAdapter.ClearBeforeFill = True
        '
        'dtFecha
        '
        Me.dtFecha.CustomFormat = ""
        Me.dtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFecha.Location = New System.Drawing.Point(7, 8)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(401, 31)
        Me.dtFecha.TabIndex = 6
        '
        'reporte_diario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 427)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.reporte_fecha)
        Me.MaximumSize = New System.Drawing.Size(935, 466)
        Me.Name = "reporte_diario"
        Me.Text = "Reporte Diario"
        CType(Me.registro_control_tramitesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.registro_control_tramites, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents reporte_fecha As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents registro_control_tramitesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents registro_control_tramites As control_de_tramites.registro_control_tramites
    Friend WithEvents registro_control_tramitesTableAdapter As control_de_tramites.registro_control_tramitesTableAdapters.registro_control_tramitesTableAdapter
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
End Class
