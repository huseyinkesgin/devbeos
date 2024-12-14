using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.OfisForms
{
    public partial class OfisListForm : BaseListForm
    {
        public OfisListForm()
        {
            InitializeComponent();
            Bll = new OfisBll();
        }
        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Ofis;
            FormShow = new ShowEditForms<OfisEditForm>();
            Navigator = longNavigator.Navigator;

        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((OfisBll)Bll).List(FilterFunctions.Filter<Ofis>(AktifKartlariGoster));
        }
    }
}
