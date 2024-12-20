using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Forms.MusteriBilgiForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftware.UserInterface.Win.UserControls.Controls.Navigators;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.EmsalForms
{
    public partial class EmsalListForm : BaseListForm
    {
        public EmsalListForm()
        {
            InitializeComponent();
            Bll = new EmsalBll();
        }

        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.MusteriBilgi;
            FormShow = new ShowEditForms<EmsalEditForm>();
            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((EmsalBll)Bll).List(FilterFunctions.Filter<Emsal>(AktifKartlariGoster));
        }


    }
}