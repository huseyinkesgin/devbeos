using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Forms.KasaForms;
using AdvancedSoftware.UserInterface.Win.GenelForms;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.BankaHesapForms
{
    public partial class BankaHesapListForm : BaseListForm
    {
        public BankaHesapListForm()
        {
            InitializeComponent();

            Bll = new BankaHesapBll();
        }

        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.BankaHesap;
            FormShow = new ShowEditForms<BankaHesapEditForm>();
            Navigator = longNavigator.Navigator;

        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((BankaHesapBll)Bll).List(x => x.Durum == AktifKartlariGoster);
        }
    }
}
