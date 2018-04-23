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
