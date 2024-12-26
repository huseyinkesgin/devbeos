using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum YapininDurumu : byte
    {
        [Description("Sıfır")]
        Sifir = 0,
        [Description("İkinci El")]
        IkinciEl = 1,
        [Description("İnşaat Halinde")]
        InsaHalinde = 2,
    }
}
