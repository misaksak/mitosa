<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPemesanan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPemesanan))
        Me.lblHotel = New System.Windows.Forms.Label()
        Me.lblpesan = New System.Windows.Forms.Label()
        Me.btnpesan = New System.Windows.Forms.Button()
        Me.GBPemesanan = New System.Windows.Forms.GroupBox()
        Me.cbbln = New System.Windows.Forms.ComboBox()
        Me.numtanggal = New System.Windows.Forms.NumericUpDown()
        Me.cbthn = New System.Windows.Forms.ComboBox()
        Me.cbtahun = New System.Windows.Forms.ComboBox()
        Me.cbbulan = New System.Windows.Forms.ComboBox()
        Me.cbtanggal = New System.Windows.Forms.NumericUpDown()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cbKartu = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cbjumlahkamar = New System.Windows.Forms.ComboBox()
        Me.rbkeredit = New System.Windows.Forms.RadioButton()
        Me.rbtunai = New System.Windows.Forms.RadioButton()
        Me.rbperempuan = New System.Windows.Forms.RadioButton()
        Me.rblaki = New System.Windows.Forms.RadioButton()
        Me.txtnotelpon = New System.Windows.Forms.TextBox()
        Me.cbtipekamar = New System.Windows.Forms.ComboBox()
        Me.txtNoidentitas = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.lbltamu = New System.Windows.Forms.Label()
        Me.lbljumlahkamar = New System.Windows.Forms.Label()
        Me.lblpembayaran = New System.Windows.Forms.Label()
        Me.lbltanggalcekout = New System.Windows.Forms.Label()
        Me.lbltanggalcek = New System.Windows.Forms.Label()
        Me.lbltipekamar = New System.Windows.Forms.Label()
        Me.lbltelp = New System.Windows.Forms.Label()
        Me.lbljeniskelamin = New System.Windows.Forms.Label()
        Me.lbllahir = New System.Windows.Forms.Label()
        Me.lblidentitas = New System.Windows.Forms.Label()
        Me.lblkartu = New System.Windows.Forms.Label()
        Me.lblpemesanan = New System.Windows.Forms.Label()
        Me.lnkkembali = New System.Windows.Forms.LinkLabel()
        Me.GBPemesanan.SuspendLayout()
        CType(Me.numtanggal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbtanggal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHotel
        '
        Me.lblHotel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHotel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHotel.ForeColor = System.Drawing.Color.Navy
        Me.lblHotel.Location = New System.Drawing.Point(167, 0)
        Me.lblHotel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHotel.Name = "lblHotel"
        Me.lblHotel.Size = New System.Drawing.Size(268, 28)
        Me.lblHotel.TabIndex = 0
        Me.lblHotel.Text = "HOTEL "
        Me.lblHotel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblpesan
        '
        Me.lblpesan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblpesan.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpesan.Location = New System.Drawing.Point(11, 45)
        Me.lblpesan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpesan.Name = "lblpesan"
        Me.lblpesan.Size = New System.Drawing.Size(167, 29)
        Me.lblpesan.TabIndex = 0
        Me.lblpesan.Text = "Pemesanan"
        '
        'btnpesan
        '
        Me.btnpesan.Location = New System.Drawing.Point(452, 550)
        Me.btnpesan.Margin = New System.Windows.Forms.Padding(4)
        Me.btnpesan.Name = "btnpesan"
        Me.btnpesan.Size = New System.Drawing.Size(113, 26)
        Me.btnpesan.TabIndex = 21
        Me.btnpesan.Text = "Pesan"
        Me.btnpesan.UseVisualStyleBackColor = True
        '
        'GBPemesanan
        '
        Me.GBPemesanan.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.GBPemesanan.Controls.Add(Me.cbbln)
        Me.GBPemesanan.Controls.Add(Me.numtanggal)
        Me.GBPemesanan.Controls.Add(Me.cbthn)
        Me.GBPemesanan.Controls.Add(Me.cbtahun)
        Me.GBPemesanan.Controls.Add(Me.cbbulan)
        Me.GBPemesanan.Controls.Add(Me.cbtanggal)
        Me.GBPemesanan.Controls.Add(Me.Panel1)
        Me.GBPemesanan.Controls.Add(Me.cbKartu)
        Me.GBPemesanan.Controls.Add(Me.DateTimePicker1)
        Me.GBPemesanan.Controls.Add(Me.cbjumlahkamar)
        Me.GBPemesanan.Controls.Add(Me.rbkeredit)
        Me.GBPemesanan.Controls.Add(Me.rbtunai)
        Me.GBPemesanan.Controls.Add(Me.rbperempuan)
        Me.GBPemesanan.Controls.Add(Me.rblaki)
        Me.GBPemesanan.Controls.Add(Me.txtnotelpon)
        Me.GBPemesanan.Controls.Add(Me.cbtipekamar)
        Me.GBPemesanan.Controls.Add(Me.txtNoidentitas)
        Me.GBPemesanan.Controls.Add(Me.txtnama)
        Me.GBPemesanan.Controls.Add(Me.lbltamu)
        Me.GBPemesanan.Controls.Add(Me.lbljumlahkamar)
        Me.GBPemesanan.Controls.Add(Me.lblpembayaran)
        Me.GBPemesanan.Controls.Add(Me.lbltanggalcekout)
        Me.GBPemesanan.Controls.Add(Me.lbltanggalcek)
        Me.GBPemesanan.Controls.Add(Me.lbltipekamar)
        Me.GBPemesanan.Controls.Add(Me.lbltelp)
        Me.GBPemesanan.Controls.Add(Me.lbljeniskelamin)
        Me.GBPemesanan.Controls.Add(Me.lbllahir)
        Me.GBPemesanan.Controls.Add(Me.lblidentitas)
        Me.GBPemesanan.Controls.Add(Me.lblkartu)
        Me.GBPemesanan.Controls.Add(Me.lblpemesanan)
        Me.GBPemesanan.Location = New System.Drawing.Point(8, 75)
        Me.GBPemesanan.Margin = New System.Windows.Forms.Padding(4)
        Me.GBPemesanan.Name = "GBPemesanan"
        Me.GBPemesanan.Padding = New System.Windows.Forms.Padding(4)
        Me.GBPemesanan.Size = New System.Drawing.Size(557, 467)
        Me.GBPemesanan.TabIndex = 0
        Me.GBPemesanan.TabStop = False
        '
        'cbbln
        '
        Me.cbbln.FormattingEnabled = True
        Me.cbbln.Items.AddRange(New Object() {"Januari", "Februari", "Maret ", "April ", "Mei ", "Juni", "Juli ", "Agustus", "September", "November", "Desember"})
        Me.cbbln.Location = New System.Drawing.Point(306, 388)
        Me.cbbln.Name = "cbbln"
        Me.cbbln.Size = New System.Drawing.Size(94, 21)
        Me.cbbln.TabIndex = 17
        '
        'numtanggal
        '
        Me.numtanggal.Location = New System.Drawing.Point(248, 389)
        Me.numtanggal.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.numtanggal.Name = "numtanggal"
        Me.numtanggal.Size = New System.Drawing.Size(52, 20)
        Me.numtanggal.TabIndex = 16
        '
        'cbthn
        '
        Me.cbthn.FormattingEnabled = True
        Me.cbthn.Items.AddRange(New Object() {"1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960"})
        Me.cbthn.Location = New System.Drawing.Point(406, 388)
        Me.cbthn.Name = "cbthn"
        Me.cbthn.Size = New System.Drawing.Size(59, 21)
        Me.cbthn.TabIndex = 18
        '
        'cbtahun
        '
        Me.cbtahun.FormattingEnabled = True
        Me.cbtahun.Items.AddRange(New Object() {"1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960"})
        Me.cbtahun.Location = New System.Drawing.Point(406, 352)
        Me.cbtahun.Name = "cbtahun"
        Me.cbtahun.Size = New System.Drawing.Size(59, 21)
        Me.cbtahun.TabIndex = 15
        '
        'cbbulan
        '
        Me.cbbulan.FormattingEnabled = True
        Me.cbbulan.Items.AddRange(New Object() {"Januari", "Februari", "Maret ", "April ", "Mei ", "Juni", "Juli ", "Agustus", "September", "November", "Desember"})
        Me.cbbulan.Location = New System.Drawing.Point(306, 352)
        Me.cbbulan.Name = "cbbulan"
        Me.cbbulan.Size = New System.Drawing.Size(94, 21)
        Me.cbbulan.TabIndex = 14
        '
        'cbtanggal
        '
        Me.cbtanggal.Location = New System.Drawing.Point(248, 353)
        Me.cbtanggal.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.cbtanggal.Name = "cbtanggal"
        Me.cbtanggal.Size = New System.Drawing.Size(52, 20)
        Me.cbtanggal.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CheckBox3)
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Location = New System.Drawing.Point(248, 274)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(279, 24)
        Me.Panel1.TabIndex = 45
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckBox3.Location = New System.Drawing.Point(108, 3)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(38, 17)
        Me.CheckBox3.TabIndex = 10
        Me.CheckBox3.Text = "10"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckBox2.Location = New System.Drawing.Point(195, 3)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(38, 17)
        Me.CheckBox2.TabIndex = 11
        Me.CheckBox2.Text = "11"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckBox1.Location = New System.Drawing.Point(21, 3)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(32, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "9"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cbKartu
        '
        Me.cbKartu.FormattingEnabled = True
        Me.cbKartu.Items.AddRange(New Object() {"KTP", "SIM"})
        Me.cbKartu.Location = New System.Drawing.Point(248, 66)
        Me.cbKartu.Margin = New System.Windows.Forms.Padding(4)
        Me.cbKartu.Name = "cbKartu"
        Me.cbKartu.Size = New System.Drawing.Size(64, 21)
        Me.cbKartu.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(248, 134)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'cbjumlahkamar
        '
        Me.cbjumlahkamar.FormattingEnabled = True
        Me.cbjumlahkamar.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cbjumlahkamar.Location = New System.Drawing.Point(248, 241)
        Me.cbjumlahkamar.Margin = New System.Windows.Forms.Padding(4)
        Me.cbjumlahkamar.Name = "cbjumlahkamar"
        Me.cbjumlahkamar.Size = New System.Drawing.Size(57, 21)
        Me.cbjumlahkamar.TabIndex = 8
        '
        'rbkeredit
        '
        Me.rbkeredit.AutoSize = True
        Me.rbkeredit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbkeredit.Location = New System.Drawing.Point(392, 428)
        Me.rbkeredit.Margin = New System.Windows.Forms.Padding(4)
        Me.rbkeredit.Name = "rbkeredit"
        Me.rbkeredit.Size = New System.Drawing.Size(52, 17)
        Me.rbkeredit.TabIndex = 20
        Me.rbkeredit.TabStop = True
        Me.rbkeredit.Text = "Kredit"
        Me.rbkeredit.UseVisualStyleBackColor = True
        '
        'rbtunai
        '
        Me.rbtunai.AutoSize = True
        Me.rbtunai.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbtunai.Location = New System.Drawing.Point(248, 428)
        Me.rbtunai.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtunai.Name = "rbtunai"
        Me.rbtunai.Size = New System.Drawing.Size(52, 17)
        Me.rbtunai.TabIndex = 19
        Me.rbtunai.TabStop = True
        Me.rbtunai.Text = "Tunai"
        Me.rbtunai.UseVisualStyleBackColor = True
        '
        'rbperempuan
        '
        Me.rbperempuan.AutoSize = True
        Me.rbperempuan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbperempuan.Location = New System.Drawing.Point(372, 170)
        Me.rbperempuan.Margin = New System.Windows.Forms.Padding(4)
        Me.rbperempuan.Name = "rbperempuan"
        Me.rbperempuan.Size = New System.Drawing.Size(79, 17)
        Me.rbperempuan.TabIndex = 6
        Me.rbperempuan.TabStop = True
        Me.rbperempuan.Text = "Perempuan"
        Me.rbperempuan.UseVisualStyleBackColor = True
        '
        'rblaki
        '
        Me.rblaki.AutoSize = True
        Me.rblaki.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rblaki.Location = New System.Drawing.Point(248, 172)
        Me.rblaki.Margin = New System.Windows.Forms.Padding(4)
        Me.rblaki.Name = "rblaki"
        Me.rblaki.Size = New System.Drawing.Size(64, 17)
        Me.rblaki.TabIndex = 5
        Me.rblaki.TabStop = True
        Me.rblaki.Text = "Laki-laki"
        Me.rblaki.UseVisualStyleBackColor = True
        '
        'txtnotelpon
        '
        Me.txtnotelpon.Location = New System.Drawing.Point(248, 208)
        Me.txtnotelpon.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnotelpon.Name = "txtnotelpon"
        Me.txtnotelpon.Size = New System.Drawing.Size(217, 20)
        Me.txtnotelpon.TabIndex = 7
        '
        'cbtipekamar
        '
        Me.cbtipekamar.FormattingEnabled = True
        Me.cbtipekamar.ItemHeight = 13
        Me.cbtipekamar.Items.AddRange(New Object() {"EKONOMI", "PREMIUM", "EKSLUSIVE"})
        Me.cbtipekamar.Location = New System.Drawing.Point(248, 313)
        Me.cbtipekamar.Margin = New System.Windows.Forms.Padding(4)
        Me.cbtipekamar.Name = "cbtipekamar"
        Me.cbtipekamar.Size = New System.Drawing.Size(279, 21)
        Me.cbtipekamar.TabIndex = 12
        '
        'txtNoidentitas
        '
        Me.txtNoidentitas.Location = New System.Drawing.Point(248, 98)
        Me.txtNoidentitas.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNoidentitas.Name = "txtNoidentitas"
        Me.txtNoidentitas.Size = New System.Drawing.Size(288, 20)
        Me.txtNoidentitas.TabIndex = 3
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(248, 30)
        Me.txtnama.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(288, 20)
        Me.txtnama.TabIndex = 1
        '
        'lbltamu
        '
        Me.lbltamu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbltamu.Location = New System.Drawing.Point(29, 274)
        Me.lbltamu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltamu.Name = "lbltamu"
        Me.lbltamu.Size = New System.Drawing.Size(116, 22)
        Me.lbltamu.TabIndex = 10
        Me.lbltamu.Text = "Jumlah Tamu"
        '
        'lbljumlahkamar
        '
        Me.lbljumlahkamar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbljumlahkamar.Location = New System.Drawing.Point(29, 241)
        Me.lbljumlahkamar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbljumlahkamar.Name = "lbljumlahkamar"
        Me.lbljumlahkamar.Size = New System.Drawing.Size(116, 22)
        Me.lbljumlahkamar.TabIndex = 9
        Me.lbljumlahkamar.Text = "Jumlah Kamar"
        '
        'lblpembayaran
        '
        Me.lblpembayaran.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblpembayaran.Location = New System.Drawing.Point(29, 430)
        Me.lblpembayaran.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpembayaran.Name = "lblpembayaran"
        Me.lblpembayaran.Size = New System.Drawing.Size(116, 22)
        Me.lblpembayaran.TabIndex = 8
        Me.lblpembayaran.Text = "Pembayaran"
        '
        'lbltanggalcekout
        '
        Me.lbltanggalcekout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbltanggalcekout.Location = New System.Drawing.Point(29, 391)
        Me.lbltanggalcekout.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltanggalcekout.Name = "lbltanggalcekout"
        Me.lbltanggalcekout.Size = New System.Drawing.Size(116, 22)
        Me.lbltanggalcekout.TabIndex = 7
        Me.lbltanggalcekout.Text = "Tanggal Check Out"
        '
        'lbltanggalcek
        '
        Me.lbltanggalcek.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbltanggalcek.Location = New System.Drawing.Point(29, 355)
        Me.lbltanggalcek.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltanggalcek.Name = "lbltanggalcek"
        Me.lbltanggalcek.Size = New System.Drawing.Size(116, 22)
        Me.lbltanggalcek.TabIndex = 7
        Me.lbltanggalcek.Text = "Tanggal Chek In"
        '
        'lbltipekamar
        '
        Me.lbltipekamar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbltipekamar.Location = New System.Drawing.Point(31, 316)
        Me.lbltipekamar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltipekamar.Name = "lbltipekamar"
        Me.lbltipekamar.Size = New System.Drawing.Size(116, 22)
        Me.lbltipekamar.TabIndex = 6
        Me.lbltipekamar.Text = "Tipe Kamar"
        '
        'lbltelp
        '
        Me.lbltelp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbltelp.Location = New System.Drawing.Point(31, 208)
        Me.lbltelp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltelp.Name = "lbltelp"
        Me.lbltelp.Size = New System.Drawing.Size(116, 22)
        Me.lbltelp.TabIndex = 5
        Me.lbltelp.Text = "No. Telp/HP"
        '
        'lbljeniskelamin
        '
        Me.lbljeniskelamin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbljeniskelamin.Location = New System.Drawing.Point(31, 172)
        Me.lbljeniskelamin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbljeniskelamin.Name = "lbljeniskelamin"
        Me.lbljeniskelamin.Size = New System.Drawing.Size(116, 22)
        Me.lbljeniskelamin.TabIndex = 4
        Me.lbljeniskelamin.Text = "Jenis Kelamin"
        '
        'lbllahir
        '
        Me.lbllahir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbllahir.Location = New System.Drawing.Point(31, 140)
        Me.lbllahir.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbllahir.Name = "lbllahir"
        Me.lbllahir.Size = New System.Drawing.Size(116, 22)
        Me.lbllahir.TabIndex = 3
        Me.lbllahir.Text = "Tanggal Lahir"
        '
        'lblidentitas
        '
        Me.lblidentitas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblidentitas.Location = New System.Drawing.Point(31, 101)
        Me.lblidentitas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblidentitas.Name = "lblidentitas"
        Me.lblidentitas.Size = New System.Drawing.Size(116, 22)
        Me.lblidentitas.TabIndex = 2
        Me.lblidentitas.Text = "No. Identitas"
        '
        'lblkartu
        '
        Me.lblkartu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblkartu.Location = New System.Drawing.Point(29, 69)
        Me.lblkartu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblkartu.Name = "lblkartu"
        Me.lblkartu.Size = New System.Drawing.Size(211, 22)
        Me.lblkartu.TabIndex = 1
        Me.lblkartu.Text = "Kartu Identitas (yang digunakan)"
        '
        'lblpemesanan
        '
        Me.lblpemesanan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblpemesanan.Location = New System.Drawing.Point(31, 34)
        Me.lblpemesanan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpemesanan.Name = "lblpemesanan"
        Me.lblpemesanan.Size = New System.Drawing.Size(116, 22)
        Me.lblpemesanan.TabIndex = 0
        Me.lblpemesanan.Text = "Nama Pemesan"
        '
        'lnkkembali
        '
        Me.lnkkembali.AutoSize = True
        Me.lnkkembali.Location = New System.Drawing.Point(12, 557)
        Me.lnkkembali.Name = "lnkkembali"
        Me.lnkkembali.Size = New System.Drawing.Size(44, 13)
        Me.lnkkembali.TabIndex = 22
        Me.lnkkembali.TabStop = True
        Me.lnkkembali.Text = "Kembali"
        '
        'FormPemesanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.imk_2.My.Resources.Resources.cool_black_and_white_designs_3387_hd_wallpapers_640x480
        Me.ClientSize = New System.Drawing.Size(576, 582)
        Me.Controls.Add(Me.lnkkembali)
        Me.Controls.Add(Me.lblHotel)
        Me.Controls.Add(Me.lblpesan)
        Me.Controls.Add(Me.btnpesan)
        Me.Controls.Add(Me.GBPemesanan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPemesanan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Form Pemesanan"
        Me.GBPemesanan.ResumeLayout(False)
        Me.GBPemesanan.PerformLayout()
        CType(Me.numtanggal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbtanggal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHotel As System.Windows.Forms.Label
    Friend WithEvents lblpesan As System.Windows.Forms.Label
    Friend WithEvents btnpesan As System.Windows.Forms.Button
    Friend WithEvents GBPemesanan As System.Windows.Forms.GroupBox
    Friend WithEvents cbjumlahkamar As System.Windows.Forms.ComboBox
    Friend WithEvents rbkeredit As System.Windows.Forms.RadioButton
    Friend WithEvents rbtunai As System.Windows.Forms.RadioButton
    Friend WithEvents rbperempuan As System.Windows.Forms.RadioButton
    Friend WithEvents rblaki As System.Windows.Forms.RadioButton
    Friend WithEvents txtnotelpon As System.Windows.Forms.TextBox
    Friend WithEvents cbtipekamar As System.Windows.Forms.ComboBox
    Friend WithEvents txtNoidentitas As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents lbltamu As System.Windows.Forms.Label
    Friend WithEvents lbljumlahkamar As System.Windows.Forms.Label
    Friend WithEvents lblpembayaran As System.Windows.Forms.Label
    Friend WithEvents lbltanggalcekout As System.Windows.Forms.Label
    Friend WithEvents lbltanggalcek As System.Windows.Forms.Label
    Friend WithEvents lbltipekamar As System.Windows.Forms.Label
    Friend WithEvents lbltelp As System.Windows.Forms.Label
    Friend WithEvents lbljeniskelamin As System.Windows.Forms.Label
    Friend WithEvents lbllahir As System.Windows.Forms.Label
    Friend WithEvents lblidentitas As System.Windows.Forms.Label
    Friend WithEvents lblkartu As System.Windows.Forms.Label
    Friend WithEvents lblpemesanan As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbKartu As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lnkkembali As System.Windows.Forms.LinkLabel
    Friend WithEvents cbtahun As System.Windows.Forms.ComboBox
    Friend WithEvents cbbulan As System.Windows.Forms.ComboBox
    Friend WithEvents cbtanggal As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbbln As System.Windows.Forms.ComboBox
    Friend WithEvents numtanggal As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbthn As System.Windows.Forms.ComboBox
End Class
