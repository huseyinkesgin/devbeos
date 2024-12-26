namespace AdvancedSoftware.UserInterface.Win.Forms.MusteriForms
{
    partial class MusteriListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriListForm));
            this.longNavigator = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Navigators.longNavigator();
            this.grid = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridControl();
            this.tablo = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridView();
            this.colKod = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMusteriTuru = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colAd = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colSoyad = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colTelefon = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colEposta = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colFirmaAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colWebsitesi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colIlAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colIlceAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colAdres = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colInstagram = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colFacebook = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colTwitter = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colLinkedin = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colVk = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colYoutube = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colTiktok = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colAciklama = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMusteriGrupAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.AccessibleName = "Search Item";
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.Size = new System.Drawing.Size(1106, 135);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 501);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1106, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 135);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1106, 366);
            this.grid.TabIndex = 3;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
            this.tablo.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.BandPanel.ForeColor = System.Drawing.Color.DarkBlue;
            this.tablo.Appearance.BandPanel.Options.UseFont = true;
            this.tablo.Appearance.BandPanel.Options.UseForeColor = true;
            this.tablo.Appearance.BandPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.FooterPanel.Options.UseFont = true;
            this.tablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.tablo.BandPanelRowHeight = 40;
            this.tablo.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4,
            this.gridBand5});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colKod,
            this.colMusteriTuru,
            this.colMusteriGrupAdi,
            this.colAd,
            this.colSoyad,
            this.colEposta,
            this.colTelefon,
            this.colIlAdi,
            this.colIlceAdi,
            this.colAdres,
            this.colFirmaAdi,
            this.colWebsitesi,
            this.colFacebook,
            this.colTwitter,
            this.colInstagram,
            this.colLinkedin,
            this.colYoutube,
            this.colTiktok,
            this.colVk,
            this.colAciklama});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintFooter = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.ColumnAutoWidth = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowAutoFilterRow = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisaYol = null;
            this.tablo.StatusBarKisaYolAciklama = null;
            this.tablo.ViewCaption = "MÜSTERİ LİSTESİ";
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.Visible = true;
            // 
            // colMusteriTuru
            // 
            this.colMusteriTuru.Caption = "Müşteri Türü";
            this.colMusteriTuru.FieldName = "MusteriTuru";
            this.colMusteriTuru.Name = "colMusteriTuru";
            this.colMusteriTuru.OptionsColumn.AllowEdit = false;
            this.colMusteriTuru.StatusBarAciklama = null;
            this.colMusteriTuru.StatusBarKisaYol = null;
            this.colMusteriTuru.StatusBarKisaYolAciklama = null;
            this.colMusteriTuru.Visible = true;
            // 
            // colAd
            // 
            this.colAd.Caption = "Adı";
            this.colAd.FieldName = "Ad";
            this.colAd.Name = "colAd";
            this.colAd.OptionsColumn.AllowEdit = false;
            this.colAd.StatusBarAciklama = null;
            this.colAd.StatusBarKisaYol = null;
            this.colAd.StatusBarKisaYolAciklama = null;
            this.colAd.Visible = true;
            this.colAd.Width = 130;
            // 
            // colSoyad
            // 
            this.colSoyad.Caption = "Soyadi";
            this.colSoyad.FieldName = "Soyad";
            this.colSoyad.Name = "colSoyad";
            this.colSoyad.OptionsColumn.AllowEdit = false;
            this.colSoyad.StatusBarAciklama = null;
            this.colSoyad.StatusBarKisaYol = null;
            this.colSoyad.StatusBarKisaYolAciklama = null;
            this.colSoyad.Visible = true;
            this.colSoyad.Width = 120;
            // 
            // colTelefon
            // 
            this.colTelefon.Caption = "Telefon";
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.OptionsColumn.AllowEdit = false;
            this.colTelefon.StatusBarAciklama = null;
            this.colTelefon.StatusBarKisaYol = null;
            this.colTelefon.StatusBarKisaYolAciklama = null;
            this.colTelefon.Visible = true;
            // 
            // colEposta
            // 
            this.colEposta.Caption = "Eposta";
            this.colEposta.FieldName = "Eposta";
            this.colEposta.Name = "colEposta";
            this.colEposta.OptionsColumn.AllowEdit = false;
            this.colEposta.StatusBarAciklama = null;
            this.colEposta.StatusBarKisaYol = null;
            this.colEposta.StatusBarKisaYolAciklama = null;
            this.colEposta.Visible = true;
            this.colEposta.Width = 200;
            // 
            // colFirmaAdi
            // 
            this.colFirmaAdi.Caption = "Firması";
            this.colFirmaAdi.FieldName = "FirmaAdi";
            this.colFirmaAdi.Name = "colFirmaAdi";
            this.colFirmaAdi.OptionsColumn.AllowEdit = false;
            this.colFirmaAdi.StatusBarAciklama = null;
            this.colFirmaAdi.StatusBarKisaYol = null;
            this.colFirmaAdi.StatusBarKisaYolAciklama = null;
            this.colFirmaAdi.Visible = true;
            this.colFirmaAdi.Width = 200;
            // 
            // colWebsitesi
            // 
            this.colWebsitesi.Caption = "Websitesi";
            this.colWebsitesi.FieldName = "Websitesi";
            this.colWebsitesi.Name = "colWebsitesi";
            this.colWebsitesi.OptionsColumn.AllowEdit = false;
            this.colWebsitesi.StatusBarAciklama = null;
            this.colWebsitesi.StatusBarKisaYol = null;
            this.colWebsitesi.StatusBarKisaYolAciklama = null;
            this.colWebsitesi.Visible = true;
            this.colWebsitesi.Width = 120;
            // 
            // colIlAdi
            // 
            this.colIlAdi.Caption = "İli";
            this.colIlAdi.FieldName = "IlAdi";
            this.colIlAdi.Name = "colIlAdi";
            this.colIlAdi.OptionsColumn.AllowEdit = false;
            this.colIlAdi.StatusBarAciklama = null;
            this.colIlAdi.StatusBarKisaYol = null;
            this.colIlAdi.StatusBarKisaYolAciklama = null;
            this.colIlAdi.Visible = true;
            // 
            // colIlceAdi
            // 
            this.colIlceAdi.Caption = "İlçesi";
            this.colIlceAdi.FieldName = "IlceAdi";
            this.colIlceAdi.Name = "colIlceAdi";
            this.colIlceAdi.OptionsColumn.AllowEdit = false;
            this.colIlceAdi.StatusBarAciklama = null;
            this.colIlceAdi.StatusBarKisaYol = null;
            this.colIlceAdi.StatusBarKisaYolAciklama = null;
            this.colIlceAdi.Visible = true;
            // 
            // colAdres
            // 
            this.colAdres.Caption = "Adres";
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.OptionsColumn.AllowEdit = false;
            this.colAdres.StatusBarAciklama = null;
            this.colAdres.StatusBarKisaYol = null;
            this.colAdres.StatusBarKisaYolAciklama = null;
            this.colAdres.Visible = true;
            // 
            // colInstagram
            // 
            this.colInstagram.Caption = "Instagram";
            this.colInstagram.FieldName = "Instagram";
            this.colInstagram.Name = "colInstagram";
            this.colInstagram.OptionsColumn.AllowEdit = false;
            this.colInstagram.StatusBarAciklama = null;
            this.colInstagram.StatusBarKisaYol = null;
            this.colInstagram.StatusBarKisaYolAciklama = null;
            this.colInstagram.Visible = true;
            // 
            // colFacebook
            // 
            this.colFacebook.Caption = "Facebook";
            this.colFacebook.FieldName = "Facebook";
            this.colFacebook.Name = "colFacebook";
            this.colFacebook.OptionsColumn.AllowEdit = false;
            this.colFacebook.StatusBarAciklama = null;
            this.colFacebook.StatusBarKisaYol = null;
            this.colFacebook.StatusBarKisaYolAciklama = null;
            this.colFacebook.Visible = true;
            // 
            // colTwitter
            // 
            this.colTwitter.Caption = "Twitter";
            this.colTwitter.FieldName = "Twitter";
            this.colTwitter.Name = "colTwitter";
            this.colTwitter.OptionsColumn.AllowEdit = false;
            this.colTwitter.StatusBarAciklama = null;
            this.colTwitter.StatusBarKisaYol = null;
            this.colTwitter.StatusBarKisaYolAciklama = null;
            this.colTwitter.Visible = true;
            // 
            // colLinkedin
            // 
            this.colLinkedin.Caption = "Linkedin";
            this.colLinkedin.FieldName = "Linkedin";
            this.colLinkedin.Name = "colLinkedin";
            this.colLinkedin.OptionsColumn.AllowEdit = false;
            this.colLinkedin.StatusBarAciklama = null;
            this.colLinkedin.StatusBarKisaYol = null;
            this.colLinkedin.StatusBarKisaYolAciklama = null;
            this.colLinkedin.Visible = true;
            // 
            // colVk
            // 
            this.colVk.Caption = "VK";
            this.colVk.FieldName = "VK";
            this.colVk.Name = "colVk";
            this.colVk.OptionsColumn.AllowEdit = false;
            this.colVk.StatusBarAciklama = null;
            this.colVk.StatusBarKisaYol = null;
            this.colVk.StatusBarKisaYolAciklama = null;
            this.colVk.Visible = true;
            // 
            // colYoutube
            // 
            this.colYoutube.Caption = "Youtube";
            this.colYoutube.FieldName = "Youtube";
            this.colYoutube.Name = "colYoutube";
            this.colYoutube.OptionsColumn.AllowEdit = false;
            this.colYoutube.StatusBarAciklama = null;
            this.colYoutube.StatusBarKisaYol = null;
            this.colYoutube.StatusBarKisaYolAciklama = null;
            this.colYoutube.Visible = true;
            // 
            // colTiktok
            // 
            this.colTiktok.Caption = "Tiktok";
            this.colTiktok.FieldName = "Tiktok";
            this.colTiktok.Name = "colTiktok";
            this.colTiktok.OptionsColumn.AllowEdit = false;
            this.colTiktok.StatusBarAciklama = null;
            this.colTiktok.StatusBarKisaYol = null;
            this.colTiktok.StatusBarKisaYolAciklama = null;
            this.colTiktok.Visible = true;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.StatusBarAciklama = null;
            this.colAciklama.StatusBarKisaYol = null;
            this.colAciklama.StatusBarKisaYolAciklama = null;
            this.colAciklama.Visible = true;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colMusteriGrupAdi
            // 
            this.colMusteriGrupAdi.Caption = "Müşteri Grubu";
            this.colMusteriGrupAdi.FieldName = "MusteriGrupAdi";
            this.colMusteriGrupAdi.Name = "colMusteriGrupAdi";
            this.colMusteriGrupAdi.OptionsColumn.AllowEdit = false;
            this.colMusteriGrupAdi.StatusBarAciklama = null;
            this.colMusteriGrupAdi.StatusBarKisaYol = null;
            this.colMusteriGrupAdi.StatusBarKisaYolAciklama = null;
            this.colMusteriGrupAdi.Visible = true;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Müsteri Bilgileri";
            this.gridBand1.Columns.Add(this.colKod);
            this.gridBand1.Columns.Add(this.colMusteriTuru);
            this.gridBand1.Columns.Add(this.colMusteriGrupAdi);
            this.gridBand1.Columns.Add(this.colAd);
            this.gridBand1.Columns.Add(this.colSoyad);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 475;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "İletişim Bilgileri";
            this.gridBand2.Columns.Add(this.colTelefon);
            this.gridBand2.Columns.Add(this.colEposta);
            this.gridBand2.Columns.Add(this.colFirmaAdi);
            this.gridBand2.Columns.Add(this.colWebsitesi);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 595;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Lokasyon";
            this.gridBand3.Columns.Add(this.colIlAdi);
            this.gridBand3.Columns.Add(this.colIlceAdi);
            this.gridBand3.Columns.Add(this.colAdres);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 225;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Sosyal Medya";
            this.gridBand4.Columns.Add(this.colInstagram);
            this.gridBand4.Columns.Add(this.colFacebook);
            this.gridBand4.Columns.Add(this.colTwitter);
            this.gridBand4.Columns.Add(this.colLinkedin);
            this.gridBand4.Columns.Add(this.colVk);
            this.gridBand4.Columns.Add(this.colYoutube);
            this.gridBand4.Columns.Add(this.colTiktok);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 525;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "Diğer Bilgiler";
            this.gridBand5.Columns.Add(this.colAciklama);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 4;
            this.gridBand5.Width = 75;
            // 
            // MusteriListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 549);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "MusteriListForm";
            this.Text = "MÜŞTERİ KARTLARI";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.Navigators.longNavigator longNavigator;
        private UserControls.Controls.Grid.MyBandedGridControl grid;
        private UserControls.Controls.Grid.MyBandedGridView tablo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKod;
        private UserControls.Controls.Grid.MyBandedGridColumn colAd;
        private UserControls.Controls.Grid.MyBandedGridColumn colSoyad;
        private UserControls.Controls.Grid.MyBandedGridColumn colEposta;
        private UserControls.Controls.Grid.MyBandedGridColumn colTelefon;
        private UserControls.Controls.Grid.MyBandedGridColumn colIlAdi;
        private UserControls.Controls.Grid.MyBandedGridColumn colIlceAdi;
        private UserControls.Controls.Grid.MyBandedGridColumn colAdres;
        private UserControls.Controls.Grid.MyBandedGridColumn colFirmaAdi;
        private UserControls.Controls.Grid.MyBandedGridColumn colWebsitesi;
        private UserControls.Controls.Grid.MyBandedGridColumn colFacebook;
        private UserControls.Controls.Grid.MyBandedGridColumn colTwitter;
        private UserControls.Controls.Grid.MyBandedGridColumn colInstagram;
        private UserControls.Controls.Grid.MyBandedGridColumn colLinkedin;
        private UserControls.Controls.Grid.MyBandedGridColumn colYoutube;
        private UserControls.Controls.Grid.MyBandedGridColumn colTiktok;
        private UserControls.Controls.Grid.MyBandedGridColumn colVk;
        private UserControls.Controls.Grid.MyBandedGridColumn colAciklama;
        private UserControls.Controls.Grid.MyBandedGridColumn colMusteriTuru;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private UserControls.Controls.Grid.MyBandedGridColumn colMusteriGrupAdi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
    }
}