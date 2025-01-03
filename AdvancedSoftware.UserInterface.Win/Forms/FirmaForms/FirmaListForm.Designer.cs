namespace AdvancedSoftware.UserInterface.Win.Forms.FirmaForms
{
    partial class FirmaListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirmaListForm));
            this.longNavigator = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Navigators.longNavigator();
            this.grid = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridControl();
            this.tablo = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridView();
            this.colId = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colKod = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colFirmaAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colFaturaAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colVergiDairesi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colVergiNo = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colMersisNo = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colKepAdresi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colIlAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colIlceAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colAdres = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colEposta = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colTelefon = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colWebsitesi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colYoutube = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colTiktok = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colVk = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colInstagram = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colFacebook = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colTwitter = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colLinkedin = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colMahalleAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
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
            this.ribbonControl.Size = new System.Drawing.Size(911, 135);
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
            this.longNavigator.Location = new System.Drawing.Point(0, 471);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(911, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 135);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(911, 336);
            this.grid.TabIndex = 3;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
            this.tablo.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.HeaderPanel.Options.UseFont = true;
            this.tablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKod,
            this.colFirmaAdi,
            this.colFaturaAdi,
            this.colVergiDairesi,
            this.colVergiNo,
            this.colMersisNo,
            this.colKepAdresi,
            this.colIlAdi,
            this.colIlceAdi,
            this.colMahalleAdi,
            this.colAdres,
            this.colEposta,
            this.colTelefon,
            this.colWebsitesi,
            this.colYoutube,
            this.colTiktok,
            this.colVk,
            this.colInstagram,
            this.colFacebook,
            this.colTwitter,
            this.colLinkedin});
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
            this.tablo.ViewCaption = "FİRMA LİSTESİ";
            // 
            // colId
            // 
            this.colId.Caption = "ID";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.StatusBarAciklama = null;
            this.colId.StatusBarKisaYol = null;
            this.colId.StatusBarKisaYolAciklama = null;
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.StatusBarAciklama = null;
            this.colKod.StatusBarKisaYol = null;
            this.colKod.StatusBarKisaYolAciklama = null;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 0;
            // 
            // colFirmaAdi
            // 
            this.colFirmaAdi.Caption = "Firma Adı";
            this.colFirmaAdi.FieldName = "FirmaAdi";
            this.colFirmaAdi.Name = "colFirmaAdi";
            this.colFirmaAdi.OptionsColumn.AllowEdit = false;
            this.colFirmaAdi.StatusBarAciklama = null;
            this.colFirmaAdi.StatusBarKisaYol = null;
            this.colFirmaAdi.StatusBarKisaYolAciklama = null;
            this.colFirmaAdi.Visible = true;
            this.colFirmaAdi.VisibleIndex = 1;
            // 
            // colFaturaAdi
            // 
            this.colFaturaAdi.Caption = "Fatura Adı";
            this.colFaturaAdi.FieldName = "FaturaAdi";
            this.colFaturaAdi.Name = "colFaturaAdi";
            this.colFaturaAdi.OptionsColumn.AllowEdit = false;
            this.colFaturaAdi.StatusBarAciklama = null;
            this.colFaturaAdi.StatusBarKisaYol = null;
            this.colFaturaAdi.StatusBarKisaYolAciklama = null;
            this.colFaturaAdi.Visible = true;
            this.colFaturaAdi.VisibleIndex = 2;
            // 
            // colVergiDairesi
            // 
            this.colVergiDairesi.Caption = "Vergi Dairesi";
            this.colVergiDairesi.FieldName = "VergiDairesi";
            this.colVergiDairesi.Name = "colVergiDairesi";
            this.colVergiDairesi.OptionsColumn.AllowEdit = false;
            this.colVergiDairesi.StatusBarAciklama = null;
            this.colVergiDairesi.StatusBarKisaYol = null;
            this.colVergiDairesi.StatusBarKisaYolAciklama = null;
            this.colVergiDairesi.Visible = true;
            this.colVergiDairesi.VisibleIndex = 3;
            // 
            // colVergiNo
            // 
            this.colVergiNo.Caption = "Vergi No";
            this.colVergiNo.FieldName = "VergiNo";
            this.colVergiNo.Name = "colVergiNo";
            this.colVergiNo.OptionsColumn.AllowEdit = false;
            this.colVergiNo.StatusBarAciklama = null;
            this.colVergiNo.StatusBarKisaYol = null;
            this.colVergiNo.StatusBarKisaYolAciklama = null;
            this.colVergiNo.Visible = true;
            this.colVergiNo.VisibleIndex = 4;
            // 
            // colMersisNo
            // 
            this.colMersisNo.Caption = "Mersis No";
            this.colMersisNo.FieldName = "MersisNo";
            this.colMersisNo.Name = "colMersisNo";
            this.colMersisNo.OptionsColumn.AllowEdit = false;
            this.colMersisNo.StatusBarAciklama = null;
            this.colMersisNo.StatusBarKisaYol = null;
            this.colMersisNo.StatusBarKisaYolAciklama = null;
            this.colMersisNo.Visible = true;
            this.colMersisNo.VisibleIndex = 5;
            // 
            // colKepAdresi
            // 
            this.colKepAdresi.Caption = "Kep Adresi";
            this.colKepAdresi.FieldName = "KepAdresi";
            this.colKepAdresi.Name = "colKepAdresi";
            this.colKepAdresi.OptionsColumn.AllowEdit = false;
            this.colKepAdresi.StatusBarAciklama = null;
            this.colKepAdresi.StatusBarKisaYol = null;
            this.colKepAdresi.StatusBarKisaYolAciklama = null;
            this.colKepAdresi.Visible = true;
            this.colKepAdresi.VisibleIndex = 6;
            // 
            // colIlAdi
            // 
            this.colIlAdi.Caption = "İl";
            this.colIlAdi.FieldName = "IlAdi";
            this.colIlAdi.Name = "colIlAdi";
            this.colIlAdi.OptionsColumn.AllowEdit = false;
            this.colIlAdi.StatusBarAciklama = null;
            this.colIlAdi.StatusBarKisaYol = null;
            this.colIlAdi.StatusBarKisaYolAciklama = null;
            this.colIlAdi.Visible = true;
            this.colIlAdi.VisibleIndex = 7;
            // 
            // colIlceAdi
            // 
            this.colIlceAdi.Caption = "İlçe";
            this.colIlceAdi.FieldName = "IlceAdi";
            this.colIlceAdi.Name = "colIlceAdi";
            this.colIlceAdi.OptionsColumn.AllowEdit = false;
            this.colIlceAdi.StatusBarAciklama = null;
            this.colIlceAdi.StatusBarKisaYol = null;
            this.colIlceAdi.StatusBarKisaYolAciklama = null;
            this.colIlceAdi.Visible = true;
            this.colIlceAdi.VisibleIndex = 8;
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
            this.colAdres.VisibleIndex = 9;
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
            this.colEposta.VisibleIndex = 10;
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
            this.colTelefon.VisibleIndex = 11;
            // 
            // colWebsitesi
            // 
            this.colWebsitesi.Caption = "Websitesi";
            this.colWebsitesi.FieldNameSortGroup = "Websitesi";
            this.colWebsitesi.Name = "colWebsitesi";
            this.colWebsitesi.OptionsColumn.AllowEdit = false;
            this.colWebsitesi.StatusBarAciklama = null;
            this.colWebsitesi.StatusBarKisaYol = null;
            this.colWebsitesi.StatusBarKisaYolAciklama = null;
            this.colWebsitesi.Visible = true;
            this.colWebsitesi.VisibleIndex = 12;
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
            this.colYoutube.VisibleIndex = 13;
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
            this.colTiktok.VisibleIndex = 14;
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
            this.colVk.VisibleIndex = 15;
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
            this.colInstagram.VisibleIndex = 16;
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
            this.colFacebook.VisibleIndex = 17;
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
            this.colTwitter.VisibleIndex = 18;
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
            this.colLinkedin.VisibleIndex = 19;
            // 
            // colMahalleAdi
            // 
            this.colMahalleAdi.Caption = "Mahalle";
            this.colMahalleAdi.FieldName = "MahalleAdi";
            this.colMahalleAdi.Name = "colMahalleAdi";
            this.colMahalleAdi.OptionsColumn.AllowEdit = false;
            this.colMahalleAdi.StatusBarAciklama = null;
            this.colMahalleAdi.StatusBarKisaYol = null;
            this.colMahalleAdi.StatusBarKisaYolAciklama = null;
            this.colMahalleAdi.Visible = true;
            this.colMahalleAdi.VisibleIndex = 20;
            // 
            // FirmaListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 519);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "FirmaListForm";
            this.Text = "FİRMA KARTLARI";
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
        private UserControls.Controls.Grid.MyGridControl grid;
        private UserControls.Controls.Grid.MyGridView tablo;
        private UserControls.Controls.Grid.MyGridColumn colId;
        private UserControls.Controls.Grid.MyGridColumn colKod;
        private UserControls.Controls.Grid.MyGridColumn colFirmaAdi;
        private UserControls.Controls.Grid.MyGridColumn colFaturaAdi;
        private UserControls.Controls.Grid.MyGridColumn colVergiDairesi;
        private UserControls.Controls.Grid.MyGridColumn colVergiNo;
        private UserControls.Controls.Grid.MyGridColumn colMersisNo;
        private UserControls.Controls.Grid.MyGridColumn colKepAdresi;
        private UserControls.Controls.Grid.MyGridColumn colIlAdi;
        private UserControls.Controls.Grid.MyGridColumn colIlceAdi;
        private UserControls.Controls.Grid.MyGridColumn colAdres;
        private UserControls.Controls.Grid.MyGridColumn colEposta;
        private UserControls.Controls.Grid.MyGridColumn colTelefon;
        private UserControls.Controls.Grid.MyGridColumn colWebsitesi;
        private UserControls.Controls.Grid.MyGridColumn colYoutube;
        private UserControls.Controls.Grid.MyGridColumn colTiktok;
        private UserControls.Controls.Grid.MyGridColumn colVk;
        private UserControls.Controls.Grid.MyGridColumn colInstagram;
        private UserControls.Controls.Grid.MyGridColumn colFacebook;
        private UserControls.Controls.Grid.MyGridColumn colTwitter;
        private UserControls.Controls.Grid.MyGridColumn colLinkedin;
        private UserControls.Controls.Grid.MyGridColumn colMahalleAdi;
    }
}