using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Forms.SiparisForms.IlceForms;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftweare.BusinessLayer.General;
using DevExpress.Pdf.Native.BouncyCastle.Asn1.Ocsp;

namespace AdvancedSoftware.UserInterface.Win.Forms.MahalleForms
{
    public partial class MahalleListForm : BaseListForm
    {

        private readonly long _ilceId;
        private readonly string _ilceAdi;

        public MahalleListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new MahalleBll();

            _ilceId = (long)prm[0];
            _ilceAdi = prm[1].ToString();
        }

        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Mahalle;
            Navigator = longNavigator.Navigator;
            Text = Text + $" - ( {_ilceAdi} )";
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((MahalleBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.IlceId == _ilceId);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<MahalleEditForm>.ShowDialogEditForm(KartTuru.Ilce, id, _ilceId, _ilceAdi);
            ShowEditFormDefault(result);
        }
    }
}