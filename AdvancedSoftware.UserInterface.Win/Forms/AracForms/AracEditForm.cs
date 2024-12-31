using AdavancedSoftware.Model.Dto;
using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.Common.Functions;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftweare.BusinessLayer.General;
using DevExpress.XtraEditors;
using System;

namespace AdvancedSoftware.UserInterface.Win.Forms.AracForms
{
    public partial class AracEditForm : BaseEditForm
    {
        public AracEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new AracBll(myDataLayoutControl);
            txtAracCinsi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<AracCinsi>());
            txtYakitCinsi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YakitCinsi>());
            txtVitesTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<VitesTuru>());
            BaseKartTuru = KartTuru.Arac;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new AracS() : ((AracBll)Bll).Single(FilterFunctions.Filter<Arac>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert)
                return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((AracBll)Bll).YeniKodVer();
            txtPlakaNo.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (AracS)OldEntity;

            txtKod.Text = entity.Kod;
            txtPlakaNo.Text = entity.PlakaNo;
            txtMarka.Id = entity.MarkaId;
            txtMarka.Text = entity.MarkaAdi;
            txtModel.Id = entity.ModelId;
            txtModel.Text = entity.ModelAdi;
            txtTescilSiraNo.Text = entity.TescilSiraNo;
            txtTescilTarihi.DateTime = entity.TescilTarihi;
            txtIlkTescilTarihi.DateTime = entity.IlkTescilTarihi;
            txtModelYil.Value = entity.ModelYil;
            txtAracSinif.Id = entity.AracSinifId;
            txtAracSinif.Text = entity.AracSinifAdi;
            txtAracCinsi.SelectedItem = entity.AracCinsi.ToName();
            txtAracRenk.Text = entity.AracRenk;
            txtAracMotorNo.Text = entity.AracMotorNo;
            txtAracSasiNo.Text = entity.AracSasiNo;
            txtSilindirHacmi.Text = entity.SilindirHacmi;
            txtMotorGucu.Text = entity.MotorGucu;
            txtYakitCinsi.SelectedItem = entity.YakitCinsi.ToName();
            txtVitesTuru.SelectedItem = entity.VitesTuru.ToName();
            txtBelgeNo.Text = entity.BelgeNo;
            txtSeriNo.Text = entity.SeriNo;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Arac
            {
                Id = Id,
                Kod = txtKod.Text,
                PlakaNo = txtPlakaNo.Text,
                MarkaId = Convert.ToInt64(txtMarka.Id),
                ModelId = Convert.ToInt64(txtModel.Id),
                TescilSiraNo = txtTescilSiraNo.Text,
                TescilTarihi = txtTescilTarihi.DateTime,
                IlkTescilTarihi = txtIlkTescilTarihi.DateTime,
                ModelYil = (int)txtModelYil.Value,
                AracSinifId = Convert.ToInt64(txtAracSinif.Id),
                AracCinsi = txtAracCinsi.Text.GetEnum<AracCinsi>(),
                AracRenk = txtAracRenk.Text,
                AracMotorNo = txtAracMotorNo.Text,
                AracSasiNo = txtAracSasiNo.Text,
                SilindirHacmi = txtSilindirHacmi.Text,
                MotorGucu = txtMotorGucu.Text,
                YakitCinsi = txtYakitCinsi.Text.GetEnum<YakitCinsi>(),
                VitesTuru = txtVitesTuru.Text.GetEnum<VitesTuru>(),
                BelgeNo = txtBelgeNo.Text,
                SeriNo = txtSeriNo.Text,
                Durum = tglDurum.IsOn,
            };
            ButonEnabledDurumu();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit))
                return;

            using (var sec = new SelectFunctions())
                if (sender == txtMarka)
                    sec.Sec(txtMarka);
                else if (sender == txtModel)
                    sec.Sec(txtModel, txtMarka);
                else if (sender == txtAracSinif)
                    sec.Sec(txtAracSinif);
        }

        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtMarka)
                return;
            txtMarka.ControlEnabledChange(txtModel);
         

        }
    }
}