Imports System
Imports System.ComponentModel
Imports System.Diagnostics

Namespace Prover.ViewModel

    Public MustInherit Class BaseViewModel
        Implements INotifyPropertyChanged

        Protected Sub BaseViewModel()
        End Sub


        Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged

        Public Sub RaisePropertyChanged(ByVal propertyName As String)
            If Me.GetType().GetProperty(propertyName) Is Nothing Then
                Throw New InvalidOperationException("The property " & propertyName & " does not exist")
            End If
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
    End Class

End Namespace