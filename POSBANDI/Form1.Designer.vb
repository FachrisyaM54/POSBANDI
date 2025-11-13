<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
		TabControl1 = New TabControl()
		TabPage1 = New TabPage()
		btnhapus = New Button()
		btnupdate = New Button()
		btnsimpan = New Button()
		cbnonaktif = New CheckBox()
		cbaktif = New CheckBox()
		tbdate = New DateTimePicker()
		DataGridView1 = New DataGridView()
		kdptgs = New TextBox()
		tbusia = New TextBox()
		tbtlp = New TextBox()
		tbalmt = New TextBox()
		tbnama = New TextBox()
		Label4 = New Label()
		Label2 = New Label()
		Label7 = New Label()
		Label6 = New Label()
		Label3 = New Label()
		Label5 = New Label()
		Label1 = New Label()
		Label8 = New Label()
		TabControl1.SuspendLayout()
		TabPage1.SuspendLayout()
		CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' TabControl1
		' 
		TabControl1.Controls.Add(TabPage1)
		TabControl1.Location = New Point(1, 10)
		TabControl1.Name = "TabControl1"
		TabControl1.SelectedIndex = 0
		TabControl1.Size = New Size(687, 668)
		TabControl1.TabIndex = 0
		' 
		' TabPage1
		' 
		TabPage1.Controls.Add(Label8)
		TabPage1.Controls.Add(btnhapus)
		TabPage1.Controls.Add(btnupdate)
		TabPage1.Controls.Add(btnsimpan)
		TabPage1.Controls.Add(cbnonaktif)
		TabPage1.Controls.Add(cbaktif)
		TabPage1.Controls.Add(tbdate)
		TabPage1.Controls.Add(DataGridView1)
		TabPage1.Controls.Add(kdptgs)
		TabPage1.Controls.Add(tbusia)
		TabPage1.Controls.Add(tbtlp)
		TabPage1.Controls.Add(tbalmt)
		TabPage1.Controls.Add(tbnama)
		TabPage1.Controls.Add(Label4)
		TabPage1.Controls.Add(Label2)
		TabPage1.Controls.Add(Label7)
		TabPage1.Controls.Add(Label6)
		TabPage1.Controls.Add(Label3)
		TabPage1.Controls.Add(Label5)
		TabPage1.Controls.Add(Label1)
		TabPage1.Location = New Point(4, 24)
		TabPage1.Name = "TabPage1"
		TabPage1.Padding = New Padding(3, 3, 3, 3)
		TabPage1.Size = New Size(679, 640)
		TabPage1.TabIndex = 0
		TabPage1.Text = "Manajemen Petugas"
		TabPage1.UseVisualStyleBackColor = True
		' 
		' btnhapus
		' 
		btnhapus.Location = New Point(544, 170)
		btnhapus.Margin = New Padding(3, 2, 3, 2)
		btnhapus.Name = "btnhapus"
		btnhapus.Size = New Size(82, 22)
		btnhapus.TabIndex = 11
		btnhapus.Text = "HAPUS"
		btnhapus.UseVisualStyleBackColor = True
		' 
		' btnupdate
		' 
		btnupdate.Location = New Point(457, 170)
		btnupdate.Margin = New Padding(3, 2, 3, 2)
		btnupdate.Name = "btnupdate"
		btnupdate.Size = New Size(82, 22)
		btnupdate.TabIndex = 11
		btnupdate.Text = "UDPATE"
		btnupdate.UseVisualStyleBackColor = True
		' 
		' btnsimpan
		' 
		btnsimpan.Location = New Point(369, 170)
		btnsimpan.Margin = New Padding(3, 2, 3, 2)
		btnsimpan.Name = "btnsimpan"
		btnsimpan.Size = New Size(82, 22)
		btnsimpan.TabIndex = 11
		btnsimpan.Text = "SIMPAN"
		btnsimpan.UseVisualStyleBackColor = True
		' 
		' cbnonaktif
		' 
		cbnonaktif.AutoSize = True
		cbnonaktif.Location = New Point(484, 137)
		cbnonaktif.Margin = New Padding(3, 2, 3, 2)
		cbnonaktif.Name = "cbnonaktif"
		cbnonaktif.Size = New Size(74, 19)
		cbnonaktif.TabIndex = 10
		cbnonaktif.Text = "NonAktif"
		cbnonaktif.UseVisualStyleBackColor = True
		' 
		' cbaktif
		' 
		cbaktif.AutoSize = True
		cbaktif.Location = New Point(424, 137)
		cbaktif.Margin = New Padding(3, 2, 3, 2)
		cbaktif.Name = "cbaktif"
		cbaktif.Size = New Size(51, 19)
		cbaktif.TabIndex = 10
		cbaktif.Text = "Aktif"
		cbaktif.UseVisualStyleBackColor = True
		' 
		' tbdate
		' 
		tbdate.Location = New Point(421, 96)
		tbdate.Margin = New Padding(3, 2, 3, 2)
		tbdate.Name = "tbdate"
		tbdate.Size = New Size(178, 23)
		tbdate.TabIndex = 9
		' 
		' DataGridView1
		' 
		DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridView1.Location = New Point(18, 212)
		DataGridView1.Name = "DataGridView1"
		DataGridView1.RowHeadersWidth = 51
		DataGridView1.Size = New Size(642, 164)
		DataGridView1.TabIndex = 8
		' 
		' kdptgs
		' 
		kdptgs.Location = New Point(421, 60)
		kdptgs.Name = "kdptgs"
		kdptgs.ReadOnly = True
		kdptgs.Size = New Size(178, 23)
		kdptgs.TabIndex = 7
		' 
		' tbusia
		' 
		tbusia.Location = New Point(115, 90)
		tbusia.Name = "tbusia"
		tbusia.Size = New Size(175, 23)
		tbusia.TabIndex = 6
		' 
		' tbtlp
		' 
		tbtlp.Location = New Point(115, 126)
		tbtlp.Name = "tbtlp"
		tbtlp.Size = New Size(175, 23)
		tbtlp.TabIndex = 5
		' 
		' tbalmt
		' 
		tbalmt.Location = New Point(115, 158)
		tbalmt.Name = "tbalmt"
		tbalmt.Size = New Size(175, 23)
		tbalmt.TabIndex = 5
		' 
		' tbnama
		' 
		tbnama.Location = New Point(115, 60)
		tbnama.Name = "tbnama"
		tbnama.Size = New Size(175, 23)
		tbnama.TabIndex = 4
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Location = New Point(329, 62)
		Label4.Name = "Label4"
		Label4.Size = New Size(79, 15)
		Label4.TabIndex = 3
		Label4.Text = "Kode Petugas"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(373, 137)
		Label2.Name = "Label2"
		Label2.Size = New Size(39, 15)
		Label2.TabIndex = 2
		Label2.Text = "Status"
		' 
		' Label7
		' 
		Label7.AutoSize = True
		Label7.Location = New Point(77, 92)
		Label7.Name = "Label7"
		Label7.Size = New Size(29, 15)
		Label7.TabIndex = 2
		Label7.Text = "Usia"
		' 
		' Label6
		' 
		Label6.AutoSize = True
		Label6.Location = New Point(55, 128)
		Label6.Name = "Label6"
		Label6.Size = New Size(48, 15)
		Label6.TabIndex = 1
		Label6.Text = "Telepon"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Location = New Point(343, 100)
		Label3.Name = "Label3"
		Label3.Size = New Size(68, 15)
		Label3.TabIndex = 2
		Label3.Text = "Pembuatan"
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.Location = New Point(60, 161)
		Label5.Name = "Label5"
		Label5.Size = New Size(45, 15)
		Label5.TabIndex = 1
		Label5.Text = "Alamat"
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(18, 65)
		Label1.Name = "Label1"
		Label1.Size = New Size(84, 15)
		Label1.TabIndex = 0
		Label1.Text = "Nama Petugas"
		' 
		' Label8
		' 
		Label8.AutoSize = True
		Label8.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label8.Location = New Point(250, 14)
		Label8.Name = "Label8"
		Label8.Size = New Size(201, 25)
		Label8.TabIndex = 12
		Label8.Text = "Manajemen Petugas"
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(697, 432)
		Controls.Add(TabControl1)
		Name = "Form1"
		Text = "Form1"
		TabControl1.ResumeLayout(False)
		TabPage1.ResumeLayout(False)
		TabPage1.PerformLayout()
		CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
	End Sub

	Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbIdPetugas As TextBox
    Friend WithEvents tbNamaPetugas As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents kdptgs As TextBox
    Friend WithEvents tbusia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbdate As DateTimePicker
    Friend WithEvents cbnonaktif As CheckBox
    Friend WithEvents cbaktif As CheckBox
    Friend WithEvents tbtlp As TextBox
    Friend WithEvents tbalmt As TextBox
    Friend WithEvents tbnama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btnupdate As Button
	Friend WithEvents Label8 As Label

End Class
