using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Forms.ModelForms;
using AdvancedSoftware.UserInterface.Win.Forms.SiparisForms.IlceForms;
using AdvancedSoftware.UserInterface.Win.Forms.SiparisForms.IlForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftweare.BusinessLayer.General;
using DevExpress.XtraBars;


namespace AdvancedSoftware.UserInterface.Win.Forms.MarkaForms
{
    public partial class MarkaListForm : BaseListForm
    {
        public MarkaListForm()
        {
            InitializeComponent();

            Bll = new MarkaBll();
            btnBagliKartlar.Caption = "Modeller";
        }

        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Marka;
            FormShow = new ShowEditForms<MarkaEditForm>();
            Navigator = longNavigator.Navigator;

            if (IsMdiChild)
                ShowItems = new BarItem[] { btnBagliKartlar };
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((MarkaBll)Bll).List(FilterFunctions.Filter<Marka>(AktifKartlariGoster));
        }

        protected override void BagliKartAc()
        {
            var entity = Tablo.GetRow<Marka>();
            if (entity == null)
                return;
            ShowListForms<ModelListForm>.ShowListForm(KartTuru.Model, entity.Id, entity.MarkaAdi);
        }


    }
}