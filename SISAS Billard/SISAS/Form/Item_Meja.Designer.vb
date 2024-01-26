<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Item_Meja
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
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PanelGroup = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PanelItem = New System.Windows.Forms.Panel()
        Me.OpenFileDialogItem = New System.Windows.Forms.OpenFileDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridViewItem = New System.Windows.Forms.DataGridView()
        Me.LabelMeja = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(468, 499)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(100, 60)
        Me.ButtonAdd.TabIndex = 1
        Me.ButtonAdd.Text = "ADD"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(574, 499)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(100, 60)
        Me.ButtonDelete.TabIndex = 2
        Me.ButtonDelete.Text = "DELETE"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PanelGroup)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(308, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(137, 492)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GROUP"
        '
        'PanelGroup
        '
        Me.PanelGroup.AutoScroll = True
        Me.PanelGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGroup.Location = New System.Drawing.Point(3, 16)
        Me.PanelGroup.Name = "PanelGroup"
        Me.PanelGroup.Size = New System.Drawing.Size(131, 473)
        Me.PanelGroup.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PanelItem)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(451, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(330, 489)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ITEM"
        '
        'PanelItem
        '
        Me.PanelItem.AutoScroll = True
        Me.PanelItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelItem.Location = New System.Drawing.Point(3, 16)
        Me.PanelItem.Name = "PanelItem"
        Me.PanelItem.Size = New System.Drawing.Size(324, 470)
        Me.PanelItem.TabIndex = 0
        '
        'OpenFileDialogItem
        '
        Me.OpenFileDialogItem.FileName = "OpenFileDialogItem"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(681, 499)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 60)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "CHECK OUT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridViewItem
        '
        Me.DataGridViewItem.AllowUserToAddRows = False
        Me.DataGridViewItem.AllowUserToDeleteRows = False
        Me.DataGridViewItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewItem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridViewItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewItem.Location = New System.Drawing.Point(-3, 32)
        Me.DataGridViewItem.Name = "DataGridViewItem"
        Me.DataGridViewItem.RowHeadersVisible = False
        Me.DataGridViewItem.Size = New System.Drawing.Size(311, 527)
        Me.DataGridViewItem.TabIndex = 7
        '
        'LabelMeja
        '
        Me.LabelMeja.AutoSize = True
        Me.LabelMeja.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMeja.Location = New System.Drawing.Point(93, 3)
        Me.LabelMeja.Name = "LabelMeja"
        Me.LabelMeja.Size = New System.Drawing.Size(71, 24)
        Me.LabelMeja.TabIndex = 8
        Me.LabelMeja.Text = "MEJA: "
        '
        'Item_Meja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.LabelMeja)
        Me.Controls.Add(Me.DataGridViewItem)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Name = "Item_Meja"
        Me.Text = "Item_Meja"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridViewItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PanelGroup As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PanelItem As System.Windows.Forms.Panel
    Friend WithEvents OpenFileDialogItem As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewItem As System.Windows.Forms.DataGridView
    Friend WithEvents LabelMeja As System.Windows.Forms.Label
End Class
