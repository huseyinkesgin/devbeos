using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.PortfoyTipiForms
{
    public partial class PortfoyTipiEditForm : BaseEditForm
    {
        public PortfoyTipiEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new PortfoyTipiBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.PortfoyTipi;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new PortfoyTipi() : ((PortfoyTipiBll)Bll).Single(FilterFunctions.Filter<PortfoyTipi>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert)
                return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((PortfoyTipiBll)Bll).YeniKodVer();
            txtPortfoyTipiAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (PortfoyTipi)OldEntity;

            txtKod.Text = entity.Kod;
            txtPortfoyTipiAdi.Text = entity.PortfoyTipiAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new PortfoyTipi
            {
                Id = Id,
                Kod = txtKod.Text,
                PortfoyTipiAdi = txtPortfoyTipiAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };
            ButonEnabledDurumu();
        }
    }
}