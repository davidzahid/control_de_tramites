<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregar_status
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(agregar_status))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Registro_control_tramites = New control_de_tramites.registro_control_tramites()
        Me.Tipo_statusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tipo_statusTableAdapter = New control_de_tramites.registro_control_tramitesTableAdapters.tipo_statusTableAdapter()
        Me.TableAdapterManager = New control_de_tramites.registro_control_tramitesTableAdapters.TableAdapterManager()
        Me.Tipo_statusBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Tipo_statusBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tipo_statusDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Registro_control_tramites, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tipo_statusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tipo_statusBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tipo_statusBindingNavigator.SuspendLayout()
        CType(Me.Tipo_statusDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Registro_control_tramites
        '
        Me.Registro_control_tramites.DataSetName = "registro_control_tramites"
        Me.Registro_control_tramites.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tipo_statusBindingSource
        '
        Me.Tipo_statusBindingSource.DataMember = "tipo_status"
        Me.Tipo_statusBindingSource.DataSource = Me.Registro_control_tramites
        '
        'Tipo_statusTableAdapter
        '
        Me.Tipo_statusTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.nacionalidadTableAdapter = Nothing
        Me.TableAdapterManager.nombre_empleadoTableAdapter = Nothing
        Me.TableAdapterManager.registro_control_tramitesTableAdapter = Nothing
        Me.TableAdapterManager.tipo_statusTableAdapter = Me.Tipo_statusTableAdapter
        Me.TableAdapterManager.tramite_solicitadoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = control_de_tramites.registro_control_tramitesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tipo_statusBindingNavigator
        '
        Me.Tipo_statusBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tipo_statusBindingNavigator.BindingSource = Me.Tipo_statusBindingSource
        Me.Tipo_statusBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tipo_statusBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tipo_statusBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tipo_statusBindingNavigatorSaveItem})
        Me.Tipo_statusBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tipo_statusBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tipo_statusBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tipo_statusBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tipo_statusBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tipo_statusBindingNavigator.Name = "Tipo_statusBindingNavigator"
        Me.Tipo_statusBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tipo_statusBindingNavigator.Size = New System.Drawing.Size(322, 25)
        Me.Tipo_statusBindingNavigator.TabIndex = 0
        Me.Tipo_statusBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'Tipo_statusBindingNavigatorSaveItem
        '
        Me.Tipo_statusBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tipo_statusBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tipo_statusBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tipo_statusBindingNavigatorSaveItem.Name = "Tipo_statusBindingNavigatorSaveItem"
        Me.Tipo_statusBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tipo_statusBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Tipo_statusDataGridView
        '
        Me.Tipo_statusDataGridView.AutoGenerateColumns = False
        Me.Tipo_statusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tipo_statusDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.Tipo_statusDataGridView.DataSource = Me.Tipo_statusBindingSource
        Me.Tipo_statusDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.Tipo_statusDataGridView.Name = "Tipo_statusDataGridView"
        Me.Tipo_statusDataGridView.Size = New System.Drawing.Size(298, 326)
        Me.Tipo_statusDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tipo_status"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.FillWeight = 250.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "TIPO DE STATUS"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'agregar_status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 366)
        Me.Controls.Add(Me.Tipo_statusDataGridView)
        Me.Controls.Add(Me.Tipo_statusBindingNavigator)
        Me.MaximumSize = New System.Drawing.Size(338, 405)
        Me.Name = "agregar_status"
        Me.Text = "Nuevo Status"
        CType(Me.Registro_control_tramites, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tipo_statusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tipo_statusBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tipo_statusBindingNavigator.ResumeLayout(False)
        Me.Tipo_statusBindingNavigator.PerformLayout()
        CType(Me.Tipo_statusDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Registro_control_tramites As control_de_tramites.registro_control_tramites
    Friend WithEvents Tipo_statusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tipo_statusTableAdapter As control_de_tramites.registro_control_tramitesTableAdapters.tipo_statusTableAdapter
    Friend WithEvents TableAdapterManager As control_de_tramites.registro_control_tramitesTableAdapters.TableAdapterManager
    Friend WithEvents Tipo_statusBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tipo_statusBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tipo_statusDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
