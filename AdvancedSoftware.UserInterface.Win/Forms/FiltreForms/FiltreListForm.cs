using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Show;
using AdvancedSoftware.UserInterface.Win.UserControls.Controls.Navigators;
using AdvancedSoftweare.BusinessLayer.General;
using DevExpress.XtraBars;
using DevExpress.XtraGrid;

namespace AdvancedSoftware.UserInterface.Win.Forms.FiltreForms
{
    public partial class FiltreListForm : BaseListForm
    {
        private readonly KartTuru _filtreKartTuru;
        private readonly GridControl _filtreGrid;
        

        public FiltreListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new FiltreBll();

            _filtreKartTuru = (KartTuru)prm[0];
            _filtreGrid = (GridControl)prm[1];

            HideItems = new BarItem[] { btnFiltrele, btnKolonlar, btnYazdir, btnGonder, barFiltrele, barFiltreleAciklama, barKolonlar, barKolonlarAciklama, barYazdir, barYazdirAciklama, barGonder, barGonderAciklama };
        }

        protected override void DesgiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Filtre;
            Navigator = longNavigator.Navigator;
           
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((FiltreBll)Bll).List(x => x.KartTuru == _filtreKartTuru );
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<FiltreEditForm>.ShowDialogEditForm(KartTuru.Filtre, id,_filtreKartTuru, _filtreGrid);
            ShowEditFormDefault(result);
        }
    }
}