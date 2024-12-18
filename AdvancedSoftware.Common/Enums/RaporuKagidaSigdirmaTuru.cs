using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSoftware.Common.Enums
{
   public enum RaporuKagidaSigdirmaTuru : byte
    {
        [Description("Sütunları Daraltarak Sığdır")]
        SutunlarıDaraltarakSigdir = 1,
        [Description("Yazı Boyutunu Küçülterek Sığdır")]
        YaziBoyutunuKuculterekSigdir = 2,
        [Description("İşlem Yapma")]
        IslemYapma = 3
    }
}
