﻿namespace AdvancedSoftware.UserInterface.Win.Forms.SiparisForms.IlceForms
{
    partial class IlceEditForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.MyDataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtKod = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.MyCodeTextEdit();
            this.lblKod = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtIlceAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.MyTextEdit();
            this.lblIlceAdi = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtAciklama = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.MyMemoEdit();
            this.lblAciklama = new DevExpress.XtraLayout.LayoutControlItem();
            this.tglDurum = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.MyToogleSwitch();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblKod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlceAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIlceAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAciklama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.OptionsPageCategories.ShowCaptions = false;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.AccessibleName = "Search Item";
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.Size = new System.Drawing.Size(388, 135);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.tglDurum);
            this.myDataLayoutControl.Controls.Add(this.txtAciklama);
            this.myDataLayoutControl.Controls.Add(this.txtIlceAdi);
            this.myDataLayoutControl.Controls.Add(this.txtKod);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 135);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.Root;
            this.myDataLayoutControl.Size = new System.Drawing.Size(388, 115);
            this.myDataLayoutControl.TabIndex = 0;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblKod,
            this.lblIlceAdi,
            this.lblAciklama,
            this.layoutControlItem4});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 200D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 100D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 99D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 100D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3});
            this.Root.Size = new System.Drawing.Size(388, 115);
            this.Root.TextVisible = false;
            // 
            // txtKod
            // 
            this.txtKod.EnterMoveNextControl = true;
            this.txtKod.Location = new System.Drawing.Point(65, 12);
            this.txtKod.MenuManager = this.ribbonControl;
            this.txtKod.Name = "txtKod";
            this.txtKod.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtKod.Properties.Appearance.Options.UseBackColor = true;
            this.txtKod.Properties.Appearance.Options.UseTextOptions = true;
            this.txtKod.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtKod.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtKod.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKod.Properties.MaxLength = 20;
            this.txtKod.Size = new System.Drawing.Size(143, 20);
            this.txtKod.StatusBarAciklama = "Kod giriniz";
            this.txtKod.StyleController = this.myDataLayoutControl;
            this.txtKod.TabIndex = 3;
            // 
            // lblKod
            // 
            this.lblKod.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.lblKod.AppearanceItemCaption.Options.UseForeColor = true;
            this.lblKod.Control = this.txtKod;
            this.lblKod.Location = new System.Drawing.Point(0, 0);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(200, 24);
            this.lblKod.Text = "Kod";
            this.lblKod.TextSize = new System.Drawing.Size(41, 13);
            // 
            // txtIlceAdi
            // 
            this.txtIlceAdi.EnterMoveNextControl = true;
            this.txtIlceAdi.Location = new System.Drawing.Point(65, 36);
            this.txtIlceAdi.MenuManager = this.ribbonControl;
            this.txtIlceAdi.Name = "txtIlceAdi";
            this.txtIlceAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtIlceAdi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtIlceAdi.Properties.MaxLength = 50;
            this.txtIlceAdi.Size = new System.Drawing.Size(143, 20);
            this.txtIlceAdi.StatusBarAciklama = "İlçe Adı Giriniz";
            this.txtIlceAdi.StyleController = this.myDataLayoutControl;
            this.txtIlceAdi.TabIndex = 0;
            // 
            // lblIlceAdi
            // 
            this.lblIlceAdi.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.lblIlceAdi.AppearanceItemCaption.Options.UseForeColor = true;
            this.lblIlceAdi.Control = this.txtIlceAdi;
            this.lblIlceAdi.Location = new System.Drawing.Point(0, 24);
            this.lblIlceAdi.Name = "lblIlceAdi";
            this.lblIlceAdi.OptionsTableLayoutItem.RowIndex = 1;
            this.lblIlceAdi.Size = new System.Drawing.Size(200, 24);
            this.lblIlceAdi.Text = "İlçe Adı";
            this.lblIlceAdi.TextSize = new System.Drawing.Size(41, 13);
            // 
            // txtAciklama
            // 
            this.txtAciklama.EnterMoveNextControl = true;
            this.txtAciklama.Location = new System.Drawing.Point(65, 60);
            this.txtAciklama.MenuManager = this.ribbonControl;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtAciklama.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAciklama.Properties.MaxLength = 500;
            this.txtAciklama.Size = new System.Drawing.Size(311, 43);
            this.txtAciklama.StatusBarAciklama = "Açıklama Giriniz";
            this.txtAciklama.StyleController = this.myDataLayoutControl;
            this.txtAciklama.TabIndex = 1;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.lblAciklama.AppearanceItemCaption.Options.UseForeColor = true;
            this.lblAciklama.Control = this.txtAciklama;
            this.lblAciklama.Location = new System.Drawing.Point(0, 48);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.OptionsTableLayoutItem.ColumnSpan = 3;
            this.lblAciklama.OptionsTableLayoutItem.RowIndex = 2;
            this.lblAciklama.Size = new System.Drawing.Size(368, 47);
            this.lblAciklama.Text = "Açıklama";
            this.lblAciklama.TextSize = new System.Drawing.Size(41, 13);
            // 
            // tglDurum
            // 
            this.tglDurum.EnterMoveNextControl = true;
            this.tglDurum.Location = new System.Drawing.Point(281, 12);
            this.tglDurum.MenuManager = this.ribbonControl;
            this.tglDurum.Name = "tglDurum";
            this.tglDurum.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.tglDurum.Properties.Appearance.Options.UseForeColor = true;
            this.tglDurum.Properties.AutoHeight = false;
            this.tglDurum.Properties.AutoWidth = true;
            this.tglDurum.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tglDurum.Properties.OffText = "Pasif";
            this.tglDurum.Properties.OnText = "Aktif";
            this.tglDurum.Size = new System.Drawing.Size(77, 20);
            this.tglDurum.StatusBarAciklama = " Kartın kullanım durumunu seçiniz";
            this.tglDurum.StyleController = this.myDataLayoutControl;
            this.tglDurum.TabIndex = 2;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.tglDurum;
            this.layoutControlItem4.Location = new System.Drawing.Point(269, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem4.Size = new System.Drawing.Size(99, 24);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // IlceEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 274);
            this.Controls.Add(this.myDataLayoutControl);
            this.IconOptions.ShowIcon = false;
            this.MinimumSize = new System.Drawing.Size(390, 275);
            this.Name = "IlceEditForm";
            this.Text = "İlçe Kayıt Formu";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblKod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlceAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIlceAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAciklama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private UserControls.Controls.MyToogleSwitch tglDurum;
        private UserControls.Controls.MyMemoEdit txtAciklama;
        private UserControls.Controls.MyTextEdit txtIlceAdi;
        private UserControls.Controls.MyCodeTextEdit txtKod;
        private DevExpress.XtraLayout.LayoutControlItem lblKod;
        private DevExpress.XtraLayout.LayoutControlItem lblIlceAdi;
        private DevExpress.XtraLayout.LayoutControlItem lblAciklama;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}