Imports System.Data.OleDb
Public Class Order
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "/CafeManagement.accdb")
    Dim cmd As New OleDb.OleDbCommand
    Dim dr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim obj As New Login
        obj.Show()
        Me.Hide()
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
    Private Sub Filterbycategory()
        Try
            con.Open()
            cmd = New OleDb.OleDbCommand("Select * from Item_tbl where [item_cat]='" & Itcattxt.SelectedValue.ToString() & "'", con)
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
    Private Sub Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItem()
        Fillcategory()
    End Sub
    Private Sub Catcb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Itcattxt.SelectionChangeCommitted
        Filterbycategory()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DisplayItem()
    End Sub
    Dim ProdName As String
    Dim i = 0, GrdTotal = 0, price, qty
    Private Sub AddBill()
        Try
            Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "/CafeManagement.accdb")
            con.Open()
            cmd = New OleDb.OleDbCommand("Insert into Order_tbl([order_date],[order_amt]) values ('" & DateTime.Today.Date & "','" & GrdTotal & "')", con)
            cmd.ExecuteNonQuery()
            MsgBox("Bill Added")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AddBill()
        PrintPreviewDialog1.Show()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Cafe Shop", New Font("Arial", 22), Brushes.BlueViolet, 335, 35)
        e.Graphics.DrawString("***YourBill***", New Font("Arial", 14), Brushes.BlueViolet, 350, 60)
        Dim bm As New Bitmap(Me.BillDGV.Width, Me.BillDGV.Height)
        BillDGV.DrawToBitmap(bm, New Rectangle(0, 0, Me.BillDGV.Width, Me.BillDGV.Height))
        e.Graphics.DrawImage(bm, 0, 90)
        e.Graphics.DrawString("Total Amount" + GrdTotal.ToString(), New Font("Arial", 15), Brushes.Crimson, 325, 580)
        e.Graphics.DrawString(" -----------------Thanks For Buying In our Cafe-------------------- ", New Font("Arial", 15), Brushes.Crimson, 130, 600)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim obj As New Vieworders
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Addbillbtn_Click(sender As Object, e As EventArgs) Handles Addbillbtn.Click
        Try
            If key = 0 Then
                MsgBox("Select Item")
            ElseIf qty > stock Then
                MsgBox("No enough stock")
            Else
                Dim rnum As Integer = BillDGV.Rows.Add()
                Dim total = Convert.ToInt32(Itqtytxt.Text) * price
                i = i + 1
                BillDGV.Rows.Item(rnum).Cells("Column1").Value = i
                BillDGV.Rows.Item(rnum).Cells("Column2").Value = ProdName
                BillDGV.Rows.Item(rnum).Cells("Column3").Value = price
                BillDGV.Rows.Item(rnum).Cells("Column4").Value = Itqtytxt.Text
                BillDGV.Rows.Item(rnum).Cells("Column5").Value = total
                GrdTotal = GrdTotal + total
                Totallbl.Text = "Rs" + Convert.ToString(GrdTotal)
                Itqtytxt.Text = ""
                key = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim key = 0, stock
    Private Sub ItemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Try
            Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
            ProdName = row.Cells(1).Value.ToString
            If ProdName = "" Then
                key = 0
                stock = 0
            Else
                key = Convert.ToInt32(row.Cells(0).Value.ToString)
                stock = Convert.ToInt32(row.Cells(4).Value.ToString)
                price = Convert.ToInt32(row.Cells(3).Value.ToString)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class