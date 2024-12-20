using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.UnvanForms
{
    public partial class UnvanEditForm : BaseEditForm
    {
        public UnvanEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new UnvanBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Unvan;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Unvan() : ((UnvanBll)Bll).Single(FilterFunctions.Filter<Unvan>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert)
                return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((UnvanBll)Bll).YeniKodVer();
            txtUnvanAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Unvan)OldEntity;

            txtKod.Text = entity.Kod;
            txtUnvanAdi.Text = entity.UnvanAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Unvan
            {
                Id = Id,
                Kod = txtKod.Text,
                UnvanAdi = txtUnvanAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };
            ButonEnabledDurumu();
        }
    }
}