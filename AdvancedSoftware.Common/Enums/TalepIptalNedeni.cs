using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum TalepIptalNedeni : byte
    {
        [Description("Müşteri İsteği")]
        MusteriIstegi = 1,

        [Description("Bütçe Yetersizliği")]
        ButceYetersizligi = 2,

        [Description("Zaman Kısıtı")]
        ZamanKisiti = 3,

        [Description("Teknical Sorunlar")]
        TeknicalSorunlar = 4,

        [Description("Yasal Engeller")]
        YasalEngeller = 5,

        [Description("Kaynak Yetersizliği")]
        KaynakYetersizligi = 6,

        [Description("Proje Değişikliği")]
        ProjeVersionisikligi = 7,

        [Description("Üst Yönetim Kararı")]
        UstYonetimKarari = 8,

        [Description("Pazar Koşulları")]
        PazarKosullari = 9,

        [Description("Rekabet Analizi")]
        RekabetAnalizi = 10,

        [Description("Stratejik Değişiklik")]
        StratejikDegisiklik = 11,

        [Description("Diğer")]
        Diger = 12
    }
}
