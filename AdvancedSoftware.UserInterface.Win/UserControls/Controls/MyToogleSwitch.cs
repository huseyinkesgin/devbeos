﻿using AdvancedSoftware.UserInterface.Win.Interfaces;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;

namespace AdvancedSoftware.UserInterface.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyToogleSwitch:ToggleSwitch, IStatusBarAciklama
    {
        public MyToogleSwitch()
        {
            Name = "tglDurum";
            Properties.OffText = "Pasif";
            Properties.OnText = "Aktif";
            Properties.AutoHeight = false;
            Properties.AutoWidth = true;
            Properties.GlyphAlignment = HorzAlignment.Far;
            Properties.Appearance.ForeColor = Color.Maroon;
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; } = " Kartın kullanım durumunu seçiniz";
    }
}
