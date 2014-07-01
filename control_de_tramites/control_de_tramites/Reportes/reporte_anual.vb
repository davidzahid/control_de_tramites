Imports Microsoft.Reporting.WinForms
Public Class reporte_anual

    Private Sub reporte_fecha_Load(sender As Object, e As EventArgs) Handles reporte_fecha.Load

    End Sub
 

    Private Sub dtFecha_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtFecha.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
          
                Me.btnBuscar.PerformClick()

        End Select
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim p As New ReportParameter("anual", dtFecha.Text)
        reporte_fecha.LocalReport.SetParameters(p)
        reporte_fecha.RefreshReport()

    End Sub

    Private Sub reporte_anual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'registro_control_tramites.registro_control_tramites' Puede moverla o quitarla según sea necesario.
        Me.registro_control_tramitesTableAdapter.Fill(Me.registro_control_tramites._registro_control_tramites)
 
        Me.reporte_fecha.RefreshReport()

        Dim p As New ReportParameter("anual", dtFecha.Text)
        reporte_fecha.LocalReport.SetParameters(p)
        reporte_fecha.RefreshReport()
    End Sub


End Class