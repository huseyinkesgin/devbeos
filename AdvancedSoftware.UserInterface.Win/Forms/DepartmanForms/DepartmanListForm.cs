using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Forms.MusteriBilgiForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.DepartmanForms
{
    public partial class DepartmanListForm : BaseListForm
    {
        public DepartmanListForm()
        {
            InitializeComponent();
            Bll = new DepartmanBll();
        }

        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Departman;
            FormShow = new ShowEditForms<DepartmanEditForm>();
            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((DepartmanBll)Bll).List(FilterFunctions.Filter<Departman>(AktifKartlariGoster));
        }


    }
}