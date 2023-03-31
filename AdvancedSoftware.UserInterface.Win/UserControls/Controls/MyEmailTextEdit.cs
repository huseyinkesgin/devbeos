using AdvancedSoftware.UserInterface.Win.Interfaces;
using DevExpress.XtraEditors.Mask;
using System.ComponentModel;

namespace AdvancedSoftware.UserInterface.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyEmailTextEdit:MyTextEdit
    {
        public MyEmailTextEdit()
        {
            Properties.Mask.MaskType = MaskType.RegEx;
            Properties.Mask.EditMask = @"((([0-9a-zA-Z_%-])+[.])+|([0-9a-zA-Z_%-])+)+@((([0-9a-zA-Z_-])+[.])+|([0-9a-zA-Z_-])+)+";
            Properties.Mask.AutoComplete = AutoCompleteType.Strong;
            StatusBarAciklama = "Eposta adresi giriniz";
        }
    }
}
