<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FMenu))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MASTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KARYAWANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PAKETToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRANSAKSIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PELANGGANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PEMBAYARANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAPORANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HARIANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BULANANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GANTIPASSWORDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsNamaUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsTanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1386, 121)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(440, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(462, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Muhammad Nasrudin dan Resti Nur Amalia"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(512, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PENCUCIAN KENDARAAN"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MASTERToolStripMenuItem, Me.TRANSAKSIToolStripMenuItem, Me.LAPORANToolStripMenuItem, Me.GANTIPASSWORDToolStripMenuItem, Me.LOGOUTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 121)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1386, 32)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MASTERToolStripMenuItem
        '
        Me.MASTERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KARYAWANToolStripMenuItem, Me.PAKETToolStripMenuItem, Me.USERToolStripMenuItem})
        Me.MASTERToolStripMenuItem.Image = CType(resources.GetObject("MASTERToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MASTERToolStripMenuItem.Name = "MASTERToolStripMenuItem"
        Me.MASTERToolStripMenuItem.Size = New System.Drawing.Size(126, 28)
        Me.MASTERToolStripMenuItem.Text = "MASTER"
        '
        'KARYAWANToolStripMenuItem
        '
        Me.KARYAWANToolStripMenuItem.Image = CType(resources.GetObject("KARYAWANToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KARYAWANToolStripMenuItem.Name = "KARYAWANToolStripMenuItem"
        Me.KARYAWANToolStripMenuItem.Size = New System.Drawing.Size(205, 28)
        Me.KARYAWANToolStripMenuItem.Text = "KARYAWAN"
        '
        'PAKETToolStripMenuItem
        '
        Me.PAKETToolStripMenuItem.Image = CType(resources.GetObject("PAKETToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PAKETToolStripMenuItem.Name = "PAKETToolStripMenuItem"
        Me.PAKETToolStripMenuItem.Size = New System.Drawing.Size(205, 28)
        Me.PAKETToolStripMenuItem.Text = "PAKET"
        '
        'USERToolStripMenuItem
        '
        Me.USERToolStripMenuItem.Image = CType(resources.GetObject("USERToolStripMenuItem.Image"), System.Drawing.Image)
        Me.USERToolStripMenuItem.Name = "USERToolStripMenuItem"
        Me.USERToolStripMenuItem.Size = New System.Drawing.Size(205, 28)
        Me.USERToolStripMenuItem.Text = "USER"
        '
        'TRANSAKSIToolStripMenuItem
        '
        Me.TRANSAKSIToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PELANGGANToolStripMenuItem, Me.PEMBAYARANToolStripMenuItem})
        Me.TRANSAKSIToolStripMenuItem.Image = CType(resources.GetObject("TRANSAKSIToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TRANSAKSIToolStripMenuItem.Name = "TRANSAKSIToolStripMenuItem"
        Me.TRANSAKSIToolStripMenuItem.Size = New System.Drawing.Size(163, 28)
        Me.TRANSAKSIToolStripMenuItem.Text = "TRANSAKSI"
        '
        'PELANGGANToolStripMenuItem
        '
        Me.PELANGGANToolStripMenuItem.Image = CType(resources.GetObject("PELANGGANToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PELANGGANToolStripMenuItem.Name = "PELANGGANToolStripMenuItem"
        Me.PELANGGANToolStripMenuItem.Size = New System.Drawing.Size(229, 28)
        Me.PELANGGANToolStripMenuItem.Text = "PELANGGAN"
        '
        'PEMBAYARANToolStripMenuItem
        '
        Me.PEMBAYARANToolStripMenuItem.Image = CType(resources.GetObject("PEMBAYARANToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PEMBAYARANToolStripMenuItem.Name = "PEMBAYARANToolStripMenuItem"
        Me.PEMBAYARANToolStripMenuItem.Size = New System.Drawing.Size(229, 28)
        Me.PEMBAYARANToolStripMenuItem.Text = "PEMBAYARAN"
        '
        'LAPORANToolStripMenuItem
        '
        Me.LAPORANToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HARIANToolStripMenuItem, Me.BULANANToolStripMenuItem})
        Me.LAPORANToolStripMenuItem.Image = CType(resources.GetObject("LAPORANToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LAPORANToolStripMenuItem.Name = "LAPORANToolStripMenuItem"
        Me.LAPORANToolStripMenuItem.Size = New System.Drawing.Size(143, 28)
        Me.LAPORANToolStripMenuItem.Text = "LAPORAN"
        '
        'HARIANToolStripMenuItem
        '
        Me.HARIANToolStripMenuItem.Image = CType(resources.GetObject("HARIANToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HARIANToolStripMenuItem.Name = "HARIANToolStripMenuItem"
        Me.HARIANToolStripMenuItem.Size = New System.Drawing.Size(186, 28)
        Me.HARIANToolStripMenuItem.Text = "HARIAN"
        '
        'BULANANToolStripMenuItem
        '
        Me.BULANANToolStripMenuItem.Image = CType(resources.GetObject("BULANANToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BULANANToolStripMenuItem.Name = "BULANANToolStripMenuItem"
        Me.BULANANToolStripMenuItem.Size = New System.Drawing.Size(186, 28)
        Me.BULANANToolStripMenuItem.Text = "BULANAN"
        '
        'GANTIPASSWORDToolStripMenuItem
        '
        Me.GANTIPASSWORDToolStripMenuItem.Image = CType(resources.GetObject("GANTIPASSWORDToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GANTIPASSWORDToolStripMenuItem.Name = "GANTIPASSWORDToolStripMenuItem"
        Me.GANTIPASSWORDToolStripMenuItem.Size = New System.Drawing.Size(236, 28)
        Me.GANTIPASSWORDToolStripMenuItem.Text = "GANTI PASSWORD"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Image = CType(resources.GetObject("LOGOUTToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(136, 28)
        Me.LOGOUTToolStripMenuItem.Text = "LOG OUT"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.stsNamaUser, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel2, Me.stsTanggal, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel4, Me.stsJam})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 758)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1386, 30)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(162, 25)
        Me.ToolStripStatusLabel1.Text = "Selamat Datang :"
        '
        'stsNamaUser
        '
        Me.stsNamaUser.Name = "stsNamaUser"
        Me.stsNamaUser.Size = New System.Drawing.Size(20, 25)
        Me.stsNamaUser.Text = "-"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(17, 25)
        Me.ToolStripStatusLabel3.Text = " "
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Image = CType(resources.GetObject("ToolStripStatusLabel2.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(16, 25)
        '
        'stsTanggal
        '
        Me.stsTanggal.Name = "stsTanggal"
        Me.stsTanggal.Size = New System.Drawing.Size(27, 25)
        Me.stsTanggal.Text = "   "
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(17, 25)
        Me.ToolStripStatusLabel5.Text = " "
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Image = CType(resources.GetObject("ToolStripStatusLabel4.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(16, 25)
        '
        'stsJam
        '
        Me.stsJam.Name = "stsJam"
        Me.stsJam.Size = New System.Drawing.Size(20, 25)
        Me.stsJam.Text = "-"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 172)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1386, 561)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'FMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1386, 788)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MASTERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TRANSAKSIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LAPORANToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GANTIPASSWORDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents stsNamaUser As ToolStripStatusLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents KARYAWANToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PAKETToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents stsTanggal As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents stsJam As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PELANGGANToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PEMBAYARANToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents USERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HARIANToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BULANANToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
