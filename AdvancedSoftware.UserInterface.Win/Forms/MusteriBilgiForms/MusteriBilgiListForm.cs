using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Forms.SiparisForms.IlceForms;
using AdvancedSoftware.UserInterface.Win.Forms.SiparisForms.IlForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftware.UserInterface.Win.UserControls.Controls.Navigators;
using AdvancedSoftweare.BusinessLayer.General;
using DevExpress.XtraBars;

namespace AdvancedSoftware.UserInterface.Win.Forms.MusteriBilgiForms
{
    public partial class MusteriBilgiListForm : BaseListForm
    {
        public MusteriBilgiListForm()
        {
            InitializeComponent();

            Bll = new MusteriBilgiBll();
        }

        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.MusteriBilgi;
            FormShow = new ShowEditForms<MusteriBilgiEditForm>();
            Navigator =longNavigator.Navigator;

           
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((MusteriBilgiBll)Bll).List(FilterFunctions.Filter<MusteriBilgi>(AktifKartlariGoster));
        }

      
    }
}