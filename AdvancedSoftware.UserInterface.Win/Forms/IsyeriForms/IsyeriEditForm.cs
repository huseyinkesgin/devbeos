using AdavancedSoftware.Model.Dto;
using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.Common.Functions;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftweare.BusinessLayer.General;
using DevExpress.XtraEditors;
using System;

namespace AdvancedSoftware.UserInterface.Win.Forms.IsyeriForms
{
    public partial class IsyeriEditForm : BaseEditForm
    {
        public IsyeriEditForm()
        {
            
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new PersonelBll(myDataLayoutControl);
            txtPortfoyTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<PortfoyTuru>());
            txtVincVarmi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<VincVarmi>());
            txtYapininDurumu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YapininDurumu>());
            txtKiraciVarmi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KiraciVarmi>());
            txtKrediyeUygunluk.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KrediyeUygunluk>());
            txtImarDurumu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<ImarDurumu>());
            txtKullanimDurumu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KullanimDurumu>());
            txtTapuTipi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<TapuTipi>());
            txtYetkiliOfis.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YetkiliOfis>());
            txtPortfoyDurumu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<PortfoyDurumu>());
            BaseKartTuru = KartTuru.Isyeri;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new IsyeriS() : ((IsyeriBll)Bll).Single(FilterFunctions.Filter<Isyeri>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert)
                return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((PersonelBll)Bll).YeniKodVer();
            txtUcret.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (PersonelS)OldEntity;

            txtKod.Text = entity.Kod;
            txtCinsiyet.SelectedItem = entity.Cinsiyet.ToName();

            txtAd.Text = entity.Ad;
            txtSoyad.Text = entity.Soyad;
            txtTcKimlikNo.Text = entity.TcKimlikNo;
            txtDogumTarihi.DateTime = entity.DogumTarihi;
            txtDogumYeri.Text = entity.DogumYeri;
            txtBabaAdi.Text = entity.BabaAdi;
            txtAnneAdi.Text = entity.AnneAdi;
            txtMedeniDurum.SelectedItem = entity.MedeniDurum.ToName();
            txtCocukVarmi.SelectedItem = entity.CocukVarmi.ToName();
            txtCocukSayisi.Value = entity.CocukSayisi;
            txtKanGrubu.SelectedItem = entity.KanGrubu.ToName();
            txtEposta.Text = entity.Eposta;
            txtTelefon.Text = entity.Telefon;
            txtIl.Id = entity.IlId;
            txtIl.Text = entity.IlAdi;
            txtIlce.Id = entity.IlceId;
            txtIlce.Text = entity.IlceAdi;
            txtAdres.Text = entity.Adres;
            txtWebsitesi.Text = entity.Websitesi;
            txtFacebook.Text = entity.Facebook;
            txtTwitter.Text = entity.Twitter;
            txtInstagram.Text = entity.Instagram;
            txtLinkedin.Text = entity.Linkedin;
            txtYoutube.Text = entity.Youtube;
            txtTiktok.Text = entity.Tiktok;
            txtVk.Text = entity.VK;
            txtDepartman.Id = entity.DepartmanId;
            txtDepartman.Text = entity.DepartmanAdi;
            txtUnvan.Id = entity.UnvanId;
            txtUnvan.Text = entity.UnvanAdi;
            txtBanka.Id = entity.BankaId;
            txtBanka.Text = entity.BankaAdi;
            txtBankaSube.Id = entity.SubeId;
            txtBankaSube.Text = entity.SubeAdi;
            txtIban.Text = entity.IBAN;
            txtPersonelDurumu.SelectedItem = entity.PersonelDurumu.ToName();
            txtIseGirisTarihi.DateTime = entity.IseGirisTarihi;
            txtIstenCikisTarihi.EditValue = entity.IstenCikisTarihi;
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
            CurrentEntity = new Personel
            {
                Id = Id,
                Kod = txtKod.Text,
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                TcKimlikNo = txtTcKimlikNo.Text,
                Cinsiyet = txtCinsiyet.Text.GetEnum<Cinsiyet>(),
                DogumTarihi = txtDogumTarihi.DateTime,
                DogumYeri = txtDogumYeri.Text,
                BabaAdi = txtBabaAdi.Text,
                AnneAdi = txtAnneAdi.Text,
                MedeniDurum = txtMedeniDurum.Text.GetEnum<MedeniDurum>(),
                CocukVarmi = txtCocukVarmi.Text.GetEnum<CocukVarmi>(),
                CocukSayisi = Convert.ToInt32(txtCocukSayisi.Value),
                KanGrubu = txtKanGrubu.Text.GetEnum<KanGrubu>(),
                Eposta = txtEposta.Text,
                Telefon = txtTelefon.Text,
                IlId = Convert.ToInt64(txtIl.Id),
                IlceId = Convert.ToInt64(txtIlce.Id),
                Adres = txtAdres.Text,
                Websitesi = txtWebsitesi.Text,
                Facebook = txtFacebook.Text,
                Twitter = txtTwitter.Text,
                Instagram = txtInstagram.Text,
                Linkedin = txtLinkedin.Text,
                Youtube = txtYoutube.Text,
                Tiktok = txtTiktok.Text,
                VK = txtVk.Text,
                DepartmanId = txtDepartman.Id,
                UnvanId = txtUnvan.Id,
                BankaId = txtBanka.Id,
                SubeId = txtBankaSube.Id,
                IBAN = txtIban.Text,
                PersonelDurumu = txtPersonelDurumu.Text.GetEnum<PersonelDurumu>(),
                IseGirisTarihi = txtIseGirisTarihi.DateTime,
                IstenCikisTarihi = txtIstenCikisTarihi.DateTime,
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
            return ((PersonelBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod);
        }

        protected override bool EntityUpdate()
        {
            return ((PersonelBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod);
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
                else if (txtDogumYeri == sender)
                    sec.Sec(txtDogumYeri);
                else if (sender == txtBanka)
                    sec.Sec(txtBanka);
                else if (sender == txtBankaSube)
                    sec.Sec(txtBankaSube, txtBanka);
                else if (sender == txtDepartman)
                    sec.Sec(txtDepartman);
                else if (sender == txtUnvan)
                    sec.Sec(txtUnvan);
                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Personel);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Personel);
                else if (sender == txtOzelKod3)
                    sec.Sec(txtOzelKod3, KartTuru.Personel);
                else if (sender == txtOzelKod4)
                    sec.Sec(txtOzelKod4, KartTuru.Personel);
                else if (sender == txtOzelKod5)
                    sec.Sec(txtOzelKod5, KartTuru.Personel);
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

            var medeniDurumu = edt.Text.GetEnum<MedeniDurum>();

            if (medeniDurumu == MedeniDurum.Bekar)
            {
                txtCocukVarmi.SelectedItem = CocukVarmi.Yok.ToName();
                txtCocukVarmi.Enabled = false;
                txtCocukSayisi.Enabled = false;
            }
            else
            {
                txtCocukVarmi.Enabled = true;
                txtCocukSayisi.Enabled = true;
            }

        }

    }
}