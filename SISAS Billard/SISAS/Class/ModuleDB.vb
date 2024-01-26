Imports System.Data.Odbc
Imports System.Xml
Module ModuleDB
    Public sql As String
    Public dml As OdbcCommand
    Public dr As OdbcDataReader
    Public conn As OdbcConnection
    Public suc As Integer

    Public Sub open_conn()
        Dim db_name, db_ip, db_port, db_user, db_pass As String
        db_name = ""
        db_ip = ""
        db_port = ""
        db_user = ""
        db_pass = ""

        Dim doc As New XmlDocument()
        doc.Load("config.xml")
        Dim nodes As XmlNodeList = doc.DocumentElement.SelectNodes("/Config")
        Dim product_id As String = "", product_name As String = "", product_price As String = ""
        For Each node As XmlNode In nodes
            db_name = node.SelectSingleNode("db_name").InnerText
            db_user = node.SelectSingleNode("db_user").InnerText
            db_pass = node.SelectSingleNode("db_pass").InnerText
            db_ip = node.SelectSingleNode("db_ip").InnerText
            db_port = node.SelectSingleNode("db_port").InnerText
        Next
       
        Dim driver As String
        driver = "DRIVER={MariaDB ODBC 3.1 Driver}; TCPIP=1;SERVER=" & db_ip & ";UID=" & db_user & ";PWD=" & db_pass & ";DATABASE=" & db_name & ";PORT=" & db_port
        'driver = "DRIVER={MariaDB ODBC 3.1 Driver}; TCPIP=1;SERVER=localhost;UID=root;PWD=banindo;DATABASE=sisas;PORT=3306"
        conn = New Odbc.OdbcConnection(driver)
        'conn = New OdbcConnection("DSN=SISAS;")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Public Sub select_db(s As String)
        sql = s
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader
    End Sub

    Public Sub exec_non_query()
        suc = 0
        Try
            dml = New OdbcCommand(sql, conn)
            dml.ExecuteNonQuery()
            suc = 1
        Catch ex As Exception
            suc = 0
        End Try

    End Sub

    Public Function get_setting() As XmlNodeList
        Dim doc As New XmlDocument()
        doc.Load("config.xml")
        Dim nodes As XmlNodeList = doc.DocumentElement.SelectNodes("/Config")
        'Dim product_id As String = "", product_name As String = "", product_price As String = ""
        Return nodes
    End Function

End Module
