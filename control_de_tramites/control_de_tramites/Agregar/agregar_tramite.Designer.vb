<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregar_tramite
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(agregar_tramite))
        Me.Registro_control_tramites = New control_de_tramites.registro_control_tramites()
        Me.Tramite_solicitadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tramite_solicitadoTableAdapter = New control_de_tramites.registro_control_tramitesTableAdapters.tramite_solicitadoTableAdapter()
        Me.TableAdapterManager = New control_de_tramites.registro_control_tramitesTableAdapters.TableAdapterManager()
        Me.Tramite_solicitadoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tramite_solicitadoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.Tramite_solicitadoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        CType(Me.Registro_control_tramites, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tramite_solicitadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tramite_solicitadoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tramite_solicitadoBindingNavigator.SuspendLayout()
        CType(Me.Tramite_solicitadoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Registro_control_tramites
        '
        Me.Registro_control_tramites.DataSetName = "registro_control_tramites"
        Me.Registro_control_tramites.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tramite_solicitadoBindingSource
        '
        Me.Tramite_solicitadoBindingSource.DataMember = "tramite_solicitado"
        Me.Tramite_solicitadoBindingSource.DataSource = Me.Registro_control_tramites
        '
        'Tramite_solicitadoTableAdapter
        '
        Me.Tramite_solicitadoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.nacionalidadTableAdapter = Nothing
        Me.TableAdapterManager.nombre_empleadoTableAdapter = Nothing
        Me.TableAdapterManager.registro_control_tramitesTableAdapter = Nothing
        Me.TableAdapterManager.tipo_statusTableAdapter = Nothing
        Me.TableAdapterManager.tramite_solicitadoTableAdapter = Me.Tramite_solicitadoTableAdapter
        Me.TableAdapterManager.UpdateOrder = control_de_tramites.registro_control_tramitesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tramite_solicitadoBindingNavigator
        '
        Me.Tramite_solicitadoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tramite_solicitadoBindingNavigator.BindingSource = Me.Tramite_solicitadoBindingSource
        Me.Tramite_solicitadoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tramite_solicitadoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tramite_solicitadoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tramite_solicitadoBindingNavigatorSaveItem})
        Me.Tramite_solicitadoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tramite_solicitadoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tramite_solicitadoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tramite_solicitadoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tramite_solicitadoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tramite_solicitadoBindingNavigator.Name = "Tramite_solicitadoBindingNavigator"
        Me.Tramite_solicitadoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tramite_solicitadoBindingNavigator.Size = New System.Drawing.Size(871, 25)
        Me.Tramite_solicitadoBindingNavigator.TabIndex = 0
        Me.Tramite_solicitadoBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tramite_solicitadoDataGridView
        '
        Me.Tramite_solicitadoDataGridView.AutoGenerateColumns = False
        Me.Tramite_solicitadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tramite_solicitadoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.Tramite_solicitadoDataGridView.DataSource = Me.Tramite_solicitadoBindingSource
        Me.Tramite_solicitadoDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.Tramite_solicitadoDataGridView.Name = "Tramite_solicitadoDataGridView"
        Me.Tramite_solicitadoDataGridView.Size = New System.Drawing.Size(843, 241)
        Me.Tramite_solicitadoDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tramite_solicitado"
        Me.DataGridViewTextBoxColumn2.FillWeight = 800.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "TRAMITE SOLICITADO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 800
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'Tramite_solicitadoBindingNavigatorSaveItem
        '
        Me.Tramite_solicitadoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tramite_solicitadoBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tramite_solicitadoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tramite_solicitadoBindingNavigatorSaveItem.Name = "Tramite_solicitadoBindingNavigatorSaveItem"
        Me.Tramite_solicitadoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tramite_solicitadoBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'agregar_tramite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 273)
        Me.Controls.Add(Me.Tramite_solicitadoDataGridView)
        Me.Controls.Add(Me.Tramite_solicitadoBindingNavigator)
        Me.MaximumSize = New System.Drawing.Size(887, 312)
        Me.Name = "agregar_tramite"
        Me.Text = "Nuevo Tramite"
        CType(Me.Registro_control_tramites, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tramite_solicitadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tramite_solicitadoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tramite_solicitadoBindingNavigator.ResumeLayout(False)
        Me.Tramite_solicitadoBindingNavigator.PerformLayout()
        CType(Me.Tramite_solicitadoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Registro_control_tramites As control_de_tramites.registro_control_tramites
    Friend WithEvents Tramite_solicitadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tramite_solicitadoTableAdapter As control_de_tramites.registro_control_tramitesTableAdapters.tramite_solicitadoTableAdapter
    Friend WithEvents TableAdapterManager As control_de_tramites.registro_control_tramitesTableAdapters.TableAdapterManager
    Friend WithEvents Tramite_solicitadoBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tramite_solicitadoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tramite_solicitadoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
