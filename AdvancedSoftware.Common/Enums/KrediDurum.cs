using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum KrediDurum : byte
    {
        [Description("UYGUN")]
        Uygun = 1,

        [Description("UYGUN DEĞİL")]
        UygunDegil = 2,

        [Description("BİLİNMİYOR")]
        Bilinmiyor = 3
    }
}
