using DevExpress.XtraEditors.Popup;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Q535402 {
    public class MyPopupBaseFormViewInfo : PopupBaseFormViewInfo {
        public MyPopupBaseFormViewInfo(PopupBaseForm form)
            : base(form) {
        }
        protected override void CalcContentRect(Rectangle bounds) {
            var popupForm = (MyPopupColorPickEditForm)Form;
            if (popupForm.ShowClear) {
                var clearButtonHeight = popupForm.ClearBtnHeight;
                var contentRect = new Rectangle(bounds.Location, new Size(bounds.Width, bounds.Height - clearButtonHeight));
                fContentRect = contentRect;
                return;
            }
            base.CalcContentRect(bounds);
        }
    }
}
