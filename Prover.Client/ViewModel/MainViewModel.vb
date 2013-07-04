Imports Microsoft.Practices.Prism.Events

Public Class MainViewModel
    Implements IMainVM

    Private _events As IEventAggregator


    Sub New(events As IEventAggregator)
        _events = events
    End Sub
End Class
