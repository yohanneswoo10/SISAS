Imports System.IO
Module ModuleBtn
    Dim btn As Button
    Dim lbl As Label
    Dim price_lbl As Label

    Public Sub new_button(i As Integer)
        'Dim lx, ly As Integer
        btn = New Button 'NEW BUTTON
        Billing.t(i) = New Timer 'NEW TIMER
        Billing.t(i).Interval = 1000
        Billing.t(i).Tag = i
        btn.Top = Billing.btncontrol * 25
        btn.Left = 100
        btn.Size = New Size(150, 150)

        'Control the button
        btn.Name = Billing.btncontrol.ToString
        btn.Text = Billing.btncontrol.ToString
        btn.Enabled = False
        btn.TextAlign = ContentAlignment.BottomCenter
        btn.Image = My.Resources.meja_billard_green_150
        Billing.btncontrol = Billing.btncontrol + 1
        Billing.Controls.Add(btn)
        AddHandler btn.Click, AddressOf Billing.Button_Click
        AddHandler Billing.t(i).Tick, AddressOf Billing.Timer_Tick
    End Sub

    Public Sub btn_loc()
        Billing.sw = Billing.Size.Width
        Billing.sh = Billing.Size.Height
        Dim lx, ly As Integer
        If Billing.y = 0 Then
            ly = 160
        Else
            ly = 160 + (200 * Billing.y)
        End If
        lx = 170 * Billing.x

        'Console.WriteLine("lx & ly=" & lx & "," & ly)
        btn.Location = New Point(lx, ly)
        If lx < Billing.sw - 350 Then
            Billing.x = Billing.x + 1
        ElseIf ly < Billing.sh - 200 Then
            Billing.x = 0
            Billing.y = Billing.y + 1
        Else
            'MsgBox("There is no room for more table")
            Console.WriteLine("There is no room for more table")
        End If

    End Sub

    Public Sub new_btn_loc(ob As Object)
        'Dim obj As Object = Me.Controls
        Billing.sw = Billing.Size.Width
        Billing.sh = Billing.Size.Height
        Dim lx, ly As Integer
        If IsNumeric(ob.Name) Then
            If Billing.y = 0 Then
                ly = 160
            Else
                ly = 160 + (200 * Billing.y)
            End If
            lx = 170 * Billing.x

            'Console.WriteLine("lx & ly=" & lx & "," & ly)
            ob.Location = New Point(lx, ly)
            If lx < Billing.sw - 300 Then
                Billing.x = Billing.x + 1
            ElseIf ly < Billing.sh - 200 Then
                Billing.x = 0
                Billing.y = Billing.y + 1
            Else
                'MsgBox("There is no room for more table")
                Console.WriteLine("There is no room for more table")
            End If
        End If
    End Sub

    Public Sub new_label()
        lbl = New Label
        lbl.Top = Billing.lblcontrol * 25
        lbl.Left = 100
        'lbl.Size = New Size(150, 150)
        lbl.Name = Billing.lblcontrol.ToString
        lbl.Text = "Durasi: " & "0 : 0 : 0 : 0"
        Billing.lblcontrol = Billing.lblcontrol + 1
        Billing.Controls.Add(lbl)
    End Sub

    Public Sub lbl_loc()
        Dim lx, ly As Integer
        Billing.sw = Billing.Size.Width
        Billing.sh = Billing.Size.Height
        lx = 0
        If Billing.y1 = 0 Then
            ly = 310
        Else
            ly = 310 + (200 * Billing.y1)
        End If
        lx = lx + (170 * Billing.x1)

        'Console.WriteLine(i & " lx & ly=" & lx & "," & ly)
        lbl.Location = New Point(lx, ly)
        If lx < Billing.sw - 360 Then
            Billing.x1 = Billing.x1 + 1
        ElseIf ly < Billing.sh - 200 Then
            Billing.x1 = 0
            Billing.y1 = Billing.y1 + 1
        Else
            'MsgBox("There is no room for more table")
            Console.WriteLine("There is no room for more table")
        End If

    End Sub

    Public Sub new_lbl_loc(ob As Object)
        Dim lx, ly As Integer
        Billing.sw = Billing.Size.Width
        Billing.sh = Billing.Size.Height
        If IsNumeric(ob.Name) Then
            If Billing.y1 = 0 Then
                ly = 310
            Else
                ly = 310 + (200 * Billing.y1)
            End If
            lx = lx + (170 * Billing.x1)

            'Console.WriteLine(i & " lx & ly=" & lx & "," & ly)
            ob.Location = New Point(lx, ly)
            If lx < Billing.sw - 200 Then
                Billing.x1 = Billing.x1 + 1
            ElseIf ly < Billing.sh - 200 Then
                Billing.x1 = 0
                Billing.y1 = Billing.y1 + 1
            Else
                'MsgBox("There is no room for more table")
                Console.WriteLine("There is no room for more table")
            End If
        End If
    End Sub

    Public Sub new_label_price()
        price_lbl = New Label
        price_lbl.Top = Billing.pricelblcontrol * 25
        price_lbl.Left = 100
        Dim x As Integer = 0
        'lbl.Size = New Size(150, 150)
        price_lbl.Name = "Price_" & Billing.pricelblcontrol.ToString
        price_lbl.Text = "Harga: Rp " & FormatNumber(x, 0, TriState.True) & vbCrLf
        Billing.pricelblcontrol = Billing.pricelblcontrol + 1
        Billing.Controls.Add(price_lbl)
    End Sub

    Public Sub lbl_loc_price()
        Dim lx, ly As Integer
        Billing.sw = Billing.Size.Width
        Billing.sh = Billing.Size.Height
        lx = 0
        If Billing.y2 = 0 Then
            ly = 333
        Else
            ly = 333 + (200 * Billing.y2)
        End If
        lx = lx + (170 * Billing.x2)

        'Console.WriteLine(i & " lx & ly=" & lx & "," & ly)
        price_lbl.Location = New Point(lx, ly)
        If lx < Billing.sw - 360 Then
            Billing.x2 = Billing.x2 + 1
        ElseIf ly < Billing.sh - 200 Then
            Billing.x2 = 0
            Billing.y2 = Billing.y2 + 1
        Else
            'MsgBox("There is no room for more table")
            Console.WriteLine("There is no room for more table")
        End If

    End Sub

    Public Sub new_lbl_loc_price(ob As Object)
        Dim lx, ly As Integer
        Billing.sw = Billing.Size.Width
        Billing.sh = Billing.Size.Height
        Dim str() As String

        'Convert.ToInt32(str(1)))
        'Console.WriteLine(ob.Name)
        If IsNumeric(ob.Name) = False Then
            str = ob.Name.Split("_")
            If String.Compare(str(0), "Price", True) = 0 Then
                'Console.WriteLine(str(0))
                If IsNumeric(str(1)) Then
                    If Billing.y2 = 0 Then
                        ly = 333
                    Else
                        ly = 333 + (200 * Billing.y2)
                    End If
                    lx = lx + (170 * Billing.x2)

                    'Console.WriteLine(i & " lx & ly=" & lx & "," & ly)
                    ob.Location = New Point(lx, ly)
                    If lx < Billing.sw - 200 Then
                        Billing.x2 = Billing.x2 + 1
                    ElseIf ly < Billing.sh - 200 Then
                        Billing.x2 = 0
                        Billing.y2 = Billing.y2 + 1
                    Else
                        'MsgBox("There is no room for more table")
                        Console.WriteLine("There is no room for more table")
                    End If
                End If
            End If
        End If

    End Sub

    Public Function OpenWindowBrowser(ByRef FileDialog As OpenFileDialog) As String
        ' Call ShowDialog.
        Dim result As DialogResult = FileDialog.ShowDialog()
        Dim path As String = ""
        ' Test result.
        If result = Windows.Forms.DialogResult.OK Then

            ' Get the file name.
            path = FileDialog.FileName
            Try
                ' Read in text.
                'Dim text As String = File.ReadAllText(path)

                ' For debugging.
                'Me.Text = text.Length.ToString
                Console.WriteLine(path)
            Catch ex As Exception
                Return "Error"
            End Try
        End If
        Return path
    End Function
End Module
