Imports miSerialProtocol
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Namespace Instruments.Data
    Public Class InstrumentCommunications

        Private Shared _items As New List(Of ItemClass)
        Private Shared _miSerial As miSerialProtocolClass
        Public Shared Property BaudRate As miSerialProtocol.BaudRateEnum
        Public Shared Property CommPortName As String
        Public Shared Property CommPort As ICommPort
        'Private Shared _


        Public Shared Function DownloadItemFileAsync(Instrument As IBaseInstrument, Optional Progress As IProgress(Of Tuple(Of String, Integer)) = Nothing) As Task
            Return Task.Run(Sub()
                                If CommPortName Is Nothing Or IsNothing(BaudRate) Then
                                    Throw New Exception("Comm Port and Baud Rate must be set.")
                                End If

                                If CommPortName = "IrDA" Then
                                    CommPort = New IrDAPort()
                                Else
                                    CommPort = New SerialPort(CommPortName, BaudRate)
                                End If

                                Select Case Instrument.InstrumentType
                                    Case InstrumentTypeCode.MiniMax
                                        _miSerial = New miSerialProtocol.MiniMaxClass(CommPort)
                                        _items = MiniMaxInstrument.LoadInstrumentItems()
                                    Case InstrumentTypeCode.EC300
                                        _miSerial = New miSerialProtocol.EC300Class(CommPort)
                                        _items = EC300Instrument.LoadInstrumentItems()
                                    Case Else
                                        _miSerial = New miSerialProtocol.TCIClass(CommPort)
                                End Select

                                _miSerial.Connect()
                                Dim downloads = _miSerial.RG((From i In _items Select i.Number).ToList)
                                _miSerial.Disconnect()
                                _miSerial.Dispose()
                                _miSerial = Nothing
                                For Each item In downloads
                                    Instrument.Items.Where(Function(x) x.Number = item.Key).SingleOrDefault.Value = item.Value
                                Next
                            End Sub)
        End Function


        Public Shared Function DownloadPressureItemsAsync(Instrument As IBaseInstrument, Optional Progress As IProgress(Of Tuple(Of String, Integer)) = Nothing) As Task
            Return Task.Run(Sub()
                                Select Case Instrument.InstrumentType
                                    Case InstrumentTypeCode.MiniMax
                                        _miSerial = New miSerialProtocol.MiniMaxClass(CommPort)
                                        _items = (From i In MiniMaxInstrument.LoadInstrumentItems() Where i.IsPressure = True).ToList
                                    Case InstrumentTypeCode.EC300
                                        _miSerial = New miSerialProtocol.EC300Class(CommPort)
                                    Case Else
                                        _miSerial = New miSerialProtocol.TCIClass(CommPort)
                                End Select

                                _miSerial.Connect()
                                Dim downloads = _miSerial.RG((From i In _items Select i.Number).ToList)
                                _miSerial.Disconnect()

                                For Each item In downloads
                                    Instrument.Items.Where(Function(x) x.Number = item.Key).SingleOrDefault.Value = item.Value
                                Next
                            End Sub)

        End Function


        Public Shared Function DownloadTemperatureItemsAsync(Instrument As IBaseInstrument, Test As ITemperatureTestClass, Optional Progress As IProgress(Of Tuple(Of String, Integer)) = Nothing) As Task
            Return Task.Run(Sub()
                                Select Case Instrument.InstrumentType
                                    Case InstrumentTypeCode.MiniMax
                                        _miSerial = New miSerialProtocol.MiniMaxClass(CommPort)
                                    Case InstrumentTypeCode.EC300
                                        _miSerial = New miSerialProtocol.EC300Class(CommPort)
                                    Case Else
                                        _miSerial = New miSerialProtocol.TCIClass(CommPort)
                                End Select

                                _miSerial.Connect()
                                Dim downloads = _miSerial.RG((From i In (Test.Items) Select i.Number).ToList)
                                _miSerial.Disconnect()


                                For Each item In downloads
                                    Test.Items.Where(Function(x) x.Number = item.Key).SingleOrDefault.Value = item.Value
                                Next
                            End Sub)
        End Function

        Public Shared Function DownloadItemsAsync(InstrumentType As InstrumentTypeCode, Items As List(Of ItemClass), Optional Progress As IProgress(Of Tuple(Of String, Integer)) = Nothing) As Task(Of Dictionary(Of Integer, String))
            Return Task.Run(Function()
                                If CommPortName Is Nothing Or IsNothing(BaudRate) Then
                                    Throw New Exception("Comm Port and Baud Rate must be set.")
                                End If

                                If CommPort Is Nothing Then
                                    If CommPortName = "IrDA" Then
                                        CommPort = New IrDAPort()
                                    Else
                                        CommPort = New SerialPort(CommPortName, BaudRate)
                                    End If
                                End If

                                Select Case InstrumentType
                                    Case InstrumentTypeCode.MiniMax
                                        _miSerial = New miSerialProtocol.MiniMaxClass(CommPort)
                                    Case InstrumentTypeCode.EC300
                                        _miSerial = New miSerialProtocol.EC300Class(CommPort)
                                    Case Else
                                        _miSerial = New miSerialProtocol.TCIClass(CommPort)
                                End Select

                                _miSerial.Connect()
                                Dim downloads = _miSerial.RG((From i In (Items) Select i.Number).ToList)
                                _miSerial.Disconnect()

                                Return downloads

                            End Function)
        End Function

    End Class
End Namespace