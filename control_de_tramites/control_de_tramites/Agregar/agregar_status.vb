Public Class agregar_status

    Private Sub Tipo_statusBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tipo_statusBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tipo_statusBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Registro_control_tramites)
        Catch ex As Exception
            MessageBox.Show("Usted no cuenta con este permiso", "Error")
        End Try

    End Sub

    Private Sub agregar_status_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Registro_control_tramites.tipo_status' Puede moverla o quitarla según sea necesario.
        Me.Tipo_statusTableAdapter.Fill(Me.Registro_control_tramites.tipo_status)

    End Sub
End Class