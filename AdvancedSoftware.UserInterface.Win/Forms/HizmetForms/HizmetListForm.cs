using AdavancedSoftware.Model.Dto;
using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.Common.Messages;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.GenelForms;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftweare.BusinessLayer.General;
using DevExpress.Utils.Extensions;
using System;
using System.Linq;
using System.Linq.Expressions;


namespace AdvancedSoftware.UserInterface.Win.Forms.HizmetForms
{
    public partial class HizmetListForm : BaseListForm
    {
        private readonly Expression<Func<Hizmet, bool>> _filter;

        public HizmetListForm()
        {
            InitializeComponent();
            Bll = new HizmetBll();
            _filter = x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId;
        }

        public HizmetListForm(params object[] prm) : this()
        {
            if (prm != null)
            {
                var panelGoster = (bool)prm[0];
                ustPanel.Visible = DateTime.Now.Date > AnaForm.HizmetBaslamaTarihi.Date && panelGoster;

            }

            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId;
        }



        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Hizmet;
            FormShow = new ShowEditForms<HizmetEditForm>();
            Navigator = longNavigator.Navigator;
            TarihAyarla();

        }
        protected override void Listele()
        {
            var list = ((HizmetBll)Bll).List(_filter);

            tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");
        }

        protected override void SelectEntity()
        {
            base.SelectEntity();

            if (MultiSelect)
                SelectedEntities.ForEach(x => ((HizmetL)x).BaslangicTarihi = txtHizmetBaslamaTarihi.DateTime.Date);
        }

        private void TarihAyarla()
        {
            txtHizmetBaslamaTarihi.Properties.MinValue = AnaForm.GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir ? AnaForm.HizmetBaslamaTarihi : DateTime.Now.Date < AnaForm.HizmetBaslamaTarihi ? AnaForm.HizmetBaslamaTarihi : DateTime.Now.Date;
            
            
            txtHizmetBaslamaTarihi.Properties.MaxValue = AnaForm.GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir ? AnaForm.HizmetBitisTarihi : DateTime.Now.Date < AnaForm.HizmetBaslamaTarihi ? AnaForm.HizmetBaslamaTarihi : DateTime.Now.Date > AnaForm.HizmetBitisTarihi ? AnaForm.HizmetBitisTarihi : DateTime.Now.Date;
            
            
            
            txtHizmetBaslamaTarihi.DateTime = DateTime.Now.Date <= AnaForm.HizmetBaslamaTarihi ? AnaForm.HizmetBaslamaTarihi : DateTime.Now.Date > AnaForm.HizmetBitisTarihi && DateTime.Now.Date <= AnaForm.HizmetBitisTarihi ? DateTime.Now.Date : DateTime.Now.Date > AnaForm.HizmetBitisTarihi ? AnaForm.HizmetBitisTarihi : DateTime.Now.Date;
        }
    }
}