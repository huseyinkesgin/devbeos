using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.UserControls.Controls;
using AdvancedSoftweare.BusinessLayer.General;
using DevExpress.Pdf.Native.BouncyCastle.Asn1.Ocsp;

namespace AdvancedSoftware.UserInterface.Win.Forms.TapuTipiForms
{
    public partial class IsyeriTipiEditForm : BaseEditForm
    {

        public IsyeriTipiEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new IsyeriTipiBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.IsyeriTipi;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new IsyeriTipi() : ((IsyeriTipiBll)Bll).Single(FilterFunctions.Filter<IsyeriTipi>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert)
                return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IsyeriTipiBll)Bll).YeniKodVer();
            txtIsyeriTipiAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (IsyeriTipi)OldEntity;

            txtKod.Text = entity.Kod;
            txtIsyeriTipiAdi.Text = entity.IsyeriTipiAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new IsyeriTipi
            {
                Id = Id,
                Kod = txtKod.Text,
                IsyeriTipiAdi = txtIsyeriTipiAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };
            ButonEnabledDurumu();
        }
    }
}