Imports miSerialProtocol

Public Class InstrumentCommunications

    Private Shared _items As New List(Of Integer)
    Private Shared _miSerial As miSerialProtocolClass
    'Private Shared _

    Sub New()

    End Sub

    Public Shared Function DownloadItemFile(Instrument As IBaseInstrument) As XElement

        Select Instrument.InstrumentType
            Case InstrumentTypeCode.MiniMax
                _miSerial = New miSerialProtocol.MiniMaxClass(Instrument.CommPort, Instrument.BaudRate)
            Case Else
                _miSerial = New miSerialProtocol.TCIClass(Instrument.CommPort, Instrument.BaudRate)
        End Select


        Dim downloads As List(Of ItemClass)
        _miSerial.Connect()
        downloads = _miSerial.RG(_miSerial.Items)
        _miSerial.Disconnect()

        Return SerializeToXML(downloads)
    End Function

    Private Shared Function SerializeToXML(itemsDownloaded As List(Of ItemClass)) As XElement
        Dim _xml =
                <instrumentFile><%= From i In itemsDownloaded Select <item number=<%= i.Number %> value=<%= Trim(i.Value) %>/> %></instrumentFile>
        Return _xml
    End Function

End Class
