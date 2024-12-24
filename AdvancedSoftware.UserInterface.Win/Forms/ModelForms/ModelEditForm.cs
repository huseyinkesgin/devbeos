using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using AdvancedSoftweare.BusinessLayer.General;
using DevExpress.Pdf.Native.BouncyCastle.Asn1.Ocsp;

namespace AdvancedSoftware.UserInterface.Win.Forms.ModelForms
{
    public partial class ModelEditForm : BaseEditForm
    {
        #region Değişkenler

        private readonly long _markaId;
        private readonly string _markaAdi;

        #endregion
        public ModelEditForm(params object[] prm)
        {
            InitializeComponent();
            _markaId = (long)prm[0];
            _markaAdi = prm[1].ToString();

            DataLayoutControl = myDataLayoutControl;
            Bll = new ModelBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Model;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Model() : ((ModelBll)Bll).Single(FilterFunctions.Filter<Model>(Id));
            NesneyiKontrollereBagla();
            Text = Text + $" - ( {_markaAdi} )";


            if (BaseIslemTuru != IslemTuru.EntityInsert)
                return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((ModelBll)Bll).YeniKodVer(x => x.MarkaId == _markaId);
            txtModelAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Model)OldEntity;

            txtKod.Text = entity.Kod;
            txtModelAdi.Text = entity.ModelAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Model
            {
                Id = Id,
                Kod = txtKod.Text,
                ModelAdi = txtModelAdi.Text,
                Aciklama = txtAciklama.Text,
                MarkaId = _markaId,
                Durum = tglDurum.IsOn,
            };
            ButonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((ModelBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.MarkaId == _markaId);
        }

        protected override bool EntityUpdate()
        {
            return ((ModelBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.MarkaId == _markaId);
        }
    }
}