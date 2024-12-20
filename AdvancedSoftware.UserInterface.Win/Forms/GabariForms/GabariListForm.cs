using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Forms.MusteriBilgiForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftware.UserInterface.Win.UserControls.Controls.Navigators;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.GabariForms
{
    public partial class GabariListForm : BaseListForm
    {
        public GabariListForm()
        {
            InitializeComponent();
            Bll = new GabariBll();
        }

        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Gabari;
            FormShow = new ShowEditForms<GabariEditForm>();
            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((GabariBll)Bll).List(FilterFunctions.Filter<Gabari>(AktifKartlariGoster));
        }


    }
}