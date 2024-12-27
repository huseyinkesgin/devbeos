using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum IsyeriTapuTipi : byte
    {
        [Description("KAT MÜLKİYETİ")]
        KatMulkiyeti = 1,
        [Description("KAT İRTİFAKI")]
        KatIrtifaki = 2,
        [Description("MÜSTAKİL TAPU")]
        MustakilTapu = 3,
        [Description("TAHSİSLİ TAPU")]
        TahsisliTapu = 4,
        [Description("ZİLLİYET")]
        Zilyetlik = 5,
        [Description("DİĞER")]
        Diger = 6
    }
}
