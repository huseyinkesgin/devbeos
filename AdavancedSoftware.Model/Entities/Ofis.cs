using AdavancedSoftware.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdavancedSoftware.Model.Entities
{
    public class Ofis : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50)]
        public string OfisAdi { get; set; }

        [Required, StringLength(20)]
        public string Telefon { get; set; }

        [Required, StringLength(70)]
        public string Eposta { get; set; }

        public long? IlId { get; set; }
        public long? IlceId { get; set; }

        [Required, StringLength(150)]
        public string Adres { get; set; }

        public Il Il { get; set; }
        public Ilce Ilce { get; set; }
    }
}
