﻿using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.SiparisForms.IlceForms
{
    public partial class IlceListForm : BaseListForm
    {
        #region Değişkenler
        
        private readonly long _ilId;
        private readonly string _ilAdi; 

        #endregion

        public IlceListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new IlceBll();

            _ilId = (long)prm[0];
            _ilAdi = prm[1].ToString();
        }

        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Ilce;
            Navigator = longNavigator.Navigator;
            Text = Text + $" - ( {_ilAdi} )";
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IlceBll)Bll).List(x => x.Durum == AktifKartlariGoster&& x.IlId == _ilId);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<IlceEditForm>.ShowDialogEditForm(KartTuru.Ilce, id, _ilId, _ilAdi);
            ShowEditFormDefault(result);
        }
    }
}