using AdavancedSoftware.Model.Dto;
using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.Common.Functions;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftweare.BusinessLayer.General;
using DevExpress.XtraEditors;
using System;

namespace AdvancedSoftware.UserInterface.Win.Forms.YakitHarcamaForms
{
    public partial class YakitHarcamaEditForm : BaseEditForm
    {
        public YakitHarcamaEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new YakitHarcamaBll(myDataLayoutControl);
            txtYakitCinsi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YakitCinsi>());
            
            BaseKartTuru = KartTuru.YakitHarcama;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new YakitHarcamaS() : ((YakitHarcamaBll)Bll).Single(FilterFunctions.Filter<YakitHarcama>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert)
                return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((YakitHarcamaBll)Bll).YeniKodVer();
            txtTutar.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (YakitHarcamaS)OldEntity;

            txtKod.Text = entity.Kod;
            txtArac.Id = entity.AracId;
            txtArac.Text = entity.AracPlakaNo;
            txtPersonel.Id = entity.PersonelId;
            txtPersonel.Text = entity.PersonelAdi;
            txtOdemeMetodu.Id = entity.OdemeMetoduId;
            txtOdemeMetodu.Text = entity.OdemeMetoduAdi;
            txtKasa.Id = entity.KasaId;
            txtKasa.Text = entity.KasaAdi;
            txtTarih.DateTime = entity.Tarih;
            txtLitre.Value = entity.Litre;
            txtTutar.Value = entity.Tutar;
            txtYakitCinsi.SelectedItem = entity.YakitCinsi.ToName();
            txtBelgeNo.Text = entity.BelgeNo;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new YakitHarcama
            {
                Id = Id,
                Kod = txtKod.Text,
                AracId = Convert.ToInt64(txtArac.Id),
                PersonelId = Convert.ToInt64(txtPersonel.Id),
                OdemeMetoduId = Convert.ToInt64(txtOdemeMetodu.Id),
                KasaId = Convert.ToInt64(txtKasa.Id),
                Tarih = txtTarih.DateTime,
                Litre = txtLitre.Value,
                Tutar = txtTutar.Value,
                YakitCinsi = txtYakitCinsi.Text.GetEnum<YakitCinsi>(),
                BelgeNo = txtBelgeNo.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };
            ButonEnabledDurumu();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit))
                return;

            using (var sec = new SelectFunctions())
                if (sender == txtArac)
                    sec.Sec(txtArac);
                else if (sender == txtKasa)
                    sec.Sec(txtKasa);
                else if (sender == txtPersonel)
                    sec.Sec(txtPersonel);
                else if (sender == txtOdemeMetodu)
                    sec.Sec(txtOdemeMetodu);
        }
    }
}