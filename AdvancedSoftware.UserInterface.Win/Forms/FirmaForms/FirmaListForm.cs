using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Forms.OfisForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.FirmaForms
{
    public partial class FirmaListForm : BaseListForm
    {
        public FirmaListForm()
        {
            InitializeComponent();
            Bll = new FirmaBll();
        }
        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Firma;
            FormShow = new ShowEditForms<FirmaEditForm>();
            Navigator = longNavigator.Navigator;

        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((FirmaBll)Bll).List(FilterFunctions.Filter<Firma>(AktifKartlariGoster));
        }
    }
}