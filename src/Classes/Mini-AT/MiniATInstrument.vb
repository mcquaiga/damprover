Imports miSerialProtocol

Public Class MiniATInstrument : Inherits Instrument

    Friend MiniAT As miSerialProtocol.MiniATClass

    Sub New()
        MyBase.New(InstrumentTypeCode.MiniAT)
        MiniAT = New MiniATClass(Mid(My.Settings.InstrumentCommPort, 4), My.Settings.InstrumentBaudRate)
        MiniAT.AccessCode = My.Settings.InstrumentAccessCode
        InstrumentSrl = MiniAT
        Me.InstrumentDriveType = DriveType.Mechanical
    End Sub

    Public Overloads Property Volume() As MiniATVolumeClass
        Get
            Return Me.iVolume
        End Get
        Set(ByVal value As MiniATVolumeClass)
            iVolume = value
        End Set
    End Property


#Region "Methods"

    Public Shadows Sub LoadFromDB(ByVal InstrumentID)
        Me.Volume.DriveRate = Me.GetItemValue(MiniATVolumeClass.GeneralVolumeItems.DriveRate).value
    End Sub

#End Region

End Class
