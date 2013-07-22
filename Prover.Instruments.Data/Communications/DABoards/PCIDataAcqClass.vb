'Imports OpenLayers.Base

Public Class PCIDataAcqClass

    '    Public Enum MotorValues
    '        mStart = 254
    '        mStop = 255
    '    End Enum

    '    Public Enum OutputPorts
    '        PortA = 4
    '        PortB = 5
    '        PortC = 6
    '        PortD = 7
    '    End Enum

    '    Public Enum InputPorts
    '        PortA = 0
    '        PortB = 1
    '        PortC = 2
    '        PortD = 3
    '    End Enum

    '    Public Enum Lines
    '        Line0 = 1
    '        Line1 = 2
    '        Line2 = 4
    '        Line3 = 8
    '        Line4 = 16
    '        Line5 = 32
    '        Line6 = 64
    '        Line7 = 128
    '    End Enum

    '    Private pBoardName As String
    '    Private pOutputSS As DigitalOutputSubsystem
    '    Private pInputSS As DigitalInputSubsystem
    '    Private pDataFlow As Integer
    '    Private pLine As Lines
    '    Private IsPulseOut As Boolean
    '    Private DeviceManager As DeviceMgr
    '    Private pBoard As Device
    '    Private pSubSysType As SubsystemType
    '    Private pSubSys As Integer
    '    Private disposing As Boolean = False

    '    Private PulseIsCleared As Boolean = True

    '    Sub New()
    '        DeviceManager = DeviceMgr.Get
    '    End Sub

    '    Sub New(ByVal Board As String, ByVal SubSType As SubsystemType, ByVal SubSystemNumber As Integer, ByVal DataFlow As DataFlow)
    '        Try
    '            pBoardName = Board
    '            pSubSysType = SubSType
    '            pSubSys = SubSystemNumber
    '            pDataFlow = DataFlow
    '            DeviceManager = DeviceMgr.Get
    '            Config()
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message & vbNewLine, "Error", MessageBoxButtons.OK)
    '        End Try

    '    End Sub

    '    Public Overrides Sub Config()
    '        Try

    '            pBoard = DeviceManager.GetDevice(pBoardName)

    '            'If pSubSysType = SubsystemType.DigitalOutput Then
    '            '    pOutputSS = pBoard.DigitalOutputSubsystem(pSubSys)
    '            '    pOutputSS.DataFlow = pDataFlow
    '            '    pOutputSS.StopOnError = False
    '            '    pOutputSS.Config()
    '            'ElseIf pSubSysType = SubsystemType.DigitalInput Then
    '            '    pInputSS = New DigitalInputSubsystem(pBoard, pSubSys)
    '            '    pInputSS.DataFlow = pDataFlow
    '            '    pInputSS.StopOnError = True
    '            '    pInputSS.Config()
    '            'End If
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message & vbNewLine & "Is the Board being used by another resource?", "Data Acq. Board", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try

    '    End Sub

    '    Public Overrides Sub Dispose(ByVal disposing As Boolean)
    '        If Not pOutputSS Is Nothing Then
    '            'Try to stop motor before disposing
    '            PulseOut(StopMotor)
    '            Me.disposing = disposing
    '            pOutputSS.Dispose()
    '        End If
    '        Me.disposing = disposing
    '        If Not pInputSS Is Nothing Then
    '            'pInputSS.Dispose()
    '        End If
    '        pBoard.Dispose()
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
    '        Dim devices As String()
    '        devices = DeviceManager.GetDeviceNames()

    '        If devices.Length = 0 Then
    '            Return False
    '        Else
    '            Return True
    '        End If
    '    End Function


    '    Public Overrides Sub PulseOut(ByVal value As Integer)
    '        Try
    '            If disposing = False Then
    '                If DeviceManager.HardwareAvailable = True Then
    '                    If pOutputSS.State = SubsystemBase.States.ConfiguredForSingleValue Then
    '                        pOutputSS.SetSingleValue(value)
    '                        IsPulseOut = True
    '                    ElseIf pOutputSS.State = SubsystemBase.States.Initialized Then
    '                        Config()
    '                    End If
    '                End If
    '            End If
    '        Catch ex As OlException
    '            ex.Subsystem.Abort()
    '            MessageBox.Show(ex.Message)
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
    '        End Try
    '    End Sub

    '    'This returns a 1 integer if a pulse is detected and 0 if it is not
    '    Public Overrides Function ReadPulse() As Integer
    '        Dim value As Integer = 255
    '        Try
    '            If disposing = False Then
    '                If pInputSS.State = SubsystemBase.States.ConfiguredForSingleValue Then
    '                    value = pInputSS.GetSingleValue()
    '                    If value <> 255 Then
    '                        If PulseIsCleared Then
    '                            PulseIsCleared = False
    '                            Return 1
    '                        Else
    '                            Return 0
    '                        End If
    '                    Else
    '                        PulseIsCleared = True
    '                        Return 0
    '                    End If
    '                End If
    '            End If
    '        Catch ex As Exception
    '            'MessageBox.Show("Pulse Input Error." & ex.Message, "Pulse Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            ex = Nothing
    '        End Try
    '    End Function

    '#End Region

    '    Private Function DeviceMgr() As Object
    '        Throw New NotImplementedException
    '    End Function

    '    Private Function SubsystemBase() As Object
    '        Throw New NotImplementedException
    '    End Function

End Class