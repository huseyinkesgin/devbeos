using AdavancedSoftware.Model.Dto;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.Common.Messages;
using AdvancedSoftware.UserInterface.Win.Forms.HizmetForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.GenelForms;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftware.UserInterface.Win.UserControls.UserControl.Base;
using AdvancedSoftweare.BusinessLayer.Functions;
using AdvancedSoftweare.BusinessLayer.General;
using System.Linq;

namespace AdvancedSoftware.UserInterface.Win.UserControls.UserControl.IndirimEditFormTable
{
    public partial class IndiriminUygulanacagiHizmetlerTable : BaseTablo
    {
        public IndiriminUygulanacagiHizmetlerTable()
        {
            InitializeComponent();

            Bll = new IndiriminUygulanacagiHizmetBilgileriBll();
            Tablo = tablo;
            Eventsload();
        }

        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((IndiriminUygulanacagiHizmetBilgileriBll)Bll).List(x => x.IndirimId == OwnerForm.Id).ToBindingList<IndiriminUygulanacagiHizmetBilgileriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<IndiriminUygulanacagiHizmetBilgileriL>().Where(x => !x.Delete).Select(x => x.HizmetId).ToList();

            var entities = ShowListForms<HizmetListForm>.ShowDialogListForm(KartTuru.Hizmet, ListeDisiTutulacakKayitlar, true,false).EntityListConvert<HizmetL>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new IndiriminUygulanacagiHizmetBilgileriL
                {
                    IndirimId = OwnerForm.Id,
                    HizmetId = entity.Id,
                    HizmetAdi = entity.HizmetAdi,
                    IndirimTutari = 0,
                    IndirimOrani = 0,
                    SubeId = AnaForm.SubeId,
                    Insert = true,

                };
                source.Add(row);
            }


            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount -1;
            tablo.FocusedColumn = colIndirimTutari;

            ButonEnabledDurumu(true);

        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<IndiriminUygulanacagiHizmetBilgileriL>(i);

                if (entity.IndirimTutari == 0 || entity.IndirimOrani == 0) continue;
                {
                    tablo.Focus();
                    tablo.FocusedRowHandle = i;
                    Messages.HataMesaji("İndirim Tutarı veya İndirim Oranı alanlarından birininde değeri 0'dan büyük olmalıdır.");
                    return true;
                }
            }

            return false;
        }
    }
}
