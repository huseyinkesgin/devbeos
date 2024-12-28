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
            txtKod.Text = ((IsyeriBll)Bll).YeniKodVer();
            txtUcret.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (IsyeriS)OldEntity;

            txtKod.Text = entity.Kod;
            txtIsyeriTipi.Id = entity.IsyeriTipiId;
            txtIsyeriTipi.Text = entity.IsyeriTipiAdi;
            txtPortfoyTuru.SelectedItem = entity.PortfoyTuru.ToName();
            txtImarDurumu.SelectedItem = entity.ImarDurumu.ToName();
            txtBaslik.Text = entity.Baslik;
            txtUcret.Value = entity.Ucret;
            txtAcikAlan.Value = entity.AcikAlan;
            txtKapaliAlan.Value = entity.KapaliAlan;
            txtIsletmeAlani.Value = entity.IsletmeAlani;
            txtOfisAlani.Value = entity.OfisAlani;
            txtKWAEnerji.Value = entity.KWAEnerji;
            txtVincVarmi.SelectedItem = entity.VincVarmi.ToName();
            txtVincAciklama.Text = entity.VincAciklama;
            txtKatSayisi.Value = entity.Katsayisi;
            txtM2TasimaKapasitesi.Text = entity.M2TasimaKapasitesi;
            txtGirisYuksekligi.Value = entity.GirisYuksekligi;
            txtYapimYili.Value = entity.YapimYili;
            txtKiraciVarmi.SelectedItem = entity.KiraciVarmi.ToName();
            txtIsitma.Id = entity.IsitmaId;
            txtIsitma.Text = entity.IsitmaAdi;
            txtYapininDurumu.SelectedItem = entity.YapininDurumu.ToName();
            txtKullanimDurumu.SelectedItem = entity.KullanimDurumu.ToName();
            txtKrediyeUygunluk.SelectedItem = entity.KrediyeUygunluk.ToName();
            txtTapuTipi.SelectedItem = entity.IsyeriTapuTipi.ToName();
            txtTasinmazNo.Text = entity.TasinmazNo;
            txtIl.Id = entity.IlId;
            txtIl.Text = entity.IlAdi;
            txtIlce.Id = entity.IlceId;
            txtIlce.Text = entity.IlceAdi;
            txtMahalle.Text = entity.Mahalle;
            txtAda.Value = entity.Ada;
            txtParsel.Value = entity.Parsel;
            txtAciklama.Text = entity.Aciklama;
            txtDanisman.Id = entity.DanismanId;
            txtDanisman.Text = entity.DanismanAdi;
            txtMusteri.Id = entity.MusteriId;
            txtMusteri.Text = entity.MusteriAdi;
            txtIlanVarmi.SelectedItem = entity.IlanVarmi.ToName();
            txtSahibindenID.Text = entity.Sahibinden;
            txtSahibindenLink.Text = entity.SahibindenLink;
            txtHepsiEmlakID.Text = entity.HepsiEmlak;
            txtHepsiEmlakLink.Text = entity.HepsiEmlakLink;
            txtZingatID.Text = entity.Zingat;
            txtZingatLink.Text = entity.ZingatLink;
            txtBuradaYapiID.Text = entity.BuradaYapı;
            txtBuradaYapiLink.Text = entity.BuradaYapıLink;
            txtDepoFabrikaID.Text = entity.DepoFabrika;
            txtDepoFabrikaLink.Text = entity.DepoFabrikaLink;
            //txtUyduGoruntusu.Text = entity.UyduGoruntusu;
            //txtOznitelikGoruntusu.Text = entity.OznitelikGoruntusu;
            //txtImarDurumuGoruntusu.Text = entity.ImarDurumuGoruntusu;
            //txtAutoCadDosyaAdi.Text = entity.AutoCadDosyaAdi;
            //txtAutoCadDosyaYolu.Text = entity.AutoCadDosyaYolu;
            txtPortfoyDurumu.SelectedItem = entity.PortfoyDurumu.ToName();
            txtYetkiliOfis.SelectedItem = entity.YetkiliOfis.ToName();
            txtKayitTarihi.DateTime = entity.KayitTarihi;
            txtIlanKayitTarihi.EditValue = entity.IlanKayitTarihi;
            txtIlanCikisTarihi.EditValue = entity.IlanCikisTarihi;
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
            CurrentEntity = new Isyeri
            {
                Id = Id,
                Kod = txtKod.Text,
                IsyeriTipiId = Convert.ToInt64(txtIsyeriTipi.Id),
                PortfoyTuru = txtPortfoyTuru.Text.GetEnum<PortfoyTuru>(),
                ImarDurumu = txtImarDurumu.Text.GetEnum<ImarDurumu>(),
                Baslik = txtBaslik.Text,
                Ucret = txtUcret.Value,
                AcikAlan = txtAcikAlan.Value,
                KapaliAlan = txtKapaliAlan.Value,
                IsletmeAlani = txtIsletmeAlani.Value,
                OfisAlani = txtOfisAlani.Value,
                KWAEnerji = Convert.ToInt32(txtKWAEnerji.Value),
                VincVarmi = txtVincVarmi.Text.GetEnum<VincVarmi>(),
                VincAciklama = txtVincAciklama.Text,
                Katsayisi = Convert.ToInt32(txtKatSayisi.Value),
                M2TasimaKapasitesi = txtM2TasimaKapasitesi.Text,
                GirisYuksekligi = Convert.ToInt32(txtGirisYuksekligi.Value),
                YapimYili = Convert.ToInt32(txtYapimYili.Value),
                KiraciVarmi = txtKiraciVarmi.Text.GetEnum<KiraciVarmi>(),
                IsitmaId = Convert.ToInt64(txtIsitma.Id),
                YapininDurumu = txtYapininDurumu.Text.GetEnum<YapininDurumu>(),
                KullanimDurumu = txtKullanimDurumu.Text.GetEnum<KullanimDurumu>(),
                KrediyeUygunluk = txtKrediyeUygunluk.Text.GetEnum <KrediyeUygunluk>(),
                IsyeriTapuTipi = txtTapuTipi.Text.GetEnum<IsyeriTapuTipi>(),
                TasinmazNo = txtTasinmazNo.Text,
                IlId = Convert.ToInt64(txtIl.Id),
                IlceId = Convert.ToInt64(txtIlce.Id),
                Mahalle = txtMahalle.Text,
                Ada = Convert.ToInt32(txtAda.Value),
                Parsel = Convert.ToInt32(txtParsel.Value),
                Aciklama = txtAciklama.Text,
                DanismanId = Convert.ToInt64(txtDanisman.Id),
                MusteriId = Convert.ToInt64(txtMusteri.Id),
                IlanVarmi = txtIlanVarmi.Text.GetEnum<IlanVarmi>(),
                Sahibinden = txtSahibindenID.Text,
                SahibindenLink = txtSahibindenLink.Text,
                HepsiEmlak = txtHepsiEmlakID.Text,
                HepsiEmlakLink = txtHepsiEmlakLink.Text,
                Zingat = txtZingatID.Text,
                ZingatLink = txtZingatLink.Text,
                BuradaYapı = txtBuradaYapiID.Text,
                BuradaYapıLink = txtBuradaYapiLink.Text,
                DepoFabrika = txtDepoFabrikaID.Text,
                DepoFabrikaLink = txtDepoFabrikaLink.Text,
                //UyduGoruntusu = txtUyduGoruntusu.Text,
                //OznitelikGoruntusu = txtOznitelikGoruntusu.Text,
                //ImarDurumuGoruntusu = txtImarDurumuGoruntusu.Text,
                //AutoCadDosyaAdi = txtAutoCadDosyaAdi.Text,
                //AutoCadDosyaYolu = txtAutoCadDosyaYolu.Text,
                PortfoyDurumu = txtPortfoyDurumu.Text.GetEnum<PortfoyDurumu>(),
                YetkiliOfis = txtYetkiliOfis.Text.GetEnum<YetkiliOfis>(),
                KayitTarihi = txtKayitTarihi.DateTime,
                IlanKayitTarihi = txtIlanKayitTarihi.DateTime,
                IlanCikisTarihi = txtIlanCikisTarihi.DateTime,
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
            return ((IsyeriBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod);
        }

        protected override bool EntityUpdate()
        {
            return ((IsyeriBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod);
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
                else if (txtIsyeriTipi == sender)
                    sec.Sec(txtIsyeriTipi);
                else if (txtDanisman == sender)
                    sec.Sec(txtDanisman);
                else if (txtMusteri == sender)
                    sec.Sec(txtMusteri);
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

            var ilanDurumu = edt.Text.GetEnum<IlanVarmi>();

            if (ilanDurumu == IlanVarmi.IlanVar)
            {
                txtIlanKayitTarihi.Enabled = true;
                txtIlanCikisTarihi.Enabled = true;
                txtSahibindenID.Enabled = true;
                txtSahibindenLink.Enabled = true;
                txtHepsiEmlakID.Enabled = true;
                txtHepsiEmlakLink.Enabled = true;
                txtZingatID.Enabled = true;
                txtZingatLink.Enabled = true;
                txtBuradaYapiID.Enabled = true;
                txtBuradaYapiLink.Enabled = true;
                txtDepoFabrikaID.Enabled = true;
                txtDepoFabrikaLink.Enabled = true;

            }
            else
            {
                txtIlanKayitTarihi.Enabled = false;
                txtIlanCikisTarihi.Enabled = false;
                txtSahibindenID.Enabled = false;
                txtSahibindenLink.Enabled = false;
                txtHepsiEmlakID.Enabled = false;
                txtHepsiEmlakLink.Enabled = false;
                txtZingatID.Enabled = false;
                txtZingatLink.Enabled = false;
                txtBuradaYapiID.Enabled = false;
                txtBuradaYapiLink.Enabled = false;
                txtDepoFabrikaID.Enabled = false;
                txtDepoFabrikaLink.Enabled = false;
            }

        }

    }
}