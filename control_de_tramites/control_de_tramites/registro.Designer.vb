﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registro))
        Me.lblFechaIngreso = New System.Windows.Forms.Label()
        Me.lblNut = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblNacionalidad = New System.Windows.Forms.Label()
        Me.lblDocumentoRecibido = New System.Windows.Forms.Label()
        Me.lblTramiteSolicitado = New System.Windows.Forms.Label()
        Me.lblResidente = New System.Windows.Forms.Label()
        Me.lblActividad = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblFechadeNacimiento = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblPersonaAutorizada = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblRecibidoPor = New System.Windows.Forms.Label()
        Me.lblLoResuelve = New System.Windows.Forms.Label()
        Me.lblAlcance1 = New System.Windows.Forms.Label()
        Me.lblDocumentoEntregado = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.lblColonia = New System.Windows.Forms.Label()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.lblCP = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblCorreoElectronico = New System.Windows.Forms.Label()
        Me.lblEmpresaServicio = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtEmpresaServicio = New System.Windows.Forms.TextBox()
        Me.txtNombreSearch = New System.Windows.Forms.TextBox()
        Me.lblNombreSearch = New System.Windows.Forms.Label()
        Me.txtCorreoElectronico = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.txtMunicipio = New System.Windows.Forms.ComboBox()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtActividad = New System.Windows.Forms.TextBox()
        Me.txtDocumentoRecibido = New System.Windows.Forms.TextBox()
        Me.cbxNacionalidad = New System.Windows.Forms.ComboBox()
        Me.NacionalidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Registro_control_tramites = New control_de_tramites.registro_control_tramites()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtNut = New System.Windows.Forms.TextBox()
        Me.dtFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.cbxTramiteSolicitado = New System.Windows.Forms.ComboBox()
        Me.TramitesolicitadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtDocumentoEntregado = New System.Windows.Forms.TextBox()
        Me.txtAlcance = New System.Windows.Forms.TextBox()
        Me.cbxLoResuelve = New System.Windows.Forms.ComboBox()
        Me.NombreempleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbxRecibidoPor = New System.Windows.Forms.ComboBox()
        Me.cbxResidente = New System.Windows.Forms.ComboBox()
        Me.cbxStatus = New System.Windows.Forms.ComboBox()
        Me.TipostatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtPersonaAutorizada = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.cbxSexo = New System.Windows.Forms.ComboBox()
        Me.dtFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txtIdControl = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtIdControlGuardar = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SincronizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PendientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NacionalidadToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TramiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusrcarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeneficiarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PendienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDeTramitesPorMesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDeTramitesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NacionalidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TramiteSolicitadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NacionalidadToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesarrolladorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Registro_control_tramitesDataGridView = New System.Windows.Forms.DataGridView()
        Me.id_control_tramite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nacionalidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.documento_recibido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tramite_solicitado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.residente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_nacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.persona_autorizada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.recibido_por = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lo_resuelve = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alcance_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colonia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.municipio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.correo_electronico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empresa_servicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.documento_entregado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdcontroltramiteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaingresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NacionalidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentorecibidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TramitesolicitadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResidenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActividadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechanacimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EdadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonaautorizadaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecibidoporDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoresuelveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Alcance1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColoniaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MunicipioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoelectronicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpresaservicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentoentregadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Registro_control_tramitesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtFechaControl = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New control_de_tramites.registro_control_tramitesTableAdapters.TableAdapterManager()
        Me.Registro_control_tramitesTableAdapter = New control_de_tramites.registro_control_tramitesTableAdapters.registro_control_tramitesTableAdapter()
        Me.Registro_control_tramites1 = New control_de_tramites.registro_control_tramites()
        Me.Tramite_solicitadoTableAdapter = New control_de_tramites.registro_control_tramitesTableAdapters.tramite_solicitadoTableAdapter()
        Me.Tipo_statusTableAdapter = New control_de_tramites.registro_control_tramitesTableAdapters.tipo_statusTableAdapter()
        Me.Nombre_empleadoTableAdapter = New control_de_tramites.registro_control_tramitesTableAdapters.nombre_empleadoTableAdapter()
        Me.NacionalidadTableAdapter = New control_de_tramites.registro_control_tramitesTableAdapters.nacionalidadTableAdapter()
        Me.actualizar = New System.Windows.Forms.ProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RegistrocontroltramitesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreempleadoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.NacionalidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Registro_control_tramites, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TramitesolicitadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.NombreempleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipostatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Registro_control_tramitesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Registro_control_tramitesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Registro_control_tramites1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrocontroltramitesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NombreempleadoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.AutoSize = True
        Me.lblFechaIngreso.Location = New System.Drawing.Point(1, 8)
        Me.lblFechaIngreso.Name = "lblFechaIngreso"
        Me.lblFechaIngreso.Size = New System.Drawing.Size(93, 13)
        Me.lblFechaIngreso.TabIndex = 1
        Me.lblFechaIngreso.Text = "Fecha de Ingreso:"
        '
        'lblNut
        '
        Me.lblNut.AutoSize = True
        Me.lblNut.Location = New System.Drawing.Point(236, 8)
        Me.lblNut.Name = "lblNut"
        Me.lblNut.Size = New System.Drawing.Size(33, 13)
        Me.lblNut.TabIndex = 1
        Me.lblNut.Text = "NUT:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(395, 8)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre:"
        '
        'lblNacionalidad
        '
        Me.lblNacionalidad.AutoSize = True
        Me.lblNacionalidad.Location = New System.Drawing.Point(736, 8)
        Me.lblNacionalidad.Name = "lblNacionalidad"
        Me.lblNacionalidad.Size = New System.Drawing.Size(72, 13)
        Me.lblNacionalidad.TabIndex = 1
        Me.lblNacionalidad.Text = "Nacionalidad:"
        '
        'lblDocumentoRecibido
        '
        Me.lblDocumentoRecibido.AutoSize = True
        Me.lblDocumentoRecibido.Location = New System.Drawing.Point(1, 33)
        Me.lblDocumentoRecibido.Name = "lblDocumentoRecibido"
        Me.lblDocumentoRecibido.Size = New System.Drawing.Size(110, 13)
        Me.lblDocumentoRecibido.TabIndex = 1
        Me.lblDocumentoRecibido.Text = "Documento Recibido:"
        '
        'lblTramiteSolicitado
        '
        Me.lblTramiteSolicitado.AutoSize = True
        Me.lblTramiteSolicitado.Location = New System.Drawing.Point(268, 32)
        Me.lblTramiteSolicitado.Name = "lblTramiteSolicitado"
        Me.lblTramiteSolicitado.Size = New System.Drawing.Size(94, 13)
        Me.lblTramiteSolicitado.TabIndex = 1
        Me.lblTramiteSolicitado.Text = "Tramite Solicitado:"
        '
        'lblResidente
        '
        Me.lblResidente.AutoSize = True
        Me.lblResidente.Location = New System.Drawing.Point(168, 48)
        Me.lblResidente.Name = "lblResidente"
        Me.lblResidente.Size = New System.Drawing.Size(55, 13)
        Me.lblResidente.TabIndex = 1
        Me.lblResidente.Text = "Residente"
        '
        'lblActividad
        '
        Me.lblActividad.AutoSize = True
        Me.lblActividad.Location = New System.Drawing.Point(1, 64)
        Me.lblActividad.Name = "lblActividad"
        Me.lblActividad.Size = New System.Drawing.Size(54, 13)
        Me.lblActividad.TabIndex = 1
        Me.lblActividad.Text = "Actividad:"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(1, 10)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(34, 13)
        Me.lblSexo.TabIndex = 1
        Me.lblSexo.Text = "Sexo:"
        '
        'lblFechadeNacimiento
        '
        Me.lblFechadeNacimiento.AutoSize = True
        Me.lblFechadeNacimiento.Location = New System.Drawing.Point(165, 10)
        Me.lblFechadeNacimiento.Name = "lblFechadeNacimiento"
        Me.lblFechadeNacimiento.Size = New System.Drawing.Size(111, 13)
        Me.lblFechadeNacimiento.TabIndex = 1
        Me.lblFechadeNacimiento.Text = "Fecha de Nacimiento:"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Location = New System.Drawing.Point(411, 10)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(35, 13)
        Me.lblEdad.TabIndex = 1
        Me.lblEdad.Text = "Edad:"
        '
        'lblPersonaAutorizada
        '
        Me.lblPersonaAutorizada.AutoSize = True
        Me.lblPersonaAutorizada.Location = New System.Drawing.Point(527, 10)
        Me.lblPersonaAutorizada.Name = "lblPersonaAutorizada"
        Me.lblPersonaAutorizada.Size = New System.Drawing.Size(102, 13)
        Me.lblPersonaAutorizada.TabIndex = 1
        Me.lblPersonaAutorizada.Text = "Persona Autorizada:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(1, 48)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(40, 13)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "Status:"
        '
        'lblRecibidoPor
        '
        Me.lblRecibidoPor.AutoSize = True
        Me.lblRecibidoPor.Location = New System.Drawing.Point(407, 48)
        Me.lblRecibidoPor.Name = "lblRecibidoPor"
        Me.lblRecibidoPor.Size = New System.Drawing.Size(71, 13)
        Me.lblRecibidoPor.TabIndex = 1
        Me.lblRecibidoPor.Text = "Recibido Por:"
        '
        'lblLoResuelve
        '
        Me.lblLoResuelve.AutoSize = True
        Me.lblLoResuelve.Location = New System.Drawing.Point(662, 48)
        Me.lblLoResuelve.Name = "lblLoResuelve"
        Me.lblLoResuelve.Size = New System.Drawing.Size(70, 13)
        Me.lblLoResuelve.TabIndex = 1
        Me.lblLoResuelve.Text = "Lo Resuelve:"
        '
        'lblAlcance1
        '
        Me.lblAlcance1.AutoSize = True
        Me.lblAlcance1.Location = New System.Drawing.Point(1, 89)
        Me.lblAlcance1.Name = "lblAlcance1"
        Me.lblAlcance1.Size = New System.Drawing.Size(58, 13)
        Me.lblAlcance1.TabIndex = 1
        Me.lblAlcance1.Text = "Alcance 1:"
        '
        'lblDocumentoEntregado
        '
        Me.lblDocumentoEntregado.AutoSize = True
        Me.lblDocumentoEntregado.Location = New System.Drawing.Point(227, 89)
        Me.lblDocumentoEntregado.Name = "lblDocumentoEntregado"
        Me.lblDocumentoEntregado.Size = New System.Drawing.Size(117, 13)
        Me.lblDocumentoEntregado.TabIndex = 1
        Me.lblDocumentoEntregado.Text = "Documento Entregado:"
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Location = New System.Drawing.Point(497, 89)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(81, 13)
        Me.lblObservaciones.TabIndex = 1
        Me.lblObservaciones.Text = "Observaciones:"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(1, 6)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(33, 13)
        Me.lblCalle.TabIndex = 1
        Me.lblCalle.Text = "Calle:"
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.Location = New System.Drawing.Point(363, 6)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(45, 13)
        Me.lblColonia.TabIndex = 1
        Me.lblColonia.Text = "Colonia:"
        '
        'lblMunicipio
        '
        Me.lblMunicipio.AutoSize = True
        Me.lblMunicipio.Location = New System.Drawing.Point(710, 6)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(55, 13)
        Me.lblMunicipio.TabIndex = 1
        Me.lblMunicipio.Text = "Municipio:"
        '
        'lblCP
        '
        Me.lblCP.AutoSize = True
        Me.lblCP.Location = New System.Drawing.Point(1, 35)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(33, 13)
        Me.lblCP.TabIndex = 1
        Me.lblCP.Text = "C.P. :"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(132, 35)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 1
        Me.lblTelefono.Text = "Telefono:"
        '
        'lblCorreoElectronico
        '
        Me.lblCorreoElectronico.AutoSize = True
        Me.lblCorreoElectronico.Location = New System.Drawing.Point(363, 35)
        Me.lblCorreoElectronico.Name = "lblCorreoElectronico"
        Me.lblCorreoElectronico.Size = New System.Drawing.Size(97, 13)
        Me.lblCorreoElectronico.TabIndex = 1
        Me.lblCorreoElectronico.Text = "Correo Electronico:"
        '
        'lblEmpresaServicio
        '
        Me.lblEmpresaServicio.AutoSize = True
        Me.lblEmpresaServicio.Location = New System.Drawing.Point(1, 69)
        Me.lblEmpresaServicio.Name = "lblEmpresaServicio"
        Me.lblEmpresaServicio.Size = New System.Drawing.Size(183, 13)
        Me.lblEmpresaServicio.TabIndex = 1
        Me.lblEmpresaServicio.Text = "Empresa para la que presta servicios:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtEmpresaServicio)
        Me.Panel1.Controls.Add(Me.txtNombreSearch)
        Me.Panel1.Controls.Add(Me.lblNombreSearch)
        Me.Panel1.Controls.Add(Me.txtCorreoElectronico)
        Me.Panel1.Controls.Add(Me.txtTelefono)
        Me.Panel1.Controls.Add(Me.txtCP)
        Me.Panel1.Controls.Add(Me.txtMunicipio)
        Me.Panel1.Controls.Add(Me.btnReporte)
        Me.Panel1.Controls.Add(Me.txtColonia)
        Me.Panel1.Controls.Add(Me.txtCalle)
        Me.Panel1.Controls.Add(Me.lblCalle)
        Me.Panel1.Controls.Add(Me.lblEmpresaServicio)
        Me.Panel1.Controls.Add(Me.lblColonia)
        Me.Panel1.Controls.Add(Me.lblCorreoElectronico)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.lblMunicipio)
        Me.Panel1.Controls.Add(Me.lblTelefono)
        Me.Panel1.Controls.Add(Me.lblCP)
        Me.Panel1.Location = New System.Drawing.Point(52, 349)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(948, 122)
        Me.Panel1.TabIndex = 6
        '
        'txtEmpresaServicio
        '
        Me.txtEmpresaServicio.Location = New System.Drawing.Point(190, 66)
        Me.txtEmpresaServicio.MaxLength = 100
        Me.txtEmpresaServicio.Name = "txtEmpresaServicio"
        Me.txtEmpresaServicio.Size = New System.Drawing.Size(514, 20)
        Me.txtEmpresaServicio.TabIndex = 7
        '
        'txtNombreSearch
        '
        Me.txtNombreSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNombreSearch.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtNombreSearch.Location = New System.Drawing.Point(128, 96)
        Me.txtNombreSearch.Name = "txtNombreSearch"
        Me.txtNombreSearch.Size = New System.Drawing.Size(324, 20)
        Me.txtNombreSearch.TabIndex = 12
        '
        'lblNombreSearch
        '
        Me.lblNombreSearch.Location = New System.Drawing.Point(1, 99)
        Me.lblNombreSearch.Name = "lblNombreSearch"
        Me.lblNombreSearch.Size = New System.Drawing.Size(141, 17)
        Me.lblNombreSearch.TabIndex = 0
        Me.lblNombreSearch.Text = "Ingresa nombre a buscar:"
        '
        'txtCorreoElectronico
        '
        Me.txtCorreoElectronico.Location = New System.Drawing.Point(465, 32)
        Me.txtCorreoElectronico.MaxLength = 100
        Me.txtCorreoElectronico.Name = "txtCorreoElectronico"
        Me.txtCorreoElectronico.Size = New System.Drawing.Size(239, 20)
        Me.txtCorreoElectronico.TabIndex = 6
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(185, 32)
        Me.txtTelefono.MaxLength = 25
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(172, 20)
        Me.txtTelefono.TabIndex = 5
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(36, 32)
        Me.txtCP.MaxLength = 9
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(88, 20)
        Me.txtCP.TabIndex = 4
        '
        'txtMunicipio
        '
        Me.txtMunicipio.FormattingEnabled = True
        Me.txtMunicipio.Items.AddRange(New Object() {"ACATLÁN", "ACAXOCHITLÁN", "ACTOPAN", "AGUA BLANCA DE ITURBIDE", "AJACUBA", "ALFAJAYUCAN", "ALMOLOYA", "APAN", "ATITALAQUIA", "ATLAPEXCO", "ATOTONILCO DE TULA", "ATOTONILCO EL GRANDE", "CALNALI", "CARDONAL", "CHAPANTONGO", "CHAPULHUACÁN", "CHILCUAUTLA", "CUAUTEPEC DE HINOJOSA", "EL ARENAL", "ELOXOCHITLÁN", "EMILIANO ZAPATA", "EPAZOYUCAN", "FRANCISCO I. MADERO", "HUASCA DE OCAMPO", "HUAUTLA", "HUAZALINGO", "HUEHUETLA", "HUEJUTLA DE REYES", "HUICHAPAN", "IXMIQUILPAN", "JACALA DE LEDEZMA", "JALTOCÁN", "JUÁREZ HIDALGO", "LA MISIÓN", "LOLOTLA", "METEPEC", "METZTITLÁN", "MINERAL DE LA REFORMA", "MINERAL DEL CHICO", "MINERAL DEL MONTE", "MIXQUIAHUALA DE JUÁREZ", "MOLANGO DE ESCAMILLA", "NICOLÁS FLORES", "NOPALA DE VILLAGRÁN", "OMITLÁN DE JUÁREZ", "PACHUCA DE SOTO", "PACULA", "PISAFLORES", "PROGRESO DE OBREGÓN", "SAN AGUSTÍN METZQUITITLÁN", "SAN AGUSTÍN TLAXIACA", "SAN BARTOLO TUTOTEPEC", "SAN FELIPE ORIZATLÁN", "SAN SALVADOR", "SANTIAGO DE ANAYA", "SANTIAGO TULANTEPEC DE LUGO GUERRE", "SINGUILUCAN", "TASQUILLO", "TECOZAUTLA", "TENANGO DE DORIA", "TEPEAPULCO", "TEPEHUACÁN DE GUERRERO", "TEPEJI DEL RÍO DE OCAMPO", "TEPETITLÁN", "TETEPANGO", "TEZONTEPEC DE ALDAMA", "TIANGUISTENGO", "TIZAYUCA", "TLAHUELILPAN", "TLAHUILTEPA", "TLANALAPA", "TLANCHINOL", "TLAXCOAPAN", "TOLCAYUCA", "TULA DE ALLENDE", "TULANCINGO DE BRAVO", "VILLA DE TEZONTEPEC", "XOCHIATIPAN", "XOCHICOATLÁN", "YAHUALICA", "ZACUALTIPÁN DE ?NGELES", "ZAPOTLÁN DE JUÁREZ", "ZEMPOALA", "ZIMAPÁN", ""})
        Me.txtMunicipio.Location = New System.Drawing.Point(771, 3)
        Me.txtMunicipio.MaxLength = 100
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(173, 21)
        Me.txtMunicipio.TabIndex = 3
        '
        'btnReporte
        '
        Me.btnReporte.Location = New System.Drawing.Point(784, 77)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(79, 22)
        Me.btnReporte.TabIndex = 10
        Me.btnReporte.Text = "Reporte"
        Me.btnReporte.UseVisualStyleBackColor = True
        Me.btnReporte.Visible = False
        '
        'txtColonia
        '
        Me.txtColonia.Location = New System.Drawing.Point(414, 3)
        Me.txtColonia.MaxLength = 150
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(290, 20)
        Me.txtColonia.TabIndex = 2
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(36, 3)
        Me.txtCalle.MaxLength = 150
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(321, 20)
        Me.txtCalle.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.AccessibleDescription = "Actualizar Datos"
        Me.btnBuscar.AccessibleName = "Actualizar Datos"
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Location = New System.Drawing.Point(869, 77)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 22)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Tag = "Actualizar Datos"
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        Me.btnBuscar.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtActividad)
        Me.Panel2.Controls.Add(Me.txtDocumentoRecibido)
        Me.Panel2.Controls.Add(Me.cbxNacionalidad)
        Me.Panel2.Controls.Add(Me.txtNombre)
        Me.Panel2.Controls.Add(Me.txtNut)
        Me.Panel2.Controls.Add(Me.lblActividad)
        Me.Panel2.Controls.Add(Me.lblTramiteSolicitado)
        Me.Panel2.Controls.Add(Me.lblFechaIngreso)
        Me.Panel2.Controls.Add(Me.lblNut)
        Me.Panel2.Controls.Add(Me.lblNombre)
        Me.Panel2.Controls.Add(Me.dtFechaIngreso)
        Me.Panel2.Controls.Add(Me.lblNacionalidad)
        Me.Panel2.Controls.Add(Me.lblDocumentoRecibido)
        Me.Panel2.Controls.Add(Me.cbxTramiteSolicitado)
        Me.Panel2.Location = New System.Drawing.Point(52, 102)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(947, 93)
        Me.Panel2.TabIndex = 4
        '
        'txtActividad
        '
        Me.txtActividad.Location = New System.Drawing.Point(60, 61)
        Me.txtActividad.MaxLength = 50
        Me.txtActividad.Name = "txtActividad"
        Me.txtActividad.Size = New System.Drawing.Size(464, 20)
        Me.txtActividad.TabIndex = 7
        '
        'txtDocumentoRecibido
        '
        Me.txtDocumentoRecibido.Location = New System.Drawing.Point(110, 29)
        Me.txtDocumentoRecibido.MaxLength = 50
        Me.txtDocumentoRecibido.Name = "txtDocumentoRecibido"
        Me.txtDocumentoRecibido.Size = New System.Drawing.Size(153, 20)
        Me.txtDocumentoRecibido.TabIndex = 5
        '
        'cbxNacionalidad
        '
        Me.cbxNacionalidad.DataSource = Me.NacionalidadBindingSource
        Me.cbxNacionalidad.DisplayMember = "nacionalidad"
        Me.cbxNacionalidad.FormattingEnabled = True
        Me.cbxNacionalidad.Location = New System.Drawing.Point(814, 3)
        Me.cbxNacionalidad.MaxLength = 80
        Me.cbxNacionalidad.Name = "cbxNacionalidad"
        Me.cbxNacionalidad.Size = New System.Drawing.Size(133, 21)
        Me.cbxNacionalidad.TabIndex = 4
        Me.cbxNacionalidad.ValueMember = "nacionalidad"
        '
        'NacionalidadBindingSource
        '
        Me.NacionalidadBindingSource.DataMember = "nacionalidad"
        Me.NacionalidadBindingSource.DataSource = Me.Registro_control_tramites
        '
        'Registro_control_tramites
        '
        Me.Registro_control_tramites.DataSetName = "registro_control_tramites"
        Me.Registro_control_tramites.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(448, 3)
        Me.txtNombre.MaxLength = 255
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(282, 20)
        Me.txtNombre.TabIndex = 3
        '
        'txtNut
        '
        Me.txtNut.Location = New System.Drawing.Point(271, 3)
        Me.txtNut.MaxLength = 9
        Me.txtNut.Name = "txtNut"
        Me.txtNut.Size = New System.Drawing.Size(100, 20)
        Me.txtNut.TabIndex = 2
        '
        'dtFechaIngreso
        '
        Me.dtFechaIngreso.Checked = False
        Me.dtFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFechaIngreso.Location = New System.Drawing.Point(97, 4)
        Me.dtFechaIngreso.Name = "dtFechaIngreso"
        Me.dtFechaIngreso.Size = New System.Drawing.Size(119, 20)
        Me.dtFechaIngreso.TabIndex = 2
        '
        'cbxTramiteSolicitado
        '
        Me.cbxTramiteSolicitado.DataSource = Me.TramitesolicitadoBindingSource
        Me.cbxTramiteSolicitado.DisplayMember = "tramite_solicitado"
        Me.cbxTramiteSolicitado.FormattingEnabled = True
        Me.cbxTramiteSolicitado.Location = New System.Drawing.Point(362, 29)
        Me.cbxTramiteSolicitado.MaxLength = 150
        Me.cbxTramiteSolicitado.Name = "cbxTramiteSolicitado"
        Me.cbxTramiteSolicitado.Size = New System.Drawing.Size(585, 21)
        Me.cbxTramiteSolicitado.TabIndex = 6
        Me.cbxTramiteSolicitado.ValueMember = "tramite_solicitado"
        '
        'TramitesolicitadoBindingSource
        '
        Me.TramitesolicitadoBindingSource.DataMember = "tramite_solicitado"
        Me.TramitesolicitadoBindingSource.DataSource = Me.Registro_control_tramites
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtObservaciones)
        Me.Panel3.Controls.Add(Me.txtDocumentoEntregado)
        Me.Panel3.Controls.Add(Me.txtAlcance)
        Me.Panel3.Controls.Add(Me.cbxLoResuelve)
        Me.Panel3.Controls.Add(Me.cbxRecibidoPor)
        Me.Panel3.Controls.Add(Me.cbxResidente)
        Me.Panel3.Controls.Add(Me.cbxStatus)
        Me.Panel3.Controls.Add(Me.txtPersonaAutorizada)
        Me.Panel3.Controls.Add(Me.txtEdad)
        Me.Panel3.Controls.Add(Me.cbxSexo)
        Me.Panel3.Controls.Add(Me.dtFechaNacimiento)
        Me.Panel3.Controls.Add(Me.lblObservaciones)
        Me.Panel3.Controls.Add(Me.lblStatus)
        Me.Panel3.Controls.Add(Me.lblResidente)
        Me.Panel3.Controls.Add(Me.lblDocumentoEntregado)
        Me.Panel3.Controls.Add(Me.lblSexo)
        Me.Panel3.Controls.Add(Me.lblAlcance1)
        Me.Panel3.Controls.Add(Me.lblPersonaAutorizada)
        Me.Panel3.Controls.Add(Me.lblRecibidoPor)
        Me.Panel3.Controls.Add(Me.lblEdad)
        Me.Panel3.Controls.Add(Me.lblLoResuelve)
        Me.Panel3.Controls.Add(Me.lblFechadeNacimiento)
        Me.Panel3.Location = New System.Drawing.Point(52, 201)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(947, 142)
        Me.Panel3.TabIndex = 5
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(583, 86)
        Me.txtObservaciones.MaxLength = 255
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(363, 56)
        Me.txtObservaciones.TabIndex = 11
        '
        'txtDocumentoEntregado
        '
        Me.txtDocumentoEntregado.Location = New System.Drawing.Point(346, 86)
        Me.txtDocumentoEntregado.MaxLength = 100
        Me.txtDocumentoEntregado.Name = "txtDocumentoEntregado"
        Me.txtDocumentoEntregado.Size = New System.Drawing.Size(136, 20)
        Me.txtDocumentoEntregado.TabIndex = 10
        '
        'txtAlcance
        '
        Me.txtAlcance.Location = New System.Drawing.Point(67, 86)
        Me.txtAlcance.MaxLength = 80
        Me.txtAlcance.Name = "txtAlcance"
        Me.txtAlcance.Size = New System.Drawing.Size(154, 20)
        Me.txtAlcance.TabIndex = 9
        '
        'cbxLoResuelve
        '
        Me.cbxLoResuelve.DataSource = Me.NombreempleadoBindingSource1
        Me.cbxLoResuelve.DisplayMember = "nombre_empleado"
        Me.cbxLoResuelve.FormattingEnabled = True
        Me.cbxLoResuelve.Location = New System.Drawing.Point(738, 45)
        Me.cbxLoResuelve.MaxLength = 150
        Me.cbxLoResuelve.Name = "cbxLoResuelve"
        Me.cbxLoResuelve.Size = New System.Drawing.Size(209, 21)
        Me.cbxLoResuelve.TabIndex = 8
        Me.cbxLoResuelve.ValueMember = "nombre_empleado"
        '
        'NombreempleadoBindingSource
        '
        Me.NombreempleadoBindingSource.DataMember = "nombre_empleado"
        Me.NombreempleadoBindingSource.DataSource = Me.Registro_control_tramites
        '
        'cbxRecibidoPor
        '
        Me.cbxRecibidoPor.DataSource = Me.NombreempleadoBindingSource
        Me.cbxRecibidoPor.DisplayMember = "nombre_empleado"
        Me.cbxRecibidoPor.FormattingEnabled = True
        Me.cbxRecibidoPor.Location = New System.Drawing.Point(478, 45)
        Me.cbxRecibidoPor.MaxLength = 150
        Me.cbxRecibidoPor.Name = "cbxRecibidoPor"
        Me.cbxRecibidoPor.Size = New System.Drawing.Size(178, 21)
        Me.cbxRecibidoPor.TabIndex = 7
        Me.cbxRecibidoPor.ValueMember = "nombre_empleado"
        '
        'cbxResidente
        '
        Me.cbxResidente.FormattingEnabled = True
        Me.cbxResidente.Items.AddRange(New Object() {"PERMANENTE", "TEMPORAL", "N/A"})
        Me.cbxResidente.Location = New System.Drawing.Point(230, 45)
        Me.cbxResidente.MaxLength = 60
        Me.cbxResidente.Name = "cbxResidente"
        Me.cbxResidente.Size = New System.Drawing.Size(171, 21)
        Me.cbxResidente.TabIndex = 6
        '
        'cbxStatus
        '
        Me.cbxStatus.DataSource = Me.TipostatusBindingSource
        Me.cbxStatus.DisplayMember = "tipo_status"
        Me.cbxStatus.FormattingEnabled = True
        Me.cbxStatus.Location = New System.Drawing.Point(38, 45)
        Me.cbxStatus.MaxLength = 60
        Me.cbxStatus.Name = "cbxStatus"
        Me.cbxStatus.Size = New System.Drawing.Size(121, 21)
        Me.cbxStatus.TabIndex = 5
        Me.cbxStatus.ValueMember = "tipo_status"
        '
        'TipostatusBindingSource
        '
        Me.TipostatusBindingSource.DataMember = "tipo_status"
        Me.TipostatusBindingSource.DataSource = Me.Registro_control_tramites
        '
        'txtPersonaAutorizada
        '
        Me.txtPersonaAutorizada.Location = New System.Drawing.Point(632, 4)
        Me.txtPersonaAutorizada.MaxLength = 255
        Me.txtPersonaAutorizada.Name = "txtPersonaAutorizada"
        Me.txtPersonaAutorizada.Size = New System.Drawing.Size(312, 20)
        Me.txtPersonaAutorizada.TabIndex = 4
        '
        'txtEdad
        '
        Me.txtEdad.Enabled = False
        Me.txtEdad.Location = New System.Drawing.Point(452, 5)
        Me.txtEdad.MaxLength = 3
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(59, 20)
        Me.txtEdad.TabIndex = 3
        '
        'cbxSexo
        '
        Me.cbxSexo.FormattingEnabled = True
        Me.cbxSexo.Items.AddRange(New Object() {"MASCULINO", "FEMENINO"})
        Me.cbxSexo.Location = New System.Drawing.Point(38, 4)
        Me.cbxSexo.MaxLength = 11
        Me.cbxSexo.Name = "cbxSexo"
        Me.cbxSexo.Size = New System.Drawing.Size(121, 21)
        Me.cbxSexo.TabIndex = 1
        '
        'dtFechaNacimiento
        '
        Me.dtFechaNacimiento.Checked = False
        Me.dtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFechaNacimiento.Location = New System.Drawing.Point(282, 4)
        Me.dtFechaNacimiento.Name = "dtFechaNacimiento"
        Me.dtFechaNacimiento.Size = New System.Drawing.Size(119, 20)
        Me.dtFechaNacimiento.TabIndex = 2
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("LM Roman Caps 10", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(630, 33)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(370, 44)
        Me.lblTitulo.TabIndex = 7
        Me.lblTitulo.Text = "Control de Tramites"
        '
        'btnModificar
        '
        Me.btnModificar.AccessibleDescription = "Actualizar Datos"
        Me.btnModificar.AccessibleName = "Actualizar Datos"
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(921, 471)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(79, 26)
        Me.btnModificar.TabIndex = 8
        Me.btnModificar.Tag = "Actualizar Datos"
        Me.btnModificar.Text = "Actualizar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'txtIdControl
        '
        Me.txtIdControl.Enabled = False
        Me.txtIdControl.Location = New System.Drawing.Point(70, 54)
        Me.txtIdControl.Name = "txtIdControl"
        Me.txtIdControl.Size = New System.Drawing.Size(70, 20)
        Me.txtIdControl.TabIndex = 9
        Me.txtIdControl.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(921, 501)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(79, 26)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtIdControlGuardar
        '
        Me.txtIdControlGuardar.Enabled = False
        Me.txtIdControlGuardar.Location = New System.Drawing.Point(139, 54)
        Me.txtIdControlGuardar.Name = "txtIdControlGuardar"
        Me.txtIdControlGuardar.Size = New System.Drawing.Size(52, 20)
        Me.txtIdControlGuardar.TabIndex = 9
        Me.txtIdControlGuardar.Visible = False
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(70, 40)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(62, 20)
        Me.txtFecha.TabIndex = 9
        Me.txtFecha.Visible = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Location = New System.Drawing.Point(921, 530)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(79, 26)
        Me.btnLimpiar.TabIndex = 10
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(190, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "INSTITUTO NACIONAL DE MIGRACIÓN" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(190, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(313, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "SUBDIRECCIÓN DE REGULACIÓN MIGRATORIA" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(190, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(266, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "CONTROL DE TRAMITES MIGRATORIOS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.NotificacionesToolStripMenuItem, Me.OperacionesToolStripMenuItem, Me.BusrcarToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1049, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SincronizarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SincronizarToolStripMenuItem
        '
        Me.SincronizarToolStripMenuItem.Image = Global.control_de_tramites.My.Resources.Resources.sincronizar
        Me.SincronizarToolStripMenuItem.Name = "SincronizarToolStripMenuItem"
        Me.SincronizarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.SincronizarToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.SincronizarToolStripMenuItem.Text = "Actualizar BD"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.control_de_tramites.My.Resources.Resources.salir
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.SalirToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'NotificacionesToolStripMenuItem
        '
        Me.NotificacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PendientesToolStripMenuItem})
        Me.NotificacionesToolStripMenuItem.Name = "NotificacionesToolStripMenuItem"
        Me.NotificacionesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.NotificacionesToolStripMenuItem.Text = "Tramites"
        '
        'PendientesToolStripMenuItem
        '
        Me.PendientesToolStripMenuItem.Image = Global.control_de_tramites.My.Resources.Resources.notification
        Me.PendientesToolStripMenuItem.Name = "PendientesToolStripMenuItem"
        Me.PendientesToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PendientesToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.PendientesToolStripMenuItem.Text = "Pendientes"
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActualizarToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.LimpiarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.AgregarToolStripMenuItem})
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.RightToLeftAutoMirrorImage = True
        Me.OperacionesToolStripMenuItem.ShowShortcutKeys = False
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.OperacionesToolStripMenuItem.Text = "&Operación"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.control_de_tramites.My.Resources.Resources.update
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ActualizarToolStripMenuItem.Text = "&Actualizar"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Image = Global.control_de_tramites.My.Resources.Resources.save
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.GuardarToolStripMenuItem.Text = "&Guardar"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Image = Global.control_de_tramites.My.Resources.Resources.erase1
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.LimpiarToolStripMenuItem.Text = "&Limpiar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.control_de_tramites.My.Resources.Resources.delete
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.EliminarToolStripMenuItem.Text = "&Eliminar"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NacionalidadToolStripMenuItem2, Me.TramiteToolStripMenuItem, Me.StatusToolStripMenuItem, Me.PersonalToolStripMenuItem})
        Me.AgregarToolStripMenuItem.Image = Global.control_de_tramites.My.Resources.Resources.add
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'NacionalidadToolStripMenuItem2
        '
        Me.NacionalidadToolStripMenuItem2.Image = Global.control_de_tramites.My.Resources.Resources.national
        Me.NacionalidadToolStripMenuItem2.Name = "NacionalidadToolStripMenuItem2"
        Me.NacionalidadToolStripMenuItem2.Size = New System.Drawing.Size(144, 22)
        Me.NacionalidadToolStripMenuItem2.Text = "Nacionalidad"
        '
        'TramiteToolStripMenuItem
        '
        Me.TramiteToolStripMenuItem.Image = Global.control_de_tramites.My.Resources.Resources.tramite
        Me.TramiteToolStripMenuItem.Name = "TramiteToolStripMenuItem"
        Me.TramiteToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.TramiteToolStripMenuItem.Text = "Tramite"
        '
        'StatusToolStripMenuItem
        '
        Me.StatusToolStripMenuItem.Image = Global.control_de_tramites.My.Resources.Resources.status
        Me.StatusToolStripMenuItem.Name = "StatusToolStripMenuItem"
        Me.StatusToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.StatusToolStripMenuItem.Text = "Status"
        '
        'PersonalToolStripMenuItem
        '
        Me.PersonalToolStripMenuItem.Image = Global.control_de_tramites.My.Resources.Resources.personal
        Me.PersonalToolStripMenuItem.Name = "PersonalToolStripMenuItem"
        Me.PersonalToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PersonalToolStripMenuItem.Text = "Personal"
        '
        'BusrcarToolStripMenuItem
        '
        Me.BusrcarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeneficiarioToolStripMenuItem, Me.PendienteToolStripMenuItem, Me.NUTToolStripMenuItem})
        Me.BusrcarToolStripMenuItem.Name = "BusrcarToolStripMenuItem"
        Me.BusrcarToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.BusrcarToolStripMenuItem.Text = "&Buscar"
        '
        'BeneficiarioToolStripMenuItem
        '
        Me.BeneficiarioToolStripMenuItem.Image = Global.control_de_tramites.My.Resources.Resources.people
        Me.BeneficiarioToolStripMenuItem.Name = "BeneficiarioToolStripMenuItem"
        Me.BeneficiarioToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.BeneficiarioToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.BeneficiarioToolStripMenuItem.Text = "Beneficia&rio"
        '
        'PendienteToolStripMenuItem
        '
        Me.PendienteToolStripMenuItem.Image = Global.control_de_tramites.My.Resources.Resources.status
        Me.PendienteToolStripMenuItem.Name = "PendienteToolStripMenuItem"
        Me.PendienteToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.PendienteToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.PendienteToolStripMenuItem.Text = "S&tatus"
        '
        'NUTToolStripMenuItem
        '
        Me.NUTToolStripMenuItem.Image = Global.control_de_tramites.My.Resources.Resources.NUT
        Me.NUTToolStripMenuItem.Name = "NUTToolStripMenuItem"
        Me.NUTToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NUTToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.NUTToolStripMenuItem.Text = "NUT"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnioToolStripMenuItem, Me.ControlDeTramitesPorMesToolStripMenuItem, Me.DiarioToolStripMenuItem, Me.ControlDeTramitesToolStripMenuItem, Me.NacionalidadToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ReportesToolStripMenuItem.Text = "&Reporte"
        '
        'AnioToolStripMenuItem
        '
        Me.AnioToolStripMenuItem.Image = Global.control_de_tramites.My.Resources.Resources.year
        Me.AnioToolStripMenuItem.Name = "AnioToolStripMenuItem"
        Me.AnioToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.AnioToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.AnioToolStripMenuItem.Text = "An&ual"
        '
        'ControlDeTramitesPorMesToolStripMenuItem
        '
        Me.ControlDeTramitesPorMesToolStripMenuItem.Image = Global.control_de_tramites.My.Resources.Resources.month
        Me.ControlDeTramitesPorMesToolStripMenuItem.Name = "ControlDeTramitesPorMesToolStripMenuItem"
        Me.ControlDeTramitesPorMesToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.ControlDeTramitesPorMesToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ControlDeTramitesPorMesToolStripMenuItem.Text = "&Mensual"
        '
        'DiarioToolStripMenuItem
        '
        Me.DiarioToolStripMenuItem.Image = Global.control_de_tramites.My.Resources.Resources.day
        Me.DiarioToolStripMenuItem.Name = "DiarioToolStripMenuItem"
        Me.DiarioToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.DiarioToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.DiarioToolStripMenuItem.Text = "Diar&io"
        '
        'ControlDeTramitesToolStripMenuItem
        '
        Me.ControlDeTramitesToolStripMenuItem.Image = Global.control_de_tramites.My.Resources.Resources.general1
        Me.ControlDeTramitesToolStripMenuItem.Name = "ControlDeTramitesToolStripMenuItem"
        Me.ControlDeTramitesToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ControlDeTramitesToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ControlDeTramitesToolStripMenuItem.Tag = "e"
        Me.ControlDeTramitesToolStripMenuItem.Text = "G&eneral"
        '
        'NacionalidadToolStripMenuItem
        '
        Me.NacionalidadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TramiteSolicitadoToolStripMenuItem, Me.NacionalidadToolStripMenuItem1})
        Me.NacionalidadToolStripMenuItem.Image = Global.control_de_tramites.My.Resources.Resources.nation
        Me.NacionalidadToolStripMenuItem.Name = "NacionalidadToolStripMenuItem"
        Me.NacionalidadToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.NacionalidadToolStripMenuItem.Text = "Nacionalidad"
        '
        'TramiteSolicitadoToolStripMenuItem
        '
        Me.TramiteSolicitadoToolStripMenuItem.Image = Global.control_de_tramites.My.Resources.Resources.tramite
        Me.TramiteSolicitadoToolStripMenuItem.Name = "TramiteSolicitadoToolStripMenuItem"
        Me.TramiteSolicitadoToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.TramiteSolicitadoToolStripMenuItem.Text = "Tramite Solicitado"
        '
        'NacionalidadToolStripMenuItem1
        '
        Me.NacionalidadToolStripMenuItem1.Image = Global.control_de_tramites.My.Resources.Resources.national
        Me.NacionalidadToolStripMenuItem1.Name = "NacionalidadToolStripMenuItem1"
        Me.NacionalidadToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.NacionalidadToolStripMenuItem1.Text = "Nacionalidad"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DesarrolladorToolStripMenuItem})
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'DesarrolladorToolStripMenuItem
        '
        Me.DesarrolladorToolStripMenuItem.Image = Global.control_de_tramites.My.Resources.Resources.desarrollador
        Me.DesarrolladorToolStripMenuItem.Name = "DesarrolladorToolStripMenuItem"
        Me.DesarrolladorToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.DesarrolladorToolStripMenuItem.Text = "Desarrollador"
        '
        'Registro_control_tramitesDataGridView
        '
        Me.Registro_control_tramitesDataGridView.AutoGenerateColumns = False
        Me.Registro_control_tramitesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Registro_control_tramitesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_control_tramite, Me.fecha_ingreso, Me.NUT, Me.nombre, Me.nacionalidad, Me.documento_recibido, Me.tramite_solicitado, Me.residente, Me.actividad, Me.sexo, Me.fecha_nacimiento, Me.edad, Me.persona_autorizada, Me.status, Me.recibido_por, Me.lo_resuelve, Me.alcance_1, Me.observaciones, Me.calle, Me.colonia, Me.municipio, Me.cp, Me.telefono, Me.correo_electronico, Me.empresa_servicio, Me.documento_entregado, Me.IdcontroltramiteDataGridViewTextBoxColumn, Me.FechaingresoDataGridViewTextBoxColumn, Me.NUTDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.NacionalidadDataGridViewTextBoxColumn, Me.DocumentorecibidoDataGridViewTextBoxColumn, Me.TramitesolicitadoDataGridViewTextBoxColumn, Me.ResidenteDataGridViewTextBoxColumn, Me.ActividadDataGridViewTextBoxColumn, Me.SexoDataGridViewTextBoxColumn, Me.FechanacimientoDataGridViewTextBoxColumn, Me.EdadDataGridViewTextBoxColumn, Me.PersonaautorizadaDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.RecibidoporDataGridViewTextBoxColumn, Me.LoresuelveDataGridViewTextBoxColumn, Me.Alcance1DataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn, Me.CalleDataGridViewTextBoxColumn, Me.ColoniaDataGridViewTextBoxColumn, Me.MunicipioDataGridViewTextBoxColumn, Me.CpDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.CorreoelectronicoDataGridViewTextBoxColumn, Me.EmpresaservicioDataGridViewTextBoxColumn, Me.DocumentoentregadoDataGridViewTextBoxColumn})
        Me.Registro_control_tramitesDataGridView.DataSource = Me.Registro_control_tramitesBindingSource
        Me.Registro_control_tramitesDataGridView.Location = New System.Drawing.Point(52, 474)
        Me.Registro_control_tramitesDataGridView.Name = "Registro_control_tramitesDataGridView"
        Me.Registro_control_tramitesDataGridView.ReadOnly = True
        Me.Registro_control_tramitesDataGridView.Size = New System.Drawing.Size(863, 110)
        Me.Registro_control_tramitesDataGridView.TabIndex = 15
        '
        'id_control_tramite
        '
        Me.id_control_tramite.DataPropertyName = "id_control_tramite"
        Me.id_control_tramite.HeaderText = "ID_TRAMITE"
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
        '
        'NUT
        '
        Me.NUT.DataPropertyName = "NUT"
        Me.NUT.HeaderText = "NUT"
        Me.NUT.Name = "NUT"
        Me.NUT.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "NOMBRE"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'nacionalidad
        '
        Me.nacionalidad.DataPropertyName = "nacionalidad"
        Me.nacionalidad.FillWeight = 110.0!
        Me.nacionalidad.HeaderText = "NACIONALIDAD"
        Me.nacionalidad.Name = "nacionalidad"
        Me.nacionalidad.ReadOnly = True
        Me.nacionalidad.Width = 110
        '
        'documento_recibido
        '
        Me.documento_recibido.DataPropertyName = "documento_recibido"
        Me.documento_recibido.HeaderText = "documento_recibido"
        Me.documento_recibido.Name = "documento_recibido"
        Me.documento_recibido.ReadOnly = True
        Me.documento_recibido.Visible = False
        '
        'tramite_solicitado
        '
        Me.tramite_solicitado.DataPropertyName = "tramite_solicitado"
        Me.tramite_solicitado.HeaderText = "tramite_solicitado"
        Me.tramite_solicitado.Name = "tramite_solicitado"
        Me.tramite_solicitado.ReadOnly = True
        Me.tramite_solicitado.Visible = False
        '
        'residente
        '
        Me.residente.DataPropertyName = "residente"
        Me.residente.HeaderText = "RESIDENTE"
        Me.residente.Name = "residente"
        Me.residente.ReadOnly = True
        '
        'actividad
        '
        Me.actividad.DataPropertyName = "actividad"
        Me.actividad.HeaderText = "actividad"
        Me.actividad.Name = "actividad"
        Me.actividad.ReadOnly = True
        Me.actividad.Visible = False
        '
        'sexo
        '
        Me.sexo.DataPropertyName = "sexo"
        Me.sexo.HeaderText = "sexo"
        Me.sexo.Name = "sexo"
        Me.sexo.ReadOnly = True
        Me.sexo.Visible = False
        '
        'fecha_nacimiento
        '
        Me.fecha_nacimiento.DataPropertyName = "fecha_nacimiento"
        Me.fecha_nacimiento.HeaderText = "fecha_nacimiento"
        Me.fecha_nacimiento.Name = "fecha_nacimiento"
        Me.fecha_nacimiento.ReadOnly = True
        Me.fecha_nacimiento.Visible = False
        '
        'edad
        '
        Me.edad.DataPropertyName = "edad"
        Me.edad.HeaderText = "EDAD"
        Me.edad.Name = "edad"
        Me.edad.ReadOnly = True
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
        Me.status.HeaderText = "STATUS"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
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
        Me.observaciones.FillWeight = 160.0!
        Me.observaciones.HeaderText = "OBSERVACIONES"
        Me.observaciones.Name = "observaciones"
        Me.observaciones.ReadOnly = True
        Me.observaciones.Width = 160
        '
        'calle
        '
        Me.calle.DataPropertyName = "calle"
        Me.calle.HeaderText = "calle"
        Me.calle.Name = "calle"
        Me.calle.ReadOnly = True
        Me.calle.Visible = False
        '
        'colonia
        '
        Me.colonia.DataPropertyName = "colonia"
        Me.colonia.HeaderText = "colonia"
        Me.colonia.Name = "colonia"
        Me.colonia.ReadOnly = True
        Me.colonia.Visible = False
        '
        'municipio
        '
        Me.municipio.DataPropertyName = "municipio"
        Me.municipio.HeaderText = "municipio"
        Me.municipio.Name = "municipio"
        Me.municipio.ReadOnly = True
        Me.municipio.Visible = False
        '
        'cp
        '
        Me.cp.DataPropertyName = "cp"
        Me.cp.HeaderText = "cp"
        Me.cp.Name = "cp"
        Me.cp.ReadOnly = True
        Me.cp.Visible = False
        '
        'telefono
        '
        Me.telefono.DataPropertyName = "telefono"
        Me.telefono.HeaderText = "telefono"
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        Me.telefono.Visible = False
        '
        'correo_electronico
        '
        Me.correo_electronico.DataPropertyName = "correo_electronico"
        Me.correo_electronico.HeaderText = "correo_electronico"
        Me.correo_electronico.Name = "correo_electronico"
        Me.correo_electronico.ReadOnly = True
        Me.correo_electronico.Visible = False
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
        'IdcontroltramiteDataGridViewTextBoxColumn
        '
        Me.IdcontroltramiteDataGridViewTextBoxColumn.DataPropertyName = "id_control_tramite"
        Me.IdcontroltramiteDataGridViewTextBoxColumn.HeaderText = "id_control_tramite"
        Me.IdcontroltramiteDataGridViewTextBoxColumn.Name = "IdcontroltramiteDataGridViewTextBoxColumn"
        Me.IdcontroltramiteDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdcontroltramiteDataGridViewTextBoxColumn.Visible = False
        '
        'FechaingresoDataGridViewTextBoxColumn
        '
        Me.FechaingresoDataGridViewTextBoxColumn.DataPropertyName = "fecha_ingreso"
        Me.FechaingresoDataGridViewTextBoxColumn.HeaderText = "fecha_ingreso"
        Me.FechaingresoDataGridViewTextBoxColumn.Name = "FechaingresoDataGridViewTextBoxColumn"
        Me.FechaingresoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaingresoDataGridViewTextBoxColumn.Visible = False
        '
        'NUTDataGridViewTextBoxColumn
        '
        Me.NUTDataGridViewTextBoxColumn.DataPropertyName = "NUT"
        Me.NUTDataGridViewTextBoxColumn.HeaderText = "NUT"
        Me.NUTDataGridViewTextBoxColumn.Name = "NUTDataGridViewTextBoxColumn"
        Me.NUTDataGridViewTextBoxColumn.ReadOnly = True
        Me.NUTDataGridViewTextBoxColumn.Visible = False
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Visible = False
        '
        'NacionalidadDataGridViewTextBoxColumn
        '
        Me.NacionalidadDataGridViewTextBoxColumn.DataPropertyName = "nacionalidad"
        Me.NacionalidadDataGridViewTextBoxColumn.HeaderText = "nacionalidad"
        Me.NacionalidadDataGridViewTextBoxColumn.Name = "NacionalidadDataGridViewTextBoxColumn"
        Me.NacionalidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.NacionalidadDataGridViewTextBoxColumn.Visible = False
        '
        'DocumentorecibidoDataGridViewTextBoxColumn
        '
        Me.DocumentorecibidoDataGridViewTextBoxColumn.DataPropertyName = "documento_recibido"
        Me.DocumentorecibidoDataGridViewTextBoxColumn.HeaderText = "documento_recibido"
        Me.DocumentorecibidoDataGridViewTextBoxColumn.Name = "DocumentorecibidoDataGridViewTextBoxColumn"
        Me.DocumentorecibidoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DocumentorecibidoDataGridViewTextBoxColumn.Visible = False
        '
        'TramitesolicitadoDataGridViewTextBoxColumn
        '
        Me.TramitesolicitadoDataGridViewTextBoxColumn.DataPropertyName = "tramite_solicitado"
        Me.TramitesolicitadoDataGridViewTextBoxColumn.HeaderText = "tramite_solicitado"
        Me.TramitesolicitadoDataGridViewTextBoxColumn.Name = "TramitesolicitadoDataGridViewTextBoxColumn"
        Me.TramitesolicitadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TramitesolicitadoDataGridViewTextBoxColumn.Visible = False
        '
        'ResidenteDataGridViewTextBoxColumn
        '
        Me.ResidenteDataGridViewTextBoxColumn.DataPropertyName = "residente"
        Me.ResidenteDataGridViewTextBoxColumn.HeaderText = "residente"
        Me.ResidenteDataGridViewTextBoxColumn.Name = "ResidenteDataGridViewTextBoxColumn"
        Me.ResidenteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ResidenteDataGridViewTextBoxColumn.Visible = False
        '
        'ActividadDataGridViewTextBoxColumn
        '
        Me.ActividadDataGridViewTextBoxColumn.DataPropertyName = "actividad"
        Me.ActividadDataGridViewTextBoxColumn.HeaderText = "actividad"
        Me.ActividadDataGridViewTextBoxColumn.Name = "ActividadDataGridViewTextBoxColumn"
        Me.ActividadDataGridViewTextBoxColumn.ReadOnly = True
        Me.ActividadDataGridViewTextBoxColumn.Visible = False
        '
        'SexoDataGridViewTextBoxColumn
        '
        Me.SexoDataGridViewTextBoxColumn.DataPropertyName = "sexo"
        Me.SexoDataGridViewTextBoxColumn.HeaderText = "sexo"
        Me.SexoDataGridViewTextBoxColumn.Name = "SexoDataGridViewTextBoxColumn"
        Me.SexoDataGridViewTextBoxColumn.ReadOnly = True
        Me.SexoDataGridViewTextBoxColumn.Visible = False
        '
        'FechanacimientoDataGridViewTextBoxColumn
        '
        Me.FechanacimientoDataGridViewTextBoxColumn.DataPropertyName = "fecha_nacimiento"
        Me.FechanacimientoDataGridViewTextBoxColumn.HeaderText = "fecha_nacimiento"
        Me.FechanacimientoDataGridViewTextBoxColumn.Name = "FechanacimientoDataGridViewTextBoxColumn"
        Me.FechanacimientoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechanacimientoDataGridViewTextBoxColumn.Visible = False
        '
        'EdadDataGridViewTextBoxColumn
        '
        Me.EdadDataGridViewTextBoxColumn.DataPropertyName = "edad"
        Me.EdadDataGridViewTextBoxColumn.HeaderText = "edad"
        Me.EdadDataGridViewTextBoxColumn.Name = "EdadDataGridViewTextBoxColumn"
        Me.EdadDataGridViewTextBoxColumn.ReadOnly = True
        Me.EdadDataGridViewTextBoxColumn.Visible = False
        '
        'PersonaautorizadaDataGridViewTextBoxColumn
        '
        Me.PersonaautorizadaDataGridViewTextBoxColumn.DataPropertyName = "persona_autorizada"
        Me.PersonaautorizadaDataGridViewTextBoxColumn.HeaderText = "persona_autorizada"
        Me.PersonaautorizadaDataGridViewTextBoxColumn.Name = "PersonaautorizadaDataGridViewTextBoxColumn"
        Me.PersonaautorizadaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PersonaautorizadaDataGridViewTextBoxColumn.Visible = False
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusDataGridViewTextBoxColumn.Visible = False
        '
        'RecibidoporDataGridViewTextBoxColumn
        '
        Me.RecibidoporDataGridViewTextBoxColumn.DataPropertyName = "recibido_por"
        Me.RecibidoporDataGridViewTextBoxColumn.HeaderText = "recibido_por"
        Me.RecibidoporDataGridViewTextBoxColumn.Name = "RecibidoporDataGridViewTextBoxColumn"
        Me.RecibidoporDataGridViewTextBoxColumn.ReadOnly = True
        Me.RecibidoporDataGridViewTextBoxColumn.Visible = False
        '
        'LoresuelveDataGridViewTextBoxColumn
        '
        Me.LoresuelveDataGridViewTextBoxColumn.DataPropertyName = "lo_resuelve"
        Me.LoresuelveDataGridViewTextBoxColumn.HeaderText = "lo_resuelve"
        Me.LoresuelveDataGridViewTextBoxColumn.Name = "LoresuelveDataGridViewTextBoxColumn"
        Me.LoresuelveDataGridViewTextBoxColumn.ReadOnly = True
        Me.LoresuelveDataGridViewTextBoxColumn.Visible = False
        '
        'Alcance1DataGridViewTextBoxColumn
        '
        Me.Alcance1DataGridViewTextBoxColumn.DataPropertyName = "alcance_1"
        Me.Alcance1DataGridViewTextBoxColumn.HeaderText = "alcance_1"
        Me.Alcance1DataGridViewTextBoxColumn.Name = "Alcance1DataGridViewTextBoxColumn"
        Me.Alcance1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Alcance1DataGridViewTextBoxColumn.Visible = False
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        Me.ObservacionesDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObservacionesDataGridViewTextBoxColumn.Visible = False
        '
        'CalleDataGridViewTextBoxColumn
        '
        Me.CalleDataGridViewTextBoxColumn.DataPropertyName = "calle"
        Me.CalleDataGridViewTextBoxColumn.HeaderText = "calle"
        Me.CalleDataGridViewTextBoxColumn.Name = "CalleDataGridViewTextBoxColumn"
        Me.CalleDataGridViewTextBoxColumn.ReadOnly = True
        Me.CalleDataGridViewTextBoxColumn.Visible = False
        '
        'ColoniaDataGridViewTextBoxColumn
        '
        Me.ColoniaDataGridViewTextBoxColumn.DataPropertyName = "colonia"
        Me.ColoniaDataGridViewTextBoxColumn.HeaderText = "colonia"
        Me.ColoniaDataGridViewTextBoxColumn.Name = "ColoniaDataGridViewTextBoxColumn"
        Me.ColoniaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ColoniaDataGridViewTextBoxColumn.Visible = False
        '
        'MunicipioDataGridViewTextBoxColumn
        '
        Me.MunicipioDataGridViewTextBoxColumn.DataPropertyName = "municipio"
        Me.MunicipioDataGridViewTextBoxColumn.HeaderText = "municipio"
        Me.MunicipioDataGridViewTextBoxColumn.Name = "MunicipioDataGridViewTextBoxColumn"
        Me.MunicipioDataGridViewTextBoxColumn.ReadOnly = True
        Me.MunicipioDataGridViewTextBoxColumn.Visible = False
        '
        'CpDataGridViewTextBoxColumn
        '
        Me.CpDataGridViewTextBoxColumn.DataPropertyName = "cp"
        Me.CpDataGridViewTextBoxColumn.HeaderText = "cp"
        Me.CpDataGridViewTextBoxColumn.Name = "CpDataGridViewTextBoxColumn"
        Me.CpDataGridViewTextBoxColumn.ReadOnly = True
        Me.CpDataGridViewTextBoxColumn.Visible = False
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelefonoDataGridViewTextBoxColumn.Visible = False
        '
        'CorreoelectronicoDataGridViewTextBoxColumn
        '
        Me.CorreoelectronicoDataGridViewTextBoxColumn.DataPropertyName = "correo_electronico"
        Me.CorreoelectronicoDataGridViewTextBoxColumn.HeaderText = "correo_electronico"
        Me.CorreoelectronicoDataGridViewTextBoxColumn.Name = "CorreoelectronicoDataGridViewTextBoxColumn"
        Me.CorreoelectronicoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CorreoelectronicoDataGridViewTextBoxColumn.Visible = False
        '
        'EmpresaservicioDataGridViewTextBoxColumn
        '
        Me.EmpresaservicioDataGridViewTextBoxColumn.DataPropertyName = "empresa_servicio"
        Me.EmpresaservicioDataGridViewTextBoxColumn.HeaderText = "empresa_servicio"
        Me.EmpresaservicioDataGridViewTextBoxColumn.Name = "EmpresaservicioDataGridViewTextBoxColumn"
        Me.EmpresaservicioDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmpresaservicioDataGridViewTextBoxColumn.Visible = False
        '
        'DocumentoentregadoDataGridViewTextBoxColumn
        '
        Me.DocumentoentregadoDataGridViewTextBoxColumn.DataPropertyName = "documento_entregado"
        Me.DocumentoentregadoDataGridViewTextBoxColumn.HeaderText = "documento_entregado"
        Me.DocumentoentregadoDataGridViewTextBoxColumn.Name = "DocumentoentregadoDataGridViewTextBoxColumn"
        Me.DocumentoentregadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DocumentoentregadoDataGridViewTextBoxColumn.Visible = False
        '
        'Registro_control_tramitesBindingSource
        '
        Me.Registro_control_tramitesBindingSource.DataMember = "registro_control_tramites"
        Me.Registro_control_tramitesBindingSource.DataSource = Me.Registro_control_tramites
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(921, 560)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(79, 26)
        Me.btnEliminar.TabIndex = 16
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(190, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "DELEGACIÓN FEDERAL HIDALGO"
        '
        'dtFechaControl
        '
        Me.dtFechaControl.CustomFormat = "yyyy"
        Me.dtFechaControl.Enabled = False
        Me.dtFechaControl.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFechaControl.Location = New System.Drawing.Point(532, 42)
        Me.dtFechaControl.Name = "dtFechaControl"
        Me.dtFechaControl.Size = New System.Drawing.Size(44, 20)
        Me.dtFechaControl.TabIndex = 17
        Me.dtFechaControl.Visible = False
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(453, 74)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(51, 15)
        Me.lblFecha.TabIndex = 11
        Me.lblFecha.Text = "FECHA"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.nacionalidadTableAdapter = Nothing
        Me.TableAdapterManager.nombre_empleadoTableAdapter = Nothing
        Me.TableAdapterManager.registro_control_tramitesTableAdapter = Me.Registro_control_tramitesTableAdapter
        Me.TableAdapterManager.tipo_statusTableAdapter = Nothing
        Me.TableAdapterManager.tramite_solicitadoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = control_de_tramites.registro_control_tramitesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Registro_control_tramitesTableAdapter
        '
        Me.Registro_control_tramitesTableAdapter.ClearBeforeFill = True
        '
        'Registro_control_tramites1
        '
        Me.Registro_control_tramites1.DataSetName = "registro_control_tramites"
        Me.Registro_control_tramites1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tramite_solicitadoTableAdapter
        '
        Me.Tramite_solicitadoTableAdapter.ClearBeforeFill = True
        '
        'Tipo_statusTableAdapter
        '
        Me.Tipo_statusTableAdapter.ClearBeforeFill = True
        '
        'Nombre_empleadoTableAdapter
        '
        Me.Nombre_empleadoTableAdapter.ClearBeforeFill = True
        '
        'NacionalidadTableAdapter
        '
        Me.NacionalidadTableAdapter.ClearBeforeFill = True
        '
        'actualizar
        '
        Me.actualizar.Location = New System.Drawing.Point(638, 76)
        Me.actualizar.Name = "actualizar"
        Me.actualizar.Size = New System.Drawing.Size(351, 23)
        Me.actualizar.TabIndex = 18
        Me.actualizar.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(45, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(146, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'RegistrocontroltramitesBindingSource
        '
        Me.RegistrocontroltramitesBindingSource.DataSource = Me.Registro_control_tramites
        Me.RegistrocontroltramitesBindingSource.Position = 0
        '
        'NombreempleadoBindingSource1
        '
        Me.NombreempleadoBindingSource1.DataMember = "nombre_empleado"
        Me.NombreempleadoBindingSource1.DataSource = Me.Registro_control_tramites
        '
        'registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1049, 608)
        Me.Controls.Add(Me.actualizar)
        Me.Controls.Add(Me.dtFechaControl)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtIdControlGuardar)
        Me.Controls.Add(Me.txtIdControl)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Registro_control_tramitesDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(2000, 1200)
        Me.Name = "registro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de Tramites"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.NacionalidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Registro_control_tramites, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TramitesolicitadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.NombreempleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipostatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Registro_control_tramitesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Registro_control_tramitesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Registro_control_tramites1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrocontroltramitesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NombreempleadoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFechaIngreso As System.Windows.Forms.Label
    Friend WithEvents lblNut As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblNacionalidad As System.Windows.Forms.Label
    Friend WithEvents lblDocumentoRecibido As System.Windows.Forms.Label
    Friend WithEvents lblTramiteSolicitado As System.Windows.Forms.Label
    Friend WithEvents lblResidente As System.Windows.Forms.Label
    Friend WithEvents lblActividad As System.Windows.Forms.Label
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents lblFechadeNacimiento As System.Windows.Forms.Label
    Friend WithEvents lblEdad As System.Windows.Forms.Label
    Friend WithEvents lblPersonaAutorizada As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblRecibidoPor As System.Windows.Forms.Label
    Friend WithEvents lblLoResuelve As System.Windows.Forms.Label
    Friend WithEvents lblAlcance1 As System.Windows.Forms.Label
    Friend WithEvents lblDocumentoEntregado As System.Windows.Forms.Label
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents lblCalle As System.Windows.Forms.Label
    Friend WithEvents lblColonia As System.Windows.Forms.Label
    Friend WithEvents lblMunicipio As System.Windows.Forms.Label
    Friend WithEvents lblCP As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lblCorreoElectronico As System.Windows.Forms.Label
    Friend WithEvents lblEmpresaServicio As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtActividad As System.Windows.Forms.TextBox
    Friend WithEvents txtDocumentoRecibido As System.Windows.Forms.TextBox
    Friend WithEvents cbxNacionalidad As System.Windows.Forms.ComboBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtNut As System.Windows.Forms.TextBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents txtDocumentoEntregado As System.Windows.Forms.TextBox
    Friend WithEvents txtAlcance As System.Windows.Forms.TextBox
    Friend WithEvents cbxLoResuelve As System.Windows.Forms.ComboBox
    Friend WithEvents cbxRecibidoPor As System.Windows.Forms.ComboBox
    Friend WithEvents cbxResidente As System.Windows.Forms.ComboBox
    Friend WithEvents cbxStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtPersonaAutorizada As System.Windows.Forms.TextBox
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents cbxSexo As System.Windows.Forms.ComboBox
    Friend WithEvents dtFechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpresaServicio As System.Windows.Forms.TextBox
    Friend WithEvents txtCorreoElectronico As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents txtMunicipio As System.Windows.Forms.ComboBox
    Friend WithEvents txtColonia As System.Windows.Forms.TextBox
    Friend WithEvents Registro_control_tramites As control_de_tramites.registro_control_tramites
    Friend WithEvents TableAdapterManager As control_de_tramites.registro_control_tramitesTableAdapters.TableAdapterManager
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents txtIdControl As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtIdControlGuardar As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents cbxTramiteSolicitado As System.Windows.Forms.ComboBox
    Friend WithEvents btnReporte As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BusrcarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeneficiarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PendienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OperacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LimpiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlDeTramitesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtNombreSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreSearch As System.Windows.Forms.Label
    Friend WithEvents Registro_control_tramitesTableAdapter As control_de_tramites.registro_control_tramitesTableAdapters.registro_control_tramitesTableAdapter
    Friend WithEvents Registro_control_tramitesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Registro_control_tramitesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents id_control_tramite As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_ingreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nacionalidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents documento_recibido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tramite_solicitado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents residente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actividad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sexo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_nacimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents edad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents persona_autorizada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents recibido_por As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lo_resuelve As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents alcance_1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents calle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colonia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents municipio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents correo_electronico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empresa_servicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents documento_entregado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdcontroltramiteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaingresoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NacionalidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocumentorecibidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TramitesolicitadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResidenteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActividadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechanacimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EdadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PersonaautorizadaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecibidoporDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoresuelveDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Alcance1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColoniaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MunicipioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CorreoelectronicoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpresaservicioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocumentoentregadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtFechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents ControlDeTramitesPorMesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtFechaControl As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesarrolladorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SincronizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotificacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PendientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Registro_control_tramites1 As control_de_tramites.registro_control_tramites
    Friend WithEvents NacionalidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TramiteSolicitadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NacionalidadToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TramitesolicitadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tramite_solicitadoTableAdapter As control_de_tramites.registro_control_tramitesTableAdapters.tramite_solicitadoTableAdapter
    Friend WithEvents TipostatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tipo_statusTableAdapter As control_de_tramites.registro_control_tramitesTableAdapters.tipo_statusTableAdapter
    Friend WithEvents NombreempleadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Nombre_empleadoTableAdapter As control_de_tramites.registro_control_tramitesTableAdapters.nombre_empleadoTableAdapter
    Friend WithEvents NacionalidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NacionalidadTableAdapter As control_de_tramites.registro_control_tramitesTableAdapters.nacionalidadTableAdapter
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NacionalidadToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TramiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents actualizar As System.Windows.Forms.ProgressBar
    Friend WithEvents NombreempleadoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents RegistrocontroltramitesBindingSource As System.Windows.Forms.BindingSource



End Class
