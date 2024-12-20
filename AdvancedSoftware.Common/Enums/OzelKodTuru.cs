﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSoftware.Common.Enums
{
    public enum OzelKodTuru : byte
    {
        [Description("Özel Kod-1")]
        OzelKod1 = 1,
        [Description("Özel Kod-2")]
        OzelKod2 = 2,
        [Description("Özel Kod-3")]
        OzelKod3 = 3,
        [Description("Özel Kod-4")]
        OzelKod4 = 4,
        [Description("Özel Kod-5")]
        OzelKod5 = 5,
    }
}
