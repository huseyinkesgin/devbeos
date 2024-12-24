using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.MarkaForms
{
    public partial class MarkaEditForm : BaseEditForm
    {
        public MarkaEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new MarkaBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Marka;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Marka() : ((MarkaBll)Bll).Single(FilterFunctions.Filter<Marka>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert)
                return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((MarkaBll)Bll).YeniKodVer();
            txtMarkaAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Marka)OldEntity;

            txtKod.Text = entity.Kod;
            txtMarkaAdi.Text = entity.MarkaAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Marka
            {
                Id = Id,
                Kod = txtKod.Text,
                MarkaAdi = txtMarkaAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };
            ButonEnabledDurumu();
        }
    }
}