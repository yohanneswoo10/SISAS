<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
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
        Me.components = New System.ComponentModel.Container()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.TextBoxUname = New System.Windows.Forms.TextBox()
        Me.TextBoxPass = New System.Windows.Forms.TextBox()
        Me.LabelLevel = New System.Windows.Forms.Label()
        Me.LevelName = New System.Windows.Forms.ComboBox()
        Me.TablevelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New SISAS.DataSet1()
        Me.LevelID = New System.Windows.Forms.Label()
        Me.TablevelTableAdapter = New SISAS.DataSet1TableAdapters.tablevelTableAdapter()
        Me.ButtonOk = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ButtonDel = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridViewUser = New System.Windows.Forms.DataGridView()
        Me.TabuserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabuserTableAdapter = New SISAS.DataSet1TableAdapters.tabuserTableAdapter()
        CType(Me.TablevelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridViewUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabuserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Location = New System.Drawing.Point(19, 16)
        Me.LabelUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(83, 20)
        Me.LabelUsername.TabIndex = 0
        Me.LabelUsername.Text = "Username"
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Location = New System.Drawing.Point(19, 48)
        Me.LabelPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(78, 20)
        Me.LabelPassword.TabIndex = 1
        Me.LabelPassword.Text = "Password"
        '
        'TextBoxUname
        '
        Me.TextBoxUname.Location = New System.Drawing.Point(137, 15)
        Me.TextBoxUname.Name = "TextBoxUname"
        Me.TextBoxUname.Size = New System.Drawing.Size(249, 26)
        Me.TextBoxUname.TabIndex = 2
        '
        'TextBoxPass
        '
        Me.TextBoxPass.Location = New System.Drawing.Point(137, 47)
        Me.TextBoxPass.Name = "TextBoxPass"
        Me.TextBoxPass.Size = New System.Drawing.Size(249, 26)
        Me.TextBoxPass.TabIndex = 3
        '
        'LabelLevel
        '
        Me.LabelLevel.AutoSize = True
        Me.LabelLevel.Location = New System.Drawing.Point(24, 80)
        Me.LabelLevel.Name = "LabelLevel"
        Me.LabelLevel.Size = New System.Drawing.Size(46, 20)
        Me.LabelLevel.TabIndex = 4
        Me.LabelLevel.Text = "Level"
        '
        'LevelName
        '
        Me.LevelName.DataSource = Me.TablevelBindingSource
        Me.LevelName.DisplayMember = "levelName"
        Me.LevelName.FormattingEnabled = True
        Me.LevelName.Location = New System.Drawing.Point(138, 77)
        Me.LevelName.Name = "LevelName"
        Me.LevelName.Size = New System.Drawing.Size(249, 28)
        Me.LevelName.TabIndex = 5
        Me.LevelName.ValueMember = "levelId"
        '
        'TablevelBindingSource
        '
        Me.TablevelBindingSource.DataMember = "tablevel"
        Me.TablevelBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LevelID
        '
        Me.LevelID.AutoSize = True
        Me.LevelID.Location = New System.Drawing.Point(442, 337)
        Me.LevelID.Name = "LevelID"
        Me.LevelID.Size = New System.Drawing.Size(0, 20)
        Me.LevelID.TabIndex = 6
        '
        'TablevelTableAdapter
        '
        Me.TablevelTableAdapter.ClearBeforeFill = True
        '
        'ButtonOk
        '
        Me.ButtonOk.Location = New System.Drawing.Point(295, 156)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(92, 34)
        Me.ButtonOk.TabIndex = 7
        Me.ButtonOk.Text = "Create"
        Me.ButtonOk.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(66, 156)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(92, 33)
        Me.ButtonCancel.TabIndex = 8
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(137, 111)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(47, 26)
        Me.TextBox1.TabIndex = 9
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-6, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(577, 259)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ButtonDel)
        Me.TabPage1.Controls.Add(Me.LabelUsername)
        Me.TabPage1.Controls.Add(Me.ButtonOk)
        Me.TabPage1.Controls.Add(Me.ButtonCancel)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.TextBoxUname)
        Me.TabPage1.Controls.Add(Me.LabelPassword)
        Me.TabPage1.Controls.Add(Me.TextBoxPass)
        Me.TabPage1.Controls.Add(Me.LabelLevel)
        Me.TabPage1.Controls.Add(Me.LevelName)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(569, 226)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "New User"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ButtonDel
        '
        Me.ButtonDel.Location = New System.Drawing.Point(183, 155)
        Me.ButtonDel.Name = "ButtonDel"
        Me.ButtonDel.Size = New System.Drawing.Size(92, 34)
        Me.ButtonDel.TabIndex = 10
        Me.ButtonDel.Text = "Delete"
        Me.ButtonDel.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridViewUser)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(569, 226)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "User List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridViewUser
        '
        Me.DataGridViewUser.AllowUserToAddRows = False
        Me.DataGridViewUser.AllowUserToDeleteRows = False
        Me.DataGridViewUser.AllowUserToOrderColumns = True
        Me.DataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewUser.Location = New System.Drawing.Point(3, 0)
        Me.DataGridViewUser.Name = "DataGridViewUser"
        Me.DataGridViewUser.ReadOnly = True
        Me.DataGridViewUser.Size = New System.Drawing.Size(563, 220)
        Me.DataGridViewUser.TabIndex = 0
        '
        'TabuserBindingSource
        '
        Me.TabuserBindingSource.DataMember = "tabuser"
        Me.TabuserBindingSource.DataSource = Me.DataSet1BindingSource
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'TabuserTableAdapter
        '
        Me.TabuserTableAdapter.ClearBeforeFill = True
        '
        'AddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 251)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.LevelID)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddUser"
        Me.ShowIcon = False
        Me.Text = "AddUser"
        CType(Me.TablevelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridViewUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabuserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelUsername As System.Windows.Forms.Label
    Friend WithEvents LabelPassword As System.Windows.Forms.Label
    Friend WithEvents TextBoxUname As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPass As System.Windows.Forms.TextBox
    Friend WithEvents LabelLevel As System.Windows.Forms.Label
    Friend WithEvents LevelName As System.Windows.Forms.ComboBox
    Friend WithEvents LevelID As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As SISAS.DataSet1
    Friend WithEvents TablevelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TablevelTableAdapter As SISAS.DataSet1TableAdapters.tablevelTableAdapter
    Friend WithEvents ButtonOk As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewUser As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TabuserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TabuserTableAdapter As SISAS.DataSet1TableAdapters.tabuserTableAdapter
    Friend WithEvents ButtonDel As System.Windows.Forms.Button
End Class
