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
            Bll = new MusteriGrupBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.MusteriGrup;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new MusteriGrup() : ((MusteriGrupBll)Bll).Single(FilterFunctions.Filter<MusteriGrup>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert)
                return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((MusteriGrupBll)Bll).YeniKodVer();
            txtMusteriGrubu.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (MusteriGrup)OldEntity;

            txtKod.Text = entity.Kod;
            txtMusteriGrubu.Text = entity.MusteriGrubu;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new MusteriGrup
            {
                Id = Id,
                Kod = txtKod.Text,
                MusteriGrubu = txtMusteriGrubu.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };
            ButonEnabledDurumu();
        }
    }
}