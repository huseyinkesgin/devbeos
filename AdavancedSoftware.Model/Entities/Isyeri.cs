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

        public long PortfoyTipiId { get; set; }
        public IsyeriTuru IsyeriTuru { get; set; } = IsyeriTuru.Fabrika;

        [Required, StringLength(350), ZorunluAlan("Başlık", "txtIlAdi")]
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
        public long TapuTipiId { get; set; }
        public int TasinmazNo { get; set; }
        public long IlId { get; set; }
        public long IlceId { get; set; }
        public string Mahalle { get; set; }
        public int Ada { get; set; }
        public int Parsel { get; set; }

        [StringLength(5000)]
        public string Aciklama { get; set; }
        public Danisman Danisman { get; set; } = Danisman.NedimAkbacak;
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

        public Isitma Isitma { get; set; }
        public PortfoyTipi PortfoyTipi { get; set; }
        public TapuTipi TapuTipi { get; set; }
        public Il Il { get; set; }
        public Ilce Ilce { get; set; }
        public Musteri Musteri { get; set; }
    }
}
