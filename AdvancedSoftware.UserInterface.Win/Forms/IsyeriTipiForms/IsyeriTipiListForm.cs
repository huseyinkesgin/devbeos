using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Forms.EmsalForms;
using AdvancedSoftware.UserInterface.Win.Forms.IptalNedeniForms;
using AdvancedSoftware.UserInterface.Win.Forms.PortfoyTipiForms;
using AdvancedSoftware.UserInterface.Win.Forms.SiparisForms.IlceForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftweare.BusinessLayer.General;
using DevExpress.Pdf.Native.BouncyCastle.Asn1.Ocsp;
using DevExpress.XtraBars;

namespace AdvancedSoftware.UserInterface.Win.Forms.TapuTipiForms
{
    public partial class IsyeriTipiListForm : BaseListForm
    {
       
        public IsyeriTipiListForm()
        {
            InitializeComponent();
            Bll = new IsyeriTipiBll();
        }

        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.IsyeriTipi;
            FormShow = new ShowEditForms<IsyeriTipiEditForm>();
            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IsyeriTipiBll)Bll).List(FilterFunctions.Filter<IsyeriTipi>(AktifKartlariGoster));
        }

    }
}