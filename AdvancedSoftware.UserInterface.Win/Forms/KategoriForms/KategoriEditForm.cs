using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.MusteriGrupForms
{
    public partial class KategoriEditForm : BaseEditForm
    {
        private readonly KategoriTuru _kategoriTuru;
        private readonly KartTuru _kategoriKartTuru;

        public KategoriEditForm(params object[] prm)
        {
            InitializeComponent();

            _kategoriTuru = (KategoriTuru)prm[0];
            _kategoriKartTuru = (KartTuru)prm[1];

            DataLayoutControl = myDataLayoutControl;
            Bll = new KategoriBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Kategori;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new AdavancedSoftware.Model.Entities.Kategori() : ((KategoriBll)Bll).Single(FilterFunctions.Filter<Kategori>(Id));
            NesneyiKontrollereBagla();


            if (BaseIslemTuru != IslemTuru.EntityInsert)
                return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((KategoriBll)Bll).YeniKodVer(x => x.KategoriTuru == _kategoriTuru && x.KartTuru == _kategoriKartTuru);
            txtKategoriAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (AdavancedSoftware.Model.Entities.Kategori)OldEntity;

            txtKod.Text = entity.Kod;
            txtKategoriAdi.Text = entity.KategoriAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;

        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new AdavancedSoftware.Model.Entities.Kategori
            {
                Id = Id,
                Kod = txtKod.Text,
                KategoriAdi = txtKategoriAdi.Text,
                KategoriTuru = _kategoriTuru,
                KartTuru = _kategoriKartTuru,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,


            };
            ButonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((KategoriBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.KategoriTuru == _kategoriTuru && x.KartTuru == _kategoriKartTuru);
        }

        protected override bool EntityUpdate()
        {
            return ((KategoriBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.KategoriTuru == _kategoriTuru && x.KartTuru == _kategoriKartTuru);
        }
    }
}