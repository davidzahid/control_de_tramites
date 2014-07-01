
Imports Microsoft.Reporting.WinForms
Public Class reporte_nacionalidad

    Private Sub reporte_nacionalidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'registro_control_tramites.nacionalidad' Puede moverla o quitarla según sea necesario.
        Me.NacionalidadTableAdapter.Fill(Me.registro_control_tramites.nacionalidad)
        'TODO: esta línea de código carga datos en la tabla 'registro_control_tramites.registro_control_tramites' Puede moverla o quitarla según sea necesario.
        Me.registro_control_tramitesTableAdapter.Fill(Me.registro_control_tramites._registro_control_tramites)

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim a As New ReportParameter("anual", dtFecha.Value)
        Dim n As New ReportParameter("nacionalidad", cbxNacionalidad.Text)
        reporte_fecha.LocalReport.SetParameters(a)
        reporte_fecha.LocalReport.SetParameters(n)
        reporte_fecha.RefreshReport()
    End Sub
End Class