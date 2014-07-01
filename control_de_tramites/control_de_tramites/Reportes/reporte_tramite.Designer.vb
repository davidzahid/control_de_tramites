<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporte_tramite
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.registro_control_tramitesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Registro_control_tramites = New control_de_tramites.registro_control_tramites()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.reporte_fecha = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cbxNacionalidad = New System.Windows.Forms.ComboBox()
        Me.cbxTramite = New System.Windows.Forms.ComboBox()
        Me.RegistrocontroltramitesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Registro_control_tramitesTableAdapter = New control_de_tramites.registro_control_tramitesTableAdapters.registro_control_tramitesTableAdapter()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.NacionalidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NacionalidadTableAdapter = New control_de_tramites.registro_control_tramitesTableAdapters.nacionalidadTableAdapter()
        Me.TramitesolicitadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tramite_solicitadoTableAdapter = New control_de_tramites.registro_control_tramitesTableAdapters.tramite_solicitadoTableAdapter()
        CType(Me.registro_control_tramitesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Registro_control_tramites, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrocontroltramitesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NacionalidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TramitesolicitadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'registro_control_tramitesBindingSource
        '
        Me.registro_control_tramitesBindingSource.DataMember = "registro_control_tramites"
        Me.registro_control_tramitesBindingSource.DataSource = Me.Registro_control_tramites
        '
        'Registro_control_tramites
        '
        Me.Registro_control_tramites.DataSetName = "registro_control_tramites"
        Me.Registro_control_tramites.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(883, 5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(96, 35)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'reporte_fecha
        '
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.registro_control_tramitesBindingSource
        Me.reporte_fecha.LocalReport.DataSources.Add(ReportDataSource3)
        Me.reporte_fecha.LocalReport.ReportEmbeddedResource = "control_de_tramites.reporte_tramite.rdlc"
        Me.reporte_fecha.Location = New System.Drawing.Point(7, 45)
        Me.reporte_fecha.Name = "reporte_fecha"
        Me.reporte_fecha.Size = New System.Drawing.Size(972, 377)
        Me.reporte_fecha.TabIndex = 3
        '
        'cbxNacionalidad
        '
        Me.cbxNacionalidad.DataSource = Me.NacionalidadBindingSource
        Me.cbxNacionalidad.DisplayMember = "nacionalidad"
        Me.cbxNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxNacionalidad.FormattingEnabled = True
        Me.cbxNacionalidad.Location = New System.Drawing.Point(7, 5)
        Me.cbxNacionalidad.Name = "cbxNacionalidad"
        Me.cbxNacionalidad.Size = New System.Drawing.Size(229, 33)
        Me.cbxNacionalidad.TabIndex = 5
        Me.cbxNacionalidad.ValueMember = "nacionalidad"
        '
        'cbxTramite
        '
        Me.cbxTramite.DataSource = Me.TramitesolicitadoBindingSource
        Me.cbxTramite.DisplayMember = "tramite_solicitado"
        Me.cbxTramite.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTramite.FormattingEnabled = True
        Me.cbxTramite.Location = New System.Drawing.Point(238, 6)
        Me.cbxTramite.Name = "cbxTramite"
        Me.cbxTramite.Size = New System.Drawing.Size(422, 33)
        Me.cbxTramite.TabIndex = 5
        Me.cbxTramite.ValueMember = "tramite_solicitado"
        '
        'RegistrocontroltramitesBindingSource
        '
        Me.RegistrocontroltramitesBindingSource.DataMember = "registro_control_tramites"
        Me.RegistrocontroltramitesBindingSource.DataSource = Me.Registro_control_tramites
        '
        'Registro_control_tramitesTableAdapter
        '
        Me.Registro_control_tramitesTableAdapter.ClearBeforeFill = True
        '
        'dtFecha
        '
        Me.dtFecha.CustomFormat = "MMMM yyyy"
        Me.dtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFecha.Location = New System.Drawing.Point(665, 6)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(218, 34)
        Me.dtFecha.TabIndex = 6
        '
        'NacionalidadBindingSource
        '
        Me.NacionalidadBindingSource.DataMember = "nacionalidad"
        Me.NacionalidadBindingSource.DataSource = Me.Registro_control_tramites
        '
        'NacionalidadTableAdapter
        '
        Me.NacionalidadTableAdapter.ClearBeforeFill = True
        '
        'TramitesolicitadoBindingSource
        '
        Me.TramitesolicitadoBindingSource.DataMember = "tramite_solicitado"
        Me.TramitesolicitadoBindingSource.DataSource = Me.Registro_control_tramites
        '
        'Tramite_solicitadoTableAdapter
        '
        Me.Tramite_solicitadoTableAdapter.ClearBeforeFill = True
        '
        'reporte_tramite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 427)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.cbxTramite)
        Me.Controls.Add(Me.cbxNacionalidad)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.reporte_fecha)
        Me.MaximumSize = New System.Drawing.Size(1000, 466)
        Me.Name = "reporte_tramite"
        Me.Text = "Reporte por Nacionalidad y Tramite Solicitado"
        CType(Me.registro_control_tramitesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Registro_control_tramites, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrocontroltramitesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NacionalidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TramitesolicitadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents reporte_fecha As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cbxNacionalidad As System.Windows.Forms.ComboBox
    Friend WithEvents cbxTramite As System.Windows.Forms.ComboBox
    Friend WithEvents Registro_control_tramites As control_de_tramites.registro_control_tramites
    Friend WithEvents RegistrocontroltramitesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Registro_control_tramitesTableAdapter As control_de_tramites.registro_control_tramitesTableAdapters.registro_control_tramitesTableAdapter
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents registro_control_tramitesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NacionalidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NacionalidadTableAdapter As control_de_tramites.registro_control_tramitesTableAdapters.nacionalidadTableAdapter
    Friend WithEvents TramitesolicitadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tramite_solicitadoTableAdapter As control_de_tramites.registro_control_tramitesTableAdapters.tramite_solicitadoTableAdapter
End Class
