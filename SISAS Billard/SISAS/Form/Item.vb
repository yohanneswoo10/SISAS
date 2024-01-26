Imports System.Data.Odbc
Imports System.Data.DataTable
Imports System
Imports System.IO
Public Class Item
    Dim p As String = ""
    Private Sub TabControl1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles TabControl1.DrawItem
        Dim g As Graphics
        Dim sText As String

        Dim iX As Integer
        Dim iY As Integer
        Dim sizeText As SizeF

        Dim ctlTab As TabControl

        ctlTab = CType(sender, TabControl)

        g = e.Graphics

        sText = ctlTab.TabPages(e.Index).Text
        sizeText = g.MeasureString(sText, ctlTab.Font)

        iX = e.Bounds.Left + 6
        iY = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2

        g.DrawString(sText, ctlTab.Font, Brushes.Black, iX, iY)
    End Sub

    Private Sub Item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        open_conn()
        load_unit()
        load_group()
        PopulateDataGrid()
    End Sub

    Public Sub load_unit()
        Dim s As String = "Select UnitName from tabunit"
        select_db(s)
        ItemUnit.Items.Add("")
        While dr.Read
            ItemUnit.Items.Add(dr("UnitName"))
        End While
    End Sub

    Public Sub load_group()
        Dim s As String = "Select GroupName from tabitemgroup"
        select_db(s)
        ItemGroup.Items.Add("")
        While dr.Read
            ItemGroup.Items.Add(dr("GroupName"))
        End While
    End Sub

    Private Sub ItemUnit_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ItemUnit.SelectionChangeCommitted
        Console.WriteLine(ItemUnit.SelectedValue)
    End Sub

    Private Sub ItemGroup_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ItemGroup.SelectionChangeCommitted
        Console.WriteLine(ItemUnit.SelectedValue)
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub PopulateDataGrid()
        sql = "select ItemNo, ItemName, ItemGroup, ItemUnit, ItemPrice from tabitem"
        'dml = New OdbcCommand(sql, conn)
        Dim da As New OdbcDataAdapter(sql, conn)
        Dim ds As New DataSet
        Dim dt As New DataTable()
        'da.SelectCommand = dml
        'da.Fill(ds, "users")
        da.Fill(dt)
        ItemList.DataSource = dt
        dt.Columns(0).ColumnName = "Item No"
        dt.Columns(1).ColumnName = "Name"
        dt.Columns(2).ColumnName = "Group"
        dt.Columns(3).ColumnName = "Unit"
        dt.Columns(4).ColumnName = "Price"

    End Sub

    Public Function get_last_id()
        sql = "select ID from tabitem ORDER BY ID DESC LIMIT 1"
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader
        Dim i As Integer = 0
        While dr.Read
            i = dr("ID")
        End While
        Return i
    End Function
    Private Sub ButtonSelect_Click(sender As Object, e As EventArgs) Handles ButtonSelect.Click
        p = OpenWindowBrowser(OpenFileDialog1)
        Try
            Using fs As New System.IO.FileStream(p, IO.FileMode.Open)
                ItemImg.Image = New Bitmap(Image.FromStream(fs))
            End Using
        Catch ex As Exception
            Dim msg As String = "Filename: " & p & Environment.NewLine & Environment.NewLine & "Exception: " & ex.ToString
            MessageBox.Show(msg, "Error Opening Image File")
        End Try
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim pa As String = ""
        'OpenFileDialog1.ShowDialog()
        If StrComp(p, "") Then
            pa = OpenFileDialog1.FileName.Replace("\", "\\")
        Else
            p = ""
        End If

        'Console.WriteLine("path" & pa)

        If IsNumeric(ItemPrice.Text) Then
            Try
                sql = "INSERT INTO tabitem (ItemNo, ItemName, ItemDeskripsi, ItemGroup, ItemUnit, ItemPrice, ItemImage) VALUES ('" _
                    & ItemNo.Text & "', '" & ItemName.Text & "', '" & ItemDesc.Text & "', '" & ItemGroup.SelectedItem & "', '" _
                    & ItemUnit.SelectedItem & "', " & CInt(ItemPrice.Text) & ", '" & pa & "') ON DUPLICATE KEY UPDATE ItemName = '" & ItemName.Text & "', ItemDeskripsi = '" _
                    & ItemDesc.Text & "', ItemGroup ='" & ItemGroup.SelectedItem & "', ItemUnit ='" & ItemUnit.SelectedItem & "', ItemPrice = " & CInt(ItemPrice.Text) & ", ItemImage = '" _
                    & pa & "'"
                dml = New OdbcCommand(sql, conn)
                dml.ExecuteNonQuery()
                'Console.WriteLine(sql)
                MessageBox.Show("Data Insert Successfully")

            Catch ex As Exception
                MsgBox("Terjadi Kesalahan Input Ke database")
            End Try
        Else
            MsgBox("Item Price harus angka")
        End If
        PopulateDataGrid()
        clear_all()
    End Sub

    Private Sub ItemList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemList.CellClick
        Dim i As Integer
        i = ItemList.CurrentRow.Index
        Dim Item_No As String = ItemList.Item(0, i).Value

        sql = "select ItemNo, ItemName, ItemDeskripsi, ItemGroup, ItemUnit, ItemPrice, ItemImage from tabitem where ItemNo ='" & Item_No & "'"
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader

        While dr.Read
            ItemNo.Text = dr("ItemNo")
            ItemName.Text = dr("ItemName")
            ItemDesc.Text = dr("ItemDeskripsi")
            ItemGroup.SelectedItem = dr("ItemGroup")
            ItemUnit.SelectedItem = dr("ItemUnit")
            ItemPrice.Text = dr("ItemPrice")
            If ModuleClass.FilenameIsOK(dr("ItemImage")) Then
                Using fs As New System.IO.FileStream(dr("ItemImage"), IO.FileMode.Open)
                    ItemImg.Image = New Bitmap(Image.FromStream(fs))
                    OpenFileDialog1.FileName = dr("ItemImage")
                End Using
                'Console.WriteLine(dr("ItemImage"))
            Else

            End If
        End While
    End Sub

    Public Sub clear_all()
        ItemNo.Text = ""
        ItemName.Text = ""
        ItemDesc.Text = ""
        ItemGroup.SelectedItem = ""
        ItemUnit.SelectedItem = ""
        ItemPrice.Text = ""
        OpenFileDialog1.FileName = ""
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If String.Compare(ItemNo.Text, "") = 1 Then
            sql = "DELETE FROM tabitem where ItemNo = '" & ItemNo.Text & "'"
            dml = New OdbcCommand(sql, conn)
            dml.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus")
        Else
            MsgBox("Data tidak ada yang dihapus")
        End If
        

        'REFRESH DATAGRID AND TEXTBOX
        PopulateDataGrid()
        clear_all()
    End Sub
End Class