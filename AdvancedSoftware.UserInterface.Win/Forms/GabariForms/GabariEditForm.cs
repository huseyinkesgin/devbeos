using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.UserControls.Controls;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.GabariForms
{
    public partial class GabariEditForm : BaseEditForm
    {
        public GabariEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new GabariBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Gabari;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Gabari() : ((GabariBll)Bll).Single(FilterFunctions.Filter<Gabari>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert)
                return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((GabariBll)Bll).YeniKodVer();
            txtGabariAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Gabari)OldEntity;

            txtKod.Text = entity.Kod;
            txtGabariAdi.Text = entity.GabariAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Gabari
            {
                Id = Id,
                Kod = txtKod.Text,
                GabariAdi = txtGabariAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };
            ButonEnabledDurumu();
        }
    }
}