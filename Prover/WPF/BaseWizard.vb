Imports System.ComponentModel

Public MustInherit Class BaseWizardStep
    Implements IWizardStep, INotifyPropertyChanged

    Private _isActiveStep As Boolean = False
    Private _isStepEnabled As Boolean = False

    Public Sub New()
        Dim notifier = TryCast(Me, INotifyPropertyChanged)
        If notifier IsNot Nothing Then
            AddHandler notifier.PropertyChanged, AddressOf OnPropertyChanged
        End If
    End Sub

    Public Property IsActiveStep As Boolean Implements IWizardStep.IsActiveStep
        Get
            Return _isActiveStep
        End Get
        Set(ByVal value As Boolean)
            _isActiveStep = value
            RaisePropertyChanged("IsActiveStep")
            RaisePropertyChanged("IsStepEnabled")
        End Set
    End Property


    Public MustOverride Property IsStepEnabled As Boolean Implements IWizardStep.IsStepEnabled

    Public Overridable ReadOnly Property IsStepHeaderVisible As Boolean Implements IWizardStep.IsStepHeaderVisible
        Get
            Return True
        End Get
    End Property

    Public MustOverride ReadOnly Property Title As String Implements IWizardStep.Title

    'Public Function GetValidationErrors() As IEnumerable(Of ValidationHelper.DataError) Implements IWizardStep.GetValidationErrors
    '    Return GetIDataErrorInfoValidationErrors().Union(GetCustomValidationErrors())
    'End Function

    'Private Function GetIDataErrorInfoValidationErrors() As IEnumerable(Of ValidationHelper.DataError)
    '    Dim dataErrorInfo = TryCast(Me, IDataErrorInfo)
    '    If dataErrorInfo IsNot Nothing Then
    '        Return ValidationHelper.GetValidationErrors(dataErrorInfo)
    '    Else
    '        Return New ValidationHelper.DataError() {}
    '    End If
    'End Function

    'Protected Overridable Function GetCustomValidationErrors() As IEnumerable(Of ValidationHelper.DataError)
    '    Return New ValidationHelper.DataError() {}
    'End Function

    Protected Sub RaiseValidationResultsChanged()
        RaiseEvent ValidationResultsChanged(Me)
    End Sub

    Public Sub RaisePropertyChanged(ByVal propertyName As String)
        If Me.GetType().GetProperty(propertyName) Is Nothing Then
            Throw New InvalidOperationException("The property " & propertyName & " does not exist")
        End If
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

    Private Sub OnPropertyChanged(sender As Object, args As PropertyChangedEventArgs)
        RaiseValidationResultsChanged()
    End Sub

    Public Event PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

    Public Event ValidationResultsChanged(wizardStep As IWizardStep) Implements IWizardStep.ValidationResultsChanged
End Class
