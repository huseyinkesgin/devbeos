using AdavancedSoftware.Model.Attributes;
using AdavancedSoftware.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AdavancedSoftware.Model.Entities
{
    public class MusteriGrup : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Musteri Grup", "txtMusteriGrubu")]
        public string MusteriGrubu { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
