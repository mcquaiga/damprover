Imports miSerialProtocol

Public Class TCIInstrument : Inherits Instrument
    'Author: Adam McQuaig
    'Oct 30, 2007

    'Inherits from the base class instrument, this class will provide specific functionality for the mini max rotary instrument.
    'It will act as a bridge between this application and the miSerialProtocol 

    Friend Tci As miSerialProtocol.TCIClass


    Sub New()
        MyBase.New()
        Tci = New TCIClass(Mid(My.Settings.InstrumentCommPort, 4), My.Settings.InstrumentBaudRate)
        Tci.AccessCode = My.Settings.TCIAccessCode
        MyBase.InstrumentSrl = Tci
        Me.InstrumentType = InstrumentTypeCode.TCI
        Me.InstrumentDriveType = DriveType.Rotary
    End Sub

    Public Overloads Property Volume() As TCIVolumeClass
        Get
            Return Me.iVolume
        End Get
        Set(ByVal value As TCIVolumeClass)
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

