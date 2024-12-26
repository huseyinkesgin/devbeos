using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.MusteriGrupForms
{
    public partial class MusteriGrupEditForm : BaseEditForm
    {
        public MusteriGrupEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new KategoriBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Kategori;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Kategori() : ((KategoriBll)Bll).Single(FilterFunctions.Filter<Kategori>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert)
                return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((KategoriBll)Bll).YeniKodVer();
            txtKategoriAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Kategori)OldEntity;

            txtKod.Text = entity.Kod;
            txtKategoriAdi.Text = entity.KategoriAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Kategori
            {
                Id = Id,
                Kod = txtKod.Text,
                KategoriAdi = txtKategoriAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };
            ButonEnabledDurumu();
        }
    }
}