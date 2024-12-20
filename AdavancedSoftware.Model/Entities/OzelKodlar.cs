using AdavancedSoftware.Model.Attributes;
using AdavancedSoftware.Model.Entities.Base;
using AdvancedSoftware.Common.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdavancedSoftware.Model.Entities
{
    public class OzelKodlar : BaseEntity
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Özel Kod Adı", "txtOzelKodAdi")]
        public string OzelKodAdi { get; set; }

        [Required]
        public OzelKodTuru KodTuru { get; set; }

        [Required]
        public KartTuru KartTuru { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
