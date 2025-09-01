using AdavancedSoftware.Model.Attributes;
using AdavancedSoftware.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdavancedSoftware.Model.Entities
{
    public class Indirim : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(100), ZorunluAlan("İndirim Adı", "txtIndirimAdi")]
        public string IndirimAdi { get; set; }

        [ZorunluAlan("İndirim Türü", "txt;IndirimTuru")]
        public long IndirimTuruId { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
        public long SubeId { get; set; }


        public IndirimTuru IndirimTuru { get; set; }
        public Sube Sube { get; set; }

        [InverseProperty("Indirim")]
        public ICollection<IndiriminUygulanacagiHizmetBilgileri> IndiriminUygulanacagiHizmetBilgileri { get; set; }
    }
}
