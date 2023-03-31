using AdvancedSoftware.UserInterface.Win.Interfaces;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.ComponentModel;
using System.Drawing;

namespace AdvancedSoftware.UserInterface.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public  class MyPictureEdit:PictureEdit, IStatusBarKisaYol
    {
        public MyPictureEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.Appearance.ForeColor = Color.Maroon;
            Properties.NullText = "Resim Yok";
            Properties.SizeMode = PictureSizeMode.Stretch;
            Properties.ShowMenu = false;

        }
        public override bool EnterMoveNextControl { get; set; } = true;
        string IStatusBarKisaYol.StatusBarKisaYol { get; set; } = "F4 :";
        string IStatusBarKisaYol.StatusBarKisaYolAciklama { get; set; }
        string IStatusBarAciklama.StatusBarAciklama { get; set; }
    }
}
