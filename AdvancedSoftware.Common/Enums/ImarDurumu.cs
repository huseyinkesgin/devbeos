using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSoftware.Common.Enums
{
    public enum ImarDurumu : byte
    {
        [Description("SANAYİ İMARLI")]
        Sanayi = 1,
        [Description("TİCARİ İMARLI")]
        Ticari = 2,
        [Description("KONUT İMARLI")]
        Konut = 3,
        [Description("TARLA")]
        Tarla = 4,
        [Description("TİCARİ+KONUT İMARLI")]
        TicariKonut = 5,
        [Description("KONUT DIŞI KENTSEL ÇALIŞMA ALANI")]
        KDKCA = 6,
        [Description("VİLLA İMARLI")]
        Villa = 7,
        [Description("SİT ALANI")]
        SitAlanı = 8,
        [Description("TURİSTİK TESİS ALANI")]
        TuristikTesis = 9,
        [Description("DİĞER TARIM")]
        Diger = 10

    }
}
