Public Class agregar_nacionalidad

    Private Sub NacionalidadBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles NacionalidadBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.NacionalidadBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Registro_control_tramites)
        Catch ex As Exception
            MessageBox.Show("Usted no cuenta con este permiso", "Error")
        End Try
    End Sub

    Private Sub agregar_nacionalidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Registro_control_tramites.nacionalidad' Puede moverla o quitarla según sea necesario.
        Me.NacionalidadTableAdapter.Fill(Me.Registro_control_tramites.nacionalidad)

    End Sub
End Class