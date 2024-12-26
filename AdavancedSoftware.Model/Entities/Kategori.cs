using AdavancedSoftware.Model.Attributes;
using AdavancedSoftware.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using AdvancedSoftware.Common.Enums;

namespace AdavancedSoftware.Model.Entities
{
    public class Kategori : BaseEntity
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Kategori Adı", "txtKategoriAdi")]
        public string KategoriAdi { get; set; }

        [Required]
        public KategoriTuru KategoriTuru { get; set; }

        [Required]
        public KartTuru KartTuru { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
