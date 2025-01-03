using AdvancedSoftware.UserInterface.Win.UserControls.Controls.Navigators;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;

namespace AdvancedSoftware.UserInterface.Win.UserControls.UserControl.Base
{
    public partial class BaseTablo : XtraUserControl
    {
        protected GridView Tablo;
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
            insUptNavigator.Navigator.ButtonClick += Navigator_ButtonClick;

        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Navigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
