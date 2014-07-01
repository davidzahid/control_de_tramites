Imports System.IO
Public Class registro

    Dim Diferencia As TimeSpan
    Dim contador As Integer


    'LICENCIADO EN SISTEMAS COMPUTACIONALES
    'AUTOR DAVID ZAHID JIMENEZ GREZ
    'CONTACTO@ZAHID.MX
    'WWW.ZAHID.MX

    Private Sub Registro_control_tramitesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Registro_control_tramitesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Registro_control_tramites)
    End Sub

    Private Sub registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'ACCION DE ACTUALIZAR '

        actualizar.Minimum = 0
        actualizar.Maximum = 5
        actualizar.Value = 0


        'TERMINA ACCIÓN ACTUALIZAR'
        'TODO: esta línea de código carga datos en la tabla 'Registro_control_tramites.nacionalidad' Puede moverla o quitarla según sea necesario.
        Me.NacionalidadTableAdapter.Fill(Me.Registro_control_tramites.nacionalidad)
        'TODO: esta línea de código carga datos en la tabla 'Registro_control_tramites.nombre_empleado' Puede moverla o quitarla según sea necesario.
        Me.Nombre_empleadoTableAdapter.Fill(Me.Registro_control_tramites.nombre_empleado)
        'TODO: esta línea de código carga datos en la tabla 'Registro_control_tramites.tipo_status' Puede moverla o quitarla según sea necesario.
        Me.Tipo_statusTableAdapter.Fill(Me.Registro_control_tramites.tipo_status)
        'TODO: esta línea de código carga datos en la tabla 'Registro_control_tramites.tramite_solicitado' Puede moverla o quitarla según sea necesario.
        Me.Tramite_solicitadoTableAdapter.Fill(Me.Registro_control_tramites.tramite_solicitado)
        'SE ASIGNA LA FECHA AL ENCABEZADO DEL SISTEMA'
        lblFecha.Text = dtFechaControl.Value.Year
        'TODO: esta línea de código carga datos en la tabla 'Registro_control_tramites._registro_control_tramites' Puede moverla o quitarla según sea necesario.
        Me.Registro_control_tramitesTableAdapter.Fill(Me.Registro_control_tramites._registro_control_tramites)

    End Sub

    Private Sub Registro_control_tramitesBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Registro_control_tramitesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Registro_control_tramites)
    End Sub

    Private Sub Registro_control_tramitesBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs)

        Me.Validate()
        Me.Registro_control_tramitesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Registro_control_tramites)

    End Sub

    Private Sub Registro_control_tramitesDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Registro_control_tramitesDataGridView.CellClick
        Try
            dtFechaIngreso().Text = ""
            txtNut().Text = ""
            txtNombre().Text = ""
            cbxNacionalidad().Text = ""
            txtDocumentoRecibido().Text = ""
            cbxTramiteSolicitado().Text = ""
            cbxResidente().Text = ""
            txtActividad().Text = ""
            cbxSexo().Text = ""
            dtFechaNacimiento().Text = ""
            txtEdad().Clear()
            txtPersonaAutorizada().Clear()
            cbxStatus.Text = ""
            cbxRecibidoPor.Text = ""
            cbxLoResuelve.Text = ""
            txtAlcance().Clear()
            txtObservaciones().Clear()
            txtCalle().Clear()
            txtColonia().Clear()
            txtMunicipio.Text = ""
            txtCP().Clear()
            txtTelefono().Clear()
            txtCorreoElectronico().Clear()
            txtEmpresaServicio().Clear()
            txtDocumentoEntregado().Clear()
            txtIdControl().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(0).Value()
            dtFechaIngreso().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(1).Value()
            txtNut().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(2).Value()
            txtNombre().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(3).Value()
            cbxNacionalidad().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(4).Value()
            txtDocumentoRecibido().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(5).Value()
            cbxTramiteSolicitado().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(6).Value()
            cbxResidente().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(7).Value()
            txtActividad().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(8).Value()
            cbxSexo().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(9).Value()
            dtFechaNacimiento().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(10).Value()
            txtEdad().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(11).Value()
            txtPersonaAutorizada().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(12).Value()
            cbxStatus().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(13).Value()
            cbxRecibidoPor().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(14).Value()
            cbxLoResuelve().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(15).Value()
            txtAlcance().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(16).Value()
            txtObservaciones().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(17).Value()
            txtCalle().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(18).Value()
            txtColonia().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(19).Value()
            txtMunicipio().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(20).Value()
            txtCP().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(21).Value()
            txtTelefono().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(22).Value()
            txtCorreoElectronico().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(23).Value()
            txtEmpresaServicio().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(24).Value()
            txtDocumentoEntregado().Text = Me.Registro_control_tramitesDataGridView.Rows(e.RowIndex).Cells(25).Value()
        Catch ex As Exception
        End Try

    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click, ActualizarToolStripMenuItem.Click
        Try

            'BOTON PARA ACTUALIZAR REGISTRO
            Me.Registro_control_tramitesTableAdapter.actualizar_registro(txtNut.Text, txtNombre.Text, cbxNacionalidad.Text, txtDocumentoRecibido.Text, cbxTramiteSolicitado.Text, cbxResidente.Text, txtActividad.Text, cbxSexo.Text, dtFechaNacimiento.Text, txtEdad.Text, txtPersonaAutorizada.Text, cbxStatus.Text, cbxRecibidoPor.Text, cbxLoResuelve.Text, txtAlcance.Text, txtObservaciones.Text, txtCalle.Text, txtColonia.Text, txtMunicipio.Text, txtCP.Text, txtTelefono.Text, txtCorreoElectronico.Text, txtEmpresaServicio.Text, txtDocumentoEntregado.Text, txtIdControl.Text)
            Me.Registro_control_tramitesTableAdapter.Fill(Me.Registro_control_tramites._registro_control_tramites)
            MessageBox.Show("Actualizado Correctamente")
        Catch ex As Exception
            MessageBox.Show("Imposible Actualizar")
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click, GuardarToolStripMenuItem.Click
        Try
            'BOTON PARA GUARDAR REGISTRO
            ' If (txtNut.Text = "" Or txtNombre.Text = "" Or cbxNacionalidad.Text = "" Or txtDocumentoRecibido.Text = "" Or cbxTramiteSolicitado.Text = "" Or cbxResidente.Text = "" Or txtActividad.Text = "" Or cbxSexo.Text = "" Or dtFechaNacimiento.Text = "" Or txtEdad.Text = "" Or txtPersonaAutorizada.Text = "" Or cbxStatus.Text = "" Or cbxRecibidoPor.Text = "" Or cbxLoResuelve.Text = "" Or txtAlcance.Text = "" Or txtObservaciones.Text = "" Or txtCalle.Text = "" Or txtColonia.Text = "" Or txtMunicipio.Text = "" Or txtCP.Text = "" Or txtTelefono.Text = "" Or txtCorreoElectronico.Text = "" Or txtEmpresaServicio.Text = "") Then
            ' End If

            'GENERAR ID'
            txtIdControlGuardar.Text = Val(Me.Registro_control_tramitesTableAdapter.identificador())
            If txtIdControlGuardar.Text = "" Then
                txtIdControlGuardar.Text = 0
            End If
            txtIdControlGuardar.Text = txtIdControlGuardar.Text + 1

            If (txtEdad.Text = "") Then
                txtEdad.Text = 0
            End If


            Me.Registro_control_tramitesTableAdapter.guardar_registro(dtFechaIngreso.Text, txtNut.Text, txtNombre.Text, cbxNacionalidad.Text, txtDocumentoRecibido.Text, cbxTramiteSolicitado.Text, cbxResidente.Text, txtActividad.Text, cbxSexo.Text, dtFechaNacimiento.Text, txtEdad.Text, txtPersonaAutorizada.Text, cbxStatus.Text, cbxRecibidoPor.Text, cbxLoResuelve.Text, txtAlcance.Text, txtObservaciones.Text, txtCalle.Text, txtColonia.Text, txtMunicipio.Text, txtCP.Text, txtTelefono.Text, txtCorreoElectronico.Text, txtEmpresaServicio.Text, txtDocumentoEntregado.Text)
            Me.Registro_control_tramitesTableAdapter.Fill(Me.Registro_control_tramites._registro_control_tramites)
            MessageBox.Show("Guardado Correctamente")

        Catch ex As Exception
            MessageBox.Show("Imposible Guardar")
        End Try
    End Sub

    Private Sub dtFechaIngreso_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dtFechaNacimiento_TextChanged(sender As Object, e As EventArgs) Handles dtFechaNacimiento.TextChanged, dtFechaIngreso.TextChanged
        txtFecha.Text = dtFechaNacimiento.Text
    End Sub
    Private Sub txtFecha_TextChanged(sender As Object, e As EventArgs) Handles txtFecha.TextChanged
        'CON LA SIGUIENTE FUNCIÓN SE EXTRAE LA EDAD DEL BENEFICIARIO
        txtFecha.Text = dtFechaNacimiento.Text
        Dim fnac As Date = Convert.ToDateTime(txtFecha.Text)
        Diferencia = Today.Subtract(fnac)
        txtEdad.Text = Fix(Diferencia.TotalDays / 365.25)
        ' txtEdad.Text = Fix(Diferencia.TotalDays / 365.25)
        '***********************************************************'
    End Sub



    Private Sub Registro_control_tramitesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Registro_control_tramitesDataGridView.CellContentClick

        Registro_control_tramitesDataGridView.ClearSelection()
        Registro_control_tramitesDataGridView.Refresh()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click, LimpiarToolStripMenuItem.Click


        dtFechaIngreso().Text = ""
        txtNut().Text = ""
        txtNombre().Text = ""
        cbxNacionalidad().Text = ""
        txtDocumentoRecibido().Text = ""
        cbxTramiteSolicitado().Text = ""
        cbxResidente().Text = ""
        txtActividad().Text = ""
        cbxSexo().Text = ""
        dtFechaNacimiento().Text = ""
        txtEdad().Clear()
        txtPersonaAutorizada().Clear()
        cbxStatus.Text = ""
        cbxRecibidoPor.Text = ""
        cbxLoResuelve.Text = ""
        txtAlcance().Clear()
        txtObservaciones().Clear()
        txtCalle().Clear()
        txtColonia().Clear()
        txtMunicipio.Text = ""
        txtCP().Clear()
        txtTelefono().Clear()
        txtCorreoElectronico().Clear()
        txtEmpresaServicio().Clear()
        txtDocumentoEntregado().Clear()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click, BeneficiarioToolStripMenuItem.Click
        buscar_form.Show()



    End Sub



    Private Sub txtNut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNut.KeyPress
        Dim resultado As TextBox = DirectCast(sender, TextBox)
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCP.KeyPress
        Dim resultado As TextBox = DirectCast(sender, TextBox)
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        Dim resultado As TextBox = DirectCast(sender, TextBox)
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cbxSexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxSexo.KeyPress
        e.Handled = True
    End Sub


    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click, ControlDeTramitesToolStripMenuItem.Click
        reporte_general.Show()


    End Sub



    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()


    End Sub

    Private Sub NUTToolStripMenuItem_Click(sender As Object, e As EventArgs)
        nut_form.Show()

    End Sub

    Private Sub PendienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PendienteToolStripMenuItem.Click
        status_form.Show()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNombreSearch.TextChanged
        Me.Registro_control_tramitesTableAdapter.Fill(Me.Registro_control_tramites._registro_control_tramites)

        Try
            Me.Registro_control_tramitesTableAdapter.consulta(Me.Registro_control_tramites._registro_control_tramites, txtNombreSearch.Text & "%")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Registro_control_tramitesBindingNavigatorSaveItem_Click_3(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Registro_control_tramitesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Registro_control_tramites)

    End Sub

    Private Sub Registro_control_tramitesBindingNavigatorSaveItem_Click_4(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Registro_control_tramitesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Registro_control_tramites)

    End Sub

    Private Sub Registro_control_tramitesBindingNavigatorSaveItem_Click_5(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Registro_control_tramitesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Registro_control_tramites)

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click, EliminarToolStripMenuItem.Click
        Try

            If txtIdControl.Text = "" Then
                MessageBox.Show("SELECCIONE EL REGISTRO A ELIMINAR")
            Else
                Dim Mensaje, Estilo, Título, Respuesta, MiCadena
                Mensaje = "¿Esta seguro que desea eliminar este registro?"
                Estilo = vbYesNo + vbCritical
                Título = "ADVERTENCIA"
                Respuesta = MsgBox(Mensaje, Estilo, Título)
                If Respuesta = vbYes Then
                    MiCadena = "S"
                    Me.Registro_control_tramitesTableAdapter.eliminar_registro(txtIdControl.Text)
                    Me.Registro_control_tramitesTableAdapter.Fill(Me.Registro_control_tramites._registro_control_tramites)
                    txtIdControl.Text = ""
                Else
                    MiCadena = "No"
                    txtIdControl.Text = ""
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Imposible Eliminar")
        End Try
    End Sub


    Private Sub txtNut_TextChanged(sender As Object, e As EventArgs) Handles txtNut.TextChanged
        'GENERAR ID'
        txtIdControlGuardar.Text = Val(Me.Registro_control_tramitesTableAdapter.identificador())
        If txtIdControlGuardar.Text = "" Then
            txtIdControlGuardar.Text = 0
        End If
        txtIdControlGuardar.Text = txtIdControlGuardar.Text + 1
    End Sub

    Private Sub ControlDeTramitesPorMesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlDeTramitesPorMesToolStripMenuItem.Click
        reporte_mensual.Show()
    End Sub

    Private Sub AnioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnioToolStripMenuItem.Click
        reporte_anual.Show()

    End Sub


    Private Sub NUTToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles NUTToolStripMenuItem.Click

        nut_form.Show()


    End Sub




    Private Sub DesarrolladorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesarrolladorToolStripMenuItem.Click
        desarrollador.Show()

    End Sub

    Private Sub SincronizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SincronizarToolStripMenuItem.Click
        Try
            actualizar.Visible = True
            Me.Enabled = False
            Me.Refresh()
            actualizar.Value += 1
            'TODO: esta línea de código carga datos en la tabla 'Registro_control_tramites.nacionalidad' Puede moverla o quitarla según sea necesario.
            Me.NacionalidadTableAdapter.Fill(Me.Registro_control_tramites.nacionalidad)
            actualizar.Value += 1
            'TODO: esta línea de código carga datos en la tabla 'Registro_control_tramites.nombre_empleado' Puede moverla o quitarla según sea necesario.
            Me.Nombre_empleadoTableAdapter.Fill(Me.Registro_control_tramites.nombre_empleado)
            actualizar.Value += 1
            'TODO: esta línea de código carga datos en la tabla 'Registro_control_tramites.tipo_status' Puede moverla o quitarla según sea necesario.
            Me.Tipo_statusTableAdapter.Fill(Me.Registro_control_tramites.tipo_status)
            actualizar.Value += 1
            'TODO: esta línea de código carga datos en la tabla 'Registro_control_tramites.tramite_solicitado' Puede moverla o quitarla según sea necesario.
            Me.Tramite_solicitadoTableAdapter.Fill(Me.Registro_control_tramites.tramite_solicitado)
            actualizar.Value += 1
            'SE ASIGNA LA FECHA AL ENCABEZADO DEL SISTEMA'
            lblFecha.Text = dtFechaControl.Value.Year
            'TODO: esta línea de código carga datos en la tabla 'Registro_control_tramites._registro_control_tramites' Puede moverla o quitarla según sea necesario.
            Me.Registro_control_tramitesTableAdapter.Fill(Me.Registro_control_tramites._registro_control_tramites)



            If actualizar.Value = actualizar.Maximum Then MessageBox.Show("Actualizado correctamente", "Sistema")


            actualizar.Visible = False
            Me.Enabled = True
            actualizar.Value = 0
        Catch ex As Exception
            Me.Refresh()
            Me.Enabled = True
            actualizar.Visible = False
            MessageBox.Show("Imposible actualizar, intente nuevamente")
            actualizar.Value = 0

        End Try

    End Sub

    Private Sub DiarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiarioToolStripMenuItem.Click
        reporte_diario.Show()

    End Sub


    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        'CONVERTIR DE MINUSCULAS A MAYUSCULAS EN TIEMPO REAL
        Dim I As Integer
        txtNombre.Text = UCase(txtNombre.Text)
        I = Len(txtNombre.Text)
        txtNombre.SelectionStart = I

    End Sub


    Private Sub txtDocumentoRecibido_TextChanged(sender As Object, e As EventArgs) Handles txtDocumentoRecibido.TextChanged
        'CONVERTIR DE MINUSCULAS A MAYUSCULAS EN TIEMPO REAL
        Dim I As Integer
        txtDocumentoRecibido.Text = UCase(txtDocumentoRecibido.Text)
        I = Len(txtDocumentoRecibido.Text)
        txtDocumentoRecibido.SelectionStart = I

    End Sub



    Private Sub txtActividad_TextChanged(sender As Object, e As EventArgs) Handles txtActividad.TextChanged
        'CONVERTIR DE MINUSCULAS A MAYUSCULAS EN TIEMPO REAL
        Dim I As Integer
        txtActividad.Text = UCase(txtActividad.Text)
        I = Len(txtActividad.Text)
        txtActividad.SelectionStart = I
    End Sub

    Private Sub txtPersonaAutorizada_TextChanged(sender As Object, e As EventArgs) Handles txtPersonaAutorizada.TextChanged
        'CONVERTIR DE MINUSCULAS A MAYUSCULAS EN TIEMPO REAL
        Dim I As Integer
        txtPersonaAutorizada.Text = UCase(txtPersonaAutorizada.Text)
        I = Len(txtPersonaAutorizada.Text)
        txtPersonaAutorizada.SelectionStart = I
    End Sub

    Private Sub txtAlcance_TextChanged(sender As Object, e As EventArgs) Handles txtAlcance.TextChanged
        'CONVERTIR DE MINUSCULAS A MAYUSCULAS EN TIEMPO REAL
        Dim I As Integer
        txtAlcance.Text = UCase(txtAlcance.Text)
        I = Len(txtAlcance.Text)
        txtAlcance.SelectionStart = I
    End Sub

    Private Sub txtDocumentoEntregado_TextChanged(sender As Object, e As EventArgs) Handles txtDocumentoEntregado.TextChanged
        'CONVERTIR DE MINUSCULAS A MAYUSCULAS EN TIEMPO REAL
        Dim I As Integer
        txtDocumentoEntregado.Text = UCase(txtDocumentoEntregado.Text)
        I = Len(txtDocumentoEntregado.Text)
        txtDocumentoEntregado.SelectionStart = I
    End Sub

    Private Sub txtObservaciones_TextChanged(sender As Object, e As EventArgs) Handles txtObservaciones.TextChanged
        'CONVERTIR DE MINUSCULAS A MAYUSCULAS EN TIEMPO REAL
        Dim I As Integer
        txtObservaciones.Text = UCase(txtObservaciones.Text)
        I = Len(txtObservaciones.Text)
        txtObservaciones.SelectionStart = I
    End Sub

    Private Sub txtCalle_TextChanged(sender As Object, e As EventArgs) Handles txtCalle.TextChanged
        'CONVERTIR DE MINUSCULAS A MAYUSCULAS EN TIEMPO REAL
        Dim I As Integer
        txtCalle.Text = UCase(txtCalle.Text)
        I = Len(txtCalle.Text)
        txtCalle.SelectionStart = I
    End Sub

    Private Sub txtColonia_TextChanged(sender As Object, e As EventArgs) Handles txtColonia.TextChanged
        'CONVERTIR DE MINUSCULAS A MAYUSCULAS EN TIEMPO REAL
        Dim I As Integer
        txtColonia.Text = UCase(txtColonia.Text)
        I = Len(txtColonia.Text)
        txtColonia.SelectionStart = I
    End Sub


    Private Sub txtCorreoElectronico_TextChanged(sender As Object, e As EventArgs) Handles txtCorreoElectronico.TextChanged
        'CONVERTIR DE MAYUSCULAS A MINUSCULAS EN TIEMPO REAL
        Dim I As Integer
        txtCorreoElectronico.Text = LCase(txtCorreoElectronico.Text)
        I = Len(txtCorreoElectronico.Text)
        txtCorreoElectronico.SelectionStart = I
    End Sub

    Private Sub txtEmpresaServicio_TextChanged(sender As Object, e As EventArgs) Handles txtEmpresaServicio.TextChanged
        'CONVERTIR DE MINUSCULAS A MAYUSCULAS EN TIEMPO REAL
        Dim I As Integer
        txtEmpresaServicio.Text = UCase(txtEmpresaServicio.Text)
        I = Len(txtEmpresaServicio.Text)
        txtEmpresaServicio.SelectionStart = I
    End Sub

    Private Sub cbxTramiteSolicitado_TextChanged(sender As Object, e As EventArgs) Handles cbxTramiteSolicitado.TextChanged
        'CONVERTIR DE MINUSCULAS A MAYUSCULAS EN TIEMPO REAL
        Dim I As Integer
        cbxTramiteSolicitado.Text = UCase(cbxTramiteSolicitado.Text)
        I = Len(cbxTramiteSolicitado.Text)
        cbxTramiteSolicitado.SelectionStart = I
    End Sub



    Private Sub cbxRecibidoPor_TextChanged(sender As Object, e As EventArgs) Handles cbxRecibidoPor.TextChanged
        'CONVERTIR DE MINUSCULAS A MAYUSCULAS EN TIEMPO REAL
        Dim I As Integer
        cbxRecibidoPor.Text = UCase(cbxRecibidoPor.Text)
        I = Len(cbxRecibidoPor.Text)
        cbxRecibidoPor.SelectionStart = I
    End Sub


    Private Sub cbxLoResuelve_TextChanged(sender As Object, e As EventArgs) Handles cbxLoResuelve.TextChanged
        'CONVERTIR DE MINUSCULAS A MAYUSCULAS EN TIEMPO REAL
        Dim I As Integer
        cbxLoResuelve.Text = UCase(cbxLoResuelve.Text)
        I = Len(cbxLoResuelve.Text)
        cbxLoResuelve.SelectionStart = I
    End Sub



    Private Sub txtMunicipio_TextChanged(sender As Object, e As EventArgs) Handles txtMunicipio.TextChanged
        'CONVERTIR DE MINUSCULAS A MAYUSCULAS EN TIEMPO REAL
        Dim I As Integer
        txtMunicipio.Text = UCase(txtMunicipio.Text)
        I = Len(txtMunicipio.Text)
        txtMunicipio.SelectionStart = I
    End Sub



    Private Sub cbxNacionalidad_TextChanged(sender As Object, e As EventArgs) Handles cbxNacionalidad.TextChanged
        'CONVERTIR DE MINUSCULAS A MAYUSCULAS EN TIEMPO REAL
        Dim I As Integer
        cbxNacionalidad.Text = UCase(cbxNacionalidad.Text)
        I = Len(cbxNacionalidad.Text)
        cbxNacionalidad.SelectionStart = I
    End Sub



    Private Sub cbxStatus_TextChanged(sender As Object, e As EventArgs) Handles cbxStatus.TextChanged
        'CONVERTIR DE MINUSCULAS A MAYUSCULAS EN TIEMPO REAL
        Dim I As Integer
        cbxStatus.Text = UCase(cbxStatus.Text)
        I = Len(cbxStatus.Text)
        cbxStatus.SelectionStart = I
    End Sub



    Private Sub cbxResidente_TextChanged(sender As Object, e As EventArgs) Handles cbxResidente.TextChanged
        'CONVERTIR DE MINUSCULAS A MAYUSCULAS EN TIEMPO REAL
        Dim I As Integer
        cbxResidente.Text = UCase(cbxResidente.Text)
        I = Len(cbxResidente.Text)
        cbxResidente.SelectionStart = I
    End Sub


    Private Sub PendientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PendientesToolStripMenuItem.Click
        pendientes_form.Show()
    End Sub

    Private Sub TramiteSolicitadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TramiteSolicitadoToolStripMenuItem.Click
        reporte_tramite.Show()

    End Sub

    Private Sub NacionalidadToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NacionalidadToolStripMenuItem1.Click
        reporte_nacionalidad.Show()
    End Sub

    Private Sub NacionalidadToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles NacionalidadToolStripMenuItem2.Click
        agregar_nacionalidad.Show()
    End Sub


    Private Sub StatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatusToolStripMenuItem.Click
        agregar_status.Show()

    End Sub

    Private Sub TramiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TramiteToolStripMenuItem.Click
        agregar_tramite.Show()

    End Sub

    Private Sub PersonalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonalToolStripMenuItem.Click
        agregar_empleado.Show()
    End Sub

  
End Class
