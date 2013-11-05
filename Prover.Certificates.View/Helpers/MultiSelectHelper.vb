Imports System.Collections.Specialized
Imports System.Windows.Controls.Primitives

Public Class MultiSelectHelper


    Private Shared Function GetListBoxTracker(ByVal element As DependencyObject) As ListBoxSelectedItemsChangeTracker
        If element Is Nothing Then
            Throw New ArgumentNullException("element")
        End If

        Return element.GetValue(ListBoxTrackerProperty)
    End Function

    Private Shared Sub SetListBoxTracker(ByVal element As DependencyObject, ByVal value As ListBoxSelectedItemsChangeTracker)
        If element Is Nothing Then
            Throw New ArgumentNullException("element")
        End If

        element.SetValue(ListBoxTrackerProperty, value)
    End Sub

    Private Shared ReadOnly ListBoxTrackerProperty As  _
                           DependencyProperty = DependencyProperty.RegisterAttached("ListBoxTracker", _
                           GetType(ListBoxSelectedItemsChangeTracker), GetType(MultiSelectHelper), _
                           New FrameworkPropertyMetadata(Nothing))

    Public Shared Function GetSelectedItems(ByVal element As DependencyObject) As IEnumerable(Of Object)
        If element Is Nothing Then
            Throw New ArgumentNullException("element")
        End If

        Return element.GetValue(SelectedItemsProperty)
    End Function

    Public Shared Sub SetSelectedItems(ByVal element As DependencyObject, ByVal value As IEnumerable(Of Object))
        If element Is Nothing Then
            Throw New ArgumentNullException("element")
        End If

        element.SetValue(SelectedItemsProperty, value)
    End Sub

    Public Shared ReadOnly SelectedItemsProperty As  _
                           DependencyProperty = DependencyProperty.RegisterAttached("SelectedItems", _
                           GetType(IEnumerable(Of Object)), GetType(MultiSelectHelper), _
                           New FrameworkPropertyMetadata(Nothing, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, AddressOf OnSelectedItemsPropertyChanged))

    Private Shared Sub OnSelectedItemsPropertyChanged(ByVal sender As DependencyObject, ByVal args As DependencyPropertyChangedEventArgs)

        Dim listBox = TryCast(sender, ListBox)

        ' Error check: make sure the property was set on a listbox or derived class
        If listBox Is Nothing Then
            Throw New InvalidOperationException("MultiSelectHelper.SelectedItems attached property can only be used on a ListBox")
        End If

        Dim tracker = GetListBoxTracker(listBox)
        If tracker Is Nothing Then
            tracker = New ListBoxSelectedItemsChangeTracker(listBox)
            SetListBoxTracker(listBox, tracker)
        End If

        If args.OldValue Is Nothing Then
            ' If this is the first time setting the property on the listbox then start tracking its changes
            AddHandler listBox.SelectionChanged, AddressOf tracker.OnSelectorSelectionChanged
        End If

        Dim selectedItems = DirectCast(args.NewValue, IEnumerable(Of Object))

        ' Track changes to the collection if it is observable
        Dim collectionChangeNotifier = TryCast(selectedItems, INotifyCollectionChanged)
        If collectionChangeNotifier IsNot Nothing Then
            AddHandler collectionChangeNotifier.CollectionChanged, AddressOf tracker.OnSelectedItemsCollectionChanged
        End If

        ' Make the listbox select exactly the items that are in SelectedItemsProperty
        If Not tracker.IgnoreListBoxSelectionChanges Then
            tracker.IgnoreCollectionChanges = True
            Try
                tracker.SelectItemsOnListBox(selectedItems)
            Finally
                tracker.IgnoreCollectionChanges = False
            End Try
        End If

    End Sub

    Private Class ListBoxSelectedItemsChangeTracker

        Private _listBox As ListBox
        Private _ignoreCollectionChanges As Boolean = False
        Private _ignoreListBoxSelectionChanges As Boolean = False

        Public Sub New(ByVal listBox As ListBox)
            _listBox = listBox
        End Sub

        Public Sub OnSelectedItemsCollectionChanged(ByVal sender As Object, ByVal args As NotifyCollectionChangedEventArgs)
            If _ignoreListBoxSelectionChanges Then Exit Sub

            IgnoreCollectionChanges = True
            Try
                SelectItemsOnListBox(DirectCast(sender, IEnumerable))
            Finally
                IgnoreCollectionChanges = False
            End Try
        End Sub

        Public Sub OnSelectorSelectionChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)

            If IgnoreCollectionChanges Then Exit Sub

            _ignoreListBoxSelectionChanges = True
            Try
                Dim listBox = DirectCast(sender, ListBox)
                Dim newSelectedItemsCollection = listBox.SelectedItems.OfType(Of Object).ToList
                SetSelectedItems(listBox, newSelectedItemsCollection)
                'Dim selectedItems = GetSelectedItems(listBox)

                'For Each itemToRemove In selectedItems.OfType(Of Object).Except(listBox.SelectedItems.OfType(Of Object)).ToList()
                '    selectedItems.Remove(itemToRemove)
                'Next
                'For Each itemToAdd In listBox.SelectedItems.OfType(Of Object).Except(selectedItems.OfType(Of Object)).ToList()
                '    selectedItems.Add(itemToAdd)
                'Next
            Finally
                _ignoreListBoxSelectionChanges = False
            End Try

        End Sub

        Public Sub SelectItemsOnListBox(ByVal itemsToSelect As IEnumerable)

            If itemsToSelect IsNot Nothing Then
                For Each itemToRemove In _listBox.SelectedItems.OfType(Of Object).Except(itemsToSelect.OfType(Of Object)).ToList()
                    _listBox.SelectedItems.Remove(itemToRemove)
                Next
                For Each itemToAdd In itemsToSelect.OfType(Of Object).Except(_listBox.SelectedItems.OfType(Of Object)).ToList()
                    Dim namedEntity = TryCast(itemToAdd, Object)
                    If namedEntity IsNot Nothing Then
                        itemToAdd = GetEquivalentItem(namedEntity)
                    End If
                    _listBox.SelectedItems.Add(itemToAdd)
                Next
            End If

        End Sub

        Private Function GetEquivalentItem(entity As Object) As Object
            For Each item In _listBox.Items.OfType(Of Object)()
                If item.Id = entity.Id Then
                    Return item
                End If
            Next
            Return Nothing
        End Function

        Public Property IgnoreCollectionChanges() As Boolean
            Get
                Return _ignoreCollectionChanges
            End Get
            Set(value As Boolean)
                _ignoreCollectionChanges = Value
            End Set
        End Property

        Public ReadOnly Property IgnoreListBoxSelectionChanges As Boolean
            Get
                Return _ignoreListBoxSelectionChanges
            End Get
        End Property

    End Class

End Class