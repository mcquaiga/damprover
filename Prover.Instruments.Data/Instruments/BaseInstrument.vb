Imports miSerialProtocol
Imports System.Xml
Imports System.Xml.Serialization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Collections.ObjectModel

Namespace Instruments.Data

    Public MustInherit Class BaseInstrument
        Implements IBaseInstrument, INotifyPropertyChanged

        'This is the base class for all the Mercury Instruments
        'Seperate classes for each instrument must be created and inherited from this class
        'Only the properties and methods common to all instruments are created in this class
        'i.e. Mini-Max Rotary has Proving modes that must be set before testing

        'This class is responsible for holding values downloaded from the instrument and Temperature and Pressure Classes
        Protected _instrumentJson As JObject
        Protected _pathToItemXML As String
        Private _instrumentGUID As Guid



        Sub New()
            'PressureTests = New List(Of IPressureFactorClass)
            'PressureTests.Add(New PressureFactorClass(1))
            'PressureTests.Add(New PressureFactorClass(2))
            'PressureTests.Add(New PressureFactorClass(3))

            TemperatureTests = New List(Of ITemperatureClass)
            TemperatureTests.Add(New TemperatureClass(1))
            TemperatureTests.Add(New TemperatureClass(2))
            TemperatureTests.Add(New TemperatureClass(3))
        End Sub

#Region "Properties"

        Public Property Items As List(Of ItemClass) Implements IBaseInstrument.Items

        Public Property CreatedDate As DateTime? Implements IBaseInstrument.CreatedDate
        Public Property InstrumentType As miSerialProtocol.InstrumentTypeCode Implements IBaseInstrument.InstrumentType
        Public Property InstrumentDriveType() As IBaseInstrument.DriveType Implements IBaseInstrument.InstrumentDriveType
        Public Property InspectionID As Integer? Implements IBaseInstrument.InspectionID

        Public Property PressureTests As List(Of IPressureFactorClass) Implements IBaseInstrument.PressureTests
        Public Property TemperatureTests As List(Of ITemperatureClass) Implements IBaseInstrument.TemperateTests
        Public Property VolumeTest As IVolume Implements IBaseInstrument.VolumeTest

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
                Return Items.Where(Function(x) x.Number = 62).SingleOrDefault.Value
            End Get
        End Property


        Public ReadOnly Property SiteNumber1 As String Implements IBaseInstrument.SiteNumber1
            Get
                Return Items.Where(Function(x) x.Number = 200).SingleOrDefault.Value
            End Get
        End Property

        Public ReadOnly Property SiteNumbe2 As String Implements IBaseInstrument.SiteNumber2
            Get
                Return Items.Where(Function(x) x.Number = 201).SingleOrDefault.Value
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



        Public Overridable Function IsLivePressure() As IBaseInstrument.FixedFactors Implements IBaseInstrument.IsLivePressure
            Return Items.Where(Function(x) x.Number = IBaseInstrument.FixedFactorItems.FixedPressure).SingleOrDefault.Value
        End Function

        Public Overridable Function IsLiveTemperate() As IBaseInstrument.FixedFactors Implements IBaseInstrument.IsLiveTemperate
            Return Items.Where(Function(x) x.Number = IBaseInstrument.FixedFactorItems.FixedTempFactor).SingleOrDefault.Value
        End Function

        Public Overridable Function IsLiveSuper() As IBaseInstrument.FixedFactors Implements IBaseInstrument.IsLiveSuper
            Return Items.Where(Function(x) x.Number = IBaseInstrument.FixedFactorItems.FixedSuperFactor).SingleOrDefault.Value
        End Function

        Shared Function LoadInstrumentItems() As List(Of ItemClass)
            Return Nothing
        End Function



#End Region

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        ' This method is called by the Set accessor of each property. 
        ' The CallerMemberName attribute that is applied to the optional propertyName 
        ' parameter causes the property name of the caller to be substituted as an argument. 
        Private Sub NotifyPropertyChanged(<CallerMemberName()> Optional ByVal propertyName As String = Nothing)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub


    End Class

End Namespace
