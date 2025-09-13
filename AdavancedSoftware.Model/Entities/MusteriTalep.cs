using AdavancedSoftware.Model.Attributes;
using AdavancedSoftware.Model.Entities.Base;
using AdvancedSoftware.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdavancedSoftware.Model.Entities
{
    public class MusteriTalep : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(100), ZorunluAlan("Talep Başlığı", "txtTalepBasligi")]
        public string TalepBasligi { get; set; }

        [ZorunluAlan("Müşteri", "txtMusteri")]
        public long MusteriId { get; set; }

        [ZorunluAlan("Talep Türü", "txtTalepTuru")]
        public TalepTuru TalepTuru { get; set; } = TalepTuru.GayrimenkulSatis;

        public TalepDurumu TalepDurumu { get; set; } = TalepDurumu.YeniTalep;

        public OncelikSeviyesi OncelikSeviyesi { get; set; } = OncelikSeviyesi.Normal;

        [Column(TypeName = "date")]
        public DateTime TalepTarihi { get; set; } = DateTime.Now.Date;

        [Column(TypeName = "date")]
        public DateTime? TalepEdilecekTarih { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TamamlanmaTarihi { get; set; }

        [ZorunluAlan("Sorumlu Personel", "txtSorumluPersonel")]
        public long SorumluPersonelId { get; set; }

        // Lokasyon Bilgileri (İsteğe bağlı - talep edilen gayrimenkul için)
        public long? IlId { get; set; }
        public long? IlceId { get; set; }
        public long? MahalleId { get; set; }
        public string Adres { get; set; }

        // Portföy ile ilişki (eğer mevcut portföyden talep ise)
        public long? PortfoyId { get; set; }

        // Hizmet ile ilişki (eğer hizmet talebi ise)
        public long? HizmetId { get; set; }

        // Bütçe Bilgileri
        [Column(TypeName = "money")]
        public decimal? MinBütce { get; set; }

        [Column(TypeName = "money")]
        public decimal? MaxBütce { get; set; }

        [Column(TypeName = "money")]
        public decimal? TeklifTutari { get; set; }

        // Metrekare Bilgileri
        public decimal? MinMetrekare { get; set; }
        public decimal? MaxMetrekare { get; set; }

        // Talep Detayları
        [StringLength(1000)]
        public string TalepDetayi { get; set; }

        [StringLength(500)]
        public string MusteriNotlari { get; set; }

        [StringLength(500)]
        public string PersonelNotlari { get; set; }

        public RedNedeni? RedNedeni { get; set; }

        public TalepIptalNedeni? IptalNedeni { get; set; }

        // Özel Kodlar
        public long? OzelKod1Id { get; set; }
        public long? OzelKod2Id { get; set; }
        public long? OzelKod3Id { get; set; }

        // Navigation Properties
        public Musteri Musteri { get; set; }
        public Personel SorumluPersonel { get; set; }
        public Il Il { get; set; }
        public Ilce Ilce { get; set; }
        public Mahalle Mahalle { get; set; }
        public Portfoy Portfoy { get; set; }
        public Hizmet Hizmet { get; set; }
        public OzelKod OzelKod1 { get; set; }
        public OzelKod OzelKod2 { get; set; }
        public OzelKod OzelKod3 { get; set; }
    }
}
