﻿Imports miSerialProtocol
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Namespace Instruments.Data
    Public Class InstrumentCommunications

        Private Shared _items As New List(Of ItemClass)
        Private Shared _miSerial As miSerialProtocolClass
        Public Shared Property BaudRate As miSerialProtocol.BaudRateEnum
        Public Shared Property CommPort As String
        'Private Shared _


        Sub New(CommPortName As String, BaudRate As miSerialProtocol.BaudRateEnum)
            CommPort = CommPortName
            BaudRate = BaudRate
        End Sub

        Public Shared Function DownloadItemFile(Instrument As IBaseInstrument, Optional Progress As IProgress(Of Tuple(Of String, Integer)) = Nothing) As Task(Of Dictionary(Of Integer, String))
            Return Task.Run(Function()
                                If CommPort Is Nothing Or IsNothing(BaudRate) Then
                                    Throw New Exception("Comm Port and Baud Rate must be set.")
                                End If
                                Select Case Instrument.InstrumentType
                                    Case InstrumentTypeCode.MiniMax
                                        _miSerial = New miSerialProtocol.MiniMaxClass(CommPort, BaudRate)
                                        _items = MiniMaxInstrument.LoadInstrumentItems()
                                    Case Else
                                        _miSerial = New miSerialProtocol.TCIClass(CommPort, BaudRate)
                                End Select

                                _miSerial.Connect()
                                Dim downloads = _miSerial.RG((From i In _items Select i.Number).ToList)
                                _miSerial.Disconnect()
                                Return downloads
                            End Function)
        End Function


        Public Shared Function DownloadPressureItems(Instrument As IBaseInstrument, Optional Progress As IProgress(Of Tuple(Of String, Integer)) = Nothing) As Dictionary(Of Integer, String)
            Select Case Instrument.InstrumentType
                Case InstrumentTypeCode.MiniMax
                    _miSerial = New miSerialProtocol.MiniMaxClass(CommPort, BaudRate)
                    _items = (From i In MiniMaxInstrument.LoadInstrumentItems() Where i.IsPressure = True).ToList
                Case Else
                    _miSerial = New miSerialProtocol.TCIClass(CommPort, BaudRate)
            End Select

            Dim t = Task(Of Dictionary(Of Integer, String)).Factory.StartNew(Function()
                                                                                 _miSerial.Connect()
                                                                                 Dim downloads = _miSerial.RG((From i In _items Select i.Number).ToList)
                                                                                 _miSerial.Disconnect()
                                                                                 Return downloads
                                                                             End Function)
            t.Wait()
            Return t.Result
        End Function


        Public Shared Function DownloadTemperatureItems(Instrument As IBaseInstrument, Optional Progress As IProgress(Of Tuple(Of String, Integer)) = Nothing) As Dictionary(Of Integer, String)

            Select Case Instrument.InstrumentType
                Case InstrumentTypeCode.MiniMax
                    _miSerial = New miSerialProtocol.MiniMaxClass(CommPort, BaudRate)
                    _items = (From i In MiniMaxInstrument.LoadInstrumentItems() Where i.IsTemperature = True).ToList
                Case Else
                    _miSerial = New miSerialProtocol.TCIClass(CommPort, BaudRate)
            End Select

            _miSerial.Connect()
            Dim downloads = _miSerial.RG((From i In _items Select i.Number).ToList)
            _miSerial.Disconnect()

            Return downloads

        End Function

    End Class
End Namespace