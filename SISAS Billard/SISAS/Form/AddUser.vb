Imports System.Data.Odbc
Imports System.Data.DataTable
Imports System

Public Class AddUser
    Dim table As New DataTable("Table")
    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.tabuser' table. You can move, or remove it, as needed.
        Me.TabuserTableAdapter.Fill(Me.DataSet1.tabuser)
        'TODO: This line of code loads data into the 'DataSet1.tablevel' table. You can move, or remove it, as needed.
        Me.TablevelTableAdapter.Fill(Me.DataSet1.tablevel)
        TextBox1.Text = LevelName.SelectedValue
        open_conn()
        PopulateDataGrid()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub ButtonOk_Click(sender As Object, e As EventArgs) Handles ButtonOk.Click

        Dim uname, pass, pass_ency As String
        Dim level_ids As Integer

        uname = TextBoxUname.Text
        pass = TextBoxPass.Text.Trim()
        pass_ency = ModuleClass.Encrypt(pass)
        level_ids = Convert.ToInt32(TextBox1.Text)
        'Console.WriteLine(ModuleClass.Encrypt(pass))
        sql = "insert into tabuser (Username, password, userLevel) values ('" & uname & "','" & pass_ency & "'," & level_ids & ")"
        dml = New OdbcCommand(sql, conn)
        dml.ExecuteNonQuery()
        MsgBox("Data Berhasil di Simpan")

        'REFRESH DATAGRID AND TEXTBOX
        TextBoxUname.Text = ""
        TextBoxPass.Text = ""
        LevelName.SelectedValue = 1
        TextBox1.Text = LevelName.SelectedValue
        PopulateDataGrid()
    End Sub

    Private Sub LevelName_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles LevelName.SelectionChangeCommitted
        'Console.WriteLine(LevelName.SelectedValue)
        TextBox1.Text = LevelName.SelectedValue
    End Sub

    Private Sub PopulateDataGrid()
        sql = "select * from tabuser"
        'dml = New OdbcCommand(sql, conn)
        Dim da As New OdbcDataAdapter(sql, conn)
        Dim ds As New DataSet
        Dim dt As New DataTable()
        'da.SelectCommand = dml
        'da.Fill(ds, "users")
        da.Fill(dt)
        DataGridViewUser.DataSource = dt
        dt.Columns(2).ColumnName = "Encrypted Password"
        dt.Columns.Add("Password")
        For Each row As DataRow In dt.Rows
            row("Password") = ModuleClass.Decrypt(row("Encrypted Password").ToString)
        Next
    End Sub

    Private Sub DataGridViewUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewUser.CellClick
        Dim i As Integer
        i = DataGridViewUser.CurrentRow.Index
        TextBoxUname.Text = DataGridViewUser.Item(1, i).Value
        TextBoxPass.Text = ModuleClass.Decrypt(DataGridViewUser.Item(2, i).Value.ToString)
        LevelName.SelectedValue = DataGridViewUser.Item(3, i).Value
        TextBox1.Text = DataGridViewUser.Item(3, i).Value
    End Sub

    Private Sub ButtonDel_Click(sender As Object, e As EventArgs) Handles ButtonDel.Click
        sql = "DELETE FROM tabuser where Username = '" & TextBoxUname.Text & "'"
        dml = New OdbcCommand(sql, conn)
        dml.ExecuteNonQuery()
        MsgBox("User berhasil di delete")

        'REFRESH DATAGRID AND TEXTBOX
        TextBoxUname.Text = ""
        TextBoxPass.Text = ""
        LevelName.SelectedValue = 1
        TextBox1.Text = LevelName.SelectedValue
        PopulateDataGrid()
    End Sub

End Class