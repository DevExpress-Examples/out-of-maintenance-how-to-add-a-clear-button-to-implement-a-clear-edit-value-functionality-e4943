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

Imports DevExpress.XtraEditors.Popup
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports DevExpress.XtraEditors

Namespace Q535402
    Public Class MyPopupBaseFormViewInfo
        Inherits PopupColorPickEditFormViewInfo

        Public Sub New(ByVal form As PopupColorPickEditForm)
            MyBase.New(form)

        End Sub

        Protected Overrides Sub CalcContentRect(ByVal bounds As Rectangle)
            Dim popupForm = CType(Form, MyPopupColorPickEditForm)
            If popupForm.ShowClear Then
                Dim clearButtonHeight = popupForm.ClearBtnHeight
                Dim contentRect = New Rectangle(bounds.Location, New Size(bounds.Width, bounds.Height - clearButtonHeight))
                fContentRect = contentRect
                Return
            End If
            MyBase.CalcContentRect(bounds)
        End Sub
    End Class
End Namespace
