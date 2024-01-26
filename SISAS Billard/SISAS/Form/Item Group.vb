Imports System.Data.Odbc
Imports System.Data.DataTable
Imports System
Public Class Item_Group

    Private Sub Item_Group_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        open_conn()
        PopulateDataGrid()
        Dim id As Integer = get_last_id()
        LabelID.Text = (id + 1).ToString
    End Sub

    Private Sub PopulateDataGrid()
        sql = "select ID, GroupName from tabitemgroup"
        'dml = New OdbcCommand(sql, conn)
        Dim da As New OdbcDataAdapter(sql, conn)
        Dim ds As New DataSet
        Dim dt As New DataTable()
        'da.SelectCommand = dml
        'da.Fill(ds, "users")
        da.Fill(dt)
        DataItemGroup.DataSource = dt
        dt.Columns(1).ColumnName = "Item Group"
        'dt.Columns.Add("Password")
        
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        Dim s As String = ItemGroup.Text
        Dim id As Integer
        id = CInt(LabelID.Text)
        sql = "insert into tabitemgroup (ID, GroupName) values (" & id & ",'" & s & "') ON DUPLICATE KEY UPDATE GroupName = '" & s & "'"
        dml = New OdbcCommand(sql, conn)
        dml.ExecuteNonQuery()
        MsgBox("Data Berhasil di Simpan")
        ItemGroup.Text = ""
        PopulateDataGrid()
        clear_all()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        sql = "DELETE FROM tabitemgroup where GroupName = '" & ItemGroup.Text & "'"
        dml = New OdbcCommand(sql, conn)
        dml.ExecuteNonQuery()
        MsgBox("Data berhasil di delete")

        'REFRESH DATAGRID AND TEXTBOX
        PopulateDataGrid()
        clear_all()
    End Sub

    Private Sub DataItemGroup_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataItemGroup.CellClick
        Dim i As Integer
        i = DataItemGroup.CurrentRow.Index
        ItemGroup.Text = DataItemGroup.Item(1, i).Value
        LabelID.Text = DataItemGroup.Item(0, i).Value
    End Sub

    Public Function get_last_id() As Integer
        sql = "select ID from tabitemgroup ORDER BY ID DESC LIMIT 1"
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader
        Dim i As Integer = 0
        While dr.Read
            i = dr("ID")
        End While
        Return i
    End Function

    Public Sub clear_all()
        LabelID.Text = (get_last_id() + 1).ToString
        ItemGroup.Text = ""
    End Sub
End Class