using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum ArsaTapuTipi :byte
    {
        [Description("MÜSTAKİL PARSEL")]
        MustakilParsel = 1,
        [Description("HİSSELİ")]
        Hisseli = 2,
        [Description("TAHSİS")]
        Tahsis = 3,
        [Description("DİĞER")]
        Diger = 4
    }
}
