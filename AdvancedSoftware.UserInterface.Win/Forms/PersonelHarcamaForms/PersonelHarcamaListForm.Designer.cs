namespace AdvancedSoftware.UserInterface.Win.Forms.PersonelHarcamaForms
{
    partial class PersonelHarcamaListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelHarcamaListForm));
            this.longNavigator = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Navigators.longNavigator();
            this.grid = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridControl();
            this.tablo = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colKod = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPersonelAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colKategoriAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colTarih = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colKasaAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colTutar = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colOdemeMetoduAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colBelgeNo = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colBelgeTuru = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
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
            this.gridBand2});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colKod,
            this.colPersonelAdi,
            this.colOdemeMetoduAdi,
            this.colKasaAdi,
            this.colKategoriAdi,
            this.colTarih,
            this.colTutar,
            this.colBelgeTuru,
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
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowAutoFilterRow = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisaYol = null;
            this.tablo.StatusBarKisaYolAciklama = null;
            this.tablo.ViewCaption = "PERSONEL HARCAMALARI";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "HARCAMA BİLGİLERİ";
            this.gridBand1.Columns.Add(this.colKod);
            this.gridBand1.Columns.Add(this.colPersonelAdi);
            this.gridBand1.Columns.Add(this.colKategoriAdi);
            this.gridBand1.Columns.Add(this.colTarih);
            this.gridBand1.Columns.Add(this.colKasaAdi);
            this.gridBand1.Columns.Add(this.colTutar);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 600;
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
            this.colKod.Width = 100;
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
            this.colPersonelAdi.Width = 100;
            // 
            // colKategoriAdi
            // 
            this.colKategoriAdi.Caption = "Harcama Kategorisi";
            this.colKategoriAdi.FieldName = "KategoriAdi";
            this.colKategoriAdi.Name = "colKategoriAdi";
            this.colKategoriAdi.OptionsColumn.AllowEdit = false;
            this.colKategoriAdi.StatusBarAciklama = null;
            this.colKategoriAdi.StatusBarKisaYol = null;
            this.colKategoriAdi.StatusBarKisaYolAciklama = null;
            this.colKategoriAdi.Visible = true;
            this.colKategoriAdi.Width = 100;
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
            // colKasaAdi
            // 
            this.colKasaAdi.Caption = "Kasa Adı";
            this.colKasaAdi.FieldName = "KasaAdi";
            this.colKasaAdi.Name = "colKasaAdi";
            this.colKasaAdi.OptionsColumn.AllowEdit = false;
            this.colKasaAdi.StatusBarAciklama = null;
            this.colKasaAdi.StatusBarKisaYol = null;
            this.colKasaAdi.StatusBarKisaYolAciklama = null;
            this.colKasaAdi.Visible = true;
            this.colKasaAdi.Width = 100;
            // 
            // colTutar
            // 
            this.colTutar.Caption = "Tutar";
            this.colTutar.FieldName = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsColumn.AllowEdit = false;
            this.colTutar.StatusBarAciklama = null;
            this.colTutar.StatusBarKisaYol = null;
            this.colTutar.StatusBarKisaYolAciklama = null;
            this.colTutar.Visible = true;
            this.colTutar.Width = 100;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "DİĞER BİLGİLER";
            this.gridBand2.Columns.Add(this.colOdemeMetoduAdi);
            this.gridBand2.Columns.Add(this.colBelgeNo);
            this.gridBand2.Columns.Add(this.colBelgeTuru);
            this.gridBand2.Columns.Add(this.colAciklama);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 600;
            // 
            // colOdemeMetoduAdi
            // 
            this.colOdemeMetoduAdi.Caption = "Ödeme Metodu";
            this.colOdemeMetoduAdi.FieldName = "OdemeMetoduAdi";
            this.colOdemeMetoduAdi.Name = "colOdemeMetoduAdi";
            this.colOdemeMetoduAdi.OptionsColumn.AllowEdit = false;
            this.colOdemeMetoduAdi.StatusBarAciklama = null;
            this.colOdemeMetoduAdi.StatusBarKisaYol = null;
            this.colOdemeMetoduAdi.StatusBarKisaYolAciklama = null;
            this.colOdemeMetoduAdi.Visible = true;
            this.colOdemeMetoduAdi.Width = 100;
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
            this.colBelgeNo.Width = 100;
            // 
            // colBelgeTuru
            // 
            this.colBelgeTuru.Caption = "Belge Türü";
            this.colBelgeTuru.FieldName = "BelgeTuru";
            this.colBelgeTuru.Name = "colBelgeTuru";
            this.colBelgeTuru.OptionsColumn.AllowEdit = false;
            this.colBelgeTuru.StatusBarAciklama = null;
            this.colBelgeTuru.StatusBarKisaYol = null;
            this.colBelgeTuru.StatusBarKisaYolAciklama = null;
            this.colBelgeTuru.Visible = true;
            this.colBelgeTuru.Width = 100;
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
            this.colAciklama.Width = 300;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // PersonelHarcamaListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 519);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "PersonelHarcamaListForm";
            this.Text = "PERSONEL HARCAMA KARTLARI";
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
        private UserControls.Controls.Grid.MyBandedGridColumn colPersonelAdi;
        private UserControls.Controls.Grid.MyBandedGridColumn colOdemeMetoduAdi;
        private UserControls.Controls.Grid.MyBandedGridColumn colKasaAdi;
        private UserControls.Controls.Grid.MyBandedGridColumn colKategoriAdi;
        private UserControls.Controls.Grid.MyBandedGridColumn colTarih;
        private UserControls.Controls.Grid.MyBandedGridColumn colTutar;
        private UserControls.Controls.Grid.MyBandedGridColumn colBelgeTuru;
        private UserControls.Controls.Grid.MyBandedGridColumn colBelgeNo;
        private UserControls.Controls.Grid.MyBandedGridColumn colAciklama;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
    }
}