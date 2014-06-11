Public Class Form1



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'registro_control_tramites.registro_control_tramites' Puede moverla o quitarla según sea necesario.
        Me.registro_control_tramitesTableAdapter.Fill(Me.registro_control_tramites._registro_control_tramites)

        'LICENCIADO EN SISTEMAS COMPUTACIONALES
        'AUTOR DAVID ZAHID JIMENEZ GREZ
        'CONTACTO@ZAHID.MX
        'WWW.ZAHID.MX
        'TODO: esta línea de código carga datos en la tabla 'registro_control_tramites.registro_control_tramites' Puede moverla o quitarla según sea necesario.
      
        Me.ReportViewer1.RefreshReport()
    End Sub


End Class