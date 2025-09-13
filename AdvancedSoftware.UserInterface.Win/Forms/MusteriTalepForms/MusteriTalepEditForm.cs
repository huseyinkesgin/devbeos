using AdavancedSoftware.Model.Dto;
using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.Common.Functions;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftweare.BusinessLayer.General;
using DevExpress.XtraEditors;
using System;

namespace AdvancedSoftware.UserInterface.Win.Forms.MusteriTalepForms
{
    public partial class MusteriTalepEditForm : BaseEditForm
    {
        public MusteriTalepEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl1;
            Bll = new MusteriTalepBll(myDataLayoutControl1);

            // Enum değerlerini ComboBox'lara yükle
            txtRedNedeni.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<RedNedeni>());
            txtTalepIptalNedeni.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<TalepIptalNedeni>());
            txtTalepDurumu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<TalepDurumu>());
            txtTalepTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<TalepTuru>());
            txtOncelikSeviyesi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<OncelikSeviyesi>());

            BaseKartTuru = KartTuru.MusteriTalep;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new MusteriTalepS() : ((MusteriTalepBll)Bll).Single(FilterFunctions.Filter<MusteriTalep>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert)
                return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            //txtKod.Text = ((MusteriTalepBll)Bll).YeniKodVer();
            txtTalepBasligi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (MusteriTalepS)OldEntity;

            //txtKod.Text = entity.Kod;
            txtTalepBasligi.Text = entity.TalepBasligi;
            txtMusteri.Id = entity.MusteriId;
            txtMusteri.Text = entity.MusteriAdi + " " + entity.MusteriSoyadi;
            txtTalepTarihi.DateTime = entity.TalepTarihi;
            txtSorumluPersonel.Id = entity.SorumluPersonelId;
            txtSorumluPersonel.Text = entity.SorumluPersonelAdi;

            // Lokasyon bilgileri
            txtIl.Id = entity.IlId ?? 0;
            txtIl.Text = entity.IlAdi;
            txtIlce.Id = entity.IlceId ?? 0;
            txtIlce.Text = entity.IlceAdi;
            txtMahalle.Id = entity.MahalleId ?? 0;
            txtMahalle.Text = entity.MahalleAdi;

            // İlişkili veriler
            txtPortfoy.Id = entity.PortfoyId ?? 0;
            txtPortfoy.Text = entity.PortfoyNo;
            txtHizmet.Id = entity.HizmetId ?? 0;
            txtHizmet.Text = entity.HizmetAdi;

            // Bütçe
            txtMinBütce.Value = entity.MinBütce ?? 0;
            txtMaxBütce.Value = entity.MaxBütce ?? 0;

            // Metrekare
            txtMinMetrekare.Value = entity.MinMetrekare ?? 0;
            txtMaxMetrekare.Value = entity.MaxMetrekare ?? 0;

            // Tarihler
            txtTalepEdilecekTarih.DateTime = entity.TalepEdilecekTarih ?? DateTime.Now;
            txtTamamlanmaTarihi.DateTime = entity.TamamlanmaTarihi ?? DateTime.Now;

            // Notlar ve detaylar
            txtTalepDetayi.Text = entity.TalepDetayi;
            txtMusteriNotlari.Text = entity.MusteriNotlari;
            txtPersonelNotlari.Text = entity.PersonelNotlari;

            // Red ve iptal nedenleri
            if (entity.RedNedeni.HasValue)
                txtRedNedeni.SelectedItem = entity.RedNedeni.Value.ToName();
            if (entity.IptalNedeni.HasValue)
                txtTalepIptalNedeni.SelectedItem = entity.IptalNedeni.Value.ToName();
            if (entity.TalepDurumu != TalepDurumu.YeniTalep)
                txtTalepDurumu.SelectedItem = entity.TalepDurumu.ToName();
            if (entity.OncelikSeviyesi != OncelikSeviyesi.Normal)
                txtOncelikSeviyesi.SelectedItem = entity.OncelikSeviyesi.ToName();
            if (entity.TalepTuru != TalepTuru.GayrimenkulSatis)
                txtTalepTuru.SelectedItem = entity.TalepTuru.ToName();

            // Özel kodlar
            txtOzelKod1.Id = entity.OzelKod1Id ?? 0;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id ?? 0;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtOzelKod3.Id = entity.OzelKod3Id ?? 0;
            txtOzelKod3.Text = entity.OzelKod3Adi;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new MusteriTalep
            {
                Id = Id,
                //Kod = txtKod.Text,
                TalepBasligi = txtTalepBasligi.Text,
                MusteriId = Convert.ToInt64(txtMusteri.Id),
                TalepTarihi = txtTalepTarihi.DateTime,
                SorumluPersonelId = Convert.ToInt64(txtSorumluPersonel.Id),

                IptalNedeni = string.IsNullOrEmpty(txtTalepIptalNedeni.Text) ? (TalepIptalNedeni?)null : txtTalepIptalNedeni.Text.GetEnum<TalepIptalNedeni>(),
                RedNedeni = string.IsNullOrEmpty(txtRedNedeni.Text) ? (RedNedeni?)null : txtRedNedeni.Text.GetEnum<RedNedeni>(),
                TalepDurumu = string.IsNullOrEmpty(txtTalepDurumu.Text) ? TalepDurumu.YeniTalep : txtTalepDurumu.Text.GetEnum<TalepDurumu>(),
                OncelikSeviyesi = string.IsNullOrEmpty(txtOncelikSeviyesi.Text) ? OncelikSeviyesi.Normal : txtOncelikSeviyesi.Text.GetEnum<OncelikSeviyesi>(),
                TalepTuru = string.IsNullOrEmpty(txtTalepTuru.Text) ? TalepTuru.GayrimenkulSatis : txtTalepTuru.Text.GetEnum<TalepTuru>(),

                // Lokasyon bilgileri
                IlId = Convert.ToInt64(txtIl.Id) == 0 ? (long?)null : Convert.ToInt64(txtIl.Id),
                IlceId = Convert.ToInt64(txtIlce.Id) == 0 ? (long?)null : Convert.ToInt64(txtIlce.Id),
                MahalleId = Convert.ToInt64(txtMahalle.Id) == 0 ? (long?)null : Convert.ToInt64(txtMahalle.Id),

                // İlişkili veriler
                PortfoyId = Convert.ToInt64(txtPortfoy.Id) == 0 ? (long?)null : Convert.ToInt64(txtPortfoy.Id),
                HizmetId = Convert.ToInt64(txtHizmet.Id) == 0 ? (long?)null : Convert.ToInt64(txtHizmet.Id),

                // Bütçe
                MinBütce = txtMinBütce.Value == 0 ? (decimal?)null : txtMinBütce.Value,
                MaxBütce = txtMaxBütce.Value == 0 ? (decimal?)null : txtMaxBütce.Value,

                // Metrekare
                MinMetrekare = txtMinMetrekare.Value == 0 ? (decimal?)null : txtMinMetrekare.Value,
                MaxMetrekare = txtMaxMetrekare.Value == 0 ? (decimal?)null : txtMaxMetrekare.Value,

                // Tarihler
                TalepEdilecekTarih = txtTalepEdilecekTarih.DateTime == DateTime.MinValue ? (DateTime?)null : txtTalepEdilecekTarih.DateTime,
                TamamlanmaTarihi = txtTamamlanmaTarihi.DateTime == DateTime.MinValue ? (DateTime?)null : txtTamamlanmaTarihi.DateTime,

                // Notlar ve detaylar
                TalepDetayi = txtTalepDetayi.Text,
                MusteriNotlari = txtMusteriNotlari.Text,
                PersonelNotlari = txtPersonelNotlari.Text,

                // Özel kodlar
                OzelKod1Id = Convert.ToInt64(txtOzelKod1.Id) == 0 ? (long?)null : Convert.ToInt64(txtOzelKod1.Id),
                OzelKod2Id = Convert.ToInt64(txtOzelKod2.Id) == 0 ? (long?)null : Convert.ToInt64(txtOzelKod2.Id),
                OzelKod3Id = Convert.ToInt64(txtOzelKod3.Id) == 0 ? (long?)null : Convert.ToInt64(txtOzelKod3.Id),
            };
            ButonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((MusteriTalepBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod);
        }

        protected override bool EntityUpdate()
        {
            return ((MusteriTalepBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod);
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit))
                return;

            using (var sec = new SelectFunctions())
                if (sender == txtMusteri)
                    sec.Sec(txtMusteri);
                else if (sender == txtSorumluPersonel)
                    sec.Sec(txtSorumluPersonel);
                else if (sender == txtIl)
                    sec.Sec(txtIl);
                else if (sender == txtIlce)
                    sec.Sec(txtIlce, txtIl);
                else if (sender == txtMahalle)
                    sec.Sec(txtMahalle, txtIlce);
                else if (sender == txtPortfoy)
                    sec.Sec(txtPortfoy);
                else if (sender == txtHizmet)
                    sec.Sec(txtHizmet);
                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.OzelKod);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.OzelKod);
                else if (sender == txtOzelKod3)
                    sec.Sec(txtOzelKod3, KartTuru.OzelKod);
        }

        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender == txtIl)
            {
                txtIl.ControlEnabledChange(txtIlce);
                txtIl.ControlEnabledChange(txtMahalle);
            }
            else if (sender == txtIlce)
            {
                txtIlce.ControlEnabledChange(txtMahalle);
            }
        }

        private void groupControl1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }
    }
}