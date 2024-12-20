using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Forms.MusteriBilgiForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.ImarBilgisiForms
{
    public partial class ImarBilgisiListForm : BaseListForm
    {
        public ImarBilgisiListForm()
        {
            InitializeComponent();
            Bll = new ImarDurumuBll();
        }

        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.ImarDurumu;
            FormShow = new ShowEditForms<ImarBilgisiEditForm>();
            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((ImarDurumuBll)Bll).List(FilterFunctions.Filter<ImarBilgisi>(AktifKartlariGoster));
        }
    }
}