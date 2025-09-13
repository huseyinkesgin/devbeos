using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum OncelikSeviyesi : byte
    {
        [Description("Düşük")]
        Dusuk = 1,

        [Description("Normal")]
        Normal = 2,

        [Description("Yüksek")]
        Yuksek = 3,

        [Description("Acil")]
        Acil = 4,

        [Description("Kritik")]
        Kritik = 5
    }
}
