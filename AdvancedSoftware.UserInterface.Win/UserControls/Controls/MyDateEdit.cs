﻿using AdvancedSoftware.UserInterface.Win.Interfaces;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using System.ComponentModel;
using System.Drawing;

namespace AdvancedSoftware.UserInterface.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyDateEdit:DateEdit, IStatusBarKisaYol
    {
        public MyDateEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarKisaYol { get; set; } = "F4 :";
        public string StatusBarKisaYolAciklama { get; set; } = "Tarih Seç :";
        public string StatusBarAciklama { get; set; }
    }
}
