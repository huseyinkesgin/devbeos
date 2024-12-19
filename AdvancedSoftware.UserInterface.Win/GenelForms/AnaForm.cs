using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.IptalNedeniForms;
using AdvancedSoftware.UserInterface.Win.Forms.MusteriBilgiForms;
using AdvancedSoftware.UserInterface.Win.Forms.OfisForms;
using AdvancedSoftware.UserInterface.Win.Forms.PortfoyTipiForms;
using AdvancedSoftware.UserInterface.Win.Forms.SiparisForms.IlForms;
using AdvancedSoftware.UserInterface.Win.Forms.TapuTipiForms;
using AdvancedSoftware.UserInterface.Win.Show;
using DevExpress.XtraBars;

namespace AdvancedSoftware.UserInterface.Win.GenelForms
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string DonemAdi = "2021-2022";
        public static string SubeAdi = "Merkez";

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

        }

       
    }
}