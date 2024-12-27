using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum PersonelDurumu : byte
    {
        [Description("ÇALIŞIYOR")]
        Calisiyor = 1,
        [Description("İZİNDE")]
        Izinde = 2,
        [Description("İŞTEN AYRILDI")]
        İstenAyrildi = 3,
    }
}
