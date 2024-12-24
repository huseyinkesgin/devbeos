using AdavancedSoftware.Model.Dto;
using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftweare.BusinessLayer.General;
using DevExpress.XtraEditors;
using System;

namespace AdvancedSoftware.UserInterface.Win.Forms.FirmaForms
{
    public partial class FirmaEditForm : BaseEditForm
    {
        public FirmaEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new FirmaBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Firma;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new FirmaS() : ((FirmaBll)Bll).Single(FilterFunctions.Filter<Firma>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert)
                return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((FirmaBll)Bll).YeniKodVer();
            txtFirmaAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (FirmaS)OldEntity;

            txtKod.Text = entity.Kod;
            txtFirmaAdi.Text = entity.FirmaAdi;
            txtFaturaAdi.Text = entity.FaturaAdi;
            txtVergiDairesi.Text = entity.VergiDairesi;
            txtIlce.Text = entity.VergiNo;
            txtMersisNo.Text = entity.MersisNo;
            txtKepAdresi.Text = entity.KepAdresi;
            txtIl.Id = entity.IlId;
            txtIl.Text = entity.IlAdi;
            txtIlce.Id = entity.IlceId;
            txtIlce.Text = entity.IlceAdi;
            txtIlce.Text = entity.IlceAdi;
            txtAdres.Text = entity.Adres;
            txtEposta.Text = entity.Telefon;
            txtTelefon.Text = entity.Eposta;
            txtWebsitesi.Text = entity.Websitesi;
            txtFacebook.Text = entity.Facebook;
            txtTwitter.Text = entity.Twitter;
            txtInstagram.Text = entity.Instagram;
            txtLinkedin.Text = entity.Linkedin;
            txtTwitter.Text = entity.Twitter;
            txtVk.Text = entity.VK;
            txtYoutube.Text = entity.Youtube;
            txtTiktok.Text = entity.Tiktok;
            txtAciklama.Text = entity.Aciklama;         
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Firma
            {
                Id = Id,
                Kod = txtKod.Text,
                FirmaAdi = txtFirmaAdi.Text,
                FaturaAdi = txtFaturaAdi.Text,
                VergiDairesi = txtVergiDairesi.Text,
                VergiNo = txtVergiNo.Text,
                MersisNo = txtMersisNo.Text,
                KepAdresi = txtKepAdresi.Text,
                IlId = Convert.ToInt64(txtIl.Id),
                IlceId = Convert.ToInt64(txtIlce.Id),
                Adres = txtAdres.Text,
                Telefon = txtEposta.Text,
                Eposta = txtTelefon.Text,
                Websitesi = txtWebsitesi.Text,
                Facebook = txtFacebook.Text,
                Twitter = txtTwitter.Text,
                Instagram = txtInstagram.Text,
                Linkedin = txtLinkedin.Text,
                VK = txtVk.Text,
                Youtube = txtYoutube.Text,
                Tiktok = txtTiktok.Text,
                Aciklama = txtAdres.Text,
                Durum = tglDurum.IsOn,
            };
            ButonEnabledDurumu();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit))
                return;

            using (var sec = new SelectFunctions())
                if (sender == txtIl)
                    sec.Sec(txtIl);
                else if (sender == txtIlce)
                    sec.Sec(txtIlce, txtIl);
        }

        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtIl)
                return;
            txtIl.ControlEnabledChange(txtIlce);

        }
    }
}