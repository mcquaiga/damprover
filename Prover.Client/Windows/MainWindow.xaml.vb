Public Class MainWindow
    Implements IView(Of IMainVM)


    Sub New()
        InitializeComponent()
    End Sub

    Sub New(viewModel As IMainVM)
        DataContext = viewModel
        InitializeComponent()
    End Sub

    Public Property DataContext1 As IMainVM Implements IView(Of IMainVM).DataContext

End Class
