namespace AdvancedSoftware.UserInterface.Win.Forms.SiparisForms.KargoFirmasiForms
{
    partial class KargoFirmasiListForm
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
            this.grid = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridControl();
            this.tablo = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridView();
            this.colId = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colKod = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colFirmaAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colTelefon = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colEposta = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colMusteriHizmetleri = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colİlAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colIlceAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colAdres = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.longNavigator = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Navigators.longNavigator();
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
            this.ribbonControl.Size = new System.Drawing.Size(1131, 135);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 135);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1131, 345);
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
            this.colTelefon,
            this.colEposta,
            this.colMusteriHizmetleri,
            this.colİlAdi,
            this.colIlceAdi,
            this.colAdres});
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
            this.tablo.ViewCaption = "Kargo Firmaları Listesi";
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
            this.colFirmaAdi.Width = 200;
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
            this.colTelefon.VisibleIndex = 2;
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
            this.colEposta.VisibleIndex = 3;
            this.colEposta.Width = 120;
            // 
            // colMusteriHizmetleri
            // 
            this.colMusteriHizmetleri.Caption = "Müşteri Hizmetleri Tel.";
            this.colMusteriHizmetleri.FieldName = "MusteriHizmetleri";
            this.colMusteriHizmetleri.Name = "colMusteriHizmetleri";
            this.colMusteriHizmetleri.OptionsColumn.AllowEdit = false;
            this.colMusteriHizmetleri.StatusBarAciklama = null;
            this.colMusteriHizmetleri.StatusBarKisaYol = null;
            this.colMusteriHizmetleri.StatusBarKisaYolAciklama = null;
            this.colMusteriHizmetleri.Visible = true;
            this.colMusteriHizmetleri.VisibleIndex = 4;
            // 
            // colİlAdi
            // 
            this.colİlAdi.Caption = "İl Adı";
            this.colİlAdi.FieldName = "IlAdi";
            this.colİlAdi.Name = "colİlAdi";
            this.colİlAdi.OptionsColumn.AllowEdit = false;
            this.colİlAdi.StatusBarAciklama = null;
            this.colİlAdi.StatusBarKisaYol = null;
            this.colİlAdi.StatusBarKisaYolAciklama = null;
            this.colİlAdi.Visible = true;
            this.colİlAdi.VisibleIndex = 5;
            this.colİlAdi.Width = 99;
            // 
            // colIlceAdi
            // 
            this.colIlceAdi.Caption = "İlçe Adı";
            this.colIlceAdi.FieldName = "IlceAdi";
            this.colIlceAdi.Name = "colIlceAdi";
            this.colIlceAdi.OptionsColumn.AllowEdit = false;
            this.colIlceAdi.StatusBarAciklama = null;
            this.colIlceAdi.StatusBarKisaYol = null;
            this.colIlceAdi.StatusBarKisaYolAciklama = null;
            this.colIlceAdi.Visible = true;
            this.colIlceAdi.VisibleIndex = 6;
            this.colIlceAdi.Width = 98;
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
            this.colAdres.VisibleIndex = 7;
            this.colAdres.Width = 250;
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 480);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1131, 24);
            this.longNavigator.TabIndex = 4;
            // 
            // KargoFirmasiListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 528);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "KargoFirmasiListForm";
            this.Text = "Kargo Firmaları Listesi";
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

        //private UserControls.Controls.Navigators.LongNavigator.;
        private UserControls.Controls.Grid.MyGridControl grid;
        private UserControls.Controls.Grid.MyGridView tablo;
        private UserControls.Controls.Grid.MyGridColumn colId;
        private UserControls.Controls.Grid.MyGridColumn colKod;
        private UserControls.Controls.Grid.MyGridColumn colFirmaAdi;
        private UserControls.Controls.Grid.MyGridColumn colTelefon;
        private UserControls.Controls.Grid.MyGridColumn colEposta;
        private UserControls.Controls.Grid.MyGridColumn colMusteriHizmetleri;
        private UserControls.Controls.Grid.MyGridColumn colİlAdi;
        private UserControls.Controls.Grid.MyGridColumn colIlceAdi;
        private UserControls.Controls.Grid.MyGridColumn colAdres;
        public UserControls.Controls.Navigators.longNavigator longNavigator;
    }
}