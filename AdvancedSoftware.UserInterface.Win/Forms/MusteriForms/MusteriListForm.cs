using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.MusteriForms
{
    public partial class MusteriListForm : BaseListForm
    {
      
        public MusteriListForm()
        {
            InitializeComponent();

            Bll = new MusteriBll();

        }

        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Musteri;
            FormShow = new ShowEditForms<MusteriEditForm>();
            Navigator = longNavigator.Navigator;

        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((MusteriBll)Bll).List(FilterFunctions.Filter<Musteri>(AktifKartlariGoster));
        }

     

    }
}