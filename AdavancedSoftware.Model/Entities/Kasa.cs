using AdavancedSoftware.Model.Attributes;
using AdavancedSoftware.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AdavancedSoftware.Model.Entities
{
    public class Kasa : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Kasa Adı", "txtKasaAdi")]
        public string KasaAdi { get; set; }

        public long? OzelKod1 { get; set; }
        public long? OzelKod2 { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
        public long SubeID { get; set; }
        public long DonemId { get;set; }

        public OzelKodlar OzelKodlar1 { get; set; }
        public OzelKodlar OzelKodlar2 { get; set; }

        public Sube Sube { get; set; }
        public Donem Donem { get; set; }

    }
}
