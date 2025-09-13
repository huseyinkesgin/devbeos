using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum RedNedeni : byte
    {
        [Description("Fiyat Uyumsuzluğu")]
        FiyatUyumsuzlugu = 1,

        [Description("Kalite Yetersizliği")]
        KaliteYetersizligi = 2,

        [Description("Teslimat Süresi")]
        TeslimatSuresi = 3,

        [Description("Teknik Spesifikasyon")]
        TeknikSpesifikasyon = 4,

        [Description("Referans Yetersizliği")]
        ReferansYetersizligi = 5,

        [Description("Mali Durum")]
        MaliDurum = 6,

        [Description("Kapasite Yetersizliği")]
        KapasiteYetersizligi = 7,

        [Description("Coğrafi Konum")]
        CografiKonum = 8,

        [Description("Sertifika Eksikliği")]
        SertifikaEksikligi = 9,

        [Description("İletişim Sorunu")]
        IletisimSorunu = 10,

        [Description("Önceki Deneyim")]
        OncekiDeneyim = 11,

        [Description("Yasal Uyumsuzluk")]
        YasalUyumsuzluk = 12,

        [Description("Stratejik Uyumsuzluk")]
        StratejikUyumsuzluk = 13,

        [Description("Güvenlik Sorunu")]
        GuvenlikSorunu = 14,

        [Description("Diğer")]
        Diger = 15
    }
}
