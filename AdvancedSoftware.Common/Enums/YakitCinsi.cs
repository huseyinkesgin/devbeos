using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSoftware.Common.Enums
{
    public enum YakitCinsi : byte
    {
        [Description("BENZİN")]
        Benzin = 1,
        [Description("DİZEL")]
        Dizel = 2,
        [Description("LPG")]
        LPG = 3,
        [Description("ELEKTRİK")]
        Elektrik = 4,
        [Description("HİBRİT")]
        Hibrit = 5
    }
}
