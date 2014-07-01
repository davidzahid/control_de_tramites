<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nut_form
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
        Me.txtNUT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Registro_control_tramitesDataGridView = New System.Windows.Forms.DataGridView()
        Me.id_control_tramite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.documento_recibido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tramite_solicitado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_nacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.persona_autorizada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.recibido_por = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lo_resuelve = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alcance_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empresa_servicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.documento_entregado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Registro_control_tramitesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Registro_control_tramites = New control_de_tramites.registro_control_tramites()
        Me.Registro_control_tramitesTableAdapter = New control_de_tramites.registro_control_tramitesTableAdapters.registro_control_tramitesTableAdapter()
        Me.TableAdapterManager = New control_de_tramites.registro_control_tramitesTableAdapters.TableAdapterManager()
        CType(Me.Registro_control_tramitesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Registro_control_tramitesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Registro_control_tramites, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNUT
        '
        Me.txtNUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNUT.Location = New System.Drawing.Point(126, 6)
        Me.txtNUT.Name = "txtNUT"
        Me.txtNUT.Size = New System.Drawing.Size(754, 31)
        Me.txtNUT.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NUT"
        '
        'Registro_control_tramitesDataGridView
        '
        Me.Registro_control_tramitesDataGridView.AllowUserToAddRows = False
        Me.Registro_control_tramitesDataGridView.AllowUserToDeleteRows = False
        Me.Registro_control_tramitesDataGridView.AutoGenerateColumns = False
        Me.Registro_control_tramitesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Registro_control_tramitesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_control_tramite, Me.fecha_ingreso, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.documento_recibido, Me.tramite_solicitado, Me.DataGridViewTextBoxColumn8, Me.actividad, Me.DataGridViewTextBoxColumn10, Me.fecha_nacimiento, Me.edad, Me.persona_autorizada, Me.status, Me.recibido_por, Me.lo_resuelve, Me.alcance_1, Me.observaciones, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.empresa_servicio, Me.documento_entregado})
        Me.Registro_control_tramitesDataGridView.DataSource = Me.Registro_control_tramitesBindingSource
        Me.Registro_control_tramitesDataGridView.Location = New System.Drawing.Point(30, 51)
        Me.Registro_control_tramitesDataGridView.Name = "Registro_control_tramitesDataGridView"
        Me.Registro_control_tramitesDataGridView.ReadOnly = True
        Me.Registro_control_tramitesDataGridView.Size = New System.Drawing.Size(850, 263)
        Me.Registro_control_tramitesDataGridView.TabIndex = 4
        '
        'id_control_tramite
        '
        Me.id_control_tramite.DataPropertyName = "id_control_tramite"
        Me.id_control_tramite.HeaderText = "ID"
        Me.id_control_tramite.Name = "id_control_tramite"
        Me.id_control_tramite.ReadOnly = True
        Me.id_control_tramite.Visible = False
        '
        'fecha_ingreso
        '
        Me.fecha_ingreso.DataPropertyName = "fecha_ingreso"
        Me.fecha_ingreso.HeaderText = "FECHA DE INGRESO"
        Me.fecha_ingreso.Name = "fecha_ingreso"
        Me.fecha_ingreso.ReadOnly = True
        Me.fecha_ingreso.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NUT"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NUT"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn4.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "nacionalidad"
        Me.DataGridViewTextBoxColumn5.HeaderText = "NACIONALIDAD"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'documento_recibido
        '
        Me.documento_recibido.DataPropertyName = "documento_recibido"
        Me.documento_recibido.HeaderText = "DOCUMENTO RECIBIDO"
        Me.documento_recibido.Name = "documento_recibido"
        Me.documento_recibido.ReadOnly = True
        Me.documento_recibido.Visible = False
        '
        'tramite_solicitado
        '
        Me.tramite_solicitado.DataPropertyName = "tramite_solicitado"
        Me.tramite_solicitado.HeaderText = "TRAMITE SOLICITADO"
        Me.tramite_solicitado.Name = "tramite_solicitado"
        Me.tramite_solicitado.ReadOnly = True
        Me.tramite_solicitado.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "residente"
        Me.DataGridViewTextBoxColumn8.HeaderText = "RESIDENTE"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'actividad
        '
        Me.actividad.DataPropertyName = "actividad"
        Me.actividad.HeaderText = "actividad"
        Me.actividad.Name = "actividad"
        Me.actividad.ReadOnly = True
        Me.actividad.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "sexo"
        Me.DataGridViewTextBoxColumn10.HeaderText = "SEXO"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'fecha_nacimiento
        '
        Me.fecha_nacimiento.DataPropertyName = "fecha_nacimiento"
        Me.fecha_nacimiento.HeaderText = "FECHA DE NACIMIENTO"
        Me.fecha_nacimiento.Name = "fecha_nacimiento"
        Me.fecha_nacimiento.ReadOnly = True
        '
        'edad
        '
        Me.edad.DataPropertyName = "edad"
        Me.edad.HeaderText = "edad"
        Me.edad.Name = "edad"
        Me.edad.ReadOnly = True
        Me.edad.Visible = False
        '
        'persona_autorizada
        '
        Me.persona_autorizada.DataPropertyName = "persona_autorizada"
        Me.persona_autorizada.HeaderText = "persona_autorizada"
        Me.persona_autorizada.Name = "persona_autorizada"
        Me.persona_autorizada.ReadOnly = True
        Me.persona_autorizada.Visible = False
        '
        'status
        '
        Me.status.DataPropertyName = "status"
        Me.status.HeaderText = "status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Visible = False
        '
        'recibido_por
        '
        Me.recibido_por.DataPropertyName = "recibido_por"
        Me.recibido_por.HeaderText = "recibido_por"
        Me.recibido_por.Name = "recibido_por"
        Me.recibido_por.ReadOnly = True
        Me.recibido_por.Visible = False
        '
        'lo_resuelve
        '
        Me.lo_resuelve.DataPropertyName = "lo_resuelve"
        Me.lo_resuelve.HeaderText = "lo_resuelve"
        Me.lo_resuelve.Name = "lo_resuelve"
        Me.lo_resuelve.ReadOnly = True
        Me.lo_resuelve.Visible = False
        '
        'alcance_1
        '
        Me.alcance_1.DataPropertyName = "alcance_1"
        Me.alcance_1.HeaderText = "alcance_1"
        Me.alcance_1.Name = "alcance_1"
        Me.alcance_1.ReadOnly = True
        Me.alcance_1.Visible = False
        '
        'observaciones
        '
        Me.observaciones.DataPropertyName = "observaciones"
        Me.observaciones.HeaderText = "observaciones"
        Me.observaciones.Name = "observaciones"
        Me.observaciones.ReadOnly = True
        Me.observaciones.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "calle"
        Me.DataGridViewTextBoxColumn19.HeaderText = "CALLE"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "colonia"
        Me.DataGridViewTextBoxColumn20.HeaderText = "COLONIA"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "municipio"
        Me.DataGridViewTextBoxColumn21.HeaderText = "MUNICIPIO"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "cp"
        Me.DataGridViewTextBoxColumn22.HeaderText = "C.P."
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn23.HeaderText = "TELEFONO"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "correo_electronico"
        Me.DataGridViewTextBoxColumn24.HeaderText = "CORREO ELECTRONICO"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'empresa_servicio
        '
        Me.empresa_servicio.DataPropertyName = "empresa_servicio"
        Me.empresa_servicio.HeaderText = "empresa_servicio"
        Me.empresa_servicio.Name = "empresa_servicio"
        Me.empresa_servicio.ReadOnly = True
        Me.empresa_servicio.Visible = False
        '
        'documento_entregado
        '
        Me.documento_entregado.DataPropertyName = "documento_entregado"
        Me.documento_entregado.HeaderText = "documento_entregado"
        Me.documento_entregado.Name = "documento_entregado"
        Me.documento_entregado.ReadOnly = True
        Me.documento_entregado.Visible = False
        '
        'Registro_control_tramitesBindingSource
        '
        Me.Registro_control_tramitesBindingSource.DataMember = "registro_control_tramites"
        Me.Registro_control_tramitesBindingSource.DataSource = Me.Registro_control_tramites
        '
        'Registro_control_tramites
        '
        Me.Registro_control_tramites.DataSetName = "registro_control_tramites"
        Me.Registro_control_tramites.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Registro_control_tramitesTableAdapter
        '
        Me.Registro_control_tramitesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.registro_control_tramitesTableAdapter = Me.Registro_control_tramitesTableAdapter
        Me.TableAdapterManager.UpdateOrder = control_de_tramites.registro_control_tramitesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'nut_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(907, 326)
        Me.Controls.Add(Me.Registro_control_tramitesDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNUT)
        Me.Name = "nut_form"
        Me.Text = "Buscar Beneficiario"
        CType(Me.Registro_control_tramitesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Registro_control_tramitesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Registro_control_tramites, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNUT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Registro_control_tramitesTableAdapter As control_de_tramites.registro_control_tramitesTableAdapters.registro_control_tramitesTableAdapter
    Friend WithEvents Registro_control_tramites As control_de_tramites.registro_control_tramites
    Friend WithEvents Registro_control_tramitesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As control_de_tramites.registro_control_tramitesTableAdapters.TableAdapterManager
    Friend WithEvents Registro_control_tramitesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents id_control_tramite As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_ingreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents documento_recibido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tramite_solicitado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actividad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_nacimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents edad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents persona_autorizada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents recibido_por As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lo_resuelve As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents alcance_1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empresa_servicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents documento_entregado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
