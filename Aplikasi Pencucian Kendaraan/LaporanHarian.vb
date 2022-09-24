Public Class LaporanHarian
    Private Sub btnLihat_Click(sender As Object, e As EventArgs) Handles btnLihat.Click
        CrystalReportViewer1.SelectionFormula = "({pembayaran1.tgl_pembayaran})=#" & DateTimePicker1.Text & "#"
        CrystalReportViewer1.ReportSource = "LapHarian.rpt"
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        CrystalReportViewer1.PrintReport()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        CrystalReportViewer1.ExportReport()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
        FMenu.PictureBox1.Show()
    End Sub
End Class