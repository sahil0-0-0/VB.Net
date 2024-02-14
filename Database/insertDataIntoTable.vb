Imports System.Data.OleDb
Public Class insertDataIntoTable
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim qry As String
    Private Sub insertDataIntoTable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\sahil\OneDrive\Desktop\mdbFile\Dummy.mdb"
        con.Open()
        cmd.Connection = con
        qry = "select * from employee"
        Dim da As New OleDbDataAdapter(qry, con)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub insertbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insertbtn.Click
        qry = "insert into employee values ( "
        qry = qry + TextBox1.Text + " , "
        qry = qry + " ' " + TextBox2.Text + " ' ,"
        qry = qry + TextBox3.Text + " ) "
        cmd.CommandText = qry
        cmd.ExecuteNonQuery()
        qry = "select * from employee"
        Dim da As New OleDbDataAdapter(qry, con)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class