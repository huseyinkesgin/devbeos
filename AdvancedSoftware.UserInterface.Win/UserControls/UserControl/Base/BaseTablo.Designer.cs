namespace AdvancedSoftware.UserInterface.Win.UserControls.UserControl.Base
{
    partial class BaseTablo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addUptNavigator = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Navigators.AddUptNavigator();
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnHaraketEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnHaraketSil = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // addUptNavigator
            // 
            this.addUptNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addUptNavigator.Location = new System.Drawing.Point(0, 263);
            this.addUptNavigator.Name = "addUptNavigator";
            this.addUptNavigator.Size = new System.Drawing.Size(717, 24);
            this.addUptNavigator.TabIndex = 0;
            // 
            // popupMenu
            // 
            this.popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHaraketEkle),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHaraketSil)});
            this.popupMenu.Manager = this.barManager;
            this.popupMenu.Name = "popupMenu";
            // 
            // barManager
            // 
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnHaraketEkle,
            this.btnHaraketSil});
            this.barManager.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(717, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 287);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(717, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 287);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(717, 0);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 287);
            // 
            // btnHaraketEkle
            // 
            this.btnHaraketEkle.Caption = "Haraket Ekle";
            this.btnHaraketEkle.Id = 0;
            this.btnHaraketEkle.ImageOptions.Image = global::AdvancedSoftware.UserInterface.Win.Properties.Resources.add_16x16;
            this.btnHaraketEkle.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Insert));
            this.btnHaraketEkle.Name = "btnHaraketEkle";
            // 
            // btnHaraketSil
            // 
            this.btnHaraketSil.Caption = "Haraket Sil";
            this.btnHaraketSil.Id = 1;
            this.btnHaraketSil.ImageOptions.Image = global::AdvancedSoftware.UserInterface.Win.Properties.Resources.deletefooter_16x16;
            this.btnHaraketSil.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete));
            this.btnHaraketSil.Name = "btnHaraketSil";
            // 
            // BaseTablo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addUptNavigator);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "BaseTablo";
            this.Size = new System.Drawing.Size(717, 287);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.Navigators.AddUptNavigator addUptNavigator;
        protected DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraBars.BarButtonItem btnHaraketEkle;
        private DevExpress.XtraBars.BarButtonItem btnHaraketSil;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}
