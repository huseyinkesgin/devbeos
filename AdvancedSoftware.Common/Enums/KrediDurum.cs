using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum KrediDurum : byte
    {
        [Description("Uygun")]
        Uygun = 1,

        [Description("Uygun Değil")]
        UygunDegil = 2,

        [Description("Bilinmiyor")]
        Bilinmiyor = 3
    }
}
