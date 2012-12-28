Imports miSerialProtocol

Public Class RotaryInstrument : Inherits Instrument
    'Author: Adam McQuaig
    'Oct 30, 2007

    'Inherits from the base class instrument, this class will provide specific functionality for the mini max rotary instrument.
    'It will act as a bridge between this application and the miSerialProtocol 

    Friend Rotary As miSerialProtocol.MiniMaxClass

    Sub New()

        MyBase.New(InstrumentTypeCode.MiniMax)
        Rotary = New MiniMaxClass(Mid(My.Settings.InstrumentCommPort, 4), My.Settings.InstrumentBaudRate)
        MyBase.InstrumentSrl = Rotary
        Rotary.AccessCode = My.Settings.InstrumentAccessCode
        Me.InstrumentDriveType = DriveType.Rotary

    End Sub

    Public Overloads Property Volume() As RotaryVolumeClass
        Get
            Return Me.iVolume
        End Get
        Set(ByVal value As RotaryVolumeClass)
            iVolume = value
        End Set
    End Property


#Region "Methods"

    Public Shadows Sub LoadFromDB(ByVal InstrumentID)
        'MyBase.LoadFromDB(InstrumentID)
        Me.Volume.MeterDisplacement = Me.GetItemValue(RotaryVolumeClass.GeneralVolumeItems.MeterDisplacement).value
    End Sub

#End Region

End Class
