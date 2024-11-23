using AdavancedSoftware.Model.Entities.Base;
using AdavancedSoftware.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdavancedSoftware.Model.Dto
{
    [NotMapped]
    public class OfisS : Ofis
    {
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
    }

    public class OfisL : BaseEntity
    {
        public string OfisAdi { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string Adres { get; set; }

    }
}
