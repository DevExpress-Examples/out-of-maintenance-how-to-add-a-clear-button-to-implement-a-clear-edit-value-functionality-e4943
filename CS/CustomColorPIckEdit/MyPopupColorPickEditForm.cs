using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Q535402 {
    public class MyPopupColorPickEditForm : PopupColorPickEditForm {
        private SimpleButton fClearButton;

        public int ClearBtnHeight {
            get {
                return fClearButton.Height;
            }
        }

        public bool ShowClear {
            get {
                var properties = (RepositoryItemMyColorPickEdit)(OwnerEdit.Properties);
                return properties.ShowClear;
            }
        }
        public MyPopupColorPickEditForm(ColorEdit ownerEdit)
            : base(ownerEdit) {
            Controls.Add(GetClearButton());
        }
        protected override DevExpress.XtraEditors.Popup.PopupBaseFormViewInfo CreateViewInfo() {
            return new MyPopupBaseFormViewInfo(this);
        }
        protected override void OnPopupDropDown() {
            base.OnPopupDropDown();
            if (ShowClear) {
                fClearButton.Visible = ShowClear;
            }
        }
        private Control GetClearButton() {
            fClearButton = new SimpleButton() {
                Text = "Clear",
                Dock = DockStyle.Bottom
            };
            fClearButton.Click += clearButton_Click;
            return fClearButton;
        }
        private void clearButton_Click(object sender, EventArgs e) {
            if (!ShowClear) {
                return;
            }
            OwnerEdit.EditValue = null;
            Close();
        }
        public override System.Drawing.Size CalcFormSize(System.Drawing.Size contentSize) {
            var formSize = base.CalcFormSize(contentSize);
            if (ShowClear) {
                formSize.Height += ClearBtnHeight;
            }
            return formSize;
        }
    }
}
