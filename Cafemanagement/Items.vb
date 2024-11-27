Imports System.Data.OleDb
Public Class Items
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "/CafeManagement.accdb")
    Dim cmd As New OleDb.OleDbCommand
    Dim dr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim obj As New Login
        obj.Show()
        Me.Hide()
    End Sub
    Private Sub addcatbtn_Click(sender As Object, e As EventArgs) Handles addcatbtn.Click
        Try
            If categorytxt.Text = "" Then
                MsgBox("Enter the Category")
            Else
                Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "/CafeManagement.accdb")
                con.Open()
                cmd = New OleDb.OleDbCommand("Insert into Category_tbl ([cat_name]) values ('" & categorytxt.Text & "')", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox("Category Added")
                con.Close()
                categorytxt.Text = ""
                Fillcategory()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub
    Private Sub Reset()
        Itnametxt.Text = ""
        Itcattxt.SelectedIndex = 0
        Itqtytxt.Text = ""
        Itpricetxt.Text = ""
    End Sub
    Private Sub Fillcategory()
        Try
            con.Open()
            cmd = New OleDb.OleDbCommand("Select * from Category_tbl", con)
            Dim adapter = New OleDbDataAdapter(cmd)
            Dim tbl = New DataTable()
            adapter.Fill(tbl)
            Itcattxt.DataSource = tbl
            Itcattxt.DisplayMember = "cat_name"
            Itcattxt.ValueMember = "cat_name"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub resetbtn_Click(sender As Object, e As EventArgs) Handles resetbtn.Click
        Reset()
    End Sub
    Private Sub Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fillcategory()
        DisplayItem()
    End Sub
    Private Sub DisplayItem()
        Try
            con.Open()
            cmd = New OleDb.OleDbCommand("Select * from Item_tbl", con)
            Dim adapter = New OleDbDataAdapter(cmd)
            Dim builder = New OleDbCommandBuilder(adapter)
            builder = New OleDbCommandBuilder(adapter)
            Dim ds = New DataSet()
            adapter.Fill(ds)
            ItemDGV.DataSource = ds.Tables(0)
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        Try
            If Itcattxt.SelectedIndex = -1 Or Itnametxt.Text = "" Or Itpricetxt.Text = "" Or Itqtytxt.Text = "" Then
                MsgBox("Missing Information ")
            Else
                Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "/CafeManagement.accdb")
                con.Open()
                cmd = New OleDb.OleDbCommand("Insert into Item_tbl([item_name],[item_cat],[item_price],[item_qty]) values ('" & Itnametxt.Text & "','" & Itcattxt.SelectedValue.ToString() & "','" & Itpricetxt.Text & "','" & Itqtytxt.Text & "')", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox("Item Added")
                con.Close()
                Reset()
                DisplayItem()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim key = 0
    Private Sub ItemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Try
            Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
            Itnametxt.Text = row.Cells(1).Value.ToString
            Itcattxt.Text = row.Cells(2).Value.ToString
            Itpricetxt.Text = row.Cells(3).Value.ToString
            Itqtytxt.Text = row.Cells(4).Value.ToString
            If Itnametxt.Text = "" Then
                key = 0
            Else
                key = Convert.ToInt32(row.Cells(0).Value.ToString)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        Try
            If key = 0 Then
                MsgBox("Select the Item to Delete")
            Else
                Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "/CafeManagement.accdb")
                con.Open()
                cmd = New OleDb.OleDbCommand("Delete from Item_tbl where item_id=" & key & "", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox("Item Deleted")
                con.Close()
                Reset()
                DisplayItem()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        Try
            If Itcattxt.SelectedIndex = -1 Or Itnametxt.Text = "" Or Itpricetxt.Text = "" Or Itqtytxt.Text = "" Then
                MsgBox("Missing Information ")
            Else
                Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "/CafeManagement.accdb")
                con.Open()
                cmd = New OleDb.OleDbCommand("Update Item_tbl set [item_name]='" & Itnametxt.Text & "',[item_cat]='" & Itcattxt.SelectedValue.ToString() & "',[item_price]='" & Itpricetxt.Text & "',[item_qty]='" & Itqtytxt.Text & "'where [item_id] =" & key & "", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox("Item Updated")
                con.Close()
                Reset()
                DisplayItem()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class