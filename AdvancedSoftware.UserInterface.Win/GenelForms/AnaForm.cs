﻿using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.OfisForms;
using AdvancedSoftware.UserInterface.Win.Forms.SiparisForms.IlForms;
using AdvancedSoftware.UserInterface.Win.Forms.SiparisForms.KargoFirmasiForms;
using AdvancedSoftware.UserInterface.Win.Show;
using DevExpress.XtraBars;

namespace AdvancedSoftware.UserInterface.Win.GenelForms
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
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
            if (e.Item == btnKargoFirmasi)

                ShowListForms<KargoFirmasiListForm>.ShowListForm(KartTuru.KargoFirmasi);
           
            if (e.Item == btnOfis)
                ShowListForms<OfisListForm>.ShowListForm(KartTuru.Ofis);

            if (e.Item == btnIl)
                ShowListForms<IlListForm>.ShowListForm(KartTuru.Il);

        }

       
    }
}