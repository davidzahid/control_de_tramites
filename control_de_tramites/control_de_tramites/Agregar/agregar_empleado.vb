Public Class agregar_empleado

    Private Sub Nombre_empleadoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Nombre_empleadoBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Nombre_empleadoBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Registro_control_tramites)
        Catch ex As Exception
            MessageBox.Show("Usted no cuenta con este permiso", "Error")
        End Try


    End Sub

    Private Sub agregar_empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Registro_control_tramites.nombre_empleado' Puede moverla o quitarla según sea necesario.
        Me.Nombre_empleadoTableAdapter.Fill(Me.Registro_control_tramites.nombre_empleado)

    End Sub
End Class