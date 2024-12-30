using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Forms.OdemeMetoduForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.OdemeTuru
{
    public partial class OdemeMetoduList : BaseListForm
    {
        public OdemeMetoduList()
        {
            InitializeComponent();
            Bll = new OdemeMetoduBll();
        }

        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.OdemeMetodu;
            FormShow = new ShowEditForms<OdemeMetoduEdit>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((OdemeMetoduBll)Bll).List(FilterFunctions.Filter<OdemeMetodu>(AktifKartlariGoster));
        }
    }
}