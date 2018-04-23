Imports Microsoft.VisualBasic
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
