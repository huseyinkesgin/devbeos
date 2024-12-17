using AdavancedSoftware.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdavancedSoftware.Model.Attributes;

namespace AdavancedSoftware.Model.Entities
{
    public class Ofis : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Ofis Adı", "txtOfisAdi")]
        public string OfisAdi { get; set; }

        [Required, StringLength(20)]
        public string Telefon { get; set; }

        [Required, StringLength(70)]
        public string Eposta { get; set; }

        [ZorunluAlan("İl", "txtIl")]
        public long IlId { get; set; }

        [ZorunluAlan("İlçe", "txtIlce")]
        public long IlceId { get; set; }

        [StringLength(150)]
        public string Adres { get; set; }

        public Il Il { get; set; }
        public Ilce Ilce { get; set; }
    }
}
