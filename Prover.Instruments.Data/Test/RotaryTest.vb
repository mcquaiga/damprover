Public Class RotaryTest
    Implements ITestClass

    Dim _pulseAInput As IBoard
    Dim _pulseBInput As IBoard
    Dim _pulseOutput As IBoard
    Dim _tachPort As TachometerClass

    Dim _pulseACounter As Integer
    Dim _pulseBCounter As Integer


    Sub New()
        _pulseAInput = New USBDataAcqClass(0, MccDaq.DigitalPortType.FirstPortA, 0)
        _pulseBInput = New USBDataAcqClass(0, MccDaq.DigitalPortType.FirstPortB, 1)
        _pulseOutput = New USBDataAcqClass(0, 0, 0)

        _tachPort = New TachometerClass(2)
    End Sub



    Public Function StartTest(Volume As IVolume) As Task Implements ITestClass.StartTest
        Return Task.Run(Sub()
                            _tachPort.ResetTach()
                            _pulseOutput.StartMotor()

                            Do While _pulseACounter < 10
                                Me._pulseACounter = _pulseAInput.ReadPulse()
                                Me._pulseBCounter = _pulseBInput.ReadPulse()
                            Loop

                            _tachPort.ResetTach()


                        End Sub)
    End Function
End Class
