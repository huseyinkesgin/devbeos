using AdvancedSoftware.UserInterface.Win.Interfaces;
using DevExpress.XtraEditors;
using System.ComponentModel;

namespace AdvancedSoftware.UserInterface.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyFilterControl: FilterControl, IStatusBarAciklama
    {
        public MyFilterControl()
        {
           ShowGroupCommandsIcon = true;
        }

        public string StatusBarAciklama { get; set; } = "Filtre metni giriniz";
    }
   
}
