﻿Imports System.Reflection
Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Prism
Imports Microsoft.Practices.Prism.Events
Imports Microsoft.Practices.Prism.Regions
Imports Microsoft.Practices.Prism.Modularity
Imports System.Globalization
Imports System.Windows
Imports Prover
Imports Prover.Instruments.View

Public Class ProverBootstrapper
    Inherits UnityExtensions.UnityBootstrapper

    Protected _main As MainWindow

    Sub New()
        MyBase.New()
    End Sub


    Protected Overrides Function CreateShell() As System.Windows.DependencyObject
        _main = Container.Resolve(Of MainWindow)()
        Return _main
    End Function

    Protected Overrides Sub ConfigureContainer()
        MyBase.ConfigureContainer()

    End Sub

    Protected Overrides Sub InitializeShell()
        MyBase.InitializeShell()
        'Application.Current.MainWindow = DirectCast(Window, MainWindow)()
        Application.Current.MainWindow.Show()
    End Sub

    'Protected Overrides Sub InitializeModules()
    '    MyBase.InitializeModules()
    'End Sub

    Protected Overrides Sub ConfigureModuleCatalog()
        'MyBase.ConfigureModuleCatalog()
        Dim InstrumentModuleType As Type = GetType(InstrumentsViewModule)
        ModuleCatalog.AddModule(New ModuleInfo(InstrumentModuleType.Name, InstrumentModuleType.AssemblyQualifiedName))

    End Sub
End Class