Public Class FGantiPassword
    Private Sub FGantiPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassLama.Enabled = True
        txtPassBaru.Enabled = False
        txtKonfirmasi.Enabled = False
    End Sub

    Private Sub FGantiPassword_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtPassLama.Focus()
    End Sub

    Private Sub txtPassLama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassLama.KeyPress
        If e.KeyChar = Chr(13) Then
            cekkoneksi()
            eksekusi.Connection = conn
            eksekusi.CommandType = CommandType.Text
            eksekusi.CommandText = "select * from user where pengguna='" & FMenu.stsNamaUser.Text & "'and userpassword='" & txtPassLama.Text & "'"
            cek = eksekusi.ExecuteReader
            cek.Read()
            If cek.HasRows Then
                txtPassBaru.Enabled = True
                txtPassBaru.Focus()
            Else
                MsgBox("Password Lama Salah")
                txtPassLama.Focus()
            End If
        End If
    End Sub

    Private Sub txtPassBaru_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassBaru.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtPassBaru.Text = "" Then
                MsgBox("Password baru wajib diisi")
                txtPassBaru.Focus()
            Else
                txtKonfirmasi.Enabled = True
                txtKonfirmasi.Focus()
            End If
        End If
    End Sub

    Private Sub txtKonfirmasi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKonfirmasi.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtKonfirmasi.Text <> txtPassBaru.Text Then
                MsgBox("Password konfirmasi tidak sesuai")
                txtKonfirmasi.Focus()
            Else
                If MessageBox.Show("Yakin akan ganti password ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    cekkoneksi()
                    eksekusi.Connection = conn
                    eksekusi.CommandType = CommandType.Text
                    eksekusi.CommandText = "UPDATE user SET userpassword='" & txtPassBaru.Text & "' WHERE pengguna='" & FMenu.stsNamaUser.Text & "'"
                    eksekusi.ExecuteNonQuery()
                    MsgBox("Password Berhasil Diubah", MsgBoxStyle.Information, "Sukses")
                    txtPassLama.Text = ""
                    txtPassBaru.Text = ""
                    txtKonfirmasi.Text = ""
                Else
                    txtPassLama.Clear()
                    txtPassBaru.Clear()
                    txtKonfirmasi.Clear()
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtKonfirmasi.Text <> txtPassBaru.Text Then
            MsgBox("Password konfirmasi tidak sesuai")
            txtKonfirmasi.Focus()
        Else
            If MessageBox.Show("Yakin akan ganti password ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cekkoneksi()
                eksekusi.Connection = conn
                eksekusi.CommandType = CommandType.Text
                eksekusi.CommandText = "UPDATE user SET userpassword='" & txtPassBaru.Text & "' WHERE pengguna='" & FMenu.stsNamaUser.Text & "'"
                eksekusi.ExecuteNonQuery()
                MsgBox("Password Berhasil Diubah", MsgBoxStyle.Information, "Sukses")
                txtPassLama.Text = ""
                txtPassBaru.Text = ""
                txtKonfirmasi.Text = ""
            Else
                txtPassLama.Clear()
                txtPassBaru.Clear()
                txtKonfirmasi.Clear()
                Me.Close()
            End If
        End If
    End Sub
End Class