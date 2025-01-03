﻿using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Forms.EmsalForms;
using AdvancedSoftware.UserInterface.Win.Forms.SiparisForms.IlceForms;
using AdvancedSoftware.UserInterface.Win.Forms.SiparisForms.IlForms;
using AdvancedSoftware.UserInterface.Win.Forms.TapuTipiForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftweare.BusinessLayer.General;
using DevExpress.XtraBars;

namespace AdvancedSoftware.UserInterface.Win.Forms.PortfoyTipiForms
{
    public partial class PortfoyTipiListForm :BaseListForm
    {
        public PortfoyTipiListForm()
        {
            InitializeComponent();
            Bll = new PortfoyTipiBll();
        }

        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.PortfoyTipi;
            FormShow = new ShowEditForms<PortfoyTipiEditForm>();
            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((PortfoyTipiBll)Bll).List(FilterFunctions.Filter<PortfoyTipi>(AktifKartlariGoster));
        }



    }
}