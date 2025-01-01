using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.AracForms;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.PersonelHarcamaForms
{
    public partial class PersonelHarcamaListForm : BaseListForm
    {
        public PersonelHarcamaListForm()
        {
            InitializeComponent();
            Bll = new PersonelHarcamaBll();
        }
        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.PersonelHarcama;
            FormShow = new ShowEditForms<PersonelHarcamaEditForm>();
            Navigator = longNavigator.Navigator;

        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((PersonelHarcamaBll)Bll).List(FilterFunctions.Filter<PersonelHarcama>(AktifKartlariGoster));
        }
    }
}