using AdavancedSoftware.Model.Dto;
using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.UserControls.Controls;
using AdvancedSoftweare.BusinessLayer.General;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors;
using System;

namespace AdvancedSoftware.UserInterface.Win.Forms.OfisForms
{
    public partial class OfisEditForm : BaseEditForm
    {
        public OfisEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new OfisBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Ofis;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new OfisS() : ((OfisBll)Bll).Single(FilterFunctions.Filter<Ofis>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert)
                return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((OfisBll)Bll).YeniKodVer();
            txtOfisAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (OfisS)OldEntity;

            txtKod.Text = entity.Kod;
            txtOfisAdi.Text = entity.OfisAdi;
            txtTelefon.Text = entity.Telefon;
            txtEposta.Text = entity.Eposta;
            txtIl.Id = entity.IlId;
            txtIl.Text = entity.IlAdi;
            txtIlce.Id = entity.IlceId;
            txtIlce.Text = entity.IlceAdi;
            txtAdres.Text = entity.Adres;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Ofis
            {
                Id = Id,
                Kod = txtKod.Text,
                OfisAdi = txtOfisAdi.Text,
                Telefon = txtTelefon.Text,
                Eposta = txtEposta.Text,
                IlId = Convert.ToInt64(txtIl.Id),
                IlceId = Convert.ToInt64(txtIlce.Id),
                Adres = txtAdres.Text,
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
            if (sender != txtIl) return;
            txtIl.ControlEnabledChange(txtIlce);

        }


    }
}