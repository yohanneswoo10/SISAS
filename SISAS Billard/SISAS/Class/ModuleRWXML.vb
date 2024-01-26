Imports System.Xml
Imports System.IO
Module ModuleRWXML

    Public Sub init_table_xml()
        Dim doc As New XmlDocument()
        doc.Load("table.xml")
        Dim nodes As XmlNodeList = doc.DocumentElement.SelectNodes("/root")
        For Each node As XmlNode In nodes
            If node IsNot Nothing Then
                node.RemoveAll()
            End If
        Next
        doc.Save("table.xml")
    End Sub
    Public Sub read_write_xml(i As Integer)
        Dim doc As New XmlDocument()
        doc.Load("table.xml")
        Dim s As String = "/root/table[@ids='" & i & "']"
        Dim waktu As String = Billing.hour(i) & ":" & Billing.min(i) & ":" & Billing.sec(i)
        'Dim nodes As XmlNodeList = doc.DocumentElement.SelectNodes("/table")
        Dim nodes As XmlNode = doc.SelectSingleNode(s)

        If nodes IsNot Nothing Then
            'Console.WriteLine("Price:" + nodes("price").InnerText)
            nodes("time").InnerText = waktu
            nodes("price").InnerText = Billing.bill(i)
            'nodes("user").InnerText = Billing.username
            'nodes("tanggal").InnerText = todayDate
        Else
            Dim xmlRoot As XmlElement = doc.SelectSingleNode("root")
            Dim xmlChild As XmlElement = doc.CreateElement("table")
            xmlChild.SetAttribute("ids", i.ToString)
            xmlRoot.AppendChild(xmlChild)
            Dim xmlc As XmlElement = doc.CreateElement("time")
            xmlChild.AppendChild(xmlc)
            xmlc = doc.CreateElement("price")
            xmlChild.AppendChild(xmlc)
            xmlc = doc.CreateElement("tanggal")
            xmlChild.AppendChild(xmlc)
            xmlc = doc.CreateElement("starttime")
            xmlChild.AppendChild(xmlc)
            xmlc = doc.CreateElement("endtime")
            xmlChild.AppendChild(xmlc)
            xmlc = doc.CreateElement("user")
            xmlChild.AppendChild(xmlc)
        End If
        'Dim elem As XmlElement = doc.GetElementById("1")

        'For Each node As XmlNode In nodes
        '    Console.WriteLine(node.ChildNodes(i).InnerText)
        '    i += 1
        'Next

        doc.Save("table.xml")
    End Sub

    Public Sub create_xml_node(i As Integer)
        Dim doc As New XmlDocument()
        doc.Load("table.xml")
        Dim s As String = "/root/table[@ids='" & i & "']"
        Dim nodes As XmlNode = doc.SelectSingleNode(s)
        If nodes IsNot Nothing Then

        Else
            Dim xmlRoot As XmlElement = doc.SelectSingleNode("root")
            Dim xmlChild As XmlElement = doc.CreateElement("table")
            xmlChild.SetAttribute("ids", i.ToString)
            xmlRoot.AppendChild(xmlChild)
            Dim xmlc As XmlElement = doc.CreateElement("time")
            xmlChild.AppendChild(xmlc)
            xmlc = doc.CreateElement("price")
            xmlChild.AppendChild(xmlc)
            xmlc = doc.CreateElement("tanggal")
            xmlChild.AppendChild(xmlc)
            xmlc = doc.CreateElement("starttime")
            xmlChild.AppendChild(xmlc)
            xmlc = doc.CreateElement("endtime")
            xmlChild.AppendChild(xmlc)
            xmlc = doc.CreateElement("user")
            xmlChild.AppendChild(xmlc)
        End If
        doc.Save("table.xml")
    End Sub

    Public Sub start_time(i As Integer)

        Dim doc As New XmlDocument()
        doc.Load("table.xml")
        Dim s As String = "/root/table[@ids='" & i & "']"
        Dim nodes As XmlNode = doc.SelectSingleNode(s)
        Dim todayDate As Date = Date.Now

        If nodes IsNot Nothing Then
            nodes("user").InnerText = Billing.username
            nodes("starttime").InnerText = DateTime.Now.ToString("HH:mm:ss")
            nodes("tanggal").InnerText = todayDate.ToString("yyyy-MM-dd")
        End If

        doc.Save("table.xml")
    End Sub

    Public Sub end_time(i As Integer)
        Dim doc As New XmlDocument()
        doc.Load("table.xml")
        Dim s As String = "/root/table[@ids='" & i & "']"
        Dim nodes As XmlNode = doc.SelectSingleNode(s)
        Dim todayDate As Date = Date.Now
        If nodes IsNot Nothing Then
            nodes("endtime").InnerText = DateTime.Now.ToString("HH:mm:ss")
        End If

        doc.Save("table.xml")
    End Sub

    Public Function get_xml_data(i As Integer)
        Dim doc As New XmlDocument()
        doc.Load("table.xml")
        Dim s As String = "/root/table[@ids='" & i & "']"
        Dim nodes As XmlNode = doc.SelectSingleNode(s)

        Dim data As String = i.ToString & "," & nodes("time").InnerText & "," & nodes("price").InnerText & "," & nodes("tanggal").InnerText & "," & nodes("starttime").InnerText & "," & nodes("endtime").InnerText & "," & nodes("user").InnerText
        Return data
    End Function
End Module
