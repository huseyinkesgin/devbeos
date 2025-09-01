using AdavancedSoftware.Model.Attributes;
using AdavancedSoftware.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdavancedSoftware.Model.Entities
{
    public class Marka : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Marka Adı", "txtIlAdi")]
        public string MarkaAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        [InverseProperty("Marka")]
        public ICollection<Model> Model { get; set; }
    }
}
