using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.IsıtmaForms
{
    public partial class IsitmaEditForm : BaseEditForm
    {
        public IsitmaEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new IsitmaBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Isitma;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Isitma() : ((IsitmaBll)Bll).Single(FilterFunctions.Filter<Isitma>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert)
                return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IsitmaBll)Bll).YeniKodVer();
            txtIsitmaAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Isitma)OldEntity;

            txtKod.Text = entity.Kod;
            txtIsitmaAdi.Text = entity.IsitmaAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Isitma
            {
                Id = Id,
                Kod = txtKod.Text,
                IsitmaAdi = txtIsitmaAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };
            ButonEnabledDurumu();
        }
    }
}