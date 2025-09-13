namespace AdvancedSoftware.UserInterface.Win.Forms.MusteriTalepForms
{
    partial class MusteriTalepListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriTalepListForm));
            this.longNavigator = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Navigators.longNavigator();
            this.grid = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridControl();
            this.tablo = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridView();
            this.colId = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colKod = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colTalepBasligi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colMusteriAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colTalepTuru = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colTalepDurumu = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colOncelikSeviyesi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colTalepTarihi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colTalepEdilecekTarih = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colTamamlanmaTarihi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colSorumluPersonelAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colIlAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colIlceAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colMahalleAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colPortfoyAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colHizmetAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colMinBütce = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colMaxBütce = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colAciklama = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
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
            this.ribbonControl.Size = new System.Drawing.Size(1134, 135);
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
            this.longNavigator.Location = new System.Drawing.Point(0, 495);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1134, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 135);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1134, 360);
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
            this.colTalepBasligi,
            this.colMusteriAdi,
            this.colTalepTuru,
            this.colTalepDurumu,
            this.colOncelikSeviyesi,
            this.colTalepTarihi,
            this.colTalepEdilecekTarih,
            this.colTamamlanmaTarihi,
            this.colSorumluPersonelAdi,
            this.colIlAdi,
            this.colIlceAdi,
            this.colMahalleAdi,
            this.colPortfoyAdi,
            this.colHizmetAdi,
            this.colMinBütce,
            this.colMaxBütce,
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
            this.tablo.ViewCaption = "MÜŞTERİ TALEP LİSTESİ";
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
            // colTalepBasligi
            // 
            this.colTalepBasligi.Caption = "Talep Başlığı";
            this.colTalepBasligi.FieldName = "TalepBasligi";
            this.colTalepBasligi.Name = "colTalepBasligi";
            this.colTalepBasligi.OptionsColumn.AllowEdit = false;
            this.colTalepBasligi.StatusBarAciklama = null;
            this.colTalepBasligi.StatusBarKisaYol = null;
            this.colTalepBasligi.StatusBarKisaYolAciklama = null;
            this.colTalepBasligi.Visible = true;
            this.colTalepBasligi.VisibleIndex = 1;
            // 
            // colMusteriAdi
            // 
            this.colMusteriAdi.Caption = "Müşteri";
            this.colMusteriAdi.FieldName = "MusteriAdi";
            this.colMusteriAdi.Name = "colMusteriAdi";
            this.colMusteriAdi.OptionsColumn.AllowEdit = false;
            this.colMusteriAdi.StatusBarAciklama = null;
            this.colMusteriAdi.StatusBarKisaYol = null;
            this.colMusteriAdi.StatusBarKisaYolAciklama = null;
            this.colMusteriAdi.Visible = true;
            this.colMusteriAdi.VisibleIndex = 2;
            // 
            // colTalepTuru
            // 
            this.colTalepTuru.Caption = "Talep Türü";
            this.colTalepTuru.FieldName = "TalepTuru";
            this.colTalepTuru.Name = "colTalepTuru";
            this.colTalepTuru.OptionsColumn.AllowEdit = false;
            this.colTalepTuru.StatusBarAciklama = null;
            this.colTalepTuru.StatusBarKisaYol = null;
            this.colTalepTuru.StatusBarKisaYolAciklama = null;
            this.colTalepTuru.Visible = true;
            this.colTalepTuru.VisibleIndex = 3;
            // 
            // colTalepDurumu
            // 
            this.colTalepDurumu.Caption = "Durum";
            this.colTalepDurumu.FieldName = "TalepDurumu";
            this.colTalepDurumu.Name = "colTalepDurumu";
            this.colTalepDurumu.OptionsColumn.AllowEdit = false;
            this.colTalepDurumu.StatusBarAciklama = null;
            this.colTalepDurumu.StatusBarKisaYol = null;
            this.colTalepDurumu.StatusBarKisaYolAciklama = null;
            this.colTalepDurumu.Visible = true;
            this.colTalepDurumu.VisibleIndex = 4;
            // 
            // colOncelikSeviyesi
            // 
            this.colOncelikSeviyesi.Caption = "Öncelik";
            this.colOncelikSeviyesi.FieldName = "OncelikSeviyesi";
            this.colOncelikSeviyesi.Name = "colOncelikSeviyesi";
            this.colOncelikSeviyesi.OptionsColumn.AllowEdit = false;
            this.colOncelikSeviyesi.StatusBarAciklama = null;
            this.colOncelikSeviyesi.StatusBarKisaYol = null;
            this.colOncelikSeviyesi.StatusBarKisaYolAciklama = null;
            this.colOncelikSeviyesi.Visible = true;
            this.colOncelikSeviyesi.VisibleIndex = 5;
            // 
            // colTalepTarihi
            // 
            this.colTalepTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colTalepTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTalepTarihi.Caption = "Talep Tarihi";
            this.colTalepTarihi.FieldName = "TalepTarihi";
            this.colTalepTarihi.Name = "colTalepTarihi";
            this.colTalepTarihi.OptionsColumn.AllowEdit = false;
            this.colTalepTarihi.StatusBarAciklama = null;
            this.colTalepTarihi.StatusBarKisaYol = null;
            this.colTalepTarihi.StatusBarKisaYolAciklama = null;
            this.colTalepTarihi.Visible = true;
            this.colTalepTarihi.VisibleIndex = 6;
            // 
            // colTalepEdilecekTarih
            // 
            this.colTalepEdilecekTarih.AppearanceCell.Options.UseTextOptions = true;
            this.colTalepEdilecekTarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTalepEdilecekTarih.Caption = "Talep Edilecek Tarih";
            this.colTalepEdilecekTarih.FieldName = "TalepEdilecekTarih";
            this.colTalepEdilecekTarih.Name = "colTalepEdilecekTarih";
            this.colTalepEdilecekTarih.OptionsColumn.AllowEdit = false;
            this.colTalepEdilecekTarih.StatusBarAciklama = null;
            this.colTalepEdilecekTarih.StatusBarKisaYol = null;
            this.colTalepEdilecekTarih.StatusBarKisaYolAciklama = null;
            this.colTalepEdilecekTarih.Visible = true;
            this.colTalepEdilecekTarih.VisibleIndex = 7;
            // 
            // colTamamlanmaTarihi
            // 
            this.colTamamlanmaTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colTamamlanmaTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTamamlanmaTarihi.Caption = "Tamamlanma Tarihi";
            this.colTamamlanmaTarihi.FieldName = "TamamlanmaTarihi";
            this.colTamamlanmaTarihi.Name = "colTamamlanmaTarihi";
            this.colTamamlanmaTarihi.OptionsColumn.AllowEdit = false;
            this.colTamamlanmaTarihi.StatusBarAciklama = null;
            this.colTamamlanmaTarihi.StatusBarKisaYol = null;
            this.colTamamlanmaTarihi.StatusBarKisaYolAciklama = null;
            this.colTamamlanmaTarihi.Visible = true;
            this.colTamamlanmaTarihi.VisibleIndex = 8;
            // 
            // colSorumluPersonelAdi
            // 
            this.colSorumluPersonelAdi.Caption = "Sorumlu Personel";
            this.colSorumluPersonelAdi.FieldName = "SorumluPersonelAdi";
            this.colSorumluPersonelAdi.Name = "colSorumluPersonelAdi";
            this.colSorumluPersonelAdi.OptionsColumn.AllowEdit = false;
            this.colSorumluPersonelAdi.StatusBarAciklama = null;
            this.colSorumluPersonelAdi.StatusBarKisaYol = null;
            this.colSorumluPersonelAdi.StatusBarKisaYolAciklama = null;
            this.colSorumluPersonelAdi.Visible = true;
            this.colSorumluPersonelAdi.VisibleIndex = 9;
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
            this.colIlAdi.VisibleIndex = 10;
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
            this.colIlceAdi.VisibleIndex = 11;
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
            this.colMahalleAdi.VisibleIndex = 12;
            // 
            // colPortfoyAdi
            // 
            this.colPortfoyAdi.Caption = "Portföy";
            this.colPortfoyAdi.FieldName = "PortfoyAdi";
            this.colPortfoyAdi.Name = "colPortfoyAdi";
            this.colPortfoyAdi.OptionsColumn.AllowEdit = false;
            this.colPortfoyAdi.StatusBarAciklama = null;
            this.colPortfoyAdi.StatusBarKisaYol = null;
            this.colPortfoyAdi.StatusBarKisaYolAciklama = null;
            this.colPortfoyAdi.Visible = true;
            this.colPortfoyAdi.VisibleIndex = 13;
            // 
            // colHizmetAdi
            // 
            this.colHizmetAdi.Caption = "Hizmet";
            this.colHizmetAdi.FieldName = "HizmetAdi";
            this.colHizmetAdi.Name = "colHizmetAdi";
            this.colHizmetAdi.OptionsColumn.AllowEdit = false;
            this.colHizmetAdi.StatusBarAciklama = null;
            this.colHizmetAdi.StatusBarKisaYol = null;
            this.colHizmetAdi.StatusBarKisaYolAciklama = null;
            this.colHizmetAdi.Visible = true;
            this.colHizmetAdi.VisibleIndex = 14;
            // 
            // colMinBütce
            // 
            this.colMinBütce.AppearanceCell.Options.UseTextOptions = true;
            this.colMinBütce.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colMinBütce.Caption = "Min Bütçe";
            this.colMinBütce.DisplayFormat.FormatString = "{0:c2}";
            this.colMinBütce.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMinBütce.FieldName = "MinBütce";
            this.colMinBütce.Name = "colMinBütce";
            this.colMinBütce.OptionsColumn.AllowEdit = false;
            this.colMinBütce.StatusBarAciklama = null;
            this.colMinBütce.StatusBarKisaYol = null;
            this.colMinBütce.StatusBarKisaYolAciklama = null;
            this.colMinBütce.Visible = true;
            this.colMinBütce.VisibleIndex = 15;
            // 
            // colMaxBütce
            // 
            this.colMaxBütce.AppearanceCell.Options.UseTextOptions = true;
            this.colMaxBütce.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colMaxBütce.Caption = "Max Bütçe";
            this.colMaxBütce.DisplayFormat.FormatString = "{0:c2}";
            this.colMaxBütce.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMaxBütce.FieldName = "MaxBütce";
            this.colMaxBütce.Name = "colMaxBütce";
            this.colMaxBütce.OptionsColumn.AllowEdit = false;
            this.colMaxBütce.StatusBarAciklama = null;
            this.colMaxBütce.StatusBarKisaYol = null;
            this.colMaxBütce.StatusBarKisaYolAciklama = null;
            this.colMaxBütce.Visible = true;
            this.colMaxBütce.VisibleIndex = 16;
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
            this.colAciklama.VisibleIndex = 17;
            // 
            // MusteriTalepListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 361);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.Name = "MusteriTalepListForm";
            this.Text = "Müşteri Talep Kartları";
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
        private UserControls.Controls.Grid.MyGridColumn colTalepBasligi;
        private UserControls.Controls.Grid.MyGridColumn colMusteriAdi;
        private UserControls.Controls.Grid.MyGridColumn colTalepTuru;
        private UserControls.Controls.Grid.MyGridColumn colTalepDurumu;
        private UserControls.Controls.Grid.MyGridColumn colOncelikSeviyesi;
        private UserControls.Controls.Grid.MyGridColumn colTalepTarihi;
        private UserControls.Controls.Grid.MyGridColumn colTalepEdilecekTarih;
        private UserControls.Controls.Grid.MyGridColumn colTamamlanmaTarihi;
        private UserControls.Controls.Grid.MyGridColumn colSorumluPersonelAdi;
        private UserControls.Controls.Grid.MyGridColumn colIlAdi;
        private UserControls.Controls.Grid.MyGridColumn colIlceAdi;
        private UserControls.Controls.Grid.MyGridColumn colMahalleAdi;
        private UserControls.Controls.Grid.MyGridColumn colPortfoyAdi;
        private UserControls.Controls.Grid.MyGridColumn colHizmetAdi;
        private UserControls.Controls.Grid.MyGridColumn colMinBütce;
        private UserControls.Controls.Grid.MyGridColumn colMaxBütce;
        private UserControls.Controls.Grid.MyGridColumn colAciklama;
    }
}
