Imports Prover
Imports System.Windows
Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Unity.Configuration.UnityContainerExtensions

Public Class Toolbar
    Implements IView(Of IToolBarVM)

    Sub New(ViewModel As IToolBarVM, Container As IUnityContainer)
        ToolBarDataContext = ViewModel
    End Sub

    <LocalizabilityAttribute(LocalizationCategory.NeverLocalize)> _
    Private Property ToolBarDataContext As IToolBarVM Implements IView(Of IToolBarVM).DataContext

End Class
