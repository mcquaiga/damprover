Imports miSerialProtocol

Public Class MiniMaxInstrument : Inherits Instrument

    Public MiniMax As miSerialProtocol.MiniMaxClass

    Sub New()
        MyBase.New(InstrumentTypeCode.MiniMax)
        MiniMax = New MiniMaxClass(Mid(My.Settings.InstrumentCommPort, 4), My.Settings.InstrumentBaudRate)
        MiniMax.AccessCode = My.Settings.InstrumentAccessCode
        InstrumentSrl = MiniMax
        InstrumentDriveType = DriveType.Mechanical
    End Sub

    Public Overloads Property Volume() As MiniMaxVolumeClass
        Get
            Return Me.iVolume
        End Get
        Set(ByVal value As MiniMaxVolumeClass)
            iVolume = value
        End Set
    End Property

#Region "Methods"

    Public Shadows Sub LoadFromDB(ByVal InstrumentID)
        Me.Volume.DriveRate = Me.GetItemValue(MiniATVolumeClass.GeneralVolumeItems.DriveRate).value
    End Sub

#End Region


End Class
