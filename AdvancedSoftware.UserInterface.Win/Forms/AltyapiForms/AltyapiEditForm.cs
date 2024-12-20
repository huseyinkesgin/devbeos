using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.AltyapiForms
{
    public partial class AltyapiEditForm : BaseEditForm
    {
        public AltyapiEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new AltyapiBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Altyapi;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Altyapi() : ((AltyapiBll)Bll).Single(FilterFunctions.Filter<Altyapi>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert)
                return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((AltyapiBll)Bll).YeniKodVer();
            txtAltyapiAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Altyapi)OldEntity;

            txtKod.Text = entity.Kod;
            txtAltyapiAdi.Text = entity.AltyapiAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Altyapi
            {
                Id = Id,
                Kod = txtKod.Text,
                AltyapiAdi = txtAltyapiAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };
            ButonEnabledDurumu();
        }
    }
}