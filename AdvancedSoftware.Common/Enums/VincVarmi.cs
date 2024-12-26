using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum VincVarmi : byte
    {
        [Description("Evet")]
        Evet = 1,
        [Description("Hayır")]
        Hayir = 2,
        [Description("Bilinmiyor")]
        Bilinmiyor = 3
    }
}
