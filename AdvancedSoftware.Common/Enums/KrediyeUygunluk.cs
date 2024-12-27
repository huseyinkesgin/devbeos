﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSoftware.Common.Enums
{
    public enum KrediyeUygunluk : byte
    {
        [Description("EVET")]
        Evet = 1,
        [Description("HAYIR")]
        Hayir = 2,
        [Description("BİLİNMİYOR")]
        Bilinmiyor = 3
    }
}
