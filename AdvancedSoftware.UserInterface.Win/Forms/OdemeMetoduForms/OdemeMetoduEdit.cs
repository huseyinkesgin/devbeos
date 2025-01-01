using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.Common.Functions;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftweare.BusinessLayer.General;


namespace AdvancedSoftware.UserInterface.Win.Forms.OdemeMetoduForms
{
    public partial class OdemeMetoduEdit : BaseEditForm
    {
        public OdemeMetoduEdit()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new OdemeMetoduBll(myDataLayoutControl);
            txtOdemeTipi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<OdemeTipi>());
           
            BaseKartTuru = KartTuru.OdemeMetodu;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new OdemeMetodu() : ((OdemeMetoduBll)Bll).Single(FilterFunctions.Filter<OdemeMetodu>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert)
                return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((OdemeMetoduBll)Bll).YeniKodVer();
            txtOdemeMetoduAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (OdemeMetodu)OldEntity;

            txtKod.Text = entity.Kod;
            txtOdemeMetoduAdi.Text = entity.OdemeMetoduAdi;
            txtOdemeTipi.SelectedItem = entity.OdemeTipi.ToName();
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new OdemeMetodu
            {
                Id = Id,
                Kod = txtKod.Text,
                OdemeMetoduAdi = txtOdemeMetoduAdi.Text,
                OdemeTipi = txtOdemeTipi.Text.GetEnum<OdemeTipi>(),
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };
            ButonEnabledDurumu();
        }
    }
}