using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Forms.MusteriBilgiForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.AltyapiForms
{
    public partial class AltyapiListForm : BaseListForm
    {
        public AltyapiListForm()
        {
            InitializeComponent();

            Bll = new AltyapiBll();
        }

        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Altyapi;
            FormShow = new ShowEditForms<AltyapiEditForm>();
            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((AltyapiBll)Bll).List(FilterFunctions.Filter<Altyapi>(AktifKartlariGoster));
        }


    }
}