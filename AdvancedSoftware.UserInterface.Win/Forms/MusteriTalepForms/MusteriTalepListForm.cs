using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.MusteriTalepForms
{
    public partial class MusteriTalepListForm : BaseListForm
    {
        public MusteriTalepListForm()
        {
            InitializeComponent();
            Bll = new MusteriTalepBll();
        }

        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.MusteriTalep;
            FormShow = new ShowEditForms<MusteriTalepEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((MusteriTalepBll)Bll).List(FilterFunctions.Filter<MusteriTalep>(AktifKartlariGoster));
        }

      
    }
}
