    using AdavancedSoftware.Model.Attributes;
using AdavancedSoftware.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using AdvancedSoftware.Common.Enums;
using System;

namespace AdavancedSoftware.Model.Entities
{
    public class Isyeri : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [ZorunluAlan("İşyeri Tipi", "txtIsyeriTipi")]
        public long IsyeriTipiId { get; set; }
        [ZorunluAlan("Portföy Türü", "txtPortfoyTuru")]
        public PortfoyTuru PortfoyTuru { get; set; } = PortfoyTuru.Kiralik;
        public ImarDurumu ImarDurumu { get; set; } = ImarDurumu.Sanayi;

        [Required, StringLength(350), ZorunluAlan("Başlık", "txtBaslik")]
        public string Baslik { get; set; }
        [Column(TypeName = "money")]
        public decimal Ucret { get; set; }

        public EkUcretler EkUcretler { get; set; } = EkUcretler.Yok;
        public decimal? Arsa { get; set; }

        [ZorunluAlan("Açık Alan", "txtAcikAlan")]
        public decimal AcikAlan { get; set; }
        [ZorunluAlan("Kapalı Alan", "txtKapaliAlan")]
        public decimal KapaliAlan { get; set; }
        [ZorunluAlan("İşletme Alanı", "txtIsletmeAlanı")]
        public decimal IsletmeAlani { get; set; }
        public decimal OfisAlani { get; set; }
        public int KWAEnerji { get; set; }
        public VincVarmi VincVarmi { get; set; } = VincVarmi.Hayir;
        public string VincAciklama { get; set; }
        public int Katsayisi { get; set; }
        public string M2TasimaKapasitesi { get; set; }
        public int GirisYuksekligi { get; set; }
        public int YapimYili { get; set; }
        public KiraciVarmi KiraciVarmi { get; set; } = KiraciVarmi.Hayir;
        [ZorunluAlan("Isıtma", "txtIsitma")]
        public long IsitmaId { get; set; }
        public YapininDurumu YapininDurumu { get; set; } = YapininDurumu.IkinciEl;
        public KullanimDurumu KullanimDurumu { get; set; } = KullanimDurumu.Bos;
        public KrediyeUygunluk KrediyeUygunluk { get; set; } = KrediyeUygunluk.Bilinmiyor;
        public VarYok? Takas { get; set; } = VarYok.Yok;
        public IsyeriTapuTipi IsyeriTapuTipi { get; set; } = IsyeriTapuTipi.KatIrtifaki;
        public string TasinmazNo { get; set; }
        [ZorunluAlan("İl", "txtIl")]
        public long IlId { get; set; }
        [ZorunluAlan("İlçe", "txtIlce")]
        public long IlceId { get; set; }
        [ZorunluAlan("Mahalle", "txtMahalle")]
        public long MahalleId { get; set; }
        public string BölgeAdi { get; set; }
        public int Ada { get; set; }
        public int Parsel { get; set; }

        [StringLength(5000)]
        public string Aciklama { get; set; }
        [ZorunluAlan("Danışman", "txtDanisman")]
        public long DanismanId { get; set; }
        [ZorunluAlan("Mal Sahibi", "txtMusteri")]
        public long MusteriId { get; set; }
        public IlanVarmi IlanVarmi { get; set; } = IlanVarmi.IlanYok;
        public string Sahibinden { get; set; }
        public string SahibindenLink { get; set; }
        public string HepsiEmlak { get; set; }
        public string HepsiEmlakLink { get; set; }
        public string Zingat { get; set; }
        public string ZingatLink { get; set; }
        public string BuradaYapı { get; set; }
        public string BuradaYapıLink { get; set; }
        public string DepoFabrika { get; set; }
        public string DepoFabrikaLink { get; set; }

        [Column(TypeName = "image")]
        public byte[] UyduGoruntusu { get; set; }

        [Column(TypeName = "image")]
        public byte[] OznitelikGoruntusu { get; set; }

        [Column(TypeName = "image")]
        public byte[] ImarDurumuGoruntusu { get; set; }

        [StringLength(255)]
        public string AutoCadDosyaAdi { get; set; }
        [StringLength(1000)]
        public string AutoCadDosyaYolu { get; set; }

        public PortfoyDurumu PortfoyDurumu { get; set; } = PortfoyDurumu.DevamEdiyor;
        public YetkiliOfis YetkiliOfis { get; set; } = YetkiliOfis.Hayır;

        [Column(TypeName = "date")]
        public DateTime KayitTarihi { get; set; } = DateTime.Now.Date;

        [Column(TypeName = "date")]
        public DateTime? IlanKayitTarihi { get; set; } = null;

        [Column(TypeName = "date")]
        public DateTime? IlanCikisTarihi { get; set; } = null;
        public long? OzelKod1Id { get; set; }
        public long? OzelKod2Id { get; set; }
        public long? OzelKod3Id { get; set; }
        public long? OzelKod4Id { get; set; }
        public long? OzelKod5Id { get; set; }

        public Isitma Isitma { get; set; }
        public IsyeriTipi IsyeriTipi { get; set; }
        public Il Il { get; set; }
        public Ilce Ilce { get; set; }
        public Mahalle Mahalle { get; set; }
        public Musteri Musteri { get; set; }
        public Personel Danisman { get; set; }
        public OzelKod OzelKod1 { get; set; }
        public OzelKod OzelKod2 { get; set; }
        public OzelKod OzelKod3 { get; set; }
        public OzelKod OzelKod4 { get; set; }
        public OzelKod OzelKod5 { get; set; }
    }
}
