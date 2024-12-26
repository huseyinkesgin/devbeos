using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum IsyeriTuru : byte
    {
        [Description("Fabrika")]
        Fabrika = 1,
        [Description("Depo")]
        Depo = 2,
        [Description("Dükkan")]
        Dukkan = 3,
        [Description("Ofis")]
        Ofis = 4,
        [Description("Mağaza")]
        Magaza = 5,
        [Description("Diğer")]
        Diger = 6
    }
}
