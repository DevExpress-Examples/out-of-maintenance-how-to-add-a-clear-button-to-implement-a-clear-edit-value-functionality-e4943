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
