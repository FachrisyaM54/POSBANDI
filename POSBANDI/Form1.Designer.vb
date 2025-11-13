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
		tbIdPetugas = New TextBox()
		tbPassword = New TextBox()
		tbUsername = New TextBox()
		tbNamaPetugas = New TextBox()
		Label4 = New Label()
		Label3 = New Label()
		Label2 = New Label()
		Label1 = New Label()
		TabPage2 = New TabPage()
		DataGridView1 = New DataGridView()
		TabControl1.SuspendLayout()
		TabPage1.SuspendLayout()
		CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' TabControl1
		' 
		TabControl1.Controls.Add(TabPage1)
		TabControl1.Controls.Add(TabPage2)
		TabControl1.Location = New Point(1, 0)
		TabControl1.Name = "TabControl1"
		TabControl1.SelectedIndex = 0
		TabControl1.Size = New Size(802, 438)
		TabControl1.TabIndex = 0
		' 
		' TabPage1
		' 
		TabPage1.Controls.Add(DataGridView1)
		TabPage1.Controls.Add(tbIdPetugas)
		TabPage1.Controls.Add(tbPassword)
		TabPage1.Controls.Add(tbUsername)
		TabPage1.Controls.Add(tbNamaPetugas)
		TabPage1.Controls.Add(Label4)
		TabPage1.Controls.Add(Label3)
		TabPage1.Controls.Add(Label2)
		TabPage1.Controls.Add(Label1)
		TabPage1.Location = New Point(4, 24)
		TabPage1.Name = "TabPage1"
		TabPage1.Padding = New Padding(3)
		TabPage1.Size = New Size(794, 410)
		TabPage1.TabIndex = 0
		TabPage1.Text = "Manajemen Petugas"
		TabPage1.UseVisualStyleBackColor = True
		' 
		' tbIdPetugas
		' 
		tbIdPetugas.Location = New Point(435, 20)
		tbIdPetugas.Name = "tbIdPetugas"
		tbIdPetugas.ReadOnly = True
		tbIdPetugas.Size = New Size(128, 23)
		tbIdPetugas.TabIndex = 7
		' 
		' tbPassword
		' 
		tbPassword.Location = New Point(115, 97)
		tbPassword.Name = "tbPassword"
		tbPassword.Size = New Size(175, 23)
		tbPassword.TabIndex = 6
		' 
		' tbUsername
		' 
		tbUsername.Location = New Point(115, 58)
		tbUsername.Name = "tbUsername"
		tbUsername.Size = New Size(175, 23)
		tbUsername.TabIndex = 5
		' 
		' tbNamaPetugas
		' 
		tbNamaPetugas.Location = New Point(115, 20)
		tbNamaPetugas.Name = "tbNamaPetugas"
		tbNamaPetugas.Size = New Size(175, 23)
		tbNamaPetugas.TabIndex = 4
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Location = New Point(351, 27)
		Label4.Name = "Label4"
		Label4.Size = New Size(63, 15)
		Label4.TabIndex = 3
		Label4.Text = "ID Petugas"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Location = New Point(18, 103)
		Label3.Name = "Label3"
		Label3.Size = New Size(57, 15)
		Label3.TabIndex = 2
		Label3.Text = "Password"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(18, 65)
		Label2.Name = "Label2"
		Label2.Size = New Size(60, 15)
		Label2.TabIndex = 1
		Label2.Text = "Username"
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(18, 27)
		Label1.Name = "Label1"
		Label1.Size = New Size(84, 15)
		Label1.TabIndex = 0
		Label1.Text = "Nama Petugas"
		' 
		' TabPage2
		' 
		TabPage2.Location = New Point(4, 24)
		TabPage2.Name = "TabPage2"
		TabPage2.Padding = New Padding(3)
		TabPage2.Size = New Size(794, 410)
		TabPage2.TabIndex = 1
		TabPage2.Text = "TabPage2"
		TabPage2.UseVisualStyleBackColor = True
		' 
		' DataGridView1
		' 
		DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridView1.Location = New Point(18, 171)
		DataGridView1.Name = "DataGridView1"
		DataGridView1.Size = New Size(753, 218)
		DataGridView1.TabIndex = 8
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(800, 450)
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
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents tbIdPetugas As TextBox
	Friend WithEvents tbPassword As TextBox
	Friend WithEvents tbUsername As TextBox
	Friend WithEvents tbNamaPetugas As TextBox
	Friend WithEvents DataGridView1 As DataGridView

End Class
