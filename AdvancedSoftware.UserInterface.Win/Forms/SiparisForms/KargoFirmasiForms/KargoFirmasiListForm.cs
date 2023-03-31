using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftware.UserInterface.Win.UserControls.Controls.Navigators;
using DevExpress.XtraEditors;
using AdvancedSoftweare.BusinessLayer.General;


namespace AdvancedSoftware.UserInterface.Win.Forms.SiparisForms.KargoFirmasiForms
{
    public partial class KargoFirmasiListForm : BaseListForm
    {
        public KargoFirmasiListForm()
        {
            InitializeComponent();
            Bll = new KargoFirmasiBll();
        }
        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.KargoFirmasi;
            FormShow = new ShowEditForms<KargoFirmasiEditForm>();
            Navigator = longNavigator.Navigator;
            
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KargoFirmasiBll)Bll).List(FilterFunctions.Filter<KargoFirmasi>(AktifKartlariGoster));
        }
    }
}