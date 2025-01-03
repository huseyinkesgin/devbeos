using AdvancedSoftware.UserInterface.Win.UserControls.Controls.Navigators;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;

namespace AdvancedSoftware.UserInterface.Win.UserControls.UserControl.Base
{
    public partial class BaseTablo : XtraUserControl
    {
        public BaseTablo()
        {
            InitializeComponent();
        }

        protected void Eventsload()
        {
            //Buton events
            foreach ( BarItem button in barManager.Items)
                button.ItemClick += Button_ItemClick;

            //navigator events
          
        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
