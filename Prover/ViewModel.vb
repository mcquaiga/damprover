Public Class ViewModel

    Private Property _view As IView(Of Object)

    Public Property View As Object
        Get
            Return _view
        End Get
        Set(value As Object)
            _view = value
        End Set
    End Property

    Sub New(View As IView(Of Object))

        If View Is Nothing Then Throw New ArgumentNullException("View")

        Me._view = View
        Me._view.DataContext = Me
    End Sub



End Class
