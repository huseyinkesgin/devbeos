using AdavancedSoftware.Model.Dto;
using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.Common.Functions;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftweare.BusinessLayer.General;
using DevExpress.XtraEditors;
using System;

namespace AdvancedSoftware.UserInterface.Win.Forms.PersonelHarcamaForms
{
    public partial class PersonelHarcamaEditForm : BaseEditForm
    {
        public PersonelHarcamaEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new PersonelHarcamaBll(myDataLayoutControl);
            txtBelgeTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<BelgeTuru>());
           
            BaseKartTuru = KartTuru.PersonelHarcama;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new PersonelHarcamaS() : ((PersonelHarcamaBll)Bll).Single(FilterFunctions.Filter<PersonelHarcama>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert)
                return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((PersonelHarcamaBll)Bll).YeniKodVer();
            txtPersonel.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (PersonelHarcamaS)OldEntity;

            txtKod.Text = entity.Kod;
            txtPersonel.Id = entity.PersonelId;
            txtPersonel.Text = entity.PersonelAdi;
            txtOdemeMetodu.Id = entity.OdemeMetoduId;
            txtOdemeMetodu.Text = entity.OdemeMetoduAdi;
            txtKasa.Id = entity.KasaId;
            txtKasa.Text = entity.KasaAdi;
            txtKategori.Id = entity.KategoriId;
            txtKategori.Text = entity.KategoriAdi;
            txtTarih.DateTime = entity.Tarih;
            txtTutar.Value = entity.Tutar;
            txtBelgeTuru.SelectedItem = entity.BelgeTuru.ToName();
            txtBelgeNo.Text = entity.BelgeNo;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new PersonelHarcama
            {
                Id = Id,
                Kod = txtKod.Text,
                PersonelId = Convert.ToInt64(txtPersonel.Id),
                OdemeMetoduId = Convert.ToInt64(txtOdemeMetodu.Id),
                KasaId = Convert.ToInt64(txtKasa.Id),
                KategoriId = Convert.ToInt64(txtKategori.Id),
                Tarih = txtTarih.DateTime,
                Tutar = txtTutar.Value,
                BelgeTuru = txtBelgeTuru.Text.GetEnum<BelgeTuru>(),
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
                if (sender == txtPersonel)
                    sec.Sec(txtPersonel);
                else if (sender == txtKasa)
                    sec.Sec(txtKasa);
                else if (sender == txtOdemeMetodu)
                    sec.Sec(txtOdemeMetodu);
                else if (sender == txtKategori)
                    sec.Sec(txtKategori, KartTuru.PersonelHarcama);
        }

      
    }
}