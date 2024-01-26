Public Class draw_line
    Dim btn As Button
    Dim lbl As Label
    'Dim t(10) As Timer
    Dim jlm_mj As Integer = 10
    Dim btncontrol As Integer = 1
    Dim lblcontrol As Integer = 1
    Dim x As Integer = 0
    Dim y As Integer = 0
    Dim x1 As Integer = 0
    Dim y1 As Integer = 0
    Dim sw As Double
    Dim sh As Double
    Dim blt As Integer = 0

    Dim t(jlm_mj) As Timer
    Dim day(jlm_mj) As Integer
    Dim hour(jlm_mj) As Integer
    Dim min(jlm_mj) As Integer
    Dim sec(jlm_mj) As Integer
    Dim meja(jlm_mj) As Integer
    Private Sub draw_line_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sw = Me.Size.Width
        sh = Me.Size.Height
        show_btn()
        show_lbl()
        'Init Array
        For i As Integer = 0 To jlm_mj
            meja(i) = 0
            day(i) = 0
            hour(i) = 0
            min(i) = 0
            sec(i) = 0
        Next
    End Sub

    Public Sub form_resize()
        Me.Refresh()
    End Sub

    Public Sub new_button(i As Integer)
        'Dim lx, ly As Integer
        btn = New Button 'NEW BUTTON
        t(i) = New Timer 'NEW TIMER
        t(i).Interval = 1000
        t(i).Tag = i
        btn.Top = btncontrol * 25
        btn.Left = 100
        btn.Size = New Size(150, 150)
        'btn.Image
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
        btn.TextAlign = ContentAlignment.BottomCenter
        btn.Image = My.Resources.meja_billard_green_150
        btncontrol = btncontrol + 1
        Controls.Add(btn)
        AddHandler btn.Click, AddressOf Me.Button_Click
        AddHandler t(i).Tick, AddressOf Timer_Tick
    End Sub

    Public Sub btn_loc()
        sw = Me.Size.Width
        sh = Me.Size.Height
        Dim lx, ly As Integer
        If y = 0 Then
            ly = 200
        Else
            ly = 200 + (200 * y)
        End If
        lx = 170 * x

        'Console.WriteLine("lx & ly=" & lx & "," & ly)
        btn.Location = New Point(lx, ly)
        If lx < sw - 350 Then
            x = x + 1
        ElseIf ly < sh - 200 Then
            x = 0
            y = y + 1
        Else
            'MsgBox("There is no room for more table")
            Console.WriteLine("There is no room for more table")
        End If

    End Sub

    Public Sub new_btn_loc(ob As Object)
        'Dim obj As Object = Me.Controls
        sw = Me.Size.Width
        sh = Me.Size.Height
        Dim lx, ly As Integer
        If y = 0 Then
            ly = 200
        Else
            ly = 200 + (200 * y)
        End If
        lx = 170 * x

        'Console.WriteLine("lx & ly=" & lx & "," & ly)
        ob.Location = New Point(lx, ly)
        If lx < sw - 350 Then
            x = x + 1
        ElseIf ly < sh - 200 Then
            x = 0
            y = y + 1
        Else
            'MsgBox("There is no room for more table")
            Console.WriteLine("There is no room for more table")
        End If
    End Sub
    Public Sub show_btn()
        For index As Integer = 1 To jlm_mj
            new_button(index)
            btn_loc()
        Next
    End Sub

    Private Sub Button_Click(sender As System.Object, e As System.EventArgs)
        Dim bt As Button = CType(sender, Button)
        Dim n As Integer = CInt(bt.Name)
        Select Case CInt(bt.Name)
            Case 1
                'FormButton.Show()
                control_button(bt, n)
            Case 2
                control_button(bt, n)
            Case 3
                control_button(bt, n)
        End Select
    End Sub

    Public Sub control_button(bt As Button, n As Integer)
        If meja(n) = 0 Then
            meja(n) = 1
            bt.Image = My.Resources.meja_billard_red_150
            t(CInt(bt.Text)).Enabled = True
            t(CInt(bt.Text)).Start()
        Else
            meja(n) = 0
            bt.Image = My.Resources.meja_billard_green_150
            t(CInt(bt.Text)).Stop()
            reset_counter(n)
        End If
    End Sub

    Public Sub reset_counter(i As Integer)
        For Each obj As Object In Me.Controls
            If TypeOf obj Is Windows.Forms.Label Then
                Console.WriteLine(obj.Name)
                If i = CInt(obj.Name) Then
                    obj.Text = day(i) & " : " & hour(i) & " : " & min(i) & " : " & sec(i)
                End If

            End If
        Next
        hour(i) = 0
        day(i) = 0
        min(i) = 0
        sec(i) = 0
        'lbl.Text = day(i) & " "
    End Sub
    Public Sub new_label()
        lbl = New Label
        lbl.Top = lblcontrol * 25
        lbl.Left = 100
        'lbl.Size = New Size(150, 150)
        lbl.Name = lblcontrol.ToString
        lbl.Text = "00:00:00:00"
        lblcontrol = lblcontrol + 1
        Controls.Add(lbl)
    End Sub

    Public Sub lbl_loc()
        Dim lx, ly As Integer
        sw = Me.Size.Width
        sh = Me.Size.Height
        If y1 = 0 Then
            ly = 360
        Else
            ly = 360 + (200 * y1)
        End If
        lx = 170 * x1

        'Console.WriteLine(i & " lx & ly=" & lx & "," & ly)
        lbl.Location = New Point(lx, ly)
        If lx < sw - 350 Then
            x1 = x1 + 1
        ElseIf ly < sh - 200 Then
            x1 = 0
            y1 = y1 + 1
        Else
            'MsgBox("There is no room for more table")
            Console.WriteLine("There is no room for more table")
        End If

    End Sub

    Public Sub new_lbl_loc(ob As Object)
        Dim lx, ly As Integer
        sw = Me.Size.Width
        sh = Me.Size.Height
        If y1 = 0 Then
            ly = 360
        Else
            ly = 360 + (200 * y1)
        End If
        lx = 170 * x1

        'Console.WriteLine(i & " lx & ly=" & lx & "," & ly)
        ob.Location = New Point(lx, ly)
        If lx < sw - 360 Then
            x1 = x1 + 1
        ElseIf ly < sh - 200 Then
            x1 = 0
            y1 = y1 + 1
        Else
            'MsgBox("There is no room for more table")
            Console.WriteLine("There is no room for more table")
        End If

    End Sub

    Public Sub show_lbl()
        For index As Integer = 1 To jlm_mj
            new_label()
            lbl_loc()
        Next
    End Sub

    Private Sub draw_line_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        x = 0
        y = 0
        x1 = 0
        y1 = 0
        For Each obj As Object In Me.Controls
            If TypeOf obj Is Windows.Forms.Button Then
                new_btn_loc(obj)
            End If
        Next
        For Each obj As Object In Me.Controls
            If TypeOf obj Is Windows.Forms.Label Then
                new_lbl_loc(obj)
            End If
        Next
    End Sub

    Private Sub Timer_Tick(sender As System.Object, e As System.EventArgs)
        Dim tm As Timer = CType(sender, Timer)
        Console.WriteLine(tm.Tag)
        Select Case tm.Tag
            Case 1
                For Each obj As Object In Me.Controls
                    If TypeOf obj Is Windows.Forms.Label Then
                        Console.WriteLine(obj.Name)
                        Select Case CInt(obj.Name)
                            Case 1
                                timer_counter(obj, tm.Tag)
                        End Select

                    End If
                Next
            Case 2
                For Each obj As Object In Me.Controls
                    If TypeOf obj Is Windows.Forms.Label Then
                        Console.WriteLine(obj.Name)
                        Select Case CInt(obj.Name)
                            Case 2
                                timer_counter(obj, tm.Tag)
                        End Select

                    End If
                Next
            Case 3
                For Each obj As Object In Me.Controls
                    If TypeOf obj Is Windows.Forms.Label Then
                        Console.WriteLine(obj.Name)
                        Select Case CInt(obj.Name)
                            Case 3
                                timer_counter(obj, tm.Tag)
                        End Select

                    End If
                Next
        End Select
    End Sub

    Public Sub timer_counter(o As Object, i As Integer)
        sec(i) += 1
        o.Text = day(i) & " : " & hour(i) & " : " & min(i) & " : " & sec(i)
        If sec(i) = 60 Then
            sec(i) = 0
            min(i) += 1
            o.Text = day(i) & " : " & hour(i) & " : " & min(i) & " : " & sec(i)
            If min(i) = 60 Then
                min(i) = 0
                hour(i) += 1
                o.Text = day(i) & " : " & hour(i) & " : " & min(i) & " : " & sec(i)
                If hour(i) = 24 Then
                    hour(i) = 0
                    day(i) += 1
                    o.Text = day(i) & " : " & hour(i) & " : " & min(i) & " : " & sec(i)
                End If
            End If
        End If
    End Sub
End Class