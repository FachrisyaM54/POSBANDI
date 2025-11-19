<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Manajemenpetugas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Me.mnjptg = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.rbnonaktif = New System.Windows.Forms.RadioButton()
        Me.rbaktif = New System.Windows.Forms.RadioButton()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnbaru = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.tbdate = New System.Windows.Forms.DateTimePicker()
        Me.dgvpetugas = New System.Windows.Forms.DataGridView()
        Me.kdptgs = New System.Windows.Forms.TextBox()
        Me.tbusia = New System.Windows.Forms.TextBox()
        Me.tbtlp = New System.Windows.Forms.TextBox()
        Me.tbalmt = New System.Windows.Forms.TextBox()
        Me.tbnama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.tbtggl = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnsmpn = New System.Windows.Forms.Button()
        Me.btbaru = New System.Windows.Forms.Button()
        Me.btnhps = New System.Windows.Forms.Button()
        Me.tblok = New System.Windows.Forms.TextBox()
        Me.tbjammulai = New System.Windows.Forms.TextBox()
        Me.tbjamselesai = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tbptgs = New System.Windows.Forms.TextBox()
        Me.tbketerangan = New System.Windows.Forms.TextBox()
        Me.btnupdt = New System.Windows.Forms.Button()
        Me.mnjptg.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvpetugas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnjptg
        '
        Me.mnjptg.Controls.Add(Me.TabPage1)
        Me.mnjptg.Controls.Add(Me.TabPage3)
        Me.mnjptg.Location = New System.Drawing.Point(1, 10)
        Me.mnjptg.Name = "mnjptg"
        Me.mnjptg.SelectedIndex = 0
        Me.mnjptg.Size = New System.Drawing.Size(785, 713)
        Me.mnjptg.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.rbnonaktif)
        Me.TabPage1.Controls.Add(Me.rbaktif)
        Me.TabPage1.Controls.Add(Me.btnhapus)
        Me.TabPage1.Controls.Add(Me.btnupdate)
        Me.TabPage1.Controls.Add(Me.btnbaru)
        Me.TabPage1.Controls.Add(Me.btnsimpan)
        Me.TabPage1.Controls.Add(Me.tbdate)
        Me.TabPage1.Controls.Add(Me.dgvpetugas)
        Me.TabPage1.Controls.Add(Me.kdptgs)
        Me.TabPage1.Controls.Add(Me.tbusia)
        Me.TabPage1.Controls.Add(Me.tbtlp)
        Me.TabPage1.Controls.Add(Me.tbalmt)
        Me.TabPage1.Controls.Add(Me.tbnama)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage1.Size = New System.Drawing.Size(777, 684)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Manajemen Petugas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'rbnonaktif
        '
        Me.rbnonaktif.AutoSize = True
        Me.rbnonaktif.Location = New System.Drawing.Point(548, 107)
        Me.rbnonaktif.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbnonaktif.Name = "rbnonaktif"
        Me.rbnonaktif.Size = New System.Drawing.Size(81, 20)
        Me.rbnonaktif.TabIndex = 12
        Me.rbnonaktif.TabStop = True
        Me.rbnonaktif.Text = "Non Aktif"
        Me.rbnonaktif.UseVisualStyleBackColor = True
        '
        'rbaktif
        '
        Me.rbaktif.AutoSize = True
        Me.rbaktif.Location = New System.Drawing.Point(481, 106)
        Me.rbaktif.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbaktif.Name = "rbaktif"
        Me.rbaktif.Size = New System.Drawing.Size(53, 20)
        Me.rbaktif.TabIndex = 12
        Me.rbaktif.TabStop = True
        Me.rbaktif.Text = "Aktif"
        Me.rbaktif.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(622, 146)
        Me.btnhapus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(94, 23)
        Me.btnhapus.TabIndex = 11
        Me.btnhapus.Text = "HAPUS"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(522, 146)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(94, 23)
        Me.btnupdate.TabIndex = 11
        Me.btnupdate.Text = "UDPATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnbaru
        '
        Me.btnbaru.Location = New System.Drawing.Point(322, 146)
        Me.btnbaru.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnbaru.Name = "btnbaru"
        Me.btnbaru.Size = New System.Drawing.Size(94, 23)
        Me.btnbaru.TabIndex = 11
        Me.btnbaru.Text = "BARU"
        Me.btnbaru.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(422, 146)
        Me.btnsimpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(94, 23)
        Me.btnsimpan.TabIndex = 11
        Me.btnsimpan.Text = "SIMPAN"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'tbdate
        '
        Me.tbdate.Location = New System.Drawing.Point(481, 60)
        Me.tbdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbdate.Name = "tbdate"
        Me.tbdate.Size = New System.Drawing.Size(203, 22)
        Me.tbdate.TabIndex = 9
        '
        'dgvpetugas
        '
        Me.dgvpetugas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpetugas.Location = New System.Drawing.Point(21, 176)
        Me.dgvpetugas.Name = "dgvpetugas"
        Me.dgvpetugas.RowHeadersWidth = 51
        Me.dgvpetugas.Size = New System.Drawing.Size(734, 175)
        Me.dgvpetugas.TabIndex = 8
        '
        'kdptgs
        '
        Me.kdptgs.Location = New System.Drawing.Point(481, 22)
        Me.kdptgs.Name = "kdptgs"
        Me.kdptgs.ReadOnly = True
        Me.kdptgs.Size = New System.Drawing.Size(203, 22)
        Me.kdptgs.TabIndex = 7
        '
        'tbusia
        '
        Me.tbusia.Location = New System.Drawing.Point(131, 53)
        Me.tbusia.Name = "tbusia"
        Me.tbusia.Size = New System.Drawing.Size(199, 22)
        Me.tbusia.TabIndex = 6
        '
        'tbtlp
        '
        Me.tbtlp.Location = New System.Drawing.Point(131, 92)
        Me.tbtlp.Name = "tbtlp"
        Me.tbtlp.Size = New System.Drawing.Size(199, 22)
        Me.tbtlp.TabIndex = 5
        '
        'tbalmt
        '
        Me.tbalmt.Location = New System.Drawing.Point(131, 126)
        Me.tbalmt.Name = "tbalmt"
        Me.tbalmt.Size = New System.Drawing.Size(199, 22)
        Me.tbalmt.TabIndex = 5
        '
        'tbnama
        '
        Me.tbnama.Location = New System.Drawing.Point(131, 22)
        Me.tbnama.Name = "tbnama"
        Me.tbnama.Size = New System.Drawing.Size(199, 22)
        Me.tbnama.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(376, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Kode Petugas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(426, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(88, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Usia"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(63, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Telepon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(392, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pembuatan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Alamat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Petugas"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DataGridView1)
        Me.TabPage3.Controls.Add(Me.btnupdt)
        Me.TabPage3.Controls.Add(Me.btnhps)
        Me.TabPage3.Controls.Add(Me.btbaru)
        Me.TabPage3.Controls.Add(Me.btnsmpn)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.tbjamselesai)
        Me.TabPage3.Controls.Add(Me.tbjammulai)
        Me.TabPage3.Controls.Add(Me.tbketerangan)
        Me.TabPage3.Controls.Add(Me.tbptgs)
        Me.TabPage3.Controls.Add(Me.tblok)
        Me.TabPage3.Controls.Add(Me.tbtggl)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(777, 684)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'tbtggl
        '
        Me.tbtggl.Location = New System.Drawing.Point(128, 30)
        Me.tbtggl.Name = "tbtggl"
        Me.tbtggl.Size = New System.Drawing.Size(129, 22)
        Me.tbtggl.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(49, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Tanggal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(60, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 16)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Lokasi"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(39, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 16)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Jam Mulai"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 16)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Jam Selesai"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(412, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 16)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Petugas"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(412, 82)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 16)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Keterangan"
        '
        'btnsmpn
        '
        Me.btnsmpn.Location = New System.Drawing.Point(347, 124)
        Me.btnsmpn.Name = "btnsmpn"
        Me.btnsmpn.Size = New System.Drawing.Size(75, 23)
        Me.btnsmpn.TabIndex = 2
        Me.btnsmpn.Text = "Simpan"
        Me.btnsmpn.UseVisualStyleBackColor = True
        '
        'btbaru
        '
        Me.btbaru.Location = New System.Drawing.Point(428, 124)
        Me.btbaru.Name = "btbaru"
        Me.btbaru.Size = New System.Drawing.Size(75, 23)
        Me.btbaru.TabIndex = 2
        Me.btbaru.Text = "Baru"
        Me.btbaru.UseVisualStyleBackColor = True
        '
        'btnhps
        '
        Me.btnhps.Location = New System.Drawing.Point(590, 124)
        Me.btnhps.Name = "btnhps"
        Me.btnhps.Size = New System.Drawing.Size(75, 23)
        Me.btnhps.TabIndex = 2
        Me.btnhps.Text = "Hapus"
        Me.btnhps.UseVisualStyleBackColor = True
        '
        'tblok
        '
        Me.tblok.Location = New System.Drawing.Point(127, 67)
        Me.tblok.Name = "tblok"
        Me.tblok.Size = New System.Drawing.Size(129, 22)
        Me.tblok.TabIndex = 0
        '
        'tbjammulai
        '
        Me.tbjammulai.Location = New System.Drawing.Point(127, 103)
        Me.tbjammulai.Name = "tbjammulai"
        Me.tbjammulai.Size = New System.Drawing.Size(129, 22)
        Me.tbjammulai.TabIndex = 0
        '
        'tbjamselesai
        '
        Me.tbjamselesai.Location = New System.Drawing.Point(127, 138)
        Me.tbjamselesai.Name = "tbjamselesai"
        Me.tbjamselesai.Size = New System.Drawing.Size(129, 22)
        Me.tbjamselesai.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(28, 186)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(637, 191)
        Me.DataGridView1.TabIndex = 3
        '
        'tbptgs
        '
        Me.tbptgs.Location = New System.Drawing.Point(509, 36)
        Me.tbptgs.Name = "tbptgs"
        Me.tbptgs.Size = New System.Drawing.Size(129, 22)
        Me.tbptgs.TabIndex = 0
        '
        'tbketerangan
        '
        Me.tbketerangan.Location = New System.Drawing.Point(509, 76)
        Me.tbketerangan.Name = "tbketerangan"
        Me.tbketerangan.Size = New System.Drawing.Size(129, 22)
        Me.tbketerangan.TabIndex = 0
        '
        'btnupdt
        '
        Me.btnupdt.Location = New System.Drawing.Point(509, 124)
        Me.btnupdt.Name = "btnupdt"
        Me.btnupdt.Size = New System.Drawing.Size(75, 23)
        Me.btnupdt.TabIndex = 2
        Me.btnupdt.Text = "Update"
        Me.btnupdt.UseVisualStyleBackColor = True
        '
        'Manajemenpetugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 461)
        Me.Controls.Add(Me.mnjptg)
        Me.Name = "Manajemenpetugas"
        Me.Text = "Form1"
        Me.mnjptg.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvpetugas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mnjptg As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbIdPetugas As TextBox
    Friend WithEvents tbNamaPetugas As TextBox
    Friend WithEvents dgvpetugas As DataGridView
    Friend WithEvents kdptgs As TextBox
    Friend WithEvents tbusia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbdate As DateTimePicker
    Friend WithEvents tbtlp As TextBox
    Friend WithEvents tbalmt As TextBox
    Friend WithEvents tbnama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnbaru As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents rbnonaktif As RadioButton
    Friend WithEvents rbaktif As RadioButton
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tbtggl As TextBox
    Friend WithEvents btnsmpn As Button
    Friend WithEvents btnhps As Button
    Friend WithEvents btbaru As Button
    Friend WithEvents tbjamselesai As TextBox
    Friend WithEvents tbjammulai As TextBox
    Friend WithEvents tblok As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tbketerangan As TextBox
    Friend WithEvents tbptgs As TextBox
    Friend WithEvents btnupdt As Button
End Class
