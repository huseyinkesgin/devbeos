using AdavancedSoftware.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AdvancedSoftware.Common.Enums;
using AdavancedSoftware.Model.Attributes;

namespace AdavancedSoftware.Model.Entities
{
    public class Kategori : BaseEntityDurum
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
