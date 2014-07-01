Imports Microsoft.Reporting.WinForms
Public Class reporte_mensual



    Private Sub reporte_mensual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'registro_control_tramites.registro_control_tramites' Puede moverla o quitarla según sea necesario.
        Me.registro_control_tramitesTableAdapter.Fill(Me.registro_control_tramites._registro_control_tramites)
   
        '  dtFecha.Format = DateTimePickerFormat.Custom
        '  dtFecha.CustomFormat = "MMMM, yyyy"
        Dim p As New ReportParameter("fecha_ingreso", dtFecha.Text)
        reporte_fecha.LocalReport.SetParameters(p)
        reporte_fecha.RefreshReport()


    End Sub


    Private Sub dtFecha_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtFecha.KeyDown
        Select Case e.KeyData
            Case Keys.Enter

                Me.btnBuscar.PerformClick()

        End Select
    End Sub



    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim p As New ReportParameter("fecha_ingreso", dtFecha.Text)
        reporte_fecha.LocalReport.SetParameters(p)
        reporte_fecha.RefreshReport()

    End Sub



End Class