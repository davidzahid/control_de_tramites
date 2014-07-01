
Imports Microsoft.Reporting.WinForms
Public Class reporte_tramite

    Private Sub reporte_tramite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Registro_control_tramites.tramite_solicitado' Puede moverla o quitarla según sea necesario.
        Me.Tramite_solicitadoTableAdapter.Fill(Me.Registro_control_tramites.tramite_solicitado)
        'TODO: esta línea de código carga datos en la tabla 'Registro_control_tramites.nacionalidad' Puede moverla o quitarla según sea necesario.
        Me.NacionalidadTableAdapter.Fill(Me.Registro_control_tramites.nacionalidad)
        'TODO: esta línea de código carga datos en la tabla 'Registro_control_tramites._registro_control_tramites' Puede moverla o quitarla según sea necesario.
        Me.Registro_control_tramitesTableAdapter.Fill(Me.Registro_control_tramites._registro_control_tramites)

    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim a As New ReportParameter("fecha_ingreso", dtFecha.Text)
        Dim n As New ReportParameter("nacionalidad", cbxNacionalidad.Text)
        Dim t As New ReportParameter("tramite", cbxTramite.Text)
        reporte_fecha.LocalReport.SetParameters(a)
        reporte_fecha.LocalReport.SetParameters(n)
        reporte_fecha.LocalReport.SetParameters(t)
        reporte_fecha.RefreshReport()
    End Sub
End Class