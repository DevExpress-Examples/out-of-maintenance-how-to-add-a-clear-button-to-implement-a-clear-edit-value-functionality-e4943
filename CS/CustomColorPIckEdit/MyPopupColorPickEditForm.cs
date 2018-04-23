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

        protected override void OnBeforeShowPopup() {
            base.OnBeforeShowPopup();
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
            if (ShowClear) {
                contentSize.Height += ClearBtnHeight;
            }
            return base.CalcFormSize(contentSize);
        }
    }
}
