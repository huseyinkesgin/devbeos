using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.AracForms;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.YakitHarcamaForms
{
    public partial class YakitHarcamaListForm : BaseListForm
    {
        public YakitHarcamaListForm()
        {
            InitializeComponent();
            Bll = new YakitHarcamaBll();
        }
        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.YakitHarcama;
            FormShow = new ShowEditForms<YakitHarcamaEditForm>();
            Navigator = longNavigator.Navigator;

        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((YakitHarcamaBll)Bll).List(FilterFunctions.Filter<YakitHarcama>(AktifKartlariGoster));
        }
    }
}