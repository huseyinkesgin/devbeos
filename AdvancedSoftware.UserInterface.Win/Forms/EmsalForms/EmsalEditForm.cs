using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.UserControls.Controls;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.EmsalForms
{
    public partial class EmsalEditForm : BaseEditForm
    {
        public EmsalEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new EmsalBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Emsal;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Emsal() : ((EmsalBll)Bll).Single(FilterFunctions.Filter<Emsal>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert)
                return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((EmsalBll)Bll).YeniKodVer();
            txtEmsalAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Emsal)OldEntity;

            txtKod.Text = entity.Kod;
            txtEmsalAdi.Text = entity.EmsalAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Emsal
            {
                Id = Id,
                Kod = txtKod.Text,
                EmsalAdi = txtEmsalAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };
            ButonEnabledDurumu();
        }
    }
}