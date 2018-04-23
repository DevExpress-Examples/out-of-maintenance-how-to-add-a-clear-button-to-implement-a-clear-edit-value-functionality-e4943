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

namespace Q535402 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.myColorPickEdit1 = new Q535402.MyColorPickEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myColorPickEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 259);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // myColorPickEdit1
            // 
            this.myColorPickEdit1.EditValue = System.Drawing.Color.Empty;
            this.myColorPickEdit1.Location = new System.Drawing.Point(459, 40);
            this.myColorPickEdit1.Name = "myColorPickEdit1";
            this.myColorPickEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.myColorPickEdit1.Size = new System.Drawing.Size(100, 20);
            this.myColorPickEdit1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 259);
            this.Controls.Add(this.myColorPickEdit1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myColorPickEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private MyColorPickEdit myColorPickEdit1;

    }
}

