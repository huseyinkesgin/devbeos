using AdavancedSoftware.Model.Attributes;
using AdavancedSoftware.Model.Entities.Base;
using AdvancedSoftware.Common.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdavancedSoftware.Model.Entities
{
    public class HizmetTuru : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Hizmet Türü Adı", "txtHizmetTuruAdi")]
        public string HizmetTuruAdi { get; set; }

      
        //public HizmetTipi HizmetTipi { get; set; } = HizmetTipi.Telefon;

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
