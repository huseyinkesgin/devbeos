namespace AdvancedSoftware.UserInterface.Win.Forms.AracForms
{
    partial class AracListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracListForm));
            this.longNavigator = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Navigators.longNavigator();
            this.grid = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridControl();
            this.tablo = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridView();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colKod = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPlakaNo = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colMarkaAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colModelAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colTescilSiraNo = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colTescilTarihi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colIlkTescilTarihi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colModelYil = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colAracSinifAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colAracCinsi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colAracRenk = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colAracMotorNo = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colAracSasiNo = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colSilindirHacmi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colMotorGucu = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colYakitCinsi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colVitesTuru = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colBelgeNo = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colSeriNo = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.colAciklama = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyBandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
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
            this.colPlakaNo,
            this.colMarkaAdi,
            this.colModelAdi,
            this.colTescilSiraNo,
            this.colTescilTarihi,
            this.colIlkTescilTarihi,
            this.colModelYil,
            this.colAracSinifAdi,
            this.colAracCinsi,
            this.colAracRenk,
            this.colAracMotorNo,
            this.colAracSasiNo,
            this.colSilindirHacmi,
            this.colMotorGucu,
            this.colYakitCinsi,
            this.colVitesTuru,
            this.colBelgeNo,
            this.colSeriNo,
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
            this.tablo.ViewCaption = "ARAÇ LİSTESİ";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
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
            // colPlakaNo
            // 
            this.colPlakaNo.Caption = "Plaka";
            this.colPlakaNo.FieldName = "PlakaNo";
            this.colPlakaNo.Name = "colPlakaNo";
            this.colPlakaNo.OptionsColumn.AllowEdit = false;
            this.colPlakaNo.StatusBarAciklama = null;
            this.colPlakaNo.StatusBarKisaYol = null;
            this.colPlakaNo.StatusBarKisaYolAciklama = null;
            this.colPlakaNo.Visible = true;
            // 
            // colMarkaAdi
            // 
            this.colMarkaAdi.Caption = "Markası";
            this.colMarkaAdi.FieldName = "MarkaAdi";
            this.colMarkaAdi.Name = "colMarkaAdi";
            this.colMarkaAdi.OptionsColumn.AllowEdit = false;
            this.colMarkaAdi.StatusBarAciklama = null;
            this.colMarkaAdi.StatusBarKisaYol = null;
            this.colMarkaAdi.StatusBarKisaYolAciklama = null;
            this.colMarkaAdi.Visible = true;
            // 
            // colModelAdi
            // 
            this.colModelAdi.Caption = "Modeli";
            this.colModelAdi.FieldName = "ModelAdi";
            this.colModelAdi.Name = "colModelAdi";
            this.colModelAdi.OptionsColumn.AllowEdit = false;
            this.colModelAdi.StatusBarAciklama = null;
            this.colModelAdi.StatusBarKisaYol = null;
            this.colModelAdi.StatusBarKisaYolAciklama = null;
            this.colModelAdi.Visible = true;
            // 
            // colTescilSiraNo
            // 
            this.colTescilSiraNo.Caption = "Tescil Sıra No";
            this.colTescilSiraNo.FieldName = "TescilSiraNo";
            this.colTescilSiraNo.Name = "colTescilSiraNo";
            this.colTescilSiraNo.OptionsColumn.AllowEdit = false;
            this.colTescilSiraNo.StatusBarAciklama = null;
            this.colTescilSiraNo.StatusBarKisaYol = null;
            this.colTescilSiraNo.StatusBarKisaYolAciklama = null;
            this.colTescilSiraNo.Visible = true;
            // 
            // colTescilTarihi
            // 
            this.colTescilTarihi.Caption = "Tescil Tarihi";
            this.colTescilTarihi.FieldName = "TescilTarihi";
            this.colTescilTarihi.Name = "colTescilTarihi";
            this.colTescilTarihi.OptionsColumn.AllowEdit = false;
            this.colTescilTarihi.StatusBarAciklama = null;
            this.colTescilTarihi.StatusBarKisaYol = null;
            this.colTescilTarihi.StatusBarKisaYolAciklama = null;
            this.colTescilTarihi.Visible = true;
            // 
            // colIlkTescilTarihi
            // 
            this.colIlkTescilTarihi.Caption = "İlk Tescil Tarihi";
            this.colIlkTescilTarihi.FieldName = "IlkTescilTarihi";
            this.colIlkTescilTarihi.Name = "colIlkTescilTarihi";
            this.colIlkTescilTarihi.OptionsColumn.AllowEdit = false;
            this.colIlkTescilTarihi.StatusBarAciklama = null;
            this.colIlkTescilTarihi.StatusBarKisaYol = null;
            this.colIlkTescilTarihi.StatusBarKisaYolAciklama = null;
            this.colIlkTescilTarihi.Visible = true;
            // 
            // colModelYil
            // 
            this.colModelYil.Caption = "Model Yılı";
            this.colModelYil.FieldName = "ModelYil";
            this.colModelYil.Name = "colModelYil";
            this.colModelYil.OptionsColumn.AllowEdit = false;
            this.colModelYil.StatusBarAciklama = null;
            this.colModelYil.StatusBarKisaYol = null;
            this.colModelYil.StatusBarKisaYolAciklama = null;
            this.colModelYil.Visible = true;
            // 
            // colAracSinifAdi
            // 
            this.colAracSinifAdi.Caption = "Sınıfı";
            this.colAracSinifAdi.FieldName = "AracSinifAdi";
            this.colAracSinifAdi.Name = "colAracSinifAdi";
            this.colAracSinifAdi.OptionsColumn.AllowEdit = false;
            this.colAracSinifAdi.StatusBarAciklama = null;
            this.colAracSinifAdi.StatusBarKisaYol = null;
            this.colAracSinifAdi.StatusBarKisaYolAciklama = null;
            this.colAracSinifAdi.Visible = true;
            // 
            // colAracCinsi
            // 
            this.colAracCinsi.Caption = "Cinsi";
            this.colAracCinsi.FieldName = "AracCinsi";
            this.colAracCinsi.Name = "colAracCinsi";
            this.colAracCinsi.OptionsColumn.AllowEdit = false;
            this.colAracCinsi.StatusBarAciklama = null;
            this.colAracCinsi.StatusBarKisaYol = null;
            this.colAracCinsi.StatusBarKisaYolAciklama = null;
            this.colAracCinsi.Visible = true;
            // 
            // colAracRenk
            // 
            this.colAracRenk.Caption = "Rengi";
            this.colAracRenk.FieldName = "AracRenk";
            this.colAracRenk.Name = "colAracRenk";
            this.colAracRenk.OptionsColumn.AllowEdit = false;
            this.colAracRenk.StatusBarAciklama = null;
            this.colAracRenk.StatusBarKisaYol = null;
            this.colAracRenk.StatusBarKisaYolAciklama = null;
            this.colAracRenk.Visible = true;
            // 
            // colAracMotorNo
            // 
            this.colAracMotorNo.Caption = "Araç Motor No";
            this.colAracMotorNo.FieldName = "AracMotorNo";
            this.colAracMotorNo.Name = "colAracMotorNo";
            this.colAracMotorNo.OptionsColumn.AllowEdit = false;
            this.colAracMotorNo.StatusBarAciklama = null;
            this.colAracMotorNo.StatusBarKisaYol = null;
            this.colAracMotorNo.StatusBarKisaYolAciklama = null;
            this.colAracMotorNo.Visible = true;
            // 
            // colAracSasiNo
            // 
            this.colAracSasiNo.Caption = "Şasi No";
            this.colAracSasiNo.FieldName = "AracSasiNo";
            this.colAracSasiNo.Name = "colAracSasiNo";
            this.colAracSasiNo.OptionsColumn.AllowEdit = false;
            this.colAracSasiNo.StatusBarAciklama = null;
            this.colAracSasiNo.StatusBarKisaYol = null;
            this.colAracSasiNo.StatusBarKisaYolAciklama = null;
            this.colAracSasiNo.Visible = true;
            // 
            // colSilindirHacmi
            // 
            this.colSilindirHacmi.Caption = "Silindir Hacmi";
            this.colSilindirHacmi.FieldName = "SilindirHacmi";
            this.colSilindirHacmi.Name = "colSilindirHacmi";
            this.colSilindirHacmi.OptionsColumn.AllowEdit = false;
            this.colSilindirHacmi.StatusBarAciklama = null;
            this.colSilindirHacmi.StatusBarKisaYol = null;
            this.colSilindirHacmi.StatusBarKisaYolAciklama = null;
            this.colSilindirHacmi.Visible = true;
            // 
            // colMotorGucu
            // 
            this.colMotorGucu.Caption = "Motor Gücü";
            this.colMotorGucu.FieldName = "MotorGucu";
            this.colMotorGucu.Name = "colMotorGucu";
            this.colMotorGucu.OptionsColumn.AllowEdit = false;
            this.colMotorGucu.StatusBarAciklama = null;
            this.colMotorGucu.StatusBarKisaYol = null;
            this.colMotorGucu.StatusBarKisaYolAciklama = null;
            this.colMotorGucu.Visible = true;
            // 
            // colYakitCinsi
            // 
            this.colYakitCinsi.Caption = "Yakıt Türü";
            this.colYakitCinsi.FieldName = "YakitCinsi";
            this.colYakitCinsi.Name = "colYakitCinsi";
            this.colYakitCinsi.OptionsColumn.AllowEdit = false;
            this.colYakitCinsi.StatusBarAciklama = null;
            this.colYakitCinsi.StatusBarKisaYol = null;
            this.colYakitCinsi.StatusBarKisaYolAciklama = null;
            this.colYakitCinsi.Visible = true;
            // 
            // colVitesTuru
            // 
            this.colVitesTuru.Caption = "Vites";
            this.colVitesTuru.FieldName = "VitesTuru";
            this.colVitesTuru.Name = "colVitesTuru";
            this.colVitesTuru.OptionsColumn.AllowEdit = false;
            this.colVitesTuru.StatusBarAciklama = null;
            this.colVitesTuru.StatusBarKisaYol = null;
            this.colVitesTuru.StatusBarKisaYolAciklama = null;
            this.colVitesTuru.Visible = true;
            // 
            // colBelgeNo
            // 
            this.colBelgeNo.Caption = "Ruhsat Belge No";
            this.colBelgeNo.FieldName = "BelgeNo";
            this.colBelgeNo.Name = "colBelgeNo";
            this.colBelgeNo.OptionsColumn.AllowEdit = false;
            this.colBelgeNo.StatusBarAciklama = null;
            this.colBelgeNo.StatusBarKisaYol = null;
            this.colBelgeNo.StatusBarKisaYolAciklama = null;
            this.colBelgeNo.Visible = true;
            // 
            // colSeriNo
            // 
            this.colSeriNo.Caption = "Ruhsat Seri No";
            this.colSeriNo.FieldName = "SeriNo";
            this.colSeriNo.Name = "colSeriNo";
            this.colSeriNo.OptionsColumn.AllowEdit = false;
            this.colSeriNo.StatusBarAciklama = null;
            this.colSeriNo.StatusBarKisaYol = null;
            this.colSeriNo.StatusBarKisaYolAciklama = null;
            this.colSeriNo.Visible = true;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "SeriNo";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.StatusBarAciklama = null;
            this.colAciklama.StatusBarKisaYol = null;
            this.colAciklama.StatusBarKisaYolAciklama = null;
            this.colAciklama.Visible = true;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "GENEL BİLGİLER";
            this.gridBand1.Columns.Add(this.colPlakaNo);
            this.gridBand1.Columns.Add(this.colMarkaAdi);
            this.gridBand1.Columns.Add(this.colModelAdi);
            this.gridBand1.Columns.Add(this.colModelYil);
            this.gridBand1.Columns.Add(this.colVitesTuru);
            this.gridBand1.Columns.Add(this.colAracRenk);
            this.gridBand1.Columns.Add(this.colYakitCinsi);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 525;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "ÖZEL BİLGİLER";
            this.gridBand2.Columns.Add(this.colAracMotorNo);
            this.gridBand2.Columns.Add(this.colAracSasiNo);
            this.gridBand2.Columns.Add(this.colTescilSiraNo);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 225;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "DİĞER BİLGİLER";
            this.gridBand3.Columns.Add(this.colSilindirHacmi);
            this.gridBand3.Columns.Add(this.colAracCinsi);
            this.gridBand3.Columns.Add(this.colAracSinifAdi);
            this.gridBand3.Columns.Add(this.colMotorGucu);
            this.gridBand3.Columns.Add(this.colSeriNo);
            this.gridBand3.Columns.Add(this.colBelgeNo);
            this.gridBand3.Columns.Add(this.colIlkTescilTarihi);
            this.gridBand3.Columns.Add(this.colTescilTarihi);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 600;
            // 
            // AracListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 519);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "AracListForm";
            this.Text = "ARAÇ KARTLARI";
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
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private UserControls.Controls.Grid.MyBandedGridColumn colPlakaNo;
        private UserControls.Controls.Grid.MyBandedGridColumn colMarkaAdi;
        private UserControls.Controls.Grid.MyBandedGridColumn colModelAdi;
        private UserControls.Controls.Grid.MyBandedGridColumn colModelYil;
        private UserControls.Controls.Grid.MyBandedGridColumn colVitesTuru;
        private UserControls.Controls.Grid.MyBandedGridColumn colAracRenk;
        private UserControls.Controls.Grid.MyBandedGridColumn colYakitCinsi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private UserControls.Controls.Grid.MyBandedGridColumn colAracMotorNo;
        private UserControls.Controls.Grid.MyBandedGridColumn colAracSasiNo;
        private UserControls.Controls.Grid.MyBandedGridColumn colTescilSiraNo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private UserControls.Controls.Grid.MyBandedGridColumn colSilindirHacmi;
        private UserControls.Controls.Grid.MyBandedGridColumn colAracCinsi;
        private UserControls.Controls.Grid.MyBandedGridColumn colAracSinifAdi;
        private UserControls.Controls.Grid.MyBandedGridColumn colMotorGucu;
        private UserControls.Controls.Grid.MyBandedGridColumn colSeriNo;
        private UserControls.Controls.Grid.MyBandedGridColumn colBelgeNo;
        private UserControls.Controls.Grid.MyBandedGridColumn colIlkTescilTarihi;
        private UserControls.Controls.Grid.MyBandedGridColumn colTescilTarihi;
        private UserControls.Controls.Grid.MyBandedGridColumn colAciklama;
    }
}