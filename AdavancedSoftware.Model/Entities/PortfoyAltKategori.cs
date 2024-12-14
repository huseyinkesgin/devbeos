using AdavancedSoftware.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdavancedSoftware.Model.Entities
{
    public class PortfoyAltKategori : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(50)]
        public string AltKategoriAdi { get; set; }

        public long PortfoyKategoriId { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        public PortfoyKategori PortfoyKategori { get; set; }
    }
}
