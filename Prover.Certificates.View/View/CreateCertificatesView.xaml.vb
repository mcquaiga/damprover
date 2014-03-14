Imports Prover.Certificates.View.ViewModels

Public Class CreateCertificatesView
    Implements IView(Of ICreateCertificateListVM)

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub New(viewModel As ICreateCertificateListVM)
        DataContext = viewModel
        InitializeComponent()
    End Sub


    Public Property DataContext1 As ICreateCertificateListVM Implements IView(Of ICreateCertificateListVM).DataContext


End Class
