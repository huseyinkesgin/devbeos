using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Forms.PersonelForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftware.UserInterface.Win.UserControls.Controls.Navigators;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.IsyeriForms
{
    public partial class IsyeriListForm : BaseListForm
    {
        public IsyeriListForm()
        {
            InitializeComponent();
            Bll = new PersonelBll();

        }

        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Personel;
            FormShow = new ShowEditForms<PersonelEditForm>();
            Navigator = UserControls.Controls.Navigators.longNavigator.Navigator;

        }
    }
}