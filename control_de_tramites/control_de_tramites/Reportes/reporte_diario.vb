Imports Microsoft.Reporting.WinForms
Public Class reporte_diario

    Private Sub dtFecha_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyData
            Case Keys.Enter

                Me.btnBuscar.PerformClick()

        End Select
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim p As New ReportParameter("fecha_dia", dtFecha.Text)
        Me.reporte_fecha.LocalReport.SetParameters(p)
        Me.reporte_fecha.RefreshReport()
    End Sub

    Private Sub reporte_diario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'registro_control_tramites.registro_control_tramites' Puede moverla o quitarla según sea necesario.
        Me.registro_control_tramitesTableAdapter.Fill(Me.registro_control_tramites._registro_control_tramites)
        Dim p As New ReportParameter("fecha_dia", dtFecha.Text)
        Me.reporte_fecha.LocalReport.SetParameters(p)
        Me.reporte_fecha.RefreshReport()

    End Sub
End Class