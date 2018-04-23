' Developer Express Code Central Example:
' How to add a Clear button to implement a clear edit value functionality
' 
' This example demonstrates how to add a Clear button to the ColorPickEdit
' dropdown form to implement a clear edit value functionality.
' For this, add the
' ShowClear property to the RepositoryItemMyColorPickEdit class, create a
' SimpleButton, and add it to the Control collection of the dropdown form. The
' ShowClear property specifies the visibility of the Clear button in the dropdown
' form. If the value is true, the dropdown form contains a Clear button;
' otherwise, false. The default is true. The Clear button allows end-users to
' clear the currently selected color. Clicking the button assigns the null value
' to the edit value and closes the dropdown. You can use this approach both in
' inplace and standalone modes.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4943

Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq

Namespace Q535402
    Public Class RepositoryItemMyColorPickEdit
        Inherits RepositoryItemColorPickEdit

        Private _ShowClear As Boolean = True
        <DefaultValue(True)> _
        Public Property ShowClear() As Boolean
            Get
                Return _ShowClear
            End Get
            Set(ByVal value As Boolean)
                _ShowClear = value
            End Set
        End Property
        Public Const fEditorName As String = "MyColorPickEdit"
        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return fEditorName
            End Get
        End Property
        Public Sub New()
        End Sub
        Shared Sub New()
            RegisterEditor()
        End Sub
        Public Shared Sub RegisterEditor()
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(fEditorName, GetType(MyColorPickEdit), GetType(RepositoryItemMyColorPickEdit), GetType(ColorEditViewInfo), New ColorEditPainter(), True, EditImageIndexes.ColorEdit))
        End Sub
        Public Overrides Sub Assign(ByVal item As RepositoryItem)
            BeginUpdate()
            Try
                MyBase.Assign(item)
                Dim source = TryCast(item, RepositoryItemMyColorPickEdit)
                If source Is Nothing Then
                    Return
                End If
                ShowClear = source.ShowClear
            Finally
                EndUpdate()
            End Try
        End Sub
        Protected Overrides Sub RaisePopup(ByVal e As EventArgs)
            MyBase.RaisePopup(e)
        End Sub
        Public Overrides Sub RaiseColorPickDialogShowing(ByVal e As DevExpress.XtraEditors.ColorPickDialogShowingEventArgs)
            MyBase.RaiseColorPickDialogShowing(e)
        End Sub
    End Class
End Namespace
