Public Class pendientes_form

    Private Sub pendientes_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Registro_control_tramites._registro_control_tramites' Puede moverla o quitarla según sea necesario.
        Me.Registro_control_tramitesTableAdapter.notifacion_23dias(Me.Registro_control_tramites._registro_control_tramites)

    End Sub
End Class