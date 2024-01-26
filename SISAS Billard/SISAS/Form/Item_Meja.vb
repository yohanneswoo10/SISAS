Imports System.Data.Odbc
Imports System.Data.DataTable
Imports System
Imports System.IO
Public Class Item_Meja
    Dim igroup As Button
    Dim btnitem As Button
    Dim itemList As RadioButton

    Dim btncontrol As Integer = 1
    Dim btncontrolitem As Integer = 1
    Public x As Integer = 0
    Public y As Integer = 0
    Public x1 As Integer = 0
    Public y1 As Integer = 0
    Public x2 As Integer = 0
    Public y2 As Integer = 0
    Dim q As Integer = 0
    Dim p As String = ""
    Private Sub Item_Meja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        open_conn()
        get_all_group()
        init_datagrid()
    End Sub

    Public Sub get_all_group()
        sql = "select * from tabitemgroup"
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader
        While dr.Read
            display_item_group_button(dr("GroupName"), CInt(dr("ID")))
        End While
    End Sub

    Public Sub display_item_group_button(name As String, i As Integer)
        igroup = New Windows.Forms.Button
        igroup.Top = btncontrol * 25
        igroup.Left = 100
        igroup.Size = New Size(100, 100)

        igroup.Name = "group-" & btncontrol.ToString
        igroup.Text = name
        igroup.Tag = name
        igroup.Enabled = True
        igroup.TextAlign = ContentAlignment.BottomCenter
        'igroup.Image = My.Resources.meja_billard_green_150
        btncontrol = btncontrol + 1
        PanelGroup.Controls.Add(igroup)
        AddHandler igroup.Click, AddressOf Group_Button_Click

        Dim lx, ly As Integer
        If y = 0 Then
            ly = 5
        Else
            ly = 5 + (105 * y)
        End If
        lx = 5

        'Console.WriteLine("lx & ly=" & lx & "," & ly)
        igroup.Location = New Point(lx, ly)
        y = y + 1
        
    End Sub

    Public Sub Group_Button_Click(sender As System.Object, e As System.EventArgs)
        Dim bt As Button = CType(sender, Button)
        Dim n As Integer = 0
        Dim s() As String = Split(bt.Name, "-")
        Console.WriteLine(s(0))
        If IsNumeric(s(1)) Then
            n = CInt(s(1))
        Else
            n = 0
        End If
        rmBtn()
        get_all_item(bt)

    End Sub

    Public Sub get_all_item(bt As Button)
        sql = "select ItemNo, ItemName, ItemDeskripsi, ItemGroup, ItemUnit, ItemPrice, ItemImage from tabitem WHERE ItemGroup='" & bt.Tag & "'"
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader

        While dr.Read
            'display_item_button(dr("ItemName"), dr("ItemImage"))
            display_item_button_radio(dr("ItemName"), dr("ItemImage"), dr("ItemNo"))
        End While
    End Sub

    Public Sub display_item_button(name As String, img As String)

        btnitem = New Windows.Forms.Button
        btnitem.Top = btncontrolitem * 25
        btnitem.Left = 100
        btnitem.Size = New Size(100, 100)

        btnitem.Name = "item-" & btncontrolitem.ToString
        btnitem.Text = name
        btnitem.Tag = name
        btnitem.Enabled = True
        btnitem.TextAlign = ContentAlignment.BottomCenter
        'btnitem.Image = img
        'p = OpenWindowBrowser(OpenFileDialogItem)

        If ModuleClass.FilenameIsOK(img) Then
            Try
                Using fs As New System.IO.FileStream(img, IO.FileMode.Open)
                    Dim img1 As New Bitmap(fs)
                    Dim img2 As New Bitmap(img1, 100, 100)
                    btnitem.Image = img2
                End Using
            Catch ex As Exception
                Dim msg As String = "Filename: " & p & Environment.NewLine & Environment.NewLine & "Exception: " & ex.ToString
                MessageBox.Show(msg, "Error Opening Image File")
            End Try
        End If


        btncontrolitem = btncontrolitem + 1
        PanelItem.Controls.Add(btnitem)
        'AddHandler btnitem.Click, AddressOf Item_Button_Click

        Dim lx, ly As Integer
        lx = 0
        If y1 = 0 Then
            ly = 5
        Else
            ly = 5 + (105 * y1)
        End If
        lx = lx + (105 * x1)

        'Console.WriteLine("lx & ly=" & lx & "," & ly)
        btnitem.Location = New Point(lx, ly)
        If lx < 200 Then
            x1 = x1 + 1
        Else
            x1 = 0
            y1 = y1 + 1
        End If
    End Sub

    Public Sub display_item_button_radio(name As String, img As String, itemno As String)
        itemList = New Windows.Forms.RadioButton
        itemList.Top = btncontrolitem * 25
        itemList.Left = 100
        itemList.MinimumSize = New Size(100, 100)

        itemList.Name = "item-" & btncontrolitem.ToString
        itemList.Text = name
        itemList.Tag = itemno
        itemList.TextAlign = ContentAlignment.BottomCenter
        itemList.Appearance = Appearance.Button
        'btnitem.Image = img
        'p = OpenWindowBrowser(OpenFileDialogItem)

        If ModuleClass.FilenameIsOK(img) Then
            Try
                Using fs As New System.IO.FileStream(img, IO.FileMode.Open)
                    Dim img1 As New Bitmap(fs)
                    Dim img2 As New Bitmap(img1, 100, 100)
                    itemList.Image = img2
                End Using
            Catch ex As Exception
                Dim msg As String = "Filename: " & p & Environment.NewLine & Environment.NewLine & "Exception: " & ex.ToString
                MessageBox.Show(msg, "Error Opening Image File")
            End Try
        End If


        btncontrolitem = btncontrolitem + 1
        PanelItem.Controls.Add(itemList)
        'AddHandler btnitem.Click, AddressOf Item_Button_Click

        Dim lx, ly As Integer
        lx = 0
        If y1 = 0 Then
            ly = 5
        Else
            ly = 5 + (105 * y1)
        End If
        lx = lx + (105 * x1)

        'Console.WriteLine("lx & ly=" & lx & "," & ly)
        itemList.Location = New Point(lx, ly)
        If lx < 200 Then
            x1 = x1 + 1
        Else
            x1 = 0
            y1 = y1 + 1
        End If

    End Sub

    Public Sub rmBtn()
        Dim ctlList As New List(Of Control)

        For Each ctl As Control In PanelItem.Controls
            If TypeOf ctl Is Windows.Forms.RadioButton Then
                Dim s() As String = Split(ctl.Name, "-")
                If IsNumeric(s(1)) Then
                    ctlList.Add(ctl)
                End If
            End If
        Next

        For Each ctl In ctlList
            Me.Controls.Remove(ctl)
            ctl.Dispose()
        Next

        btncontrolitem = 1
        x1 = 0
        y1 = 0
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Dim rbtn As RadioButton
        For Each ctl As Control In PanelItem.Controls
            If TypeOf ctl Is Windows.Forms.RadioButton Then
                rbtn = DirectCast(ctl, RadioButton)
                If rbtn.Checked Then
                    Console.WriteLine(rbtn.Tag)
                    sql = "select ItemNo, ItemName, ItemDeskripsi, ItemGroup, ItemUnit, ItemPrice, ItemImage from tabitem WHERE ItemNo='" & rbtn.Tag & "'"
                    dml = New OdbcCommand(sql, conn)
                    dr = dml.ExecuteReader
                    While dr.Read
                        Dim row As String() = New String() {dr("ItemName"), q.ToString, dr("ItemPrice"), (q * CInt(dr("ItemPrice"))).ToString}
                        DataGridViewItem.Rows.Add(row)
                    End While
                    Exit For
                End If
            End If
        Next
        'Dim row As String() = New String() {"1", "Product 1", "1000"}
        'DataGridViewItem.Rows.Add(row)
    End Sub

    Public Sub init_datagrid()
        DataGridViewItem.ColumnCount = 4
        DataGridViewItem.Columns(0).Name = "Item"
        DataGridViewItem.Columns(1).Name = "Qty"
        DataGridViewItem.Columns(2).Name = "Harga"
        DataGridViewItem.Columns(3).Name = "Total"
    End Sub
End Class