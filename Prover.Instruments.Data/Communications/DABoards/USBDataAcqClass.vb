Public Class USBDataAcqClass : Inherits DABoard

    '    Enum MotorValues As Short
    '        mStart = 1023
    '        mStop = 0
    '    End Enum

    '    Enum OutputPorts
    '        DAOut0 = 0
    '        DAOut1 = 1
    '    End Enum


    '    Private pBoard As MccDaq.MccBoard
    '    Private pChannelType As MccDaq.DigitalPortType
    '    Private pChannelNum As Integer
    '    Private Direction As MccDaq.DigitalPortDirection
    '    Private ULStat As MccDaq.ErrorInfo

    '    Private ADMemHandle As Integer
    '    Private DAMemHandle As Integer
    '    Private DataArray As UShort

    '    Private IsPulseOut As Boolean

    '    Protected PulseIsCleared As Boolean = True

    '    Sub New(ByVal BoardNumber As Integer, ByVal ChannelType As MccDaq.DigitalPortType, ByVal ChannelNumber As Integer)
    '        pBoard = New MccDaq.MccBoard(BoardNumber) 'Will more often be zero
    '        pChannelNum = ChannelNumber
    '        pChannelType = ChannelType
    '        ULStat = MccDaq.MccService.WinBufToArray(ADMemHandle, DataArray, 0, 10)
    '        If ADMemHandle = 0 Then

    '        End If
    '    End Sub

    '    Public Overrides Sub Dispose(ByVal disposing As Boolean)
    '        If Not pBoard Is Nothing Then
    '            pBoard.DeviceLogout()
    '            ULStat = MccDaq.MccService.WinBufFree(ADMemHandle)
    '        End If
    '        pBoard = Nothing
    '    End Sub

    '#Region "Properties"
    '    Public Overrides ReadOnly Property StartMotor() As Short
    '        Get
    '            Return MotorValues.mStart
    '        End Get
    '    End Property

    '    Public Overrides ReadOnly Property StopMotor() As Short
    '        Get
    '            Return MotorValues.mStop
    '        End Get
    '    End Property
    '#End Region


    '#Region "Methods"
    '    Public Overrides Function CheckBoard() As Boolean
    '        Return True
    '    End Function

    '    Public Overrides Sub PulseOut(ByVal value As Integer)
    '        pBoard.AOut(pChannelNum, MccDaq.Range.UniPt5Volts, CShort(value))
    '        IsPulseOut = True
    '    End Sub

    '    'This returns a 1 integer if a pulse is detected and 0 if it is not
    '    Public Overrides Function ReadPulse() As Integer
    '        Dim value As UShort = 0

    '        ULStat = pBoard.DIn(pChannelType, value)

    '        If ULStat.Value = MccDaq.ErrorInfo.ErrorCode.NoErrors Then
    '            If value <> 255 Then
    '                If PulseIsCleared Then
    '                    Console.Write("Pulse Read: " & value & vbNewLine)
    '                    PulseIsCleared = False
    '                    Return 1
    '                Else
    '                    Return 0
    '                End If
    '            Else
    '                PulseIsCleared = True
    '                Return 0
    '            End If
    '        Else
    '            MessageBox.Show(ULStat.Message, "Pulse Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End If
    '    End Function

    '#End Region
End Class