
Imports Microsoft.Practices.Prism.Regions

Public Class CreateCertificateListView
    Implements IView(Of ICreateCertificateList), IRegionMemberLifetime

    Sub New()
        'InitializeComponent()
    End Sub

    Sub New(viewModel As ICreateCertificateList)
        DataContext1 = viewModel
        'InitializeComponent()
    End Sub

    Public ReadOnly Property KeepAlive As Boolean Implements IRegionMemberLifetime.KeepAlive
        Get
            Return False
        End Get
    End Property

    Public Property DataContext1 As ICreateCertificateList Implements IView(Of ICreateCertificateList).DataContext

End Class
