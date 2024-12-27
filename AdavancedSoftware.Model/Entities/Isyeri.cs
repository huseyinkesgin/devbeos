using AdavancedSoftware.Model.Attributes;
using AdavancedSoftware.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using AdvancedSoftware.Common.Enums;

namespace AdavancedSoftware.Model.Entities
{
    public class Isyeri : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        public long IsyeriTipiId { get; set; }
        public PortfoyTuru PortfoyTuru { get; set; } = PortfoyTuru.Kiralik;
        public ImarDurumu ImarDurumu { get; set; } = ImarDurumu.Sanayi;

        [Required, StringLength(350), ZorunluAlan("Başlık", "txtBaslik")]
        public string Baslik { get; set; }
        [Column(TypeName = "money")]
        public decimal Ucret { get; set; }

        public decimal AcikAlan { get; set; }
        public decimal KapaliAlan { get; set; }
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
        public long IsitmaId { get; set; }
        public YapininDurumu YapininDurumu { get; set; } = YapininDurumu.IkinciEl;
        public KullanimDurumu KullanimDurumu { get; set; } = KullanimDurumu.Bos;
        public KrediyeUygunluk KrediyeUygunluk { get; set; } = KrediyeUygunluk.Bilinmiyor;
        public IsyeriTapuTipi IsyeriTapuTipi { get; set; } = IsyeriTapuTipi.KatIrtifaki;
        public int TasinmazNo { get; set; }
        public long IlId { get; set; }
        public long IlceId { get; set; }
        public string Mahalle { get; set; }
        public int Ada { get; set; }
        public int Parsel { get; set; }

        [StringLength(5000)]
        public string Aciklama { get; set; }
        public long DanismanId { get; set; }
        public long MusteriId { get; set; }
        public IlanVarmi IlanVarmi { get; set; } = IlanVarmi.IlanVar;
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
        public long? OzelKod1Id { get; set; }
        public long? OzelKod2Id { get; set; }
        public long? OzelKod3Id { get; set; }
        public long? OzelKod4Id { get; set; }
        public long? OzelKod5Id { get; set; }

        public Isitma Isitma { get; set; }
        public IsyeriTipi IsyeriTipi { get; set; }
        public Il Il { get; set; }
        public Ilce Ilce { get; set; }
        public Musteri Musteri { get; set; }
        public Personel Danisman { get; set; }
        public OzelKod OzelKod1 { get; set; }
        public OzelKod OzelKod2 { get; set; }
        public OzelKod OzelKod3 { get; set; }
        public OzelKod OzelKod4 { get; set; }
        public OzelKod OzelKod5 { get; set; }
    }
}
