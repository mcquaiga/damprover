Imports miSerialProtocol

Public Class InstrumentCommunications

    Private Shared _items As New List(Of Integer)
    Private Shared _miSerial As MiniMaxClass
    Private Shared _

    Sub New()

    End Sub

    Public Shared Sub DownloadItemFile()

        _miSerial = New MiniMaxClass(9, MiniMaxClass.BaudRateEnum.b38400)

        Dim downloads As Dictionary(Of Integer, String)
        InitItems()
        _miSerial.Connect()
        downloads = _miSerial.RG(_items)
        _miSerial.Disconnect()
        SerializeToXML(downloads)
    End Sub

    Private Shared Function SerializeToXML(itemsDownloaded As Dictionary(Of Integer, String)) As XElement
        Dim _xml =
                <instrumentFile><%= From i In itemsDownloaded Select <item number=<%= i.Key %> value=<%= Trim(i.Value) %>/> %></instrumentFile>
    End Function




    Private Shared Sub InitItems()

    End Sub

End Class
