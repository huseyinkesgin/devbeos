using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftweare.BusinessLayer.General;
using AdvancedSoftware.Common.Enums;
using AdavancedSoftware.Model.Dto;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdavancedSoftware.Model.Entities;
using System;
using DevExpress.XtraEditors;

namespace AdvancedSoftware.UserInterface.Win.Forms.SiparisForms.KargoFirmasiForms
{
    public partial class KargoFirmasiEditForm : BaseEditForm
    {
        public KargoFirmasiEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new KargoFirmasiBll(myDataLayoutControl);
            BaseKartTuru =KartTuru.KargoFirmasi;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new KargoFirmasiS() : ((KargoFirmasiBll)Bll).Single(FilterFunctions.Filter<KargoFirmasi>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            txtKod.Text = ((KargoFirmasiBll)Bll).YeniKodVer();
            txtFirmaAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (KargoFirmasiS)OldEntity;

            txtKod.Text = entity.Kod;
            txtFirmaAdi.Text = entity.FirmaAdi;
            txtTelefon.Text = entity.Telefon;
            txtEposta.Text = entity.Eposta;
            txtMusteriHizmetleri.Text = entity.MusteriHizmetleri;
            txtIl.Id = entity.IlId;
            txtIl.Text = entity.IlAdi;
            txtIlce.Id = entity.IlceId;
            txtIlce.Text = entity.IlceAdi;
            txtAdres.Text = entity.Adres;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new KargoFirmasi
            {
                Id = Id,
                Kod = txtKod.Text,
                FirmaAdi = txtFirmaAdi.Text,
                Telefon = txtTelefon.Text,
                Eposta = txtEposta.Text,
                MusteriHizmetleri = txtMusteriHizmetleri.Text,
                IlId = Convert.ToInt64(txtIl.Id),
                IlceId = Convert.ToInt64(txtIlce.Id),
                Adres = txtAdres.Text,
                Durum = tglDurum.IsOn,
            };
            ButonEnabledDurumu();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtIl)
                    sec.Sec(txtIl);
            else if (sender == txtIlce)
                    sec.Sec(txtIlce, txtIl);
        }
    }
}