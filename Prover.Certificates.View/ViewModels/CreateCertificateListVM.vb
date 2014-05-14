Imports Prover.Instruments.Data
Imports System.Object
Imports System.ComponentModel
Imports System.Collections.ObjectModel
Imports Microsoft.Practices.Prism.Events
Imports Prover.Certificates.Data
Imports Raven.Client.Document
Imports Raven.Client.Linq
Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Prism
Imports Microsoft.Practices.Prism.Regions
Imports Microsoft.Practices.Prism.Modularity
Imports System.Windows.Xps
Imports System.Windows.Xps.Packaging
Imports System.IO


Namespace ViewModels
    Public Class CreateCertificatesListVM
        Implements ICreateCertificateListVM, INotifyPropertyChanged


        Dim oneMonth As New TimeSpan(30, 0, 0, 0)
        Dim oneWeek As New TimeSpan(7, 0, 0, 0)
        Dim _InstrumentProvider As InstrumentDataProvider
        Dim _session As DocumentSession
        Private _events As IEventAggregator
        Private _instrs As ObservableCollection(Of InstrumentsListViewModel)
        Private _container As IUnityContainer
        Private _regionManager As IRegionManager


        Public Property Instruments As ObservableCollection(Of InstrumentsListViewModel) Implements ICreateCertificateListVM.Instruments
            Get
                Return _instrs
            End Get
            Set(value As ObservableCollection(Of InstrumentsListViewModel))
                _instrs = value
            End Set
        End Property


        Sub New(Container As IUnityContainer, RegionManager As IRegionManager, events As IEventAggregator)
            _events = events
            _InstrumentProvider = New InstrumentDataProvider
            _instrs = New ObservableCollection(Of InstrumentsListViewModel)
            InstrumentsWithNoCertificates()

            _container = Container
            _regionManager = RegionManager
        End Sub

        Public Property CreatedBy As String Implements ICreateCertificateListVM.CreatedBy
        Public Property VerificationType As String Implements ICreateCertificateListVM.VerificationType

        Public ReadOnly Property VerificationTypes As List(Of String)
            Get
                Dim mylist As New List(Of String)
                mylist.Add("Verification")
                mylist.Add("Re-Verification")
                Return mylist
            End Get
        End Property


        Public ReadOnly Property SealExpirationDate As String Implements ICreateCertificateListVM.SealExpirationDate
            Get
                Return FormatDateTime(DateAdd(DateInterval.Year, 5, Date.Now), DateFormat.ShortDate)
            End Get
        End Property

        Public Sub InstrumentsByCertificateNumber(CertID As String)
            Dim items As IEnumerable(Of IBaseInstrument) = _InstrumentProvider.GetInstrumentsByCertificateNumber(CertID)

            If _instrs Is Nothing Then _instrs = New ObservableCollection(Of InstrumentsListViewModel)
            _instrs.Clear()

            For Each i In items
                Dim ilvm = New InstrumentsListViewModel()
                ilvm.Instrument = i
                _instrs.Add(ilvm)
            Next

            NotifyPropertyChanged("BaseInstruments")
        End Sub

        Public Sub InstrumentsWithNoCertificates()
            Dim items As IEnumerable(Of IBaseInstrument) = _InstrumentProvider.GetInstrumentsWithNoCertificate()

            If _instrs Is Nothing Then _instrs = New ObservableCollection(Of InstrumentsListViewModel)
            _instrs.Clear()

            For Each i In items
                Dim ilvm = New InstrumentsListViewModel()
                ilvm.Instrument = i
                _instrs.Add(ilvm)
            Next
            NotifyPropertyChanged("BaseInstruments")
        End Sub

        Public Sub MiniMaxFilterInstruments()
            Dim tempInstrument = (From i In _instrs
                                    Where i.Instrument.InstrumentType = miSerialProtocol.InstrumentTypeCode.MiniMax
                                    Select i).ToList

            _instrs.Clear()
            For Each i In tempInstrument
                _instrs.Add(i)
            Next

            NotifyPropertyChanged("BaseInstruments")
        End Sub

        Public Sub EC300FilterINstruments()
            Dim tempInstrument = (From i In _instrs
                         Where i.Instrument.InstrumentType = miSerialProtocol.InstrumentTypeCode.EC300
                         Select i).ToList

            _instrs.Clear()
            For Each i In tempInstrument
                _instrs.Add(i)
            Next

            NotifyPropertyChanged("BaseInstruments")
        End Sub

        Public Sub OneWeekFilterClick()
            Dim tempInstrument = (From i In _instrs
                         Where i.Instrument.CreatedDate >= Now.AddDays(-7)
                         Select i).ToList

            _instrs.Clear()
            For Each i In tempInstrument
                _instrs.Add(i)
            Next

            NotifyPropertyChanged("BaseInstruments")
        End Sub

        Public Sub OneMonthFilterClick()

            Dim tempInstrument = (From i In _instrs
                          Where i.Instrument.CreatedDate >= Now.AddMonths(-1)
                          Select i).ToList

            _instrs.Clear()
            For Each i In tempInstrument
                _instrs.Add(i)
            Next

            NotifyPropertyChanged("BaseInstruments")
        End Sub

        Public Sub UpdateSerialFilter()

            Dim items As IEnumerable(Of IBaseInstrument) = _InstrumentProvider.GetInstrumentsBySerialNumber("")

            _instrs.Clear()
            For Each i In items
                _instrs.Add(i)
            Next
            NotifyPropertyChanged("BaseInstruments")
        End Sub

        Public Sub AddNewTestClick()
            _events.GetEvent(Of SelectedInstrumentChangedEvent).Publish(Nothing)
        End Sub

        Public Async Sub CreateNewCertClick()
            If CreatedBy Is Nothing Then
                MsgBox("Created By cannot be empty.", MsgBoxStyle.OkOnly, "Created By")
                Return
            End If

            If _instrs.Where(Function(x) x.IsSelected = True).Count >= 1 And _instrs.Where(Function(x) x.IsSelected = True).Count <= 8 Then
                Dim CertProvider As CertificateDataProvider
                Dim InstrumentProvider As InstrumentDataProvider = New InstrumentDataProvider
                Dim cert = New Certificate()
                cert.CreatedBy = Me.CreatedBy
                cert.VerificationType = Me.VerificationType
                cert.SealExpirationDate = Me.SealExpirationDate
                cert.Instruments = (From i In _instrs
                                   Where i.IsSelected = True
                                   Select i.Instrument).ToList

                CertProvider = New CertificateDataProvider

                Dim certID = Await CertProvider.UpsertCertificate(cert)
                cert.Id = certID

                For Each x In (From i In _instrs Where i.IsSelected = True Select i.Instrument).ToList
                    x.InspectionID = certID
                    Await InstrumentProvider.UpsertInstrument(x)
                Next x


                Me.CreateFixedDocument(cert)

                cert.SetNextCertificateNumber()
                Me.InstrumentsWithNoCertificates()

                '_regionManager.RequestNavigate(RegionNames.MainRegion, New Uri("CertificateReportViewer", UriKind.Relative))
            End If
        End Sub

        Function CanCreateNewCertClick() As Boolean
            Return True
            If _instrs IsNot Nothing Then
                If _instrs.Where(Function(x) x.IsSelected = True).Count >= 1 And _instrs.Where(Function(x) x.IsSelected = True).Count <= 10 Then
                    Return True
                End If
            End If

            Return False
        End Function




#Region "commands"

        Private _resetFillterCommand = New Microsoft.Practices.Prism.Commands.DelegateCommand(AddressOf InstrumentsWithNoCertificates)
        Public ReadOnly Property ResetFilterCommand As System.Windows.Input.ICommand Implements ICreateCertificateListVM.ResetFilterCommand
            Get
                Return _resetFillterCommand
            End Get
        End Property

        Private _oneWeekFilterCommand = New Microsoft.Practices.Prism.Commands.DelegateCommand(AddressOf OneWeekFilterClick)
        Public ReadOnly Property OneWeekFilterCommand As System.Windows.Input.ICommand Implements ICreateCertificateListVM.OneWeekFilterCommand
            Get
                Return _oneWeekFilterCommand
            End Get
        End Property

        Private _oneMonthFilterCommand = New Microsoft.Practices.Prism.Commands.DelegateCommand(AddressOf OneMonthFilterClick)
        Public ReadOnly Property OneMonthFilterCommand As System.Windows.Input.ICommand Implements ICreateCertificateListVM.OneMonthFilterCommand
            Get
                Return _oneMonthFilterCommand
            End Get
        End Property

        Private _MiniMaxFilterCommand = New Microsoft.Practices.Prism.Commands.DelegateCommand(AddressOf MiniMaxFilterInstruments)
        Public ReadOnly Property MiniMaxFilterCommand As System.Windows.Input.ICommand Implements ICreateCertificateListVM.MiniMaxFilterCommand
            Get
                Return _MiniMaxFilterCommand
            End Get
        End Property

        Private _EC300FilterCommand = New Microsoft.Practices.Prism.Commands.DelegateCommand(AddressOf EC300FilterINstruments)
        Public ReadOnly Property EC300FilterCommand As System.Windows.Input.ICommand Implements ICreateCertificateListVM.EC300FilterCommand
            Get
                Return _EC300FilterCommand
            End Get
        End Property

        Private _onSerialFilterCommand = New Microsoft.Practices.Prism.Commands.DelegateCommand(AddressOf OneMonthFilterClick)
        Public ReadOnly Property OnSerialFilterChange As System.Windows.Input.ICommand Implements ICreateCertificateListVM.OnSerialFilterChange

            Get
                Return _oneMonthFilterCommand
            End Get
        End Property

        Private _createNewCommand = New Microsoft.Practices.Prism.Commands.DelegateCommand(AddressOf CreateNewCertClick, AddressOf CanCreateNewCertClick)
        Public ReadOnly Property CreateNewCertCommand As System.Windows.Input.ICommand Implements ICreateCertificateListVM.CreateNewCertCommand

            Get
                Return _createNewCommand
            End Get
        End Property

#End Region

        Public Event PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        Private Sub NotifyPropertyChanged(ByVal propname As String)
            RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propname))
        End Sub




        Public Sub CreateFixedDocument(Certificate As ICertificate)
            Dim certPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Certificates")
            Dim doc As New FixedDocument()
            doc.DocumentPaginator.PageSize = New Size(96 * 11, 96 * 8.5)

            Dim page = New PageContent
            Dim fixedPage = New FixedPage

            fixedPage.Background = Brushes.White
            fixedPage.Width = 96 * 11
            fixedPage.Height = 96 * 8.5


            'Build the header
            Dim reportHeader = New CertificateHeader

            fixedPage.SetLeft(reportHeader, 35)
            fixedPage.SetTop(reportHeader, 96 * 0.15)
            reportHeader.Height = 96 * 1
            reportHeader.Width = 96 * 11
            fixedPage.Children.Add(CType(reportHeader, UIElement))

            'The instrument list
            Dim certsVm = New CreateCertificatesListVM(_container, _regionManager, _events)
            certsVm.InstrumentsByCertificateNumber(Certificate.Id)
            Dim certList = New CertificatesList()
            certList.DataContext = certsVm
            certList.Width = 96 * 10.5
            fixedPage.SetLeft(certList, 20)
            fixedPage.SetTop(certList, 115)
            fixedPage.Measure(New Windows.Size(96 * 11, 96 * 8.5))
            fixedPage.Children.Add(CType(certList, UIElement))

            'Build the footer
            Dim certFooterVM = New CertificateFootViewModel(_container, _regionManager, _events)
            certFooterVM.Certificate = Certificate
            Dim certFooter = New CertificateFooter
            certFooter.DataContext = certFooterVM
            certFooter.Height = 150
            certFooter.Width = 96 * 10
            fixedPage.SetLeft(certFooter, 35)
            fixedPage.SetTop(certFooter, 96 * 8)
            fixedPage.Children.Add(CType(certFooter, UIElement))

            DirectCast(page, System.Windows.Markup.IAddChild).AddChild(fixedPage)
            If System.IO.Directory.Exists(certPath) = False Then
                Directory.CreateDirectory(certPath)
            End If

            Dim xpsd = New XpsDocument(certPath + "\Certificate_" + Replace(Certificate.Number, "/", "") + ".xps", FileAccess.ReadWrite)
            Dim xw = XpsDocument.CreateXpsDocumentWriter(xpsd)
            doc.Pages.Add(page)
            xw.Write(doc)
            xpsd.Close()

        End Sub




    End Class

    Public Class InstrumentsListViewModel
        Public Property Instrument As IBaseInstrument
        Public Property IsSelected As Boolean
    End Class



End Namespace


