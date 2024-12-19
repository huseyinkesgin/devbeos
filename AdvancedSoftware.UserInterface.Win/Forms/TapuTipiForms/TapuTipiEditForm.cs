using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.UserControls.Controls;
using AdvancedSoftweare.BusinessLayer.General;
using DevExpress.Pdf.Native.BouncyCastle.Asn1.Ocsp;

namespace AdvancedSoftware.UserInterface.Win.Forms.TapuTipiForms
{
    public partial class TapuTipiEditForm : BaseEditForm
    {
        private readonly long _portfoyTipiId;
        private readonly string _portfoyTipiAdi;
        public TapuTipiEditForm(params object[] prm)
        {
            InitializeComponent();

            _portfoyTipiId = (long)prm[0];
            _portfoyTipiAdi = prm[1].ToString();

            DataLayoutControl = myDataLayoutControl;
            Bll = new TapuTipiBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.TapuTipi;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new TapuTipi() : ((TapuTipiBll)Bll).Single(FilterFunctions.Filter<TapuTipi>(Id));
            NesneyiKontrollereBagla();
            Text = Text + $" - ( {_portfoyTipiAdi} )";

            if (BaseIslemTuru != IslemTuru.EntityInsert)
                return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((TapuTipiBll)Bll).YeniKodVer();
            txtTapuTipiAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (TapuTipi)OldEntity;

            txtKod.Text = entity.Kod;
            txtTapuTipiAdi.Text = entity.TapuTipiAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new TapuTipi
            {
                Id = Id,
                Kod = txtKod.Text,
                PortfoyTipiId = _portfoyTipiId,
                TapuTipiAdi = txtTapuTipiAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };
            ButonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((TapuTipiBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.PortfoyTipiId == _portfoyTipiId);
        }

        protected override bool EntityUpdate()
        {
            return ((TapuTipiBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.PortfoyTipiId == _portfoyTipiId);
        }
    }
}