using AdavancedSoftware.Model.Dto;
using AdvancedSoftware.UserInterface.Win.Forms.HizmetForms;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftware.UserInterface.Win.UserControls.UserControl.Base;
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
            tablo.GridControl.DataSource = ((IndiriminUygulanacagiHizmetBilgileriBll)Bll).List(x => x.IndirimId == OwnerForm.Id);
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<IndiriminUygulanacagiHizmetBilgileriL>().Where( x => !x.Delete).Select(x => x.HizmetId).ToList();

            var entities = ShowListForms<HizmetListForm>.ShowDialogListForm
        }
    }
}
