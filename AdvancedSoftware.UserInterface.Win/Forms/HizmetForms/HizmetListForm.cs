using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.HizmetForms
{
    public partial class HizmetListForm : BaseListForm
    {
        public HizmetListForm()
        {
            InitializeComponent();
            Bll = new HizmetBll();
        }
        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Hizmet;
            FormShow = new ShowEditForms<HizmetEditForm>();
            Navigator = longNavigator.Navigator;

        }
        protected override void Listele()
        {
            tablo.GridControl.DataSource = ((HizmetBll)Bll).List(FilterFunctions.Filter<Hizmet>(AktifKartlariGoster));
        }
    }
}