using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.AltyapiForms;
using AdvancedSoftware.UserInterface.Win.Forms.AracForms;
using AdvancedSoftware.UserInterface.Win.Forms.AracSinifForms;
using AdvancedSoftware.UserInterface.Win.Forms.BankaForms;
using AdvancedSoftware.UserInterface.Win.Forms.BankaHesapForms;
using AdvancedSoftware.UserInterface.Win.Forms.DepartmanForms;
using AdvancedSoftware.UserInterface.Win.Forms.EmsalForms;
using AdvancedSoftware.UserInterface.Win.Forms.FirmaForms;
using AdvancedSoftware.UserInterface.Win.Forms.GabariForms;
using AdvancedSoftware.UserInterface.Win.Forms.HizmetForms;
using AdvancedSoftware.UserInterface.Win.Forms.HizmetTuruForms;
using AdvancedSoftware.UserInterface.Win.Forms.ImarBilgisiForms;
using AdvancedSoftware.UserInterface.Win.Forms.IndirimForms;
using AdvancedSoftware.UserInterface.Win.Forms.IndirimTuruForms;
using AdvancedSoftware.UserInterface.Win.Forms.IptalNedeniForms;
using AdvancedSoftware.UserInterface.Win.Forms.IsıtmaForms;
using AdvancedSoftware.UserInterface.Win.Forms.IsyeriForms;
using AdvancedSoftware.UserInterface.Win.Forms.KasaForms;
using AdvancedSoftware.UserInterface.Win.Forms.MarkaForms;
using AdvancedSoftware.UserInterface.Win.Forms.MusteriBilgiForms;
using AdvancedSoftware.UserInterface.Win.Forms.MusteriForms;
using AdvancedSoftware.UserInterface.Win.Forms.MusteriGrupForms;
using AdvancedSoftware.UserInterface.Win.Forms.OdemeTuru;
using AdvancedSoftware.UserInterface.Win.Forms.OfisForms;
using AdvancedSoftware.UserInterface.Win.Forms.PersonelForms;
using AdvancedSoftware.UserInterface.Win.Forms.PersonelHarcamaForms;
using AdvancedSoftware.UserInterface.Win.Forms.PortfoyTipiForms;
using AdvancedSoftware.UserInterface.Win.Forms.SiparisForms.IlForms;
using AdvancedSoftware.UserInterface.Win.Forms.TapuTipiForms;
using AdvancedSoftware.UserInterface.Win.Forms.UnvanForms;
using AdvancedSoftware.UserInterface.Win.Forms.YakitHarcamaForms;
using AdvancedSoftware.UserInterface.Win.Show;
using DevExpress.XtraBars;
using System;

namespace AdvancedSoftware.UserInterface.Win.GenelForms
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
       public static long DonemId = 1;
        public static string DonemAdi = "2024";
       public static long SubeId = 1;
        public static string SubeAdi = "Merkez";

        //public static DateTime YerGostermeTarihi = new DateTime(2024,12,20);

        public AnaForm()
        {
            InitializeComponent();
            EventsLoad();
        }

        private void EventsLoad()
        {
            foreach (var item in ribbonControl.Items)
            {
                switch (item)
                {
                    case BarButtonItem btn:
                        btn.ItemClick += Butonlar_ItemClick;
                        break;
                }
            }
        }

        private void Butonlar_ItemClick(object sender, ItemClickEventArgs e)
        {


            if (e.Item == btnOfis)
                ShowListForms<OfisListForm>.ShowListForm(KartTuru.Ofis);

            if (e.Item == btnIl)
                ShowListForms<IlListForm>.ShowListForm(KartTuru.Il);
            if (e.Item == btnMusteriBilgi)
                ShowListForms<MusteriBilgiListForm>.ShowListForm(KartTuru.MusteriBilgi);
            if (e.Item == btnIptalNedeni)
                ShowListForms<IptalNedeniListForm>.ShowListForm(KartTuru.IptalNedeni);
            if (e.Item == btnPortfoyTipi)
                ShowListForms<PortfoyTipiListForm>.ShowListForm(KartTuru.PortfoyTipi);
            if (e.Item == btnEmsal)
                ShowListForms<EmsalListForm>.ShowListForm(KartTuru.Emsal);
            if (e.Item == btnGabari)
                ShowListForms<GabariListForm>.ShowListForm(KartTuru.Gabari);
            if (e.Item == btnIsitma)
                ShowListForms<IsitmaListForm>.ShowListForm(KartTuru.Isitma);

            if (e.Item == btnDepartman)
                ShowListForms<DepartmanListForm>.ShowListForm(KartTuru.Departman);
            if (e.Item == btnUnvan)
                ShowListForms<UnvanListForm>.ShowListForm(KartTuru.Unvan);
            if (e.Item == btnAltyapi)
                ShowListForms<AltyapiListForm>.ShowListForm(KartTuru.Altyapi);
            if (e.Item == btnKasa)
                ShowListForms<KasaListForm>.ShowListForm(KartTuru.Kasa);
            if (e.Item == btnBanka)
                ShowListForms<BankaListForm>.ShowListForm(KartTuru.Banka);
            if (e.Item == btnBankaHesap)
                ShowListForms<BankaHesapListForm>.ShowListForm(KartTuru.BankaHesap);
            if (e.Item == btnFirma)
                ShowListForms<FirmaListForm>.ShowListForm(KartTuru.Firma);
            if (e.Item == btnMarka)
                ShowListForms<MarkaListForm>.ShowListForm(KartTuru.Marka);
            if (e.Item == btnMusteri)
                ShowListForms<MusteriListForm>.ShowListForm(KartTuru.Musteri);
            if (e.Item == btnPersonel)
                ShowListForms<PersonelListForm>.ShowListForm(KartTuru.Personel);
            if (e.Item == btnIsyeri)
                ShowListForms<IsyeriListForm>.ShowListForm(KartTuru.Isyeri);
            if (e.Item == btnIsyeriTipi)
                ShowListForms<IsyeriTipiListForm>.ShowListForm(KartTuru.IsyeriTipi);
            if (e.Item == btnAracSinif)
                ShowListForms<AracSinifListForm>.ShowListForm(KartTuru.AracSinif);
            if (e.Item == btnArac)
                ShowListForms<AracListForm>.ShowListForm(KartTuru.Arac);
            if (e.Item == btnOdemeMetodu)
                ShowListForms<OdemeMetoduList>.ShowListForm(KartTuru.OdemeMetodu);
            if (e.Item == btnPersonelHarcama)
                ShowListForms<PersonelHarcamaListForm>.ShowListForm(KartTuru.PersonelHarcama);
            if (e.Item == btnYakitHarcama)
                ShowListForms<YakitHarcamaListForm>.ShowListForm(KartTuru.YakitHarcama);
            if (e.Item == btnHizmetTuru)
                ShowListForms<HizmetTuruListForm>.ShowListForm(KartTuru.HizmetTuru);
            if (e.Item == btnHizmet)
                ShowListForms<HizmetListForm>.ShowListForm(KartTuru.Hizmet);
            if (e.Item == btnIndirimTuru)
                ShowListForms<IndirimTuruListForm>.ShowListForm(KartTuru.IndirimTuru);
            if (e.Item == btnIndirim)
                ShowListForms<IndirimListForm>.ShowListForm(KartTuru.Indirim);
            {
                
            }


        }

       
    }
}