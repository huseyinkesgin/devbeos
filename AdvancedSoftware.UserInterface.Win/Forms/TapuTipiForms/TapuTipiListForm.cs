using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Forms.IptalNedeniForms;
using AdvancedSoftware.UserInterface.Win.Forms.SiparisForms.IlceForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftweare.BusinessLayer.General;
using DevExpress.Pdf.Native.BouncyCastle.Asn1.Ocsp;

namespace AdvancedSoftware.UserInterface.Win.Forms.TapuTipiForms
{
    public partial class TapuTipiListForm : BaseListForm
    {
        private readonly long _portfoyTipiId;
        private readonly string _portfoyTipiAdi;

        public TapuTipiListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new TapuTipiBll();

            _portfoyTipiId = (long)prm[0];
            _portfoyTipiAdi = prm[1].ToString();
        }

        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.TapuTipi;
            //FormShow = new ShowEditForms<TapuTipiEditForm>();
            Navigator = longNavigator.Navigator;
            Text = Text + $" - ( {_portfoyTipiAdi} )";
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((TapuTipiBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.PortfoyTipiId == _portfoyTipiId);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<TapuTipiEditForm>.ShowDialogEditForm(KartTuru.TapuTipi, id, _portfoyTipiId, _portfoyTipiAdi);
            ShowEditFormDefault(result);
        }
    }
}