Public Class buscar_form

    Private Sub buscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Registro_control_tramites._registro_control_tramites' Puede moverla o quitarla según sea necesario.
        Me.Registro_control_tramitesTableAdapter.Fill(Me.Registro_control_tramites._registro_control_tramites)
        'TODO: esta línea de código carga datos en la tabla 'Registro_control_tramites._registro_control_tramites' Puede moverla o quitarla según sea necesario.
        Me.Registro_control_tramitesTableAdapter.Fill(Me.Registro_control_tramites._registro_control_tramites)

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Me.Registro_control_tramitesTableAdapter.Fill(Me.Registro_control_tramites._registro_control_tramites)

        Try
            Me.Registro_control_tramitesTableAdapter.consulta(Me.Registro_control_tramites._registro_control_tramites, txtBuscar.Text & "%")

        Catch ex As Exception

        End Try
    End Sub



    Private Sub Registro_control_tramitesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Registro_control_tramitesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Registro_control_tramites)

    End Sub



    Private Sub Registro_control_tramitesDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Registro_control_tramitesDataGridView.CellClick
        Try
            registro.dtFechaIngreso().Text = ""
            registro.txtNut().Text = ""
            registro.txtNombre().Text = ""
            registro.cbxNacionalidad().Text = ""
            registro.txtDocumentoRecibido().Text = ""
            registro.cbxTramiteSolicitado().Text = ""
            registro.cbxResidente().Text = ""
            registro.txtActividad().Text = ""
            registro.cbxSexo().Text = ""
            registro.dtFechaNacimiento().Text = ""
            registro.txtEdad().Clear()
            registro.txtPersonaAutorizada().Clear()
            registro.cbxStatus.Text = ""
            registro.cbxRecibidoPor.Text = ""
            registro.cbxLoResuelve.Text = ""
            registro.txtAlcance().Clear()
            registro.txtObservaciones().Clear()
            registro.txtCalle().Clear()
            registro.txtColonia().Clear()
            registro.txtMunicipio.Text = ""
            registro.txtCP().Clear()
            registro.txtTelefono().Clear()
            registro.txtCorreoElectronico().Clear()
            registro.txtEmpresaServicio().Clear()
            registro.txtDocumentoEntregado().Clear()
            registro.txtIdControl().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(0).Value()
            registro.dtFechaIngreso().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(1).Value()
            registro.txtNut().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(2).Value()
            registro.txtNombre().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(3).Value()
            registro.cbxNacionalidad().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(4).Value()
            registro.txtDocumentoRecibido().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(5).Value()
            registro.cbxTramiteSolicitado().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(6).Value()
            registro.cbxResidente().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(7).Value()
            registro.txtActividad().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(8).Value()
            registro.cbxSexo().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(9).Value()
            registro.dtFechaNacimiento().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(10).Value()
            registro.txtEdad().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(11).Value()
            registro.txtPersonaAutorizada().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(12).Value()
            registro.cbxStatus().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(13).Value()
            registro.cbxRecibidoPor().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(14).Value()
            registro.cbxLoResuelve().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(15).Value()
            registro.txtAlcance().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(16).Value()
            registro.txtObservaciones().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(17).Value()
            registro.txtCalle().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(18).Value()
            registro.txtColonia().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(19).Value()
            registro.txtMunicipio().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(20).Value()
            registro.txtCP().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(21).Value()
            registro.txtTelefono().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(22).Value()
            registro.txtCorreoElectronico().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(23).Value()
            registro.txtEmpresaServicio().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(24).Value()
            registro.txtDocumentoEntregado().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(25).Value()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Registro_control_tramitesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Registro_control_tramitesDataGridView.CellContentClick

    End Sub
End Class