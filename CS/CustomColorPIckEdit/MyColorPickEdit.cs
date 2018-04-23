using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Q535402 {
    [ToolboxItem(true)]
    public class MyColorPickEdit : ColorPickEdit {
        static MyColorPickEdit() {
            RepositoryItemMyColorPickEdit.RegisterEditor();
        }
        protected override DevExpress.XtraEditors.Popup.PopupBaseForm CreatePopupForm() {
            var popupForm = new MyPopupColorPickEditForm(this);
            popupForm.HandleCreated += OnPopupFormHandleCreated;
            return popupForm;
        }
        private void OnPopupFormHandleCreated(object sender, EventArgs e) {
            BeforeDoShowPopup();
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemMyColorPickEdit Properties {
            get {
                return base.Properties as RepositoryItemMyColorPickEdit;
            }
        }
        public override string EditorTypeName {
            get {
                return RepositoryItemMyColorPickEdit.fEditorName;
            }
        }
    }
}
