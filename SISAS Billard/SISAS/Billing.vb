Imports System.IO
Imports System.Data.Odbc
Public Class Billing
    Dim btn As Button
    Dim lbl As Label
    Dim Pricelbl As Label

    Public login_state As Integer = 0
    Public userlevel As Integer = 0
    Public username As String = ""

    'Dim t(10) As Timer
    Public harga As Integer = 0
    Public harga_mnt As Double = 0
    Public harga_sec As Double = 0
    Public jlm_mj As Integer = 50
    Public btncontrol As Integer = 1
    Public lblcontrol As Integer = 1
    Public pricelblcontrol As Integer = 1
    Public x As Integer = 0
    Public y As Integer = 0
    Public x1 As Integer = 0
    Public y1 As Integer = 0
    Public x2 As Integer = 0
    Public y2 As Integer = 0
    Public sw As Double
    Public sh As Double
    Dim blt As Integer = 0
    Public bill(jlm_mj) As Integer

    Public t(jlm_mj) As Timer
    Public day(jlm_mj) As Integer
    Public hour(jlm_mj) As Integer
    Public min(jlm_mj) As Integer
    Public sec(jlm_mj) As Integer
    Public temp_sec(jlm_mj) As Integer
    Dim meja(jlm_mj) As Integer
    Private Sub Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                Case "Harga_Jam"
                    harga = Convert.ToInt32(dr("set_value"))
                    harga_mnt = get_harga_menit(harga)
                    harga_sec = get_harga_menit(harga)
                Case "Company_Logo"
                    If ModuleClass.FilenameIsOK(dr("set_value")) Then
                        Using fs As New System.IO.FileStream(dr("set_value"), IO.FileMode.Open)
                            company_logo.Image = New Bitmap(Image.FromStream(fs))
                            'OpenFileDialog1.FileName = dr("set_value")
                        End Using
                        'Console.WriteLine(dr("set_value"))
                    Else

                    End If
            End Select
        End While

        'SHOW ALL BUTTON
        'show_btn()
        TextMejaBilliard.Width = Me.Size.Width

        ReDim Preserve meja(jlm_mj)
        ReDim Preserve day(jlm_mj)
        ReDim Preserve hour(jlm_mj)
        ReDim Preserve min(jlm_mj)
        ReDim Preserve sec(jlm_mj)
        ReDim Preserve temp_sec(jlm_mj)
        ReDim Preserve bill(jlm_mj)
        'Init Array
        For i As Integer = 0 To jlm_mj
            bill(i) = 0
            meja(i) = 0
            day(i) = 0
            hour(i) = 0
            min(i) = 0
            sec(i) = 0
            temp_sec(i) = 0
        Next

        show_btn() 'SHOW ALL MEJA BUTTON
        show_lbl() 'SHOW ALL MEJA LABEL

        disable_m()

        'INIT TABLE XML
        init_table_xml()

        'CHECK LOGIN STATE
        loginstate()
        usrlvl()


    End Sub

    Public Sub Billing_refresh()
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
                Case "Harga_Jam"
                    harga = Convert.ToInt32(dr("set_value"))
                    harga_mnt = get_harga_menit(harga)
                    harga_sec = get_harga_menit(harga)
                Case "Company_Logo"
                    If ModuleClass.FilenameIsOK(dr("set_value")) Then
                        Using fs As New System.IO.FileStream(dr("set_value"), IO.FileMode.Open)
                            company_logo.Image = New Bitmap(Image.FromStream(fs))
                            'OpenFileDialog1.FileName = dr("set_value")
                        End Using
                        'Console.WriteLine(dr("set_value"))
                    Else

                    End If
            End Select
        End While

        TextMejaBilliard.Width = Me.Size.Width

        ReDim Preserve meja(jlm_mj)
        ReDim Preserve day(jlm_mj)
        ReDim Preserve hour(jlm_mj)
        ReDim Preserve min(jlm_mj)
        ReDim Preserve sec(jlm_mj)
        ReDim Preserve temp_sec(jlm_mj)
        ReDim Preserve bill(jlm_mj)
        'Init Array
        For i As Integer = 0 To jlm_mj
            bill(jlm_mj) = 0
            meja(i) = 0
            day(i) = 0
            hour(i) = 0
            min(i) = 0
            sec(i) = 0
            temp_sec(i) = 0
        Next
        x = 0
        y = 0
        x1 = 0
        y1 = 0
        x2 = 0
        y2 = 0
        btncontrol = 1
        lblcontrol = 1
        pricelblcontrol = 1
        show_btn() 'SHOW ALL MEJA BUTTON
        show_lbl() 'SHOW ALL MEJA LABEL
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
        Application.Exit()
    End Sub

    Public Sub rmBtn()
        Dim ctlList As New List(Of Control)

        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is Windows.Forms.Button Then
                If IsNumeric(ctl.Name) Then
                    ctlList.Add(ctl)
                End If
            End If
        Next

        For Each ctl In ctlList
            Me.Controls.Remove(ctl)
            ctl.Dispose()
        Next
    End Sub

    Public Sub rmLbl()
        Dim ctlList As New List(Of Control)

        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is Windows.Forms.Label Then
                If IsNumeric(ctl.Name) Then
                    ctlList.Add(ctl)
                End If
            End If
        Next

        For Each ctl In ctlList
            Me.Controls.Remove(ctl)
            ctl.Dispose()
        Next
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

    Private Sub Billing_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.Enabled = True

        login_state1()

    End Sub

    Public Sub disable_m()
        For Each obj As Object In Me.Controls
            If TypeOf obj Is Windows.Forms.Button Then
                DirectCast(obj, Windows.Forms.Button).Enabled = False
            End If
        Next
    End Sub

    Public Sub enable_meja()
        For Each obj As Object In Me.Controls
            If TypeOf obj Is Windows.Forms.Button Then
                DirectCast(obj, Windows.Forms.Button).Enabled = True
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

    Public Sub show_btn()
        For index As Integer = 1 To jlm_mj
            new_button(index)
            btn_loc()
        Next
    End Sub

    Public Sub Button_Click(sender As System.Object, e As System.EventArgs)
        Dim bt As Button = CType(sender, Button)
        Dim n As Integer = 0
        If IsNumeric(bt.Name) Then
            n = CInt(bt.Name)
        Else
            n = 0
        End If
        'Select Case CInt(bt.Name)
        '    Case 1
        '        'FormButton.Show()
        '        control_button(bt, n)
        '    Case 2
        '        control_button(bt, n)
        '    Case 3
        '        control_button(bt, n)
        'End Select
        For i As Integer = 1 To jlm_mj
            If i = n Then
                control_button(bt, n)
            End If
        Next
    End Sub

    Public Sub control_button(bt As Button, n As Integer)
        If meja(n) = 0 Then
            create_xml_node(n)
            meja(n) = 1
            bt.Image = My.Resources.meja_billard_red_150
            t(CInt(bt.Text)).Enabled = True
            t(CInt(bt.Text)).Start()
            start_time(n) 'INSERT INTO XML START TIME
        Else
            meja(n) = 0
            bt.Image = My.Resources.meja_billard_green_150
            t(CInt(bt.Text)).Stop()
            reset_counter(n)
            end_time(n) ' INSERT INTO XML END TIME
            Console.WriteLine(get_xml_data(n))
            insert_into_db(get_xml_data(n))
        End If
    End Sub

    Public Sub insert_into_db(data As String)
        Dim s() As String
        '0-No meja, 1-durasi, 2-total harga, 3- start time, 4-end-time, 5-user
        s = data.Split(",")
        For i As Integer = 0 To (s.Length - 1)
            Console.WriteLine(s(i).ToString)
        Next
        Try
            sql = "INSERT INTO tabbilling (Meja_no, Tanggal, Start_Time, End_Time, Total_Duration, Total_Price, user) VALUES ('" & s(0).ToString & "', '" & s(3).ToString & "', '" & s(4).ToString & "','" & s(5).ToString & "','" & s(1).ToString & "','" & s(2).ToString & "','" & s(6).ToString & "')"
            Console.WriteLine(sql)
            dml = New OdbcCommand(sql, conn)
            dml.ExecuteNonQuery()
            'MessageBox.Show("Data Update successfully")
        Catch ex As Exception

        End Try
    End Sub

    Public Sub reset_counter(i As Integer)
        For Each obj As Object In Me.Controls
            If TypeOf obj Is Windows.Forms.Label Then
                'Console.WriteLine(obj.Name)
                If IsNumeric(obj.Name) Then
                    If i = CInt(obj.Name) Then
                        obj.Text = day(i) & " : " & hour(i) & " : " & min(i) & " : " & sec(i)
                    End If
                End If
            End If
        Next
        hour(i) = 0
        day(i) = 0
        min(i) = 0
        sec(i) = 0
        temp_sec(i) = 0
        bill(i) = 0
        'lbl.Text = day(i) & " "
    End Sub
    

    Public Sub show_lbl()
        For index As Integer = 1 To jlm_mj
            new_label()
            lbl_loc()
            new_label_price()
            lbl_loc_price()
        Next
    End Sub

    Private Sub Billing_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        x = 0
        y = 0
        x1 = 0
        y1 = 0
        x2 = 0
        y2 = 0
        For Each obj As Object In Me.Controls
            If TypeOf obj Is Windows.Forms.Button Then
                new_btn_loc(obj)
            End If
        Next
        For Each obj As Object In Me.Controls
            If TypeOf obj Is Windows.Forms.Label Then
                new_lbl_loc(obj)
                new_lbl_loc_price(obj)
            End If
        Next
    End Sub

    Public Sub Timer_Tick(sender As System.Object, e As System.EventArgs)
        Dim tm As Timer = CType(sender, Timer)
        Dim ctlList As New List(Of Control)
        Dim ctlListPrice As New List(Of Control)
        Dim ctl As Control
        'Console.WriteLine(tm.Tag)
        Dim n As Integer = 0
        If IsNumeric(tm.Tag) Then
            n = CInt(tm.Tag)
        Else
            n = 0
        End If

        For i As Integer = 1 To jlm_mj
            If i = n Then
                ctlList = get_label_list()
                ctlListPrice = get_label_list_price()
                For Each ctl In ctlList
                    If ctl.Name = n Then
                        timer_counter(ctl, n, sec, min, hour, day)
                        calculate_total_bill(n, harga, ctlListPrice)
                        read_write_xml(n) 'UPDATE XML FILE
                    End If
                Next
            End If
        Next
        'Select Case tm.Tag
        '    Case 1
        '        ctlList = get_label_list()
        '        For Each ctl In ctlList
        '            If ctl.Name = 1 Then
        '                timer_counter(ctl, tm.Tag, sec, min, hour, day)
        '            End If
        '        Next
        '    Case 2
        '        ctlList = get_label_list()
        '        For Each ctl In ctlList
        '            If ctl.Name = 2 Then
        '                timer_counter(ctl, tm.Tag, sec, min, hour, day)
        '            End If
        '        Next
        '    Case 3
        '        ctlList = get_label_list()
        '        For Each ctl In ctlList
        '            If ctl.Name = 3 Then
        '                timer_counter(ctl, tm.Tag, sec, min, hour, day)
        '            End If
        '        Next
        '    Case 4
        '    Case 5
        '    Case 6
        '    Case 7
        '    Case 8
        '    Case 9
        '    Case 10
        '    Case 11
        '    Case 12
        '    Case 13
        '    Case 14
        '    Case 15
        '    Case 16
        '    Case 17
        '    Case 18
        '    Case 19
        '    Case 20
        'End Select
    End Sub

    Private Sub ItemListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemListToolStripMenuItem.Click
        Item.Show()
    End Sub

    Private Sub ItemGroupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemGroupToolStripMenuItem.Click
        Item_Group.Show()
    End Sub

    Private Sub ItemUnitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemUnitToolStripMenuItem.Click
        Item_Unit.Show()
    End Sub

    Private Sub POSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles POSToolStripMenuItem.Click
        Item_Meja.Show()
    End Sub
End Class