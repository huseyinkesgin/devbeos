using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum OdemeTipi : byte
    {
        [Description("Nakit")]
        Nakit = 1,
        [Description("Kredi Kartı")]
        KrediKarti = 2,
        [Description("Çek")]
        Cek = 3,
        [Description("Senet")]
        Senet = 4,
        [Description("Havale/EFT")]
        HavaleEFT = 5,
        [Description("Diğer")]
        Diger = 6
    }
}
