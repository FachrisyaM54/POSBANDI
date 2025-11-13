Imports MySql.Data.MySqlClient

Public Class Form1
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim ds As New DataSet
    Public da As MySqlDataAdapter
    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connected()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub





End Class
