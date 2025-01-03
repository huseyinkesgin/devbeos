namespace AdvancedSoftware.UserInterface.Win.Forms.YakitHarcamaForms
{
    partial class YakitHarcamaListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YakitHarcamaListForm));
            this.longNavigator = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Navigators.longNavigator();
            this.grid = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridControl();
            this.tablo = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colKod = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTarih = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colAracPlakaNo = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colLitre = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colTutar = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colPersonelAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colOdemeMetoduAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colKasa = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colYakitCinsi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colBelgeNo = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colAciklama = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
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
            this.gridBand3});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colKod,
            this.colAracPlakaNo,
            this.colPersonelAdi,
            this.colOdemeMetoduAdi,
            this.colKasa,
            this.colTarih,
            this.colTutar,
            this.colLitre,
            this.colYakitCinsi,
            this.colBelgeNo,
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
            this.tablo.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowAutoFilterRow = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisaYol = null;
            this.tablo.StatusBarKisaYolAciklama = null;
            this.tablo.ViewCaption = "ARAÇ YAKIT HARCAMALARI";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "ALINAN YAKIT";
            this.gridBand1.Columns.Add(this.colKod);
            this.gridBand1.Columns.Add(this.colTarih);
            this.gridBand1.Columns.Add(this.colAracPlakaNo);
            this.gridBand1.Columns.Add(this.colLitre);
            this.gridBand1.Columns.Add(this.colTutar);
            this.gridBand1.Columns.Add(this.colPersonelAdi);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 540;
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Tarih";
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.StatusBarAciklama = null;
            this.colTarih.StatusBarKisaYol = null;
            this.colTarih.StatusBarKisaYolAciklama = null;
            this.colTarih.Visible = true;
            this.colTarih.Width = 100;
            // 
            // colAracPlakaNo
            // 
            this.colAracPlakaNo.Caption = "Plaka";
            this.colAracPlakaNo.FieldName = "AracPlakaNo";
            this.colAracPlakaNo.Name = "colAracPlakaNo";
            this.colAracPlakaNo.OptionsColumn.AllowEdit = false;
            this.colAracPlakaNo.StatusBarAciklama = null;
            this.colAracPlakaNo.StatusBarKisaYol = null;
            this.colAracPlakaNo.StatusBarKisaYolAciklama = null;
            this.colAracPlakaNo.Visible = true;
            this.colAracPlakaNo.Width = 100;
            // 
            // colLitre
            // 
            this.colLitre.Caption = "Litre";
            this.colLitre.DisplayFormat.FormatString = "n2";
            this.colLitre.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLitre.FieldName = "Litre";
            this.colLitre.Name = "colLitre";
            this.colLitre.OptionsColumn.AllowEdit = false;
            this.colLitre.StatusBarAciklama = null;
            this.colLitre.StatusBarKisaYol = null;
            this.colLitre.StatusBarKisaYolAciklama = null;
            this.colLitre.Visible = true;
            this.colLitre.Width = 100;
            // 
            // colTutar
            // 
            this.colTutar.Caption = "Tutar ";
            this.colTutar.DisplayFormat.FormatString = "c2";
            this.colTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTutar.FieldName = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsColumn.AllowEdit = false;
            this.colTutar.StatusBarAciklama = null;
            this.colTutar.StatusBarKisaYol = null;
            this.colTutar.StatusBarKisaYolAciklama = null;
            this.colTutar.Visible = true;
            this.colTutar.Width = 120;
            // 
            // colPersonelAdi
            // 
            this.colPersonelAdi.Caption = "Personel";
            this.colPersonelAdi.FieldName = "PersonelAdi";
            this.colPersonelAdi.Name = "colPersonelAdi";
            this.colPersonelAdi.OptionsColumn.AllowEdit = false;
            this.colPersonelAdi.StatusBarAciklama = null;
            this.colPersonelAdi.StatusBarKisaYol = null;
            this.colPersonelAdi.StatusBarKisaYolAciklama = null;
            this.colPersonelAdi.Visible = true;
            this.colPersonelAdi.Width = 120;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "DİĞER BİLGİLER";
            this.gridBand2.Columns.Add(this.colOdemeMetoduAdi);
            this.gridBand2.Columns.Add(this.colKasa);
            this.gridBand2.Columns.Add(this.colYakitCinsi);
            this.gridBand2.Columns.Add(this.colBelgeNo);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 520;
            // 
            // colOdemeMetoduAdi
            // 
            this.colOdemeMetoduAdi.Caption = "Ödeme Türü";
            this.colOdemeMetoduAdi.FieldName = "OdemeMetoduAdi";
            this.colOdemeMetoduAdi.Name = "colOdemeMetoduAdi";
            this.colOdemeMetoduAdi.OptionsColumn.AllowEdit = false;
            this.colOdemeMetoduAdi.StatusBarAciklama = null;
            this.colOdemeMetoduAdi.StatusBarKisaYol = null;
            this.colOdemeMetoduAdi.StatusBarKisaYolAciklama = null;
            this.colOdemeMetoduAdi.Visible = true;
            this.colOdemeMetoduAdi.Width = 150;
            // 
            // colKasa
            // 
            this.colKasa.Caption = "Kasa";
            this.colKasa.FieldName = "KasaAdi";
            this.colKasa.Name = "colKasa";
            this.colKasa.OptionsColumn.AllowEdit = false;
            this.colKasa.StatusBarAciklama = null;
            this.colKasa.StatusBarKisaYol = null;
            this.colKasa.StatusBarKisaYolAciklama = null;
            this.colKasa.Visible = true;
            this.colKasa.Width = 150;
            // 
            // colYakitCinsi
            // 
            this.colYakitCinsi.Caption = "Yakıt Cinsi";
            this.colYakitCinsi.FieldName = "YakitCinsi";
            this.colYakitCinsi.Name = "colYakitCinsi";
            this.colYakitCinsi.OptionsColumn.AllowEdit = false;
            this.colYakitCinsi.StatusBarAciklama = null;
            this.colYakitCinsi.StatusBarKisaYol = null;
            this.colYakitCinsi.StatusBarKisaYolAciklama = null;
            this.colYakitCinsi.Visible = true;
            this.colYakitCinsi.Width = 100;
            // 
            // colBelgeNo
            // 
            this.colBelgeNo.Caption = "Belge No";
            this.colBelgeNo.FieldName = "BelgeNo";
            this.colBelgeNo.Name = "colBelgeNo";
            this.colBelgeNo.OptionsColumn.AllowEdit = false;
            this.colBelgeNo.StatusBarAciklama = null;
            this.colBelgeNo.StatusBarKisaYol = null;
            this.colBelgeNo.StatusBarKisaYolAciklama = null;
            this.colBelgeNo.Visible = true;
            this.colBelgeNo.Width = 120;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "EK BİLGİLER";
            this.gridBand3.Columns.Add(this.colAciklama);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 400;
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
            this.colAciklama.Width = 400;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // YakitHarcamaListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 519);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "YakitHarcamaListForm";
            this.Text = "YAKIT HARCAMA KARTLARI";
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
        private UserControls.Controls.Grid.MyBandedGridView tablo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKod;
        private UserControls.Controls.Grid.MyBandedGridColumn colTarih;
        private UserControls.Controls.Grid.MyBandedGridColumn colAracPlakaNo;
        private UserControls.Controls.Grid.MyBandedGridColumn colLitre;
        private UserControls.Controls.Grid.MyBandedGridColumn colTutar;
        private UserControls.Controls.Grid.MyBandedGridColumn colPersonelAdi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private UserControls.Controls.Grid.MyBandedGridColumn colOdemeMetoduAdi;
        private UserControls.Controls.Grid.MyBandedGridColumn colKasa;
        private UserControls.Controls.Grid.MyBandedGridColumn colYakitCinsi;
        private UserControls.Controls.Grid.MyBandedGridColumn colBelgeNo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private UserControls.Controls.Grid.MyBandedGridColumn colAciklama;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        protected UserControls.Controls.Grid.MyBandedGridControl grid;
    }
}