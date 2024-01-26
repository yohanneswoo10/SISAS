Imports System.IO
Imports System.Data.Odbc
Public Class Main
    Public login_state As Integer = 0
    Public userlevel As Integer = 0
    Dim btn As Button
    Dim btncontrol As Integer = 1
    Dim x As Integer = 0
    Dim y As Integer = 0
    Dim sw As Double
    Dim sh As Double
    Dim jlm_mj As Integer = 0
    Dim meja = New Integer() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20}
    Dim day(20) As Integer
    Dim hour(20) As Integer
    Dim min(20) As Integer
    Dim sec(20) As Integer
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'GET SCREEN WIDTH AND HEIGHT
        sw = Me.Size.Width
        sh = Me.Size.Height
        'Console.WriteLine(sw & "," & sh)
        'GET DATA PREFERENCES FROM DATABASE
        open_conn()
        Dim s As String = "Select * from tabsetting"
        select_db(s)
        While dr.Read
            Select Case dr("set_name")
                Case "Company_Name"
                    Label_Company_Name.Text = dr("set_value").ToString
                Case "Jumlah_Meja"
                    jlm_mj = Convert.ToInt32(dr("set_value"))
                Case "Company_Logo"
                    If ModuleClass.FilenameIsOK(dr("set_value")) Then
                        Using fs As New System.IO.FileStream(dr("set_value"), IO.FileMode.Open)
                            company_logo.Image = New Bitmap(Image.FromStream(fs))
                            'OpenFileDialog1.FileName = dr("set_value")
                        End Using
                        Console.WriteLine(dr("set_value"))
                    Else

                    End If
            End Select
        End While

        'SHOW ALL BUTTON
        'show_btn()
        TextMejaBilliard.Width = Me.Size.Width

        'Init Array
        For i As Integer = 0 To 19
            meja(i) = 0
            day(i) = 0
            hour(i) = 0
            min(i) = 0
            sec(i) = 0
        Next

        disable_m()
        Me.Refresh()
        draw_line()
        'CHECK LOGIN STATE
        loginstate()
        usrlvl()
    End Sub

    Public Sub main_refresh()
        sw = Me.Size.Width
        sh = Me.Size.Height

        'GET DATA PREFERENCES FROM DATABASE
        Dim s As String = "Select * from tabsetting"
        select_db(s)
        While dr.Read
            Select Case dr("set_name")
                Case "Company_Name"
                    If String.Compare(dr("set_value").ToString, "", True) = 0 Then
                        Label_Company_Name.Text = "COMPANY NAME"
                    Else
                        Label_Company_Name.Text = dr("set_value").ToString
                    End If
                Case "Jumlah_Meja"
                    If Convert.ToInt32(dr("set_value")) <= 0 Then
                        jlm_mj = 1
                    Else
                        jlm_mj = Convert.ToInt32(dr("set_value"))
                    End If

                Case "Company_Logo"
                    If ModuleClass.FilenameIsOK(dr("set_value")) Then
                        Using fs As New System.IO.FileStream(dr("set_value"), IO.FileMode.Open)
                            company_logo.Image = New Bitmap(Image.FromStream(fs))
                            'OpenFileDialog1.FileName = dr("set_value")
                        End Using
                        Console.WriteLine(dr("set_value"))
                    Else

                    End If
            End Select
        End While

        'SHOW ALL BUTTON
        'show_btn()
        TextMejaBilliard.Width = Me.Size.Width

        'Init Array
        For i As Integer = 0 To 19
            meja(i) = 0
            day(i) = 0
            hour(i) = 0
            min(i) = 0
            sec(i) = 0
        Next

        'disable meja
        disable_m()

        'CHECK LOGIN STATE
        usrlvl()
    End Sub
    Private Sub loginstate()
        If login_state = 0 Then
            'Dim loginfrm As New Login
            Me.Enabled = False
            Login.Show()
        End If
    End Sub

    Public Sub usrlvl()
        If userlevel = 1 Then
        ElseIf userlevel = 2 Then
        ElseIf userlevel = 3 Then

        ElseIf userlevel = 4 Then
            Me.EditToolStripMenuItem.Enabled = False
            Me.ToolsToolStripMenuItem.Enabled = False
        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        conn.Close()
        Me.Close()
    End Sub

    Private Sub PreferencesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PreferencesToolStripMenuItem1.Click
        Preferences.Show()
    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        AddUser.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        login_state = 0
        userlevel = 0
        loginstate()
    End Sub

    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingToolStripMenuItem.Click
        Setting.Show()
    End Sub

    Public Sub new_button()
        'Dim lx, ly As Integer
        btn = New Button
        'Controls.Add(btn)
        btn.Top = btncontrol * 25
        btn.Left = 100
        btn.Size = New Size(100, 100)
        'lx = 110 * x
        'ly = 110 * y
        'Console.WriteLine("lx & ly=" & lx & "," & ly)
        'btn.Location = New Point(lx, ly)
        'If lx < sw - 200 Then
        ' x = x + 1
        'Else
        'x = 0
        'y = y + 1
        'End If
        btn.Name = btncontrol.ToString
        btn.Text = btncontrol.ToString
        btncontrol = btncontrol + 1
    End Sub

    Public Sub btn_loc(i As Integer)
        Dim lx, ly As Integer
        If y = 0 Then
            ly = 200
        Else
            ly = 200 + (120 * y)
        End If
        lx = 110 * x

        Console.WriteLine("lx & ly=" & lx & "," & ly)
        btn.Location = New Point(lx, ly)
        If lx < sw - 200 Then
            x = x + 1
        ElseIf ly < sh - 200 Then
            x = 0
            y = y + 1
        Else
            MsgBox("There is no room for more table")
        End If
        Controls.Add(btn)
    End Sub

    Public Sub show_btn()
        For index As Integer = 1 To jlm_mj
            new_button()
            btn_loc(index)
        Next
    End Sub


    Public Sub draw_line()
        Dim myGraphics As Graphics = Me.CreateGraphics
        Dim OurPen As Pen
        OurPen = New Pen(Brushes.Black, 20)
        myGraphics.DrawLine(OurPen, 10, 400, 10, 1000)
    End Sub

    Private Sub Main_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.Enabled = True

        login_state1()

    End Sub

    Public Sub disable_m()
        Dim s As String = "meja"
        Dim ss As String = ""

        For Each obj As Object In Me.Controls
            If TypeOf obj Is Windows.Forms.Button Then
                For i As Integer = 1 To 20
                    ss = s & i.ToString
                    If String.Compare(ss, obj.Name, True) = 0 Then
                        DirectCast(obj, Windows.Forms.Button).Enabled = False
                    End If
                    ss = ""
                    'DirectCast(obj, Windows.Forms.Button).Enabled = False
                Next
            End If
        Next
    End Sub

    Public Sub enable_meja()
        Dim s As String = "meja"
        Dim ss As String = ""

        For Each obj As Object In Me.Controls
            If TypeOf obj Is Windows.Forms.Button Then
                For i As Integer = 1 To jlm_mj
                    ss = s & i.ToString
                    If String.Compare(ss, obj.Name, True) = 0 Then
                        DirectCast(obj, Windows.Forms.Button).Enabled = True
                    End If
                    ss = ""
                    'DirectCast(obj, Windows.Forms.Button).Enabled = False
                Next
            End If
        Next
    End Sub

    Public Sub login_state1()
        If login_state = 0 Then
            LoginToolStripMenuItem.Enabled = True
            LogoutToolStripMenuItem.Enabled = False
            Me.EditToolStripMenuItem.Enabled = False
            Me.ToolsToolStripMenuItem.Enabled = False
            Me.ReportToolStripMenuItem.Enabled = False
        ElseIf login_state = 1 Then
            LoginToolStripMenuItem.Enabled = False
            LogoutToolStripMenuItem.Enabled = True
            Me.EditToolStripMenuItem.Enabled = True
            Me.ToolsToolStripMenuItem.Enabled = True
            Me.ReportToolStripMenuItem.Enabled = True
            enable_meja()
        End If
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Login.Show()
    End Sub

    Private Sub TimerBilliard_Tick(sender As Object, e As EventArgs) Handles TimerBilliard.Tick
        If LabelBilliard.Left >= Me.Size.Width Then
            LabelBilliard.Left = -LabelBilliard.Width
        Else
            LabelBilliard.Left = LabelBilliard.Left + 10
        End If
    End Sub

    Public Sub control_meja(s As String, time As Timer, btn As Button, lbl As Label)
        Dim nomeja As Integer = 0
        nomeja = Convert.ToInt32(s)
        If meja(nomeja) = 0 Then
            meja(nomeja) = 1
            reset_counter(nomeja, lbl)
            time.Start()
            meja_red(btn)
        Else
            meja(nomeja) = 0
            meja_green(btn)
            time.Stop()
        End If
    End Sub
    Public Sub meja_red(meja As Button)
        Dim meja_red As Object = My.Resources.meja_billard_red_150
        meja.Image = meja_red
    End Sub

    Public Sub meja_green(meja As Button)
        Dim meja_green As Object = My.Resources.meja_billard_green_150
        meja.Image = meja_green
    End Sub

    Public Sub reset_counter(i As Integer, lbl As Label)
        hour(i) = 0
        day(i) = 0
        min(i) = 0
        sec(i) = 0
        lbl.Text = day(i) & " : " & hour(i) & " : " & min(i) & " : " & sec(i)
    End Sub

    Public Sub timer_counter(la As Label, i As Integer)
        sec(i) += 1
        la.Text = day(i) & " : " & hour(i) & " : " & min(i) & " : " & sec(i)
        If sec(i) = 60 Then
            sec(i) = 0
            min(i) += 1
            la.Text = day(i) & " : " & hour(i) & " : " & min(i) & " : " & sec(i)
            If min(i) = 60 Then
                min(i) = 0
                hour(i) += 1
                la.Text = day(i) & " : " & hour(i) & " : " & min(i) & " : " & sec(i)
                If hour(i) = 24 Then
                    hour(i) = 0
                    day(i) += 1
                    la.Text = day(i) & " : " & hour(i) & " : " & min(i) & " : " & sec(i)
                End If
            End If
        End If
    End Sub

    Private Sub meja1_Click(sender As Object, e As EventArgs) Handles meja1.Click
        Dim str() As String
        str = meja1.Text.Split(" ")
        control_meja(str(1), TimerMeja_1, meja1, LabelTimer1)
    End Sub

    Private Sub meja2_Click(sender As Object, e As EventArgs) Handles meja2.Click
        Dim str() As String
        str = meja2.Text.Split(" ")
        control_meja(str(1), TimerMeja_2, meja2, LabelTimer2)
    End Sub

    Private Sub meja3_Click(sender As Object, e As EventArgs) Handles meja3.Click
        Dim str() As String
        str = meja3.Text.Split(" ")
        control_meja(str(1), TimerMeja_3, meja3, LabelTimer3)
    End Sub

    Private Sub meja4_Click(sender As Object, e As EventArgs) Handles meja4.Click
        Dim str() As String
        str = DirectCast(sender, Button).Text.Split(" ") 'SPLIT THE BUTTON TEXT
        control_meja(str(1), TimerMeja_4, meja4, LabelTimer4)
    End Sub

    Private Sub meja5_Click(sender As Object, e As EventArgs) Handles meja5.Click
        Dim str() As String
        str = DirectCast(sender, Button).Text.Split(" ") 'SPLIT THE BUTTON TEXT
        control_meja(str(1), TimerMeja_5, meja5, LabelTimer5)
    End Sub

    Private Sub meja6_Click(sender As Object, e As EventArgs) Handles meja6.Click
        Dim str() As String
        str = DirectCast(sender, Button).Text.Split(" ") 'SPLIT THE BUTTON TEXT
        control_meja(str(1), TimerMeja_6, meja6, LabelTimer6)
    End Sub

    Private Sub meja7_Click(sender As Object, e As EventArgs) Handles meja7.Click
        Dim str() As String
        str = DirectCast(sender, Button).Text.Split(" ") 'SPLIT THE BUTTON TEXT
        control_meja(str(1), TimerMeja_7, meja7, LabelTimer7)
    End Sub

    Private Sub meja8_Click(sender As Object, e As EventArgs) Handles meja8.Click
        Dim str() As String
        str = DirectCast(sender, Button).Text.Split(" ") 'SPLIT THE BUTTON TEXT
        control_meja(str(1), TimerMeja_8, meja8, LabelTimer8)
    End Sub

    Private Sub meja9_Click(sender As Object, e As EventArgs) Handles meja9.Click
        Dim str() As String
        str = DirectCast(sender, Button).Text.Split(" ") 'SPLIT THE BUTTON TEXT
        control_meja(str(1), TimerMeja_9, meja9, LabelTimer9)
    End Sub

    Private Sub meja10_Click(sender As Object, e As EventArgs) Handles meja10.Click
        Dim str() As String
        str = DirectCast(sender, Button).Text.Split(" ") 'SPLIT THE BUTTON TEXT
        control_meja(str(1), TimerMeja_10, meja10, LabelTimer10)
    End Sub

    Private Sub meja11_Click(sender As Object, e As EventArgs) Handles meja11.Click
        Dim str() As String
        str = DirectCast(sender, Button).Text.Split(" ") 'SPLIT THE BUTTON TEXT
        control_meja(str(1), TimerMeja_11, meja11, LabelTimer11)
    End Sub

    Private Sub meja12_Click(sender As Object, e As EventArgs) Handles meja12.Click
        Dim str() As String
        str = DirectCast(sender, Button).Text.Split(" ") 'SPLIT THE BUTTON TEXT
        control_meja(str(1), TimerMeja_12, meja12, LabelTimer12)
    End Sub

    Private Sub meja13_Click(sender As Object, e As EventArgs) Handles meja13.Click
        Dim str() As String
        str = DirectCast(sender, Button).Text.Split(" ") 'SPLIT THE BUTTON TEXT
        control_meja(str(1), TimerMeja_13, meja13, LabelTimer13)
    End Sub

    Private Sub meja14_Click(sender As Object, e As EventArgs) Handles meja14.Click
        Dim str() As String
        str = DirectCast(sender, Button).Text.Split(" ") 'SPLIT THE BUTTON TEXT
        control_meja(str(1), TimerMeja_14, meja14, LabelTimer14)
    End Sub

    Private Sub meja15_Click(sender As Object, e As EventArgs) Handles meja15.Click
        Dim str() As String
        str = DirectCast(sender, Button).Text.Split(" ") 'SPLIT THE BUTTON TEXT
        control_meja(str(1), TimerMeja_15, meja15, LabelTimer15)
    End Sub

    Private Sub meja16_Click(sender As Object, e As EventArgs) Handles meja16.Click
        Dim str() As String
        str = DirectCast(sender, Button).Text.Split(" ") 'SPLIT THE BUTTON TEXT
        control_meja(str(1), TimerMeja_16, meja16, LabelTimer16)
    End Sub

    Private Sub meja17_Click(sender As Object, e As EventArgs) Handles meja17.Click
        Dim str() As String
        str = DirectCast(sender, Button).Text.Split(" ") 'SPLIT THE BUTTON TEXT
        control_meja(str(1), TimerMeja_17, meja17, LabelTimer17)
    End Sub

    Private Sub meja18_Click(sender As Object, e As EventArgs) Handles meja18.Click
        Dim str() As String
        str = DirectCast(sender, Button).Text.Split(" ") 'SPLIT THE BUTTON TEXT
        control_meja(str(1), TimerMeja_18, meja18, LabelTimer18)
    End Sub

    Private Sub meja19_Click(sender As Object, e As EventArgs) Handles meja19.Click
        Dim str() As String
        str = DirectCast(sender, Button).Text.Split(" ") 'SPLIT THE BUTTON TEXT
        control_meja(str(1), TimerMeja_19, meja19, LabelTimer19)
    End Sub

    Private Sub meja20_Click(sender As Object, e As EventArgs) Handles meja20.Click
        Dim str() As String
        str = DirectCast(sender, Button).Text.Split(" ") 'SPLIT THE BUTTON TEXT
        control_meja(str(1), TimerMeja_20, meja20, LabelTimer20)
    End Sub

    Private Sub TimerMeja_1_Tick(sender As Object, e As EventArgs) Handles TimerMeja_1.Tick
        Dim str() As String
        str = meja1.Text.Split(" ")
        timer_counter(LabelTimer1, Convert.ToInt32(str(1)))
    End Sub

    Private Sub TimerMeja_2_Tick(sender As Object, e As EventArgs) Handles TimerMeja_2.Tick
        Dim str() As String
        str = meja2.Text.Split(" ")
        timer_counter(LabelTimer2, Convert.ToInt32(str(1)))
    End Sub

    Private Sub TimerMeja_3_Tick(sender As Object, e As EventArgs) Handles TimerMeja_3.Tick
        Dim str() As String
        str = meja3.Text.Split(" ")
        timer_counter(LabelTimer3, Convert.ToInt32(str(1)))
    End Sub

    Private Sub TimerMeja_4_Tick(sender As Object, e As EventArgs) Handles TimerMeja_4.Tick
        Dim str() As String
        str = meja1.Text.Split(" ")
        timer_counter(LabelTimer4, Convert.ToInt32(str(1)))
    End Sub

    Private Sub TimerMeja_5_Tick(sender As Object, e As EventArgs) Handles TimerMeja_5.Tick
        Dim str() As String
        str = meja1.Text.Split(" ")
        timer_counter(LabelTimer5, Convert.ToInt32(str(1)))
    End Sub

    Private Sub TimerMeja_6_Tick(sender As Object, e As EventArgs) Handles TimerMeja_6.Tick
        Dim str() As String
        str = meja1.Text.Split(" ")
        timer_counter(LabelTimer6, Convert.ToInt32(str(1)))
    End Sub

    Private Sub TimerMeja_7_Tick(sender As Object, e As EventArgs) Handles TimerMeja_7.Tick
        Dim str() As String
        str = meja1.Text.Split(" ")
        timer_counter(LabelTimer7, Convert.ToInt32(str(1)))
    End Sub

    Private Sub TimerMeja_8_Tick(sender As Object, e As EventArgs) Handles TimerMeja_8.Tick
        Dim str() As String
        str = meja1.Text.Split(" ")
        timer_counter(LabelTimer8, Convert.ToInt32(str(1)))
    End Sub

    Private Sub TimerMeja_9_Tick(sender As Object, e As EventArgs) Handles TimerMeja_9.Tick
        Dim str() As String
        str = meja1.Text.Split(" ")
        timer_counter(LabelTimer9, Convert.ToInt32(str(1)))
    End Sub

    Private Sub TimerMeja_10_Tick(sender As Object, e As EventArgs) Handles TimerMeja_10.Tick
        Dim str() As String
        str = meja1.Text.Split(" ")
        timer_counter(LabelTimer19, Convert.ToInt32(str(1)))
    End Sub

    Private Sub TimerMeja_11_Tick(sender As Object, e As EventArgs) Handles TimerMeja_11.Tick
        Dim str() As String
        str = meja1.Text.Split(" ")
        timer_counter(LabelTimer11, Convert.ToInt32(str(1)))
    End Sub

    Private Sub TimerMeja_12_Tick(sender As Object, e As EventArgs) Handles TimerMeja_12.Tick
        Dim str() As String
        str = meja1.Text.Split(" ")
        timer_counter(LabelTimer12, Convert.ToInt32(str(1)))
    End Sub

    Private Sub TimerMeja_13_Tick(sender As Object, e As EventArgs) Handles TimerMeja_13.Tick
        Dim str() As String
        str = meja1.Text.Split(" ")
        timer_counter(LabelTimer13, Convert.ToInt32(str(1)))
    End Sub

    Private Sub TimerMeja_14_Tick(sender As Object, e As EventArgs) Handles TimerMeja_14.Tick
        Dim str() As String
        str = meja1.Text.Split(" ")
        timer_counter(LabelTimer14, Convert.ToInt32(str(1)))
    End Sub

    Private Sub TimerMeja_15_Tick(sender As Object, e As EventArgs) Handles TimerMeja_15.Tick
        Dim str() As String
        str = meja1.Text.Split(" ")
        timer_counter(LabelTimer15, Convert.ToInt32(str(1)))
    End Sub

    Private Sub TimerMeja_16_Tick(sender As Object, e As EventArgs) Handles TimerMeja_16.Tick
        Dim str() As String
        str = meja1.Text.Split(" ")
        timer_counter(LabelTimer16, Convert.ToInt32(str(1)))
    End Sub

    Private Sub TimerMeja_17_Tick(sender As Object, e As EventArgs) Handles TimerMeja_17.Tick
        Dim str() As String
        str = meja1.Text.Split(" ")
        timer_counter(LabelTimer17, Convert.ToInt32(str(1)))
    End Sub

    Private Sub TimerMeja_18_Tick(sender As Object, e As EventArgs) Handles TimerMeja_18.Tick
        Dim str() As String
        str = meja1.Text.Split(" ")
        timer_counter(LabelTimer18, Convert.ToInt32(str(1)))
    End Sub

    Private Sub TimerMeja_19_Tick(sender As Object, e As EventArgs) Handles TimerMeja_19.Tick
        Dim str() As String
        str = meja1.Text.Split(" ")
        timer_counter(LabelTimer19, Convert.ToInt32(str(1)))
    End Sub

    Private Sub TimerMeja_20_Tick(sender As Object, e As EventArgs) Handles TimerMeja_20.Tick
        Dim str() As String
        str = meja1.Text.Split(" ")
        timer_counter(LabelTimer20, Convert.ToInt32(str(1)))
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Application.Exit()
    End Sub
End Class