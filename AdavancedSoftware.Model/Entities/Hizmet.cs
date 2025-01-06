using AdavancedSoftware.Model.Attributes;
using AdavancedSoftware.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdavancedSoftware.Model.Entities
{
    public class Hizmet : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Hizmet Adı", "txtHizmetAdi")]
        public string HizmetAdi { get; set; }

        [ZorunluAlan("Hizmet Türü", "txtHizmetTuru")]
        public long HizmetTuruId { get; set; }

        [Column(TypeName = "date")]
        public DateTime BaslangicTarihi { get; set; } = DateTime.Now;

        [Column(TypeName = "date")]
        public DateTime BitisTarihi { get; set; } = DateTime.Now;

        [Column(TypeName = "money")]
        public decimal Ucret { get; set; } = 0;

        [StringLength(500)]
        public string Aciklama { get; set; }

        public  long SubeId { get; set; }

        public HizmetTuru HizmetTuru { get; set; }
        public Sube Sube { get; set; }
    }
}
