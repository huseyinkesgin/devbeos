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
        [Description("Benzin")]
        Benzin = 1,
        [Description("Dizel")]
        Dizel = 2,
        [Description("LPG")]
        LPG = 3,
        [Description("Elektrik")]
        Elektrik = 4,
        [Description("Hibrit")]
        Hibrit = 5
    }
}
