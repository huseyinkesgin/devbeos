using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Forms.MusteriBilgiForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.MusteriGrupForms
{
    public partial class MusteriGrupListForm : BaseListForm
    {
        public MusteriGrupListForm()
        {
            InitializeComponent();
            Bll = new MusteriGrupBll();
        }

        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.MusteriGrup;
            FormShow = new ShowEditForms<MusteriGrupEditForm>();
            Navigator = longNavigator.Navigator;


        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((MusteriGrupBll)Bll).List(FilterFunctions.Filter<MusteriGrup>(AktifKartlariGoster));
        }


    }
}