using AdavancedSoftware.Model.Dto;
using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.Common.Functions;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftweare.BusinessLayer.General;
using DevExpress.XtraEditors;
using System;

namespace AdvancedSoftware.UserInterface.Win.Forms.MusteriForms
{
    public partial class MusteriEditForm : BaseEditForm
    {
        public MusteriEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new MusteriBll(myDataLayoutControl);
            txtMusteriTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<MusteriTuru>());
            BaseKartTuru = KartTuru.Musteri;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new MusteriS() : ((MusteriBll)Bll).Single(FilterFunctions.Filter<Musteri>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert)
                return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((MusteriBll)Bll).YeniKodVer();
            txtAd.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (MusteriS)OldEntity;

            txtKod.Text = entity.Kod;
            txtMusteriTuru.SelectedItem = entity.MusteriTuru.ToName();
            txtKategori.Id = entity.KategoriId;
            txtKategori.Text = entity.KategoriAdi;
            txtAd.Text = entity.Ad;
            txtSoyad.Text = entity.Soyad;
            txtTcKimlikNo.Text = entity.TcKimlikNo;
            txtEposta.Text = entity.Eposta;
            txtTelefon.Text = entity.Telefon;
            txtIl.Id = entity.IlId;
            txtIl.Text = entity.IlAdi;
            txtIlce.Id = entity.IlceId;
            txtIlce.Text = entity.IlceAdi;
            txtMahalle.Id = entity.MahalleId;
            txtMahalle.Text = entity.MahalleAdi;
            txtAdres.Text = entity.Adres;
            txtFirma.Id = entity.FirmaId;
            txtFirma.Text = entity.FirmaAdi;
            txtWebsitesi.Text = entity.Websitesi;
            txtFacebook.Text = entity.Facebook;
            txtTwitter.Text = entity.Twitter;
            txtInstagram.Text = entity.Instagram;
            txtLinkedin.Text = entity.Linkedin;
            txtYoutube.Text = entity.Youtube;
            txtTiktok.Text = entity.Tiktok;
            txtVk.Text = entity.VK;   
            txtAciklama.Text = entity.Aciklama;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtOzelKod3.Id = entity.OzelKod3Id;
            txtOzelKod3.Text = entity.OzelKod3Adi;
            txtOzelKod4.Id = entity.OzelKod4Id;
            txtOzelKod4.Text = entity.OzelKod4Adi;
            txtOzelKod5.Id = entity.OzelKod5Id;
            txtOzelKod5.Text = entity.OzelKod5Adi;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Musteri
            {
                Id = Id,
                Kod = txtKod.Text,
                MusteriTuru = txtMusteriTuru.Text.GetEnum<MusteriTuru>(),
                KategoriId = txtKategori.Id,
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                TcKimlikNo = txtTcKimlikNo.Text,
                Eposta = txtEposta.Text,
                Telefon = txtTelefon.Text,
                IlId = Convert.ToInt64(txtIl.Id),
                IlceId = Convert.ToInt64(txtIlce.Id),
                MahalleId = Convert.ToInt64(txtMahalle.Id),
                Adres = txtAdres.Text,
                FirmaId = txtFirma.Id,
                Websitesi = txtWebsitesi.Text,
                Facebook = txtFacebook.Text,
                Twitter = txtTwitter.Text,
                Instagram = txtInstagram.Text,
                Linkedin = txtLinkedin.Text,
                Youtube = txtYoutube.Text,
                Tiktok = txtTiktok.Text,
                VK = txtVk.Text,
                Aciklama = txtAciklama.Text,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                OzelKod3Id = txtOzelKod3.Id,
                OzelKod4Id = txtOzelKod4.Id,
                OzelKod5Id = txtOzelKod5.Id,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((MusteriBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod);
        }

        protected override bool EntityUpdate()
        {
            return ((MusteriBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod);
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
                else if (sender == txtMahalle)
                    sec.Sec(txtMahalle, txtIlce);
                else if (sender == txtKategori)
                    sec.Sec(txtKategori, KartTuru.Musteri);
                else if (sender == txtFirma)
                    sec.Sec(txtFirma, KartTuru.Musteri);
                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Musteri);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Musteri);
                else if (sender == txtOzelKod3)
                    sec.Sec(txtOzelKod3, KartTuru.Musteri);
                else if (sender == txtOzelKod4)
                    sec.Sec(txtOzelKod4, KartTuru.Musteri);
                else if (sender == txtOzelKod5)
                    sec.Sec(txtOzelKod5, KartTuru.Musteri);
        }

        protected override void Control_EnabledChange(object sender, EventArgs e)
        {

            if (!IsLoaded)
                return;
            if (sender != txtIl)
                return;
            txtIl.ControlEnabledChange(txtIlce);
        }


        /// <summary>
        /// sadece kurumsal müşteri için firma adı alanını aktif eder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!(sender is ComboBoxEdit edt))
                return;

            var musteriTuru = edt.Text.GetEnum<MusteriTuru>();

            if (musteriTuru == MusteriTuru.Kurumsal)
            {
                txtFirma.Enabled = true;
            }
            else
            {
                txtFirma.Enabled = false;
            }

        }
    }
}