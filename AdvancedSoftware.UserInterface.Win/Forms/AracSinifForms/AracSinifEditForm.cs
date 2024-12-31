using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.AracSinifForms
{
    public partial class AracSinifEditForm : BaseEditForm
    {
        public AracSinifEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new AracSinifBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.AracSinif;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new AracSinif() : ((AracSinifBll)Bll).Single(FilterFunctions.Filter<AracSinif>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert)
                return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((AracSinifBll)Bll).YeniKodVer();
            txtAracSinifAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (AracSinif)OldEntity;

            txtKod.Text = entity.Kod;
            txtAracSinifAdi.Text = entity.AracSinifAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new AracSinif
            {
                Id = Id,
                Kod = txtKod.Text,
                AracSinifAdi = txtAracSinifAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };
            ButonEnabledDurumu();
        }
    }
}