using AdavancedSoftware.Model.Dto;
using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.Common.Functions;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.GenelForms;
using AdvancedSoftweare.BusinessLayer.General;
using DevExpress.XtraEditors;
using System;

namespace AdvancedSoftware.UserInterface.Win.Forms.BankaHesapForms
{
    public partial class BankaHesapEditForm : BaseEditForm
    {
        public BankaHesapEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new BankaHesapBll(myDataLayoutControl);
            txtHesapTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<BankaHesapTuru>());
            BaseKartTuru = KartTuru.BankaHesap;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new BankaHesapS() : ((BankaHesapBll)Bll).Single(FilterFunctions.Filter<BankaHesap>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert)
                return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((BankaHesapBll)Bll).YeniKodVer();
            txtHesapAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (BankaHesapS)OldEntity;

            txtKod.Text = entity.Kod;
            txtHesapAdi.Text = entity.HesapAdi;
            txtHesapTuru.SelectedItem = entity.HesapTuru.ToName();
            txtBanka.Id = entity.BankaId;
            txtBanka.Text = entity.BankaAdi;
            txtBankaSube.Id = entity.BankaSubeId;
            txtBankaSube.Text = entity.BankaSubeAdi;
            txtHesapAcilisTarihi.DateTime = entity.HesapAcilisTarihi;
            txtMusteriNo.Text = entity.MusteriNo;
            txtHesapNo.Text = entity.HesapNo;
            txtIbanNo.Text = entity.IbanNo;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new BankaHesap
            {
                Id = Id,
                Kod = txtKod.Text,
                HesapAdi = txtHesapAdi.Text,
                HesapTuru = txtHesapTuru.Text.GetEnum<BankaHesapTuru>(),
                BankaId = Convert.ToInt64(txtBanka.Id),
                BankaSubeId = Convert.ToInt64(txtBankaSube.Id),
                HesapAcilisTarihi = txtHesapAcilisTarihi.DateTime.Date,
                MusteriNo = txtMusteriNo.Text,
                HesapNo = txtHesapNo.Text,
                IbanNo = txtIbanNo.Text,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                Durum = tglDurum.IsOn,
                Aciklama = txtAciklama.Text
            };

            ButonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((BankaHesapBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod);
        }

        protected override bool EntityUpdate()
        {
            return ((BankaHesapBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod);
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit))
                return;

            using (var sec = new SelectFunctions())
                if (sender == txtBanka)
                    sec.Sec(txtBanka);
                else if (sender == txtBankaSube)
                    sec.Sec(txtBankaSube, txtBanka);
                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.BankaHesap);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.BankaHesap);
        }

        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtBanka)
                return;
            txtBanka.ControlEnabledChange(txtBankaSube);
        }

        //protected override void Control_EditValueChanged(object sender, EventArgs e)
        //{
        //    if (sender != txtBanka)
        //        return;
        //    txtBankaSube.Id = null;
        //    txtBankaSube.Text = string.Empty;
        //}


        /// <summary>
        /// Hesap türüne göre kontrollerin aktif pasif olmasını sağlar.
        /// burada sadece deneme amaçlı yapılmıştır. daha sonradan düzeltilecektir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!(sender is ComboBoxEdit edt))
                return;

            var hesapTuru = edt.Text.GetEnum<BankaHesapTuru>();

            if (hesapTuru == BankaHesapTuru.VadesizMevduatHesabi || hesapTuru == BankaHesapTuru.VadeliMevduatHesabi)
            {
                txtHesapAcilisTarihi.Enabled = true;
                lblMusteriNo.Enabled = true;
                txtHesapNo.Enabled = true;
                txtIbanNo.Enabled = true;
            }
            else
            {
                txtHesapAcilisTarihi.Enabled = false;
                lblMusteriNo.Enabled = false;
                txtHesapNo.Enabled = false;
                txtIbanNo.Enabled = false;
            }

        }
    }
}