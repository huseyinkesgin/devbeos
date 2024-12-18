using AdavancedSoftware.Model.Entities;
using AdavancedSoftware.Model.Entities.Base.Interfaces;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.Common.Functions;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using AdvancedSoftware.UserInterface.Win.Functions;
using DevExpress.XtraBars;
using System;

namespace AdvancedSoftware.UserInterface.Win.GenelForms
{
    public partial class TabloDokumParametreleri :BaseEditForm
    {
        private DokumSekli _dokumSekli;
        private readonly string _raporBaslik;


        public TabloDokumParametreleri(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl2;
            HideItems = new BarItem[] { btnYeni,btnKaydet,btnGeriAl,btnSil};
            ShowItems = new BarItem[] { btnYazdir, btnBaskiOnizleme,  };

            EventsLoad();

            _raporBaslik = prm[0].ToString();
        }

        protected internal override void Yukle()
        {
            txtRaporBasligi.Text = _raporBaslik;
            txtBaslikEkle.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtRaporKagidaSigdir.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<RaporuKagidaSigdirmaTuru>());
            txtYazdirmaYonu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YazdirmaYonu>());
            txtYatayCizgileriGoster.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtDikeyCizgileriGoster.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtSutunBasliklariGoster.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtYaziciAdi.Properties.Items.AddRange(GeneralFunctions.YazicilariListele());


            txtBaslikEkle.SelectedItem = EvetHayir.Evet.ToName();
            txtRaporKagidaSigdir.SelectedItem = RaporuKagidaSigdirmaTuru.YaziBoyutunuKuculterekSigdir.ToName();
            txtYazdirmaYonu.SelectedItem = YazdirmaYonu.Otomatik.ToName();
            txtYatayCizgileriGoster.SelectedItem = EvetHayir.Evet.ToName();
            txtDikeyCizgileriGoster.SelectedItem = EvetHayir.Evet.ToName();
            txtSutunBasliklariGoster.SelectedItem = EvetHayir.Evet.ToName();
            txtYaziciAdi.EditValue = GeneralFunctions.DefaultYazici();

        }

        protected internal override IBaseEntity ReturnEntity()
        {
            var entity = new DokumParametreleri
            {
                RaporBaslik = txtRaporBasligi.Text,
                BaslikEkle = txtBaslikEkle.Text.GetEnum<EvetHayir>(),
                RaporKagidaSigdir = txtRaporKagidaSigdir.Text.GetEnum<RaporuKagidaSigdirmaTuru>(),
                YazdirmaYonu = txtYazdirmaYonu.Text.GetEnum<YazdirmaYonu>(),
                YatayCizgileriGoster = txtYatayCizgileriGoster.Text.GetEnum<EvetHayir>(),
                DikeyCizgileriGoster = txtDikeyCizgileriGoster.Text.GetEnum<EvetHayir>(),
                SutunBasliklariGoster = txtSutunBasliklariGoster.Text.GetEnum<EvetHayir>(),
                YaziciAdi = txtYaziciAdi.Text,
                KopyaSayisi = (int)txtKopyaSayisi.Value,
                DokumSekli = _dokumSekli
            };

            return entity;
        }

        protected override void Yazdir()
        {
           _dokumSekli = DokumSekli.TabloYazdir;
            Close();
        }

        protected override void BaskiOnizleme()
        {
            _dokumSekli = DokumSekli.TabloBaskiOnizleme;
            Close();
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
           txtRaporBasligi.Enabled = txtBaslikEkle.Text.GetEnum<EvetHayir>() == EvetHayir.Evet;
        }

    }
}