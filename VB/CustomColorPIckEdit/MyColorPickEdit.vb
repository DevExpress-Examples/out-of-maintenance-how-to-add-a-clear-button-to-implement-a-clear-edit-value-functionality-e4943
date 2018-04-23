Imports Microsoft.VisualBasic
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
		Protected Overrides Function CreatePopupForm() As DevExpress.XtraEditors.Popup.PopupBaseForm
			Dim popupForm = New MyPopupColorPickEditForm(Me)
			AddHandler popupForm.HandleCreated, AddressOf OnPopupFormHandleCreated
			Return popupForm
		End Function
		Private Sub OnPopupFormHandleCreated(ByVal sender As Object, ByVal e As EventArgs)
			BeforeDoShowPopup()
		End Sub
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
