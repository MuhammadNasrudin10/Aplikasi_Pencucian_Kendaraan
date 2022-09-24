Class Login
    Public userlogin, namauser, level As String
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.remember Then
            ckRemember.Checked = True
            txtUsername.Text = My.Settings.username
            txtPassword.Text = My.Settings.password
        Else
            ckRemember.Checked = False
            My.Settings.username = ""
            My.Settings.password = ""
        End If
    End Sub

    Private Sub ckLihat_CheckedChanged(sender As Object, e As EventArgs) Handles ckLihat.CheckedChanged
        If ckLihat.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ckRemember.Checked = True Then
            My.Settings.username = txtUsername.Text
            My.Settings.password = txtPassword.Text
            My.Settings.remember = True
            My.Settings.Save()
            My.Settings.Reload()
        Else
            My.Settings.remember = False
        End If
        cekkoneksi()
        eksekusi.Connection = conn
        eksekusi.CommandType = CommandType.Text
        eksekusi.CommandText = "select * from user where username='" & txtUsername.Text & "'and userpassword='" & txtPassword.Text & "'"
        cek = eksekusi.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            userlogin = txtUsername.Text
            namauser = cek.Item("pengguna")
            level = cek.Item("userlevel")
            If level = "admin" Then
                MessageBox.Show("Selamat Datang Admin", "Informasi")
                FMenu.Show()
            ElseIf level = "pimpinan" Then
                MessageBox.Show("Selamat Datang Pimpinan", "Informasi")
                FMenu.Show()
                FMenu.MASTERToolStripMenuItem.Visible = False
                FMenu.TRANSAKSIToolStripMenuItem.Visible = False
            ElseIf level = "kasir" Then
                MessageBox.Show("Selamat Datang Kasir", "Informasi")
                FMenu.Show()
                FMenu.MASTERToolStripMenuItem.Visible = False
            End If
        Else
            MsgBox("Username / Password Salah", MsgBoxStyle.Critical, "Infromasi")
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtUsername.Focus()
        End If
        FMenu.stsNamaUser.Text = namauser
        FMenu.stsTanggal.Text = Today
        FMenu.stsJam.Text = TimeOfDay
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txtPassword.Focus()
        End Select
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button1_Click(e, AcceptButton)
        End Select
    End Sub
End Class