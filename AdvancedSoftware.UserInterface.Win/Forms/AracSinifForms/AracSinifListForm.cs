using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.AltyapiForms;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.AracSinifForms
{
    public partial class AracSinifListForm : BaseListForm
    {
        public AracSinifListForm()
        {
            InitializeComponent();
            Bll = new AracSinifBll();
        }

        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.AracSinif;
            FormShow = new ShowEditForms<AracSinifEditForm>();
            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((AracSinifBll)Bll).List(FilterFunctions.Filter<AracSinif>(AktifKartlariGoster));
        }
    }
}