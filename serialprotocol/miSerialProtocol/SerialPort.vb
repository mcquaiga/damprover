Imports System.IO.Ports
Public Class SerialPort
    Implements ICommPort


    Private WithEvents comm As System.IO.Ports.SerialPort
    Private _portName As String
    Private _baudRate As BaudRateEnum
    Private _timeOut As Integer

    Sub New(ByVal PortName As String, ByVal BaudRate As BaudRateEnum, Optional ByVal Timeout As Integer = 50)
        _portName = PortName
        _baudRate = BaudRate
        _timeOut = Timeout
    End Sub

    Public Sub ClosePort() Implements ICommPort.ClosePort

    End Sub

    Public Sub OpenPort() Implements ICommPort.OpenPort
        If Not comm Is Nothing Then
            If Not comm.IsOpen Then
                With comm
                    .PortName = _portName
                    .BaudRate = _baudRate
                    .NewLine = "\\"
                    .ReadTimeout = 200
                    .WriteTimeout = 150
                    'This will throw an exception if the port is already in use
                    Try
                        .Open()
                    Catch ex As Exception
                        'logger.Error(ex.Message)
                        Throw New CommInUseException(comm.PortName)
                    End Try
                End With
            End If
        End If
    End Sub

    Public Function ReceiveDataFromPort() As String Implements ICommPort.ReceiveDataFromPort
        Return comm.ReadExisting()
    End Function

    Public Sub SendDataToPort(Command As String) Implements ICommPort.SendDataToPort
        comm.Write(Command)
    End Sub

    Public Function BytesToRead() As Integer Implements ICommPort.BytesToRead
        Return comm.BytesToRead()
    End Function

    Public Sub DiscardInBuffer() Implements ICommPort.DiscardInBuffer
        comm.DiscardInBuffer()
    End Sub

    Public Function IsOpen() As Boolean Implements ICommPort.IsOpen
        Return comm.IsOpen()
    End Function

End Class
