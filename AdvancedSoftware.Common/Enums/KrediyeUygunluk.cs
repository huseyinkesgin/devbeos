using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSoftware.Common.Enums
{
    public enum KrediyeUygunluk : byte
    {
        [Description("Evet")]
        Evet = 1,
        [Description("Hayır")]
        Hayir = 2,
        [Description("Bilinmiyor")]
        Bilinmiyor = 3
    }
}
