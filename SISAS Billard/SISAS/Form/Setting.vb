Imports System.Xml
Imports System.IO
Public Class Setting
    
    Private Sub Setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'READ SETTING XML AND DISPLAY IT IF THE PERSON IS AUTHORISE
        If Billing.login_state = 1 Then

            Dim doc As New XmlDocument()
            doc.Load("config.xml")
            Dim nodes As XmlNodeList = doc.DocumentElement.SelectNodes("/Config")
            'Dim product_id As String = "", product_name As String = "", product_price As String = ""
            For Each node As XmlNode In nodes
                TextBoxDBName.Text = node.SelectSingleNode("db_name").InnerText
                TextBoxDBUser.Text = node.SelectSingleNode("db_user").InnerText
                TextBoxDBPassword.Text = node.SelectSingleNode("db_pass").InnerText
                TextBoxDBIp.Text = node.SelectSingleNode("db_ip").InnerText
                TextBoxDBPort.Text = node.SelectSingleNode("db_port").InnerText
            Next
        Else
            Me.Close()
        End If
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        'UPDATE/WRITE XML SETTING AFTER MODIFIED
        'xmldoc.Load(fs)
        'xmlnode = xmldoc.GetElementsByTagName("Config")
        Dim doc As New XmlDocument()
        doc.Load("config.xml")
        Dim nodes As XmlNodeList = doc.DocumentElement.SelectNodes("/Config")
        Dim product_id As String = "", product_name As String = "", product_price As String = ""
        For Each node As XmlNode In nodes
            node.SelectSingleNode("db_name").InnerText = TextBoxDBName.Text
            node.SelectSingleNode("db_user").InnerText = TextBoxDBUser.Text
            node.SelectSingleNode("db_pass").InnerText = TextBoxDBPassword.Text
            node.SelectSingleNode("db_ip").InnerText = TextBoxDBIp.Text
            node.SelectSingleNode("db_port").InnerText = TextBoxDBPort.Text
        Next
        doc.Save("config.xml")
        'For i = 0 To XmlNode.Count - 1
        'xmlnode(i).ChildNodes.Item(0).InnerText.Trim()
        'xmlnode(i).ChildNodes.Item(0).InnerText = TextBoxDBName.Text
        'xmlnode(i).ChildNodes.Item(1).Value = TextBoxDBUser.Text
        'xmlnode(i).ChildNodes.Item(2).Value = TextBoxDBPassword.Text
        'xmlnode(i).ChildNodes.Item(3).Value = TextBoxDBIp.Text
        'xmlnode(i).ChildNodes.Item(4).Value = TextBoxDBPort.Text
        'Next
        'xmldoc.Save(fs)
        'fs.Close()
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub
End Class