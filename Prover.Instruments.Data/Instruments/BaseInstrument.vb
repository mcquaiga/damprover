Imports miSerialProtocol
Imports System.Xml
Imports System.Xml.Serialization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq



Namespace Instruments.Data



    Public MustInherit Class BaseInstrument
        Implements IBaseInstrument

        'This is the base class for all the Mercury Instruments
        'Seperate classes for each instrument must be created and inherited from this class
        'Only the properties and methods common to all instruments are created in this class
        'i.e. Mini-Max Rotary has Proving modes that must be set before testing

        'This class is responsible for holding values downloaded from the instrument and Temperature and Pressure Classes
        Protected _instrumentJson As JObject
        Protected _pathToItemXML As String
        Private _instrumentGUID As Guid

        Sub New()
            PressureTests = New List(Of IPressureFactorClass)
            TemperatureTests = New List(Of ITemperatureClass)
            VolumeTests = New List(Of IVolume)
        End Sub

#Region "Properties"

        'Public Property Items As List(Of ItemClass) Implements IBaseInstrument.Items
        Public Property ID As String Implements IBaseInstrument.ID
        Public Property CreatedDate As DateTime? Implements IBaseInstrument.CreatedDate
        Public Property InstrumentType As miSerialProtocol.InstrumentTypeCode Implements IBaseInstrument.InstrumentType
        Public Property InstrumentDriveType() As IBaseInstrument.DriveType Implements IBaseInstrument.InstrumentDriveType
        Public Property ItemFile As Dictionary(Of Integer, String) Implements IBaseInstrument.ItemFile
        Public Property InspectionID As Integer? Implements IBaseInstrument.InspectionID


        Public Property PressureTests As List(Of IPressureFactorClass) Implements IBaseInstrument.PressureTests
        Public Property TemperatureTests As List(Of ITemperatureClass) Implements IBaseInstrument.TemperateTests
        Public Property VolumeTests As List(Of IVolume) Implements IBaseInstrument.VolumeTests

        Public ReadOnly Property InstrumenGuID() As Guid Implements IBaseInstrument.InstrumentGuid
            Get
                If _instrumentGUID = Guid.Empty Then
                    _instrumentGUID = Guid.NewGuid
                End If
                Return _instrumentGUID
            End Get
        End Property


        Public ReadOnly Property SerialNumber As String Implements IBaseInstrument.SerialNumber
            Get
                Return GetItemValue(62) 'GetItemValue((From i In Items Where i.Code = "SERIAL_NUM").FirstOrDefault.Number)
            End Get
        End Property


        Public ReadOnly Property PulseASelect() As IBaseInstrument.PulseOutputValues Implements IBaseInstrument.PulseASelect
            Get
                Return Nothing
            End Get
        End Property

        Public ReadOnly Property PulseBSelect() As IBaseInstrument.PulseOutputValues Implements IBaseInstrument.PulseBSelect
            Get
                Return Nothing
            End Get
        End Property


        Public Overridable Function GetItemValue(ItemNumber As Integer) As String Implements IBaseInstrument.GetItemValue
            Dim y As String
            Try
                y = ItemFile.Item(ItemNumber.ToString)
            Catch ex As Exception
                Return Nothing
            End Try
            Return y
        End Function

        Public Overridable Function IsLivePressure() As IBaseInstrument.FixedFactors Implements IBaseInstrument.IsLivePressure
            Return GetItemValue(IBaseInstrument.FixedFactorItems.FixedPressure)
        End Function

        Public Overridable Function IsLiveTemperate() As IBaseInstrument.FixedFactors Implements IBaseInstrument.IsLiveTemperate
            Return GetItemValue(IBaseInstrument.FixedFactorItems.FixedTempFactor)
        End Function

        Public Overridable Function IsLiveSuper() As IBaseInstrument.FixedFactors Implements IBaseInstrument.IsLiveSuper
            Return GetItemValue(IBaseInstrument.FixedFactorItems.FixedSuperFactor)
        End Function

        Shared Function LoadInstrumentItems() As List(Of ItemClass)
            Return Nothing
        End Function



#End Region

    End Class

End Namespace
