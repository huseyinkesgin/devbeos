using AdavancedSoftware.Model.Attributes;
using AdavancedSoftware.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdavancedSoftware.Model.Entities
{
    public class MusterininHizmetleri : BaseHareketEntity
    {

        public long MusteriId { get; set; }
        public long HizmetId { get; set; }
        [ZorunluAlan("Hizmet Türü", "txtHizmetTuru")]
        public long HizmetTuruId { get; set; }

        [Column(TypeName = "date")]
        public DateTime HizmetBaslangic { get; set; } = DateTime.Now;

        [Column(TypeName = "date")]
        public DateTime HizmetBitis { get; set; } = DateTime.Now;
        public string Aciklama { get; set; }

        public Musteri Musteri { get; set; }
        public Hizmet Hizmet { get; set; }

    }
}
