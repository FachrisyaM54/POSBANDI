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
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Location = New Point(1, 13)
        TabControl1.Margin = New Padding(3, 4, 3, 4)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(785, 891)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
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
        TabPage1.Location = New Point(4, 29)
        TabPage1.Margin = New Padding(3, 4, 3, 4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3, 4, 3, 4)
        TabPage1.Size = New Size(777, 858)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Manajemen Petugas"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' btnhapus
        ' 
        btnhapus.Location = New Point(622, 173)
        btnhapus.Name = "btnhapus"
        btnhapus.Size = New Size(94, 29)
        btnhapus.TabIndex = 11
        btnhapus.Text = "HAPUS"
        btnhapus.UseVisualStyleBackColor = True
        ' 
        ' btnupdate
        ' 
        btnupdate.Location = New Point(522, 173)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(94, 29)
        btnupdate.TabIndex = 11
        btnupdate.Text = "UDPATE"
        btnupdate.UseVisualStyleBackColor = True
        ' 
        ' btnsimpan
        ' 
        btnsimpan.Location = New Point(422, 173)
        btnsimpan.Name = "btnsimpan"
        btnsimpan.Size = New Size(94, 29)
        btnsimpan.TabIndex = 11
        btnsimpan.Text = "SIMPAN"
        btnsimpan.UseVisualStyleBackColor = True
        ' 
        ' cbnonaktif
        ' 
        cbnonaktif.AutoSize = True
        cbnonaktif.Location = New Point(553, 129)
        cbnonaktif.Name = "cbnonaktif"
        cbnonaktif.Size = New Size(90, 24)
        cbnonaktif.TabIndex = 10
        cbnonaktif.Text = "NonAktif"
        cbnonaktif.UseVisualStyleBackColor = True
        ' 
        ' cbaktif
        ' 
        cbaktif.AutoSize = True
        cbaktif.Location = New Point(485, 129)
        cbaktif.Name = "cbaktif"
        cbaktif.Size = New Size(62, 24)
        cbaktif.TabIndex = 10
        cbaktif.Text = "Aktif"
        cbaktif.UseVisualStyleBackColor = True
        ' 
        ' tbdate
        ' 
        tbdate.Location = New Point(481, 75)
        tbdate.Name = "tbdate"
        tbdate.Size = New Size(203, 27)
        tbdate.TabIndex = 9
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(21, 220)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(734, 219)
        DataGridView1.TabIndex = 8
        ' 
        ' kdptgs
        ' 
        kdptgs.Location = New Point(481, 27)
        kdptgs.Margin = New Padding(3, 4, 3, 4)
        kdptgs.Name = "kdptgs"
        kdptgs.ReadOnly = True
        kdptgs.Size = New Size(203, 27)
        kdptgs.TabIndex = 7
        ' 
        ' tbusia
        ' 
        tbusia.Location = New Point(131, 66)
        tbusia.Margin = New Padding(3, 4, 3, 4)
        tbusia.Name = "tbusia"
        tbusia.Size = New Size(199, 27)
        tbusia.TabIndex = 6
        ' 
        ' tbtlp
        ' 
        tbtlp.Location = New Point(131, 115)
        tbtlp.Margin = New Padding(3, 4, 3, 4)
        tbtlp.Name = "tbtlp"
        tbtlp.Size = New Size(199, 27)
        tbtlp.TabIndex = 5
        ' 
        ' tbalmt
        ' 
        tbalmt.Location = New Point(131, 158)
        tbalmt.Margin = New Padding(3, 4, 3, 4)
        tbalmt.Name = "tbalmt"
        tbalmt.Size = New Size(199, 27)
        tbalmt.TabIndex = 5
        ' 
        ' tbnama
        ' 
        tbnama.Location = New Point(131, 27)
        tbnama.Margin = New Padding(3, 4, 3, 4)
        tbnama.Name = "tbnama"
        tbnama.Size = New Size(199, 27)
        tbnama.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(376, 30)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 20)
        Label4.TabIndex = 3
        Label4.Text = "Kode Petugas"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(426, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 2
        Label2.Text = "Status"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(88, 69)
        Label7.Name = "Label7"
        Label7.Size = New Size(37, 20)
        Label7.TabIndex = 2
        Label7.Text = "Usia"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(63, 118)
        Label6.Name = "Label6"
        Label6.Size = New Size(62, 20)
        Label6.TabIndex = 1
        Label6.Text = "Telepon"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(392, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 20)
        Label3.TabIndex = 2
        Label3.Text = "Pembuatan"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(68, 161)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 20)
        Label5.TabIndex = 1
        Label5.Text = "Alamat"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nama Petugas"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(797, 576)
        Controls.Add(TabControl1)
        Margin = New Padding(3, 4, 3, 4)
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

End Class
