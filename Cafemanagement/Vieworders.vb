Imports System.Data.OleDb
Public Class Vieworders
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "/CafeManagement.accdb")
    Dim cmd As New OleDb.OleDbCommand
    Dim dr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Private Sub DisplayBill()
        Try
            con.Open()
            cmd = New OleDb.OleDbCommand("Select * from Order_tbl", con)
            Dim adapter = New OleDbDataAdapter(cmd)
            Dim builder = New OleDbCommandBuilder(adapter)
            builder = New OleDbCommandBuilder(adapter)
            Dim ds = New DataSet()
            adapter.Fill(ds)
            OrdersDGV.DataSource = ds.Tables(0)
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Vieworders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBill()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj As New Order
        obj.Show()
        Me.Hide()
    End Sub
End Class