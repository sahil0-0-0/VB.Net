Imports System.Data.OleDb
Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim qry As String
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\sahil\OneDrive\Desktop\mdbFile\Demo.mdb"
        con.Open()
        cmd.Connection = con
        qry = "select * from student"
        Dim da As New OleDbDataAdapter(qry, con)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class
