using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum TalepTuru : byte
    {
        [Description("Gayrimenkul Satış")]
        GayrimenkulSatis = 1,

        [Description("Gayrimenkul Kiralama")]
        GayrimenkulKiralama = 2,

        [Description("Arsa Satış")]
        ArsaSatis = 3,

        [Description("Arsa Kiralama")]
        ArsaKiralama = 4,

        [Description("İşyeri Satış")]
        IsyeriSatis = 5,

        [Description("İşyeri Kiralama")]
        IsyeriKiralama = 6,

        [Description("Değerleme")]
        Degerleme = 7,

        [Description("Ekspertiz")]
        Ekspertiz = 8,

        [Description("Danışmanlık")]
        Danismanlik = 9,

        [Description("Proje Yönetimi")]
        ProjeYonetimi = 10,

        [Description("Gayrimenkul Değerlendirme")]
        GayrimenkulDegerlendirme = 11,

        [Description("Diğer")]
        Diger = 99
    }
}
