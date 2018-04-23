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
Imports System.Linq
Imports System.Windows.Forms

Namespace Q535402
    Public Class MyPopupColorPickEditForm
        Inherits PopupColorPickEditForm

        Private fClearButton As SimpleButton

        Public ReadOnly Property ClearBtnHeight() As Integer
            Get
                Return fClearButton.Height
            End Get
        End Property

        Public ReadOnly Property ShowClear() As Boolean
            Get
                Dim properties = CType(OwnerEdit.Properties, RepositoryItemMyColorPickEdit)
                Return properties.ShowClear
            End Get
        End Property
        Public Sub New(ByVal ownerEdit As ColorEdit)
            MyBase.New(ownerEdit)
            Controls.Add(GetClearButton())
        End Sub
        Protected Overrides Function CreateViewInfo() As DevExpress.XtraEditors.Popup.PopupBaseFormViewInfo
            Return New MyPopupBaseFormViewInfo(Me)
        End Function

        Protected Overrides Sub OnBeforeShowPopup()
            MyBase.OnBeforeShowPopup()
            If ShowClear Then
                fClearButton.Visible = ShowClear
            End If
        End Sub

        Private Function GetClearButton() As Control
            fClearButton = New SimpleButton() With {.Text = "Clear", .Dock = DockStyle.Bottom}
            AddHandler fClearButton.Click, AddressOf clearButton_Click
            Return fClearButton
        End Function
        Private Sub clearButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Not ShowClear Then
                Return
            End If
            OwnerEdit.EditValue = Nothing
            Close()
        End Sub
        Public Overrides Function CalcFormSize(ByVal contentSize As System.Drawing.Size) As System.Drawing.Size
            If ShowClear Then
                contentSize.Height += ClearBtnHeight
            End If
            Return MyBase.CalcFormSize(contentSize)
        End Function
    End Class
End Namespace
