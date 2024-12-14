using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdavancedSoftware.Model.Entities.Base;

namespace AdavancedSoftware.Model.Entities
{
    public class Personel : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50)]
        public string AdiSoyadi { get; set; }

        [Required, StringLength(20)]
        public string Telefon { get; set; }

        [Required, StringLength(70)]
        public string Eposta { get; set; }

        [Required, StringLength(11)]
        public string TcKimlik { get; set; }

        public long? IlId { get; set; }
        public long? IlceId { get; set; }

        [Required, StringLength(150)]
        public string Adres { get; set; }

        public Il Il { get; set; }
        public Ilce Ilce { get; set; }
    }
}

