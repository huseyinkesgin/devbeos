using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum KullanimDurumu : byte
    {
        [Description("BOŞ")]
        Bos =1,
        [Description("KİRACI OTURUYOR")]
        KiraciOturuyor = 2,
        [Description("MÜLK SAHİBİ OTURUYOR")]
        MulkSahibiOturuyor = 3,
    }
}
