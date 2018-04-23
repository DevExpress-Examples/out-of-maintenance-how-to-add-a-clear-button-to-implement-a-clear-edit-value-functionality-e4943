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

Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq

Namespace Q535402
    <ToolboxItem(True)> _
    Public Class MyColorPickEdit
        Inherits ColorPickEdit

        Shared Sub New()
            RepositoryItemMyColorPickEdit.RegisterEditor()
        End Sub

        Protected Overrides Function CreatePopupFormInternal() As PopupColorPickEditForm
            Return New MyPopupColorPickEditForm(Me)
        End Function

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public Shadows ReadOnly Property Properties() As RepositoryItemMyColorPickEdit
            Get
                Return TryCast(MyBase.Properties, RepositoryItemMyColorPickEdit)
            End Get
        End Property
        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return RepositoryItemMyColorPickEdit.fEditorName
            End Get
        End Property
    End Class
End Namespace
