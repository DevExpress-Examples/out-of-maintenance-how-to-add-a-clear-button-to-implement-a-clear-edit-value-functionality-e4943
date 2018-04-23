Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors.Popup
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq

Namespace Q535402
	Public Class MyPopupBaseFormViewInfo
		Inherits PopupBaseFormViewInfo
		Public Sub New(ByVal form As PopupBaseForm)
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
