Imports System.Reflection
Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Prism
Imports Microsoft.Practices.Prism.Events
Imports Microsoft.Practices.Prism.Regions
Imports Microsoft.Practices.Prism.Modularity
Imports System.Globalization
Imports System.Windows

Public Class ProverBootstrapper
    Inherits UnityExtensions.UnityBootstrapper

    Sub New()
        MyBase.New()
    End Sub


    Protected Overrides Function CreateShell() As System.Windows.DependencyObject
        Return Container.Resolve(Of MainWindow)()
    End Function


    Protected Overrides Sub ConfigureContainer()
        MyBase.ConfigureContainer()
    End Sub

    Protected Overrides Sub InitializeShell()
        MyBase.InitializeShell()

        'Application.Current.MainWindow = DirectCast(Window, MainWindow)()
        Application.Current.MainWindow.Show()
    End Sub

    Protected Overrides Sub InitializeModules()
        MyBase.InitializeModules()
    End Sub

End Class
