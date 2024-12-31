using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftweare.BusinessLayer.General;
using DevExpress.Pdf.Native.BouncyCastle.Asn1.Ocsp;

namespace AdvancedSoftware.UserInterface.Win.Forms.MahalleForms
{
    public partial class MahalleEditForm : BaseEditForm
    {
        private readonly long _ilceId;
        private readonly string _ilceAdi;

        public MahalleEditForm(params object[] prm)
        {
            InitializeComponent();

            _ilceId = (long)prm[0];
            _ilceAdi = prm[1].ToString();

            DataLayoutControl = myDataLayoutControl;
            Bll = new MahalleBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Mahalle;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Mahalle() : ((MahalleBll)Bll).Single(FilterFunctions.Filter<Mahalle>(Id));
            NesneyiKontrollereBagla();
            Text = Text + $" - ( {_ilceAdi} )";


            if (BaseIslemTuru != IslemTuru.EntityInsert)
                return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((MahalleBll)Bll).YeniKodVer(x => x.IlceId == _ilceId);
            txtMahalleAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Mahalle)OldEntity;

            txtKod.Text = entity.Kod;
            txtMahalleAdi.Text = entity.MahalleAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Mahalle
            {
                Id = Id,
                Kod = txtKod.Text,
                MahalleAdi = txtMahalleAdi.Text,
                Aciklama = txtAciklama.Text,
                IlceId = _ilceId,
                Durum = tglDurum.IsOn,
            };
            ButonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((MahalleBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.IlceId == _ilceId);
        }

        protected override bool EntityUpdate()
        {
            return ((MahalleBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.IlceId == _ilceId);
        }
    }
}