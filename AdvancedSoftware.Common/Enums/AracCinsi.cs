using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSoftware.Common.Enums
{
    public enum AracCinsi : byte
    {
        [Description("OTOMOBİL")]
        Otomobil = 1,
        [Description("KAMYONET")]
        Kamyonet = 2,
        [Description("KAMYON")]
        Kamyon = 3,
        [Description("OTOBÜS")]
        Otobüs = 4,
        [Description("MİNİBÜS")]
        Minibüs = 5,
        [Description("PANELVAN")]
        Panelvan = 6,
        [Description("TIR")]
        Tır = 7,
        [Description("TRAKTÖR")]
        Traktör = 8,
        [Description("MOTOSİKLET")]
        Motosiklet = 9,
        [Description("BİSİKLET")]
        Bisiklet = 10,
        [Description("DİĞER")]
        Diğer = 11
    }
}
