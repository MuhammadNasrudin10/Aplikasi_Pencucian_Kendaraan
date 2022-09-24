Public Class Pelanggan
    Sub tampilkan(ByVal sql As String)
        cekkoneksi()
        eksekusi.Connection = conn
        eksekusi.CommandType = CommandType.Text
        eksekusi.CommandText = sql
        mda.SelectCommand = eksekusi
        ds.Tables.Clear()
        mda.Fill(ds, "data")
        DataGridView1.DataSource = (ds.Tables("data"))
        conn.Close()
    End Sub
    Sub aturdatagrid()
        DataGridView1.Columns(0).HeaderText = "Kode Pelanggan"
        DataGridView1.Columns(1).HeaderText = "Nama Pelanggan"
        DataGridView1.Columns(2).HeaderText = "Jenis Kendaraan"
        DataGridView1.Columns(3).HeaderText = "Merk Kendaraan"
        DataGridView1.Columns(4).HeaderText = "Paket Pencucian"
        DataGridView1.Columns(5).HeaderText = "Harga"
        DataGridView1.Columns(6).HeaderText = "No Hp"

        DataGridView1.Columns(0).Width = 90
        DataGridView1.Columns(1).Width = 113
        DataGridView1.Columns(2).Width = 75
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 96
        DataGridView1.Columns(5).Width = 78
        DataGridView1.Columns(6).Width = 85

        DataGridView1.GridColor = Color.Black
        DataGridView1.DefaultCellStyle.ForeColor = Color.Black
        DataGridView1.DefaultCellStyle.BackColor = Color.SkyBlue
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Wheat
        DataGridView1.GridColor = Color.DarkCyan
    End Sub

    Sub bersih()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        btnSimpan.Text = "Simpan"
        Call buatkode()
    End Sub

    Sub buatkode()
        Dim kode, kodebaru As String
        Dim no As Integer
        Call cekkoneksi()
        eksekusi.Connection = conn
        eksekusi.CommandType = CommandType.Text
        eksekusi.CommandText = "Select * From pelanggan order by kode_pelanggan DESC LIMIT 1"
        cek = eksekusi.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            kode = cek.Item("kode_pelanggan")
            no = Val(Microsoft.VisualBasic.Right(kode, 3))
            no = no + 1
            kodebaru = "P-" + Format(no, "000")
            TextBox1.Text = kodebaru
        Else
            TextBox1.Text = "P-" + "001"
        End If
        conn.Close()
        TextBox1.Enabled = False
        TextBox2.Focus()
    End Sub
    Sub tombol()
        Dim btnedit As New DataGridViewButtonColumn
        Dim btnhapus As New DataGridViewButtonColumn

        btnedit.Name = "btnedit"
        btnedit.HeaderText = ""
        btnedit.FlatStyle = FlatStyle.Popup
        btnedit.DefaultCellStyle.ForeColor = Color.Green
        btnedit.Text = "Edit"
        btnedit.Width = "50"
        btnedit.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(btnedit)

        btnhapus.Name = "btnhapus"
        btnhapus.HeaderText = ""
        btnhapus.FlatStyle = FlatStyle.Popup
        btnhapus.DefaultCellStyle.ForeColor = Color.Green
        btnhapus.Text = "Hapus"
        btnhapus.Width = "50"
        btnhapus.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(btnhapus)
    End Sub

    Private Sub Pelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Columns.Clear()
        Call tampilkan("Select kode_pelanggan, nama_pelanggan, jenis_kendaraan, merk_kendaraan, paket_pencucian, harga, no_hp from pelanggan")
        Call aturdatagrid()
        Call tombol()
        Call buatkode()
    End Sub

    Private Sub Pelanggan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DataGridView1.Columns.Clear()
        Call tampilkan("Select kode_pelanggan, nama_pelanggan, jenis_kendaraan, merk_kendaraan, paket_pencucian, harga, no_hp from pelanggan")
        Call aturdatagrid()
        Call tombol()
        Call buatkode()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If btnSimpan.Text = "Simpan" Then
            Call cekkoneksi()
            eksekusi.Connection = conn
            eksekusi.CommandType = CommandType.Text
            eksekusi.CommandText = "INSERT INTO pelanggan (kode_pelanggan, nama_pelanggan, jenis_kendaraan, merk_kendaraan, paket_pencucian, harga, no_hp) VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "','" & ComboBox1.Text & "', '" & TextBox3.Text & "', '" & ComboBox2.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "')"
            eksekusi.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Sukses")
        Else
            cekkoneksi()
            eksekusi.Connection = conn
            eksekusi.CommandType = CommandType.Text
            eksekusi.CommandText = "UPDATE pelanggan SET kode_pelanggan='" & TextBox1.Text & "', nama_pelanggan='" & TextBox2.Text & "',jenis_kendaraan='" & ComboBox1.Text & "',merk_kendaraan='" & TextBox3.Text & "',paket_pencucian='" & ComboBox2.Text & "', harga='" & TextBox4.Text & "', no_hp='" & TextBox5.Text & "' WHERE kode_pelanggan='" & TextBox1.Text & "'"
            eksekusi.ExecuteNonQuery()
            MsgBox("Data Berhasil Diupdate", MsgBoxStyle.Information, "Sukses")
        End If
        DataGridView1.Columns.Clear()
        Call tampilkan("Select kode_pelanggan, nama_pelanggan, jenis_kendaraan, merk_kendaraan, paket_pencucian, harga, no_hp from pelanggan")
        Call aturdatagrid()
        Call tombol()
        Call bersih()
        Call buatkode()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call cekkoneksi()
        eksekusi.Connection = conn
        eksekusi.CommandType = CommandType.Text
        eksekusi.CommandText = "SELECT * FROM pelanggan WHERE kode_pelanggan='" & TextBox1.Text & "'"
        cek = eksekusi.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            TextBox1.Text = cek.Item("kode_pelanggan")
            TextBox2.Text = cek.Item("nama_pelanggan")
            TextBox3.Text = cek.Item("merk_kendaraan")
            TextBox4.Text = cek.Item("harga")
            TextBox5.Text = cek.Item("no_hp")
            ComboBox1.Text = cek.Item("jenis_kendaraan")
            'ComboBox2.Text = cek.Item("paket_pencucian")
            btnSimpan.Text = "Update"
            TextBox1.Enabled = False
        End If
        conn.Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call bersih()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
        FMenu.PictureBox1.Show()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim x As String
        x = MsgBox("Yakin ingin menghapus semua data pelangggan ? ", MsgBoxStyle.Information + vbYesNo, "Konfirmasi")
        If x = vbYes Then
            Call cekkoneksi()
            eksekusi.Connection = conn
            eksekusi.CommandType = CommandType.Text
            eksekusi.CommandText = "DELETE FROM pelanggan"
            eksekusi.ExecuteNonQuery()
            MsgBox("Data Berhasil Di Reset", MsgBoxStyle.Information, "Informasi")
            DataGridView1.Columns.Clear()
            Call tampilkan("SELECT * FROM pelanggan")
            Call aturdatagrid()
            Call tombol()
            Call buatkode()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As String
        Dim kode As String
        i = DataGridView1.CurrentRow.Index
        kode = DataGridView1.Rows.Item(i).Cells(0).Value
        If e.ColumnIndex = 7 Then
            TextBox1.Text = kode
            TextBox2.Focus()
        End If

        If e.ColumnIndex = 8 Then
            Dim x As Byte
            i = DataGridView1.CurrentRow.Index
            x = MsgBox("Hapus data pelanggan dengan kode pelanggan = " & kode & "?", MsgBoxStyle.Critical + vbYesNo, "Konfirmasi")
            If x = vbYes Then
                Call cekkoneksi()
                eksekusi.Connection = conn
                eksekusi.CommandType = CommandType.Text
                eksekusi.CommandText = "DELETE FROM pelanggan WHERE kode_pelanggan='" & kode & "'"
                eksekusi.ExecuteNonQuery()
                MsgBox("Data Berhasil Dihapus", MsgBoxStyle.Information, "Informasi")
                DataGridView1.Columns.Clear()
                Call tampilkan("Select kode_pelanggan, nama_pelanggan, jenis_kendaraan, merk_kendaraan, paket_pencucian, harga, no_hp from pelanggan")
                Call aturdatagrid()
                Call tombol()
                Call buatkode()
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call cekkoneksi()
        eksekusi.Connection = conn
        eksekusi.CommandType = CommandType.Text
        eksekusi.CommandText = "SELECT * FROM paket"
        cek = eksekusi.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            If ComboBox1.Text = "Mobil" And ComboBox2.Text = "Manual" Then
                Call cekkoneksi()
                eksekusi.Connection = conn
                eksekusi.CommandType = CommandType.Text
                eksekusi.CommandText = "SELECT * FROM paket where kategori = 'Manual'"
                cek = eksekusi.ExecuteReader
                cek.Read()
                TextBox4.Text = cek.Item("mobil")
            ElseIf ComboBox1.Text = "Motor" And ComboBox2.Text = "Manual" Then
                Call cekkoneksi()
                eksekusi.Connection = conn
                eksekusi.CommandType = CommandType.Text
                eksekusi.CommandText = "SELECT * FROM paket where kategori = 'Manual'"
                cek = eksekusi.ExecuteReader
                cek.Read()
                TextBox4.Text = cek.Item("motor")
            ElseIf ComboBox1.Text = "Mobil" And ComboBox2.Text = "Waterless" Then
                Call cekkoneksi()
                eksekusi.Connection = conn
                eksekusi.CommandType = CommandType.Text
                eksekusi.CommandText = "SELECT * FROM paket where kategori = 'Waterless'"
                cek = eksekusi.ExecuteReader
                cek.Read()
                TextBox4.Text = cek.Item("mobil")
            ElseIf ComboBox1.Text = "Motor" And ComboBox2.Text = "Waterless" Then
                Call cekkoneksi()
                eksekusi.Connection = conn
                eksekusi.CommandType = CommandType.Text
                eksekusi.CommandText = "SELECT * FROM paket where kategori = 'Waterless'"
                cek = eksekusi.ExecuteReader
                cek.Read()
                TextBox4.Text = cek.Item("motor")
            ElseIf ComboBox1.Text = "Mobil" And ComboBox2.Text = "Touchless" Then
                Call cekkoneksi()
                eksekusi.Connection = conn
                eksekusi.CommandType = CommandType.Text
                eksekusi.CommandText = "SELECT * FROM paket where kategori = 'Touchless'"
                cek = eksekusi.ExecuteReader
                cek.Read()
                TextBox4.Text = cek.Item("mobil")
            ElseIf ComboBox1.Text = "Motor" And ComboBox2.Text = "Touchless" Then
                Call cekkoneksi()
                eksekusi.Connection = conn
                eksekusi.CommandType = CommandType.Text
                eksekusi.CommandText = "SELECT * FROM paket where kategori = 'Touchless'"
                cek = eksekusi.ExecuteReader
                cek.Read()
                TextBox4.Text = cek.Item("motor")
            ElseIf ComboBox1.Text = "Mobil" And ComboBox2.Text = "Robotic" Then
                Call cekkoneksi()
                eksekusi.Connection = conn
                eksekusi.CommandType = CommandType.Text
                eksekusi.CommandText = "SELECT * FROM paket where kategori = 'Robotic'"
                cek = eksekusi.ExecuteReader
                cek.Read()
                TextBox4.Text = cek.Item("mobil")
            ElseIf ComboBox1.Text = "Motor" And ComboBox2.Text = "Robotic" Then
                Call cekkoneksi()
                eksekusi.Connection = conn
                eksekusi.CommandType = CommandType.Text
                eksekusi.CommandText = "SELECT * FROM paket where kategori = 'Robotic'"
                cek = eksekusi.ExecuteReader
                cek.Read()
                TextBox4.Text = cek.Item("motor")
            End If
        End If
        TextBox4.Enabled = False
        conn.Close()
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Call cekkoneksi()
        eksekusi.Connection = conn
        eksekusi.CommandType = CommandType.Text
        eksekusi.CommandText = "SELECT * FROM paket"
        cek = eksekusi.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            If ComboBox1.Text = "Mobil" And ComboBox2.Text = "Manual" Then
                Call cekkoneksi()
                eksekusi.Connection = conn
                eksekusi.CommandType = CommandType.Text
                eksekusi.CommandText = "SELECT * FROM paket where kategori = 'Manual'"
                cek = eksekusi.ExecuteReader
                cek.Read()
                TextBox4.Text = cek.Item("mobil")
            ElseIf ComboBox1.Text = "Motor" And ComboBox2.Text = "Manual" Then
                Call cekkoneksi()
                eksekusi.Connection = conn
                eksekusi.CommandType = CommandType.Text
                eksekusi.CommandText = "SELECT * FROM paket where kategori = 'Manual'"
                cek = eksekusi.ExecuteReader
                cek.Read()
                TextBox4.Text = cek.Item("motor")
            ElseIf ComboBox1.Text = "Mobil" And ComboBox2.Text = "Waterless" Then
                Call cekkoneksi()
                eksekusi.Connection = conn
                eksekusi.CommandType = CommandType.Text
                eksekusi.CommandText = "SELECT * FROM paket where kategori = 'Waterless'"
                cek = eksekusi.ExecuteReader
                cek.Read()
                TextBox4.Text = cek.Item("mobil")
            ElseIf ComboBox1.Text = "Motor" And ComboBox2.Text = "Waterless" Then
                Call cekkoneksi()
                eksekusi.Connection = conn
                eksekusi.CommandType = CommandType.Text
                eksekusi.CommandText = "SELECT * FROM paket where kategori = 'Waterless'"
                cek = eksekusi.ExecuteReader
                cek.Read()
                TextBox4.Text = cek.Item("motor")
            ElseIf ComboBox1.Text = "Mobil" And ComboBox2.Text = "Touchless" Then
                Call cekkoneksi()
                eksekusi.Connection = conn
                eksekusi.CommandType = CommandType.Text
                eksekusi.CommandText = "SELECT * FROM paket where kategori = 'Touchless'"
                cek = eksekusi.ExecuteReader
                cek.Read()
                TextBox4.Text = cek.Item("mobil")
            ElseIf ComboBox1.Text = "Motor" And ComboBox2.Text = "Touchless" Then
                Call cekkoneksi()
                eksekusi.Connection = conn
                eksekusi.CommandType = CommandType.Text
                eksekusi.CommandText = "SELECT * FROM paket where kategori = 'Touchless'"
                cek = eksekusi.ExecuteReader
                cek.Read()
                TextBox4.Text = cek.Item("motor")
            ElseIf ComboBox1.Text = "Mobil" And ComboBox2.Text = "Robotic" Then
                Call cekkoneksi()
                eksekusi.Connection = conn
                eksekusi.CommandType = CommandType.Text
                eksekusi.CommandText = "SELECT * FROM paket where kategori = 'Robotic'"
                cek = eksekusi.ExecuteReader
                cek.Read()
                TextBox4.Text = cek.Item("mobil")
            ElseIf ComboBox1.Text = "Motor" And ComboBox2.Text = "Robotic" Then
                Call cekkoneksi()
                eksekusi.Connection = conn
                eksekusi.CommandType = CommandType.Text
                eksekusi.CommandText = "SELECT * FROM paket where kategori = 'Robotic'"
                cek = eksekusi.ExecuteReader
                cek.Read()
                TextBox4.Text = cek.Item("motor")
            End If
        End If
        TextBox4.Enabled = False
        conn.Close()
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        DataGridView1.Columns.Clear()
        Call tampilkan("Select kode_pelanggan, nama_pelanggan, jenis_kendaraan, merk_kendaraan, paket_pencucian, harga, no_hp from pelanggan WHERE kode_pelanggan LIKE '%" & TextBox6.Text & "%' or nama_pelanggan LIKE '%" & TextBox6.Text & "%'")
        Call aturdatagrid()
        Call tombol()
    End Sub
End Class