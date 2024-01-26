Imports System.Data.Odbc
Imports System.Data.DataTable
Imports System
Public Class Item_Unit

    Private Sub Item_Unit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        open_conn()
        PopulateDataGrid()
        Dim id As Integer = get_last_id()
        LabelID.Text = (id + 1).ToString
    End Sub

    Private Sub PopulateDataGrid()
        sql = "select ID, UnitName from tabUnit"
        Dim da As New OdbcDataAdapter(sql, conn)
        Dim ds As New DataSet
        Dim dt As New DataTable()

        da.Fill(dt)
        ItemUnitList.DataSource = dt
        dt.Columns(1).ColumnName = "Item Unit"
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        Dim s As String = ItemUnit.Text
        Dim id As Integer
        id = CInt(LabelID.Text)
        sql = "INSERT INTO tabunit (ID, UnitName) values (" & id & ",'" & s & "') ON DUPLICATE KEY UPDATE UnitName = '" & s & "'"
        dml = New OdbcCommand(sql, conn)
        dml.ExecuteNonQuery()
        MsgBox("Data Berhasil di Simpan")
        ItemUnit.Text = ""
        PopulateDataGrid()
        clear_all()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        sql = "DELETE FROM tabunit where UnitName = '" & ItemUnit.Text & "'"
        dml = New OdbcCommand(sql, conn)
        dml.ExecuteNonQuery()
        MsgBox("Data berhasil di delete")

        'REFRESH DATAGRID AND TEXTBOX
        ItemUnit.Text = ""
        PopulateDataGrid()
        clear_all()
    End Sub

    Private Sub ItemUnitList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemUnitList.CellClick
        Dim i As Integer
        i = ItemUnitList.CurrentRow.Index
        ItemUnit.Text = ItemUnitList.Item(1, i).Value
        LabelID.Text = ItemUnitList.Item(0, i).Value
    End Sub

    Public Function get_last_id() As Integer
        sql = "select ID from tabunit ORDER BY ID DESC LIMIT 1"
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
        ItemUnit.Text = ""
    End Sub
End Class