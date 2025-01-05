using AdavancedSoftware.Model.Attributes;
using AdavancedSoftware.Model.Entities.Base;
using AdvancedSoftware.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdavancedSoftware.Model.Entities
{
    public class Portfoy : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        public string PortfoyNo { get; set; }

        public long IlId { get; set; }

        public long IlceId { get; set; }
        public long MahalleId { get; set; }

        public ImarDurumu ImarDurumu { get; set; } = ImarDurumu.Sanayi;

        public PortfoyTuru PortfoyTuru { get; set; } = PortfoyTuru.Kiralik;

        [ZorunluAlan("Portföy Tipi", "txtPortfoyTipi")]
        public long PortfoyTipiId { get; set; }

        [Column(TypeName = "money")]
        public decimal Ucret { get; set; }
        public decimal M2 { get; set; }
        public int Ada { get; set; }
        public int Parsel { get; set; }
        public long DanismanId { get; set; }
        [ZorunluAlan("Mal Sahibi", "txtMusteri")]
        public long MusteriId { get; set; }
        public PortfoyDurumu PortfoyDurumu { get; set; } = PortfoyDurumu.DevamEdiyor;
        public YetkiliOfis YetkiliOfis { get; set; } = YetkiliOfis.Hayır;
        [Column(TypeName = "date")]
        public DateTime KayitTarihi { get; set; } = DateTime.Now.Date;

        public long? OzelKod1Id { get; set; }
        public long? OzelKod2Id { get; set; }
        public long? OzelKod3Id { get; set; }
        public long? OzelKod4Id { get; set; }
        public long? OzelKod5Id { get; set; }


        public PortfoyTipi PortfoyTipi  { get; set; }
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
