Public Class agregar_tramite

    Private Sub Tramite_solicitadoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tramite_solicitadoBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tramite_solicitadoBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Registro_control_tramites)
        Catch ex As Exception
            MessageBox.Show("Usted no cuenta con este permiso", "Error")
        End Try
    End Sub

    Private Sub agregar_tramite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Registro_control_tramites.tramite_solicitado' Puede moverla o quitarla según sea necesario.
        Me.Tramite_solicitadoTableAdapter.Fill(Me.Registro_control_tramites.tramite_solicitado)

    End Sub
End Class