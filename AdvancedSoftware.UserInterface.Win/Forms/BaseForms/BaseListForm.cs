using AdavancedSoftware.Model.Entities.Base;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.Show.Interfaces;
using AdvancedSoftweare.BusinessLayer.Interfaces;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace AdvancedSoftware.UserInterface.Win.Forms.BaseForms
{
    public partial class BaseListForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private bool _formSablonKayitEdilecek;
        private bool _tabloSablonKayitEdilecek;
        protected IBaseFormShow FormShow;
        protected KartTuru BaseKartTuru;
        protected internal GridView Tablo;
        protected bool AktifKartlariGoster = true;
        protected internal bool AktifPasifButonGoster = false;
        protected internal bool MultiSelect;
        protected internal BaseEntity SelectedEntity;
        protected IBaseBll Bll;
        protected ControlNavigator Navigator;
        protected internal long? SeciliGelecekId;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;


        public BaseListForm()
        {
            InitializeComponent();
          

        }
        private void EventsLoad()
        {
            //button events
            foreach (BarItem button in ribbonControl.Items)
                button.ItemClick += Button_ItemClick;

            //tablo events
            Tablo.DoubleClick += Tablo_DoubleClick;
            Tablo.KeyDown += Tablo_KeyDown;
            Tablo.MouseUp += Tablo_MouseUp;
            Tablo.ColumnWidthChanged += Tablo_ColumnWidthChanged;
            Tablo.ColumnPositionChanged += Tablo_ColumnPositionChanged;
            Tablo.EndSorting += Tablo_EndSorting;

            //form events
            Shown += BaseListForm_Shown;
            Load += BaseListForm_Load;
            FormClosing += BaseListForm_FormClosing;
            LocationChanged += BaseListForm_LocationChanged;
            SizeChanged += BaseListForm_SizeChanged;
        }

        private void BaseListForm_SizeChanged(object sender, EventArgs e)
        {
            _formSablonKayitEdilecek = true;    
        }

        private void BaseListForm_LocationChanged(object sender, EventArgs e)
        {
           _formSablonKayitEdilecek = true;
        }

        private void Tablo_EndSorting(object sender, EventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
        }

        private void Tablo_ColumnPositionChanged(object sender, EventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
        }

        private void Tablo_ColumnWidthChanged(object sender, ColumnEventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
        }

        private void BaseListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();
        }

        private void BaseListForm_Load(object sender, EventArgs e)
        {
            SablonYukle();
        }

        private void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            e.SagMenuGoster(sagMenu);
        }

        private void BaseListForm_Shown(object sender, EventArgs e)
        {
            Tablo.Focus();
            ButtonGizleGoster();
            //SutunGizleGoster();

            if(IsMdiChild || SeciliGelecekId == null ) return;

            Tablo.RowFocus("Id", SeciliGelecekId);
        }

      

        private void ButtonGizleGoster()
        {
            btnSec.Visibility = AktifPasifButonGoster ? BarItemVisibility.Never : IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            barEnter.Visibility = IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            barEnterAciklama.Visibility = IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            btnAktifPasifKayit.Visibility = AktifPasifButonGoster ? BarItemVisibility.Always : !IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;

            //TODO: BURADAKİ KOD İŞLEVİNİ GÖRMÜYOR. GÜNCELLENECEK
            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
           HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);


        }
        private void SutunGizleGoster()
        {
            throw new NotImplementedException();
        }


        private void SablonKaydet()
        {
            if (_formSablonKayitEdilecek)
               Name.FormSablonKaydet(Left, Top, Width, Height, WindowState);

            if (_tabloSablonKayitEdilecek)
                Tablo.TabloSablonKaydet(IsMdiChild ? Name + " Tablosu" : Name + " TablosuMDI");
        }

        private void SablonYukle()
        {
           if(IsMdiChild)
                Tablo.TabloSablonYukle(Name + " Tablosu");
            else
            {
               Name.FormSablonYukle(this);
               Tablo.TabloSablonYukle(Name + " TablosuMDI");
            }
        }


        protected internal void Yukle()
        {
            DesgiskenleriDoldur();
            EventsLoad();

            Tablo.OptionsSelection.MultiSelect = MultiSelect;
            Navigator.NavigatableControl = Tablo.GridControl;

            Cursor.Current = Cursors.WaitCursor;
            Listele();
            Cursor.Current = DefaultCursor;


            // Güncelenecek
        }

        protected virtual void DesgiskenleriDoldur() { }
        protected virtual void ShowEditForm(long id)
        {
            var result = FormShow.ShowDialogEditForm(BaseKartTuru, id);
            ShowEditFormDefault(result);
        }

        protected void ShowEditFormDefault(long id)
        {
            if (id <= 0) return;
            AktifKartlariGoster = true;
            FormCaptionAyarla();
            Tablo.RowFocus("Id", id);

        }
        protected virtual void EntityDelete()
        {
            var entity = Tablo.GetRow<BaseEntity>();
            if (entity == null)
                return;
            if (!((IBaseCommonBll)Bll).Delete(entity))
                return;
            Tablo.DeleteSelectedRows();
            Tablo.RowFocus(Tablo.FocusedRowHandle);
        }
        private void SelectEntity()
        {
            if(MultiSelect) 
            {
                //güncellenecek
            } else
                SelectedEntity = Tablo.GetRow<BaseEntity>();

            DialogResult = DialogResult.OK;
            Close();
        }
        protected virtual void Listele() { }
        private void FiltreleSec()
        {
            throw new NotImplementedException();
        }
        private void Yazdir()
        {
            throw new NotImplementedException();
        }
        private void FormCaptionAyarla()
        {
           if(btnAktifPasifKayit == null)
            {
               Listele();
                return; 
            }
           if(AktifKartlariGoster)
            {
                btnAktifPasifKayit.Caption = "Pasif Kartlar";
                Tablo.ViewCaption = Text;           
            }
           else
            {
                btnAktifPasifKayit.Caption = "Aktif Kartlar";
                Tablo.ViewCaption = Text + " - Pasif Kartlar";
            }

            Listele();
        }
        private void IslemTuruSec()
        {
            if (!IsMdiChild)
            {
                //Güncellenecek
                SelectEntity();
            }
            else
                btnDuzenle.PerformClick();
        }


        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnGonder)
            {
                var link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }
            else if (e.Item == btnStandartExcelDosyasi)
            { }
            else if (e.Item == btnFormatliExcelDosyasi)
            { }
            else if (e.Item == btnFormatsizExcelDosyasi)
            { }
            else if (e.Item == btnWordDosyasi)
            { }
            else if (e.Item == btnPdfDosyasi)
            { }
            else if (e.Item == btnTxtDosyasi)
            { }
            else if (e.Item == btnYeni)
            {
                //Yetki Kontrolü
                ShowEditForm(-1);
            }
            else if (e.Item == btnDuzenle)
                ShowEditForm(Tablo.GetRowId());

            else if (e.Item == btnSil)
            {
                // yetki Kontrolü
                EntityDelete();
            }
            else if (e.Item == btnSec)
                SelectEntity();

            else if (e.Item == btnYenile)
                Listele();
            else if (e.Item == btnFiltrele)
                FiltreleSec();
            else if (e.Item == btnKolonlar)
            {
                if (Tablo.CustomizationForm != null) //ders 66, 26.dk
                    Tablo.ShowCustomization();
                else
                    Tablo.HideCustomization();
            }
            else if (e.Item == btnBagliKartlar)
            {
                BagliKartAc();
            }
            else if (e.Item == btnYazdir)
                Yazdir();
            else if (e.Item == btnCikis)
                Close();
            else if (e.Item == btnAktifPasifKayit)
            {
                AktifKartlariGoster = !AktifKartlariGoster;
                FormCaptionAyarla();
            }

            Cursor.Current = DefaultCursor;
        }

        protected virtual void BagliKartAc() {}

        private void Tablo_DoubleClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            IslemTuruSec();
            Cursor.Current = DefaultCursor;
        }

       

        private void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
           
                case Keys.Enter:
                    IslemTuruSec();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }


    }
}