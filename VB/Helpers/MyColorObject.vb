Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq

Namespace Q535402
	Public Class ColorObj
		Public Sub New()
		End Sub
		Private privateID As Integer
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property
		Private privateColorItem As Color
		Public Property ColorItem() As Color
			Get
				Return privateColorItem
			End Get
			Set(ByVal value As Color)
				privateColorItem = value
			End Set
		End Property
	End Class
End Namespace
