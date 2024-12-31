using AdavancedSoftware.Model.Attributes;
using AdavancedSoftware.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AdavancedSoftware.Model.Entities
{
    public class AracSinif : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Araç Sınıf Adı", "txtAracSinifAdi")]
        public string AracSinifAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
