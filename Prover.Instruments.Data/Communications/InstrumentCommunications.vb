Imports miSerialProtocol

Public Class InstrumentCommunications

    Private Shared _items As New List(Of Integer)
    Private Shared _miSerial As miSerialProtocolClass
    'Private Shared _

    Sub New()

    End Sub

    Public Shared Function DownloadItemFile(Instrument As IBaseInstrument) As XElement

        Select Case Instrument.InstrumentType
            Case InstrumentTypeCode.MiniMax
                _miSerial = New miSerialProtocol.MiniMaxClass(Instrument.CommPort, Instrument.BaudRate)
            Case Else
                _miSerial = New miSerialProtocol.TCIClass(Instrument.CommPort, Instrument.BaudRate)
        End Select

        _miSerial.Connect()
        Dim downloads = _miSerial.RG((From i In Instrument.Items Select i.Number).ToList)
        _miSerial.Disconnect()

        Return SerializeToXML(downloads)
    End Function

    Private Shared Function SerializeToXML(itemsDownloaded As Dictionary(Of Integer, String)) As XElement
        Dim _xml =
                <instrumentFile><%= From i In itemsDownloaded Select <item number=<%= i.Key %> value=<%= Trim(i.Value) %>/> %></instrumentFile>
        Return _xml
    End Function

End Class
