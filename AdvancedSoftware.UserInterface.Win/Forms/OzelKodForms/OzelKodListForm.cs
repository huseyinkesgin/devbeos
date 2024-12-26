using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.Common.Functions;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Forms.FiltreForms;
using AdvancedSoftware.UserInterface.Win.Forms.OzelKodForms;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.OzelKod
{
    public partial class OzelKodListForm : BaseListForm
    {
        private readonly OzelKodTuru _ozelKodTuru;
        private readonly KartTuru _ozelKodKartTuru;

        public OzelKodListForm(params object[] prm)
        {
            InitializeComponent();

            _ozelKodTuru = (OzelKodTuru)prm[0];
            _ozelKodKartTuru = (KartTuru)prm[1];

            Bll = new OzelKodBll();
        }

        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.OzelKod;
            Navigator = longNavigator.Navigator;
            Text = Text + $" - ( {_ozelKodTuru.ToName()} )";

        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((OzelKodBll)Bll).List(x => x.KodTuru == _ozelKodTuru && x.KartTuru == _ozelKodKartTuru);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<OzelKodEditForm>.ShowDialogEditForm(KartTuru.OzelKod, id, _ozelKodTuru, _ozelKodKartTuru);
            ShowEditFormDefault(result);
        }
    }
}