<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Item
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
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.InsertItem = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ItemUnit = New System.Windows.Forms.ComboBox()
        Me.ItemGroup = New System.Windows.Forms.ComboBox()
        Me.ItemPrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ItemDesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ItemName = New System.Windows.Forms.TextBox()
        Me.ItemNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonSelect = New System.Windows.Forms.Button()
        Me.ItemImg = New System.Windows.Forms.PictureBox()
        Me.ListItem = New System.Windows.Forms.TabPage()
        Me.ItemList = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.InsertItem.SuspendLayout()
        CType(Me.ItemImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ListItem.SuspendLayout()
        CType(Me.ItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonClose
        '
        Me.ButtonClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.Location = New System.Drawing.Point(696, 593)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 28)
        Me.ButtonClose.TabIndex = 1
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(189, 525)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 35)
        Me.ButtonSave.TabIndex = 2
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(15, 525)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 35)
        Me.ButtonDelete.TabIndex = 3
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.InsertItem)
        Me.TabControl1.Controls.Add(Me.ListItem)
        Me.TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(30, 120)
        Me.TabControl1.Location = New System.Drawing.Point(3, -3)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(862, 575)
        Me.TabControl1.TabIndex = 4
        '
        'InsertItem
        '
        Me.InsertItem.BackColor = System.Drawing.SystemColors.Control
        Me.InsertItem.Controls.Add(Me.Label7)
        Me.InsertItem.Controls.Add(Me.ItemUnit)
        Me.InsertItem.Controls.Add(Me.ItemGroup)
        Me.InsertItem.Controls.Add(Me.ItemPrice)
        Me.InsertItem.Controls.Add(Me.Label6)
        Me.InsertItem.Controls.Add(Me.Label5)
        Me.InsertItem.Controls.Add(Me.Label4)
        Me.InsertItem.Controls.Add(Me.ItemDesc)
        Me.InsertItem.Controls.Add(Me.Label3)
        Me.InsertItem.Controls.Add(Me.ItemName)
        Me.InsertItem.Controls.Add(Me.ItemNo)
        Me.InsertItem.Controls.Add(Me.Label2)
        Me.InsertItem.Controls.Add(Me.Label1)
        Me.InsertItem.Controls.Add(Me.ButtonSelect)
        Me.InsertItem.Controls.Add(Me.ItemImg)
        Me.InsertItem.Controls.Add(Me.ButtonDelete)
        Me.InsertItem.Controls.Add(Me.ButtonSave)
        Me.InsertItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InsertItem.Location = New System.Drawing.Point(115, 4)
        Me.InsertItem.Name = "InsertItem"
        Me.InsertItem.Padding = New System.Windows.Forms.Padding(3)
        Me.InsertItem.Size = New System.Drawing.Size(743, 567)
        Me.InsertItem.TabIndex = 0
        Me.InsertItem.Text = "Insert"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(513, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Label7"
        Me.Label7.Visible = False
        '
        'ItemUnit
        '
        Me.ItemUnit.FormattingEnabled = True
        Me.ItemUnit.Location = New System.Drawing.Point(435, 176)
        Me.ItemUnit.Name = "ItemUnit"
        Me.ItemUnit.Size = New System.Drawing.Size(127, 24)
        Me.ItemUnit.TabIndex = 16
        '
        'ItemGroup
        '
        Me.ItemGroup.FormattingEnabled = True
        Me.ItemGroup.Location = New System.Drawing.Point(90, 173)
        Me.ItemGroup.Name = "ItemGroup"
        Me.ItemGroup.Size = New System.Drawing.Size(255, 24)
        Me.ItemGroup.TabIndex = 15
        '
        'ItemPrice
        '
        Me.ItemPrice.Location = New System.Drawing.Point(90, 213)
        Me.ItemPrice.Name = "ItemPrice"
        Me.ItemPrice.Size = New System.Drawing.Size(255, 22)
        Me.ItemPrice.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Item Group"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(398, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Unit"
        '
        'ItemDesc
        '
        Me.ItemDesc.Location = New System.Drawing.Point(220, 75)
        Me.ItemDesc.Multiline = True
        Me.ItemDesc.Name = "ItemDesc"
        Me.ItemDesc.Size = New System.Drawing.Size(472, 70)
        Me.ItemDesc.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(121, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Item Deskripsi"
        '
        'ItemName
        '
        Me.ItemName.Location = New System.Drawing.Point(222, 38)
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Size = New System.Drawing.Size(435, 22)
        Me.ItemName.TabIndex = 8
        '
        'ItemNo
        '
        Me.ItemNo.Location = New System.Drawing.Point(222, 6)
        Me.ItemNo.Name = "ItemNo"
        Me.ItemNo.Size = New System.Drawing.Size(269, 22)
        Me.ItemNo.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Item Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Item No"
        '
        'ButtonSelect
        '
        Me.ButtonSelect.Location = New System.Drawing.Point(15, 122)
        Me.ButtonSelect.Name = "ButtonSelect"
        Me.ButtonSelect.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSelect.TabIndex = 4
        Me.ButtonSelect.Text = "Select"
        Me.ButtonSelect.UseVisualStyleBackColor = True
        '
        'ItemImg
        '
        Me.ItemImg.Location = New System.Drawing.Point(6, 6)
        Me.ItemImg.Name = "ItemImg"
        Me.ItemImg.Size = New System.Drawing.Size(108, 110)
        Me.ItemImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ItemImg.TabIndex = 0
        Me.ItemImg.TabStop = False
        '
        'ListItem
        '
        Me.ListItem.BackColor = System.Drawing.SystemColors.Control
        Me.ListItem.Controls.Add(Me.ItemList)
        Me.ListItem.Location = New System.Drawing.Point(115, 4)
        Me.ListItem.Name = "ListItem"
        Me.ListItem.Padding = New System.Windows.Forms.Padding(3)
        Me.ListItem.Size = New System.Drawing.Size(743, 567)
        Me.ListItem.TabIndex = 1
        Me.ListItem.Text = "List"
        '
        'ItemList
        '
        Me.ItemList.AllowUserToAddRows = False
        Me.ItemList.AllowUserToDeleteRows = False
        Me.ItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemList.Location = New System.Drawing.Point(0, 0)
        Me.ItemList.Name = "ItemList"
        Me.ItemList.ReadOnly = True
        Me.ItemList.Size = New System.Drawing.Size(731, 561)
        Me.ItemList.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 652)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ButtonClose)
        Me.Name = "Item"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Item"
        Me.TabControl1.ResumeLayout(False)
        Me.InsertItem.ResumeLayout(False)
        Me.InsertItem.PerformLayout()
        CType(Me.ItemImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListItem.ResumeLayout(False)
        CType(Me.ItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ItemImg As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents InsertItem As System.Windows.Forms.TabPage
    Friend WithEvents ListItem As System.Windows.Forms.TabPage
    Friend WithEvents ItemList As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonSelect As System.Windows.Forms.Button
    Friend WithEvents ItemDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ItemName As System.Windows.Forms.TextBox
    Friend WithEvents ItemNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ItemUnit As System.Windows.Forms.ComboBox
    Friend WithEvents ItemGroup As System.Windows.Forms.ComboBox
    Friend WithEvents ItemPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
