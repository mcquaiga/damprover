Public Class USBDataAcqClass
    Implements IBoard

    Enum MotorValues As Short
        mStart = 1023
        mStop = 0
    End Enum

    Enum OutputPorts
        DAOut0 = 0
        DAOut1 = 1
    End Enum


    Private _board As MccDaq.MccBoard
    Private _channelType As MccDaq.DigitalPortType
    Private _channelNum As Integer
    Private _direction As MccDaq.DigitalPortDirection
    Private _ulStat As MccDaq.ErrorInfo

    Private ADMemHandle As Integer
    Private ADMemHandlePtr As New IntPtr(ADMemHandle)
    Private DAMemHandle As Integer
    Private DataArray As UShort

    Private IsPulseOut As Boolean

    Protected PulseIsCleared As Boolean = True

    Sub New(ByVal BoardNumber As Integer, ByVal ChannelType As MccDaq.DigitalPortType, ByVal ChannelNumber As Integer)
        _board = New MccDaq.MccBoard(BoardNumber) 'Will more often be zero
        _channelNum = ChannelNumber
        _channelType = ChannelType
        '_ulStat = MccDaq.MccService.WinBufToArray(ADMemHandlePtr, DataArray, 0, 10)
        _ulStat = MccDaq.MccService.ErrHandling(MccDaq.ErrorReporting.PrintAll, MccDaq.ErrorHandling.StopAll)
    End Sub

    Public Sub Dispose(ByVal disposing As Boolean) Implements IBoard.Dispose
        If Not _board Is Nothing Then
            _board.DeviceLogout()
            _ulStat = MccDaq.MccService.WinBufFreeEx(ADMemHandle)
        End If
        _board = Nothing
    End Sub

#Region "Properties"
    Public Sub StartMotor() Implements IBoard.StartMotor
        PulseOut(MotorValues.mStart)
    End Sub

    Public Sub StopMotor() Implements IBoard.StopMotor
        PulseOut(MotorValues.mStop)
    End Sub
#End Region


#Region "Methods"
    Public Function CheckBoard() As Boolean Implements IBoard.CheckBoard
        Return True
    End Function

    Public Sub PulseOut(ByVal value As Integer) Implements IBoard.PulseOut
        _board.AOut(_channelNum, MccDaq.Range.UniPt5Volts, CShort(value))
        IsPulseOut = True
    End Sub

    'This returns a 1 integer if a pulse is detected and 0 if it is not
    Public Function ReadPulse() As Integer Implements IBoard.ReadPulse
        Dim value As UShort = 0

        _ulStat = _board.DIn(_channelType, value)

        If _ulStat.Value = MccDaq.ErrorInfo.ErrorCode.NoErrors Then
            If value <> 255 Then
                If PulseIsCleared Then
                    Console.Write("Pulse Read: " & value & vbNewLine)
                    PulseIsCleared = False
                    Return 1
                Else
                    Return 0
                End If
            Else
                PulseIsCleared = True
                Return 0
            End If
        Else
            'MessageBox.Show(ULStat.Message, "Pulse Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return 0
    End Function

#End Region


    Public Property boardName As String Implements IBoard.board

    Public Sub Config() Implements IBoard.Config

    End Sub

    Public Property data_flow As Integer Implements IBoard.data_flow

    Public Property disposedValue As Boolean Implements IBoard.disposedValue

    Public Property ss_num As Integer Implements IBoard.ss_num


    Public Shared Sub SharedStopMotor(ByVal BoardNumber As Integer, ByVal ChannelNumber As Integer)
        Dim board = New MccDaq.MccBoard(BoardNumber)

        board.AOut(ChannelNumber, MccDaq.Range.UniPt5Volts, CShort(MotorValues.mStop))

    End Sub
End Class
