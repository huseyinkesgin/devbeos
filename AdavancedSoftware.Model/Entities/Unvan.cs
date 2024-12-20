using AdavancedSoftware.Model.Attributes;
using AdavancedSoftware.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AdavancedSoftware.Model.Entities
{
    public class Unvan : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Ünvan Adı", "txtUnvanAdi")]
        public string UnvanAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
