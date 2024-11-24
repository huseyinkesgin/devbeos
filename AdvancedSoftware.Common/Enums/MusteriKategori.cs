using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum MusteriKategori : byte
    {
        [Description("Mal Sahibi")]
        MalSahibi = 1,

        [Description("Alıcı")]
        Alici = 2,

        [Description("Emlakçı")]
        Emlakci = 3,

        [Description("Partner")]
        Partner = 4,

        [Description("Diğer")]
        Diger = 5
    }
}
