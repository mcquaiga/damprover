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


    Private pBoard As MccDaq.MccBoard
    Private pChannelType As MccDaq.DigitalPortType
    Private pChannelNum As Integer
    Private Direction As MccDaq.DigitalPortDirection
    Private ULStat As MccDaq.ErrorInfo

    Private ADMemHandle As Integer
    Private DAMemHandle As Integer
    Private DataArray As UShort

    Private IsPulseOut As Boolean

    Protected PulseIsCleared As Boolean = True

    Sub New(ByVal BoardNumber As Integer, ByVal ChannelType As MccDaq.DigitalPortType, ByVal ChannelNumber As Integer)
        pBoard = New MccDaq.MccBoard(BoardNumber) 'Will more often be zero
        pChannelNum = ChannelNumber
        pChannelType = ChannelType
        ULStat = MccDaq.MccService.WinBufToArray(ADMemHandle, DataArray, 0, 10)
        ULStat = MccDaq.MccService.ErrHandling(MccDaq.ErrorReporting.PrintAll, MccDaq.ErrorHandling.StopAll)
    End Sub

    Public Sub Dispose(ByVal disposing As Boolean) Implements IBoard.Dispose
        If Not pBoard Is Nothing Then
            pBoard.DeviceLogout()
            ULStat = MccDaq.MccService.WinBufFreeEx(ADMemHandle)
        End If
        pBoard = Nothing
    End Sub

#Region "Properties"
    Public ReadOnly Property StartMotor() As Short Implements IBoard.StartMotor
        Get
            Return MotorValues.mStart
        End Get
    End Property

    Public ReadOnly Property StopMotor() As Short Implements IBoard.StopMotor
        Get
            Return MotorValues.mStop
        End Get
    End Property
#End Region


#Region "Methods"
    Public Function CheckBoard() As Boolean Implements IBoard.CheckBoard
        Return True
    End Function

    Public Sub PulseOut(ByVal value As Integer) Implements IBoard.PulseOut
        pBoard.AOut(pChannelNum, MccDaq.Range.UniPt5Volts, CShort(value))
        IsPulseOut = True
    End Sub

    'This returns a 1 integer if a pulse is detected and 0 if it is not
    Public Function ReadPulse() As Integer Implements IBoard.ReadPulse
        Dim value As UShort = 0

        ULStat = pBoard.DIn(pChannelType, value)

        If ULStat.Value = MccDaq.ErrorInfo.ErrorCode.NoErrors Then
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
            MessageBox.Show(ULStat.Message, "Pulse Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Function

#End Region
End Class
