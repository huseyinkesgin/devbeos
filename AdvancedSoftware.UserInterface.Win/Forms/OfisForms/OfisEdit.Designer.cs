﻿namespace AdvancedSoftware.UserInterface.Win.Forms.OfisForms
{
    partial class OfisEdit
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
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition7 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl1 = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.MyDataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtKod = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.MyCodeTextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtOfisAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.MyTextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtTelefon = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.MyTelefonNoTextEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtEposta = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.MyEmailTextEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtIl = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.MyButtonEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtIlce = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.MyButtonEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.myMemoEdit1 = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.MyMemoEdit();
            this.txtAdres = new DevExpress.XtraLayout.LayoutControlItem();
            this.tglDurum = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.MyToogleSwitch();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOfisAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEposta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myMemoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.OptionsPageCategories.ShowCaptions = false;
            this.ribbonControl.Size = new System.Drawing.Size(358, 135);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.tglDurum);
            this.myDataLayoutControl1.Controls.Add(this.myMemoEdit1);
            this.myDataLayoutControl1.Controls.Add(this.txtIlce);
            this.myDataLayoutControl1.Controls.Add(this.txtIl);
            this.myDataLayoutControl1.Controls.Add(this.txtEposta);
            this.myDataLayoutControl1.Controls.Add(this.txtTelefon);
            this.myDataLayoutControl1.Controls.Add(this.txtOfisAdi);
            this.myDataLayoutControl1.Controls.Add(this.txtKod);
            this.myDataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl1.Location = new System.Drawing.Point(0, 135);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(358, 220);
            this.myDataLayoutControl1.TabIndex = 2;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.txtAdres,
            this.layoutControlItem8});
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
            rowDefinition3.Height = 24D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition4.Height = 24D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition5.Height = 24D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition6.Height = 24D;
            rowDefinition6.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition7.Height = 100D;
            rowDefinition7.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5,
            rowDefinition6,
            rowDefinition7});
            this.Root.Size = new System.Drawing.Size(358, 220);
            this.Root.TextVisible = false;
            // 
            // txtKod
            // 
            this.txtKod.EnterMoveNextControl = true;
            this.txtKod.Location = new System.Drawing.Point(61, 12);
            this.txtKod.MenuManager = this.ribbonControl;
            this.txtKod.Name = "txtKod";
            this.txtKod.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtKod.Properties.Appearance.Options.UseBackColor = true;
            this.txtKod.Properties.Appearance.Options.UseTextOptions = true;
            this.txtKod.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtKod.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtKod.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKod.Properties.MaxLength = 20;
            this.txtKod.Size = new System.Drawing.Size(147, 20);
            this.txtKod.StatusBarAciklama = "Kod giriniz";
            this.txtKod.StyleController = this.myDataLayoutControl1;
            this.txtKod.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtKod;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem1.Text = "Kod";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(37, 13);
            // 
            // txtOfisAdi
            // 
            this.txtOfisAdi.EnterMoveNextControl = true;
            this.txtOfisAdi.Location = new System.Drawing.Point(61, 36);
            this.txtOfisAdi.MenuManager = this.ribbonControl;
            this.txtOfisAdi.Name = "txtOfisAdi";
            this.txtOfisAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtOfisAdi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtOfisAdi.Properties.MaxLength = 50;
            this.txtOfisAdi.Size = new System.Drawing.Size(285, 20);
            this.txtOfisAdi.StatusBarAciklama = null;
            this.txtOfisAdi.StyleController = this.myDataLayoutControl1;
            this.txtOfisAdi.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtOfisAdi;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(338, 24);
            this.layoutControlItem2.Text = "Ofis Adı";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(37, 13);
            // 
            // txtTelefon
            // 
            this.txtTelefon.EnterMoveNextControl = true;
            this.txtTelefon.Location = new System.Drawing.Point(61, 60);
            this.txtTelefon.MenuManager = this.ribbonControl;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTelefon.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTelefon.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtTelefon.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtTelefon.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegularMaskManager));
            this.txtTelefon.Properties.MaskSettings.Set("mask", "0 (\\d?\\d?\\d?) \\d?\\d?\\d? \\d?\\d? \\d?\\d?");
            this.txtTelefon.Properties.MaskSettings.Set("isAutoComplete", false);
            this.txtTelefon.Properties.MaskSettings.Set("isOptimistic", false);
            this.txtTelefon.Properties.MaxLength = 50;
            this.txtTelefon.Size = new System.Drawing.Size(147, 20);
            this.txtTelefon.StatusBarAciklama = "Telegon numarası giriniz";
            this.txtTelefon.StyleController = this.myDataLayoutControl1;
            this.txtTelefon.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtTelefon;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem3.Text = "Telefon";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(37, 13);
            // 
            // txtEposta
            // 
            this.txtEposta.EnterMoveNextControl = true;
            this.txtEposta.Location = new System.Drawing.Point(61, 84);
            this.txtEposta.MenuManager = this.ribbonControl;
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtEposta.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtEposta.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtEposta.Properties.MaskSettings.Set("allowBlankInput", true);
            this.txtEposta.Properties.MaskSettings.Set("mask", "((([0-9a-zA-Z_%-])+[.])+|([0-9a-zA-Z_%-])+)+@((([0-9a-zA-Z_-])+[.])+|([0-9a-zA-Z_" +
        "-])+)+");
            this.txtEposta.Properties.MaskSettings.Set("isAutoComplete", true);
            this.txtEposta.Properties.MaskSettings.Set("isOptimistic", false);
            this.txtEposta.Properties.MaxLength = 50;
            this.txtEposta.Size = new System.Drawing.Size(186, 20);
            this.txtEposta.StatusBarAciklama = "Eposta adresi giriniz";
            this.txtEposta.StyleController = this.myDataLayoutControl1;
            this.txtEposta.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.txtEposta;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(239, 24);
            this.layoutControlItem4.Text = "Eposta";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(37, 13);
            // 
            // txtIl
            // 
            this.txtIl.EnterMoveNextControl = true;
            this.txtIl.Id = null;
            this.txtIl.Location = new System.Drawing.Point(61, 108);
            this.txtIl.MenuManager = this.ribbonControl;
            this.txtIl.Name = "txtIl";
            this.txtIl.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtIl.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtIl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtIl.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtIl.Size = new System.Drawing.Size(147, 20);
            this.txtIl.StatusBarAciklama = null;
            this.txtIl.StatusBarKisaYol = "F4 :";
            this.txtIl.StatusBarKisaYolAciklama = null;
            this.txtIl.StyleController = this.myDataLayoutControl1;
            this.txtIl.TabIndex = 8;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.txtIl;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem5.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem5.Text = "İl";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(37, 13);
            // 
            // txtIlce
            // 
            this.txtIlce.EnterMoveNextControl = true;
            this.txtIlce.Id = null;
            this.txtIlce.Location = new System.Drawing.Point(61, 132);
            this.txtIlce.MenuManager = this.ribbonControl;
            this.txtIlce.Name = "txtIlce";
            this.txtIlce.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtIlce.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtIlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtIlce.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtIlce.Size = new System.Drawing.Size(147, 20);
            this.txtIlce.StatusBarAciklama = null;
            this.txtIlce.StatusBarKisaYol = "F4 :";
            this.txtIlce.StatusBarKisaYolAciklama = null;
            this.txtIlce.StyleController = this.myDataLayoutControl1;
            this.txtIlce.TabIndex = 9;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.txtIlce;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 5;
            this.layoutControlItem6.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem6.Text = "İlçe";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(37, 13);
            // 
            // myMemoEdit1
            // 
            this.myMemoEdit1.EnterMoveNextControl = true;
            this.myMemoEdit1.Location = new System.Drawing.Point(61, 156);
            this.myMemoEdit1.MenuManager = this.ribbonControl;
            this.myMemoEdit1.Name = "myMemoEdit1";
            this.myMemoEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.myMemoEdit1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.myMemoEdit1.Properties.MaxLength = 500;
            this.myMemoEdit1.Size = new System.Drawing.Size(285, 52);
            this.myMemoEdit1.StatusBarAciklama = "Açıklama Giriniz";
            this.myMemoEdit1.StyleController = this.myDataLayoutControl1;
            this.myMemoEdit1.TabIndex = 10;
            // 
            // txtAdres
            // 
            this.txtAdres.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.txtAdres.AppearanceItemCaption.Options.UseForeColor = true;
            this.txtAdres.Control = this.myMemoEdit1;
            this.txtAdres.Location = new System.Drawing.Point(0, 144);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.OptionsTableLayoutItem.ColumnSpan = 3;
            this.txtAdres.OptionsTableLayoutItem.RowIndex = 6;
            this.txtAdres.Size = new System.Drawing.Size(338, 56);
            this.txtAdres.Text = "Adres";
            this.txtAdres.TextSize = new System.Drawing.Size(37, 13);
            // 
            // tglDurum
            // 
            this.tglDurum.EnterMoveNextControl = true;
            this.tglDurum.Location = new System.Drawing.Point(251, 12);
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
            this.tglDurum.StyleController = this.myDataLayoutControl1;
            this.tglDurum.TabIndex = 11;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem8.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem8.Control = this.tglDurum;
            this.layoutControlItem8.Location = new System.Drawing.Point(239, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem8.Size = new System.Drawing.Size(99, 24);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // OfisEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 379);
            this.Controls.Add(this.myDataLayoutControl1);
            this.IconOptions.ShowIcon = false;
            this.MinimumSize = new System.Drawing.Size(360, 380);
            this.Name = "OfisEdit";
            this.Text = "Ofis Formu";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOfisAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEposta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myMemoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private UserControls.Controls.MyToogleSwitch tglDurum;
        private UserControls.Controls.MyMemoEdit myMemoEdit1;
        private UserControls.Controls.MyButtonEdit txtIlce;
        private UserControls.Controls.MyButtonEdit txtIl;
        private UserControls.Controls.MyEmailTextEdit txtEposta;
        private UserControls.Controls.MyTelefonNoTextEdit txtTelefon;
        private UserControls.Controls.MyTextEdit txtOfisAdi;
        private UserControls.Controls.MyCodeTextEdit txtKod;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem txtAdres;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}