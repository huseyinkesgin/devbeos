﻿namespace AdvancedSoftware.UserInterface.Win.Forms.BankaSubeForms
{
    partial class BankaSubeEditForm
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
            this.myDataLayoutControl = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.MyDataLayoutControl();
            this.txtAciklama = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.MyMemoEdit();
            this.txtOzelKod2 = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.MyButtonEdit();
            this.txtOzelKod1 = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.MyButtonEdit();
            this.txtSubeAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.MyTextEdit();
            this.txtKod = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.MyCodeTextEdit();
            this.tglDurum = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.MyToogleSwitch();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOzelKod2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOzelKod1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubeAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.OptionsPageCategories.ShowCaptions = false;
            this.ribbonControl.Size = new System.Drawing.Size(448, 135);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.txtAciklama);
            this.myDataLayoutControl.Controls.Add(this.txtOzelKod2);
            this.myDataLayoutControl.Controls.Add(this.txtOzelKod1);
            this.myDataLayoutControl.Controls.Add(this.txtSubeAdi);
            this.myDataLayoutControl.Controls.Add(this.txtKod);
            this.myDataLayoutControl.Controls.Add(this.tglDurum);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 135);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.Root;
            this.myDataLayoutControl.Size = new System.Drawing.Size(448, 170);
            this.myDataLayoutControl.TabIndex = 2;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // txtAciklama
            // 
            this.txtAciklama.EnterMoveNextControl = true;
            this.txtAciklama.Location = new System.Drawing.Point(98, 108);
            this.txtAciklama.MenuManager = this.ribbonControl;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtAciklama.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAciklama.Properties.MaxLength = 500;
            this.txtAciklama.Size = new System.Drawing.Size(338, 50);
            this.txtAciklama.StatusBarAciklama = "Açıklama Giriniz";
            this.txtAciklama.StyleController = this.myDataLayoutControl;
            this.txtAciklama.TabIndex = 10;
            // 
            // txtOzelKod2
            // 
            this.txtOzelKod2.EnterMoveNextControl = true;
            this.txtOzelKod2.Id = null;
            this.txtOzelKod2.Location = new System.Drawing.Point(98, 84);
            this.txtOzelKod2.MenuManager = this.ribbonControl;
            this.txtOzelKod2.Name = "txtOzelKod2";
            this.txtOzelKod2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtOzelKod2.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtOzelKod2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtOzelKod2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtOzelKod2.Size = new System.Drawing.Size(110, 20);
            this.txtOzelKod2.StatusBarAciklama = null;
            this.txtOzelKod2.StatusBarKisaYol = "F4 :";
            this.txtOzelKod2.StatusBarKisaYolAciklama = null;
            this.txtOzelKod2.StyleController = this.myDataLayoutControl;
            this.txtOzelKod2.TabIndex = 9;
            // 
            // txtOzelKod1
            // 
            this.txtOzelKod1.EnterMoveNextControl = true;
            this.txtOzelKod1.Id = null;
            this.txtOzelKod1.Location = new System.Drawing.Point(98, 60);
            this.txtOzelKod1.MenuManager = this.ribbonControl;
            this.txtOzelKod1.Name = "txtOzelKod1";
            this.txtOzelKod1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtOzelKod1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtOzelKod1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtOzelKod1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtOzelKod1.Size = new System.Drawing.Size(110, 20);
            this.txtOzelKod1.StatusBarAciklama = null;
            this.txtOzelKod1.StatusBarKisaYol = "F4 :";
            this.txtOzelKod1.StatusBarKisaYolAciklama = null;
            this.txtOzelKod1.StyleController = this.myDataLayoutControl;
            this.txtOzelKod1.TabIndex = 8;
            // 
            // txtSubeAdi
            // 
            this.txtSubeAdi.EnterMoveNextControl = true;
            this.txtSubeAdi.Location = new System.Drawing.Point(98, 36);
            this.txtSubeAdi.MenuManager = this.ribbonControl;
            this.txtSubeAdi.Name = "txtSubeAdi";
            this.txtSubeAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtSubeAdi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSubeAdi.Properties.MaxLength = 50;
            this.txtSubeAdi.Size = new System.Drawing.Size(338, 20);
            this.txtSubeAdi.StatusBarAciklama = null;
            this.txtSubeAdi.StyleController = this.myDataLayoutControl;
            this.txtSubeAdi.TabIndex = 6;
            // 
            // txtKod
            // 
            this.txtKod.EnterMoveNextControl = true;
            this.txtKod.Location = new System.Drawing.Point(98, 12);
            this.txtKod.MenuManager = this.ribbonControl;
            this.txtKod.Name = "txtKod";
            this.txtKod.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtKod.Properties.Appearance.Options.UseBackColor = true;
            this.txtKod.Properties.Appearance.Options.UseTextOptions = true;
            this.txtKod.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtKod.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtKod.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKod.Properties.MaxLength = 20;
            this.txtKod.Size = new System.Drawing.Size(110, 20);
            this.txtKod.StatusBarAciklama = "Kod giriniz";
            this.txtKod.StyleController = this.myDataLayoutControl;
            this.txtKod.TabIndex = 5;
            // 
            // tglDurum
            // 
            this.tglDurum.EnterMoveNextControl = true;
            this.tglDurum.Location = new System.Drawing.Point(341, 12);
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
            this.tglDurum.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
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
            rowDefinition5.Height = 100D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5});
            this.Root.Size = new System.Drawing.Size(448, 170);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.tglDurum;
            this.layoutControlItem1.Location = new System.Drawing.Point(329, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem1.Size = new System.Drawing.Size(99, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtKod;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem2.Text = "Kod";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtSubeAdi;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem3.Size = new System.Drawing.Size(428, 24);
            this.layoutControlItem3.Text = "Banka Şube Adı";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.txtOzelKod1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem5.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem5.Text = "Özel Kod-1";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.txtOzelKod2;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem6.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem6.Text = "Özel Kod-2";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem7.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem7.Control = this.txtAciklama;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem7.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem7.Size = new System.Drawing.Size(428, 54);
            this.layoutControlItem7.Text = "Aciklama";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(74, 13);
            // 
            // BankaSubeEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 329);
            this.Controls.Add(this.myDataLayoutControl);
            this.IconOptions.ShowIcon = false;
            this.MinimumSize = new System.Drawing.Size(450, 330);
            this.Name = "BankaSubeEditForm";
            this.Text = "BANKA ŞUBE KARTI";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOzelKod2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOzelKod1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubeAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private UserControls.Controls.MyMemoEdit txtAciklama;
        private UserControls.Controls.MyButtonEdit txtOzelKod2;
        private UserControls.Controls.MyButtonEdit txtOzelKod1;
        private UserControls.Controls.MyTextEdit txtSubeAdi;
        private UserControls.Controls.MyCodeTextEdit txtKod;
        private UserControls.Controls.MyToogleSwitch tglDurum;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}