Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms

Namespace Q535402
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			InitGridControl()
		End Sub
		Private Sub InitGridControl()
			GetDataSource()
			SetColumnEdit()
		End Sub
		Private Sub SetColumnEdit()
			Dim riColorPickEdit As New RepositoryItemMyColorPickEdit()
            gridControl1.RepositoryItems.Add(riColorPickEdit)            
			gridView1.Columns("ColorItem").ColumnEdit = riColorPickEdit
		End Sub
		Private Sub GetDataSource()
			gridControl1.DataSource = GetDS()
		End Sub
		#Region "GetDataSource"
		Private Function GetDS() As Object
			Dim colorObjList As New List(Of ColorObj)()
			colorObjList.Add(New ColorObj() With {.ID = 0, .ColorItem = Color.Green})
			colorObjList.Add(New ColorObj() With {.ID = 1, .ColorItem = Color.Yellow})
			colorObjList.Add(New ColorObj() With {.ID = 2, .ColorItem = Color.Red})
			Return colorObjList
		End Function
		#End Region
	End Class
End Namespace
