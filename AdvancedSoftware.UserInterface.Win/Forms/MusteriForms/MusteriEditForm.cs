using AdvancedSoftware.Common.Enums;
using AdvancedSoftware.Common.Functions;
using AdvancedSoftware.UserInterface.Win.Forms.BaseForms;
using DevExpress.XtraEditors;
using System;

namespace AdvancedSoftware.UserInterface.Win.Forms.MusteriForms
{
    public partial class MusteriEditForm : BaseEditForm
    {
        public MusteriEditForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// sadece kurumsal müşteri için firma adı alanını aktif eder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!(sender is ComboBoxEdit edt))
                return;

            var musteriTuru = edt.Text.GetEnum<MusteriTuru>();

            if (musteriTuru == MusteriTuru.Kurumsal)
            {
                txtFirmaAdi.Enabled = true;
            }
            else
            {
                txtFirmaAdi.Enabled = false;
            }

        }
    }
}