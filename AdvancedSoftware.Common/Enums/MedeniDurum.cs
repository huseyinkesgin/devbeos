using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum MedeniDurum : byte
    {
        [Description("EVLİ")]
        Evli = 1,
        [Description("BEKAR")]
        Bekar = 2,
        [Description("BOŞANMIŞ")]
        Bosanmis = 3
    }
}
