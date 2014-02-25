Imports miSerialProtocol

Public Class TachometerClass
    Implements IDisposable

    Public Shared CommPortName As String
    Public Shared CommPort As ICommPort

    Public Overloads Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        ' Take yourself off of the finalization queue
        ' to prevent finalization code for this object
        ' from executing a second time.
        GC.SuppressFinalize(Me)
    End Sub

    Protected Overridable Overloads Sub Dispose(ByVal disposing As Boolean)
        CommPort.DiscardInBuffer()
        CommPort.Dispose()
    End Sub


#Region "Methods"

    Private Shared Sub InitCommPort()
        If CommPort Is Nothing Then
            If CommPortName Is Nothing Or CommPortName = "" Then
                'Throw New Exception("Tachometer Comm Port must be set.")
            Else
                CommPort = New SerialPort(CommPortName, BaudRateEnum.b9600)
            End If


        End If
    End Sub

    Public Shared Sub ResetTach()
        InitCommPort()

        If CommPort Is Nothing Then Return

        If Not CommPort.IsOpen() Then
            CommPort.OpenPort()
        End If

        CommPort.SendDataToPort("@R3" & Chr(13))
        System.Threading.Thread.Sleep(100)

        CommPort.DiscardInBuffer()
    End Sub

    Public Shared Function ReadTach() As Integer
        Dim tachString As String = ""
        Dim tach As Integer

        InitCommPort()
        If CommPort Is Nothing Then Return 0
        If Not CommPort.IsOpen Then
            CommPort.OpenPort()
        End If
        CommPort.DiscardInBuffer()
        CommPort.SendDataToPort("@D0")
        CommPort.SendDataToPort(Chr(13))
        CommPort.DiscardInBuffer()
        System.Threading.Thread.Sleep(300)

        tachString = CommPort.ReceiveDataFromPort()


        Return ParseTachValue(tachString)
    End Function

    Public Shared Function ParseTachValue(value As String) As Integer
        ' D0
        '
        ' OK
        '
        ' 12000
        '
        Try
            Return Trim(Right(value, Len(value) - value.IndexOf(Chr(13), value.IndexOf(Chr(13)) + 1) - 1))
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
