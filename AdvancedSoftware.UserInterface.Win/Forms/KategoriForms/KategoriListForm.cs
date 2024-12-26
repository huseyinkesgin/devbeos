using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.Common.Functions;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Forms.MusteriBilgiForms;
using AdvancedSoftware.UserInterface.Win.Forms.OzelKodForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftweare.BusinessLayer.General;

namespace AdvancedSoftware.UserInterface.Win.Forms.MusteriGrupForms
{
    public partial class KategoriListForm : BaseListForm
    {
        private readonly KategoriTuru _kategoriTuru;
        private readonly KartTuru _kategoriKartTuru;

        public KategoriListForm(params object[] prm)
        {
            InitializeComponent();

            _kategoriTuru = (KategoriTuru)prm[0];
            _kategoriKartTuru = (KartTuru)prm[1];

            Bll = new KategoriBll();
        }

        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Kategori;
            Navigator = longNavigator.Navigator;
            Text = Text + $" - ( {_kategoriTuru.ToName()} )";


        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KategoriBll)Bll).List(x => x.KategoriTuru == _kategoriTuru && x.KartTuru == _kategoriKartTuru);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<KategoriEditForm>.ShowDialogEditForm(KartTuru.Kategori, id, _kategoriTuru, _kategoriKartTuru);
            ShowEditFormDefault(result);
        }


    }
}