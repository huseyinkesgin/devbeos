using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum ImarDurumu : byte
    {
        [Description("Sanayi İmarlı")]
        SanayiImarli = 1,

        [Description("Konut İmarlı")]
        KonutImarli = 2,

        [Description("Ticari İmarlı")]
        TicariImarli = 3,

        [Description("Konut + Ticari İmarlı")]
        KonutTicariImarli = 4,

        [Description("Depolama İmarlı")]
        DepolamaImarlı = 5,

        [Description("Tarla")]
        Tarla = 6,

        [Description("Villa")]
        Villa = 7,

        [Description("Diğer Tarım")]
        DigerTarim = 8,



    }
}
