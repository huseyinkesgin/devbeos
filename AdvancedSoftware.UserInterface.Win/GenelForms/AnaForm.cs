using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.AltyapiForms;
using AdvancedSoftware.UserInterface.Win.Forms.BankaForms;
using AdvancedSoftware.UserInterface.Win.Forms.BankaHesapForms;
using AdvancedSoftware.UserInterface.Win.Forms.DepartmanForms;
using AdvancedSoftware.UserInterface.Win.Forms.EmsalForms;
using AdvancedSoftware.UserInterface.Win.Forms.FirmaForms;
using AdvancedSoftware.UserInterface.Win.Forms.GabariForms;
using AdvancedSoftware.UserInterface.Win.Forms.ImarBilgisiForms;
using AdvancedSoftware.UserInterface.Win.Forms.IptalNedeniForms;
using AdvancedSoftware.UserInterface.Win.Forms.IsıtmaForms;
using AdvancedSoftware.UserInterface.Win.Forms.KasaForms;
using AdvancedSoftware.UserInterface.Win.Forms.MarkaForms;
using AdvancedSoftware.UserInterface.Win.Forms.MusteriBilgiForms;
using AdvancedSoftware.UserInterface.Win.Forms.MusteriForms;
using AdvancedSoftware.UserInterface.Win.Forms.MusteriGrupForms;
using AdvancedSoftware.UserInterface.Win.Forms.OfisForms;
using AdvancedSoftware.UserInterface.Win.Forms.PortfoyTipiForms;
using AdvancedSoftware.UserInterface.Win.Forms.SiparisForms.IlForms;
using AdvancedSoftware.UserInterface.Win.Forms.TapuTipiForms;
using AdvancedSoftware.UserInterface.Win.Forms.UnvanForms;
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
            if (e.Item == btnTapuTipi)
                ShowListForms<TapuTipiListForm>.ShowListForm(KartTuru.TapuTipi);
            if (e.Item == btnPortfoyTipi)
                ShowListForms<PortfoyTipiListForm>.ShowListForm(KartTuru.PortfoyTipi);
            if (e.Item == btnImarDurumu)
                ShowListForms<ImarBilgisiListForm>.ShowListForm(KartTuru.ImarDurumu);
            if (e.Item == btnEmsal)
                ShowListForms<EmsalListForm>.ShowListForm(KartTuru.Emsal);
            if (e.Item == btnGabari)
                ShowListForms<GabariListForm>.ShowListForm(KartTuru.Gabari);
            if (e.Item == btnIsitma)
                ShowListForms<IsitmaListForm>.ShowListForm(KartTuru.Isitma);
            if (e.Item == btnMusteriGrup)
                ShowListForms<KategoriListForm>.ShowListForm(KartTuru.Kategori);
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

        }

       
    }
}