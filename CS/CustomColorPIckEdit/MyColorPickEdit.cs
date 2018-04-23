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
using System.ComponentModel;
using System.Linq;

namespace Q535402 {
    [ToolboxItem(true)]
    public class MyColorPickEdit : ColorPickEdit {
        static MyColorPickEdit() {
            RepositoryItemMyColorPickEdit.RegisterEditor();
        }

        protected override PopupColorPickEditForm CreatePopupFormInternal() {
            return new MyPopupColorPickEditForm(this);
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
