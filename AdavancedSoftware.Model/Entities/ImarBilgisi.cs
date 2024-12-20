using AdavancedSoftware.Model.Attributes;
using AdavancedSoftware.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdavancedSoftware.Model.Entities
{
    public class ImarBilgisi : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("İmar Bilgisi Adı", "txtImarDurumuAdi")]
        public string ImarBilgisiAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
