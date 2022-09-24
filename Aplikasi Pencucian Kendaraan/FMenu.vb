Public Class FMenu
    Private Sub KARYAWANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KARYAWANToolStripMenuItem.Click
        IsMdiContainer = True
        Karyawan.MdiParent = Me
        Karyawan.WindowState = FormWindowState.Maximized
        Karyawan.Show()
        PictureBox1.Hide()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Me.Close()
        Login.Close()
    End Sub

    Private Sub PAKETToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PAKETToolStripMenuItem.Click
        IsMdiContainer = True
        Paket.MdiParent = Me
        Paket.WindowState = FormWindowState.Maximized
        Paket.Show()
        PictureBox1.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        stsJam.Text = TimeOfDay
        If Label2.Left >= Me.Width Then
            Label2.Left = -Label2.Width
        Else
            Label2.Left = Label2.Left + 3
        End If
    End Sub

    Private Sub PELANGGANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PELANGGANToolStripMenuItem.Click
        IsMdiContainer = True
        Pelanggan.MdiParent = Me
        Pelanggan.WindowState = FormWindowState.Maximized
        Pelanggan.Show()
        PictureBox1.Hide()
    End Sub

    Private Sub USERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USERToolStripMenuItem.Click
        IsMdiContainer = True
        User.MdiParent = Me
        User.WindowState = FormWindowState.Maximized
        User.Show()
        PictureBox1.Hide()
    End Sub

    Private Sub PEMBAYARANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PEMBAYARANToolStripMenuItem.Click
        IsMdiContainer = True
        Pembayaran.MdiParent = Me
        Pembayaran.WindowState = FormWindowState.Maximized
        Pembayaran.Show()
        PictureBox1.Hide()
    End Sub

    Private Sub HARIANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HARIANToolStripMenuItem.Click
        IsMdiContainer = True
        LaporanHarian.MdiParent = Me
        LaporanHarian.WindowState = FormWindowState.Maximized
        LaporanHarian.Show()
        PictureBox1.Hide()
    End Sub

    Private Sub BULANANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BULANANToolStripMenuItem.Click
        IsMdiContainer = True
        LaporanBulanan.MdiParent = Me
        LaporanBulanan.WindowState = FormWindowState.Maximized
        LaporanBulanan.Show()
        PictureBox1.Hide()
    End Sub

    Private Sub GANTIPASSWORDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GANTIPASSWORDToolStripMenuItem.Click
        FGantiPassword.Show()
    End Sub
End Class