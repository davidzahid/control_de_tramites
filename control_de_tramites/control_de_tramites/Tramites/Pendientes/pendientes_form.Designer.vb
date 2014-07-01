<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pendientes_form
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RegistrocontroltramitesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Registro_control_tramites = New control_de_tramites.registro_control_tramites()
        Me.Registro_control_tramitesTableAdapter = New control_de_tramites.registro_control_tramitesTableAdapters.registro_control_tramitesTableAdapter()
        Me.FechaingresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.recibido_por = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lo_resuelve = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrocontroltramitesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Registro_control_tramites, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaingresoDataGridViewTextBoxColumn, Me.NUTDataGridViewTextBoxColumn, Me.recibido_por, Me.lo_resuelve})
        Me.DataGridView1.DataSource = Me.RegistrocontroltramitesBindingSource
        Me.DataGridView1.GridColor = System.Drawing.Color.OrangeRed
        Me.DataGridView1.Location = New System.Drawing.Point(-1, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(754, 265)
        Me.DataGridView1.TabIndex = 0
        '
        'RegistrocontroltramitesBindingSource
        '
        Me.RegistrocontroltramitesBindingSource.DataMember = "registro_control_tramites"
        Me.RegistrocontroltramitesBindingSource.DataSource = Me.Registro_control_tramites
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
        'FechaingresoDataGridViewTextBoxColumn
        '
        Me.FechaingresoDataGridViewTextBoxColumn.DataPropertyName = "fecha_ingreso"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.FechaingresoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.FechaingresoDataGridViewTextBoxColumn.FillWeight = 160.0!
        Me.FechaingresoDataGridViewTextBoxColumn.HeaderText = "FECHA DE INGRESO"
        Me.FechaingresoDataGridViewTextBoxColumn.Name = "FechaingresoDataGridViewTextBoxColumn"
        Me.FechaingresoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaingresoDataGridViewTextBoxColumn.Width = 160
        '
        'NUTDataGridViewTextBoxColumn
        '
        Me.NUTDataGridViewTextBoxColumn.DataPropertyName = "NUT"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.NUTDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.NUTDataGridViewTextBoxColumn.HeaderText = "NUT"
        Me.NUTDataGridViewTextBoxColumn.Name = "NUTDataGridViewTextBoxColumn"
        Me.NUTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'recibido_por
        '
        Me.recibido_por.DataPropertyName = "recibido_por"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.recibido_por.DefaultCellStyle = DataGridViewCellStyle3
        Me.recibido_por.FillWeight = 225.0!
        Me.recibido_por.HeaderText = "RECIBIDO POR"
        Me.recibido_por.Name = "recibido_por"
        Me.recibido_por.ReadOnly = True
        Me.recibido_por.Width = 225
        '
        'lo_resuelve
        '
        Me.lo_resuelve.DataPropertyName = "lo_resuelve"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.lo_resuelve.DefaultCellStyle = DataGridViewCellStyle4
        Me.lo_resuelve.FillWeight = 225.0!
        Me.lo_resuelve.HeaderText = "LO RESUELVE"
        Me.lo_resuelve.Name = "lo_resuelve"
        Me.lo_resuelve.ReadOnly = True
        Me.lo_resuelve.Width = 225
        '
        'pendientes_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 271)
        Me.Controls.Add(Me.DataGridView1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "pendientes_form"
        Me.Text = "Tramites Pendientes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrocontroltramitesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Registro_control_tramites, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Registro_control_tramites As control_de_tramites.registro_control_tramites
    Friend WithEvents RegistrocontroltramitesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Registro_control_tramitesTableAdapter As control_de_tramites.registro_control_tramitesTableAdapters.registro_control_tramitesTableAdapter
    Friend WithEvents FechaingresoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents recibido_por As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lo_resuelve As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
