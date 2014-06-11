Public Class status_form

    Private Sub Registro_control_tramitesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Registro_control_tramitesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Registro_control_tramites)

    End Sub

    Private Sub status_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Registro_control_tramites._registro_control_tramites' Puede moverla o quitarla según sea necesario.
        Me.Registro_control_tramitesTableAdapter.Fill(Me.Registro_control_tramites._registro_control_tramites)

    End Sub

    Private Sub cbxStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxStatus.SelectedIndexChanged
        Me.Registro_control_tramitesTableAdapter.Fill(Me.Registro_control_tramites._registro_control_tramites)

        Try
            Me.Registro_control_tramitesTableAdapter.consultaStatus(Me.Registro_control_tramites._registro_control_tramites, cbxStatus.Text & "%")

        Catch ex As Exception

        End Try
    End Sub
End Class