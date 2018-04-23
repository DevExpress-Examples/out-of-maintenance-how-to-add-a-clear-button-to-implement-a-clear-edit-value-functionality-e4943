// Developer Express Code Central Example:
// How to add a Clear button to implement a clear edit value functionality
// 
// This example demonstrates how to add a Clear button to the ColorPickEdit
// dropdown form to implement a clear edit value functionality.
// For this, add the
// ShowClear property to the RepositoryItemMyColorPickEdit class, create a
// SimpleButton, and add it to the Control collection of the dropdown form. The
// ShowClear property specifies the visibility of the Clear button in the dropdown
// form. If the value is true, the dropdown form contains a Clear button;
// otherwise, false. The default is true. The Clear button allows end-users to
// clear the currently selected color. Clicking the button assigns the null value
// to the edit value and closes the dropdown. You can use this approach both in
// inplace and standalone modes.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4943

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Q535402 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            InitGridControl();
        }
        private void InitGridControl() {
            GetDataSource();
            SetColumnEdit();
        }
        private void SetColumnEdit() {            
            RepositoryItemMyColorPickEdit riColorPickEdit = new RepositoryItemMyColorPickEdit();
            gridControl1.RepositoryItems.Add(riColorPickEdit);
            gridView1.Columns["ColorItem"].ColumnEdit = riColorPickEdit;
        }
        private void GetDataSource() {
            gridControl1.DataSource = GetDS();
        }
        #region GetDataSource
        private object GetDS() {
            List<ColorObj> colorObjList = new List<ColorObj>();
            colorObjList.Add(new ColorObj(){ID = 0, ColorItem = Color.Green});
            colorObjList.Add(new ColorObj(){ID = 1, ColorItem = Color.Yellow});
            colorObjList.Add(new ColorObj(){ID = 2, ColorItem = Color.Red});
            return colorObjList;
        }
        #endregion
    }
}
