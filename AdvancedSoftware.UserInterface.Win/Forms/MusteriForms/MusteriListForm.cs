using AdavancedSoftware.Model.Dto;
using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BankaSubeForms;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftweare.BusinessLayer.General;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace AdvancedSoftware.UserInterface.Win.Forms.MusteriForms
{
    public partial class MusteriListForm : BaseListForm
    {
        //private readonly long _ilId;
        //private readonly string _ilAdi;
        //private readonly string _musterigroupId;

        public MusteriListForm()
        {
            InitializeComponent();

            Bll = new MusteriBll();

            //_ilId = (long)prm[0];
            //_ilAdi = prm[1].ToString();
        }

        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Musteri;
            FormShow = new ShowEditForms<MusteriEditForm>();
            Navigator = longNavigator.Navigator;

        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((MusteriBll)Bll).List(FilterFunctions.Filter<Musteri>(AktifKartlariGoster));
        }

        //protected override void ShowEditForm(long id)
        //{
        //    var result = ShowEditForms<MusteriEditForm>.ShowDialogEditForm(KartTuru.Musteri, id, _bankaId, _bankaAdi);
        //    ShowEditFormDefault(result);
        //}

    }
}