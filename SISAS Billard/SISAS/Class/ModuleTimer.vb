Module ModuleTimer
    Public Function get_button_list()
        Dim ctlList As New List(Of Control)

        For Each ctl As Control In Billing.Controls
            If TypeOf ctl Is Windows.Forms.Button Then
                If IsNumeric(ctl.Name) Then
                    ctlList.Add(ctl)
                End If
            End If
        Next
        Return ctlList
    End Function

    Public Function get_label_list()
        Dim ctlList As New List(Of Control)

        For Each ctl As Control In Billing.Controls
            If TypeOf ctl Is Windows.Forms.Label Then
                If IsNumeric(ctl.Name) Then
                    ctlList.Add(ctl)
                End If
            End If
        Next
        Return ctlList
    End Function

    Public Function get_label_list_price()
        Dim ctlList As New List(Of Control)
        Dim str() As String
        For Each ctl As Control In Billing.Controls
            If TypeOf ctl Is Windows.Forms.Label Then
                If IsNumeric(ctl.Name) = False Then
                    str = ctl.Name.Split("_")
                    If String.Compare(str(0), "Price", True) = 0 Then
                        ctlList.Add(ctl)
                    End If
                End If
            End If
        Next
        Return ctlList
    End Function

    Public Sub timer_counter(o As Object, i As Integer, ByRef sec() As Integer, ByRef min() As Integer, ByRef hour() As Integer, ByRef day() As Integer)
        Billing.temp_sec(i) += 1
        sec(i) += 1
        o.Text = "Durasi: " & day(i) & " : " & hour(i) & " : " & min(i) & " : " & sec(i)
        If sec(i) = 60 Then
            sec(i) = 0
            min(i) += 1
            o.Text = "Durasi: " & day(i) & " : " & hour(i) & " : " & min(i) & " : " & sec(i)
            If min(i) = 60 Then
                min(i) = 0
                hour(i) += 1
                o.Text = "Durasi: " & day(i) & " : " & hour(i) & " : " & min(i) & " : " & sec(i)
                If hour(i) = 24 Then
                    hour(i) = 0
                    day(i) += 1
                    o.Text = "Durasi: " & day(i) & " : " & hour(i) & " : " & min(i) & " : " & sec(i)
                End If
            End If
        End If
    End Sub

    Public Sub calculate_total_bill(i As Integer, p As Integer, ctllist As List(Of Control))
        Dim str() As String
        Billing.bill(i) = Billing.temp_sec(i) * get_harga_sec(p)
        For Each ctl In ctllist
            If IsNumeric(ctl.Name) = False Then
                str = ctl.Name.Split("_")
                If String.Compare(str(0), "Price", True) = 0 Then
                    If IsNumeric(str(1)) Then
                        If CInt(str(1)) = i Then
                            ctl.Text = "Harga: Rp " & FormatNumber(Billing.bill(i), 0, TriState.True) & vbCrLf
                        End If
                    End If
                End If
            End If

            
        Next
    End Sub
    Public Function get_harga_menit(h As Integer)
        Dim p As Integer
        p = h / 60
        Return p
    End Function

    Public Function get_harga_sec(h As Integer)
        Dim p As Integer
        p = h / 360
        Return p
    End Function
End Module
