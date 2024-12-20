using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Forms.MusteriBilgiForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.UnvanForms
{
    public partial class UnvanListForm : BaseListForm
    {
        public UnvanListForm()
        {
            InitializeComponent();
            Bll = new UnvanBll();
        }

        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Unvan;
            FormShow = new ShowEditForms<UnvanEditForm>();
            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((UnvanBll)Bll).List(FilterFunctions.Filter<Unvan>(AktifKartlariGoster));
        }


    }
}