<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Items
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ItemDGV = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.addcatbtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.categorytxt = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.resetbtn = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.editbtn = New System.Windows.Forms.Button()
        Me.addbtn = New System.Windows.Forms.Button()
        Me.Itpricetxt = New System.Windows.Forms.TextBox()
        Me.Itcattxt = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Itqtytxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Itnametxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.ItemDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.ItemDGV)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.addcatbtn)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.categorytxt)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(97, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(824, 558)
        Me.Panel1.TabIndex = 0
        '
        'ItemDGV
        '
        Me.ItemDGV.BackgroundColor = System.Drawing.Color.White
        Me.ItemDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ItemDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemDGV.EnableHeadersVisualStyles = False
        Me.ItemDGV.GridColor = System.Drawing.Color.White
        Me.ItemDGV.Location = New System.Drawing.Point(118, 311)
        Me.ItemDGV.Name = "ItemDGV"
        Me.ItemDGV.Size = New System.Drawing.Size(609, 212)
        Me.ItemDGV.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label7.Location = New System.Drawing.Point(375, 269)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 29)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Item List"
        '
        'addcatbtn
        '
        Me.addcatbtn.BackColor = System.Drawing.Color.DarkCyan
        Me.addcatbtn.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcatbtn.ForeColor = System.Drawing.Color.White
        Me.addcatbtn.Location = New System.Drawing.Point(299, 45)
        Me.addcatbtn.Name = "addcatbtn"
        Me.addcatbtn.Size = New System.Drawing.Size(129, 42)
        Me.addcatbtn.TabIndex = 14
        Me.addcatbtn.Text = "Add Category"
        Me.addcatbtn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label6.Location = New System.Drawing.Point(59, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 26)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Name"
        '
        'categorytxt
        '
        Me.categorytxt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categorytxt.ForeColor = System.Drawing.Color.DarkCyan
        Me.categorytxt.Location = New System.Drawing.Point(127, 50)
        Me.categorytxt.Name = "categorytxt"
        Me.categorytxt.Size = New System.Drawing.Size(156, 30)
        Me.categorytxt.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.resetbtn)
        Me.Panel2.Controls.Add(Me.deletebtn)
        Me.Panel2.Controls.Add(Me.editbtn)
        Me.Panel2.Controls.Add(Me.addbtn)
        Me.Panel2.Controls.Add(Me.Itpricetxt)
        Me.Panel2.Controls.Add(Me.Itcattxt)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Itqtytxt)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Itnametxt)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(25, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(775, 168)
        Me.Panel2.TabIndex = 11
        '
        'resetbtn
        '
        Me.resetbtn.BackColor = System.Drawing.Color.DarkCyan
        Me.resetbtn.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetbtn.ForeColor = System.Drawing.Color.White
        Me.resetbtn.Location = New System.Drawing.Point(510, 118)
        Me.resetbtn.Name = "resetbtn"
        Me.resetbtn.Size = New System.Drawing.Size(90, 32)
        Me.resetbtn.TabIndex = 18
        Me.resetbtn.Text = "Reset"
        Me.resetbtn.UseVisualStyleBackColor = False
        '
        'deletebtn
        '
        Me.deletebtn.BackColor = System.Drawing.Color.DarkCyan
        Me.deletebtn.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletebtn.ForeColor = System.Drawing.Color.White
        Me.deletebtn.Location = New System.Drawing.Point(392, 118)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(90, 32)
        Me.deletebtn.TabIndex = 17
        Me.deletebtn.Text = "Delete"
        Me.deletebtn.UseVisualStyleBackColor = False
        '
        'editbtn
        '
        Me.editbtn.BackColor = System.Drawing.Color.DarkCyan
        Me.editbtn.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editbtn.ForeColor = System.Drawing.Color.White
        Me.editbtn.Location = New System.Drawing.Point(274, 118)
        Me.editbtn.Name = "editbtn"
        Me.editbtn.Size = New System.Drawing.Size(90, 32)
        Me.editbtn.TabIndex = 16
        Me.editbtn.Text = "Edit"
        Me.editbtn.UseVisualStyleBackColor = False
        '
        'addbtn
        '
        Me.addbtn.BackColor = System.Drawing.Color.DarkCyan
        Me.addbtn.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addbtn.ForeColor = System.Drawing.Color.White
        Me.addbtn.Location = New System.Drawing.Point(156, 118)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(90, 32)
        Me.addbtn.TabIndex = 15
        Me.addbtn.Text = "Add "
        Me.addbtn.UseVisualStyleBackColor = False
        '
        'Itpricetxt
        '
        Me.Itpricetxt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Itpricetxt.ForeColor = System.Drawing.Color.DarkCyan
        Me.Itpricetxt.Location = New System.Drawing.Point(461, 58)
        Me.Itpricetxt.Name = "Itpricetxt"
        Me.Itpricetxt.Size = New System.Drawing.Size(134, 30)
        Me.Itpricetxt.TabIndex = 8
        '
        'Itcattxt
        '
        Me.Itcattxt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Itcattxt.ForeColor = System.Drawing.Color.DarkCyan
        Me.Itcattxt.FormattingEnabled = True
        Me.Itcattxt.Location = New System.Drawing.Point(252, 57)
        Me.Itcattxt.Name = "Itcattxt"
        Me.Itcattxt.Size = New System.Drawing.Size(189, 31)
        Me.Itcattxt.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label1.Location = New System.Drawing.Point(50, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name"
        '
        'Itqtytxt
        '
        Me.Itqtytxt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Itqtytxt.ForeColor = System.Drawing.Color.DarkCyan
        Me.Itqtytxt.Location = New System.Drawing.Point(618, 57)
        Me.Itqtytxt.Name = "Itqtytxt"
        Me.Itqtytxt.Size = New System.Drawing.Size(125, 30)
        Me.Itqtytxt.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label3.Location = New System.Drawing.Point(247, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Categories"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label4.Location = New System.Drawing.Point(456, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 26)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Price"
        '
        'Itnametxt
        '
        Me.Itnametxt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Itnametxt.ForeColor = System.Drawing.Color.DarkCyan
        Me.Itnametxt.Location = New System.Drawing.Point(55, 57)
        Me.Itnametxt.Name = "Itnametxt"
        Me.Itnametxt.Size = New System.Drawing.Size(184, 30)
        Me.Itnametxt.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label5.Location = New System.Drawing.Point(613, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 26)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label2.Location = New System.Drawing.Point(329, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Manage Items"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 554)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 29)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Logout"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Cafemanagement.My.Resources.Resources.close
        Me.PictureBox1.Location = New System.Drawing.Point(901, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(941, 614)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Items"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Items"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ItemDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Itnametxt As TextBox
    Friend WithEvents Itcattxt As ComboBox
    Friend WithEvents Itqtytxt As TextBox
    Friend WithEvents Itpricetxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents categorytxt As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents addcatbtn As Button
    Friend WithEvents ItemDGV As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents deletebtn As Button
    Friend WithEvents editbtn As Button
    Friend WithEvents addbtn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents resetbtn As Button
End Class
