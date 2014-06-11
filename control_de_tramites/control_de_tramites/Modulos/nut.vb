Public Class nut_form

    Private Sub Registro_control_tramitesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Registro_control_tramitesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Registro_control_tramites)

    End Sub

    Private Sub nut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Registro_control_tramites._registro_control_tramites' Puede moverla o quitarla según sea necesario.
        Me.Registro_control_tramitesTableAdapter.Fill(Me.Registro_control_tramites._registro_control_tramites)

    End Sub

    Private Sub txtNut_TextChanged(sender As Object, e As EventArgs) Handles txtNut.TextChanged
        Me.Registro_control_tramitesTableAdapter.Fill(Me.Registro_control_tramites._registro_control_tramites)

        Try
            Me.Registro_control_tramitesTableAdapter.consultaNut(Me.Registro_control_tramites._registro_control_tramites, txtNut.Text & "%")

        Catch ex As Exception

        End Try
    End Sub
End Class