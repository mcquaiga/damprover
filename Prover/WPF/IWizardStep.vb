Public Interface IWizardStep

    ReadOnly Property Title As String

    Property IsActiveStep As Boolean
    Property IsStepEnabled As Boolean
    ReadOnly Property IsStepHeaderVisible As Boolean

    'Function GetValidationErrors() As IEnumerable(Of ValidationHelper.DataError)

    Event ValidationResultsChanged(wizardStep As IWizardStep)

End Interface
