using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum Unvan : byte
    {
        [Description("Broker")]
        Broker = 1,

        [Description("Danışman")]
        Danisman = 2,

        [Description("Bilgi İşlem")]
        BilgiIslem = 3,

        [Description("Mutfak Sorumlusu")]
        MutfakSorumlusu = 4,

        [Description("Banko")]
        Banko = 5,

    }
}
