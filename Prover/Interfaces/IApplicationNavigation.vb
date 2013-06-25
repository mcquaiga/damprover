Imports System.Collections.ObjectModel

Public Interface IApplicationNavigation(Of T)
    Sub [GoTo](ByVal target As T)
    Sub [GoTo](Of G As T)()
    Sub GoBack(ByVal target As T)
    Sub GoBack()
    Sub GoToStart()

    ReadOnly Property CanGoBack As Boolean

    ReadOnly Property Current As T
    ReadOnly Property History As IEnumerable(Of T)
    ReadOnly Property BackList As IEnumerable(Of T)

    Event GoingForward(ByVal sender As Object, ByRef e As NavigatingEventArgs)
    Event GoingBack(ByVal sender As Object, ByRef e As NavigatingEventArgs)
    Event GoneForward(ByVal sender As Object, ByVal e As NavigatedEventArgs)
    Event GoneBack(ByVal sender As Object, ByVal e As NavigatedEventArgs)

    Event NavigationBlocked(ByVal sender As Object, ByVal e As NavigationBlockedEventArgs)

    Class NavigatingEventArgs
        Public Sub New(ByVal targetObject As T)
            _target = targetObject
        End Sub

        Private _target As T
        Public ReadOnly Property Target() As T
            Get
                Return _target
            End Get
        End Property

        Public Property Cancel As Boolean = False
    End Class

    Class NavigatedEventArgs
        Public Sub New(ByVal targetObject As T)
            _target = targetObject
        End Sub

        Private _target As T
        Public ReadOnly Property Target() As T
            Get
                Return _target
            End Get
        End Property
    End Class

    Class NavigationBlockedEventArgs
        Public Sub New(ByVal Block As INavigationBlock)
            Me.Block = Block
        End Sub
        Public Property Block As INavigationBlock
        Public Property Cancel As Boolean = False
    End Class

End Interface

