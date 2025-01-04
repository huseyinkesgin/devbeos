using AdvancedSoftware.Common.Messages;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            foreach (BarItem button in barManager.Items)
                button.ItemClick += Button_ItemClick;

            //navigator events
            addUptNavigator.Navigator.ButtonClick += Navigator_ButtonClick;

            //tablo events

        }

        protected virtual void HareketEkle() { }

        protected virtual void HareketSil() 
        {
            if (Tablo.DataRowCount == 0)  return;
            if ( Messages.SilMesaji("İşlem Satırı") != DialogResult.Yes) return;


        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnHaraketEkle)
            {
                HareketEkle();
            }
            else if (e.Item == btnHaraketSil)
            {
                HareketSil();
            }

            Cursor.Current = DefaultCursor;

        }

    

        private void Navigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button == addUptNavigator.Navigator.Buttons.Append)
            {
                HareketEkle();
            }
            else if (e.Button == addUptNavigator.Navigator.Buttons.Remove)
            {
                HareketSil();
            }
            //else if (e.Button == addUptNavigator.Navigator.Buttons.Append || e.Button == addUptNavigator.Navigator.Buttons.Remove)
            //{
            //    e.Handled = true;
            //}
          
        }

    }
}
