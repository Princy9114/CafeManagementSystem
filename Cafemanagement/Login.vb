Public Class Login
    Private Sub Login1_Click(sender As Object, e As EventArgs) Handles Login1.Click
        If Unametxt.Text = "" Or Passwordtxt.Text = "" Then
            MsgBox("Enter Username and Password")
        ElseIf Unametxt.Text = "Admin" Or Passwordtxt.Text = "Password" Then
            Dim obj As New Items
            obj.Show()
            Me.Hide()
        Else
            MsgBox("Wrong Username or Password")
            Unametxt.Text = ""
            Passwordtxt.Text = ""
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim obj As New Order
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub


End Class
