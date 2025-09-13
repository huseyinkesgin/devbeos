using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum TalepDurumu : byte
    {
        [Description("Yeni Talep")]
        YeniTalep = 1,

        [Description("İnceleniyor")]
        Inceleniyor = 2,

        [Description("Değerlendiriliyor")]
        Degerlendiriliyor = 3,

        [Description("Teklif Hazırlanıyor")]
        TeklifHazirlaniyor = 4,

        [Description("Teklif Sunuldu")]
        TeklifSunuldu = 5,

        [Description("Müzakere Ediliyor")]
        MuzakereEdiliyor = 6,

        [Description("Onaylandı")]
        Onaylandi = 7,

        [Description("Reddedildi")]
        Reddedildi = 8,

        [Description("İptal Edildi")]
        IptalEdildi = 9,

        [Description("Tamamlandı")]
        Tamamlandi = 10
    }
}
