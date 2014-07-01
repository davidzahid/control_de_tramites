<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregar_nacionalidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(agregar_nacionalidad))
        Me.Registro_control_tramites = New control_de_tramites.registro_control_tramites()
        Me.NacionalidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NacionalidadTableAdapter = New control_de_tramites.registro_control_tramitesTableAdapters.nacionalidadTableAdapter()
        Me.TableAdapterManager = New control_de_tramites.registro_control_tramitesTableAdapters.TableAdapterManager()
        Me.NacionalidadBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NacionalidadDataGridView = New System.Windows.Forms.DataGridView()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.NacionalidadBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Registro_control_tramites, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NacionalidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NacionalidadBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NacionalidadBindingNavigator.SuspendLayout()
        CType(Me.NacionalidadDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Registro_control_tramites
        '
        Me.Registro_control_tramites.DataSetName = "registro_control_tramites"
        Me.Registro_control_tramites.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.nacionalidadTableAdapter = Me.NacionalidadTableAdapter
        Me.TableAdapterManager.nombre_empleadoTableAdapter = Nothing
        Me.TableAdapterManager.registro_control_tramitesTableAdapter = Nothing
        Me.TableAdapterManager.tipo_statusTableAdapter = Nothing
        Me.TableAdapterManager.tramite_solicitadoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = control_de_tramites.registro_control_tramitesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NacionalidadBindingNavigator
        '
        Me.NacionalidadBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.NacionalidadBindingNavigator.BindingSource = Me.NacionalidadBindingSource
        Me.NacionalidadBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.NacionalidadBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.NacionalidadBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.NacionalidadBindingNavigatorSaveItem})
        Me.NacionalidadBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.NacionalidadBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.NacionalidadBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.NacionalidadBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.NacionalidadBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.NacionalidadBindingNavigator.Name = "NacionalidadBindingNavigator"
        Me.NacionalidadBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.NacionalidadBindingNavigator.Size = New System.Drawing.Size(322, 25)
        Me.NacionalidadBindingNavigator.TabIndex = 0
        Me.NacionalidadBindingNavigator.Text = "BindingNavigator1"
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
        'NacionalidadDataGridView
        '
        Me.NacionalidadDataGridView.AutoGenerateColumns = False
        Me.NacionalidadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NacionalidadDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.NacionalidadDataGridView.DataSource = Me.NacionalidadBindingSource
        Me.NacionalidadDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.NacionalidadDataGridView.Name = "NacionalidadDataGridView"
        Me.NacionalidadDataGridView.Size = New System.Drawing.Size(298, 326)
        Me.NacionalidadDataGridView.TabIndex = 1
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
        'NacionalidadBindingNavigatorSaveItem
        '
        Me.NacionalidadBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NacionalidadBindingNavigatorSaveItem.Image = CType(resources.GetObject("NacionalidadBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.NacionalidadBindingNavigatorSaveItem.Name = "NacionalidadBindingNavigatorSaveItem"
        Me.NacionalidadBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.NacionalidadBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nacionalidad"
        Me.DataGridViewTextBoxColumn2.FillWeight = 250.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "NACIONALIDAD"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'agregar_nacionalidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 366)
        Me.Controls.Add(Me.NacionalidadDataGridView)
        Me.Controls.Add(Me.NacionalidadBindingNavigator)
        Me.MaximumSize = New System.Drawing.Size(338, 405)
        Me.Name = "agregar_nacionalidad"
        Me.Text = "Nueva Nacionalidad"
        CType(Me.Registro_control_tramites, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NacionalidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NacionalidadBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NacionalidadBindingNavigator.ResumeLayout(False)
        Me.NacionalidadBindingNavigator.PerformLayout()
        CType(Me.NacionalidadDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Registro_control_tramites As control_de_tramites.registro_control_tramites
    Friend WithEvents NacionalidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NacionalidadTableAdapter As control_de_tramites.registro_control_tramitesTableAdapters.nacionalidadTableAdapter
    Friend WithEvents TableAdapterManager As control_de_tramites.registro_control_tramitesTableAdapters.TableAdapterManager
    Friend WithEvents NacionalidadBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents NacionalidadBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NacionalidadDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
