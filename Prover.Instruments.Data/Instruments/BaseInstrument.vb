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

        End Sub

#Region "Properties"

        Public Property Id As String
        Public Property Items As List(Of ItemClass) Implements IBaseInstrument.Items

        Public Property CreatedDate As DateTime? Implements IBaseInstrument.CreatedDate
        Public Property InstrumentType As miSerialProtocol.InstrumentTypeCode Implements IBaseInstrument.InstrumentType
        Public Property InstrumentDriveType() As IBaseInstrument.DriveType Implements IBaseInstrument.InstrumentDriveType
        Public Property InspectionID As String Implements IBaseInstrument.InspectionID

        Public Property PressureTests As List(Of IPressureFactorClass) Implements IBaseInstrument.PressureTests
        Public Property Temperature As TemperatureClass Implements IBaseInstrument.Temperature
        Public Property VolumeTest As IVolume Implements IBaseInstrument.VolumeTest

        <JsonIgnore>
        Public ReadOnly Property InstrumenGuID() As Guid Implements IBaseInstrument.InstrumentGuid
            Get
                If _instrumentGUID = Guid.Empty Then
                    _instrumentGUID = Guid.NewGuid
                End If
                Return _instrumentGUID
            End Get
        End Property

        <JsonIgnore>
        Public ReadOnly Property SerialNumber As String Implements IBaseInstrument.SerialNumber
            Get
                If Items Is Nothing Then Return Nothing
                Return Items.Where(Function(x) x.Number = 62).SingleOrDefault.NumericValue
            End Get
        End Property

        <JsonIgnore>
        Public ReadOnly Property SiteNumber1 As String Implements IBaseInstrument.SiteNumber1
            Get
                Try
                    Return Items.Where(Function(x) x.Number = 200).SingleOrDefault.NumericValue
                Catch ex As Exception
                    Return Nothing
                End Try
            End Get
        End Property

        <JsonIgnore>
        Public ReadOnly Property SiteNumber2 As String Implements IBaseInstrument.SiteNumber2
            Get
                Try
                    Return Items.Where(Function(x) x.Number = 201).SingleOrDefault.NumericValue
                Catch ex As Exception
                    Return Nothing
                End Try
            End Get
        End Property

        <JsonIgnore>
        Public ReadOnly Property PulseASelect() As String Implements IBaseInstrument.PulseASelect
            Get
                Try
                    Return Items.Where(Function(x) x.Number = 93).SingleOrDefault.DescriptionValue

                Catch ex As Exception
                    Return Nothing
                End Try
            End Get
        End Property

        <JsonIgnore>
        Public ReadOnly Property PulseBSelect() As String Implements IBaseInstrument.PulseBSelect
            Get
                Try
                    Return Items.Where(Function(x) x.Number = 94).SingleOrDefault.DescriptionValue
                Catch ex As Exception
                    Return Nothing
                End Try
            End Get
        End Property

        <JsonIgnore>
        Public ReadOnly Property PulseAScaling() As Double Implements IBaseInstrument.PulseAScaling
            Get
                Try
                    Return Items.Where(Function(x) x.Number = 56).SingleOrDefault.NumericValue
                Catch ex As Exception
                    Return Nothing
                End Try
            End Get
        End Property

        <JsonIgnore>
        Public ReadOnly Property PulseBScaling() As Double Implements IBaseInstrument.PulseBScaling
            Get
                Try
                    Return Items.Where(Function(x) x.Number = 57).SingleOrDefault.NumericValue
                Catch ex As Exception
                    Return Nothing
                End Try
            End Get
        End Property

        <JsonIgnore>
        Public ReadOnly Property FirmwareVersion As String Implements IBaseInstrument.FirmwareVersion
            Get
                Try
                    Return Items.Where(Function(x) x.Number = 122).SingleOrDefault.NumericValue
                Catch ex As Exception
                    Return Nothing
                End Try
            End Get
        End Property

#End Region

#Region "Methods"
        Public Overridable Function IsLivePressure() As IBaseInstrument.FixedFactors Implements IBaseInstrument.IsLivePressure
            Return Items.Where(Function(x) x.Number = IBaseInstrument.FixedFactorItems.FixedPressure).SingleOrDefault.Value
        End Function

        Public Overridable Function IsLiveTemperate() As IBaseInstrument.FixedFactors Implements IBaseInstrument.IsLiveTemperate
            Return Items.Where(Function(x) x.Number = IBaseInstrument.FixedFactorItems.FixedTempFactor).SingleOrDefault.Value
        End Function

        Public Overridable Function IsLiveSuper() As IBaseInstrument.FixedFactors Implements IBaseInstrument.IsLiveSuper
            Return Items.Where(Function(x) x.Number = IBaseInstrument.FixedFactorItems.FixedSuperFactor).SingleOrDefault.Value
        End Function


        Public Overridable Async Function DownloadSiteInformation() As Task Implements IBaseInstrument.DownloadSiteInformation
            Items = Await DownloadItems(Me.InstrumentType, Me.Items)

            If Me.Temperature Is Nothing Then Temperature = New TemperatureClass(Me.Items)
            If Me.VolumeTest Is Nothing Then VolumeTest = New Volume(Items)
        End Function

        Public Overridable Async Function DownloadTemperatureItems() As Task Implements IBaseInstrument.DownloadTemperatureItems
            Await Temperature.DownloadTemperatureItems(InstrumentType)
        End Function

        Public Overridable Async Function DownloadTemperatureTestItems(LevelIndex As Integer) As Task Implements IBaseInstrument.DownloadTemperatureTestItems
            Await Temperature.DownloadTemperatureTestItems(InstrumentType, LevelIndex)
        End Function

        Public Overridable Async Function StartRotaryTest() As Task Implements IBaseInstrument.StartRotaryTest
            Await Me.VolumeTest.RunTest(Me.InstrumentType, Me.Temperature.Tests.Where(Function(x) x.LevelIndex = 2).FirstOrDefault)
        End Function

#Region "Shared stuff"
        Shared Function LoadInstrumentItems() As List(Of ItemClass)
            Return Nothing
        End Function

        Public Shared Async Function DownloadItems(InstrumentType As InstrumentTypeCode, Items As List(Of ItemClass)) As Task(Of List(Of ItemClass))

            Dim downloads = Await InstrumentCommunications.DownloadItemsAsync(InstrumentType, Items)

            For Each item In downloads
                Items.Where(Function(x) x.Number = item.Key).SingleOrDefault.NumericValue = item.Value
            Next

            Return Items
        End Function


#End Region

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
