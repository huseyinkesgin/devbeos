using AdavancedSoftware.Model.Attributes;
using AdavancedSoftware.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdavancedSoftware.Model.Entities
{
    public class Emsal : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required,StringLength(50),ZorunluAlan("Emsal","txtEmsalAdi")]
        public string EmsalAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
