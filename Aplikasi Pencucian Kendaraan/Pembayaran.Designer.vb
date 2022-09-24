<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pembayaran
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblKembali = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.txtDibayar = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblNamaKasir = New System.Windows.Forms.Label()
        Me.lblJam = New System.Windows.Forms.Label()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Rp = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblNoHp = New System.Windows.Forms.Label()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.lblPaketPencucian = New System.Windows.Forms.Label()
        Me.lblMerkKendaraan = New System.Windows.Forms.Label()
        Me.lblJenisKendaraan = New System.Windows.Forms.Label()
        Me.lblNamaPelanggan = New System.Windows.Forms.Label()
        Me.lblKode = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 23)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(353, 157)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 337)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(385, 83)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(27, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(331, 26)
        Me.TextBox1.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(335, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Cari Berdasarkan Kode/Nama Pelanggan"
        '
        'btnKeluar
        '
        Me.btnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.Location = New System.Drawing.Point(317, 437)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(80, 31)
        Me.btnKeluar.TabIndex = 11
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.Location = New System.Drawing.Point(16, 199)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(68, 27)
        Me.btnPrev.TabIndex = 12
        Me.btnPrev.Text = "Prev"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(103, 199)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(68, 27)
        Me.btnNext.TabIndex = 13
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.btnNext)
        Me.GroupBox1.Controls.Add(Me.btnPrev)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 242)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pilih Nama Pelanggan"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.lblKembali)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Controls.Add(Me.btnBayar)
        Me.GroupBox3.Controls.Add(Me.txtDibayar)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.lblNamaKasir)
        Me.GroupBox3.Controls.Add(Me.lblJam)
        Me.GroupBox3.Controls.Add(Me.lblTanggal)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Rp)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.lblNoHp)
        Me.GroupBox3.Controls.Add(Me.lblHarga)
        Me.GroupBox3.Controls.Add(Me.lblPaketPencucian)
        Me.GroupBox3.Controls.Add(Me.lblMerkKendaraan)
        Me.GroupBox3.Controls.Add(Me.lblJenisKendaraan)
        Me.GroupBox3.Controls.Add(Me.lblNamaPelanggan)
        Me.GroupBox3.Controls.Add(Me.lblKode)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(417, 72)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(930, 396)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Font = New System.Drawing.Font("DS-Digital", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(664, 326)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 48)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Rp."
        '
        'lblKembali
        '
        Me.lblKembali.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblKembali.Font = New System.Drawing.Font("DS-Digital", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKembali.ForeColor = System.Drawing.Color.White
        Me.lblKembali.Location = New System.Drawing.Point(732, 326)
        Me.lblKembali.Name = "lblKembali"
        Me.lblKembali.Size = New System.Drawing.Size(192, 48)
        Me.lblKembali.TabIndex = 44
        Me.lblKembali.Text = "0"
        Me.lblKembali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(488, 333)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(181, 48)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "KEMBALI :"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotal.Font = New System.Drawing.Font("DS-Digital", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(752, 22)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(155, 48)
        Me.lblTotal.TabIndex = 42
        Me.lblTotal.Text = "0"
        '
        'btnBayar
        '
        Me.btnBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBayar.Location = New System.Drawing.Point(740, 279)
        Me.btnBayar.Name = "btnBayar"
        Me.btnBayar.Size = New System.Drawing.Size(80, 31)
        Me.btnBayar.TabIndex = 17
        Me.btnBayar.Text = "Bayar"
        Me.btnBayar.UseVisualStyleBackColor = True
        '
        'txtDibayar
        '
        Me.txtDibayar.Location = New System.Drawing.Point(638, 237)
        Me.txtDibayar.Name = "txtDibayar"
        Me.txtDibayar.Size = New System.Drawing.Size(269, 26)
        Me.txtDibayar.TabIndex = 39
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(530, 241)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 22)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Di bayar :"
        '
        'lblNamaKasir
        '
        Me.lblNamaKasir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNamaKasir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaKasir.Location = New System.Drawing.Point(638, 194)
        Me.lblNamaKasir.Name = "lblNamaKasir"
        Me.lblNamaKasir.Size = New System.Drawing.Size(269, 22)
        Me.lblNamaKasir.TabIndex = 37
        Me.lblNamaKasir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJam
        '
        Me.lblJam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblJam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJam.Location = New System.Drawing.Point(638, 146)
        Me.lblJam.Name = "lblJam"
        Me.lblJam.Size = New System.Drawing.Size(269, 22)
        Me.lblJam.TabIndex = 36
        Me.lblJam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTanggal
        '
        Me.lblTanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanggal.Location = New System.Drawing.Point(638, 99)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(269, 22)
        Me.lblTanggal.TabIndex = 35
        Me.lblTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(530, 194)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 22)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Kasir      :"
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(530, 146)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 22)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Jam        :"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(530, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 22)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Tanggal  :"
        '
        'Rp
        '
        Me.Rp.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Rp.Font = New System.Drawing.Font("DS-Digital", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rp.ForeColor = System.Drawing.Color.White
        Me.Rp.Location = New System.Drawing.Point(690, 22)
        Me.Rp.Name = "Rp"
        Me.Rp.Size = New System.Drawing.Size(78, 48)
        Me.Rp.TabIndex = 31
        Me.Rp.Text = "Rp."
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(514, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 48)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = " TOTAL :"
        '
        'lblNoHp
        '
        Me.lblNoHp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNoHp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoHp.Location = New System.Drawing.Point(222, 326)
        Me.lblNoHp.Name = "lblNoHp"
        Me.lblNoHp.Size = New System.Drawing.Size(248, 22)
        Me.lblNoHp.TabIndex = 29
        Me.lblNoHp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHarga
        '
        Me.lblHarga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHarga.Location = New System.Drawing.Point(222, 283)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(248, 22)
        Me.lblHarga.TabIndex = 28
        Me.lblHarga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPaketPencucian
        '
        Me.lblPaketPencucian.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPaketPencucian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaketPencucian.Location = New System.Drawing.Point(222, 241)
        Me.lblPaketPencucian.Name = "lblPaketPencucian"
        Me.lblPaketPencucian.Size = New System.Drawing.Size(248, 22)
        Me.lblPaketPencucian.TabIndex = 27
        Me.lblPaketPencucian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMerkKendaraan
        '
        Me.lblMerkKendaraan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMerkKendaraan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMerkKendaraan.Location = New System.Drawing.Point(222, 194)
        Me.lblMerkKendaraan.Name = "lblMerkKendaraan"
        Me.lblMerkKendaraan.Size = New System.Drawing.Size(248, 22)
        Me.lblMerkKendaraan.TabIndex = 26
        Me.lblMerkKendaraan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblJenisKendaraan
        '
        Me.lblJenisKendaraan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblJenisKendaraan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJenisKendaraan.Location = New System.Drawing.Point(222, 146)
        Me.lblJenisKendaraan.Name = "lblJenisKendaraan"
        Me.lblJenisKendaraan.Size = New System.Drawing.Size(248, 22)
        Me.lblJenisKendaraan.TabIndex = 25
        Me.lblJenisKendaraan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNamaPelanggan
        '
        Me.lblNamaPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNamaPelanggan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaPelanggan.Location = New System.Drawing.Point(221, 99)
        Me.lblNamaPelanggan.Name = "lblNamaPelanggan"
        Me.lblNamaPelanggan.Size = New System.Drawing.Size(248, 22)
        Me.lblNamaPelanggan.TabIndex = 24
        Me.lblNamaPelanggan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKode
        '
        Me.lblKode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblKode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKode.Location = New System.Drawing.Point(220, 51)
        Me.lblKode.Name = "lblKode"
        Me.lblKode.Size = New System.Drawing.Size(249, 22)
        Me.lblKode.TabIndex = 23
        Me.lblKode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 22)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "MERK KENDARAAN :"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 22)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "JENIS KENDARAAN :"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 22)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "HARGA                     :"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(32, 326)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 22)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "NO HP                       :"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(184, 22)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "PAKET PENCUCIAN :"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 22)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "NAMA PELANGGAN :"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 22)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "KODE PELANGGAN :"
        '
        'btnBatal
        '
        Me.btnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(177, 437)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(80, 31)
        Me.btnBatal.TabIndex = 16
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Pembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 533)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Pembayaran"
        Me.Text = "Pembayaran"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNoHp As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents lblPaketPencucian As Label
    Friend WithEvents lblMerkKendaraan As Label
    Friend WithEvents lblJenisKendaraan As Label
    Friend WithEvents lblNamaPelanggan As Label
    Friend WithEvents lblKode As Label
    Friend WithEvents Rp As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnBatal As Button
    Friend WithEvents lblNamaKasir As Label
    Friend WithEvents lblJam As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnBayar As Button
    Friend WithEvents txtDibayar As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblKembali As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
End Class
