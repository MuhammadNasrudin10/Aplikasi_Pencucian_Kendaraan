Public Class Pembayaran
    Dim startrecord As Integer = 0
    Dim totalrecordperhalaman = 5
    Sub tampilkan(ByVal sql As String)
        cekkoneksi()
        eksekusi.Connection = conn
        eksekusi.CommandType = CommandType.Text
        eksekusi.CommandText = sql
        mda.SelectCommand = eksekusi
        ds.Tables.Clear()
        mda.Fill(ds, startrecord, totalrecordperhalaman, "data")
        DataGridView1.DataSource = (ds.Tables("data"))
        conn.Close()
    End Sub

    Private Function getrowscount() As Integer
        Call tampilkan("select kode_pelanggan, nama_pelanggan from pelanggan")
        ds = New DataSet
        mda.Fill(ds)
        Return ds.Tables(0).Rows.Count
    End Function

    Sub cekdata()
        Dim endofrecord As Integer = getrowscount() / totalrecordperhalaman
        If startrecord = 0 Then
            btnPrev.Enabled = False
            btnNext.Enabled = True
        ElseIf startrecord / totalrecordperhalaman = endofrecord Then
            btnNext.Enabled = False
            btnPrev.Enabled = True
        Else
            btnPrev.Enabled = True
            btnNext.Enabled = True
        End If
    End Sub
    Sub aturdatagrid()
        DataGridView1.Columns(0).HeaderText = "Kode Pelanggan"
        DataGridView1.Columns(1).HeaderText = "Nama Pelanggan"

        DataGridView1.Columns(0).Width = 90
        DataGridView1.Columns(1).Width = 160

        DataGridView1.GridColor = Color.Black
        DataGridView1.DefaultCellStyle.ForeColor = Color.Black
        DataGridView1.DefaultCellStyle.BackColor = Color.SkyBlue
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Wheat
        DataGridView1.GridColor = Color.DarkCyan
    End Sub

    Sub bersih()
        lblKode.Text = ""
        lblNamaPelanggan.Text = ""
        lblJenisKendaraan.Text = ""
        lblMerkKendaraan.Text = ""
        lblPaketPencucian.Text = ""
        lblHarga.Text = ""
        lblNoHp.Text = ""
        lblTotal.Text = ""
        txtDibayar.Text = ""
        lblKembali.Text = ""
    End Sub

    Sub tombol()
        Dim btnbayar As New DataGridViewButtonColumn

        btnbayar.Name = "btnpilih"
        btnbayar.HeaderText = ""
        btnbayar.FlatStyle = FlatStyle.Popup
        btnbayar.DefaultCellStyle.ForeColor = Color.Green
        btnbayar.Text = "Pilih"
        btnbayar.Width = "60"
        btnbayar.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(btnbayar)
    End Sub

    Private Sub Pembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Columns.Clear()
        Call tampilkan("select kode_pelanggan, nama_pelanggan from pelanggan")
        Call aturdatagrid()
        Call tombol()
        Call cekdata()
    End Sub

    Private Sub Pembayaran_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DataGridView1.Columns.Clear()
        Call tampilkan("select kode_pelanggan, nama_pelanggan from pelanggan")
        Call aturdatagrid()
        Call tombol()
        lblNamaKasir.Text = Login.namauser
        lblTanggal.Text = Today
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        DataGridView1.Columns.Clear()
        Call tampilkan("SELECT kode_pelanggan, nama_pelanggan FROM pelanggan WHERE kode_pelanggan LIKE '%" & TextBox1.Text & "%' or nama_pelanggan LIKE '%" & TextBox1.Text & "%'")
        Call aturdatagrid()
        Call tombol()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        startrecord = startrecord - totalrecordperhalaman
        Call tampilkan("select kode_pelanggan, nama_pelanggan from pelanggan")
        Call cekdata()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        startrecord = startrecord + totalrecordperhalaman
        Call tampilkan("select kode_pelanggan, nama_pelanggan from pelanggan")
        Call cekdata()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
        FMenu.PictureBox1.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As String
        Dim kode As String
        i = DataGridView1.CurrentRow.Index
        kode = DataGridView1.Rows.Item(i).Cells(0).Value
        If e.ColumnIndex = 2 Then
            lblKode.Text = kode
        End If
    End Sub

    Private Sub lblKode_TextChanged(sender As Object, e As EventArgs) Handles lblKode.TextChanged
        Call cekkoneksi()
        eksekusi.Connection = conn
        eksekusi.CommandType = CommandType.Text
        eksekusi.CommandText = "SELECT * FROM pelanggan WHERE kode_pelanggan='" & lblKode.Text & "'"
        cek = eksekusi.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            lblKode.Text = cek.Item("kode_pelanggan")
            lblNamaPelanggan.Text = cek.Item("nama_pelanggan")
            lblMerkKendaraan.Text = cek.Item("merk_kendaraan")
            lblHarga.Text = cek.Item("harga")
            lblNoHp.Text = cek.Item("no_hp")
            lblJenisKendaraan.Text = cek.Item("jenis_kendaraan")
            lblPaketPencucian.Text = cek.Item("paket_pencucian")
            lblTotal.Text = cek.Item("harga")
        End If
        conn.Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call bersih()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblJam.Text = TimeOfDay
    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        If lblTotal.Text = "" Then
            MsgBox("Silahkan pilih nama pelanggan", MsgBoxStyle.Information, "Informasi")
        ElseIf txtDibayar.Text = "" Then
            MsgBox("Silahkan masukkan uang yang dibayarkan", MsgBoxStyle.Information, "Informasi")
        Else
            Call cekkoneksi()
            eksekusi.Connection = conn
            eksekusi.CommandType = CommandType.Text
            eksekusi.CommandText = "INSERT INTO pembayaran (kode_pelanggan, nama_pelanggan, jenis_kendaraan, merk_kendaraan, paket_pencucian, harga, no_hp, tgl_pembayaran, jam_pembayaran, nama_kasir, dibayar, kembalian) VALUES ('" & lblKode.Text & "', '" & lblNamaPelanggan.Text & "','" & lblJenisKendaraan.Text & "', '" & lblMerkKendaraan.Text & "', '" & lblPaketPencucian.Text & "', '" & lblHarga.Text & "', '" & lblNoHp.Text & "', '" & lblTanggal.Text & "', '" & lblJam.Text & "', '" & lblNamaKasir.Text & "','" & txtDibayar.Text & "', '" & lblKembali.Text & "')"
            eksekusi.ExecuteNonQuery()
            eksekusi.CommandText = "DELETE FROM pelanggan WHERE kode_pelanggan='" & lblKode.Text & "'"
            eksekusi.ExecuteNonQuery()
            If MessageBox.Show("Apakah ingin cetak nota pembayaran ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Nota.CrystalReportViewer1.ReportSource = "NotaPembayaran.rpt"
                Nota.CrystalReportViewer1.SelectionFormula = "{pembayaran1.kode_pelanggan}= '" & lblKode.Text & "' AND {pembayaran1.nama_pelanggan}= '" & lblNamaPelanggan.Text & "'"
                Nota.CrystalReportViewer1.RefreshReport()
                Nota.ShowDialog()
                Call bersih()
            End If
            Call tampilkan("select kode_pelanggan, nama_pelanggan from pelanggan")
        End If
    End Sub

    Private Sub txtDibayar_TextChanged(sender As Object, e As EventArgs) Handles txtDibayar.TextChanged
        lblKembali.Text = Val(txtDibayar.Text) - Val(lblTotal.Text)
    End Sub
End Class