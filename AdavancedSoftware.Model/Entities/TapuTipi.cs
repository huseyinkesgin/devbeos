using AdavancedSoftware.Model.Attributes;
using AdavancedSoftware.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdavancedSoftware.Model.Entities
{
    public class TapuTipi : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        public long PortfoyTipiId { get; set; }

        [Required, StringLength(50), ZorunluAlan("Tapu Tipi Adı", "txtTapuTipiAdi")]
        public string TapuTipiAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        public PortfoyTipi PortfoyTipi { get; set; }
    }
}
