using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Forms.SiparisForms.IlceForms;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftweare.BusinessLayer.General;
using DevExpress.Pdf.Native.BouncyCastle.Asn1.Ocsp;

namespace AdvancedSoftware.UserInterface.Win.Forms.ModelForms
{
    public partial class ModelListForm : BaseListForm
    {
        #region Değişkenler

        private readonly long _markaId;
        private readonly string _markaAdi;

        #endregion
        public ModelListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new ModelBll();

            _markaId = (long)prm[0];
            _markaAdi = prm[1].ToString();
        }

        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Model;
            Navigator = longNavigator.Navigator;
            Text = Text + $" - ( {_markaAdi} )";
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((ModelBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.MarkaId == _markaId);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<ModelEditForm>.ShowDialogEditForm(KartTuru.Model, id, _markaId, _markaAdi);
            ShowEditFormDefault(result);
        }
    }
}