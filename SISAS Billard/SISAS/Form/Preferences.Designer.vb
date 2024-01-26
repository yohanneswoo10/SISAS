<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preferences
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
        Me.TextDtk = New System.Windows.Forms.TextBox()
        Me.TextMnt = New System.Windows.Forms.TextBox()
        Me.harga_jam = New System.Windows.Forms.TextBox()
        Me.jlm_meja = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.submit = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.company_name = New System.Windows.Forms.TextBox()
        Me.company_logo = New System.Windows.Forms.PictureBox()
        Me.select_btn = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.company_address = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.company_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextDtk
        '
        Me.TextDtk.Location = New System.Drawing.Point(168, 245)
        Me.TextDtk.Name = "TextDtk"
        Me.TextDtk.ReadOnly = True
        Me.TextDtk.Size = New System.Drawing.Size(156, 26)
        Me.TextDtk.TabIndex = 7
        '
        'TextMnt
        '
        Me.TextMnt.Location = New System.Drawing.Point(168, 213)
        Me.TextMnt.Name = "TextMnt"
        Me.TextMnt.ReadOnly = True
        Me.TextMnt.Size = New System.Drawing.Size(156, 26)
        Me.TextMnt.TabIndex = 6
        '
        'harga_jam
        '
        Me.harga_jam.Location = New System.Drawing.Point(168, 181)
        Me.harga_jam.Name = "harga_jam"
        Me.harga_jam.Size = New System.Drawing.Size(156, 26)
        Me.harga_jam.TabIndex = 5
        '
        'jlm_meja
        '
        Me.jlm_meja.Location = New System.Drawing.Point(168, 146)
        Me.jlm_meja.Name = "jlm_meja"
        Me.jlm_meja.Size = New System.Drawing.Size(100, 26)
        Me.jlm_meja.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(89, 241)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 20)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "/ Dtk"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(89, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "/ Mnt"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Harga / Jam"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Jumlah Meja"
        '
        'submit
        '
        Me.submit.Location = New System.Drawing.Point(541, 324)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(87, 33)
        Me.submit.TabIndex = 1
        Me.submit.Text = "Save"
        Me.submit.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(429, 325)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 32)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "Close"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Company Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(486, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Company Logo"
        '
        'company_name
        '
        Me.company_name.Location = New System.Drawing.Point(168, 10)
        Me.company_name.Name = "company_name"
        Me.company_name.Size = New System.Drawing.Size(258, 26)
        Me.company_name.TabIndex = 10
        '
        'company_logo
        '
        Me.company_logo.Location = New System.Drawing.Point(478, 10)
        Me.company_logo.Name = "company_logo"
        Me.company_logo.Size = New System.Drawing.Size(150, 150)
        Me.company_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.company_logo.TabIndex = 11
        Me.company_logo.TabStop = False
        '
        'select_btn
        '
        Me.select_btn.Location = New System.Drawing.Point(515, 166)
        Me.select_btn.Name = "select_btn"
        Me.select_btn.Size = New System.Drawing.Size(75, 32)
        Me.select_btn.TabIndex = 12
        Me.select_btn.Text = "Select"
        Me.select_btn.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'company_address
        '
        Me.company_address.Location = New System.Drawing.Point(168, 43)
        Me.company_address.Multiline = True
        Me.company_address.Name = "company_address"
        Me.company_address.Size = New System.Drawing.Size(258, 97)
        Me.company_address.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Company Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(567, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Setelah melakukan perubahan silahkan matikan program and jalan kan kembali"
        '
        'Preferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 369)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.company_address)
        Me.Controls.Add(Me.select_btn)
        Me.Controls.Add(Me.company_logo)
        Me.Controls.Add(Me.company_name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextDtk)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.TextMnt)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.harga_jam)
        Me.Controls.Add(Me.jlm_meja)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimizeBox = False
        Me.Name = "Preferences"
        Me.Text = "Preferences"
        CType(Me.company_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents submit As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextDtk As System.Windows.Forms.TextBox
    Friend WithEvents TextMnt As System.Windows.Forms.TextBox
    Friend WithEvents harga_jam As System.Windows.Forms.TextBox
    Friend WithEvents jlm_meja As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents company_name As System.Windows.Forms.TextBox
    Friend WithEvents company_logo As System.Windows.Forms.PictureBox
    Friend WithEvents select_btn As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents company_address As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
