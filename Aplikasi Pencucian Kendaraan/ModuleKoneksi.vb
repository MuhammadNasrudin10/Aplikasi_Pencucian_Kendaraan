Imports MySql.Data.MySqlClient
Module ModuleKoneksi

    Dim connection As String = "server=localhost;uid=root;database=pencucian_kendaraan;Ssl Mode = none"
    Public conn As New MySqlConnection(connection)
    Public eksekusi As New MySqlCommand
    Public cek As MySqlDataReader
    Public mda As New MySqlDataAdapter
    Public ds As New DataSet
    Public Sub cekkoneksi()
        Try
            conn = New MySqlConnection(connection)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            Else
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox("Koneksi ke server terputus", MsgBoxStyle.Information)
            End
            Exit Sub
        End Try
    End Sub

    'Dim connection As String = "Data Source=DESKTOP-6LGQTJQ;Initial Catalog=pencucian_kendaraan;Integrated Security=True"
    'Public conn As New SqlConnection(connection)
    'Public eksekusi As New SqlCommand
    'Public cek As SqlDataReader
    'Public mda As New SqlDataAdapter
    'Public ds As New DataSet
    'Public Sub cekkoneksi()
    '    Try
    '        conn = New SqlConnection(connection)
    '        If conn.State = ConnectionState.Closed Then
    '            conn.Open()
    '        Else
    '            conn.Close()
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Koneksi ke server terputus", MsgBoxStyle.Information)
    '        End
    '        Exit Sub
    '    End Try
    'End Sub

    'Private connection As String = "provider=microsoft.ace.oledb.16.0;data source=pencucian_kendaraan.accdb"
    'Public conn As New OleDbConnection(connection)
    'Public eksekusi As New OleDbCommand
    'Public cek As OleDbDataReader
    'Public mda As New OleDbDataAdapter
    'Public ds As New DataSet
    'Public Sub cekkoneksi()
    '    Try
    '        conn = New OleDbConnection(connection)
    '        If conn.State = ConnectionState.Closed Then
    '            conn.Open()
    '        Else
    '            conn.Close()
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Koneksi ke server terputus", MsgBoxStyle.Information)
    '        End
    '        Exit Sub
    '    End Try
    'End Sub

    'Private connection As String = "Data source = pencucian_kendaraan.db;version=3"
    'Public conn As New SQLiteConnection(connection)
    'Public eksekusi As New SQLiteCommand
    'Public cek As SQLiteDataReader
    'Public mda As New SQLiteDataAdapter
    'Public ds As New DataSet

    'Public Sub cekkoneksi()
    '    Try
    '        conn = New SQLiteConnection(connection)
    '        If conn.State = ConnectionState.Closed Then
    '            conn.Open()
    '        Else
    '            conn.Close()
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Koneksi ke server terputus", MsgBoxStyle.Information)
    '        End
    '        Exit Sub
    '    End Try
    'End Sub
End Module
