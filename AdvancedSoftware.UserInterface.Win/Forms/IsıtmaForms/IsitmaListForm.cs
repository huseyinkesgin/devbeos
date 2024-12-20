using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Forms.MusteriBilgiForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.IsıtmaForms
{
    public partial class IsitmaListForm : BaseListForm
    {
        public IsitmaListForm()
        {
            InitializeComponent();
            Bll = new IsitmaBll();
        }

        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Isitma;
            FormShow = new ShowEditForms<IsitmaEditForm>();
            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IsitmaBll)Bll).List(FilterFunctions.Filter<Isitma>(AktifKartlariGoster));
        }


    }
}