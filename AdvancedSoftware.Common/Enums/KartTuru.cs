using System.ComponentModel;

namespace AdvancedSoftware.Common.Enums
{
    public enum KartTuru: byte
    {
        [Description("İl Kaydı")]
        Il = 1,

        [Description("İlçe Kaydı")]
        Ilce = 2,

        [Description("Ofis Kaydı")]
        Ofis = 3,

        [Description("Portföy Kategori Kaydı")]
        PortfoyKategori = 4,

        [Description("Portföy Alt Kaydı")]
        PortfoyAltKategori = 5,

        [Description("Filtre Kartı")]
        Filtre = 6,

        [Description("Müşteri Bilgi Kartı")]
        MusteriBilgi = 7,

        [Description("İptal Nedeni Kartı")]
        IptalNedeni = 8,

        [Description("Tapu Tipi Kartı")]
        TapuTipi = 9,

        [Description("Portföy Tipi Kartı")]
        PortfoyTipi = 10,

        [Description("İşyeri Tipi Kartı")]
        IsyeriTipi = 11,

        [Description("İmar Durumu Kartı")]
        ImarDurumu = 12,

        [Description("Emsal Kartı")]
        Emsal = 13,

        [Description("Gabari Kartı")]
        Gabari = 14,

        [Description("Isıtma Kartı")]
        Isitma = 15,

        [Description("Müşteri Grup Kartı")]
        MusteriGrup = 16,

        [Description("Unvan Kartı")]
        Unvan = 17,

        [Description("Altyapı Kartı")]
        Altyapi = 18,

        [Description("Departman Kartı")]
        Departman = 19,


    }
}
