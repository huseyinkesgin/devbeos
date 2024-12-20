using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.UserControls.Controls;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.ImarBilgisiForms
{
    public partial class ImarBilgisiEditForm : BaseEditForm
    {
        public ImarBilgisiEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new ImarDurumuBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.ImarDurumu;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new ImarBilgisi() : ((ImarDurumuBll)Bll).Single(FilterFunctions.Filter<ImarBilgisi>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert)
                return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((ImarDurumuBll)Bll).YeniKodVer();
            txtImarBilgisiAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (ImarBilgisi)OldEntity;

            txtKod.Text = entity.Kod;
            txtImarBilgisiAdi.Text = entity.ImarBilgisiAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new ImarBilgisi
            {
                Id = Id,
                Kod = txtKod.Text,
                ImarBilgisiAdi = txtImarBilgisiAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };
            ButonEnabledDurumu();
        }
    }
}