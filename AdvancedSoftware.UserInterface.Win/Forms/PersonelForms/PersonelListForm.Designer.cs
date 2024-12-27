namespace AdvancedSoftware.UserInterface.Win.Forms.PersonelForms
{
    partial class PersonelListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelListForm));
            this.longNavigator = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Navigators.longNavigator();
            this.grid = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridControl();
            this.tablo = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colKod = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDepartmanAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colUnvanAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colAd = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colSoyad = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colTcKimlikNo = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colCinsiyet = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colAnneAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colBabaAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colDogumYeri = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colDogumTarihi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colKanGrubu = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colEhliyet = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colMedeniDurum = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colCocukSayisi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colCocukVarmi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colTelefon = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colEposta = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colIlAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colIlceAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colAdres = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colWebsitesi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colBankaAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colSubeAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colIBAN = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colFacebook = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colTiktok = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colInstagram = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colTwitter = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colVK = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colLinkedin = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colYoutube = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAciklama = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
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
            this.grid.Click += new System.EventHandler(this.grid_Click);
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
            this.gridBand5,
            this.gridBand6});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colKod,
            this.colSoyad,
            this.colAd,
            this.colTcKimlikNo,
            this.colCinsiyet,
            this.colDogumTarihi,
            this.colDogumYeri,
            this.colBabaAdi,
            this.colAnneAdi,
            this.colMedeniDurum,
            this.colCocukVarmi,
            this.colCocukSayisi,
            this.colKanGrubu,
            this.colEhliyet,
            this.colEposta,
            this.colTelefon,
            this.colIlAdi,
            this.colIlceAdi,
            this.colAdres,
            this.colWebsitesi,
            this.colFacebook,
            this.colTwitter,
            this.colInstagram,
            this.colLinkedin,
            this.colYoutube,
            this.colTiktok,
            this.colVK,
            this.colAciklama,
            this.colDepartmanAdi,
            this.colUnvanAdi,
            this.colBankaAdi,
            this.colSubeAdi,
            this.colIBAN});
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
            this.tablo.ViewCaption = "PERSONEL LİSTESİ";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "PERSONEL BİLGİLERİ";
            this.gridBand1.Columns.Add(this.colKod);
            this.gridBand1.Columns.Add(this.colDepartmanAdi);
            this.gridBand1.Columns.Add(this.colUnvanAdi);
            this.gridBand1.Columns.Add(this.colAd);
            this.gridBand1.Columns.Add(this.colSoyad);
            this.gridBand1.Columns.Add(this.colTcKimlikNo);
            this.gridBand1.Columns.Add(this.colCinsiyet);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 525;
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
            // colDepartmanAdi
            // 
            this.colDepartmanAdi.Caption = "Departman";
            this.colDepartmanAdi.FieldName = "DepartmanAdi";
            this.colDepartmanAdi.Name = "colDepartmanAdi";
            this.colDepartmanAdi.OptionsColumn.AllowEdit = false;
            this.colDepartmanAdi.StatusBarAciklama = null;
            this.colDepartmanAdi.StatusBarKisaYol = null;
            this.colDepartmanAdi.StatusBarKisaYolAciklama = null;
            this.colDepartmanAdi.Visible = true;
            // 
            // colUnvanAdi
            // 
            this.colUnvanAdi.Caption = "Ünvan";
            this.colUnvanAdi.FieldName = "UnvanAdi";
            this.colUnvanAdi.Name = "colUnvanAdi";
            this.colUnvanAdi.OptionsColumn.AllowEdit = false;
            this.colUnvanAdi.StatusBarAciklama = null;
            this.colUnvanAdi.StatusBarKisaYol = null;
            this.colUnvanAdi.StatusBarKisaYolAciklama = null;
            this.colUnvanAdi.Visible = true;
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
            // 
            // colSoyad
            // 
            this.colSoyad.Caption = "Soyadı";
            this.colSoyad.FieldName = "Soyad";
            this.colSoyad.Name = "colSoyad";
            this.colSoyad.OptionsColumn.AllowEdit = false;
            this.colSoyad.StatusBarAciklama = null;
            this.colSoyad.StatusBarKisaYol = null;
            this.colSoyad.StatusBarKisaYolAciklama = null;
            this.colSoyad.Visible = true;
            // 
            // colTcKimlikNo
            // 
            this.colTcKimlikNo.Caption = "TC Kimlik";
            this.colTcKimlikNo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTcKimlikNo.FieldName = "TcKimlikNo";
            this.colTcKimlikNo.Name = "colTcKimlikNo";
            this.colTcKimlikNo.OptionsColumn.AllowEdit = false;
            this.colTcKimlikNo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colTcKimlikNo.StatusBarAciklama = null;
            this.colTcKimlikNo.StatusBarKisaYol = null;
            this.colTcKimlikNo.StatusBarKisaYolAciklama = null;
            this.colTcKimlikNo.Visible = true;
            // 
            // colCinsiyet
            // 
            this.colCinsiyet.Caption = "Cinsiyet";
            this.colCinsiyet.FieldName = "Cinsiyet";
            this.colCinsiyet.Name = "colCinsiyet";
            this.colCinsiyet.OptionsColumn.AllowEdit = false;
            this.colCinsiyet.StatusBarAciklama = null;
            this.colCinsiyet.StatusBarKisaYol = null;
            this.colCinsiyet.StatusBarKisaYolAciklama = null;
            this.colCinsiyet.Visible = true;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "EK BİLGİLER";
            this.gridBand2.Columns.Add(this.colAnneAdi);
            this.gridBand2.Columns.Add(this.colBabaAdi);
            this.gridBand2.Columns.Add(this.colDogumYeri);
            this.gridBand2.Columns.Add(this.colDogumTarihi);
            this.gridBand2.Columns.Add(this.colKanGrubu);
            this.gridBand2.Columns.Add(this.colEhliyet);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 450;
            // 
            // colAnneAdi
            // 
            this.colAnneAdi.Caption = "Anne Adı";
            this.colAnneAdi.FieldName = "AnneAdi";
            this.colAnneAdi.Name = "colAnneAdi";
            this.colAnneAdi.OptionsColumn.AllowEdit = false;
            this.colAnneAdi.StatusBarAciklama = null;
            this.colAnneAdi.StatusBarKisaYol = null;
            this.colAnneAdi.StatusBarKisaYolAciklama = null;
            this.colAnneAdi.Visible = true;
            // 
            // colBabaAdi
            // 
            this.colBabaAdi.Caption = "BabaAdi";
            this.colBabaAdi.FieldName = "BabaAdi";
            this.colBabaAdi.Name = "colBabaAdi";
            this.colBabaAdi.OptionsColumn.AllowEdit = false;
            this.colBabaAdi.StatusBarAciklama = null;
            this.colBabaAdi.StatusBarKisaYol = null;
            this.colBabaAdi.StatusBarKisaYolAciklama = null;
            this.colBabaAdi.Visible = true;
            // 
            // colDogumYeri
            // 
            this.colDogumYeri.Caption = "Doğum Yeri";
            this.colDogumYeri.FieldName = "DogumYeri";
            this.colDogumYeri.Name = "colDogumYeri";
            this.colDogumYeri.OptionsColumn.AllowEdit = false;
            this.colDogumYeri.StatusBarAciklama = null;
            this.colDogumYeri.StatusBarKisaYol = null;
            this.colDogumYeri.StatusBarKisaYolAciklama = null;
            this.colDogumYeri.Visible = true;
            // 
            // colDogumTarihi
            // 
            this.colDogumTarihi.Caption = "Doğum Tarihi";
            this.colDogumTarihi.FieldName = "DogumTarihi";
            this.colDogumTarihi.Name = "colDogumTarihi";
            this.colDogumTarihi.OptionsColumn.AllowEdit = false;
            this.colDogumTarihi.StatusBarAciklama = null;
            this.colDogumTarihi.StatusBarKisaYol = null;
            this.colDogumTarihi.StatusBarKisaYolAciklama = null;
            this.colDogumTarihi.Visible = true;
            // 
            // colKanGrubu
            // 
            this.colKanGrubu.Caption = "Kan Grubu";
            this.colKanGrubu.FieldName = "KanGrubu";
            this.colKanGrubu.Name = "colKanGrubu";
            this.colKanGrubu.OptionsColumn.AllowEdit = false;
            this.colKanGrubu.StatusBarAciklama = null;
            this.colKanGrubu.StatusBarKisaYol = null;
            this.colKanGrubu.StatusBarKisaYolAciklama = null;
            this.colKanGrubu.Visible = true;
            // 
            // colEhliyet
            // 
            this.colEhliyet.Caption = "Ehliyet";
            this.colEhliyet.FieldName = "Ehliyet";
            this.colEhliyet.Name = "colEhliyet";
            this.colEhliyet.OptionsColumn.AllowEdit = false;
            this.colEhliyet.StatusBarAciklama = null;
            this.colEhliyet.StatusBarKisaYol = null;
            this.colEhliyet.StatusBarKisaYolAciklama = null;
            this.colEhliyet.Visible = true;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "MEDENİ DURUM BİLGİLERİ";
            this.gridBand3.Columns.Add(this.colMedeniDurum);
            this.gridBand3.Columns.Add(this.colCocukSayisi);
            this.gridBand3.Columns.Add(this.colCocukVarmi);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 225;
            // 
            // colMedeniDurum
            // 
            this.colMedeniDurum.Caption = "Medeni Durum";
            this.colMedeniDurum.FieldName = "MedeniDurum";
            this.colMedeniDurum.Name = "colMedeniDurum";
            this.colMedeniDurum.OptionsColumn.AllowEdit = false;
            this.colMedeniDurum.StatusBarAciklama = null;
            this.colMedeniDurum.StatusBarKisaYol = null;
            this.colMedeniDurum.StatusBarKisaYolAciklama = null;
            this.colMedeniDurum.Visible = true;
            // 
            // colCocukSayisi
            // 
            this.colCocukSayisi.Caption = "Çocuk Sayısı";
            this.colCocukSayisi.FieldName = "CocukSayisi";
            this.colCocukSayisi.Name = "colCocukSayisi";
            this.colCocukSayisi.OptionsColumn.AllowEdit = false;
            this.colCocukSayisi.StatusBarAciklama = null;
            this.colCocukSayisi.StatusBarKisaYol = null;
            this.colCocukSayisi.StatusBarKisaYolAciklama = null;
            this.colCocukSayisi.Visible = true;
            // 
            // colCocukVarmi
            // 
            this.colCocukVarmi.Caption = "Çocuk Durumu";
            this.colCocukVarmi.FieldName = "CocukVarmi";
            this.colCocukVarmi.Name = "colCocukVarmi";
            this.colCocukVarmi.OptionsColumn.AllowEdit = false;
            this.colCocukVarmi.StatusBarAciklama = null;
            this.colCocukVarmi.StatusBarKisaYol = null;
            this.colCocukVarmi.StatusBarKisaYolAciklama = null;
            this.colCocukVarmi.Visible = true;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "İLETİŞİM BİLGİLERİ";
            this.gridBand4.Columns.Add(this.colTelefon);
            this.gridBand4.Columns.Add(this.colEposta);
            this.gridBand4.Columns.Add(this.colIlAdi);
            this.gridBand4.Columns.Add(this.colIlceAdi);
            this.gridBand4.Columns.Add(this.colAdres);
            this.gridBand4.Columns.Add(this.colWebsitesi);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 450;
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
            this.colEposta.Caption = "Eposta Adresi";
            this.colEposta.FieldName = "Eposta";
            this.colEposta.Name = "colEposta";
            this.colEposta.OptionsColumn.AllowEdit = false;
            this.colEposta.StatusBarAciklama = null;
            this.colEposta.StatusBarKisaYol = null;
            this.colEposta.StatusBarKisaYolAciklama = null;
            this.colEposta.Visible = true;
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
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "BANKA BİLGİLERİ";
            this.gridBand5.Columns.Add(this.colBankaAdi);
            this.gridBand5.Columns.Add(this.colSubeAdi);
            this.gridBand5.Columns.Add(this.colIBAN);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 4;
            this.gridBand5.Width = 225;
            // 
            // colBankaAdi
            // 
            this.colBankaAdi.Caption = "Banka";
            this.colBankaAdi.FieldName = "BankaAdi";
            this.colBankaAdi.Name = "colBankaAdi";
            this.colBankaAdi.OptionsColumn.AllowEdit = false;
            this.colBankaAdi.StatusBarAciklama = null;
            this.colBankaAdi.StatusBarKisaYol = null;
            this.colBankaAdi.StatusBarKisaYolAciklama = null;
            this.colBankaAdi.Visible = true;
            // 
            // colSubeAdi
            // 
            this.colSubeAdi.Caption = "Banka Şube";
            this.colSubeAdi.FieldName = "SubeAdi";
            this.colSubeAdi.Name = "colSubeAdi";
            this.colSubeAdi.OptionsColumn.AllowEdit = false;
            this.colSubeAdi.StatusBarAciklama = null;
            this.colSubeAdi.StatusBarKisaYol = null;
            this.colSubeAdi.StatusBarKisaYolAciklama = null;
            this.colSubeAdi.Visible = true;
            // 
            // colIBAN
            // 
            this.colIBAN.Caption = "İban";
            this.colIBAN.FieldName = "IBAN";
            this.colIBAN.Name = "colIBAN";
            this.colIBAN.OptionsColumn.AllowEdit = false;
            this.colIBAN.StatusBarAciklama = null;
            this.colIBAN.StatusBarKisaYol = null;
            this.colIBAN.StatusBarKisaYolAciklama = null;
            this.colIBAN.Visible = true;
            // 
            // gridBand6
            // 
            this.gridBand6.Caption = "SOSYAL MEDYA";
            this.gridBand6.Columns.Add(this.colFacebook);
            this.gridBand6.Columns.Add(this.colTiktok);
            this.gridBand6.Columns.Add(this.colInstagram);
            this.gridBand6.Columns.Add(this.colTwitter);
            this.gridBand6.Columns.Add(this.colVK);
            this.gridBand6.Columns.Add(this.colLinkedin);
            this.gridBand6.Columns.Add(this.colYoutube);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.VisibleIndex = 5;
            this.gridBand6.Width = 525;
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
            // colInstagram
            // 
            this.colInstagram.Caption = "Instagram";
            this.colInstagram.FieldName = "Instagram ";
            this.colInstagram.Name = "colInstagram";
            this.colInstagram.OptionsColumn.AllowEdit = false;
            this.colInstagram.StatusBarAciklama = null;
            this.colInstagram.StatusBarKisaYol = null;
            this.colInstagram.StatusBarKisaYolAciklama = null;
            this.colInstagram.Visible = true;
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
            // colVK
            // 
            this.colVK.Caption = "VK";
            this.colVK.FieldName = "VK";
            this.colVK.Name = "colVK";
            this.colVK.OptionsColumn.AllowEdit = false;
            this.colVK.StatusBarAciklama = null;
            this.colVK.StatusBarKisaYol = null;
            this.colVK.StatusBarKisaYolAciklama = null;
            this.colVK.Visible = true;
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
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
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
            // PersonelListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 519);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "PersonelListForm";
            this.Text = "PersonelListForm";
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
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKod;
        private UserControls.Controls.Grid.MyBandedGridColumn colAd;
        private UserControls.Controls.Grid.MyBandedGridColumn colSoyad;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private UserControls.Controls.Grid.MyBandedGridColumn colTcKimlikNo;
        private UserControls.Controls.Grid.MyBandedGridColumn colCinsiyet;
        private UserControls.Controls.Grid.MyBandedGridColumn colDogumTarihi;
        private UserControls.Controls.Grid.MyBandedGridColumn colDogumYeri;
        private UserControls.Controls.Grid.MyBandedGridColumn colBabaAdi;
        private UserControls.Controls.Grid.MyBandedGridColumn colAnneAdi;
        private UserControls.Controls.Grid.MyBandedGridColumn colMedeniDurum;
        private UserControls.Controls.Grid.MyBandedGridColumn colCocukVarmi;
        private UserControls.Controls.Grid.MyBandedGridColumn colCocukSayisi;
        private UserControls.Controls.Grid.MyBandedGridColumn colKanGrubu;
        private UserControls.Controls.Grid.MyBandedGridColumn colEhliyet;
        private UserControls.Controls.Grid.MyBandedGridColumn colEposta;
        private UserControls.Controls.Grid.MyBandedGridColumn colTelefon;
        private UserControls.Controls.Grid.MyBandedGridColumn colIlAdi;
        private UserControls.Controls.Grid.MyBandedGridColumn colIlceAdi;
        private UserControls.Controls.Grid.MyBandedGridColumn colAdres;
        private UserControls.Controls.Grid.MyBandedGridColumn colWebsitesi;
        private UserControls.Controls.Grid.MyBandedGridColumn colFacebook;
        private UserControls.Controls.Grid.MyBandedGridColumn colTwitter;
        private UserControls.Controls.Grid.MyBandedGridColumn colInstagram;
        private UserControls.Controls.Grid.MyBandedGridColumn colLinkedin;
        private UserControls.Controls.Grid.MyBandedGridColumn colYoutube;
        private UserControls.Controls.Grid.MyBandedGridColumn colTiktok;
        private UserControls.Controls.Grid.MyBandedGridColumn colVK;
        private UserControls.Controls.Grid.MyBandedGridColumn colAciklama;
        private UserControls.Controls.Grid.MyBandedGridColumn colDepartmanAdi;
        private UserControls.Controls.Grid.MyBandedGridColumn colUnvanAdi;
        private UserControls.Controls.Grid.MyBandedGridColumn colBankaAdi;
        private UserControls.Controls.Grid.MyBandedGridColumn colSubeAdi;
        private UserControls.Controls.Grid.MyBandedGridColumn colIBAN;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
    }
}