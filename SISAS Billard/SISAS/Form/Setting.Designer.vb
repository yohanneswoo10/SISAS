<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setting
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxDBPort = New System.Windows.Forms.TextBox()
        Me.TextBoxDBIp = New System.Windows.Forms.TextBox()
        Me.TextBoxDBPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxDBUser = New System.Windows.Forms.TextBox()
        Me.TextBoxDBName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.submit = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(236, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Default Port 3306"
        '
        'TextBoxDBPort
        '
        Me.TextBoxDBPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDBPort.Location = New System.Drawing.Point(124, 135)
        Me.TextBoxDBPort.Name = "TextBoxDBPort"
        Me.TextBoxDBPort.Size = New System.Drawing.Size(95, 22)
        Me.TextBoxDBPort.TabIndex = 20
        '
        'TextBoxDBIp
        '
        Me.TextBoxDBIp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDBIp.Location = New System.Drawing.Point(124, 102)
        Me.TextBoxDBIp.Name = "TextBoxDBIp"
        Me.TextBoxDBIp.Size = New System.Drawing.Size(234, 22)
        Me.TextBoxDBIp.TabIndex = 19
        '
        'TextBoxDBPassword
        '
        Me.TextBoxDBPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDBPassword.Location = New System.Drawing.Point(124, 69)
        Me.TextBoxDBPassword.Name = "TextBoxDBPassword"
        Me.TextBoxDBPassword.Size = New System.Drawing.Size(234, 22)
        Me.TextBoxDBPassword.TabIndex = 18
        '
        'TextBoxDBUser
        '
        Me.TextBoxDBUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDBUser.Location = New System.Drawing.Point(124, 38)
        Me.TextBoxDBUser.Name = "TextBoxDBUser"
        Me.TextBoxDBUser.Size = New System.Drawing.Size(234, 22)
        Me.TextBoxDBUser.TabIndex = 17
        '
        'TextBoxDBName
        '
        Me.TextBoxDBName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDBName.Location = New System.Drawing.Point(124, 6)
        Me.TextBoxDBName.Name = "TextBoxDBName"
        Me.TextBoxDBName.Size = New System.Drawing.Size(234, 22)
        Me.TextBoxDBName.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Port"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "IP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "User"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Database"
        '
        'submit
        '
        Me.submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit.Location = New System.Drawing.Point(269, 182)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(75, 30)
        Me.submit.TabIndex = 22
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel.Location = New System.Drawing.Point(176, 182)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(75, 30)
        Me.cancel.TabIndex = 23
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'Setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 224)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxDBPort)
        Me.Controls.Add(Me.TextBoxDBIp)
        Me.Controls.Add(Me.TextBoxDBPassword)
        Me.Controls.Add(Me.TextBoxDBUser)
        Me.Controls.Add(Me.TextBoxDBName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Setting"
        Me.Text = "Setting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDBPort As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDBIp As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDBPassword As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDBUser As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDBName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents submit As System.Windows.Forms.Button
    Friend WithEvents cancel As System.Windows.Forms.Button
End Class
