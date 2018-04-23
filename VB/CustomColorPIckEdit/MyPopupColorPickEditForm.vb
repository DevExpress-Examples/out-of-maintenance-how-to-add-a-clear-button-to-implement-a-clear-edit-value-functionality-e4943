Imports Microsoft.VisualBasic
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
		Protected Overrides Sub OnPopupDropDown()
			MyBase.OnPopupDropDown()
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
			If (Not ShowClear) Then
				Return
			End If
			OwnerEdit.EditValue = Nothing
			Close()
		End Sub
		Public Overrides Function CalcFormSize(ByVal contentSize As System.Drawing.Size) As System.Drawing.Size
			Dim formSize = MyBase.CalcFormSize(contentSize)
			If ShowClear Then
				formSize.Height += ClearBtnHeight
			End If
			Return formSize
		End Function
	End Class
End Namespace
