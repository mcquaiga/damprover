Public Class TachometerClass
    Implements IDisposable

    Dim comm As New System.IO.Ports.SerialPort

    Sub New(ByVal SerialPort As Integer)
        'Config Serial Port
        comm.PortName = "COM" & SerialPort
        comm.BaudRate = 9600

        If Not comm.IsOpen Then
            comm.Open()
        End If
    End Sub

    Public Overloads Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        ' Take yourself off of the finalization queue
        ' to prevent finalization code for this object
        ' from executing a second time.
        GC.SuppressFinalize(Me)
    End Sub

    Protected Overridable Overloads Sub Dispose(ByVal disposing As Boolean)
        'clean up our resources
        If (disposing) Then
            If comm.IsOpen Then
                comm.Close()
                comm.Dispose()
                comm = Nothing
            End If
        End If
    End Sub


#Region "Methods"

    Public Sub ResetTach()
        comm.Write("@T1" & Chr(13))
        System.Threading.Thread.Sleep(50)
        comm.Write("6" & Chr(13))
        System.Threading.Thread.Sleep(100)

        comm.DiscardInBuffer()
    End Sub

    Public Function ReadTach() As Object
        Dim tachString As String = ""
        Dim tach As Integer

        If comm.IsOpen = False Then
            comm.Open()
        End If
        comm.DiscardInBuffer()
        comm.Write("@D0")
        comm.Write(Chr(13))
        System.Threading.Thread.Sleep(200)

        tachString = comm.ReadExisting()
        If tachString.Length > 8 Then
            tach = tachString.Substring(1, 8)
        End If

        Return tach
    End Function

#End Region

End Class
