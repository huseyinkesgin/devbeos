using AdavancedSoftware.Model.Attributes;
using AdavancedSoftware.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdavancedSoftware.Model.Entities
{
    public class Model : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique =false)]
        public override string Kod { get; set; }

        public long MarkaId { get; set; }


        [Required,StringLength(50), ZorunluAlan("Model Adı", "txtModelAdi")]
        public string ModelAdi { get; set; }
        

        [StringLength(500)]
        public string Aciklama { get; set; }

        public Marka Marka { get; set; }
    }
}
