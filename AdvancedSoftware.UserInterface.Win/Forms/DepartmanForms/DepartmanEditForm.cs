using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.DepartmanForms
{
    public partial class DepartmanEditForm : BaseEditForm
    {
        public DepartmanEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new DepartmanBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Departman;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Departman() : ((DepartmanBll)Bll).Single(FilterFunctions.Filter<Departman>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert)
                return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((DepartmanBll)Bll).YeniKodVer();
            txtDepartmanAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Departman)OldEntity;

            txtKod.Text = entity.Kod;
            txtDepartmanAdi.Text = entity.DepartmanAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Departman
            {
                Id = Id,
                Kod = txtKod.Text,
                DepartmanAdi = txtDepartmanAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };
            ButonEnabledDurumu();
        }
    }
}