using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Q535402 {
    public class RepositoryItemMyColorPickEdit : RepositoryItemColorPickEdit {
        private bool _ShowClear = true;
        [DefaultValue(true)]
        public bool ShowClear {
            get {
                return _ShowClear;
            }
            set {
                _ShowClear = value;
            }
        }
        public const string fEditorName = "MyColorPickEdit";
        public override string EditorTypeName {
            get {
                return fEditorName;
            }
        }
        public RepositoryItemMyColorPickEdit() {
        }
        static RepositoryItemMyColorPickEdit() {
            RegisterEditor();
        }
        public static void RegisterEditor() {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(fEditorName,
                typeof(MyColorPickEdit),
                typeof(RepositoryItemMyColorPickEdit),
                typeof(ColorEditViewInfo),
                new ColorEditPainter(), true, EditImageIndexes.ColorEdit));
        }
        public override void Assign(RepositoryItem item) {
            BeginUpdate();
            try {
                base.Assign(item);
                var source = item as RepositoryItemMyColorPickEdit;
                if (source == null) {
                    return;
                }
                ShowClear = source.ShowClear;
            } finally {
                EndUpdate();
            }
        }
        protected override void RaisePopup(EventArgs e) {
            base.RaisePopup(e);
        }
        public override void RaiseColorPickDialogShowing(DevExpress.XtraEditors.ColorPickDialogShowingEventArgs e) {
            base.RaiseColorPickDialogShowing(e);
        }
    }
}
