Imports System.IO
Imports System.Data.Odbc
Public Class Preferences
    Dim p As String = ""
    Private Sub Preferences_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'GET DATA FROM DATABASE
        open_conn()
        Dim s As String
        s = "Select * from tabsetting"
        select_db(s)
        While dr.Read
            Select Case dr("set_name")
                Case "Company_Name"
                    company_name.Text = dr("set_value")
                    Console.WriteLine(dr("set_value"))
                Case "Company_address"
                    company_address.Text = dr("set_value")
                    Console.WriteLine(dr("set_value"))
                Case "Jumlah_Meja"
                    jlm_meja.Text = dr("set_value")
                    Console.WriteLine(dr("set_value"))
                Case "Harga_Jam"
                    harga_jam.Text = dr("set_value")
                    Console.WriteLine(dr("set_value"))
                Case "Company_Logo"
                    If ModuleClass.FilenameIsOK(dr("set_value")) Then
                        Using fs As New System.IO.FileStream(dr("set_value"), IO.FileMode.Open)
                            company_logo.Image = New Bitmap(Image.FromStream(fs))
                            OpenFileDialog1.FileName = dr("set_value")
                        End Using
                        Console.WriteLine(dr("set_value"))
                    Else

                    End If
            End Select
        End While
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub select_btn_Click(sender As Object, e As EventArgs) Handles select_btn.Click
        ' Call ShowDialog.
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()

        ' Test result.
        If result = Windows.Forms.DialogResult.OK Then

            ' Get the file name.
            Dim path As String = OpenFileDialog1.FileName
            Try
                ' Read in text.
                Dim text As String = File.ReadAllText(path)

                ' For debugging.
                'Me.Text = text.Length.ToString
                'Console.WriteLine(path)

                Try
                    Using fs As New System.IO.FileStream(path, IO.FileMode.Open)
                        company_logo.Image = New Bitmap(Image.FromStream(fs))
                        p = path
                    End Using
                Catch ex As Exception
                    Dim msg As String = "Filename: " & path & Environment.NewLine & Environment.NewLine & "Exception: " & ex.ToString
                    MessageBox.Show(msg, "Error Opening Image File")
                End Try
            Catch ex As Exception

                ' Report an error.
                Me.Text = "Error"

            End Try
        End If

    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click

        Billing.rmBtn()
        Billing.rmLbl()
        'SAVE TO DATABASE
        Dim pa As String
        'OpenFileDialog1.ShowDialog()
        pa = OpenFileDialog1.FileName.Replace("\", "\\")
        Console.WriteLine("path" + pa)
        Try
            sql = "INSERT INTO tabsetting (set_id, set_value) VALUES (1, '" & company_name.Text & "'),(2, '" & company_address.Text & "'),(3, '" & jlm_meja.Text & "'),(4, '" & harga_jam.Text & "'),(5, '" & pa.ToString() & "') ON DUPLICATE KEY UPDATE set_value = VALUES(set_value)"
            dml = New OdbcCommand(sql, conn)
            dml.ExecuteNonQuery()

            MessageBox.Show("Data Update successfully")
            Billing.Billing_refresh()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub harga_jam_TextChanged(sender As Object, e As EventArgs) Handles harga_jam.TextChanged
        Dim h As String
        Dim harga As Integer
        h = harga_jam.Text
        If h = "" Then
            h = 0
        Else
            harga = Convert.ToInt32(h)
        End If
        TextMnt.Text = ModuleClass.harga_calculation_mnt(harga)
        TextDtk.Text = ModuleClass.harga_calculation_dtk(harga)

    End Sub
End Class