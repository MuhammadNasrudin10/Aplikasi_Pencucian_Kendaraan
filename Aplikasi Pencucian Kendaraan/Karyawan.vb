Public Class Karyawan
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
        DataGridView1.Columns(0).HeaderText = "Id Karyawan"
        DataGridView1.Columns(1).HeaderText = "Nama Karyawan"
        DataGridView1.Columns(2).HeaderText = "No Hp"
        DataGridView1.Columns(3).HeaderText = "Alamat"
        DataGridView1.Columns(4).HeaderText = "Level"

        DataGridView1.Columns(0).Width = 90
        DataGridView1.Columns(1).Width = 135
        DataGridView1.Columns(2).Width = 95
        DataGridView1.Columns(3).Width = 180
        DataGridView1.Columns(4).Width = 70

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
        btnSimpan.Text = "Simpan"
        TextBox1.Enabled = True
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
    Private Sub Karyawan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DataGridView1.Columns.Clear()
        Call tampilkan("select * from karyawan")
        Call aturdatagrid()
        Call tombol()
    End Sub
    Private Sub Karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Columns.Clear()
        Call tampilkan("select * from karyawan")
        Call aturdatagrid()
        Call tombol()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                TextBox2.Focus()
        End Select
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                TextBox3.Focus()
        End Select
    End Sub

    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                TextBox4.Focus()
        End Select
    End Sub

    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                TextBox5.Focus()
        End Select
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If btnSimpan.Text = "Simpan" Then
            Call cekkoneksi()
            eksekusi.Connection = conn
            eksekusi.CommandType = CommandType.Text
            eksekusi.CommandText = "INSERT INTO karyawan (idkaryawan, nama_karyawan, no_hp, alamat,level) VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "','" & TextBox5.Text & "')"
            eksekusi.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Sukses")
        Else
            cekkoneksi()
            eksekusi.Connection = conn
            eksekusi.CommandType = CommandType.Text
            eksekusi.CommandText = "UPDATE karyawan SET idkaryawan='" & TextBox1.Text & "', nama_karyawan='" & TextBox2.Text & "', no_hp='" & TextBox3.Text & "', alamat='" & TextBox4.Text & "', level='" & TextBox5.Text & "' WHERE idkaryawan='" & TextBox1.Text & "'"
            eksekusi.ExecuteNonQuery()
            MsgBox("Data Berhasil Diupdate", MsgBoxStyle.Information, "Sukses")
        End If
        DataGridView1.Columns.Clear()
        Call tampilkan("SELECT *FROM karyawan")
        Call aturdatagrid()
        Call tombol()
        Call bersih()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call cekkoneksi()
        eksekusi.Connection = conn
        eksekusi.CommandType = CommandType.Text
        eksekusi.CommandText = "SELECT * FROM karyawan WHERE idkaryawan='" & TextBox1.Text & "'"
        cek = eksekusi.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            TextBox1.Text = cek.Item("idkaryawan")
            TextBox2.Text = cek.Item("nama_karyawan")
            TextBox3.Text = cek.Item("no_hp")
            TextBox4.Text = cek.Item("alamat")
            TextBox5.Text = cek.Item("level")
            btnSimpan.Text = "Update"
            TextBox1.Enabled = False
        End If
        conn.Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call bersih()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As String
        Dim kode As String
        i = DataGridView1.CurrentRow.Index
        kode = DataGridView1.Rows.Item(i).Cells(0).Value
        If e.ColumnIndex = 5 Then
            TextBox1.Text = kode
            TextBox2.Focus()
        End If

        If e.ColumnIndex = 6 Then
            Dim x As Byte
            i = DataGridView1.CurrentRow.Index
            x = MsgBox("Hapus data karyawan dengan Id Karyawan = " & kode & "?", MsgBoxStyle.Critical + vbYesNo, "Konfirmasi")
            If x = vbYes Then
                Call cekkoneksi()
                eksekusi.Connection = conn
                eksekusi.CommandType = CommandType.Text
                eksekusi.CommandText = "DELETE FROM karyawan WHERE idkaryawan='" & kode & "'"
                eksekusi.ExecuteNonQuery()
                MsgBox("Data Berhasil Dihapus", MsgBoxStyle.Information, "Informasi")
                DataGridView1.Columns.Clear()
                Call tampilkan("SELECT * FROM karyawan")
                Call aturdatagrid()
                Call tombol()
            End If
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        DataGridView1.Columns.Clear()
        Call tampilkan("SELECT * FROM karyawan WHERE idkaryawan LIKE '%" & TextBox6.Text & "%' or nama_karyawan LIKE '%" & TextBox6.Text & "%'")
        Call aturdatagrid()
        Call tombol()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
        FMenu.PictureBox1.Show()
    End Sub
End Class