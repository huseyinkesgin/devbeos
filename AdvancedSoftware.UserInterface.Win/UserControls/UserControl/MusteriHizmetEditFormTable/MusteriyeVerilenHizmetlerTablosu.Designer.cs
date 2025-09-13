namespace AdvancedSoftware.UserInterface.Win.UserControls.UserControl.MusteriHizmetEditFormTable
{
    partial class MusteriyeVerilenHizmetlerTablosu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridControl();
            this.tablo = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridView();
            this.colHizmetBaslangic = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colHizmetTuruAdi = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colHizmetBitis = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.colAciklama = new AdvancedSoftware.UserInterface.Win.UserControls.Controls.Grid.MyGridColumn();
            this.repositoryTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // addUptNavigator
            // 
            this.addUptNavigator.Location = new System.Drawing.Point(0, 399);
            this.addUptNavigator.Size = new System.Drawing.Size(577, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryTarih});
            this.grid.Size = new System.Drawing.Size(577, 399);
            this.grid.TabIndex = 5;
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
            this.colHizmetTuruAdi,
            this.colHizmetBaslangic,
            this.colHizmetBitis,
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
            this.tablo.ViewCaption = "Müşteriye VErilen Hizmetler Tablosu";
            // 
            // colHizmetBaslangic
            // 
            this.colHizmetBaslangic.Caption = "Hizmet Başlangıç";
            this.colHizmetBaslangic.FieldName = "HizmetBaslangic";
            this.colHizmetBaslangic.GroupFormat.FormatString = "d";
            this.colHizmetBaslangic.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colHizmetBaslangic.Name = "colHizmetBaslangic";
            this.colHizmetBaslangic.OptionsColumn.AllowEdit = false;
            this.colHizmetBaslangic.StatusBarAciklama = null;
            this.colHizmetBaslangic.StatusBarKisaYol = null;
            this.colHizmetBaslangic.StatusBarKisaYolAciklama = null;
            this.colHizmetBaslangic.Visible = true;
            this.colHizmetBaslangic.VisibleIndex = 1;
            this.colHizmetBaslangic.Width = 111;
            // 
            // colHizmetTuruAdi
            // 
            this.colHizmetTuruAdi.Caption = "Hizmet Türü";
            this.colHizmetTuruAdi.FieldName = "HizmetTuru";
            this.colHizmetTuruAdi.Name = "colHizmetTuruAdi";
            this.colHizmetTuruAdi.OptionsColumn.AllowEdit = false;
            this.colHizmetTuruAdi.StatusBarAciklama = null;
            this.colHizmetTuruAdi.StatusBarKisaYol = null;
            this.colHizmetTuruAdi.StatusBarKisaYolAciklama = null;
            this.colHizmetTuruAdi.Visible = true;
            this.colHizmetTuruAdi.VisibleIndex = 0;
            this.colHizmetTuruAdi.Width = 92;
            // 
            // colHizmetBitis
            // 
            this.colHizmetBitis.Caption = "Hizmet Bitiş";
            this.colHizmetBitis.FieldName = "HizmetBitis";
            this.colHizmetBitis.GroupFormat.FormatString = "d";
            this.colHizmetBitis.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colHizmetBitis.Name = "colHizmetBitis";
            this.colHizmetBitis.OptionsColumn.AllowEdit = false;
            this.colHizmetBitis.StatusBarAciklama = null;
            this.colHizmetBitis.StatusBarKisaYol = null;
            this.colHizmetBitis.StatusBarKisaYolAciklama = null;
            this.colHizmetBitis.Visible = true;
            this.colHizmetBitis.VisibleIndex = 2;
            this.colHizmetBitis.Width = 100;
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
            this.colAciklama.VisibleIndex = 3;
            this.colAciklama.Width = 182;
            // 
            // repositoryTarih
            // 
            this.repositoryTarih.AutoHeight = false;
            this.repositoryTarih.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryTarih.Name = "repositoryTarih";
            // 
            // MusteriyeVerilenHizmetlerTablosu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "MusteriyeVerilenHizmetlerTablosu";
            this.Size = new System.Drawing.Size(577, 423);
            this.Controls.SetChildIndex(this.addUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTarih)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.Grid.MyGridControl grid;
        private Controls.Grid.MyGridView tablo;
        private Controls.Grid.MyGridColumn colHizmetTuruAdi;
        private Controls.Grid.MyGridColumn colHizmetBaslangic;
        private Controls.Grid.MyGridColumn colHizmetBitis;
        private Controls.Grid.MyGridColumn colAciklama;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryTarih;
    }
}
