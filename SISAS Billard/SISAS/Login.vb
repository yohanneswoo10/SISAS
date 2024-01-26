Imports System.Data.Odbc
Public Class Login
    Public login_state As Integer = 0
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim uname, pass, pass_enc, pass_db, userlevel As String
        Dim result As Integer

        pass_db = ""
        userlevel = ""
        uname = TextBoxUsername.Text
        pass = TextBoxPassword.Text
        pass_enc = ModuleClass.Encrypt(pass)
        'Console.WriteLine(pass_enc)
        sql = "select password,userLevel from tabuser where username='" & uname & "'"
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader

        While dr.Read
            'Console.WriteLine(dr("password"))
            'Console.WriteLine(dr("userLevel"))
            pass_db = dr("password")
            userlevel = dr("userLevel")
        End While

        result = String.Compare(pass_db, pass_enc, True)
        'MsgBox(result)
        If result = 0 Then
            MsgBox("Login Success!!!")
            Billing.login_state = 1
            Billing.userlevel = userlevel
            Billing.Enabled = True
            Billing.username = uname
            Me.Close()
        Else
            MsgBox("Username or Password Not Matches")
        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        'Billing.Close()
        'Application.Exit()
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        open_conn()
        Me.TopMost = True
        TextBoxUsername.Select()
        'Label2.Visible = Not Label2.Visible
    End Sub
End Class
