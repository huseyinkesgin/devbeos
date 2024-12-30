using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum BelgeTuru : byte
    {
        [Description("FİŞ")]
        Fis = 1,
        [Description("FATURA")]
        Fatura = 2,
        [Description("MAKBUZ")]
        Makbuz = 3,
        [Description("DİĞER")]
        Diger = 4
    }
}
