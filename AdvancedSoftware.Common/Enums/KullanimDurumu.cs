using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum KullanimDurumu : byte
    {
        [Description("Boş")]
        Bos =1,
        [Description("Kiracı Oturuyor")]
        KiraciOturuyor = 2,
        [Description("Mülk Sahibi Oturuyor")]
        MulkSahibiOturuyor = 3,
    }
}
