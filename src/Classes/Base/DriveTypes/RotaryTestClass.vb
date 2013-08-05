Imports System.ComponentModel
Public Class RotaryTestClass : Inherits TestClass
    Implements IDisposable

#Region "Enums"

#End Region

    'The rotary test differs from all the others because it is automatic,
    'We must start and stop the motor, read in pulses from the instrument and read the tachometer when it is finished

    Private tPulseOut As DABoard
    Private tTach As TachometerClass

    Private tPulseASelect As Instrument.PulseOutputValues
    Private tPulseBSelect As Instrument.PulseOutputValues

    Sub New(ByVal CustomerID As Integer)
        MyBase.New(CustomerID)
        tTach = New TachometerClass(Mid(My.Settings.TachCommPort, 4))

        'Configure Pulse Board


        If My.Settings.BoardType = DABoard.BoardType.PCI Then
            PulseA = New PCIDataAcqClass()
            If PulseA.CheckBoard = True Then
                'Me.PulseA = New PCIDataAcqClass("DT335(00)", OpenLayers.Base.SubsystemType.DigitalInput, 2, My.Settings.PulserADataFlow)
                'Me.PulseB = New PCIDataAcqClass("DT335(00)", OpenLayers.Base.SubsystemType.DigitalInput, 3, My.Settings.PulserBDataFlow)
                'Me.PulseOut = New PCIDataAcqClass("DT335(00)", OpenLayers.Base.SubsystemType.DigitalOutput, 1, My.Settings.PulserOutDataFlow)
            Else
                Throw New Exception("No PCI board exists.")
            End If
        Else
            Me.PulseA = New USBDataAcqClass(0, MccDaq.DigitalPortType.FirstPortA, 0)
            Me.PulseB = New USBDataAcqClass(0, MccDaq.DigitalPortType.FirstPortB, 1)
            Me.PulseOut = New USBDataAcqClass(0, 0, 0)
        End If

    End Sub


#Region "Properties"

    Public Property PulseOut() As DABoard
        Get
            Return tPulseOut
        End Get
        Set(ByVal value As DABoard)
            tPulseOut = value
        End Set
    End Property
#End Region

#Region "Methods"
    Public Overrides Sub PreTest(Optional ByVal Retest As Boolean = False)

        Dim VolumeCollection As New Collection

        MyBase.PreTest(Retest)

        'Create our volume, temp and pressure objects
        ' Instrument.Volume = New RotaryVolumeClass(Instrument.GetItemValue(DAM_Prover.RotaryVolumeClass.GeneralVolumeItems.MeterType).value)
        Dim meterName As String = Instrument.Volume.MeterTypeName

        Instrument.InstrumentSrl.Connect()
        VolumeCollection = Instrument.DownloadItems(Me.VolumeItems)
        If Instrument.Volume.IsMetric(Instrument.GetItemValue(92).value) Then
            Instrument.Volume.EVCMeterDisplacement = Instrument.GetItemValue(RotaryVolumeClass.GeneralVolumeItems.MeterDisplacement).value * 0.0283168466
            Instrument.Volume.MeterDisplacement = Instrument.Volume.MeterDisplacement * 0.0283168466
        Else
            Instrument.Volume.EVCMeterDisplacement = Instrument.GetItemValue(RotaryVolumeClass.GeneralVolumeItems.MeterDisplacement).value
        End If

        Instrument.Volume.StartUncorrected = VolumeCollection.Item(CStr(Volume.VolumeTestItems.UnCorrectedVolume)).value
        Instrument.Volume.StartCorrected = VolumeCollection.Item(CStr(Volume.VolumeTestItems.CorrectedVolume)).value
        Instrument.Volume.UncCorMultiplerCode = Instrument.GetItemValue(Volume.GeneralVolumeItems.UnCorrectedMultiplier).value

        Instrument.PulseASelect = Me.Instrument.GetItemValue(Instrument.PulseOutputItems.PulserA).value
        Instrument.PulseBSelect = Me.Instrument.GetItemValue(Instrument.PulseOutputItems.PulserB).value
        tTach.ResetTach()
    End Sub

    Public Overrides Function Test() As DialogResult

        Me.tPulserACount = 0
        Me.tPulserBCount = 0
        Me.tUnCorPulseCount = 0
        'Reset the tachometer

        'Wait a second for the tachometer to be ready
        System.Threading.Thread.Sleep(200)

        MaxUnCorrectedEvent = Instrument.Volume.MaxUnCorrected

        'Start the motor
        PulseOut.PulseOut(PulseOut.StartMotor)

        'Listen for pulse inputs
        Try
            Do
                Application.DoEvents()
                Me.PulseACount = PulseA.ReadPulse()
                Me.PulseBCount = PulseB.ReadPulse()

                If Instrument.PulseASelect = Instrument.PulseOutputValues.UncVol Then
                    UnCorCount = PulseACount
                ElseIf Instrument.PulseBSelect = Instrument.PulseOutputValues.UncVol Then
                    UnCorCount = PulseBCount
                End If
            Loop Until UnCorCount = Me.Instrument.Volume.MaxUnCorrected
        Catch ex As Exception
        End Try

        PulseOut.PulseOut(PulseOut.StopMotor)

        System.Threading.Thread.Sleep(1000)

    End Function

    Public Overrides Function PostTest() As DialogResult
        Me.Instrument.Volume.AppliedInput = tTach.ReadTach()

        Me.Instrument.Volume.PulserA = PulseACount
        Me.Instrument.Volume.PulserB = PulseBCount


        Return MyBase.PostTest()

    End Function

#End Region

#Region "Events"



#End Region

#Region "Dispose"

    ' IDisposable
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)

        If disposing Then
            If Not IsNothing(Instrument) Then
                Me.Instrument.Disconnect()
                Me.Instrument.Dispose()
            End If
            ' TODO: free unmanaged resources when explicitly called
            If Not IsNothing(tTach) Then
                tTach.Dispose()
                tTach = Nothing
            End If

            If Not IsNothing(PulseA) Then
                PulseA.Dispose(True)
            End If
            If Not IsNothing(PulseB) Then
                PulseB.Dispose(True)
            End If
            If Not IsNothing(PulseOut) Then
                PulseOut.Dispose(True)
            End If
            MyBase.Dispose(True)
        End If


    End Sub


#End Region


End Class
